using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SellingAgencyManagement
{
    public class Contracts
    {

        private int id;
        private int idCustomer;
        private string cntType;
        private float firstBatch;
        private float installement;
        private string contDate;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int IdCustomer
        {
            get
            {
                return idCustomer;
            }

            set
            {
                idCustomer = value;
            }
        }

        public string CntType
        {
            get
            {
                return cntType;
            }

            set
            {
                cntType = value;
            }
        }

        public float FirstBatch
        {
            get
            {
                return firstBatch;
            }

            set
            {
                firstBatch = value;
            }
        }

        public float Installement
        {
            get
            {
                return installement;
            }

            set
            {
                installement = value;
            }
        }

        public string ContDate
        {
            get
            {
                return contDate;
            }

            set
            {
                contDate = value;
            }
        }

        public Contracts()
        {

        }

        public Contracts(int id,int idCustomer,string cntType,float firstBatch, float installement, string contDate)
        {
            this.Id = id;
            this.IdCustomer = idCustomer;
            this.CntType = cntType;
            this.FirstBatch = firstBatch;
            this.Installement = installement;
            this.ContDate = contDate;
        }


    }
}
