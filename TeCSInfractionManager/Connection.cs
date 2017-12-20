using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace model
{
    class Connection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        private SqlDataReader rs;

        public Connection(string server, string database)
        {
            /*
             *   con = new SqlConnection(
                "Date Source=COMPUTER-891624\\SQLEXPRESS;" +
                "Initial Catalog=" + database + ";" +
                "User id=sa;" +
             *  "Password =123456"
                );
             */
            con = new SqlConnection(
                "Data Source=" + server + ";" +
                "Initial Catalog=" + database + ";" +
                "Integrated Security=SSPI;"
                );
        }

        public String Execute(String query)
        {
            try
            {
                Console.WriteLine("sql = " + query);
                con.Open();
                cmd = new SqlCommand(query, con);
                if (query.ToLower().Contains("select"))
                {
                    //Select
                    rs = cmd.ExecuteReader();
                    return "The query was successfully executed.";
                }
                else
                {
                    //Insert, Update or Delete
                    cmd.ExecuteNonQuery();
                    Disconnect();
                    return "The Update was successfully executed.";
                }

            }
            catch (SqlException e1)
            {
                return e1.Message;
            }
            catch (InvalidOperationException e2)
            {
                return e2.Message;
            }
        }

        public String Disconnect()
        {
            try
            {
                con.Close();
                return "The connection was successfully closed.";
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
