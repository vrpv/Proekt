using System;  
using System.Collections.Generic;  
using System.Diagnostics;  
using System.IO;  
using System.IO.Compression;  
using System.Linq;  
using System.Runtime.InteropServices.WindowsRuntime;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void Test_Load(object sender, EventArgs e)
        {
            var lol = new OpenFileDialog();
            lol.Title = "Файл";
            lol.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            lol.InitialDirectory = "D:\\";
            if (lol.ShowDialog() == DialogResult.OK && lol.FileName != "")
            {
                Process.Start(lol.FileName);
            } 
        }
    }
}