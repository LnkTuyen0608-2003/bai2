namespace Lab02
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
            this.txtSothu1 = new System.Windows.Forms.TextBox();
            this.lblSothu1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSothu2 = new System.Windows.Forms.TextBox();
            this.lblSothu2 = new System.Windows.Forms.Label();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCauhoi = new System.Windows.Forms.Label();
            this.txtCauhoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSothu1
            // 
            this.txtSothu1.Location = new System.Drawing.Point(368, 35);
            this.txtSothu1.Name = "txtSothu1";
            this.txtSothu1.Size = new System.Drawing.Size(177, 20);
            this.txtSothu1.TabIndex = 0;
            // 
            // lblSothu1
            // 
            this.lblSothu1.AutoSize = true;
            this.lblSothu1.Location = new System.Drawing.Point(292, 41);
            this.lblSothu1.Name = "lblSothu1";
            this.lblSothu1.Size = new System.Drawing.Size(50, 13);
            this.lblSothu1.TabIndex = 1;
            this.lblSothu1.Text = "Number1";
            this.lblSothu1.Click += new System.EventHandler(this.lblSothu1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSothu2
            // 
            this.txtSothu2.Location = new System.Drawing.Point(368, 85);
            this.txtSothu2.Name = "txtSothu2";
            this.txtSothu2.Size = new System.Drawing.Size(177, 20);
            this.txtSothu2.TabIndex = 3;
            // 
            // lblSothu2
            // 
            this.lblSothu2.AutoSize = true;
            this.lblSothu2.Location = new System.Drawing.Point(295, 85);
            this.lblSothu2.Name = "lblSothu2";
            this.lblSothu2.Size = new System.Drawing.Size(50, 13);
            this.lblSothu2.TabIndex = 4;
            this.lblSothu2.Text = "Number2";
            this.lblSothu2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(298, 144);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(47, 41);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(368, 146);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(46, 38);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "X";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(436, 146);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(46, 38);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "  ";
            // 
            // lblCauhoi
            // 
            this.lblCauhoi.AutoSize = true;
            this.lblCauhoi.Location = new System.Drawing.Point(266, 223);
            this.lblCauhoi.Name = "lblCauhoi";
            this.lblCauhoi.Size = new System.Drawing.Size(42, 13);
            this.lblCauhoi.TabIndex = 4;
            this.lblCauhoi.Text = "Answer";
            this.lblCauhoi.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCauhoi
            // 
            this.txtCauhoi.Location = new System.Drawing.Point(346, 216);
            this.txtCauhoi.Name = "txtCauhoi";
            this.txtCauhoi.Size = new System.Drawing.Size(199, 20);
            this.txtCauhoi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.lblCauhoi);
            this.Controls.Add(this.lblSothu2);
            this.Controls.Add(this.txtCauhoi);
            this.Controls.Add(this.txtSothu2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSothu1);
            this.Controls.Add(this.txtSothu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSothu1;
        private System.Windows.Forms.Label lblSothu1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSothu2;
        private System.Windows.Forms.Label lblSothu2;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCauhoi;
        private System.Windows.Forms.TextBox txtCauhoi;
    }
}

