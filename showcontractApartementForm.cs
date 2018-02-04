using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellingAgencyManagement
{
    public partial class showcontractApartementForm : Form
    {
        OfficeSales officeSales;
        public showcontractApartementForm()
        {
            InitializeComponent();
            officeSales = new OfficeSales();
        }

        private void btnAllContract_Click(object sender, EventArgs e)
        {
            try
            {
                contractsDataGridView.DataSource = officeSales.ContractsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAlleApartements_Click(object sender, EventArgs e)
        {
            try
            {
                apartementsDataGridView.DataSource = officeSales.ApartementsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
