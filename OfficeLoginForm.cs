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
    public partial class OfficeLoginForm : Form
    {
        OfficeSales officeSales;
        public OfficeLoginForm()
        {
            InitializeComponent();
            officeSales = new OfficeSales();
        }
        

        private void btnAddOffice_Click(object sender, EventArgs e)
        {
            try
            {
                Office o = new Office();
                o.IdOffice = int.Parse(idOfficeTextBox.Text);
                o.Nameoffice = txtNomOff.Text;
                officeSales.AddOffice(o.IdOffice, o.Nameoffice);

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

            //idOfficecomboBox.DataSource = officeSales.OfficesList();// khsek xi list t ajouti fiha bax t affectiha f combo
            //idOfficecomboBox.DisplayMember = "Nameoffice";// wla t3awed tjib m data 
            //idOfficecomboBox.ValueMember = "IdOffice";
        }

        private void OfficeLoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
