using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SellingAgencyManagement
{
    public partial class Form1 : Form
    {
        OfficeSales officeSales ;

        DataGridView dgv;
        public Form1(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
            officeSales = new OfficeSales();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idCustomerTextBox.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        }


        public static List<Contracts> OfficeSalesContrList = new List<Contracts>();

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                MyConnexion.open();
                Contracts Co = new Contracts();
                Co.Id = int.Parse(idTextBox.Text);
                Co.IdCustomer = int.Parse(idCustomerTextBox.Text);
                Co.CntType = cntTypeTextBox.Text;
                Co.FirstBatch = float.Parse(firstBatchTextBox.Text);
                Co.Installement = float.Parse(installementTextBox.Text);
                Co.ContDate = contDateTextBox.Text;
                officeSales.AddContract(Co);
                OfficeSalesContrList.Add(Co);
                idTextBox1.Enabled = false; //IDContract
                idTextBox1.Text = idTextBox.Text;
                MyConnexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public static List<Apartements> OfficeSalesApartList = new List<Apartements>();

        private void btnAddApartement_Click(object sender, EventArgs e)
        {
            try
            {
                MyConnexion.open();
                Apartements A = new Apartements();
                A.IdApartment = int.Parse(idApartmentTextBox.Text);
                A.Price = float.Parse(priceTextBox.Text);
                A.AparAddress = aparAddressTextBox.Text;
                A.Aparfloor = int.Parse(aparfloorTextBox.Text);
                A.NbrRooms = int.Parse(nbrRoomsTextBox.Text);
                officeSales.AddApartement(A);
                OfficeSalesApartList.Add(A);
                idApartmentTextBox1.Enabled = false;
                idApartmentTextBox1.Text = idApartmentTextBox.Text;
                MyConnexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void linkBetween_Click(object sender, EventArgs e)
        {
            try
            {
                officeSales.AddRelationContractApartemet(int.Parse(idTextBox1.Text),int.Parse(idApartmentTextBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            showcontractApartementForm showF = new showcontractApartementForm();
            showF.ShowDialog();
        }
    }
}
