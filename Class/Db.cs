using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

    class Db
    {

    string server = "localhost";
    string database = "checkuser";
    string login = "root";
    string pass = "";

    private MySqlConnection connection;

    public bool found;

    
    public Db()
        {
            this.InitConnexion();
        }

        public void InitConnexion()
        {

            string connectionString = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + login + "; PASSWORD=" + pass + "";
            this.connection = new MySqlConnection(connectionString);


        }

        public void AddUser(User user)
        {
            try
            {
                
                this.connection.Open();

                MySqlCommand cmd = this.connection.CreateCommand();
      
                cmd.CommandText = "INSERT INTO user (id, nickname, password, email, date_inscription) VALUES (@id, @nickname, @password, @email, @dateInscription)";

                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@nickname", user.Nickname);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@dateInscription", user.DateInscription);

                cmd.ExecuteNonQuery();

                this.connection.Close();
                
        }
            catch
            {
                
            }
        }

        public void CheckUser(User user)
        {
        
                this.connection.Open();
                MySqlCommand cmd = this.connection.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) NB_USER FROM user WHERE nickname = @nickname and password = @password";
                cmd.Parameters.AddWithValue("@nickname", user.Nickname);
                cmd.Parameters.AddWithValue("@password", user.Password);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                this.connection.Close();

        if (count > 0)
        {
            found = true;
        }
        else
        {
            found = false;
        }

    }



    }

