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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbmsdn = new System.Windows.Forms.TextBox();
            this.tbmk = new System.Windows.Forms.TextBox();
            this.btdn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG THÔNG TIN TỔNG HỢP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(943, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRƯỜNG ĐẠI HỌC TIỀN GIANG";
            // 
            // tbmsdn
            // 
            this.tbmsdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmsdn.Location = new System.Drawing.Point(613, 381);
            this.tbmsdn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmsdn.Name = "tbmsdn";
            this.tbmsdn.Size = new System.Drawing.Size(480, 38);
            this.tbmsdn.TabIndex = 3;
            this.tbmsdn.Click += new System.EventHandler(this.tbmsdn_Click);
            this.tbmsdn.TextChanged += new System.EventHandler(this.tbmsdn_TextChanged);
            // 
            // tbmk
            // 
            this.tbmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmk.Location = new System.Drawing.Point(613, 442);
            this.tbmk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmk.Name = "tbmk";
            this.tbmk.Size = new System.Drawing.Size(480, 38);
            this.tbmk.TabIndex = 4;
            this.tbmk.Click += new System.EventHandler(this.tbmk_Click);
            this.tbmk.TextChanged += new System.EventHandler(this.tbmk_TextChanged);
            // 
            // btdn
            // 
            this.btdn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdn.Location = new System.Drawing.Point(777, 500);
            this.btdn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btdn.Name = "btdn";
            this.btdn.Size = new System.Drawing.Size(153, 35);
            this.btdn.TabIndex = 5;
            this.btdn.Text = "ĐĂNG NHẬP";
            this.btdn.UseVisualStyleBackColor = false;
            this.btdn.Click += new System.EventHandler(this.btdn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 385);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(294, 201);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDTM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(764, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btdn);
            this.Controls.Add(this.tbmk);
            this.Controls.Add(this.tbmsdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangNhap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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