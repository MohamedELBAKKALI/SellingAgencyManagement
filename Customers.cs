using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingAgencyManagement
{
    public class Customers
    {
        
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string phone;
        private string occupation;
        //private static List<Contracts> CustomersContractsList = new List<Contracts>();
        private int idOffice;


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

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Occupation
        {
            get
            {
                return occupation;
            }

            set
            {
                occupation = value;
            }
        }

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

        public Customers() { }
        public Customers(int id,string firstName,string lastName,int age,string phone,
            string occupation,int idOffice)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Phone = phone;
            this.Occupation = occupation;
            this.IdOffice = idOffice;
        }
    }
}
