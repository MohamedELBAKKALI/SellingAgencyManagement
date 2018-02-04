namespace SellingAgencyManagement
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label idApartmentLabel1;
            System.Windows.Forms.Label installementLabel;
            System.Windows.Forms.Label cntTypeLabel;
            System.Windows.Forms.Label idCustomerLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label contDateLabel;
            System.Windows.Forms.Label firstBatchLabel;
            System.Windows.Forms.Label aparAddressLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label aparfloorLabel;
            System.Windows.Forms.Label nbrRoomsLabel;
            System.Windows.Forms.Label idApartmentLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.idApartmentTextBox1 = new System.Windows.Forms.TextBox();
            this.linkBetween = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.installementTextBox = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.idCustomerTextBox = new System.Windows.Forms.TextBox();
            this.cntTypeTextBox = new System.Windows.Forms.TextBox();
            this.firstBatchTextBox = new System.Windows.Forms.TextBox();
            this.contDateTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxApartement = new System.Windows.Forms.GroupBox();
            this.btnAddApartement = new System.Windows.Forms.Button();
            this.aparAddressTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nbrRoomsTextBox = new System.Windows.Forms.TextBox();
            this.aparfloorTextBox = new System.Windows.Forms.TextBox();
            this.idApartmentTextBox = new System.Windows.Forms.TextBox();
            this.apartementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel1 = new System.Windows.Forms.Label();
            idApartmentLabel1 = new System.Windows.Forms.Label();
            installementLabel = new System.Windows.Forms.Label();
            cntTypeLabel = new System.Windows.Forms.Label();
            idCustomerLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            contDateLabel = new System.Windows.Forms.Label();
            firstBatchLabel = new System.Windows.Forms.Label();
            aparAddressLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            aparfloorLabel = new System.Windows.Forms.Label();
            nbrRoomsLabel = new System.Windows.Forms.Label();
            idApartmentLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxApartement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(176, 392);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(59, 13);
            idLabel1.TabIndex = 27;
            idLabel1.Text = "IdContract:";
            // 
            // idApartmentLabel1
            // 
            idApartmentLabel1.AutoSize = true;
            idApartmentLabel1.Location = new System.Drawing.Point(176, 418);
            idApartmentLabel1.Name = "idApartmentLabel1";
            idApartmentLabel1.Size = new System.Drawing.Size(70, 13);
            idApartmentLabel1.TabIndex = 28;
            idApartmentLabel1.Text = "Id Apartment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selling Agency Management";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(252, 389);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 28;
            // 
            // idApartmentTextBox1
            // 
            this.idApartmentTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartementsBindingSource, "IdApartment", true));
            this.idApartmentTextBox1.Location = new System.Drawing.Point(252, 415);
            this.idApartmentTextBox1.Name = "idApartmentTextBox1";
            this.idApartmentTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idApartmentTextBox1.TabIndex = 29;
            // 
            // linkBetween
            // 
            this.linkBetween.BackColor = System.Drawing.Color.CornflowerBlue;
            this.linkBetween.Location = new System.Drawing.Point(217, 441);
            this.linkBetween.Name = "linkBetween";
            this.linkBetween.Size = new System.Drawing.Size(162, 23);
            this.linkBetween.TabIndex = 30;
            this.linkBetween.Text = "Link Between the previous";
            this.linkBetween.UseVisualStyleBackColor = false;
            this.linkBetween.Click += new System.EventHandler(this.linkBetween_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnshowall.Location = new System.Drawing.Point(498, 430);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 34);
            this.btnshowall.TabIndex = 31;
            this.btnshowall.Text = "Show";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SellingAgencyManagement.Properties.Resources.hyresgast_och_hyresvard_ser_over_besittningsskydd;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.installementTextBox);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(installementLabel);
            this.groupBox1.Controls.Add(this.idCustomerTextBox);
            this.groupBox1.Controls.Add(cntTypeLabel);
            this.groupBox1.Controls.Add(idCustomerLabel);
            this.groupBox1.Controls.Add(this.cntTypeTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(contDateLabel);
            this.groupBox1.Controls.Add(this.firstBatchTextBox);
            this.groupBox1.Controls.Add(this.contDateTextBox);
            this.groupBox1.Controls.Add(firstBatchLabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 291);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contract";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(101, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // installementTextBox
            // 
            this.installementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "Installement", true));
            this.installementTextBox.Location = new System.Drawing.Point(101, 150);
            this.installementTextBox.Name = "installementTextBox";
            this.installementTextBox.Size = new System.Drawing.Size(100, 20);
            this.installementTextBox.TabIndex = 12;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(20, 182);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(96, 23);
            this.btnAddCustomer.TabIndex = 16;
            this.btnAddCustomer.Text = "AddCustomer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // installementLabel
            // 
            installementLabel.AutoSize = true;
            installementLabel.Location = new System.Drawing.Point(29, 153);
            installementLabel.Name = "installementLabel";
            installementLabel.Size = new System.Drawing.Size(66, 13);
            installementLabel.TabIndex = 11;
            installementLabel.Text = "Installement:";
            // 
            // idCustomerTextBox
            // 
            this.idCustomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "IdCustomer", true));
            this.idCustomerTextBox.Location = new System.Drawing.Point(101, 45);
            this.idCustomerTextBox.Name = "idCustomerTextBox";
            this.idCustomerTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCustomerTextBox.TabIndex = 10;
            // 
            // cntTypeLabel
            // 
            cntTypeLabel.AutoSize = true;
            cntTypeLabel.Location = new System.Drawing.Point(29, 75);
            cntTypeLabel.Name = "cntTypeLabel";
            cntTypeLabel.Size = new System.Drawing.Size(53, 13);
            cntTypeLabel.TabIndex = 1;
            cntTypeLabel.Text = "Cnt Type:";
            // 
            // idCustomerLabel
            // 
            idCustomerLabel.AutoSize = true;
            idCustomerLabel.Location = new System.Drawing.Point(29, 48);
            idCustomerLabel.Name = "idCustomerLabel";
            idCustomerLabel.Size = new System.Drawing.Size(71, 13);
            idCustomerLabel.TabIndex = 9;
            idCustomerLabel.Text = "Id Customers:";
            // 
            // cntTypeTextBox
            // 
            this.cntTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "CntType", true));
            this.cntTypeTextBox.Location = new System.Drawing.Point(101, 72);
            this.cntTypeTextBox.Name = "cntTypeTextBox";
            this.cntTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cntTypeTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(29, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // contDateLabel
            // 
            contDateLabel.AutoSize = true;
            contDateLabel.Location = new System.Drawing.Point(29, 101);
            contDateLabel.Name = "contDateLabel";
            contDateLabel.Size = new System.Drawing.Size(58, 13);
            contDateLabel.TabIndex = 3;
            contDateLabel.Text = "Cont Date:";
            // 
            // firstBatchTextBox
            // 
            this.firstBatchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "FirstBatch", true));
            this.firstBatchTextBox.Location = new System.Drawing.Point(101, 124);
            this.firstBatchTextBox.Name = "firstBatchTextBox";
            this.firstBatchTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstBatchTextBox.TabIndex = 6;
            // 
            // contDateTextBox
            // 
            this.contDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractsBindingSource, "ContDate", true));
            this.contDateTextBox.Location = new System.Drawing.Point(101, 98);
            this.contDateTextBox.Name = "contDateTextBox";
            this.contDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.contDateTextBox.TabIndex = 4;
            // 
            // firstBatchLabel
            // 
            firstBatchLabel.AutoSize = true;
            firstBatchLabel.Location = new System.Drawing.Point(29, 127);
            firstBatchLabel.Name = "firstBatchLabel";
            firstBatchLabel.Size = new System.Drawing.Size(60, 13);
            firstBatchLabel.TabIndex = 5;
            firstBatchLabel.Text = "First Batch:";
            // 
            // groupBoxApartement
            // 
            this.groupBoxApartement.BackgroundImage = global::SellingAgencyManagement.Properties.Resources.apartement_by_photopocket;
            this.groupBoxApartement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxApartement.Controls.Add(this.btnAddApartement);
            this.groupBoxApartement.Controls.Add(this.aparAddressTextBox);
            this.groupBoxApartement.Controls.Add(aparAddressLabel);
            this.groupBoxApartement.Controls.Add(this.priceTextBox);
            this.groupBoxApartement.Controls.Add(priceLabel);
            this.groupBoxApartement.Controls.Add(aparfloorLabel);
            this.groupBoxApartement.Controls.Add(this.nbrRoomsTextBox);
            this.groupBoxApartement.Controls.Add(this.aparfloorTextBox);
            this.groupBoxApartement.Controls.Add(nbrRoomsLabel);
            this.groupBoxApartement.Controls.Add(idApartmentLabel);
            this.groupBoxApartement.Controls.Add(this.idApartmentTextBox);
            this.groupBoxApartement.Location = new System.Drawing.Point(312, 92);
            this.groupBoxApartement.Name = "groupBoxApartement";
            this.groupBoxApartement.Size = new System.Drawing.Size(261, 291);
            this.groupBoxApartement.TabIndex = 26;
            this.groupBoxApartement.TabStop = false;
            this.groupBoxApartement.Text = "Apartement";
            // 
            // btnAddApartement
            // 
            this.btnAddApartement.Location = new System.Drawing.Point(12, 182);
            this.btnAddApartement.Name = "btnAddApartement";
            this.btnAddApartement.Size = new System.Drawing.Size(98, 23);
            this.btnAddApartement.TabIndex = 26;
            this.btnAddApartement.Text = "AddApartement";
            this.btnAddApartement.UseVisualStyleBackColor = true;
            this.btnAddApartement.Click += new System.EventHandler(this.btnAddApartement_Click);
            // 
            // aparAddressTextBox
            // 
            this.aparAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartementsBindingSource, "AparAddress", true));
            this.aparAddressTextBox.Location = new System.Drawing.Point(101, 48);
            this.aparAddressTextBox.Name = "aparAddressTextBox";
            this.aparAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.aparAddressTextBox.TabIndex = 17;
            // 
            // aparAddressLabel
            // 
            aparAddressLabel.AutoSize = true;
            aparAddressLabel.Location = new System.Drawing.Point(22, 51);
            aparAddressLabel.Name = "aparAddressLabel";
            aparAddressLabel.Size = new System.Drawing.Size(73, 13);
            aparAddressLabel.TabIndex = 16;
            aparAddressLabel.Text = "Apar Address:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartementsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(101, 130);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 25;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(22, 133);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 24;
            priceLabel.Text = "Price:";
            // 
            // aparfloorLabel
            // 
            aparfloorLabel.AutoSize = true;
            aparfloorLabel.Location = new System.Drawing.Point(22, 77);
            aparfloorLabel.Name = "aparfloorLabel";
            aparfloorLabel.Size = new System.Drawing.Size(52, 13);
            aparfloorLabel.TabIndex = 18;
            aparfloorLabel.Text = "Aparfloor:";
            // 
            // nbrRoomsTextBox
            // 
            this.nbrRoomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartementsBindingSource, "NbrRooms", true));
            this.nbrRoomsTextBox.Location = new System.Drawing.Point(101, 104);
            this.nbrRoomsTextBox.Name = "nbrRoomsTextBox";
            this.nbrRoomsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nbrRoomsTextBox.TabIndex = 23;
            // 
            // aparfloorTextBox
            // 
            this.aparfloorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartementsBindingSource, "Aparfloor", true));
            this.aparfloorTextBox.Location = new System.Drawing.Point(101, 74);
            this.aparfloorTextBox.Name = "aparfloorTextBox";
            this.aparfloorTextBox.Size = new System.Drawing.Size(100, 20);
            this.aparfloorTextBox.TabIndex = 19;
            // 
            // nbrRoomsLabel
            // 
            nbrRoomsLabel.AutoSize = true;
            nbrRoomsLabel.Location = new System.Drawing.Point(22, 107);
            nbrRoomsLabel.Name = "nbrRoomsLabel";
            nbrRoomsLabel.Size = new System.Drawing.Size(63, 13);
            nbrRoomsLabel.TabIndex = 22;
            nbrRoomsLabel.Text = "Nbr Rooms:";
            // 
            // idApartmentLabel
            // 
            idApartmentLabel.AutoSize = true;
            idApartmentLabel.Location = new System.Drawing.Point(22, 25);
            idApartmentLabel.Name = "idApartmentLabel";
            idApartmentLabel.Size = new System.Drawing.Size(70, 13);
            idApartmentLabel.TabIndex = 20;
            idApartmentLabel.Text = "Id Apartment:";
            // 
            // idApartmentTextBox
            // 
            this.idApartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.apartementsBindingSource, "IdApartment", true));
            this.idApartmentTextBox.Location = new System.Drawing.Point(101, 22);
            this.idApartmentTextBox.Name = "idApartmentTextBox";
            this.idApartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.idApartmentTextBox.TabIndex = 21;
            // 
            // apartementsBindingSource
            // 
            this.apartementsBindingSource.DataSource = typeof(SellingAgencyManagement.Apartements);
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataSource = typeof(SellingAgencyManagement.Contracts);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(SellingAgencyManagement.Customers);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 479);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.linkBetween);
            this.Controls.Add(idApartmentLabel1);
            this.Controls.Add(this.idApartmentTextBox1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxApartement);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ContractApartementManagementForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxApartement.ResumeLayout(false);
            this.groupBoxApartement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource contractsBindingSource;
        private System.Windows.Forms.TextBox cntTypeTextBox;
        private System.Windows.Forms.TextBox contDateTextBox;
        private System.Windows.Forms.TextBox firstBatchTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox idCustomerTextBox;
        private System.Windows.Forms.TextBox installementTextBox;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.BindingSource apartementsBindingSource;
        private System.Windows.Forms.TextBox aparAddressTextBox;
        private System.Windows.Forms.TextBox aparfloorTextBox;
        private System.Windows.Forms.TextBox idApartmentTextBox;
        private System.Windows.Forms.TextBox nbrRoomsTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.GroupBox groupBoxApartement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox idApartmentTextBox1;
        private System.Windows.Forms.Button btnAddApartement;
        private System.Windows.Forms.Button linkBetween;
        private System.Windows.Forms.Button btnshowall;
    }
}

