using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace model
{
    public class DataVehicleModel: ICrud<VehicleModel>
    {
        private const string SqlInsert = @"INSERT INTO model VALUES('{0}',{1});";
        private const string SqlUpdate = @"UPDATE model SET name = '{0}', id_brand = {1} 
                                                  WHERE id = {2};";
        private const string SqlDelete = @"DELETE FROM model WHERE id = {0};";
        private const string SqlReadById = @"SELECT * FROM model WHERE id = {0};";
        private const string SqlReadAll = @"SELECT * FROM model;";
        private const string SqlReadAllFullInfo = @"SELECT m.id AS id, b.name AS BrandName,
                                                   m.name AS ModelName FROM model m INNER JOIN
                                                   brand b ON m.id_brand = b.id ";
        private const string SqlNameFilter = @" WHERE m.name LIKE '%{0}%' OR b.name LIKE '%{0}%'";
        private const string SqlSearchByName = @"SELECT * FROM model WHERE name LIKE '%{0}%';";

        private Connection con;
        private string query;
        private string lastError;

        public DataVehicleModel()
        {
            con = new Connection();        
        }

        public bool Create(VehicleModel model)
        {
            query = String.Format(SqlInsert, model.Name, model.IdBrand);
            Console.WriteLine("SQL = " + query);
            return con.Execute(query, ref lastError);
        }

        public bool Update(VehicleModel model)
        {
            query = String.Format(SqlUpdate, model.Name, model.IdBrand, model.Id);
            Console.WriteLine("SQL = " + query);
            return con.Execute(query, ref lastError);
        }

        public bool Delete(object id)
        {
            query = String.Format(SqlDelete, Convert.ToInt32(id));
            Console.WriteLine("SQL = " + query);
            return con.Execute(query, ref lastError);
        }

        public VehicleModel ReadById(object id)
        {
            VehicleModel b = null;
            query = String.Format(SqlReadById, Convert.ToInt32(id));
            con.Execute(query, ref lastError);
            while (con.ResultSet.Read())
            {
                b = GetVehicleModelFromResultSet(con.ResultSet);
            }
            con.Disconnect();
            return b;    
        }

        public List<VehicleModel> ReadAll()
        {
            List<VehicleModel> list = new List<VehicleModel>();
            con.Execute(SqlReadAll, ref lastError);
            while (con.ResultSet.Read())
            {
                list.Add(GetVehicleModelFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
        }

        public List<VehicleModel> Search(object pattern)
        {
            List<VehicleModel> list = new List<VehicleModel>();
            query = String.Format(SqlSearchByName, (string)pattern);
            con.Execute(query, ref lastError);
            while (con.ResultSet.Read())
            {
                list.Add(GetVehicleModelFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
        }

        public DataTable ReadAllFormatted()
        {
            return SearchByQuery(SqlReadAllFullInfo);
        }

        public DataTable SearchByNameFormatted(string pattern)
        {
            return SearchByQuery(SqlReadAllFullInfo + 
                   String.Format(SqlNameFilter, pattern));
        }

        public DataTable GetDataForCombo()
        {
            DataTable dt = null;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(SqlReadAll, con.Conexion);
                con.Conexion.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
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

        private VehicleModel GetVehicleModelFromResultSet(SqlDataReader rs)
        {
            return new VehicleModel(rs.GetInt32(0), rs.GetString(1),
                                    rs.GetInt32(2));
        }

        private DataTable SearchByQuery(string query)
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
            return dt;
        }
    }
}
