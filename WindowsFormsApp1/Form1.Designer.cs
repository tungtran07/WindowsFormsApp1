
namespace WindowsFormsApp1
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
            this.soThuNhat = new System.Windows.Forms.Label();
            this.soThuHai = new System.Windows.Forms.Label();
            this.ketQua = new System.Windows.Forms.Label();
            this.labelKQ = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soThuNhat
            // 
            this.soThuNhat.AutoSize = true;
            this.soThuNhat.Location = new System.Drawing.Point(104, 68);
            this.soThuNhat.Name = "soThuNhat";
            this.soThuNhat.Size = new System.Drawing.Size(81, 17);
            this.soThuNhat.TabIndex = 0;
            this.soThuNhat.Text = "Số thứ nhất";
            // 
            // soThuHai
            // 
            this.soThuHai.AutoSize = true;
            this.soThuHai.Location = new System.Drawing.Point(104, 118);
            this.soThuHai.Name = "soThuHai";
            this.soThuHai.Size = new System.Drawing.Size(72, 17);
            this.soThuHai.TabIndex = 0;
            this.soThuHai.Text = "Số thứ hai";
            // 
            // ketQua
            // 
            this.ketQua.AutoSize = true;
            this.ketQua.Location = new System.Drawing.Point(104, 248);
            this.ketQua.Name = "ketQua";
            this.ketQua.Size = new System.Drawing.Size(57, 17);
            this.ketQua.TabIndex = 0;
            this.ketQua.Text = "Kết quả";
            // 
            // labelKQ
            // 
            this.labelKQ.AutoSize = true;
            this.labelKQ.Location = new System.Drawing.Point(177, 248);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(16, 17);
            this.labelKQ.TabIndex = 0;
            this.labelKQ.Text = "0";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(244, 62);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(100, 22);
            this.txtSoThuNhat.TabIndex = 1;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(244, 115);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(100, 22);
            this.txtSoThuHai.TabIndex = 1;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(74, 194);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.ketQua);
            this.Controls.Add(this.soThuHai);
            this.Controls.Add(this.soThuNhat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soThuNhat;
        private System.Windows.Forms.Label soThuHai;
        private System.Windows.Forms.Label ketQua;
        private System.Windows.Forms.Label labelKQ;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

