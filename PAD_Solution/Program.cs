using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PAD_Solution
{
    public class Program
    {
        // Unit Testing
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static String CreateMessage()
        {
            return "Message";
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static bool IsPrime(int value)
        {
            if (value == 2) return true;
            else return false;
        }
        // Integration Testing
        private static MySqlConnection Connect ()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "missbeninsenegal";
            string username = "root";
            string password = "";
            // Connection String
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;
            // Connection
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        public static String FirstId(string column,string sql)
        {
            string val = "";
            MySqlConnection con = Program.Connect();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                val = reader.GetString(column);
            }
            return val;
        }
    }
}
