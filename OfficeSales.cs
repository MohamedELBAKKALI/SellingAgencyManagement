using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SellingAgencyManagement
{
    class OfficeSales
    {
        //private static List<Customers> OfficeSalesList = new List<Customers>();

        private SqlConnection connexion;

        public OfficeSales()
        {
            connexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SellingAgencyManagement;Integrated Security=true");
        }


        public void AddCustomer(Customers Customer)
        {
            MyConnexion.ExecuteNonQueryMyC("insert into Customers values(" + Customer.Id + ",'" + Customer.FirstName + "','"+ Customer.LastName +"',"+Customer.Age+",'"
                +Customer.Phone+"','"+ Customer.Occupation+"',"+Customer.IdOffice+")");
        }


        public void DeleteCustomer(int id)
        {
            MyConnexion.ExecuteNonQueryMyC(@"delete from Customers  where Id=" + id);

        }

        public void UpdateCustomer(int id, string firstName,string lastName, int age,string phone,string occupation, int idOffice)
        {

            MyConnexion.ExecuteNonQueryMyC(@"Update Customers set FirstName='"+ firstName + "',LastName='"+ lastName + "',Age="+ age + ",phone='"+ phone + "',Occupation='"+ occupation + "',IdOffice="+ idOffice
                + "where Id=" + id);

        }

        public List<Customers> CustomerList()
        {
            List<Customers> list = new List<Customers>();
            SqlDataReader data = MyConnexion.ExecuteReaderMyC("select * from Customers ");

            while (data.Read())
                //list.Add(new Group(int.Parse(data["Id"].ToString()),data["Nom"].ToString()));
                list.Add(new Customers(data.GetInt32(0), data.GetString(1),data.GetString(2),data.GetInt32(3),
                    data.GetString(4),data.GetString(5),data.GetInt32(6)));
            MyConnexion.Close();
            return list;
        }
        /// <summary>
        /// /////////////////
        /// </summary>
        /// <param name="Contract"></param>
        public void AddContract(Contracts Contract)
        {
            MyConnexion.ExecuteNonQueryMyC("insert into Contracts values (" + Contract.Id + "," + Contract.IdCustomer + ",'" + Contract.CntType + "'," + Contract.FirstBatch + "," + Contract.Installement + ",'" + Contract.ContDate + "');");
        }

        public List<Contracts> ContractsList()
        {
            List<Contracts> list = new List<Contracts>();
            SqlDataReader data = MyConnexion.ExecuteReaderMyC("select * from Contracts ");

            while (data.Read())
                //list.Add(new Group(int.Parse(data["Id"].ToString()),data["Nom"].ToString()));
                list.Add(new Contracts(data.GetInt32(0), data.GetInt32(1), data.GetString(2), data.GetFloat(3),
                     data.GetFloat(4),data.GetDateTime(5).ToString()));
            MyConnexion.Close();
            return list;
        }
        /// <summary>
        /// //////////
        /// </summary>
        /// <param name="Apartement"></param>
        public void AddApartement(Apartements Apartement)
        {
            MyConnexion.ExecuteNonQueryMyC("insert into Apartements values("+Apartement.IdApartment+","+Apartement.Price+",'"+ Apartement.AparAddress+"',"+Apartement.Aparfloor+","+Apartement.NbrRooms+");");
        }

        public List<Apartements> ApartementsList()
        {
            List<Apartements> list = new List<Apartements>();
            SqlDataReader data = MyConnexion.ExecuteReaderMyC("select * from Apartements ");
            while (data.Read())
                //list.Add(new Group(int.Parse(data["Id"].ToString()),data["Nom"].ToString()));
                list.Add(new Apartements(data.GetInt32(0), data.GetFloat(1), data.GetString(2), data.GetInt32(3),
                     data.GetInt32(4)));
            MyConnexion.Close();
            return list;
        }

        public void AddRelationContractApartemet(int IdContact,int IdApartement)
        {
            MyConnexion.ExecuteNonQueryMyC("insert into Contract_Apartement values("+ IdContact + ","+ IdApartement + ");");
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="IdOffice"></param>
        /// <param name="NameOffice"></param>
        public void AddOffice(int IdOffice ,string NameOffice)
        {
            MyConnexion.ExecuteNonQueryMyC("Insert into OfficesSales values("+ IdOffice + ",'"+ NameOffice + "')");

        }
        public List<Office> OfficesList()
        {
            List<Office> list = new List<Office>();
            SqlDataReader data = MyConnexion.ExecuteReaderMyC("Select * from OfficesSales;");
            while (data.Read())
                list.Add(new Office(data.GetInt32(0),data.GetString(1)));
            MyConnexion.Close();
            return list;
        }
    }
}
