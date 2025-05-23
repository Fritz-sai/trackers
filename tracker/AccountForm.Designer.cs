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
            panel1 = new Panel();
            lblname = new Label();
            pictureBox1 = new PictureBox();
            btnlogout = new Button();
            btnexpenses = new Button();
            btnincome = new Button();
            btndata = new Button();
            panel10 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox1.Location = new Point(34, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 69);
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
            panel10.BackColor = SystemColors.ActiveBorder;
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(146, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(805, 519);
            panel10.TabIndex = 4;
            panel10.Paint += panel10_Paint;
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
    }
}