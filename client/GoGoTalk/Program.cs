using GoGoTalk.Network;
using System;
using System.Windows.Forms;

namespace GoGoTalk
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TCPClient.Singleton.Connect();
            TCPClient.Singleton.Start();

            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
