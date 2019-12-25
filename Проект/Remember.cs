using System.Windows.Forms;

namespace Проект
{
    public partial class Remember : MetroFramework.Forms.MetroForm
    {
        public Remember()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var auth = new Auth();
            auth.Show();
        }
    }
}