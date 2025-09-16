namespace TestForm_1
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
			this.btnDeleteClient = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddClient = new System.Windows.Forms.Button();
			this.Client_Name = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabClients = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.btnEditClient = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDeletePet = new System.Windows.Forms.Button();
			this.btnEditPet = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabClients.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDeleteClient
			// 
			this.btnDeleteClient.Location = new System.Drawing.Point(402, 67);
			this.btnDeleteClient.Name = "btnDeleteClient";
			this.btnDeleteClient.Size = new System.Drawing.Size(130, 40);
			this.btnDeleteClient.TabIndex = 0;
			this.btnDeleteClient.Text = "PetName";
			this.btnDeleteClient.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ColSurname,
            this.ClientID,
            this.colCredit});
			this.dataGridView1.Location = new System.Drawing.Point(53, 122);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(678, 215);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Name
			// 
			this.Name.HeaderText = "Name";
			this.Name.MinimumWidth = 6;
			this.Name.Name = "Name";
			this.Name.Width = 125;
			// 
			// ColSurname
			// 
			this.ColSurname.HeaderText = "Surname";
			this.ColSurname.MinimumWidth = 6;
			this.ColSurname.Name = "ColSurname";
			this.ColSurname.Width = 125;
			// 
			// ClientID
			// 
			this.ClientID.HeaderText = "ID";
			this.ClientID.MinimumWidth = 6;
			this.ClientID.Name = "ClientID";
			this.ClientID.Width = 125;
			// 
			// colCredit
			// 
			this.colCredit.HeaderText = "Credit Limit";
			this.colCredit.MinimumWidth = 6;
			this.colCredit.Name = "colCredit";
			this.colCredit.Width = 125;
			// 
			// btnAddClient
			// 
			this.btnAddClient.Location = new System.Drawing.Point(78, 67);
			this.btnAddClient.Name = "btnAddClient";
			this.btnAddClient.Size = new System.Drawing.Size(130, 40);
			this.btnAddClient.TabIndex = 2;
			this.btnAddClient.Text = "Add Client";
			this.btnAddClient.UseVisualStyleBackColor = true;
			this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
			// 
			// Client_Name
			// 
			this.Client_Name.Location = new System.Drawing.Point(487, 365);
			this.Client_Name.Name = "Client_Name";
			this.Client_Name.Size = new System.Drawing.Size(121, 48);
			this.Client_Name.TabIndex = 3;
			this.Client_Name.Text = "Clientele";
			this.Client_Name.UseVisualStyleBackColor = true;
			this.Client_Name.Click += new System.EventHandler(this.Client_Name_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabClients);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(928, 551);
			this.tabControl1.TabIndex = 4;
			// 
			// tabClients
			// 
			this.tabClients.Controls.Add(this.button1);
			this.tabClients.Controls.Add(this.btnEditClient);
			this.tabClients.Controls.Add(this.btnAddClient);
			this.tabClients.Controls.Add(this.dataGridView1);
			this.tabClients.Controls.Add(this.Client_Name);
			this.tabClients.Controls.Add(this.btnDeleteClient);
			this.tabClients.Location = new System.Drawing.Point(4, 25);
			this.tabClients.Name = "tabClients";
			this.tabClients.Padding = new System.Windows.Forms.Padding(3);
			this.tabClients.Size = new System.Drawing.Size(920, 522);
			this.tabClients.TabIndex = 0;
			this.tabClients.Text = "Clients";
			this.tabClients.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			// 
			// btnEditClient
			// 
			this.btnEditClient.Location = new System.Drawing.Point(0, 0);
			this.btnEditClient.Name = "btnEditClient";
			this.btnEditClient.Size = new System.Drawing.Size(75, 23);
			this.btnEditClient.TabIndex = 1;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.btnAdd);
			this.tabPage2.Controls.Add(this.btnDeletePet);
			this.tabPage2.Controls.Add(this.btnEditPet);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(920, 522);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Pets";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAge,
            this.colType,
            this.colOwnerID});
			this.dataGridView2.Location = new System.Drawing.Point(187, 92);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(560, 150);
			this.dataGridView2.TabIndex = 3;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			// 
			// colName
			// 
			this.colName.HeaderText = "Name";
			this.colName.MinimumWidth = 6;
			this.colName.Name = "colName";
			this.colName.Width = 125;
			// 
			// colAge
			// 
			this.colAge.HeaderText = "Age";
			this.colAge.MinimumWidth = 6;
			this.colAge.Name = "colAge";
			this.colAge.Width = 125;
			// 
			// colType
			// 
			this.colType.HeaderText = "Type";
			this.colType.MinimumWidth = 6;
			this.colType.Name = "colType";
			this.colType.Width = 125;
			// 
			// colOwnerID
			// 
			this.colOwnerID.HeaderText = "Owner ID";
			this.colOwnerID.MinimumWidth = 6;
			this.colOwnerID.Name = "colOwnerID";
			this.colOwnerID.Width = 125;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(187, 34);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDeletePet
			// 
			this.btnDeletePet.Location = new System.Drawing.Point(632, 34);
			this.btnDeletePet.Name = "btnDeletePet";
			this.btnDeletePet.Size = new System.Drawing.Size(115, 23);
			this.btnDeletePet.TabIndex = 1;
			this.btnDeletePet.Text = "Delete Pet";
			this.btnDeletePet.UseVisualStyleBackColor = true;
			// 
			// btnEditPet
			// 
			this.btnEditPet.Location = new System.Drawing.Point(418, 34);
			this.btnEditPet.Name = "btnEditPet";
			this.btnEditPet.Size = new System.Drawing.Size(75, 23);
			this.btnEditPet.TabIndex = 0;
			this.btnEditPet.Text = "Edit Pet";
			this.btnEditPet.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(920, 522);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Appointments";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(361, 310);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Hello Naledi";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 551);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabClients.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button Client_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDeletePet;
		private System.Windows.Forms.Button btnEditPet;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
		private System.Windows.Forms.DataGridViewTextBoxColumn colType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOwnerID;
		private System.Windows.Forms.Button button2;
	}
=======
        private System.Windows.Forms.Button btnEdit;
    }
>>>>>>> e3d44471d70604b43f53cb969f8a19fecb3ca3e2
}

