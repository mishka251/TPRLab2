﻿namespace TPRLab2_2
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbProp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_FAL = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsherb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUsherb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(554, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(47, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // tbProp
            // 
            this.tbProp.Location = new System.Drawing.Point(554, 79);
            this.tbProp.Name = "tbProp";
            this.tbProp.Size = new System.Drawing.Size(47, 20);
            this.tbProp.TabIndex = 2;
            this.tbProp.TextChanged += new System.EventHandler(this.tbProp_TextChanged);
            this.tbProp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ФАЛ в базисе конъюнкция-отрицание:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вероятность опасного состояния:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ФАЛ:";
            // 
            // label_FAL
            // 
            this.label_FAL.AutoSize = true;
            this.label_FAL.Location = new System.Drawing.Point(12, 38);
            this.label_FAL.Name = "label_FAL";
            this.label_FAL.Size = new System.Drawing.Size(0, 13);
            this.label_FAL.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(491, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Название";
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Location = new System.Drawing.Point(476, 82);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(72, 13);
            this.lblProp.TabIndex = 12;
            this.lblProp.Text = "Вероятность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(869, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ущерб";
            // 
            // tbUsherb
            // 
            this.tbUsherb.Location = new System.Drawing.Point(855, 67);
            this.tbUsherb.Name = "tbUsherb";
            this.tbUsherb.Size = new System.Drawing.Size(100, 20);
            this.tbUsherb.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Оценка ущерба";
            // 
            // lblUsherb
            // 
            this.lblUsherb.AutoSize = true;
            this.lblUsherb.Location = new System.Drawing.Point(13, 179);
            this.lblUsherb.Name = "lblUsherb";
            this.lblUsherb.Size = new System.Drawing.Size(0, 13);
            this.lblUsherb.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 641);
            this.Controls.Add(this.lblUsherb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUsherb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_FAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProp);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2 (ЛВМ)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbProp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_FAL;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUsherb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUsherb;
    }
}

