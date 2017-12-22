using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace model
{
    public class DataInfraction : ICrud<Infraction>
    {
        private const String SqlInsert = @"INSERT INTO infraction VALUES('{0}',
                                           {1},'{2}','{3}',{4});";
        private const String SqlUpdate = @"UPDATE infraction SET patent = '{0}',
                                          id_model = {1}, details = '{2}',
                                          fecha = '{3}', fine = {4} WHERE id = {5};";
        private const String SqlDelete = @"DELETE FROM infraction WHERE id = {0};";
        private const String SqlReadById = @"SELECT * FROM infraction WHERE id = {0};";
        private const String SqlReadAll = @"SELECT * FROM infraction;";
        private const String SqlSearchByDetails = @"SELECT * FROM infraction
                                                  WHERE details LIKE '%{0}%';";
        private const String SqlReadAllFullInfo = @"SELECT i.id AS ID, i.patent AS Patent,
                                                  b.name AS BrandName, m.name ModelName, i.details,
                                                  i.fecha, i.fine FROM infraction i
                                                  INNER JOIN model m ON
                                                  i.id_model = m.id
                                                  INNER JOIN brand b ON
                                                  m.id_brand = b.id ";
        private const String SqlSearchTotal = @"SELECT i.id AS ID, i.patent AS Patent,b.name AS BrandName,
                                               m.name ModelName, i.details, i.fecha, i.fine FROM infraction i 
                                               INNER JOIN model m ON i.id_model = m.id 
                                               INNER JOIN brand b ON m.id_brand = b.id 
                                               WHERE i.patent LIKE '%{0}%' OR b.name LIKE '%{0}%' OR
                                               m.name LIKE '%{0}%' OR i.details LIKE '%{0}%';";
        private Connection con;
        private string query;
        private string lastError;

        public DataInfraction()
        {
            con = new Connection();
        }

        public bool Create(Infraction i)
        {
            query = String.Format(SqlInsert, i.Patent, i.IdModel, i.Details,
                                  i.Fecha, i.Fine);
            Console.WriteLine("SQL = " + query);
            return con.Execute(query, ref lastError);
        }

        public bool Update(Infraction i)
        {
            query = String.Format(SqlUpdate, i.Patent, i.IdModel, i.Details,
                                  i.Fecha, i.Fine, i.Id);
            Console.WriteLine("SQL = " + query);
            return con.Execute(query, ref lastError);
        }

        public bool Delete(object id)
        {
            query = String.Format(SqlDelete, Convert.ToInt32(id));
            Console.WriteLine("SQL = " + query);
            return con.Execute(query, ref lastError);
        }

        public Infraction ReadById(object id)
        {
            Infraction i = null;
            query = String.Format(SqlReadById, Convert.ToInt32(id));
            con.Execute(query, ref lastError);
            while (con.ResultSet.Read())
            {
                i = GetInfractionFromResultSet(con.ResultSet);
            }
            con.Disconnect();
            return i;   
        }

        public List<Infraction> ReadAll()
        {
            List<Infraction> list = new List<Infraction>();
            con.Execute(SqlReadAll, ref lastError);
            while (con.ResultSet.Read())
            {
                list.Add(GetInfractionFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
        }

        public List<Infraction> Search(object pattern)
        {
            List<Infraction> list = new List<Infraction>();
            query = String.Format(SqlSearchByDetails, (string)pattern);
            con.Execute(query, ref lastError);
            while (con.ResultSet.Read())
            {
                list.Add(GetInfractionFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
        }

        public DataTable getCompleteInfractionData()
        {
            return SearchByQuery(SqlReadAllFullInfo);
        }

        public DataTable SearchTotal(string regEx)
        {
            return SearchByQuery(String.Format(SqlSearchTotal, regEx));
        }

        private DataTable SearchByQuery(String query)
        {
            DataTable dt = null;
            try
            {
                using (SqlCommand cmd = con.Conexion.CreateCommand())
                {
                    con.Conexion.Open();
                    cmd.CommandText = query;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    con.Disconnect();
                }
            }
            catch (SqlException ex)
            {
                lastError = ex.Message;
            }
            finally
            {
                con.Disconnect();
            }
            return dt;
        }

        public string getLastError()
        {
            return this.lastError;
        }

        private Infraction GetInfractionFromResultSet(SqlDataReader rs)
        {
            Infraction i = new Infraction();
            i.Id = rs.GetInt32(0);
            i.Patent = rs.GetString(1);
            i.IdModel = rs.GetInt32(2);            
            i.Details = rs.IsDBNull(3) ? "<No details>" : rs.GetString(3);
            i.Fecha = rs.GetDateTime(4);
            i.Fine = rs.GetInt32(5);
            return i;
        }
    }
}
