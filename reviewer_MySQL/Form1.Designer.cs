
namespace reviewer_MySQL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Eid_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Surname_txt = new System.Windows.Forms.TextBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewTableButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadChartButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.italyCheckBox = new System.Windows.Forms.CheckBox();
            this.usaCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.textBox_image_path = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // Eid_txt
            // 
            this.Eid_txt.Location = new System.Drawing.Point(141, 24);
            this.Eid_txt.Name = "Eid_txt";
            this.Eid_txt.Size = new System.Drawing.Size(151, 22);
            this.Eid_txt.TabIndex = 4;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(141, 66);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(151, 22);
            this.Name_txt.TabIndex = 5;
            // 
            // Surname_txt
            // 
            this.Surname_txt.Location = new System.Drawing.Point(141, 108);
            this.Surname_txt.Name = "Surname_txt";
            this.Surname_txt.Size = new System.Drawing.Size(151, 22);
            this.Surname_txt.TabIndex = 6;
            // 
            // ageComboBox
            // 
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.ageComboBox.Location = new System.Drawing.Point(141, 148);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(151, 24);
            this.ageComboBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(27, 263);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 30);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(283, 263);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 30);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(162, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 33);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewTableButton
            // 
            this.viewTableButton.Location = new System.Drawing.Point(318, 473);
            this.viewTableButton.Name = "viewTableButton";
            this.viewTableButton.Size = new System.Drawing.Size(151, 33);
            this.viewTableButton.TabIndex = 14;
            this.viewTableButton.Text = "View Table";
            this.viewTableButton.UseVisualStyleBackColor = true;
            this.viewTableButton.Click += new System.EventHandler(this.viewTableButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_Label
            // 
            this.time_Label.AutoSize = true;
            this.time_Label.Location = new System.Drawing.Point(449, 22);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(43, 17);
            this.time_Label.TabIndex = 15;
            this.time_Label.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Chart";
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(35, 541);
            this.chart1.Name = "chart1";
            series13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series13.ChartArea = "ChartArea1";
            series13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series13.Legend = "Legend1";
            series13.Name = "Age";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Score";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(476, 240);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // loadChartButton
            // 
            this.loadChartButton.Location = new System.Drawing.Point(534, 541);
            this.loadChartButton.Name = "loadChartButton";
            this.loadChartButton.Size = new System.Drawing.Size(109, 37);
            this.loadChartButton.TabIndex = 18;
            this.loadChartButton.Text = "Load Chart";
            this.loadChartButton.UseVisualStyleBackColor = true;
            this.loadChartButton.Click += new System.EventHandler(this.loadChartButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(641, 602);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(147, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Progress Bar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Gender:";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(141, 191);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 22;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(217, 193);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 23;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.italyCheckBox);
            this.groupBox1.Controls.Add(this.usaCheckBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Eid_txt);
            this.groupBox1.Controls.Add(this.Name_txt);
            this.groupBox1.Controls.Add(this.Surname_txt);
            this.groupBox1.Controls.Add(this.ageComboBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 299);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // italyCheckBox
            // 
            this.italyCheckBox.AutoSize = true;
            this.italyCheckBox.Location = new System.Drawing.Point(217, 227);
            this.italyCheckBox.Name = "italyCheckBox";
            this.italyCheckBox.Size = new System.Drawing.Size(55, 21);
            this.italyCheckBox.TabIndex = 26;
            this.italyCheckBox.Text = "Italy";
            this.italyCheckBox.UseVisualStyleBackColor = true;
            this.italyCheckBox.CheckedChanged += new System.EventHandler(this.italyCheckBox_CheckedChanged);
            // 
            // usaCheckBox
            // 
            this.usaCheckBox.AutoSize = true;
            this.usaCheckBox.Location = new System.Drawing.Point(141, 227);
            this.usaCheckBox.Name = "usaCheckBox";
            this.usaCheckBox.Size = new System.Drawing.Size(58, 21);
            this.usaCheckBox.TabIndex = 25;
            this.usaCheckBox.Text = "USA";
            this.usaCheckBox.UseVisualStyleBackColor = true;
            this.usaCheckBox.CheckedChanged += new System.EventHandler(this.usaCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Country:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(549, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 27);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Date of Birth:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(452, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(696, 55);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(102, 28);
            this.loadImageButton.TabIndex = 28;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // textBox_image_path
            // 
            this.textBox_image_path.Location = new System.Drawing.Point(452, 232);
            this.textBox_image_path.Name = "textBox_image_path";
            this.textBox_image_path.Size = new System.Drawing.Size(228, 22);
            this.textBox_image_path.TabIndex = 29;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(580, 470);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(196, 22);
            this.searchTextBox.TabIndex = 30;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Search:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(684, 498);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 37);
            this.searchButton.TabIndex = 32;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 803);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.textBox_image_path);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.loadChartButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time_Label);
            this.Controls.Add(this.viewTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Eid_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.TextBox Surname_txt;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewTableButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button loadChartButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox italyCheckBox;
        private System.Windows.Forms.CheckBox usaCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.TextBox textBox_image_path;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button searchButton;
    }
}

