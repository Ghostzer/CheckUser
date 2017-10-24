using System;
using System.Windows.Forms;

namespace CheckUser
{
    public partial class F_LOGIN : Form
    {
        public F_LOGIN()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            if ((txt_nickname.Text == "") || (txt_password.Text == "" ))
            {
                MessageBox.Show("Please enter your nickname/pass", "Error");
            } else
            {
                User login = new User();

                login.Nickname = txt_nickname.Text;
                login.Password = txt_password.Text;

                Db connexion = new Db();

                connexion.CheckUser(login);

                if (connexion.found)
                {
                    MessageBox.Show("You're login !", "Confirmation");
                }
                else
                {
                    MessageBox.Show("This user doesn't exist !", "Error");
                }
            }

            

        }

        private void F_LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
