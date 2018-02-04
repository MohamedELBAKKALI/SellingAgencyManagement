using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SellingAgencyManagement
{
    class MyConnexion
    {
        static SqlConnection connexion;

        static MyConnexion()
        {
            connexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SellingAgencyManagement;Integrated Security=true");
        }

        public static void ExecuteNonQueryMyC(string requete)
        {
            SqlCommand commande = new SqlCommand(requete, connexion);
            open();
            commande.ExecuteNonQuery();
            Close();
        }


        public static SqlDataReader ExecuteReaderMyC(string requete)
        {
            SqlCommand commande = new SqlCommand(requete, connexion);
            open();
            return commande.ExecuteReader();
            //Close();
        }

        public static void Close()
        {
            if (connexion.State == System.Data.ConnectionState.Open)
            {
                connexion.Close();
            }
        }

        public static void open()
        {
            if (connexion.State == System.Data.ConnectionState.Closed)
            {
                connexion.Open();
            }
        }
    }
}
