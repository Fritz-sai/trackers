namespace tracker
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel2 = new Panel();
            chbShowpassword = new CheckBox();
            label6 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            btnsignup = new Button();
            textBox1 = new TextBox();
            btnlogin = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(chbShowpassword);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnsignup);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(229, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 370);
            panel2.TabIndex = 3;
            // 
            // chbShowpassword
            // 
            chbShowpassword.AutoSize = true;
            chbShowpassword.FlatStyle = FlatStyle.Popup;
            chbShowpassword.Location = new Point(105, 254);
            chbShowpassword.Name = "chbShowpassword";
            chbShowpassword.Size = new Size(106, 19);
            chbShowpassword.TabIndex = 8;
            chbShowpassword.Text = "Show Password";
            chbShowpassword.UseVisualStyleBackColor = true;
            chbShowpassword.CheckedChanged += chbShowpassword_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 207);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 7;
            label6.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.Location = new Point(198, 3);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 145);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 93);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // btnsignup
            // 
            btnsignup.Location = new Point(59, 322);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(106, 25);
            btnsignup.TabIndex = 3;
            btnsignup.Text = "SIGN UP";
            btnsignup.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 0;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(58, 265);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(122, 25);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "LOG IN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 370);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(82, 195);
            label5.Name = "label5";
            label5.Size = new Size(78, 30);
            label5.TabIndex = 7;
            label5.Text = "Tracker";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(69, 163);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 6;
            label4.Text = "Expenses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(69, 166);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 5;
            label3.Text = "Expenses";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 9;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 10;
            textBox3.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(457, 373);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button btnsignup;
        private TextBox textBox1;
        private Button btnlogin;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label6;
        private CheckBox chbShowpassword;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}