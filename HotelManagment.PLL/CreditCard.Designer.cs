namespace HotelManagment.PLL
{
    partial class CreditCard
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            comboBox5 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(37, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 338);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.WindowFrame;
            textBox2.Location = new Point(281, 78);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 41);
            textBox2.TabIndex = 7;
            textBox2.Text = "CVC";
            textBox2.MouseClick += textBox2_MouseClick;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox5.ForeColor = SystemColors.WindowFrame;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(295, 153);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 40);
            comboBox5.TabIndex = 6;
            comboBox5.Text = "Type";
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(125, 253);
            button1.Name = "button1";
            button1.Size = new Size(177, 52);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(26, 153);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 40);
            textBox1.TabIndex = 4;
            textBox1.Text = "       9999 - 9999 - 9999 - 9999";
            textBox1.MouseClick += textBox1_MouseClick;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox3.ForeColor = SystemColors.WindowFrame;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(61, 79);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(76, 38);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "MM";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.WindowFrame;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(175, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(71, 40);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "YY";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // CreditCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(panel1);
            Name = "CreditCard";
            Text = "CreditCard";
            Load += CreditCard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label25;
        private Label label24;
        private Label label22;
        private TextBox RoomPrice;
        private TextBox RoomType;
        private TextBox Floor;
        private Panel panel1;
        private ComboBox comboBox2;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox5;
        private TextBox textBox2;
    }
}