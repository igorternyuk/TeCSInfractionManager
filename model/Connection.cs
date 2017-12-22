using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace model
{
    class Connection
    {
        private const String ServerName = "COMPUTER-891624\\SQLEXPRESS";
        private const String DatabaseName = "bd_infractions";
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rs;

        public Connection()
        {
            con = new SqlConnection(
                "Data Source=" + ServerName + ";" +
                "Initial Catalog=" + DatabaseName + ";" +
                "Integrated Security=SSPI;"
                );  
        }

        public Connection(string server, string database,
                          bool isWindowsAuthentication = true,
                          string username = "sa", string password = "")
        {
            if (isWindowsAuthentication)
            {
                con = new SqlConnection(
                    "Data Source=" + server + ";" +
                    "Initial Catalog=" + database + ";" +
                    "Integrated Security=SSPI;"
                    );  
            }
            else
            {
                con = new SqlConnection(
                   "Data Source=" + server + ";" +
                   "Initial Catalog=" + database + ";" +
                    "User id=" + username + ";" +
                    "Password = " + password
                   );
            }
        }

        public String Server
        {
            get { return ServerName; }
        }

        public String Database
        {
            get { return DatabaseName; }
        }

        public SqlConnection Conexion
        {
            get { return con; }
        }

        public bool Execute(string query, ref string err)
        {
            try
            {
                Console.WriteLine("sql = " + query);
                Conexion.Open();
                cmd = new SqlCommand(query, Conexion);
                if (query.ToLower().Contains("select"))
                {
                    //Select
                    rs = cmd.ExecuteReader();
                    return true;
                }
                else
                {
                    //Insert, Update or Delete
                    int numOfAffectedRows = cmd.ExecuteNonQuery();
                    Disconnect();
                    return numOfAffectedRows != 0;
                }

            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return false;
        }

        public String Disconnect()
        {
            try
            {
                Conexion.Close();
                return "The Conexion was successfully closed.";
            }
            catch (SqlException ex)
            {
                return ex.Message;
            }
        }

        public SqlDataReader ResultSet
        {
            get { return rs; }
        }
    }
}
