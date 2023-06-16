namespace CSharpAssignment1
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
            this.dateTimePicker_dayOfWeek = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.longestDistance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.averageDistance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalIncome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.amount = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.numericUpDown_taxiId_home = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_endTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_startTime = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_distance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericUpDown_taxiId = new System.Windows.Forms.NumericUpDown();
            this.addTaxiButton = new System.Windows.Forms.Button();
            this.taxiIdLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.bestEarningDay_radioButton = new System.Windows.Forms.RadioButton();
            this.averageTimeLength_radioButton = new System.Windows.Forms.RadioButton();
            this.mostActiveTime_radioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_taxiId_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_distance)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_taxiId)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_dayOfWeek
            // 
            this.dateTimePicker_dayOfWeek.AllowDrop = true;
            this.dateTimePicker_dayOfWeek.CustomFormat = "dddd";
            this.dateTimePicker_dayOfWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dayOfWeek.Location = new System.Drawing.Point(287, 206);
            this.dateTimePicker_dayOfWeek.Name = "dateTimePicker_dayOfWeek";
            this.dateTimePicker_dayOfWeek.Size = new System.Drawing.Size(120, 23);
            this.dateTimePicker_dayOfWeek.TabIndex = 15;
            this.dateTimePicker_dayOfWeek.Value = new System.DateTime(2023, 6, 13, 0, 0, 0, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.longestDistance);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.averageDistance);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.totalIncome);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(686, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistic";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // longestDistance
            // 
            this.longestDistance.AutoSize = true;
            this.longestDistance.Location = new System.Drawing.Point(335, 260);
            this.longestDistance.Name = "longestDistance";
            this.longestDistance.Size = new System.Drawing.Size(98, 15);
            this.longestDistance.TabIndex = 23;
            this.longestDistance.Text = "Please insert data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Longest distance:";
            // 
            // averageDistance
            // 
            this.averageDistance.AutoSize = true;
            this.averageDistance.Location = new System.Drawing.Point(335, 209);
            this.averageDistance.Name = "averageDistance";
            this.averageDistance.Size = new System.Drawing.Size(98, 15);
            this.averageDistance.TabIndex = 21;
            this.averageDistance.Text = "Please insert data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Average Distance:";
            // 
            // totalIncome
            // 
            this.totalIncome.AutoSize = true;
            this.totalIncome.Location = new System.Drawing.Point(335, 158);
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(98, 15);
            this.totalIncome.TabIndex = 19;
            this.totalIncome.Text = "Please insert data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Income:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.amount);
            this.tabPage1.Controls.Add(this.amountLabel);
            this.tabPage1.Controls.Add(this.numericUpDown_taxiId_home);
            this.tabPage1.Controls.Add(this.dateTimePicker_dayOfWeek);
            this.tabPage1.Controls.Add(this.dateTimePicker_endTime);
            this.tabPage1.Controls.Add(this.dateTimePicker_startTime);
            this.tabPage1.Controls.Add(this.numericUpDown_distance);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.distanceLabel);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.startTimeLabel);
            this.tabPage1.Controls.Add(this.endTimeLabel);
            this.tabPage1.Controls.Add(this.dayOfWeekLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(287, 332);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(98, 15);
            this.amount.TabIndex = 18;
            this.amount.Text = "Please insert data";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(227, 332);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(54, 15);
            this.amountLabel.TabIndex = 17;
            this.amountLabel.Text = "Amount:";
            // 
            // numericUpDown_taxiId_home
            // 
            this.numericUpDown_taxiId_home.Location = new System.Drawing.Point(287, 104);
            this.numericUpDown_taxiId_home.Name = "numericUpDown_taxiId_home";
            this.numericUpDown_taxiId_home.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_taxiId_home.TabIndex = 16;
            // 
            // dateTimePicker_endTime
            // 
            this.dateTimePicker_endTime.AllowDrop = true;
            this.dateTimePicker_endTime.CustomFormat = "HH:mm";
            this.dateTimePicker_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_endTime.Location = new System.Drawing.Point(287, 170);
            this.dateTimePicker_endTime.Name = "dateTimePicker_endTime";
            this.dateTimePicker_endTime.ShowUpDown = true;
            this.dateTimePicker_endTime.Size = new System.Drawing.Size(120, 23);
            this.dateTimePicker_endTime.TabIndex = 14;
            // 
            // dateTimePicker_startTime
            // 
            this.dateTimePicker_startTime.AllowDrop = true;
            this.dateTimePicker_startTime.CustomFormat = "HH:mm";
            this.dateTimePicker_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_startTime.Location = new System.Drawing.Point(287, 137);
            this.dateTimePicker_startTime.Name = "dateTimePicker_startTime";
            this.dateTimePicker_startTime.ShowUpDown = true;
            this.dateTimePicker_startTime.Size = new System.Drawing.Size(120, 23);
            this.dateTimePicker_startTime.TabIndex = 13;
            // 
            // numericUpDown_distance
            // 
            this.numericUpDown_distance.Location = new System.Drawing.Point(287, 240);
            this.numericUpDown_distance.Name = "numericUpDown_distance";
            this.numericUpDown_distance.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_distance.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Taxi id:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(226, 248);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(55, 15);
            this.distanceLabel.TabIndex = 8;
            this.distanceLabel.Text = "Distance:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(287, 281);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 38);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(220, 143);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(61, 15);
            this.startTimeLabel.TabIndex = 1;
            this.startTimeLabel.Text = "Start time:";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(224, 176);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(57, 15);
            this.endTimeLabel.TabIndex = 2;
            this.endTimeLabel.Text = "End time:";
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Location = new System.Drawing.Point(207, 212);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(74, 15);
            this.dayOfWeekLabel.TabIndex = 5;
            this.dayOfWeekLabel.Text = "Day of week:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numericUpDown_taxiId);
            this.tabPage4.Controls.Add(this.addTaxiButton);
            this.tabPage4.Controls.Add(this.taxiIdLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(686, 474);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Taxi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_taxiId
            // 
            this.numericUpDown_taxiId.AllowDrop = true;
            this.numericUpDown_taxiId.Location = new System.Drawing.Point(287, 177);
            this.numericUpDown_taxiId.Name = "numericUpDown_taxiId";
            this.numericUpDown_taxiId.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown_taxiId.TabIndex = 9;
            // 
            // addTaxiButton
            // 
            this.addTaxiButton.Location = new System.Drawing.Point(287, 226);
            this.addTaxiButton.Name = "addTaxiButton";
            this.addTaxiButton.Size = new System.Drawing.Size(100, 38);
            this.addTaxiButton.TabIndex = 8;
            this.addTaxiButton.Text = "Add Taxi";
            this.addTaxiButton.UseVisualStyleBackColor = true;
            this.addTaxiButton.Click += new System.EventHandler(this.addTaxiButton_Click);
            // 
            // taxiIdLabel
            // 
            this.taxiIdLabel.AutoSize = true;
            this.taxiIdLabel.Location = new System.Drawing.Point(230, 185);
            this.taxiIdLabel.Name = "taxiIdLabel";
            this.taxiIdLabel.Size = new System.Drawing.Size(43, 15);
            this.taxiIdLabel.TabIndex = 5;
            this.taxiIdLabel.Text = "Taxi id:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.bestEarningDay_radioButton);
            this.tabPage2.Controls.Add(this.averageTimeLength_radioButton);
            this.tabPage2.Controls.Add(this.mostActiveTime_radioButton);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 474);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bestEarningDay_radioButton
            // 
            this.bestEarningDay_radioButton.AutoSize = true;
            this.bestEarningDay_radioButton.Location = new System.Drawing.Point(511, 205);
            this.bestEarningDay_radioButton.Name = "bestEarningDay_radioButton";
            this.bestEarningDay_radioButton.Size = new System.Drawing.Size(113, 19);
            this.bestEarningDay_radioButton.TabIndex = 6;
            this.bestEarningDay_radioButton.TabStop = true;
            this.bestEarningDay_radioButton.Text = "Best Earning Day";
            this.bestEarningDay_radioButton.UseVisualStyleBackColor = true;
            // 
            // averageTimeLength_radioButton
            // 
            this.averageTimeLength_radioButton.AutoSize = true;
            this.averageTimeLength_radioButton.Location = new System.Drawing.Point(511, 180);
            this.averageTimeLength_radioButton.Name = "averageTimeLength_radioButton";
            this.averageTimeLength_radioButton.Size = new System.Drawing.Size(137, 19);
            this.averageTimeLength_radioButton.TabIndex = 5;
            this.averageTimeLength_radioButton.TabStop = true;
            this.averageTimeLength_radioButton.Text = "Average Time Length";
            this.averageTimeLength_radioButton.UseVisualStyleBackColor = true;
            // 
            // mostActiveTime_radioButton
            // 
            this.mostActiveTime_radioButton.AutoSize = true;
            this.mostActiveTime_radioButton.Location = new System.Drawing.Point(511, 155);
            this.mostActiveTime_radioButton.Name = "mostActiveTime_radioButton";
            this.mostActiveTime_radioButton.Size = new System.Drawing.Size(117, 19);
            this.mostActiveTime_radioButton.TabIndex = 4;
            this.mostActiveTime_radioButton.TabStop = true;
            this.mostActiveTime_radioButton.Text = "Most Active Time";
            this.mostActiveTime_radioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "COMPANY HISTORY";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 369);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(670, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(457, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Taxi Company";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_taxiId_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_distance)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_taxiId)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabPage tabPage3;
        private TabPage tabPage1;
        private DateTimePicker dateTimePicker_dayOfWeek;
        private DateTimePicker dateTimePicker_endTime;
        private DateTimePicker dateTimePicker_startTime;
        private NumericUpDown numericUpDown_distance;
        private Label label1;
        private Label distanceLabel;
        private Button calculateButton;
        private Label startTimeLabel;
        private Label endTimeLabel;
        private Label dayOfWeekLabel;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private Button addTaxiButton;
        private Label taxiIdLabel;
        private NumericUpDown numericUpDown_taxiId;
        private NumericUpDown numericUpDown_taxiId_home;
        private Label amount;
        private Label amountLabel;
        private Label totalIncome;
        private Label label3;
        private Label averageDistance;
        private Label label4;
        private Label longestDistance;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button1;
        private RadioButton bestEarningDay_radioButton;
        private RadioButton averageTimeLength_radioButton;
        private RadioButton mostActiveTime_radioButton;
        private ToolStripMenuItem importToolStripMenuItem;
    }
}