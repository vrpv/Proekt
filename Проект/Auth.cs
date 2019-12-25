using System.Windows.Forms;

namespace Проект
{
    public partial class Auth : MetroFramework.Forms.MetroForm
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, System.EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var reg = new Reg();
            reg.Show();
        }

        private void metroLabel1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var rem = new Remember();
            rem.Show();
        }
    }
}