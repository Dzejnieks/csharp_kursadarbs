using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Vilcienu_uzskaites_aplikacija
{
    //This class is responsible with keeping database information private, opening/closing db connection, and kind of like setter and getter for information (queries)
    public class DB_conn
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        
        public DB_conn()
        {
            //Database access information
            server = "localhost";
            database = "vus_db";
            user = "admin";
            password = "admin";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            connection = new MySqlConnection(connectionString);
        }
        //helper methods
        public void open_connection()
        {
            this.conn().Open();
        }
        public void close_connection()
        {
            this.conn().Close();
        }
        public MySqlConnection conn()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
        //global functions
          //for authorization purposes (Form1)
        public bool verify_user(string username,string password){

            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            try
            {
                this.open_connection();

                adapter = new MySqlDataAdapter("SELECT `username`, `password` FROM `auth_cred` WHERE `username` = '" + username + "' AND `password` = '" + password + "'", this.conn());
                adapter.Fill(table);

                this.close_connection();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ping_db()
        {
            try
            {
                this.conn().Open();
                this.conn().Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //returns the whole table
        public DataTable get_table (string table_name)
        {
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            try
            {
                this.open_connection();

                adapter = new MySqlDataAdapter("SELECT * FROM `"+table_name+"`", this.conn());
                adapter.Fill(table);

                this.close_connection();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return table;
        }

        //when user selects 
        public DataTable get_table_from_x_where_y_is_z(string table_name, string column_name, string value)
        {
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            int number = 0;
            DateTime dateTime = new DateTime();
          if (Int32.TryParse(value, out number))
            {
                Console.WriteLine("value got parsed into Int32 and it is = " + number);
                try
                {
                    this.open_connection();

                    adapter = new MySqlDataAdapter("SELECT * FROM `"+table_name+"` WHERE `"+column_name+"` = '" + number + "'", this.conn());
                    adapter.Fill(table);

                    this.close_connection();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (DateTime.TryParse(value, out dateTime))
            {
                Console.WriteLine("value got parsed into DateTime and it is = " + dateTime.ToString("dd/MM/yyyy HH:mm:ss"));
                try
                {
                    this.open_connection();

                    adapter = new MySqlDataAdapter("SELECT * FROM `" + table_name + "` WHERE `" + column_name + "` = ('" + dateTime.ToString("yyyy/MM/dd HH:mm:ss") + "');", this.conn());
                    adapter.Fill(table);

                    this.close_connection();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                {
                    Console.WriteLine("value is not int32 " + value);
                    try
                    {
                        this.open_connection();

                        adapter = new MySqlDataAdapter("SELECT * FROM `" + table_name + "` WHERE `" + column_name + "` = '" + value + "'", this.conn());
                        adapter.Fill(table);

                        this.close_connection();
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return table;
        }
        public bool insert_train(string train_number, string train_model, string train_track, string arrival, string departure)
        {
            DateTime dateTime_arrival = new DateTime();
            DateTime dateTime_departure = new DateTime();
            try
            {

                DateTime.TryParse(arrival, out dateTime_arrival);
                DateTime.TryParse(departure, out dateTime_departure);

                string CommandText = "INSERT INTO `trains`(`train_number`, `train_model`, `train_track`, `arrival_time`, `departure_time`) " +
                    "VALUES (?train_number,?train_model,?train_track,?arrival_time,?departure_time)";

                MySqlCommand cmd = new MySqlCommand(CommandText, this.connection);
                cmd.Connection.Open();
                         cmd.Parameters.AddWithValue("?train_number", train_number);
                         Console.WriteLine(train_number);
                         cmd.Parameters.AddWithValue("?train_model", train_model);
                         Console.WriteLine(train_model);
                         cmd.Parameters.AddWithValue("?train_track", train_track);
                         Console.WriteLine(train_track);
                         cmd.Parameters.AddWithValue("?arrival_time", dateTime_arrival.ToString("yyyy/MM/dd HH:mm:ss"));
                         Console.WriteLine(dateTime_arrival.ToString("yyyy/MM/dd HH:mm:ss"));
                         cmd.Parameters.AddWithValue("?departure_time", dateTime_departure.ToString("yyyy/MM/dd HH:mm:ss"));
                         Console.WriteLine(dateTime_departure.ToString("yyyy/MM/dd HH:mm:ss"));
                cmd.Prepare();
                cmd.ExecuteReader();
                this.conn().Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool insert_wagon(string wagon_number, string krava, string svars, string train_number)
        {
            try
            {
                string CommandText = "INSERT INTO `wagons`(`wagon_number`, `krava`, `svars`, `train_number`) " +
                    "VALUES (?wagon_number,?krava,?svars,?train_number)";

                MySqlCommand cmd = new MySqlCommand(CommandText, this.connection);
                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("?wagon_number", wagon_number);
                Console.WriteLine(wagon_number);
                cmd.Parameters.AddWithValue("?krava", krava);
                Console.WriteLine(krava);
                cmd.Parameters.AddWithValue("?svars", svars);
                Console.WriteLine(svars);
                cmd.Parameters.AddWithValue("?train_number", train_number);
                Console.WriteLine(train_number);
                cmd.Prepare();
                cmd.ExecuteReader();
                this.conn().Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool edit_wagon(string wagon_number, string krava, string svars, string train_number)
        {
            try
            {
                string CommandText = "UPDATE `wagons` SET `krava`=?krava, `svars`=?svars, `train_number`=?train_number WHERE `wagon_number` = ?wagon_number ";

                MySqlCommand cmd = new MySqlCommand(CommandText, this.connection);
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("?wagon_number", wagon_number);
                Console.WriteLine(wagon_number);
                cmd.Parameters.AddWithValue("?krava", krava);
                Console.WriteLine(krava);
                cmd.Parameters.AddWithValue("?svars", svars);
                Console.WriteLine(svars);
                cmd.Parameters.AddWithValue("?train_number", train_number);
                Console.WriteLine(train_number);

                cmd.Prepare();
                cmd.ExecuteReader();

                this.conn().Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool edit_train(string train_number, string train_model, string train_track, string arrival, string departure)
        {
            DateTime dateTime_arrival = new DateTime();
            DateTime dateTime_departure = new DateTime();

            try
            {
                DateTime.TryParse(arrival, out dateTime_arrival);
                DateTime.TryParse(departure, out dateTime_departure);
                Console.WriteLine("parsed arrival " + dateTime_arrival.ToString() + " parsed departure " + dateTime_departure.ToString());

                string CommandText = "UPDATE `trains` SET `train_model`=?train_model,`train_track`=?train_track,`arrival_time`=?arrival_time,`departure_time`=?departure_time WHERE `train_number` = ?train_number";
                MySqlCommand cmd = new MySqlCommand(CommandText, this.connection);
                cmd.Connection.Open();

                cmd.Parameters.AddWithValue("?train_number", train_number);
                Console.WriteLine(train_number);
                cmd.Parameters.AddWithValue("?train_model", train_model);
                Console.WriteLine(train_model);
                cmd.Parameters.AddWithValue("?train_track", train_track);
                Console.WriteLine(train_track);
                cmd.Parameters.AddWithValue("?arrival_time", dateTime_arrival.ToString("yyyy/MM/dd HH:mm:ss"));
                Console.WriteLine(dateTime_arrival.ToString("yyyy/MM/dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("?departure_time", dateTime_departure.ToString("yyyy/MM/dd HH:mm:ss"));
                Console.WriteLine(dateTime_departure.ToString("yyyy/MM/dd HH:mm:ss"));
                cmd.Prepare();
                cmd.ExecuteReader();

                this.conn().Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool delete_from_x_where_y_is_z(string table_name, string column_name, string value)
        {
            try
            {
                int number;
                Int32.TryParse(value, out number);

                string commandText = "DELETE FROM "+table_name+" WHERE "+column_name+" = @value";
                MySqlCommand cmd = new MySqlCommand(commandText, this.connection);
                cmd.Connection.Open();

                //for some reasons these lines dont work. they put extra apostrophes around table and column names which break the mysql query
                //cmd.Parameters.AddWithValue("@table_name", table_name.ToString());
                Console.WriteLine(table_name);
                //cmd.Parameters.AddWithValue("?column_name", column_name.ToString());
                Console.WriteLine(column_name);
                cmd.Parameters.AddWithValue("?value", number);
                Console.WriteLine(value);
                cmd.Prepare();
                cmd.ExecuteReader();
                Console.WriteLine(value + " entry deleted");
                this.conn().Close();


                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
