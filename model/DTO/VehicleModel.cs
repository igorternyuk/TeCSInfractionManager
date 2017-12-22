using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class VehicleModel
    {
        int id;
        string name;
        int idBrand;

        public VehicleModel()
        { }

        public VehicleModel(string name, int idBrand)
        {
            this.name = name;
            this.idBrand = idBrand;
        }

        public VehicleModel(int id, string name, int idBrand)
        {
            this.id = id;
            this.name = name;
            this.idBrand = idBrand;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }       

        public string Name
        {
            get { return name; }
            set { name = value; }
        }        

        public int IdBrand
        {
            get { return idBrand; }
            set { idBrand = value; }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
