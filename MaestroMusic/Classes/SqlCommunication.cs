using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MaestroMusic
{
    internal class SQLCommunication
    {
        #region variables
        // all variables that important for the use of the class
        //"server=(localdb)\\MSSQLLocalDB; Integrated Security = true;"

        // STATIC
        private static string _connectionstring;
        public string connectionstring
        {

            get
            {
                return _connectionstring;
            }
            set
            {
                _connectionstring = value;
            }
        }

        public static MySqlConnection conn = new MySqlConnection("server=eduweb20; user=f.wurzer ; database=f.wurzer; password=MyDatabase138");
        public static MySqlCommand comm = new MySqlCommand("", conn);
        public static MySqlDataReader SqlDR;

        #endregion
        #region generaldb


        public static void SqlConnection()
        {
            try
            {
                MySqlConnection con = new MySqlConnection();
                con = new MySqlConnection("server=eduweb20; user=f.wurzer ; database=f.wurzer; password=MyDatabase138");
                MySqlCommand cmd = new MySqlCommand("", con);
                con.Open();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed!");
            }

        }

        // changes the connection string for a connection with username and password
        public void changeConnstring(string adresse, string username, string password)
        {
            connectionstring = "server=" + adresse + ";" + " User ID=" + username + ";Password=" + password + ";";
            conn.ConnectionString = connectionstring;
        }

        //executes a command without return from user input
        public void sqlCommandNoReturn(string commandline)
        {
            try
            {
                conn.Open();

                comm.CommandText = commandline;
                comm.ExecuteNonQuery();


                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }

        //executes a command with return from user input
        public string sqlCommandReturn(string commandline)
        {
            try
            {
                conn.Open();

                string output = "";
                comm.CommandText = "";

                //new SqlDataReader
                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        output = reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3];
                    }

                }

                conn.Close();
                return output;
            }

            catch (Exception ex)
            {
                return "";
            }

        }

        public static bool checkLogin(string user, string pw)
        {

           
            conn.Open();
            if (pw != string.Empty || user != string.Empty)
            {
                comm.CommandText = "select * from anmeldung where username='" + user + "' and password='" + pw + "'";
                MySqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Try again! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return false;
                }

            }
            else
            {
                MessageBox.Show("All fields must be filled! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
            
        }
        public static void Register(string user, string mail, string pw)
        {
            conn.Open();
            comm.CommandText = "INSERT INTO anmeldung (username, email, password) VALUES ('" + user + "', '" + mail + "', '" + pw + "')";
            comm.ExecuteNonQuery();
            MessageBox.Show("Sucessfully registered!");
            conn.Close();
          
        }

        #endregion
    }
}
