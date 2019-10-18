using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vilcienu_uzskaites_aplikacija
{
    public class db_parent
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        public void open_connection()
        {
            //open connection
        }
        public void close_connection()
        {
            //close connection
        }
        public MySqlConnection conn()
        {
            //method returns connection object
            return connection;
        }
    }
}
