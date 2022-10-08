
namespace nguyenminhthuan_
{
    partial class Form2
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
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_nhan = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số x";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(82, 37);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(250, 20);
            this.txt_x.TabIndex = 1;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(82, 63);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(250, 20);
            this.txt_y.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số y";
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Enabled = false;
            this.txt_ketqua.Location = new System.Drawing.Point(82, 89);
            this.txt_ketqua.Multiline = true;
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(250, 169);
            this.txt_ketqua.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(15, 277);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(64, 28);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(128, 277);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(64, 28);
            this.btn_cong.TabIndex = 7;
            this.btn_cong.Text = "Cộng";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Location = new System.Drawing.Point(198, 277);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(64, 28);
            this.btn_nhan.TabIndex = 8;
            this.btn_nhan.Text = "Nhân";
            this.btn_nhan.UseVisualStyleBackColor = true;
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(268, 277);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(64, 28);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_nhan);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_nhan;
        private System.Windows.Forms.Button btn_thoat;
    }
}