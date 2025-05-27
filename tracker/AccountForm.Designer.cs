namespace tracker
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            panel1 = new Panel();
            lblname = new Label();
            pictureBox1 = new PictureBox();
            btnlogout = new Button();
            btnexpenses = new Button();
            btnincome = new Button();
            btndata = new Button();
            panel10 = new Panel();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(lblname);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnexpenses);
            panel1.Controls.Add(btnincome);
            panel1.Controls.Add(btndata);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 519);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.Green;
            lblname.ForeColor = SystemColors.ButtonHighlight;
            lblname.Location = new Point(54, 91);
            lblname.Name = "lblname";
            lblname.Size = new Size(37, 15);
            lblname.TabIndex = 5;
            lblname.Text = "name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = SystemColors.ButtonFace;
            btnlogout.Location = new Point(12, 404);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(119, 34);
            btnlogout.TabIndex = 3;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnexpenses
            // 
            btnexpenses.BackColor = SystemColors.ButtonFace;
            btnexpenses.Location = new Point(12, 254);
            btnexpenses.Name = "btnexpenses";
            btnexpenses.Size = new Size(119, 34);
            btnexpenses.TabIndex = 2;
            btnexpenses.Text = "Expenses";
            btnexpenses.UseVisualStyleBackColor = false;
            // 
            // btnincome
            // 
            btnincome.BackColor = SystemColors.ButtonFace;
            btnincome.Location = new Point(12, 204);
            btnincome.Name = "btnincome";
            btnincome.Size = new Size(119, 34);
            btnincome.TabIndex = 1;
            btnincome.Text = "Income";
            btnincome.UseVisualStyleBackColor = false;
            // 
            // btndata
            // 
            btndata.BackColor = SystemColors.ButtonFace;
            btndata.Location = new Point(12, 152);
            btndata.Name = "btndata";
            btndata.Size = new Size(119, 34);
            btndata.TabIndex = 0;
            btndata.Text = "Data";
            btndata.UseVisualStyleBackColor = false;
            btndata.Click += btndata_Click_1;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ButtonFace;
            panel10.Controls.Add(panel3);
            panel10.Controls.Add(panel5);
            panel10.Controls.Add(panel4);
            panel10.Controls.Add(panel6);
            panel10.Controls.Add(panel2);
            panel10.Controls.Add(label2);
            panel10.Controls.Add(label1);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(146, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(805, 519);
            panel10.TabIndex = 4;
            panel10.Paint += panel10_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 0);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label7);
            panel3.ForeColor = Color.FromArgb(128, 255, 128);
            panel3.Location = new Point(60, 353);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 133);
            panel3.TabIndex = 7;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(26, 35);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(116, 79);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(170, 15);
            label7.TabIndex = 0;
            label7.Text = "reduce unnecessary spending";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 192, 0);
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(label6);
            panel5.ForeColor = Color.FromArgb(128, 255, 128);
            panel5.Location = new Point(562, 344);
            panel5.Name = "panel5";
            panel5.Size = new Size(168, 133);
            panel5.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(26, 35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(116, 79);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(135, 21);
            label6.TabIndex = 0;
            label6.Text = "Future reference";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 0);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label5);
            panel4.ForeColor = Color.FromArgb(128, 255, 128);
            panel4.Location = new Point(559, 166);
            panel4.Name = "panel4";
            panel4.Size = new Size(168, 133);
            panel4.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 79);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 0;
            label5.Text = "Better budgeting";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 192, 0);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label4);
            panel6.ForeColor = Color.FromArgb(128, 255, 128);
            panel6.Location = new Point(302, 264);
            panel6.Name = "panel6";
            panel6.Size = new Size(168, 133);
            panel6.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(26, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 0;
            label4.Text = "Savings goals";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.FromArgb(128, 255, 128);
            panel2.Location = new Point(57, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 133);
            panel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 0;
            label3.Text = "Awareness ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 106);
            label2.Name = "label2";
            label2.Size = new Size(681, 20);
            label2.TabIndex = 1;
            label2.Text = " is a personal finance management system designed to help users monitor and control their spending.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 61);
            label1.Name = "label1";
            label1.Size = new Size(329, 45);
            label1.TabIndex = 0;
            label1.Text = "The Expenses Tracker ";
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 519);
            Controls.Add(panel10);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblname;
        private PictureBox pictureBox1;
        private Button btnlogout;
        private Button btnexpenses;
        private Button btnincome;
        private Button btndata;
        private Panel panel10;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Label label7;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label label4;
    }
}