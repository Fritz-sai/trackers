namespace tracker
{
    partial class adminForm
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
            btnLogout = new Button();
            label1 = new Label();
            userView = new DataGridView();
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 53);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(725, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(85, 26);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            // 
            // userView
            // 
            userView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userView.Dock = DockStyle.Fill;
            userView.Location = new Point(0, 53);
            userView.Name = "userView";
            userView.Size = new Size(822, 425);
            userView.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 423);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 55);
            panel2.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 15);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(725, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 26);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(634, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 26);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 478);
            Controls.Add(panel2);
            Controls.Add(userView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Button btnAdd;
        private Label label1;
        private DataGridView userView;
        private Panel panel2;
        private Button btnLogout;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}