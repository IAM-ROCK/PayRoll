namespace PayRoll
{
    partial class Bonus
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bonus));
            panel1 = new Panel();
            BonusDGV = new DataGridView();
            DeleteBtn = new Button();
            EditBtn = new Button();
            SaveBtn = new Button();
            label1 = new Label();
            BAmountTb = new TextBox();
            label6 = new Label();
            BNameTb = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BonusDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(BonusDGV);
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(EditBtn);
            panel1.Controls.Add(SaveBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BAmountTb);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(BNameTb);
            panel1.Location = new Point(229, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(2938, 1771);
            panel1.TabIndex = 0;
            // 
            // BonusDGV
            // 
            BonusDGV.BackgroundColor = SystemColors.ButtonHighlight;
            BonusDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            BonusDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            BonusDGV.DefaultCellStyle = dataGridViewCellStyle1;
            BonusDGV.Location = new Point(964, 897);
            BonusDGV.Name = "BonusDGV";
            BonusDGV.RowHeadersWidth = 92;
            BonusDGV.RowTemplate.Height = 45;
            BonusDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BonusDGV.Size = new Size(752, 374);
            BonusDGV.TabIndex = 43;
            BonusDGV.CellContentClick += BonusDGV_CellContentClick_1;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(1552, 656);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(228, 52);
            DeleteBtn.TabIndex = 28;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(0, 192, 0);
            EditBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EditBtn.Location = new Point(1194, 656);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(228, 52);
            EditBtn.TabIndex = 27;
            EditBtn.Text = "EDIT";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Yellow;
            SaveBtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.Black;
            SaveBtn.Location = new Point(786, 656);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(228, 52);
            SaveBtn.TabIndex = 26;
            SaveBtn.Text = "SAVE";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1552, 492);
            label1.Name = "label1";
            label1.Size = new Size(201, 48);
            label1.TabIndex = 10;
            label1.Text = "AMOUNT :";
            // 
            // BAmountTb
            // 
            BAmountTb.Location = new Point(1552, 543);
            BAmountTb.Name = "BAmountTb";
            BAmountTb.Size = new Size(284, 43);
            BAmountTb.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(786, 492);
            label6.Name = "label6";
            label6.Size = new Size(146, 48);
            label6.TabIndex = 8;
            label6.Text = "NAME :";
            // 
            // BNameTb
            // 
            BNameTb.Location = new Point(786, 543);
            BNameTb.Name = "BNameTb";
            BNameTb.Size = new Size(284, 43);
            BNameTb.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3032, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(218, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(2773, 130);
            panel2.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(1659, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(151, 10);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(2130, 23);
            label5.Name = "label5";
            label5.Size = new Size(321, 57);
            label5.TabIndex = 4;
            label5.Text = "ISSUE SALARY";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 27);
            label2.Name = "label2";
            label2.Size = new Size(155, 57);
            label2.TabIndex = 0;
            label2.Text = "HOME";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1635, 27);
            label4.Name = "label4";
            label4.Size = new Size(175, 57);
            label4.TabIndex = 3;
            label4.Text = "BONUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(499, 18);
            label3.Name = "label3";
            label3.Size = new Size(245, 57);
            label3.TabIndex = 1;
            label3.Text = "EMPLOYEE";
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1030, 27);
            label7.Name = "label7";
            label7.Size = new Size(272, 57);
            label7.TabIndex = 2;
            label7.Text = "ATTEDENCE";
            label7.Click += label7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(51, 361);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 0);
            panel4.Controls.Add(pictureBox7);
            panel4.Location = new Point(27, 1153);
            panel4.Name = "panel4";
            panel4.Size = new Size(196, 141);
            panel4.TabIndex = 42;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(23, 27);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(155, 101);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(61, 702);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(143, 104);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(51, 29);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(151, 113);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(51, 1614);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(155, 107);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // Bonus
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3172, 1921);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(panel4);
            Name = "Bonus";
            Text = "Bonus";
            Load += Bonus_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BonusDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox BAmountTb;
        private Label label6;
        private TextBox BNameTb;
        private Button DeleteBtn;
        private Button EditBtn;
        private Button SaveBtn;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label7;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private DataGridView BonusDGV;
        private PictureBox pictureBox2;
    }
}