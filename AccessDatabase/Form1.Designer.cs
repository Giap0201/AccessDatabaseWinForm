namespace AccessDatabase
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            labFirstName = new Label();
            labLastName = new Label();
            labClass = new Label();
            labEmail = new Label();
            labAddress = new Label();
            labAge = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtClass = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            labId = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(389, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(940, 517);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // labFirstName
            // 
            labFirstName.AutoSize = true;
            labFirstName.BackColor = SystemColors.ButtonFace;
            labFirstName.Location = new Point(69, 123);
            labFirstName.Name = "labFirstName";
            labFirstName.Size = new Size(76, 20);
            labFirstName.TabIndex = 1;
            labFirstName.Text = "FirstName";
            // 
            // labLastName
            // 
            labLastName.AutoSize = true;
            labLastName.BackColor = SystemColors.ButtonFace;
            labLastName.Location = new Point(69, 187);
            labLastName.Name = "labLastName";
            labLastName.Size = new Size(75, 20);
            labLastName.TabIndex = 2;
            labLastName.Text = "LastName";
            // 
            // labClass
            // 
            labClass.AutoSize = true;
            labClass.BackColor = SystemColors.ButtonFace;
            labClass.Location = new Point(69, 252);
            labClass.Name = "labClass";
            labClass.Size = new Size(42, 20);
            labClass.TabIndex = 3;
            labClass.Text = "Class";
            // 
            // labEmail
            // 
            labEmail.AutoSize = true;
            labEmail.BackColor = SystemColors.ButtonFace;
            labEmail.Location = new Point(69, 322);
            labEmail.Name = "labEmail";
            labEmail.Size = new Size(46, 20);
            labEmail.TabIndex = 4;
            labEmail.Text = "Email";
            // 
            // labAddress
            // 
            labAddress.AutoSize = true;
            labAddress.BackColor = SystemColors.ButtonFace;
            labAddress.Location = new Point(69, 356);
            labAddress.Name = "labAddress";
            labAddress.Size = new Size(62, 20);
            labAddress.TabIndex = 5;
            labAddress.Text = "Address";
            // 
            // labAge
            // 
            labAge.AutoSize = true;
            labAge.BackColor = SystemColors.ButtonFace;
            labAge.Location = new Point(69, 401);
            labAge.Name = "labAge";
            labAge.Size = new Size(36, 20);
            labAge.TabIndex = 6;
            labAge.Text = "Age";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(217, 123);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(217, 187);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(217, 242);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(125, 27);
            txtClass.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(217, 356);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(217, 412);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 495);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Create";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(151, 495);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(265, 495);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // labId
            // 
            labId.AutoSize = true;
            labId.BackColor = SystemColors.ButtonFace;
            labId.Location = new Point(78, 86);
            labId.Name = "labId";
            labId.Size = new Size(22, 20);
            labId.TabIndex = 16;
            labId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(215, 72);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 17;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 693);
            Controls.Add(txtId);
            Controls.Add(labId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtClass);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(labAge);
            Controls.Add(labAddress);
            Controls.Add(labEmail);
            Controls.Add(labClass);
            Controls.Add(labLastName);
            Controls.Add(labFirstName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label labFirstName;
        private Label labLastName;
        private Label labClass;
        private Label labEmail;
        private Label labAddress;
        private Label labAge;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtClass;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtAge;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label labId;
        private TextBox txtId;
    }
}
