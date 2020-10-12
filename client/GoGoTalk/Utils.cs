using System;
using System.IO;
using System.Net;

namespace GoGoTalk
{
    public static class Utils
    {
        public static void DownFile(String url, String saveFile)
        {
            try
            {
                if (String.IsNullOrEmpty(url) || String.IsNullOrEmpty(saveFile))
                {
                    return;
                }

                String savePath = Path.GetDirectoryName(saveFile);
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, saveFile);
                }
            }
            catch
            {
            }
        }
    }
}
