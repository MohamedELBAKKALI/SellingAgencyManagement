namespace SellingAgencyManagement
{
    partial class showcontractApartementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.apartementsDataGridView = new System.Windows.Forms.DataGridView();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAllContract = new System.Windows.Forms.Button();
            this.btnAlleApartements = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.apartementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apartementsDataGridView
            // 
            this.apartementsDataGridView.AutoGenerateColumns = false;
            this.apartementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apartementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.apartementsDataGridView.DataSource = this.apartementsBindingSource;
            this.apartementsDataGridView.Location = new System.Drawing.Point(172, 330);
            this.apartementsDataGridView.Name = "apartementsDataGridView";
            this.apartementsDataGridView.Size = new System.Drawing.Size(544, 164);
            this.apartementsDataGridView.TabIndex = 1;
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.AutoGenerateColumns = false;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.contractsDataGridView.DataSource = this.contractsBindingSource;
            this.contractsDataGridView.Location = new System.Drawing.Point(172, 70);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.Size = new System.Drawing.Size(644, 164);
            this.contractsDataGridView.TabIndex = 2;
            // 
            // btnAllContract
            // 
            this.btnAllContract.Location = new System.Drawing.Point(40, 70);
            this.btnAllContract.Name = "btnAllContract";
            this.btnAllContract.Size = new System.Drawing.Size(91, 39);
            this.btnAllContract.TabIndex = 3;
            this.btnAllContract.Text = "AllContracts";
            this.btnAllContract.UseVisualStyleBackColor = true;
            this.btnAllContract.Click += new System.EventHandler(this.btnAllContract_Click);
            // 
            // btnAlleApartements
            // 
            this.btnAlleApartements.Location = new System.Drawing.Point(40, 330);
            this.btnAlleApartements.Name = "btnAlleApartements";
            this.btnAlleApartements.Size = new System.Drawing.Size(91, 39);
            this.btnAlleApartements.TabIndex = 4;
            this.btnAlleApartements.Text = "AlleApartements";
            this.btnAlleApartements.UseVisualStyleBackColor = true;
            this.btnAlleApartements.Click += new System.EventHandler(this.btnAlleApartements_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdCustomer";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdCustomer";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CntType";
            this.dataGridViewTextBoxColumn8.HeaderText = "CntType";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FirstBatch";
            this.dataGridViewTextBoxColumn9.HeaderText = "FirstBatch";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Installement";
            this.dataGridViewTextBoxColumn10.HeaderText = "Installement";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ContDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "ContDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataSource = typeof(SellingAgencyManagement.Contracts);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdApartment";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdApartment";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AparAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "AparAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Aparfloor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Aparfloor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NbrRooms";
            this.dataGridViewTextBoxColumn5.HeaderText = "NbrRooms";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // apartementsBindingSource
            // 
            this.apartementsBindingSource.DataSource = typeof(SellingAgencyManagement.Apartements);
            // 
            // showcontractApartementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SellingAgencyManagement.Properties.Resources.images2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(845, 564);
            this.Controls.Add(this.btnAlleApartements);
            this.Controls.Add(this.btnAllContract);
            this.Controls.Add(this.contractsDataGridView);
            this.Controls.Add(this.apartementsDataGridView);
            this.Name = "showcontractApartementForm";
            this.Text = "showcontractApartementForm";
            ((System.ComponentModel.ISupportInitialize)(this.apartementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartementsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource apartementsBindingSource;
        private System.Windows.Forms.DataGridView apartementsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private System.Windows.Forms.DataGridView contractsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnAllContract;
        private System.Windows.Forms.Button btnAlleApartements;
    }
}