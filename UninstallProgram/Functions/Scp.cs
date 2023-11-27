using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;


namespace UninstallProgram.Functions
{
    internal class Scp
    {
        private string hostname;
        private string username;
        public Scp() {
            this.hostname = "192.168.1.13";
            this.username = "kali";
    }
        public Scp(string ipdomain, string name) 
        {
            this.hostname = ipdomain;
            this.username = name;
        }

        public void Copy(string keypath, string filetoCopy)
        {
            string publicKeyPath = keypath;
            var publicKey = new PrivateKeyFile(publicKeyPath);
            var connectionInfo = new ConnectionInfo(hostname, username, new PrivateKeyAuthenticationMethod(username, publicKey));

            using (var client = new SshClient(connectionInfo))
            {
                client.Connect();

                // Tạo một đối tượng SCP để truyền tải tệp tin
                using (var scp = new ScpClient(connectionInfo))
                {
                    scp.Connect();

                    string localFilepath = filetoCopy;
                    string fileName = Path.GetFileName(localFilepath);
                    string remoteFilepath = @"/home/tcm/" + fileName; // Thay đổi đường dẫn trên máy chủ

                    // Upload tệp tin từ máy tính cục bộ lên máy chủ từ xa
                    UploadFile(scp, localFilepath, remoteFilepath);

                    // Download tệp tin từ máy chủ từ xa về máy tính cục bộ
                    // DownloadFile(scp, remoteFilepath, localFilepath);

                    scp.Disconnect();
                }

                client.Disconnect();
            }
        }

        private void UploadFile(ScpClient scp, string localFilePath, string remoteFilePath)
        {
            using (var fileStream = new FileStream(localFilePath, FileMode.Open))
            {
                scp.Upload(fileStream, remoteFilePath);
            }
        }
    }
}
