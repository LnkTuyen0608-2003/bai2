namespace Lab02
{
    partial class Lap02_02
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
            this.lblQuanly = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblChuyennganh = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblNu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanly
            // 
            this.lblQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanly.Location = new System.Drawing.Point(248, 23);
            this.lblQuanly.Name = "lblQuanly";
            this.lblQuanly.Size = new System.Drawing.Size(461, 37);
            this.lblQuanly.TabIndex = 0;
            this.lblQuanly.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.lblQuanly.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(27, 88);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(70, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Mã Sinh Viên";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(27, 116);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ và tên";
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(27, 150);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioitinh.TabIndex = 0;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Location = new System.Drawing.Point(27, 185);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(48, 13);
            this.lblDiem.TabIndex = 0;
            this.lblDiem.Text = "Điểm TB";
            // 
            // lblChuyennganh
            // 
            this.lblChuyennganh.AutoSize = true;
            this.lblChuyennganh.Location = new System.Drawing.Point(27, 216);
            this.lblChuyennganh.Name = "lblChuyennganh";
            this.lblChuyennganh.Size = new System.Drawing.Size(76, 13);
            this.lblChuyennganh.TabIndex = 0;
            this.lblChuyennganh.Text = "Chuyên ngành";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Location = new System.Drawing.Point(27, 57);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(97, 13);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông tin sinh viên";
            this.lblThongtin.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(164, 80);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(145, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(164, 178);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(100, 20);
            this.txtAverageScore.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(164, 116);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(162, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(164, 216);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(121, 21);
            this.cmbFaculty.TabIndex = 2;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(164, 150);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(47, 17);
            this.optMale.TabIndex = 3;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Checked = true;
            this.optFemale.Location = new System.Drawing.Point(255, 150);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(39, 17);
            this.optFemale.TabIndex = 4;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(86, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.Location = new System.Drawing.Point(350, 78);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(494, 225);
            this.dgvStudent.TabIndex = 7;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "MSSV";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Điểm TB";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khoa";
            this.Column5.Name = "Column5";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(386, 309);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(72, 13);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "Tổng SV nam";
            // 
            // lblNu
            // 
            this.lblNu.AutoSize = true;
            this.lblNu.Location = new System.Drawing.Point(587, 309);
            this.lblNu.Name = "lblNu";
            this.lblNu.Size = new System.Drawing.Size(21, 13);
            this.lblNu.TabIndex = 8;
            this.lblNu.Text = "Nữ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(635, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Lap02_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNu);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.optFemale);
            this.Controls.Add(this.optMale);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblChuyennganh);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblQuanly);
            this.Name = "Lap02_02";
            this.Text = "Lap02_02";
            this.Load += new System.EventHandler(this.Lap02_02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanly;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblChuyennganh;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblNu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}