namespace QLDTM
{
    partial class DangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmsdn = new System.Windows.Forms.TextBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.btdn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDTM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(860, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG THÔNG TIN TỔNG HỢP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1124, 82);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRƯỜNG ĐẠI HỌC TIỀN GIANG";
            // 
            // tbmsdn
            // 
            this.tbmsdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmsdn.Location = new System.Drawing.Point(690, 476);
            this.tbmsdn.Name = "tbmsdn";
            this.tbmsdn.Size = new System.Drawing.Size(539, 44);
            this.tbmsdn.TabIndex = 3;
            this.tbmsdn.Click += new System.EventHandler(this.tbmsdn_Click);
            this.tbmsdn.TextChanged += new System.EventHandler(this.tbmsdn_TextChanged);
            // 
            // tbmk
            // 
            this.tbmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmk.Location = new System.Drawing.Point(690, 552);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(539, 44);
            this.tbmk.TabIndex = 4;
            this.tbmk.Click += new System.EventHandler(this.tbmk_Click);
            this.tbmk.TextChanged += new System.EventHandler(this.tbmk_TextChanged);
            // 
            // btdn
            // 
            this.btdn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdn.Location = new System.Drawing.Point(874, 625);
            this.btdn.Name = "btdn";
            this.btdn.Size = new System.Drawing.Size(172, 44);
            this.btdn.TabIndex = 5;
            this.btdn.Text = "ĐĂNG NHẬP";
            this.btdn.UseVisualStyleBackColor = false;
            this.btdn.Click += new System.EventHandler(this.btdn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(114, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(331, 251);
            this.dataGridView1.TabIndex = 6;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btdn);
            this.Controls.Add(this.tbmk);
            this.Controls.Add(this.tbmsdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmsdn;
        private System.Windows.Forms.TextBox tbmk;
        private System.Windows.Forms.Button btdn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}