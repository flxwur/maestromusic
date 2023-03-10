using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sql usings
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MaestroMusic.Classes
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

        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand comm = new SqlCommand();
        public static SqlDataReader SqlDR;

        #endregion
        #region generaldb

        public void connectDatabase(string username, string password)
        {
            connectionstring = "server=web.hak-kitz.eu/f.wurzer ;" + " User ID=" + username + ";Password=" + password + ";";
            conn.ChangeDatabase(connectionstring);
            conn.Open();
        }


        // changes the connection string for a sspi connection
        //public void changeConnstringSSPI(string adresse)
        //{
        //    try
        //    {
        //        conn.Close();
        //        connectionstring = "server=" + adresse + ";" + " Integrated Security = true; ";     
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        // changes the connection string for a new database
        //public void changeConnstringDatabase(string db)
        //{
        //    try
        //    {
        //        conn.Close();
        //        connectionstring = connectionstring + " database = " + db + " ;";               //Sensless bc only one
        //        conn.ConnectionString = connectionstring;                                       //Database will be used
        //        conn.ConnectionString = connectionstring;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}


        // changes the connection string for a connection with username and password
        //public void changeConnstring(string adresse, string username, string password)
        //{
        //    connectionstring = "server=" + adresse + ";" + " User ID=" + username + ";Password=" + password + ";";
        //    conn.ConnectionString = connectionstring;
        //}

        // opens and closes Sql for test use
        public bool sqlOpen()
        {
            try
            {
                conn.Open();

                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // closes and maybe open sql connection
        public bool sqlClose()
        {
            try
            {
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void createDatabase(string dbname)                  
        {
            try
            {
                bool IsExits = CheckDatabaseExists(conn, dbname);
                 
                if (!IsExits)
                {
                    conn.Open();
                    SqlCommand dbcreate_sqlCommand = conn.CreateCommand();
                    dbcreate_sqlCommand.CommandText = "CREATE DATABASE " + dbname;
                    dbcreate_sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Database " + dbname + " succesfully created!");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("This database with the name " + dbname + " already exists!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while creating database with the name " + dbname);
                MessageBox.Show(ex.ToString());
            }

        }//No DB will be created


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
                SqlDataReader reader = comm.ExecuteReader();

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

        private static bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName)
        {
            string sqlCreateDBQuery;
            bool result = false;
            try
            {
                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);
                // databaseName gets a value of 0, shows every Database with the value 0

                //test the connection to the Database with id and conn
                SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn);

                tmpConn.Open();
                object resultObj = sqlCmd.ExecuteScalar(); ;
                //.ExecuteScalar returns the first row of the command and safes it in resultObj.

                if (resultObj != null)
                {
                    result = true;
                }

                tmpConn.Close();

            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
    #endregion
}
