using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Internet;

namespace Utils.Tests
{
    public class FTPTest
    {

        public void UploadTest()
        {
            var ftpClient = new FTP("ftp.progressband.pl", 21, "pband", "yaya2000");
            ftpClient.Connect();
            ftpClient.ChangeDir("domains/progressband.pl/public_html/modules/payroll/");
            if (ftpClient.IsConnected)
            {
                //ftpClient.OpenUpload("route.html", new MemoryStream(, false), false);
                while (ftpClient.DoUpload() > 0) ;
            }
        }

    }
}
