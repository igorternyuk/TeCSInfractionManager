using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    public class Infraction
    {
        private int id;
        private string patent;
        private int idModel;
        private string details;
        private DateTime fecha;
        private int fine;

        public Infraction() { }

        public Infraction(int id, string patent, int idModel, string details,
                          DateTime fecha, int fine)
        {
            this.id = id;
            this.patent = patent;
            this.idModel = idModel;
            this.details = details;
            this.fecha = fecha;
            this.fine = fine;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Patent
        {
            get { return patent; }
            set { patent = value; }
        }

        public int IdModel
        {
            get { return idModel; }
            set { idModel = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Fine
        {
            get { return fine; }
            set { fine = value; }
        }

        public string getFormattedDate()
        {
            return this.Fecha.ToString("yyyy-MM-dd"); 
        }

        public override string ToString()
        {
            return patent + " - " + getFormattedDate();
        }
    }
}
