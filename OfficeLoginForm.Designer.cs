namespace SellingAgencyManagement
{
    partial class OfficeLoginForm
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
            System.Windows.Forms.Label idOfficeLabel;
            System.Windows.Forms.Label nameofficeLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddOffice = new System.Windows.Forms.Button();
            this.idOfficeTextBox = new System.Windows.Forms.TextBox();
            this.txtNomOff = new System.Windows.Forms.TextBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idOfficeLabel = new System.Windows.Forms.Label();
            nameofficeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idOfficeLabel);
            this.groupBox1.Controls.Add(this.txtNomOff);
            this.groupBox1.Controls.Add(this.idOfficeTextBox);
            this.groupBox1.Controls.Add(nameofficeLabel);
            this.groupBox1.Location = new System.Drawing.Point(25, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Office";
            // 
            // btnAddOffice
            // 
            this.btnAddOffice.Location = new System.Drawing.Point(102, 168);
            this.btnAddOffice.Name = "btnAddOffice";
            this.btnAddOffice.Size = new System.Drawing.Size(75, 23);
            this.btnAddOffice.TabIndex = 6;
            this.btnAddOffice.Text = "AddOffice";
            this.btnAddOffice.UseVisualStyleBackColor = true;
            this.btnAddOffice.Click += new System.EventHandler(this.btnAddOffice_Click);
            // 
            // idOfficeLabel
            // 
            idOfficeLabel.AutoSize = true;
            idOfficeLabel.Location = new System.Drawing.Point(18, 33);
            idOfficeLabel.Name = "idOfficeLabel";
            idOfficeLabel.Size = new System.Drawing.Size(50, 13);
            idOfficeLabel.TabIndex = 0;
            idOfficeLabel.Text = "Id Office:";
            // 
            // idOfficeTextBox
            // 
            this.idOfficeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.officeBindingSource, "IdOffice", true));
            this.idOfficeTextBox.Location = new System.Drawing.Point(88, 30);
            this.idOfficeTextBox.Name = "idOfficeTextBox";
            this.idOfficeTextBox.Size = new System.Drawing.Size(121, 20);
            this.idOfficeTextBox.TabIndex = 1;
            // 
            // nameofficeLabel
            // 
            nameofficeLabel.AutoSize = true;
            nameofficeLabel.Location = new System.Drawing.Point(18, 59);
            nameofficeLabel.Name = "nameofficeLabel";
            nameofficeLabel.Size = new System.Drawing.Size(64, 13);
            nameofficeLabel.TabIndex = 2;
            nameofficeLabel.Text = "Nameoffice:";
            // 
            // txtNomOff
            // 
            this.txtNomOff.Location = new System.Drawing.Point(88, 59);
            this.txtNomOff.Name = "txtNomOff";
            this.txtNomOff.Size = new System.Drawing.Size(121, 20);
            this.txtNomOff.TabIndex = 1;
            this.txtNomOff.Text = " ";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataSource = typeof(SellingAgencyManagement.Office);
            // 
            // OfficeLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 240);
            this.Controls.Add(this.btnAddOffice);
            this.Controls.Add(this.groupBox1);
            this.Name = "OfficeLoginForm";
            this.Text = "OfficeLoginForm";
            this.Load += new System.EventHandler(this.OfficeLoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource officeBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idOfficeTextBox;
        private System.Windows.Forms.Button btnAddOffice;
        private System.Windows.Forms.TextBox txtNomOff;
    }
}