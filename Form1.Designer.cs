namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zip_codeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zip_codeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zip_codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            addressLabel.Location = new System.Drawing.Point(60, 165);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 16);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Address :";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cityLabel.Location = new System.Drawing.Point(80, 194);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 16);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City :";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            customer_idLabel.Location = new System.Drawing.Point(36, 50);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(83, 16);
            customer_idLabel.TabIndex = 5;
            customer_idLabel.Text = "Customer ID:";
            customer_idLabel.Click += new System.EventHandler(this.customer_idLabel_Click);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            emailLabel.Location = new System.Drawing.Point(421, 55);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email :";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            first_nameLabel.Location = new System.Drawing.Point(47, 76);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(75, 16);
            first_nameLabel.TabIndex = 9;
            first_nameLabel.Text = "First Name ";
            first_nameLabel.Click += new System.EventHandler(this.first_nameLabel_Click);
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            last_nameLabel.Location = new System.Drawing.Point(44, 102);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(78, 16);
            last_nameLabel.TabIndex = 11;
            last_nameLabel.Text = "Last Name :";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            phone_numberLabel.Location = new System.Drawing.Point(396, 82);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(103, 16);
            phone_numberLabel.TabIndex = 13;
            phone_numberLabel.Text = "Phone Number :";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            stateLabel.Location = new System.Drawing.Point(568, 196);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(44, 16);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "State :";
            // 
            // zip_codeLabel
            // 
            zip_codeLabel.AutoSize = true;
            zip_codeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            zip_codeLabel.Location = new System.Drawing.Point(367, 194);
            zip_codeLabel.Name = "zip_codeLabel";
            zip_codeLabel.Size = new System.Drawing.Size(65, 16);
            zip_codeLabel.TabIndex = 17;
            zip_codeLabel.Text = "Zip Code:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(152, 160);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(591, 22);
            this.addressTextBox.TabIndex = 2;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(WindowsFormsApp1.customer);
            this.customerBindingSource.CurrentChanged += new System.EventHandler(this.customerBindingSource_CurrentChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(152, 194);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(143, 22);
            this.cityTextBox.TabIndex = 4;
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customer_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customer_idTextBox.Location = new System.Drawing.Point(152, 48);
            this.customer_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(213, 22);
            this.customer_idTextBox.TabIndex = 6;
            this.customer_idTextBox.TextChanged += new System.EventHandler(this.customer_idTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(511, 50);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(248, 22);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(152, 74);
            this.first_nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(213, 22);
            this.first_nameTextBox.TabIndex = 10;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(152, 98);
            this.last_nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(213, 22);
            this.last_nameTextBox.TabIndex = 12;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "phone_number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(511, 82);
            this.phone_numberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(248, 22);
            this.phone_numberTextBox.TabIndex = 14;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(653, 196);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(89, 22);
            this.stateTextBox.TabIndex = 16;
            // 
            // zip_codeTextBox
            // 
            this.zip_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "zip_code", true));
            this.zip_codeTextBox.Location = new System.Drawing.Point(437, 191);
            this.zip_codeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zip_codeTextBox.Name = "zip_codeTextBox";
            this.zip_codeTextBox.Size = new System.Drawing.Size(89, 22);
            this.zip_codeTextBox.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zipcodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 235);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(808, 199);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 150;
            // 
            // zipcodeDataGridViewTextBoxColumn
            // 
            this.zipcodeDataGridViewTextBoxColumn.DataPropertyName = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.HeaderText = "zip_code";
            this.zipcodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.zipcodeDataGridViewTextBoxColumn.Name = "zipcodeDataGridViewTextBoxColumn";
            this.zipcodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNew.Location = new System.Drawing.Point(405, 439);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 26);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New ";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(532, 439);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 26);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(635, 439);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 26);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 666);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(customer_idLabel);
            this.Controls.Add(this.customer_idTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zip_codeLabel);
            this.Controls.Add(this.zip_codeTextBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.customerBindingSource_CurrentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zip_codeTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcodeDataGridViewTextBoxColumn;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        public System.Windows.Forms.BindingSource customerBindingSource;
    }
}

