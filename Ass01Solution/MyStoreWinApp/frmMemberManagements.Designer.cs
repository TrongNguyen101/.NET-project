namespace MyStoreWinApp
{
    partial class frmMemberManagements
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
            lbMemberID = new Label();
            txtMemberID = new TextBox();
            lbMemberName = new Label();
            txtMemberName = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            lbCountry = new Label();
            txtCountry = new TextBox();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dgvMember = new DataGridView();
            gbSortMember = new GroupBox();
            rbtnSortByName = new RadioButton();
            rbtnSortByID = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            gbSortMember.SuspendLayout();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(71, 53);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "MemberID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(190, 49);
            txtMemberID.Margin = new Padding(3, 4, 3, 4);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(204, 27);
            txtMemberID.TabIndex = 1;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(71, 107);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(105, 20);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "MemberName";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(190, 103);
            txtMemberName.Margin = new Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(204, 27);
            txtMemberName.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(71, 164);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 160);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 5;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(496, 53);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(597, 49);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(210, 27);
            txtPassword.TabIndex = 7;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(496, 107);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 8;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(597, 103);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(210, 27);
            txtCity.TabIndex = 9;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(496, 164);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(597, 160);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(210, 27);
            txtCountry.TabIndex = 11;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(214, 216);
            btnNew.Margin = new Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(86, 31);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(378, 216);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(539, 216);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(693, 216);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.RightToLeft = RightToLeft.No;
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(14, 341);
            dgvMember.Margin = new Padding(3, 4, 3, 4);
            dgvMember.Name = "dgvMember";
            dgvMember.ReadOnly = true;
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 25;
            dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMember.Size = new Size(887, 208);
            dgvMember.TabIndex = 18;
            dgvMember.CellDoubleClick += dgvMember_CellDoubleClick;
            // 
            // gbSortMember
            // 
            gbSortMember.Controls.Add(rbtnSortByName);
            gbSortMember.Controls.Add(rbtnSortByID);
            gbSortMember.Location = new Point(539, 258);
            gbSortMember.Name = "gbSortMember";
            gbSortMember.Size = new Size(271, 76);
            gbSortMember.TabIndex = 19;
            gbSortMember.TabStop = false;
            gbSortMember.Text = "Sort Member";
            // 
            // rbtnSortByName
            // 
            rbtnSortByName.AutoSize = true;
            rbtnSortByName.Location = new Point(64, 46);
            rbtnSortByName.Name = "rbtnSortByName";
            rbtnSortByName.Size = new Size(181, 24);
            rbtnSortByName.TabIndex = 1;
            rbtnSortByName.TabStop = true;
            rbtnSortByName.Text = "Sort Member by Name";
            rbtnSortByName.UseVisualStyleBackColor = true;
            rbtnSortByName.CheckedChanged += rbtnSortByName_CheckedChanged;
            // 
            // rbtnSortByID
            // 
            rbtnSortByID.AutoSize = true;
            rbtnSortByID.Location = new Point(64, 24);
            rbtnSortByID.Name = "rbtnSortByID";
            rbtnSortByID.Size = new Size(156, 24);
            rbtnSortByID.TabIndex = 0;
            rbtnSortByID.TabStop = true;
            rbtnSortByID.Text = "Sort Member By ID";
            rbtnSortByID.UseVisualStyleBackColor = true;
            rbtnSortByID.CheckedChanged += rbtnSortByID_CheckedChanged;
            // 
            // frmMemberManagements
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(gbSortMember);
            Controls.Add(dgvMember);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberName);
            Controls.Add(lbMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMemberManagements";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberManagements";
            Load += frmMemberManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            gbSortMember.ResumeLayout(false);
            gbSortMember.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private TextBox txtMemberID;
        private Label lbMemberName;
        private TextBox txtMemberName;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbCity;
        private TextBox txtCity;
        private Label lbCountry;
        private TextBox txtCountry;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLogout;
        private DataGridView dgvMember;
        private GroupBox gbSortMember;
        private RadioButton rbtnSortByID;
        private RadioButton rbtnSortByName;
    }
}