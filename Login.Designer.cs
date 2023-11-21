namespace PayRoll
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            button2 = new Button();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            txt_password = new TextBox();
            txt_adminname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(txt_adminname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(813, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(2362, 1897);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1173, 1126);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 41;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(2213, 31);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(117, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1173, 1033);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(1085, 882);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(352, 43);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_adminname
            // 
            txt_adminname.Location = new Point(1085, 660);
            txt_adminname.Name = "txt_adminname";
            txt_adminname.Size = new Size(352, 43);
            txt_adminname.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(694, 863);
            label4.Name = "label4";
            label4.Size = new Size(334, 65);
            label4.TabIndex = 1;
            label4.Text = "PASSWORD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(666, 650);
            label3.Name = "label3";
            label3.Size = new Size(392, 65);
            label3.TabIndex = 0;
            label3.Text = "ADMIN NAME :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 1897);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(226, 1018);
            panel4.Name = "panel4";
            panel4.Size = new Size(218, 10);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(32, 937);
            panel3.Name = "panel3";
            panel3.Size = new Size(644, 10);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(226, 963);
            label2.Name = "label2";
            label2.Size = new Size(217, 65);
            label2.TabIndex = 2;
            label2.Text = "SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 882);
            label1.Name = "label1";
            label1.Size = new Size(666, 65);
            label1.TabIndex = 1;
            label1.Text = "EMPLOYEE MANAGEMENT ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 584);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 227);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3172, 1921);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox txt_password;
        private TextBox txt_adminname;
        private PictureBox pictureBox6;
        private Button button2;
    }
}