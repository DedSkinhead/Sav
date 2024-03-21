namespace Med
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
            tabPage2 = new TabPage();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            tab1 = new TabPage();
            button4 = new Button();
            button1 = new Button();
            label1 = new Label();
            SearchTextBox = new TextBox();
            monthCalendar1 = new MonthCalendar();
            PatientData = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            button3 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            dataGridView3 = new DataGridView();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientData).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(checkBox2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(922, 444);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Прививки";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 10);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 21;
            label2.Text = "Возраст";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(910, 403);
            dataGridView2.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(506, 10);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 19);
            checkBox2.TabIndex = 20;
            checkBox2.Text = "Предстоящие";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(379, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 10);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 17;
            label5.Text = "Поиск";
            // 
            // button2
            // 
            button2.Location = new Point(225, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = true;
            // 
            // tab1
            // 
            tab1.Controls.Add(button4);
            tab1.Controls.Add(button1);
            tab1.Controls.Add(label1);
            tab1.Controls.Add(SearchTextBox);
            tab1.Controls.Add(monthCalendar1);
            tab1.Controls.Add(PatientData);
            tab1.Location = new Point(4, 24);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(922, 444);
            tab1.TabIndex = 0;
            tab1.Text = "Главная";
            tab1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(492, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Перейти";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(222, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Поиск";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(54, 3);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(162, 23);
            SearchTextBox.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 3);
            monthCalendar1.Location = new Point(578, -7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // PatientData
            // 
            PatientData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientData.Location = new Point(6, 32);
            PatientData.Name = "PatientData";
            PatientData.Size = new Size(561, 406);
            PatientData.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 472);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 444);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Профосмотр";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 14);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 15;
            label4.Text = "Возраст";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(509, 14);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Предстоящие";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(382, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(228, 10);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Найти";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Поиск";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 10);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 10;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(5, 39);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(911, 399);
            dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 481);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientData).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tab1;
        private MonthCalendar monthCalendar1;
        private DataGridView PatientData;
        private TabControl tabControl1;
        private Label label1;
        private TextBox SearchTextBox;
        private Button button1;
        private DataGridView dataGridView2;
        private TabPage tabPage1;
        private Label label4;
        private CheckBox checkBox1;
        private ComboBox comboBox2;
        private Button button3;
        private Label label3;
        private TextBox textBox3;
        private DataGridView dataGridView3;
        private Label label2;
        private CheckBox checkBox2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Button button2;
        private Button button4;
    }
}
