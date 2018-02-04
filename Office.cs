using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingAgencyManagement
{
    class Office
    {
        private int idOffice;
        private string nameoffice;


        public int IdOffice
        {
            get
            {
                return idOffice;
            }

            set
            {
                idOffice = value;
            }
        }

        public string Nameoffice
        {
            get
            {
                return nameoffice;
            }

            set
            {
                nameoffice = value;
            }
        }

        public Office() { }
        public Office(int idOffice,string nameoffice)
        {
            this.IdOffice = idOffice;
            this.Nameoffice = nameoffice;
        }
    }
}
