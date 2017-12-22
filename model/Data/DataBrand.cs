using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace model
{
    public class DataBrand : ICrud<Brand>
    {
        private const String SqlInsert = @"INSERT INTO brand VALUES('{0}');";
        private const String SqlUpdate = @"UPDATE brand SET name = '{0}' WHERE id = {1};";
        private const String SqlDelete = @"DELETE FROM brand WHERE id = {0};";
        private const String SqlReadById = @"SELECT * FROM brand WHERE id = {0};";
        private const String SqlReadAll = @"SELECT * FROM brand;";
        private const String SqlSearchByName = @"SELECT * FROM brand WHERE name LIKE '%{0}%';";

        private Connection con;
        private string query;
        private string lastError;

        public DataBrand()
        {
            con = new Connection();
        }

        public bool Create(Brand brand)
        {
            query = String.Format(SqlInsert, brand.Name);
            return con.Execute(query, ref lastError);
        }

        public bool Update(Brand brand)
        {
            query = String.Format(SqlUpdate, brand.Name, brand.Id);
            return con.Execute(query, ref lastError);
        }

        public bool Delete(object id)
        {
            query = String.Format(SqlDelete, Convert.ToInt32(id));
            Console.WriteLine("SQL = " + query);
            return con.Execute(query, ref lastError);
        }

        public Brand ReadById(object id)
        {
            Brand b = null;
            query = String.Format(SqlReadById, Convert.ToInt32(id));
            con.Execute(query, ref lastError);
            while (con.ResultSet.Read())
            {
                b = GetBrandFromResultSet(con.ResultSet);
            }
            con.Disconnect();
            return b;     
        }

        public List<Brand> ReadAll()
        {
            List<Brand> list = new List<Brand>();
            con.Execute(SqlReadAll, ref lastError);
            while (con.ResultSet.Read())
            {
                list.Add(GetBrandFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
        }

        public List<Brand> Search(object pattern)
        {
            List<Brand> list = new List<Brand>();
            query = String.Format(SqlSearchByName, (string)pattern);
            con.Execute(query, ref lastError);
            while (con.ResultSet.Read())
            {
                list.Add(GetBrandFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
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

        private Brand GetBrandFromResultSet(SqlDataReader rs)
        {
            return new Brand(rs.GetInt32(0), rs.GetString(1));
        }
    }
}
