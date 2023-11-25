using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace _732_1Reverser
{
    public class DBWorker
    {
        private SQLiteConnection conn;

        public DBWorker(string path)
        {
            conn = new SQLiteConnection("Data Source = " + path);
            conn.Open();
        }

        public bool DisconnectDB()
        {
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Dispose();
                }
            }

            return true;
        }

        public bool AddNewUser(string login, string password)
        {
            //INSERT INTO users VALUES ('user' , 'password')
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        SQLiteCommand command = conn.CreateCommand();
                        command.CommandText = "INSERT INTO users VALUES ('"
                            + login + "', '" + getHash(password) + "')";
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }

            return false;
        }

        public bool AuthUser(string login, string password)
        {
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        SQLiteCommand command = conn.CreateCommand();
                        command.CommandText = "SELECT * FROM users WHERE login = '" +
                            login + "' and password = '" + getHash(password) + "'";
                        object res = command.ExecuteScalar();
                        if (res != null)
                            return true;
                        else
                            return false;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
            }
            }

            return false;
        }

        private string getHash(string text)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] raw_text = Encoding.Unicode.GetBytes(text);
            byte[] raw_hash = sha256.ComputeHash(raw_text);
            string hash = Encoding.Unicode.GetString(raw_hash);

            sha256.Clear();

            return hash;
        }
    }
}
