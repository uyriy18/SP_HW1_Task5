
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Monday_txbx = new System.Windows.Forms.TextBox();
            this.Tuesday_txbx = new System.Windows.Forms.TextBox();
            this.Wednesday_txbx = new System.Windows.Forms.TextBox();
            this.Thursday_txbx = new System.Windows.Forms.TextBox();
            this.Friday_txbx = new System.Windows.Forms.TextBox();
            this.Saturday_txbx = new System.Windows.Forms.TextBox();
            this.Sunday_txbx = new System.Windows.Forms.TextBox();
            this.Send_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monday";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuesday";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wednesday";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thursday";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Friday";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(22, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saturday";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(22, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sunday";
            // 
            // Monday_txbx
            // 
            this.Monday_txbx.Location = new System.Drawing.Point(112, 35);
            this.Monday_txbx.Name = "Monday_txbx";
            this.Monday_txbx.Size = new System.Drawing.Size(51, 20);
            this.Monday_txbx.TabIndex = 7;
            this.Monday_txbx.TextChanged += new System.EventHandler(this.TextBox_txbx_TextChanged);
            // 
            // Tuesday_txbx
            // 
            this.Tuesday_txbx.Location = new System.Drawing.Point(112, 70);
            this.Tuesday_txbx.Name = "Tuesday_txbx";
            this.Tuesday_txbx.Size = new System.Drawing.Size(51, 20);
            this.Tuesday_txbx.TabIndex = 8;
            this.Tuesday_txbx.TextChanged += new System.EventHandler(this.TextBox_txbx_TextChanged);
            // 
            // Wednesday_txbx
            // 
            this.Wednesday_txbx.Location = new System.Drawing.Point(112, 106);
            this.Wednesday_txbx.Name = "Wednesday_txbx";
            this.Wednesday_txbx.Size = new System.Drawing.Size(51, 20);
            this.Wednesday_txbx.TabIndex = 9;
            this.Wednesday_txbx.TextChanged += new System.EventHandler(this.TextBox_txbx_TextChanged);
            // 
            // Thursday_txbx
            // 
            this.Thursday_txbx.Location = new System.Drawing.Point(112, 137);
            this.Thursday_txbx.Name = "Thursday_txbx";
            this.Thursday_txbx.Size = new System.Drawing.Size(51, 20);
            this.Thursday_txbx.TabIndex = 10;
            this.Thursday_txbx.TextChanged += new System.EventHandler(this.TextBox_txbx_TextChanged);
            // 
            // Friday_txbx
            // 
            this.Friday_txbx.Location = new System.Drawing.Point(112, 168);
            this.Friday_txbx.Name = "Friday_txbx";
            this.Friday_txbx.Size = new System.Drawing.Size(51, 20);
            this.Friday_txbx.TabIndex = 11;
            this.Friday_txbx.TextChanged += new System.EventHandler(this.TextBox_txbx_TextChanged);
            // 
            // Saturday_txbx
            // 
            this.Saturday_txbx.Location = new System.Drawing.Point(112, 201);
            this.Saturday_txbx.Name = "Saturday_txbx";
            this.Saturday_txbx.Size = new System.Drawing.Size(51, 20);
            this.Saturday_txbx.TabIndex = 12;
            this.Saturday_txbx.TextChanged += new System.EventHandler(this.TextBox_txbx_TextChanged);
            // 
            // Sunday_txbx
            // 
            this.Sunday_txbx.Location = new System.Drawing.Point(112, 232);
            this.Sunday_txbx.Name = "Sunday_txbx";
            this.Sunday_txbx.Size = new System.Drawing.Size(51, 20);
            this.Sunday_txbx.TabIndex = 13;
            this.Sunday_txbx.TextChanged += new System.EventHandler(this.TextBox_txbx_TextChanged);
            // 
            // Send_btn
            // 
            this.Send_btn.Location = new System.Drawing.Point(25, 272);
            this.Send_btn.Name = "Send_btn";
            this.Send_btn.Size = new System.Drawing.Size(75, 23);
            this.Send_btn.TabIndex = 14;
            this.Send_btn.Text = "Send data";
            this.Send_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 310);
            this.Controls.Add(this.Send_btn);
            this.Controls.Add(this.Sunday_txbx);
            this.Controls.Add(this.Saturday_txbx);
            this.Controls.Add(this.Friday_txbx);
            this.Controls.Add(this.Thursday_txbx);
            this.Controls.Add(this.Wednesday_txbx);
            this.Controls.Add(this.Tuesday_txbx);
            this.Controls.Add(this.Monday_txbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Monday_txbx;
        private System.Windows.Forms.TextBox Tuesday_txbx;
        private System.Windows.Forms.TextBox Wednesday_txbx;
        private System.Windows.Forms.TextBox Thursday_txbx;
        private System.Windows.Forms.TextBox Friday_txbx;
        private System.Windows.Forms.TextBox Saturday_txbx;
        private System.Windows.Forms.TextBox Sunday_txbx;
        private System.Windows.Forms.Button Send_btn;
    }
}

