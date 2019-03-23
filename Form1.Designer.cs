namespace ReadWriteUsers
{
    partial class SAMS
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.studentspublicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Writebtn = new System.Windows.Forms.Button();
            this.Readbtn = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.studentspublicBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentspublicBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspublicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspublicBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspublicBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.StudentName,
            this.PhoneNumber,
            this.email,
            this.Module,
            this.Module2,
            this.Module3});
            this.dataGridView.DataSource = this.studentspublicBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(-4, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(758, 357);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentspublicBindingSource
            // 
            this.studentspublicBindingSource.DataSource = typeof(ReadWriteUsers.Studentspublic);
            // 
            // Writebtn
            // 
            this.Writebtn.Location = new System.Drawing.Point(612, 415);
            this.Writebtn.Name = "Writebtn";
            this.Writebtn.Size = new System.Drawing.Size(75, 23);
            this.Writebtn.TabIndex = 1;
            this.Writebtn.Text = "Write";
            this.Writebtn.UseVisualStyleBackColor = true;
            this.Writebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Readbtn
            // 
            this.Readbtn.Location = new System.Drawing.Point(693, 415);
            this.Readbtn.Name = "Readbtn";
            this.Readbtn.Size = new System.Drawing.Size(75, 23);
            this.Readbtn.TabIndex = 2;
            this.Readbtn.Text = "Read";
            this.Readbtn.UseVisualStyleBackColor = true;
            this.Readbtn.Click += new System.EventHandler(this.Readbtn_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(531, 415);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Swipe Card";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // studentspublicBindingSource2
            // 
            this.studentspublicBindingSource2.DataSource = typeof(ReadWriteUsers.Studentspublic);
            // 
            // studentspublicBindingSource1
            // 
            this.studentspublicBindingSource1.DataSource = typeof(ReadWriteUsers.Studentspublic);
            // 
            // studentID
            // 
            this.studentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentID.DataPropertyName = "StudentID";
            this.studentID.HeaderText = "StudentID";
            this.studentID.Name = "studentID";
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // Module
            // 
            this.Module.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Module.DataPropertyName = "Module";
            this.Module.HeaderText = "Module";
            this.Module.Name = "Module";
            // 
            // Module2
            // 
            this.Module2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Module2.DataPropertyName = "Module2";
            this.Module2.HeaderText = "Module2";
            this.Module2.Name = "Module2";
            // 
            // Module3
            // 
            this.Module3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Module3.DataPropertyName = "Module3";
            this.Module3.HeaderText = "Module3";
            this.Module3.Name = "Module3";
            // 
            // SAMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Readbtn);
            this.Controls.Add(this.Writebtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "SAMS";
            this.Text = "Student Attendance Monitoring System";
            this.TransparencyKey = System.Drawing.Color.Olive;
            this.Load += new System.EventHandler(this.SAMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspublicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspublicBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentspublicBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Writebtn;
        private System.Windows.Forms.Button Readbtn;
        private System.Windows.Forms.BindingSource studentspublicBindingSource;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.BindingSource studentspublicBindingSource2;
        private System.Windows.Forms.BindingSource studentspublicBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module3;
    }
}

