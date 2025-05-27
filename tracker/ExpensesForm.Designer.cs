namespace tracker
{
    partial class ExpensesForm
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtDescription = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnADD = new Button();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(283, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 450);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(457, 371);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 0;
            label1.Text = "Expenses";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnADD);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 450);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(26, 180);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 13;
            label4.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(26, 198);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 23);
            txtDescription.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(28, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Amount";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(28, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(28, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(227, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(26, 336);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(229, 34);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnADD
            // 
            btnADD.BackColor = Color.FromArgb(0, 192, 0);
            btnADD.FlatStyle = FlatStyle.Flat;
            btnADD.ForeColor = SystemColors.ButtonHighlight;
            btnADD.Location = new Point(26, 285);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(229, 34);
            btnADD.TabIndex = 2;
            btnADD.Text = "Add";
            btnADD.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(26, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 58);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 14;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 117);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 15;
            label6.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 180);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 16;
            label7.Text = "Description";
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExpensesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpensesForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnADD;
        private Label label2;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}