namespace PayRoll
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            AttNumCb = new ComboBox();
            ExcusedTb = new TextBox();
            AbsTb = new TextBox();
            label16 = new Label();
            label14 = new Label();
            label9 = new Label();
            BonusTb = new TextBox();
            BonusIdCb = new ComboBox();
            SalDate = new DateTimePicker();
            BaseSalaryTb = new TextBox();
            BalanceTb = new TextBox();
            label15 = new Label();
            AdvanceTb = new TextBox();
            EmpIdCb = new ComboBox();
            SalaryDGV = new DataGridView();
            PresTb = new TextBox();
            label10 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            EmpNameTb = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 0);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(12, 1560);
            panel4.Name = "panel4";
            panel4.Size = new Size(196, 141);
            panel4.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 401);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1941, 605);
            button3.Name = "button3";
            button3.Size = new Size(228, 52);
            button3.TabIndex = 25;
            button3.Text = "COMPUTE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(679, 605);
            button1.Name = "button1";
            button1.Size = new Size(228, 52);
            button1.TabIndex = 23;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(AttNumCb);
            panel1.Controls.Add(ExcusedTb);
            panel1.Controls.Add(AbsTb);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(BonusTb);
            panel1.Controls.Add(BonusIdCb);
            panel1.Controls.Add(SalDate);
            panel1.Controls.Add(BaseSalaryTb);
            panel1.Controls.Add(BalanceTb);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(AdvanceTb);
            panel1.Controls.Add(EmpIdCb);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SalaryDGV);
            panel1.Controls.Add(PresTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpNameTb);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(224, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(2936, 1766);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // AttNumCb
            // 
            AttNumCb.FormattingEnabled = true;
            AttNumCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            AttNumCb.Location = new Point(1941, 369);
            AttNumCb.Name = "AttNumCb";
            AttNumCb.Size = new Size(249, 45);
            AttNumCb.TabIndex = 41;
            AttNumCb.SelectionChangeCommitted += AttNumCb_SelectionChangeCommitted_1;
            // 
            // ExcusedTb
            // 
            ExcusedTb.Enabled = false;
            ExcusedTb.Location = new Point(2309, 518);
            ExcusedTb.Name = "ExcusedTb";
            ExcusedTb.Size = new Size(199, 43);
            ExcusedTb.TabIndex = 40;
            // 
            // AbsTb
            // 
            AbsTb.Enabled = false;
            AbsTb.Location = new Point(2299, 371);
            AbsTb.Name = "AbsTb";
            AbsTb.Size = new Size(199, 43);
            AbsTb.TabIndex = 39;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(2309, 465);
            label16.Name = "label16";
            label16.Size = new Size(174, 48);
            label16.TabIndex = 38;
            label16.Text = "Excused :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(2299, 304);
            label14.Name = "label14";
            label14.Size = new Size(158, 48);
            label14.TabIndex = 37;
            label14.Text = "Absent :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1960, 304);
            label9.Name = "label9";
            label9.Size = new Size(232, 48);
            label9.TabIndex = 36;
            label9.Text = "Attendence :";
            // 
            // BonusTb
            // 
            BonusTb.Enabled = false;
            BonusTb.Location = new Point(1625, 518);
            BonusTb.Name = "BonusTb";
            BonusTb.Size = new Size(284, 43);
            BonusTb.TabIndex = 34;
            // 
            // BonusIdCb
            // 
            BonusIdCb.FormattingEnabled = true;
            BonusIdCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            BonusIdCb.Location = new Point(1616, 369);
            BonusIdCb.Name = "BonusIdCb";
            BonusIdCb.Size = new Size(293, 45);
            BonusIdCb.TabIndex = 33;
            BonusIdCb.SelectionChangeCommitted += BonusIdCb_SelectionChangeCommitted;
            // 
            // SalDate
            // 
            SalDate.Location = new Point(1271, 516);
            SalDate.Name = "SalDate";
            SalDate.Size = new Size(293, 43);
            SalDate.TabIndex = 32;
            SalDate.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // BaseSalaryTb
            // 
            BaseSalaryTb.Enabled = false;
            BaseSalaryTb.Location = new Point(1237, 371);
            BaseSalaryTb.Name = "BaseSalaryTb";
            BaseSalaryTb.Size = new Size(284, 43);
            BaseSalaryTb.TabIndex = 30;
            // 
            // BalanceTb
            // 
            BalanceTb.Location = new Point(910, 516);
            BalanceTb.Name = "BalanceTb";
            BalanceTb.Size = new Size(284, 43);
            BalanceTb.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(910, 465);
            label15.Name = "label15";
            label15.Size = new Size(201, 48);
            label15.TabIndex = 28;
            label15.Text = "BALANCE :";
            // 
            // AdvanceTb
            // 
            AdvanceTb.Location = new Point(566, 513);
            AdvanceTb.Name = "AdvanceTb";
            AdvanceTb.Size = new Size(237, 43);
            AdvanceTb.TabIndex = 27;
            // 
            // EmpIdCb
            // 
            EmpIdCb.FormattingEnabled = true;
            EmpIdCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            EmpIdCb.Location = new Point(554, 365);
            EmpIdCb.Name = "EmpIdCb";
            EmpIdCb.Size = new Size(249, 45);
            EmpIdCb.TabIndex = 26;
            EmpIdCb.SelectedIndexChanged += EmpIdCb_SelectedIndexChanged;
            EmpIdCb.SelectionChangeCommitted += EmpIdCb_SelectionChangeCommitted;
            // 
            // SalaryDGV
            // 
            SalaryDGV.BackgroundColor = SystemColors.ButtonHighlight;
            SalaryDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalaryDGV.GridColor = SystemColors.ButtonHighlight;
            SalaryDGV.Location = new Point(432, 823);
            SalaryDGV.Name = "SalaryDGV";
            SalaryDGV.RowHeadersWidth = 92;
            SalaryDGV.RowTemplate.Height = 45;
            SalaryDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalaryDGV.Size = new Size(2104, 527);
            SalaryDGV.TabIndex = 22;
            SalaryDGV.CellContentClick += SalaryDGV_CellContentClick;
            // 
            // PresTb
            // 
            PresTb.Enabled = false;
            PresTb.Location = new Point(1974, 518);
            PresTb.Name = "PresTb";
            PresTb.Size = new Size(199, 43);
            PresTb.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1960, 467);
            label10.Name = "label10";
            label10.Size = new Size(188, 48);
            label10.TabIndex = 20;
            label10.Text = "Presence :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(1606, 304);
            label13.Name = "label13";
            label13.Size = new Size(164, 48);
            label13.TabIndex = 15;
            label13.Text = "BONUS :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1261, 465);
            label12.Name = "label12";
            label12.Size = new Size(170, 48);
            label12.TabIndex = 12;
            label12.Text = "PERIOD :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1261, 304);
            label11.Name = "label11";
            label11.Size = new Size(272, 48);
            label11.TabIndex = 10;
            label11.Text = "BASE SALARY :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(554, 304);
            label8.Name = "label8";
            label8.Size = new Size(266, 48);
            label8.TabIndex = 4;
            label8.Text = "EMPLOYEE ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(566, 444);
            label7.Name = "label7";
            label7.Size = new Size(208, 48);
            label7.TabIndex = 2;
            label7.Text = "ADVANCE :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(910, 304);
            label6.Name = "label6";
            label6.Size = new Size(146, 48);
            label6.TabIndex = 1;
            label6.Text = "NAME :";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Enabled = false;
            EmpNameTb.Location = new Point(910, 365);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(284, 43);
            EmpNameTb.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(2299, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 10);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(533, 23);
            label2.Name = "label2";
            label2.Size = new Size(245, 57);
            label2.TabIndex = 1;
            label2.Text = "EMPLOYEE";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(224, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(2775, 113);
            panel2.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(2290, 23);
            label5.Name = "label5";
            label5.Size = new Size(321, 57);
            label5.TabIndex = 4;
            label5.Text = "ISSUE SALARY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 23);
            label1.Name = "label1";
            label1.Size = new Size(155, 57);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1729, 23);
            label4.Name = "label4";
            label4.Size = new Size(175, 57);
            label4.TabIndex = 3;
            label4.Text = "BONUS";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1105, 23);
            label3.Name = "label3";
            label3.Size = new Size(272, 57);
            label3.TabIndex = 2;
            label3.Text = "ATTEDENCE";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(35, 1148);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(155, 121);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(47, 727);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(143, 104);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3020, 47);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(117, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3172, 1921);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Name = "Salary";
            Text = "Salary";
            Load += Salary_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryDGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button3;
        private Button button1;
        private Panel panel1;
        private DataGridView SalaryDGV;
        private TextBox PresTb;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox EmpNameTb;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private ComboBox EmpIdCb;
        private DateTimePicker SalDate;
        private TextBox textBox7;
        private TextBox BaseSalaryTb;
        private TextBox BalanceTb;
        private Label label15;
        private TextBox AdvanceTb;
        private PictureBox pictureBox6;
        private TextBox BonusTb;
        private ComboBox BonusIdCb;
        private TextBox ExcusedTb;
        private TextBox AbsTb;
        private Label label16;
        private Label label9;
        private ComboBox AttNumCb;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}