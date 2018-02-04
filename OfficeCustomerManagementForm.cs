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
    public partial class OfficeCustomerManagementForm : Form
    {
        OfficeSales officeSales;
        public OfficeCustomerManagementForm()
        {
            InitializeComponent();
            officeSales = new OfficeSales();
        }
        public static List<Customers> OfficeSalesList = new List<Customers>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customers C = new Customers();
                C.Id = int.Parse(idTextBox.Text);
                C.FirstName = firstNameTextBox.Text;
                C.LastName = lastNameTextBox.Text;
                C.Age = int.Parse(ageTextBox.Text);
                C.Phone = phoneTextBox.Text;
                C.Occupation = occupationTextBox.Text;
                C.IdOffice = (int)idOfficecomboBox.SelectedValue;
                officeSales.AddCustomer(C);
                OfficeSalesList.Add(C);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customers C = new Customers();
                C.Id = int.Parse(idTextBox.Text);
                C.FirstName = firstNameTextBox.Text;
                C.LastName = lastNameTextBox.Text;
                C.Age = int.Parse(ageTextBox.Text);
                C.Phone = phoneTextBox.Text;
                C.Occupation = occupationTextBox.Text;
                C.IdOffice = int.Parse(idOfficecomboBox.Text);
                officeSales.UpdateCustomer(C.Id,C.FirstName,C.LastName,C.Age,C.Phone,C.Occupation,C.IdOffice);// khsek tbdelo f list moraha
                customersDataGridView.DataSource = officeSales.CustomerList();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Enabled = false;
            idTextBox.Text = customersDataGridView.CurrentRow.Cells[0].Value.ToString();
            firstNameTextBox.Text = customersDataGridView.CurrentRow.Cells[1].Value.ToString();
            lastNameTextBox.Text = customersDataGridView.CurrentRow.Cells[2].Value.ToString();
            ageTextBox.Text = customersDataGridView.CurrentRow.Cells[3].Value.ToString();
            phoneTextBox.Text = customersDataGridView.CurrentRow.Cells[4].Value.ToString();
            occupationTextBox.Text = customersDataGridView.CurrentRow.Cells[5].Value.ToString();
            idOfficecomboBox.Text = customersDataGridView.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = null;
            customersDataGridView.DataSource = officeSales.CustomerList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            idTextBox.Enabled = true;
            idTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageTextBox.Text = "";
            phoneTextBox.Text = "";
            occupationTextBox.Text = "";
            idOfficecomboBox.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int IdS = int.Parse(customersDataGridView.CurrentRow.Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show("Do you realy want to delete this Customer ?", "Suppression", MessageBoxButtons.YesNo
                ,MessageBoxIcon.Question);
            if (r.Equals(DialogResult.Yes))
                    officeSales.DeleteCustomer(IdS);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(customersDataGridView);
            f.ShowDialog();
        }

        private void OfficeCustomerManagementForm_Load(object sender, EventArgs e)
        {
            idOfficecomboBox.DataSource = officeSales.OfficesList();
            idOfficecomboBox.DisplayMember = "Nameoffice";//hna kat afficher li briti Display
            idOfficecomboBox.ValueMember = "IdOffice";// o hna value li khtarti 
            //List<int> ids = new List<int>();
            //ids = int.Parse(officeSales.OfficesList.ToString());
            //idOfficecomboBox.Items.DataSource(officeSales.OfficesList);
        }

        private void addOfficeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new OfficeLoginForm().ShowDialog();
            idOfficecomboBox.DataSource = officeSales.OfficesList();
            idOfficecomboBox.DisplayMember = "Nameoffice";
            idOfficecomboBox.ValueMember = "IdOffice";
        }
    }
}
