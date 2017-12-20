using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace model
{
    public class Data: ICrud<Infraction>
    {
        private const String ServerName = "COMPUTER-891624\\SQLEXPRESS";    
        private const String DatabaseName = "db_infractions";
        private const String SqlInsert = "INSERT INTO infraction VALUES({0}, " + 
                                         "{1}, {2}, {3}, {4}, {5});";
        private const String SqlUpdate = "UPDATE infraction SET rut = {0},"+
                                         " patent = {1}, brand = {2}, model = {3}, " + 
                                         "details = {4}, fine = {5} WHERE id = {6};";
        private const String SqlDelete = "DELETE FROM infraction WHERE id = {0};";
        private const String SqlReadById = "SELECT * FROM infraction WHERE id = {0};";
        private const String SqlReadAll = "SELECT * FROM infraction;";
        private const String SqlReadByPatent = "SELECT * FROM infraction WHERE patent LIKE '%{0}%';";
        private const String SqlSearch = "SELECT * FROM infraction WHERE brand LIKE '%{0}%' OR " +
                                         "model LIKE '%{0}%' OR details LIKE '%{0}%'";

        private Connection con;
        private String query;
        
        public Data()
        {
            con = new Connection(ServerName, DatabaseName);
        }

        public String Server
        {
            get { return ServerName; }
        }

        public String Database
        {
            get { return DatabaseName; }
        }

        public void Create(Infraction infraction)
        {
            query = String.Format(SqlInsert, infraction.Rut, infraction.Patent,
                                  infraction.Brand, infraction.Model,
                                  infraction.Details, infraction.Fine);
            Console.WriteLine("SQL = " + query);
            con.Execute(query);
        }

        public Infraction ReadById(Object id)
        {
            Infraction i = new Infraction();
            query = String.Format(SqlReadById, Convert.ToInt32(id));
            con.Execute(query);
            while (con.ResultSet.Read())
            {
                i = GetInfractionFromResultSet(con.ResultSet);
            }
            con.Disconnect();
            return i;      
        }

        public List<Infraction> ReadAll()
        {
            return GetInfractionsByQuery(SqlReadAll);
        }

        public void Update(Infraction infraction)
        {
            query = String.Format(SqlUpdate, infraction.Rut, infraction.Patent,
                                  infraction.Brand, infraction.Model,
                                  infraction.Details, infraction.Fine,
                                  infraction.Id);
            Console.WriteLine("SQL = " + query);
            con.Execute(query);
        }

        public void Delete(Object infraction)
        {
            query = String.Format(SqlDelete, Convert.ToInt32(infraction));
            Console.WriteLine("SQL = " + query);
            con.Execute(query);
        }

        public List<Infraction> Search(Object pattern)
        {
            List<Infraction> list = new List<Infraction>();
            query = String.Format(SqlSearch, (String)pattern);
            con.Execute(query);
            while (con.ResultSet.Read())
            {
                list.Add(GetInfractionFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
        }

        private List<Infraction> GetInfractionsByPatent(String patent)
        {
            return GetInfractionsByQuery(String.Format(SqlReadByPatent, patent));
        }

        private List<Infraction> GetInfractionsByQuery(String cmd)
        {
            List<Infraction> list = new List<Infraction>();
            con.Execute(cmd);
            while (con.ResultSet.Read())
            {
                list.Add(GetInfractionFromResultSet(con.ResultSet));
            }
            con.Disconnect();
            return list;
        }

        private Infraction GetInfractionFromResultSet(SqlDataReader rs)
        {
            Infraction i = new Infraction();
            i.Id = rs.GetInt32(0);
            i.Rut = rs.GetString(1);
            i.Patent = rs.GetString(2);
            i.Brand = rs.GetString(3);
            i.Model = rs.GetString(4);
            i.Details = rs.GetString(5);
            i.Fine = rs.GetInt32(6);
            return i;
        }
    }
}
