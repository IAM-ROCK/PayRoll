namespace PayRoll
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtm = new Button();
            EmployeeDGV = new DataGridView();
            EmpPhoneTb = new TextBox();
            label10 = new Label();
            EmpDOB = new DateTimePicker();
            label9 = new Label();
            EmpPosCb = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            EmpSalTb = new TextBox();
            EmpQualCb = new ComboBox();
            label12 = new Label();
            JDate = new DateTimePicker();
            label11 = new Label();
            EmpAddTb = new TextBox();
            label8 = new Label();
            EmpGenCb = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            EmpNameTb = new TextBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(32, 864);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(143, 104);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 1683);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(20, 1285);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(155, 101);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1264, 33);
            label3.Name = "label3";
            label3.Size = new Size(272, 57);
            label3.TabIndex = 2;
            label3.Text = "ATTEDENCE";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(2334, 33);
            label5.Name = "label5";
            label5.Size = new Size(321, 57);
            label5.TabIndex = 4;
            label5.Text = "ISSUE SALARY";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 34);
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
            label4.Location = new Point(1835, 33);
            label4.Name = "label4";
            label4.Size = new Size(175, 57);
            label4.TabIndex = 3;
            label4.Text = "BONUS";
            label4.Click += label4_Click;
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
            panel2.Location = new Point(203, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(2786, 128);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(691, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 10);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(691, 21);
            label2.Name = "label2";
            label2.Size = new Size(245, 57);
            label2.TabIndex = 1;
            label2.Text = "EMPLOYEE";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtm);
            panel1.Controls.Add(EmployeeDGV);
            panel1.Controls.Add(EmpPhoneTb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(EmpDOB);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(EmpPosCb);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(EmpSalTb);
            panel1.Controls.Add(EmpQualCb);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(JDate);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(EmpAddTb);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(EmpGenCb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(EmpNameTb);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(203, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(2972, 1772);
            panel1.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(502, 193);
            label15.Name = "label15";
            label15.Size = new Size(139, 48);
            label15.TabIndex = 26;
            label15.Text = "Name :";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(2139, 520);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(228, 63);
            DeleteBtn.TabIndex = 25;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(0, 192, 0);
            EditBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.Location = new Point(1472, 520);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(228, 63);
            EditBtn.TabIndex = 24;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtm
            // 
            SaveBtm.BackColor = Color.Yellow;
            SaveBtm.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtm.ForeColor = Color.Black;
            SaveBtm.Location = new Point(877, 520);
            SaveBtm.Name = "SaveBtm";
            SaveBtm.Size = new Size(228, 63);
            SaveBtm.TabIndex = 23;
            SaveBtm.Text = "SAVE";
            SaveBtm.UseVisualStyleBackColor = false;
            SaveBtm.Click += SaveBtm_Click;
            // 
            // EmployeeDGV
            // 
            EmployeeDGV.BackgroundColor = SystemColors.ButtonHighlight;
            EmployeeDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EmployeeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            EmployeeDGV.Location = new Point(371, 686);
            EmployeeDGV.Name = "EmployeeDGV";
            EmployeeDGV.RowHeadersWidth = 92;
            EmployeeDGV.RowTemplate.Height = 45;
            EmployeeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EmployeeDGV.Size = new Size(2315, 747);
            EmployeeDGV.TabIndex = 22;
            EmployeeDGV.CellContentClick += EmployeeDGV_CellContentClick;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.Location = new Point(2261, 389);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(284, 43);
            EmpPhoneTb.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(2252, 327);
            label10.Name = "label10";
            label10.Size = new Size(229, 48);
            label10.TabIndex = 20;
            label10.Text = "PHONE NO :";
            // 
            // EmpDOB
            // 
            EmpDOB.Location = new Point(2252, 247);
            EmpDOB.Name = "EmpDOB";
            EmpDOB.Size = new Size(293, 43);
            EmpDOB.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(2252, 179);
            label9.Name = "label9";
            label9.Size = new Size(117, 48);
            label9.TabIndex = 18;
            label9.Text = "DOB :";
            // 
            // EmpPosCb
            // 
            EmpPosCb.FormattingEnabled = true;
            EmpPosCb.Items.AddRange(new object[] { "MANAGER", "SENIOR", "JUNIOR" });
            EmpPosCb.Location = new Point(1811, 385);
            EmpPosCb.Name = "EmpPosCb";
            EmpPosCb.Size = new Size(293, 45);
            EmpPosCb.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(1811, 327);
            label14.Name = "label14";
            label14.Size = new Size(207, 48);
            label14.TabIndex = 16;
            label14.Text = "POSITION :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(1811, 196);
            label13.Name = "label13";
            label13.Size = new Size(286, 48);
            label13.TabIndex = 15;
            label13.Text = "BASIC SALARY :";
            // 
            // EmpSalTb
            // 
            EmpSalTb.Location = new Point(1813, 247);
            EmpSalTb.Name = "EmpSalTb";
            EmpSalTb.Size = new Size(284, 43);
            EmpSalTb.TabIndex = 14;
            // 
            // EmpQualCb
            // 
            EmpQualCb.FormattingEnabled = true;
            EmpQualCb.Items.AddRange(new object[] { "B.E", "M.TECH", "BCA", "MCA" });
            EmpQualCb.Location = new Point(1356, 385);
            EmpQualCb.Name = "EmpQualCb";
            EmpQualCb.Size = new Size(293, 45);
            EmpQualCb.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1356, 334);
            label12.Name = "label12";
            label12.Size = new Size(307, 48);
            label12.TabIndex = 12;
            label12.Text = "QUALIFICATION :";
            // 
            // JDate
            // 
            JDate.Location = new Point(1356, 245);
            JDate.Name = "JDate";
            JDate.Size = new Size(293, 43);
            JDate.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1356, 194);
            label11.Name = "label11";
            label11.Size = new Size(220, 48);
            label11.TabIndex = 10;
            label11.Text = "JOIN DATE :";
            // 
            // EmpAddTb
            // 
            EmpAddTb.Location = new Point(925, 245);
            EmpAddTb.Multiline = true;
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(325, 185);
            EmpAddTb.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(925, 194);
            label8.Name = "label8";
            label8.Size = new Size(202, 48);
            label8.TabIndex = 4;
            label8.Text = "ADDRESS :";
            // 
            // EmpGenCb
            // 
            EmpGenCb.FormattingEnabled = true;
            EmpGenCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            EmpGenCb.Location = new Point(502, 387);
            EmpGenCb.Name = "EmpGenCb";
            EmpGenCb.Size = new Size(293, 45);
            EmpGenCb.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(502, 336);
            label7.Name = "label7";
            label7.Size = new Size(183, 48);
            label7.TabIndex = 2;
            label7.Text = "GENDER :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(502, 196);
            label6.Name = "label6";
            label6.Size = new Size(146, 48);
            label6.TabIndex = 1;
            label6.Text = "NAME :";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(502, 247);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(284, 43);
            EmpNameTb.TabIndex = 0;
            EmpNameTb.TextChanged += EmpNameTb_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 0);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(12, 463);
            panel4.Name = "panel4";
            panel4.Size = new Size(196, 141);
            panel4.TabIndex = 10;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3023, 13);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(117, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3172, 1921);
            Controls.Add(pictureBox6);
            Controls.Add(panel4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Label label8;
        private ComboBox EmpGenCb;
        private Label label7;
        private Label label6;
        private TextBox EmpNameTb;
        private TextBox EmpAddTb;
        private Label label12;
        private DateTimePicker JDate;
        private Label label11;
        private TextBox EmpPhoneTb;
        private Label label10;
        private DateTimePicker EmpDOB;
        private Label label9;
        private ComboBox EmpPosCb;
        private Label label14;
        private Label label13;
        private TextBox EmpSalTb;
        private ComboBox EmpQualCb;
        private DataGridView EmployeeDGV;
        private Button SaveBtm;
        private Button DeleteBtn;
        private Button EditBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel panel4;
        private PictureBox pictureBox6;
        private Label label15;
    }
}