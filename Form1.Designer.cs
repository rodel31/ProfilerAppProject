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
            btnUpdate = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(112, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(490, 384);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(590, 384);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(388, 384);
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
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 5;
            label1.Text = "Last Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "First Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 76);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "Middle Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 106);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 16);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 9;
            label5.Text = "Address: ";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 156);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(776, 222);
            dgvData.TabIndex = 10;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(122, 9);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(284, 27);
            txtLname.TabIndex = 11;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(122, 43);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(284, 27);
            txtFname.TabIndex = 12;
            // 
            // txtMname
            // 
            txtMname.Location = new Point(122, 76);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(284, 27);
            txtMname.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(122, 108);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(284, 27);
            txtContact.TabIndex = 14;
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(431, 38);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(357, 97);
            rtbAddress.TabIndex = 15;
            rtbAddress.Text = "";
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbAddress);
            Controls.Add(txtContact);
            Controls.Add(txtMname);
            Controls.Add(txtFname);
            Controls.Add(txtLname);
            Controls.Add(dgvData);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmProfile";
            Text = "Profiler App";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button btnUpdate;
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
    }
}
