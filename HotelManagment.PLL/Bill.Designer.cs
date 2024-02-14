namespace HotelManagment.PLL
{
    partial class Bill
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
            RoomBill = new Label();
            FOODBILL = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // RoomBill
            // 
            RoomBill.AutoSize = true;
            RoomBill.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomBill.Location = new Point(152, 75);
            RoomBill.Name = "RoomBill";
            RoomBill.Size = new Size(208, 32);
            RoomBill.TabIndex = 0;
            RoomBill.Text = "Room Bill           :";
            // 
            // FOODBILL
            // 
            FOODBILL.AutoSize = true;
            FOODBILL.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FOODBILL.Location = new Point(152, 131);
            FOODBILL.Name = "FOODBILL";
            FOODBILL.Size = new Size(205, 32);
            FOODBILL.TabIndex = 1;
            FOODBILL.Text = "Food Bill            :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 233);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Total :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 89);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 145);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(265, 241);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(414, 317);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkCyan;
            button1.Location = new Point(469, 216);
            button1.Name = "button1";
            button1.Size = new Size(117, 42);
            button1.TabIndex = 10;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 394);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(FOODBILL);
            Controls.Add(RoomBill);
            Name = "Bill";
            Text = "Bill";
            Load += Bill_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoomBill;
        private Label FOODBILL;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
    }
}