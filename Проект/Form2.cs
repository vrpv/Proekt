using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;
using Ionic.Zip;

namespace Проект
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //listView1.Clear();
            var request = (FtpWebRequest) WebRequest.Create("ftp://37.140.192.226/");
            request.Credentials = new NetworkCredential("u0905535", "5SNt8O_o");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            var response = (FtpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream);
            //  listView1.Items.Add(reader.ReadToEnd());
            using (var sw = new StreamWriter("test.txt"))
            {
                sw.WriteLine(reader.ReadToEnd());
            }

            response.Close();
            responseStream.Close();
            reader.Close();

            using (var sr = new StreamReader("test.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "") break;
                    //  MessageBox.Show(line);
                    var frpWebRequest =
                        (FtpWebRequest) WebRequest.Create("ftp://37.140.192.226/" + line);
                    frpWebRequest.Credentials = new NetworkCredential("u0905535", "5SNt8O_o");
                    frpWebRequest.KeepAlive = true;
                    frpWebRequest.UsePassive = true;
                    frpWebRequest.UseBinary = true;
                    frpWebRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                    var response1 = (FtpWebResponse) frpWebRequest.GetResponse();
                    var stream = response1.GetResponseStream();
                    var list = new List<byte>();
                    int b;
                    while ((b = stream.ReadByte()) != -1)
                        list.Add((byte) b);
                    File.WriteAllBytes($"loooooool\\{line}", list.ToArray());
                }
            }


            // получаем все файлы
            var files = Directory.GetFiles("loooooool\\");

            // перебор полученных файлов
            foreach (var file in files)
            {
                var lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);

                //  lvi.ImageIndex = 0; // установка картинки для файла
                lvi.Group = listView1.Groups[2];

                // добавляем элемент в ListView
                listView1.Items.Add(lvi);
            }

            MessageBox.Show("Загрузка и сохранение файла завершены");
        }

        private static void FtpUploadFile(string filename)
        {
            var fileInf = new FileInfo(filename);
            var uri = "ftp://" + "37.140.192.226" + "/" + fileInf.Name;
            FtpWebRequest reqFTP;
            // Создаем объект FtpWebRequest
            reqFTP = (FtpWebRequest) WebRequest.Create(
                new Uri("ftp://" + "37.140.192.226" + "/" + fileInf.Name));
            // Учетная запись
            reqFTP.Credentials = new NetworkCredential("u0905535", "5SNt8O_o");
            reqFTP.KeepAlive = false;
            // Задаем команду на закачкуё
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            // Тип передачи файла
            reqFTP.UseBinary = true;
            // Сообщаем серверу о размере файла
            reqFTP.ContentLength = fileInf.Length;
            // Буффер в 2 кбайт
            var buffLength = 2048;
            var buff = new byte[buffLength];
            int contentLen;
            // Файловый поток
            var fs = fileInf.OpenRead();
            try
            {
                var strm = reqFTP.GetRequestStream();
                // Читаем из потока по 2 кбайт
                contentLen = fs.Read(buff, 0, buffLength);
                // Пока файл не кончится
                while (contentLen != 0)
                {
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Закрываем потоки
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var filename = new OpenFileDialog {Multiselect = true};
            filename.ShowDialog();
            if (filename.FileName == string.Empty)
                return;

            using (var zipp = new ZipFile(Encoding.GetEncoding("cp866")))
            {
                zipp.CompressionLevel =
                    Ionic.Zlib.CompressionLevel.BestCompression; // Задаем максимальную степень сжатия 
                foreach (var file in filename.FileNames)
                {
                    zipp.AddFile(file, "");
                }

                zipp.Save("Архив.zip");
            }

            using (var zip = new ZipFile(Encoding.GetEncoding("cp866")))
            {
                zip.CompressionLevel =
                    Ionic.Zlib.CompressionLevel.BestCompression; // Задаем максимальную степень сжатия 
                zip.Password = "123";
                zip.AddFile("Архив.zip"); // Кладем в архив папку вместе с содежимым
                zip.Save("Файлы\\loooooool.zip"); // Создаем архив     
                File.Delete("Архив.zip");
            }

            FtpUploadFile("Файлы\\loooooool.zip");

            MessageBox.Show("Файл загружен");

            var request = (FtpWebRequest) WebRequest.Create("ftp://37.140.192.226/");
            request.Credentials = new NetworkCredential("u0905535", "5SNt8O_o");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            var response = (FtpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream);
            //  listView1.Items.Add(reader.ReadToEnd());
            using (var sw = new StreamWriter("zagr.txt"))
            {
                sw.WriteLine(reader.ReadToEnd());
            }

            response.Close();
            responseStream.Close();
            reader.Close();

            using (var sr = new StreamReader("zagr.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "") break;
                    var lvi = new ListViewItem();
                    // установка названия файла
                    lvi.Text = line;
                    //  lvi.ImageIndex = 0; // установка картинки для файла
                    lvi.Group = listView1.Groups[3];
                    // добавляем элемент в ListView
                    listView1.Items.Add(lvi);
                }
            }

            //  }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;


            var request = (FtpWebRequest) WebRequest.Create("ftp://37.140.192.226/");
            request.Credentials = new NetworkCredential("u0905535", "5SNt8O_o");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            var response = (FtpWebResponse) request.GetResponse();
            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream);
            //  listView1.Items.Add(reader.ReadToEnd());
            using (var sw = new StreamWriter("NaCervere.txt"))
            {
                sw.WriteLine(reader.ReadToEnd());
            }

            response.Close();
            responseStream.Close();
            reader.Close();

            using (var sr = new StreamReader("NaCervere.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "") break;

                    var lvi = new ListViewItem();
                    // установка названия файла
                    lvi.Text = line;

                    //  lvi.ImageIndex = 0; // установка картинки для файла
                    lvi.Group = listView1.Groups[1];
                    // добавляем элемент в ListView
                    listView1.Items.Add(lvi);
                }
            }
        }

        //синхронизация
        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.GetDirectories(@"Файлы").Length + Directory.GetFiles(@"Файлы").Length > 0)
            {
                // Папка не пуста
                //    MessageBox.Show("Папка не пуста");

                const string path = "Файлы\\";
                // получаем все файлы
                var files = Directory.GetFiles(path);
                // перебор полученных файлов
                foreach (var file in files)
                {
                    FtpUploadFile(file);
                }
                //    MessageBox.Show("dd");


                var request = (FtpWebRequest) WebRequest.Create("ftp://37.140.192.226/");
                request.Credentials = new NetworkCredential("u0905535", "5SNt8O_o");
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                var response = (FtpWebResponse) request.GetResponse();
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream);
                //  listView1.Items.Add(reader.ReadToEnd());
                using (var sw = new StreamWriter("cinxron.txt"))
                {
                    sw.WriteLine(reader.ReadToEnd());
                }

                response.Close();
                responseStream.Close();
                reader.Close();

                using (var sr = new StreamReader("cinxron.txt", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == "") break;
                        //  MessageBox.Show(line);
                        var frpWebRequest =
                            (FtpWebRequest) WebRequest.Create("ftp://37.140.192.226/" + line);
                        frpWebRequest.Credentials = new NetworkCredential("u0905535", "5SNt8O_o");
                        frpWebRequest.KeepAlive = true;
                        frpWebRequest.UsePassive = true;
                        frpWebRequest.UseBinary = true;
                        frpWebRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                        var response1 = (FtpWebResponse)frpWebRequest.GetResponse();
                        var stream = response1.GetResponseStream();
                        var list = new List<byte>();
                        int b;
                        while ((b = stream.ReadByte()) != -1)
                            list.Add((byte) b);
                        File.WriteAllBytes($"Локальные\\{line}", list.ToArray());
                    }
                }

                const string path1 = "Локальные\\";
                // получаем все файлы
                var files1 = Directory.GetFiles(path1);
                // перебор полученных файлов
                foreach (var file in files1)
                {
                    var lvi = new ListViewItem();
                    // установка названия файла
                    lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);

                    //  lvi.ImageIndex = 0; // установка картинки для файла
                    lvi.Group = listView1.Groups[0];
                    // добавляем элемент в ListView
                    listView1.Items.Add(lvi);
                }

                var di = new DirectoryInfo("Файлы");

                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }

                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                File.Delete("cinxron.txt");
            }
            else
            {
                MessageBox.Show("Папка пуста. Добавите файлы в нее");
            }

            MessageBox.Show("Синхронизация успешно выполнена");
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}