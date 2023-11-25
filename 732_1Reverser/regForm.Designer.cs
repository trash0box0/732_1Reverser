namespace _732_1Reverser
{
    partial class regForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regPwd1TB = new System.Windows.Forms.TextBox();
            this.regLoginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regPwd2TB = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // regPwd1TB
            // 
            this.regPwd1TB.Location = new System.Drawing.Point(12, 122);
            this.regPwd1TB.Name = "regPwd1TB";
            this.regPwd1TB.Size = new System.Drawing.Size(592, 31);
            this.regPwd1TB.TabIndex = 5;
            // 
            // regLoginTB
            // 
            this.regLoginTB.Location = new System.Drawing.Point(12, 36);
            this.regLoginTB.Name = "regLoginTB";
            this.regLoginTB.Size = new System.Drawing.Size(592, 31);
            this.regLoginTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Повторить пароль";
            // 
            // regPwd2TB
            // 
            this.regPwd2TB.Location = new System.Drawing.Point(12, 188);
            this.regPwd2TB.Name = "regPwd2TB";
            this.regPwd2TB.Size = new System.Drawing.Size(592, 31);
            this.regPwd2TB.TabIndex = 8;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(15, 235);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(225, 34);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 296);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regPwd2TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regPwd1TB);
            this.Controls.Add(this.regLoginTB);
            this.Name = "regForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox regPwd1TB;
        private TextBox regLoginTB;
        private Label label3;
        private TextBox regPwd2TB;
        private Button regButton;
    }
}