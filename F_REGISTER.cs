using System.Windows.Forms;
using System;

namespace CheckUser
{
    public partial class F_REGISTER : Form
    {
        public F_REGISTER()
        {
            InitializeComponent();

        }

        private void Btn_inscription_Click(object sender, System.EventArgs e)
        {

            try
            {
                DateTime localDate = DateTime.Now;

                User newUser = new User();

                newUser.Nickname = txt_nickname.Text;
                newUser.Password = txt_pass.Text;
                newUser.Email = txt_email.Text;
                newUser.DateInscription = localDate;

                Db db = new Db();

                db.AddUser(newUser); //check erreur

                toolStripStatusLabel1.Text = "User added successfully !";
                
                txt_nickname.Text = "";
                txt_pass.Text = "";
                txt_email.Text = "";
            }
            catch (System.Exception)
            {
                toolStripStatusLabel1.Text = "Woops ! An error occured...";
                throw;
            }

            
        }

        private void F_REGISTER_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
