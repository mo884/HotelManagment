namespace HotelManagment.PLL
{
    partial class Login
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
            textBox1 = new TextBox();
            Userlabel = new Label();
            Passwordlabel = new Label();
            UserNametextBox = new TextBox();
            PasswordtextBox = new TextBox();
            label3 = new Label();
            LoginBtn = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkTurquoise;
            textBox1.Location = new Point(-107, -15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1266, 23);
            textBox1.TabIndex = 0;
            // 
            // Userlabel
            // 
            Userlabel.AutoSize = true;
            Userlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Userlabel.Location = new Point(27, 174);
            Userlabel.Name = "Userlabel";
            Userlabel.Size = new Size(94, 21);
            Userlabel.TabIndex = 1;
            Userlabel.Text = "User Name";
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passwordlabel.Location = new Point(39, 254);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(82, 21);
            Passwordlabel.TabIndex = 2;
            Passwordlabel.Text = "Password";
            // 
            // UserNametextBox
            // 
            UserNametextBox.BorderStyle = BorderStyle.FixedSingle;
            UserNametextBox.Cursor = Cursors.Hand;
            UserNametextBox.ForeColor = Color.LightSeaGreen;
            UserNametextBox.Location = new Point(127, 164);
            UserNametextBox.Multiline = true;
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(355, 41);
            UserNametextBox.TabIndex = 3;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Cursor = Cursors.Hand;
            PasswordtextBox.ForeColor = Color.LightSeaGreen;
            PasswordtextBox.Location = new Point(127, 245);
            PasswordtextBox.Multiline = true;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(355, 41);
            PasswordtextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(127, 11);
            label3.Name = "label3";
            label3.Size = new Size(206, 86);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.LightSeaGreen;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.AliceBlue;
            LoginBtn.Location = new Point(157, 323);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(261, 64);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSeaGreen;
            textBox2.Location = new Point(147, 97);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(46, 10);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(540, 423);
            Controls.Add(textBox2);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(PasswordtextBox);
            Controls.Add(UserNametextBox);
            Controls.Add(Passwordlabel);
            Controls.Add(Userlabel);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Userlabel;
        private Label Passwordlabel;
        private TextBox UserNametextBox;
        private TextBox PasswordtextBox;
        private Label label3;
        private Button LoginBtn;
        private TextBox textBox2;
    }
}
