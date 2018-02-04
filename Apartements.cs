using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingAgencyManagement
{
    public class Apartements
    {
        private int idApartment;
        private float price;
        private string aparAddress;
        private int aparfloor;
        private int nbrRooms;

        public int IdApartment
        {
            get
            {
                return idApartment;
            }

            set
            {
                idApartment = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string AparAddress
        {
            get
            {
                return aparAddress;
            }

            set
            {
                aparAddress = value;
            }
        }

        public int Aparfloor
        {
            get
            {
                return aparfloor;
            }

            set
            {
                aparfloor = value;
            }
        }

        public int NbrRooms
        {
            get
            {
                return nbrRooms;
            }

            set
            {
                nbrRooms = value;
            }
        }

        public Apartements() { }
        public Apartements(int idApartment,float price,string aparAddress,int aparfloor,int nbrRooms)
        {
            this.IdApartment = idApartment;
            this.Price = price;
            this.AparAddress = aparAddress;
            this.Aparfloor = Aparfloor;
            this.NbrRooms = nbrRooms;  
        }


    }
}
