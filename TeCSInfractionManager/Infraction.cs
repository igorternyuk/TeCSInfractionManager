using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class Infraction
    {
        private int id;
        private String rut;
        private String patent;        
        private String brand;        
        private String model;
        private String details;
        private int fine;        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public String Patent
        {
            get { return patent; }
            set { patent = value; }
        }

        public String Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public String Details
        {
            get { return details; }
            set { details = value; }
        }

        public int Fine
        {
            get { return fine; }
            set { fine = value; }
        }


    }
}
