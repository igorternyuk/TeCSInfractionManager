using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class Brand
    {
        private int id;
        private string name;

        public Brand() { }

        public Brand(string name)
        {
            this.name = name;
        }

        public Brand(int id, string name)
        {
            this.id = id;
            this.name = name;
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

        public override string ToString()
        {
            return name;
        }
    }
}
