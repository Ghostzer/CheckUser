using System;
using System.Windows.Forms;

namespace CheckUser
{
    public partial class F_HOME : Form
    {
        public F_HOME()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_REGISTER register = new F_REGISTER();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_LOGIN login = new F_LOGIN();
            login.ShowDialog();
        }

        private void F_HOME_Load(object sender, EventArgs e)
        {

        }
    }
}
