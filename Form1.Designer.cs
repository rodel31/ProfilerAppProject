namespace SampleApp
{
    partial class frmProfile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnCancel = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnView = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgvData = new DataGridView();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtMname = new TextBox();
            txtContact = new TextBox();
            rtbAddress = new RichTextBox();
            lblStatus = new Label();
            pInfo = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            pInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(112, 437);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "New";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 437);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(593, 437);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(693, 437);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(493, 437);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 5;
            label1.Text = "Last Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 54);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "First Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 84);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "Middle Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 114);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 24);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 9;
            label5.Text = "Address: ";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(13, 247);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(776, 184);
            dgvData.TabIndex = 10;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(117, 17);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(259, 27);
            txtLname.TabIndex = 11;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(117, 51);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(259, 27);
            txtFname.TabIndex = 12;
            // 
            // txtMname
            // 
            txtMname.Location = new Point(117, 84);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(259, 27);
            txtMname.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(117, 116);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(259, 27);
            txtContact.TabIndex = 14;
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(426, 46);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(332, 97);
            rtbAddress.TabIndex = 15;
            rtbAddress.Text = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(18, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 23);
            lblStatus.TabIndex = 16;
            // 
            // pInfo
            // 
            pInfo.Controls.Add(txtFname);
            pInfo.Controls.Add(label1);
            pInfo.Controls.Add(rtbAddress);
            pInfo.Controls.Add(label2);
            pInfo.Controls.Add(txtContact);
            pInfo.Controls.Add(label3);
            pInfo.Controls.Add(txtMname);
            pInfo.Controls.Add(label4);
            pInfo.Controls.Add(label5);
            pInfo.Controls.Add(txtLname);
            pInfo.Enabled = false;
            pInfo.Location = new Point(13, 43);
            pInfo.Name = "pInfo";
            pInfo.Size = new Size(775, 161);
            pInfo.TabIndex = 17;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(412, 213);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(143, 20);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search by Lastname:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(561, 210);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(228, 27);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(pInfo);
            Controls.Add(lblStatus);
            Controls.Add(dgvData);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmProfile";
            Text = "Profiler App";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            pInfo.ResumeLayout(false);
            pInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgvData;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtMname;
        private TextBox txtContact;
        private RichTextBox rtbAddress;
        private Label lblStatus;
        private Panel pInfo;
        private Label lblSearch;
        private TextBox txtSearch;
    }
}
