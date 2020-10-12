using Google.Protobuf;
using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace GoGoTalk.Network
{
    public sealed class TCPClient : IDisposable
    {
        /// <summary>
        /// 单例
        /// </summary>
        public static TCPClient Singleton = new TCPClient(GlobalResourceManager.ServerIP, GlobalResourceManager.ServerPort);

        private TcpClient _Client;

        /// <summary>
        /// 消息队列
        /// </summary>
        private ConcurrentQueue<MessageBuffer> _Queue = new ConcurrentQueue<MessageBuffer>();

        /// <summary>
        /// 远程地址
        /// </summary>
        private IPEndPoint _RemoteEndPoint { get; set; }

        /// <summary>
        /// 是否运行
        /// </summary>
        private Boolean _IsAction {get; set;}

        private TCPClient()
        {
        }

        public TCPClient(String server, Int32 port)
        {
            if (String.IsNullOrEmpty(server) || port <= 0)
            {
                throw new ArgumentNullException("RemoteEndPoint error");
            }

            _RemoteEndPoint = new IPEndPoint(IPAddress.Parse(server), port);
        }

        /// <summary>
        /// 连接
        /// </summary>
        /// <returns></returns>
        public Boolean Connect()
        {
            try
            {
                _Client = new TcpClient(_RemoteEndPoint.AddressFamily);
                _Client.Connect(_RemoteEndPoint);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }

        /// <summary>
        /// 启动
        /// </summary>
        public void Start()
        {
            try
            {
                if (_Client.Client.Connected)
                {
                    _IsAction = true;
                    ThreadPool.QueueUserWorkItem(ReceiveThread, null);
                    ThreadPool.QueueUserWorkItem(DealQueueThread, null);
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 接收消息线程
        /// </summary>
        /// <param name="state"></param>
        private void ReceiveThread(Object state)
        {
            NetworkStream networkStream = _Client.GetStream();

            // 4个字节的长度 4个字节的id
            Byte[] headBuffer = new Byte[4];

            while (_IsAction)
            {
                try
                {
                    if (_Client.Client == null || !_Client.Client.Connected)
                    {
                        Close();
                        Connect();
                        networkStream = _Client.GetStream();

                        continue;
                    }

                    // 4个字节的长度
                    networkStream.Read(headBuffer, 0, 4);
                    Int32 len = BitConverter.ToInt32(headBuffer, 0);

                    // 4个字节的id
                    networkStream.Read(headBuffer, 0, 4);
                    Int32 cmd = BitConverter.ToInt32(headBuffer, 0);

                    Byte[] buffer = new Byte[len];
                    Int32 total = 0;
                    while (total < len)
                    {
                        total += networkStream.Read(buffer, 0, len);
                    }

                    if (total == len)
                    {
                        _Queue.Enqueue(new MessageBuffer(cmd, buffer));
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    Thread.Sleep(1);
                }
            }
        }

        /// <summary>
        /// 处理消息线程
        /// </summary>
        /// <param name="state"></param>
        private void DealQueueThread(Object state)
        {
            while (_IsAction)
            {
                try
                {
                    while (!_Queue.IsEmpty)
                    {
                        if (!_Queue.TryDequeue(out var msgBuf) || msgBuf.Buffer == null || msgBuf.Buffer.Length < 2)
                        {
                            continue;
                        }

                        ProtocolDecoder.Singleton.Decode(msgBuf);
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    Thread.Sleep(1);
                }
            }
        }

        /// <summary>
        /// 发送protobuf对象
        /// </summary>
        /// <param name="cmd">命令号</param>
        /// <param name="sendMessage">protobuf对象</param>
        /// <returns>已发送长度</returns>
        public Int32 SendProtoMessage(Int32 cmd, IMessage message)
        {
            try
            {
                if (_Client.Client == null || !_Client.Client.Connected)
                {
                    Close();
                    Connect();
                }

                // 组装发送数据
                int sendLen = message.CalculateSize();
                var sendBuffer = new Byte[8 + sendLen];

                // 4个字节的包长
                var headBuffer = BitConverter.GetBytes(sendLen);     
                Buffer.BlockCopy(headBuffer, 0, sendBuffer, 0, headBuffer.Length);

                // 4个字节的CMDID
                headBuffer = BitConverter.GetBytes((Int32)cmd);
                Buffer.BlockCopy(headBuffer, 0, sendBuffer, 4, headBuffer.Length);

                // 数据体
                var buffer = new Byte[sendLen];
                using (CodedOutputStream cos = new CodedOutputStream(buffer))
                {
                    message.WriteTo(cos);
                }
                Buffer.BlockCopy(buffer, 0, sendBuffer, 8, sendLen);

                // 发包
                Int32 sendOKLen = _Client.Client.Send(sendBuffer);

                return sendOKLen;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public void Close()
        {
            if (_Client != null)
            {
                _Client.Close();
                _Client.Dispose();
            }
        }

        public void Dispose()
        {
            Close();
            _IsAction = true;
        }
    }
}