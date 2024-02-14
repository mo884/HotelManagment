namespace HotelManagement.WindowsFormsUI
{
    partial class Kitchen
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
            metroTabControl1 = new TabControl();
            TodoTabPage = new TabPage();
            onTheLineLabel = new Label();
            roomNLabel = new Label();
            floorNLabel = new Label();
            roomTypeLabel = new Label();
            Todo = new GroupBox();
            dinnerQTLabel = new Label();
            lunchQTLabel = new Label();
            breakfastQTLabel = new Label();
            breakfastTextBox = new TextBox();
            foodSelectionButton = new Button();
            supplyCheckBox = new CheckBox();
            lunchTextBox = new TextBox();
            towelCheckBox = new CheckBox();
            dinnerTextBox = new TextBox();
            cleaningCheckBox = new CheckBox();
            surpriseCheckBox = new CheckBox();
            floorNTextBox = new TextBox();
            roomNTextBox = new TextBox();
            roomTypeTextBox = new TextBox();
            phoneNTextBox = new TextBox();
            queueListBox = new ListBox();
            nameLabel = new Label();
            phoneNLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            overviewTabPage = new TabPage();
            overviewDataGridView = new DataGridView();
            metroTabControl1.SuspendLayout();
            TodoTabPage.SuspendLayout();
            Todo.SuspendLayout();
            overviewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).BeginInit();
            SuspendLayout();
            // 
            // metroTabControl1
            // 
            metroTabControl1.Controls.Add(TodoTabPage);
            metroTabControl1.Controls.Add(overviewTabPage);
            metroTabControl1.Dock = DockStyle.Fill;
            metroTabControl1.ForeColor = Color.Lime;
            metroTabControl1.Location = new Point(0, 0);
            metroTabControl1.Margin = new Padding(4);
            metroTabControl1.Name = "metroTabControl1";
            metroTabControl1.SelectedIndex = 1;
            metroTabControl1.Size = new Size(1166, 562);
            metroTabControl1.TabIndex = 0;
            // 
            // TodoTabPage
            // 
            TodoTabPage.Controls.Add(onTheLineLabel);
            TodoTabPage.Controls.Add(roomNLabel);
            TodoTabPage.Controls.Add(floorNLabel);
            TodoTabPage.Controls.Add(roomTypeLabel);
            TodoTabPage.Controls.Add(Todo);
            TodoTabPage.Controls.Add(floorNTextBox);
            TodoTabPage.Controls.Add(roomNTextBox);
            TodoTabPage.Controls.Add(roomTypeTextBox);
            TodoTabPage.Controls.Add(phoneNTextBox);
            TodoTabPage.Controls.Add(queueListBox);
            TodoTabPage.Controls.Add(nameLabel);
            TodoTabPage.Controls.Add(phoneNLabel);
            TodoTabPage.Controls.Add(firstNameTextBox);
            TodoTabPage.Controls.Add(lastNameTextBox);
            TodoTabPage.ForeColor = Color.ForestGreen;
            TodoTabPage.Location = new Point(4, 24);
            TodoTabPage.Margin = new Padding(4);
            TodoTabPage.Name = "TodoTabPage";
            TodoTabPage.Size = new Size(1158, 534);
            TodoTabPage.TabIndex = 0;
            TodoTabPage.Text = "TODO*";
            // 
            // onTheLineLabel
            // 
            onTheLineLabel.AutoSize = true;
            onTheLineLabel.BackColor = Color.Transparent;
            onTheLineLabel.ForeColor = SystemColors.ControlText;
            onTheLineLabel.Location = new Point(825, 34);
            onTheLineLabel.Margin = new Padding(4, 0, 4, 0);
            onTheLineLabel.Name = "onTheLineLabel";
            onTheLineLabel.Size = new Size(65, 15);
            onTheLineLabel.TabIndex = 61;
            onTheLineLabel.Text = "On the line";
            // 
            // roomNLabel
            // 
            roomNLabel.AutoSize = true;
            roomNLabel.BackColor = Color.Transparent;
            roomNLabel.ForeColor = SystemColors.ControlText;
            roomNLabel.Location = new Point(34, 294);
            roomNLabel.Margin = new Padding(4, 0, 4, 0);
            roomNLabel.Name = "roomNLabel";
            roomNLabel.Size = new Size(49, 15);
            roomNLabel.TabIndex = 58;
            roomNLabel.Text = "Room #";
            // 
            // floorNLabel
            // 
            floorNLabel.AutoSize = true;
            floorNLabel.BackColor = Color.Transparent;
            floorNLabel.ForeColor = SystemColors.ControlText;
            floorNLabel.Location = new Point(223, 223);
            floorNLabel.Margin = new Padding(4, 0, 4, 0);
            floorNLabel.Name = "floorNLabel";
            floorNLabel.Size = new Size(44, 15);
            floorNLabel.TabIndex = 57;
            floorNLabel.Text = "Floor #";
            // 
            // roomTypeLabel
            // 
            roomTypeLabel.AutoSize = true;
            roomTypeLabel.BackColor = Color.Transparent;
            roomTypeLabel.ForeColor = SystemColors.ControlText;
            roomTypeLabel.Location = new Point(34, 223);
            roomTypeLabel.Margin = new Padding(4, 0, 4, 0);
            roomTypeLabel.Name = "roomTypeLabel";
            roomTypeLabel.Size = new Size(65, 15);
            roomTypeLabel.TabIndex = 56;
            roomTypeLabel.Text = "Room type";
            // 
            // Todo
            // 
            Todo.BackColor = Color.Transparent;
            Todo.BackgroundImageLayout = ImageLayout.None;
            Todo.Controls.Add(dinnerQTLabel);
            Todo.Controls.Add(lunchQTLabel);
            Todo.Controls.Add(breakfastQTLabel);
            Todo.Controls.Add(breakfastTextBox);
            Todo.Controls.Add(foodSelectionButton);
            Todo.Controls.Add(supplyCheckBox);
            Todo.Controls.Add(lunchTextBox);
            Todo.Controls.Add(towelCheckBox);
            Todo.Controls.Add(dinnerTextBox);
            Todo.Controls.Add(cleaningCheckBox);
            Todo.Controls.Add(surpriseCheckBox);
            Todo.FlatStyle = FlatStyle.Flat;
            Todo.Location = new Point(410, 52);
            Todo.Margin = new Padding(4);
            Todo.Name = "Todo";
            Todo.Padding = new Padding(4);
            Todo.Size = new Size(407, 373);
            Todo.TabIndex = 55;
            Todo.TabStop = false;
            Todo.Text = "Todo";
            // 
            // dinnerQTLabel
            // 
            dinnerQTLabel.AutoSize = true;
            dinnerQTLabel.BackColor = Color.Transparent;
            dinnerQTLabel.ForeColor = SystemColors.ControlText;
            dinnerQTLabel.Location = new Point(20, 100);
            dinnerQTLabel.Margin = new Padding(4, 0, 4, 0);
            dinnerQTLabel.Name = "dinnerQTLabel";
            dinnerQTLabel.Size = new Size(74, 15);
            dinnerQTLabel.TabIndex = 63;
            dinnerQTLabel.Text = "Dinner [QTY]";
            // 
            // lunchQTLabel
            // 
            lunchQTLabel.AutoSize = true;
            lunchQTLabel.BackColor = Color.Transparent;
            lunchQTLabel.ForeColor = SystemColors.ControlText;
            lunchQTLabel.Location = new Point(209, 28);
            lunchQTLabel.Margin = new Padding(4, 0, 4, 0);
            lunchQTLabel.Name = "lunchQTLabel";
            lunchQTLabel.Size = new Size(72, 15);
            lunchQTLabel.TabIndex = 62;
            lunchQTLabel.Text = "Lunch [QTY]";
            // 
            // breakfastQTLabel
            // 
            breakfastQTLabel.AutoSize = true;
            breakfastQTLabel.BackColor = Color.Transparent;
            breakfastQTLabel.ForeColor = SystemColors.ControlText;
            breakfastQTLabel.Location = new Point(20, 28);
            breakfastQTLabel.Margin = new Padding(4, 0, 4, 0);
            breakfastQTLabel.Name = "breakfastQTLabel";
            breakfastQTLabel.Size = new Size(87, 15);
            breakfastQTLabel.TabIndex = 61;
            breakfastQTLabel.Text = "Breakfast [QTY]";
            // 
            // breakfastTextBox
            // 
            breakfastTextBox.BackColor = Color.White;
            breakfastTextBox.Enabled = false;
            breakfastTextBox.Location = new Point(20, 53);
            breakfastTextBox.Margin = new Padding(4);
            breakfastTextBox.Name = "breakfastTextBox";
            breakfastTextBox.PlaceholderText = "Breakfast";
            breakfastTextBox.Size = new Size(180, 23);
            breakfastTextBox.TabIndex = 47;
            // 
            // foodSelectionButton
            // 
            foodSelectionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            foodSelectionButton.ForeColor = Color.Green;
            foodSelectionButton.Location = new Point(20, 319);
            foodSelectionButton.Margin = new Padding(4);
            foodSelectionButton.Name = "foodSelectionButton";
            foodSelectionButton.Size = new Size(370, 36);
            foodSelectionButton.TabIndex = 59;
            foodSelectionButton.Text = "Change food selection?";
            foodSelectionButton.Visible = false;
            foodSelectionButton.Click += foodSelectionButton_Click;
            // 
            // supplyCheckBox
            // 
            supplyCheckBox.AutoSize = true;
            supplyCheckBox.BackColor = Color.Transparent;
            supplyCheckBox.ForeColor = SystemColors.ControlText;
            supplyCheckBox.Location = new Point(147, 274);
            supplyCheckBox.Margin = new Padding(4);
            supplyCheckBox.Name = "supplyCheckBox";
            supplyCheckBox.Size = new Size(136, 19);
            supplyCheckBox.TabIndex = 42;
            supplyCheckBox.Text = "Food/Supply status ?";
            supplyCheckBox.UseVisualStyleBackColor = false;
            // 
            // lunchTextBox
            // 
            lunchTextBox.BackColor = Color.White;
            lunchTextBox.Enabled = false;
            lunchTextBox.Location = new Point(209, 53);
            lunchTextBox.Margin = new Padding(4);
            lunchTextBox.Name = "lunchTextBox";
            lunchTextBox.PlaceholderText = "Lunch";
            lunchTextBox.Size = new Size(180, 23);
            lunchTextBox.TabIndex = 48;
            // 
            // towelCheckBox
            // 
            towelCheckBox.BackColor = Color.Transparent;
            towelCheckBox.Enabled = false;
            towelCheckBox.ForeColor = SystemColors.ControlText;
            towelCheckBox.Location = new Point(158, 196);
            towelCheckBox.Margin = new Padding(4);
            towelCheckBox.Name = "towelCheckBox";
            towelCheckBox.Size = new Size(90, 34);
            towelCheckBox.TabIndex = 52;
            towelCheckBox.Text = "Towels";
            towelCheckBox.UseVisualStyleBackColor = false;
            // 
            // dinnerTextBox
            // 
            dinnerTextBox.BackColor = Color.White;
            dinnerTextBox.Enabled = false;
            dinnerTextBox.Location = new Point(20, 126);
            dinnerTextBox.Margin = new Padding(4);
            dinnerTextBox.Name = "dinnerTextBox";
            dinnerTextBox.PlaceholderText = "Dinner";
            dinnerTextBox.Size = new Size(369, 23);
            dinnerTextBox.TabIndex = 49;
            // 
            // cleaningCheckBox
            // 
            cleaningCheckBox.BackColor = Color.Transparent;
            cleaningCheckBox.Enabled = false;
            cleaningCheckBox.ForeColor = SystemColors.ControlText;
            cleaningCheckBox.Location = new Point(25, 196);
            cleaningCheckBox.Margin = new Padding(4);
            cleaningCheckBox.Name = "cleaningCheckBox";
            cleaningCheckBox.Size = new Size(90, 34);
            cleaningCheckBox.TabIndex = 51;
            cleaningCheckBox.Text = "Cleaning";
            cleaningCheckBox.UseVisualStyleBackColor = false;
            // 
            // surpriseCheckBox
            // 
            surpriseCheckBox.BackColor = Color.Transparent;
            surpriseCheckBox.Enabled = false;
            surpriseCheckBox.ForeColor = SystemColors.ControlText;
            surpriseCheckBox.Location = new Point(255, 197);
            surpriseCheckBox.Margin = new Padding(4);
            surpriseCheckBox.Name = "surpriseCheckBox";
            surpriseCheckBox.Size = new Size(141, 32);
            surpriseCheckBox.TabIndex = 50;
            surpriseCheckBox.Text = "Sweetest Surprise";
            surpriseCheckBox.UseVisualStyleBackColor = false;
            // 
            // floorNTextBox
            // 
            floorNTextBox.BackColor = Color.White;
            floorNTextBox.Enabled = false;
            floorNTextBox.Location = new Point(221, 248);
            floorNTextBox.Margin = new Padding(4);
            floorNTextBox.Name = "floorNTextBox";
            floorNTextBox.PlaceholderText = "Floor #";
            floorNTextBox.Size = new Size(180, 23);
            floorNTextBox.TabIndex = 46;
            // 
            // roomNTextBox
            // 
            roomNTextBox.BackColor = Color.White;
            roomNTextBox.Enabled = false;
            roomNTextBox.Location = new Point(36, 320);
            roomNTextBox.Margin = new Padding(4);
            roomNTextBox.Name = "roomNTextBox";
            roomNTextBox.PlaceholderText = "Room #";
            roomNTextBox.Size = new Size(368, 23);
            roomNTextBox.TabIndex = 45;
            // 
            // roomTypeTextBox
            // 
            roomTypeTextBox.BackColor = Color.White;
            roomTypeTextBox.Enabled = false;
            roomTypeTextBox.Location = new Point(34, 248);
            roomTypeTextBox.Margin = new Padding(4);
            roomTypeTextBox.Name = "roomTypeTextBox";
            roomTypeTextBox.PlaceholderText = "Room type";
            roomTypeTextBox.Size = new Size(180, 23);
            roomTypeTextBox.TabIndex = 44;
            // 
            // phoneNTextBox
            // 
            phoneNTextBox.BackColor = Color.White;
            phoneNTextBox.Enabled = false;
            phoneNTextBox.ForeColor = Color.Lime;
            phoneNTextBox.Location = new Point(36, 178);
            phoneNTextBox.Margin = new Padding(4);
            phoneNTextBox.Name = "phoneNTextBox";
            phoneNTextBox.PlaceholderText = "(999)-999-9999";
            phoneNTextBox.Size = new Size(368, 23);
            phoneNTextBox.TabIndex = 43;
            // 
            // queueListBox
            // 
            queueListBox.FormattingEnabled = true;
            queueListBox.ItemHeight = 15;
            queueListBox.Location = new Point(825, 60);
            queueListBox.Margin = new Padding(4);
            queueListBox.Name = "queueListBox";
            queueListBox.Size = new Size(260, 364);
            queueListBox.TabIndex = 40;
            queueListBox.SelectedIndexChanged += queueListBox_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.ForeColor = SystemColors.ControlText;
            nameLabel.Location = new Point(34, 80);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name";
            // 
            // phoneNLabel
            // 
            phoneNLabel.AutoSize = true;
            phoneNLabel.BackColor = Color.Transparent;
            phoneNLabel.ForeColor = SystemColors.ControlText;
            phoneNLabel.Location = new Point(35, 152);
            phoneNLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNLabel.Name = "phoneNLabel";
            phoneNLabel.Size = new Size(86, 15);
            phoneNLabel.TabIndex = 30;
            phoneNLabel.Text = "Phone number";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.White;
            firstNameTextBox.Enabled = false;
            firstNameTextBox.ForeColor = Color.White;
            firstNameTextBox.Location = new Point(35, 105);
            firstNameTextBox.Margin = new Padding(4);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "First";
            firstNameTextBox.Size = new Size(180, 23);
            firstNameTextBox.TabIndex = 21;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.White;
            lastNameTextBox.Enabled = false;
            lastNameTextBox.Location = new Point(223, 105);
            lastNameTextBox.Margin = new Padding(4);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Last";
            lastNameTextBox.Size = new Size(180, 23);
            lastNameTextBox.TabIndex = 22;
            // 
            // overviewTabPage
            // 
            overviewTabPage.Controls.Add(overviewDataGridView);
            overviewTabPage.Location = new Point(4, 24);
            overviewTabPage.Margin = new Padding(4);
            overviewTabPage.Name = "overviewTabPage";
            overviewTabPage.Size = new Size(1158, 534);
            overviewTabPage.TabIndex = 1;
            overviewTabPage.Text = "Overview";
            // 
            // overviewDataGridView
            // 
            overviewDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            overviewDataGridView.Location = new Point(11, 23);
            overviewDataGridView.Margin = new Padding(4);
            overviewDataGridView.Name = "overviewDataGridView";
            overviewDataGridView.RowHeadersWidth = 51;
            overviewDataGridView.Size = new Size(1134, 563);
            overviewDataGridView.TabIndex = 2;
            // 
            // Kitchen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1166, 562);
            Controls.Add(metroTabControl1);
            Margin = new Padding(4);
            Name = "Kitchen";
            Text = "Room Service";
            FormClosing += Kitchen_FormClosing;
            Load += Kitchen_Load;
            metroTabControl1.ResumeLayout(false);
            TodoTabPage.ResumeLayout(false);
            TodoTabPage.PerformLayout();
            Todo.ResumeLayout(false);
            Todo.PerformLayout();
            overviewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)overviewDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl metroTabControl1;
        private TabPage TodoTabPage;
        private TabPage overviewTabPage;
        private System.Windows.Forms.DataGridView overviewDataGridView;
        private Label nameLabel;
        private Label phoneNLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private System.Windows.Forms.ListBox queueListBox;
        private TextBox phoneNTextBox;
        private CheckBox supplyCheckBox;
        private TextBox floorNTextBox;
        private TextBox roomNTextBox;
        private TextBox roomTypeTextBox;
        private CheckBox towelCheckBox;
        private CheckBox cleaningCheckBox;
        private CheckBox surpriseCheckBox;
        private TextBox dinnerTextBox;
        private TextBox lunchTextBox;
        private TextBox breakfastTextBox;
        private System.Windows.Forms.GroupBox Todo;
        private Label roomNLabel;
        private Label floorNLabel;
        private Label roomTypeLabel;
        private Button foodSelectionButton;
        private Label dinnerQTLabel;
        private Label lunchQTLabel;
        private Label breakfastQTLabel;
        private Label onTheLineLabel;
    }
}