namespace BKS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttnLgn = new Button();
            passWord = new TextBox();
            userName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // bttnLgn
            // 
            bttnLgn.BackColor = Color.MediumSlateBlue;
            bttnLgn.FlatAppearance.BorderSize = 0;
            bttnLgn.FlatStyle = FlatStyle.Flat;
            bttnLgn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bttnLgn.ForeColor = Color.White;
            bttnLgn.Location = new Point(549, 211);
            bttnLgn.Name = "bttnLgn";
            bttnLgn.Size = new Size(96, 29);
            bttnLgn.TabIndex = 0;
            bttnLgn.Text = "Giriş Yap";
            bttnLgn.UseVisualStyleBackColor = true;
            bttnLgn.Click += bttnLgn_Click;
            // 
            // passWord
            // 
            passWord.Location = new Point(521, 159);
            passWord.Name = "passWord";
            passWord.Size = new Size(124, 23);
            passWord.TabIndex = 1;
            // 
            // userName
            // 
            userName.Location = new Point(521, 116);
            userName.Name = "userName";
            userName.Size = new Size(124, 23);
            userName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 119);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 162);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(501, 290);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Son Giriş:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userName);
            Controls.Add(passWord);
            Controls.Add(bttnLgn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnLgn;
        private TextBox passWord;
        private TextBox userName;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
