namespace HotelManagment.PLL
{
    partial class FoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodForm));
            label1 = new Label();
            panel1 = new Panel();
            textBox3 = new TextBox();
            label2 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            panel4 = new Panel();
            button3 = new Button();
            textBox2 = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            button4 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Urdu Typesetting", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(2, -1);
            label1.Name = "label1";
            label1.Size = new Size(265, 53);
            label1.TabIndex = 0;
            label1.Text = "FOOD AND MENU";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 383);
            panel1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 351);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 29);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 5;
            label2.Text = "Food Selection";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(14, 329);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(132, 25);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Dinner   ($15)";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(238, 167);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 25);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Lunch   ($15)";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(14, 229);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 94);
            panel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(191, 94);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(238, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 29);
            textBox2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(238, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 120);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(-11, 3);
            button2.Name = "button2";
            button2.Size = new Size(191, 117);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(14, 167);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(144, 25);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Break Fast  ($7)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 29);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(14, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 120);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.lunch_new_png;
            button1.Location = new Point(-11, 6);
            button1.Name = "button1";
            button1.Size = new Size(191, 114);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(checkBox4);
            panel5.Controls.Add(checkBox5);
            panel5.Controls.Add(checkBox6);
            panel5.Location = new Point(487, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 279);
            panel5.TabIndex = 5;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(35, 167);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(202, 34);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Sweetest surprise";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(35, 114);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(98, 34);
            checkBox5.TabIndex = 6;
            checkBox5.Text = "Towels";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(35, 66);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(133, 36);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "Cleaning";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSeaGreen;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(507, 367);
            button4.Name = "button4";
            button4.Size = new Size(261, 51);
            button4.TabIndex = 6;
            button4.Text = "Next";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FoodForm";
            Text = "FoodForm";
            Load += FoodForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Panel panel4;
        private Button button3;
        private TextBox textBox2;
        private Panel panel3;
        private Button button2;
        private CheckBox checkBox1;
        private Panel panel5;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Button button4;
        private Label label2;
        private TextBox textBox3;
    }
}