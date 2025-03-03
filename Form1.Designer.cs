namespace bai17_Tinhlaisuat
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
            this.txtVon = new System.Windows.Forms.TextBox();
            this.txtlaisuat = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstkq = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(94, 69);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(134, 20);
            this.txtVon.TabIndex = 0;
            this.txtVon.Text = "10000000";
            // 
            // txtlaisuat
            // 
            this.txtlaisuat.Location = new System.Drawing.Point(94, 120);
            this.txtlaisuat.Name = "txtlaisuat";
            this.txtlaisuat.Size = new System.Drawing.Size(134, 20);
            this.txtlaisuat.TabIndex = 0;
            this.txtlaisuat.Text = "7%";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(94, 169);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(134, 20);
            this.txtnam.TabIndex = 0;
            this.txtnam.Text = "10";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(357, 160);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(142, 71);
            this.btntinh.TabIndex = 1;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "lãi suất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "năm";
            // 
            // lstkq
            // 
            this.lstkq.FormattingEnabled = true;
            this.lstkq.Location = new System.Drawing.Point(39, 221);
            this.lstkq.Name = "lstkq";
            this.lstkq.Size = new System.Drawing.Size(189, 160);
            this.lstkq.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.txtlaisuat);
            this.Controls.Add(this.txtVon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.TextBox txtlaisuat;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstkq;
    }
}

