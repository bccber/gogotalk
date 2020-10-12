using System;

namespace GoGoTalk.Network
{
    public  class MessageBuffer
    {
        // 命令ID
        public Int32 CMD { get; set; }

        // 数据包
        public Byte[] Buffer { get; set; }

        public MessageBuffer(Int32 cmd, Byte[] buffer)
        {
            CMD = cmd;
            Buffer = buffer;
        }
    }
}
