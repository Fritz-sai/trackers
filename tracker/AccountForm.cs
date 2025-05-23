using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tracker
{
    public partial class AccountForm : Form
    {
        private DataForm dataForm;
        private IncomeForm incomeForm;
        private ExpensesForm expensesForm;

        public AccountForm()
        {
            InitializeComponent();
            TestDatabaseConnection();
            btndata.Click += Btndata_Click;
            btnincome.Click += Btnincome_Click;
            btnexpenses.Click += Btnexpenses_Click;
            btnlogout.Click += Btnlogout_Click;
        }

        private void TestDatabaseConnection()
        {
            if (!DatabaseConnection.TestConnection())
            {
                MessageBox.Show("Cannot connect to database. Please make sure:\n" +
                    "1. MySQL server is running\n" +
                    "2. Database 'expenses_tracker' exists\n" +
                    "3. Username and password are correct",
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ShowForm(Form form)
        {
            panel10.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel10.Controls.Add(form);
            form.Show();
        }

        private void Btndata_Click(object sender, EventArgs e)
        {
            if (dataForm == null)
            {
                dataForm = new DataForm();
            }
            ShowForm(dataForm);
        }

        private void Btnincome_Click(object sender, EventArgs e)
        {
            if (incomeForm == null)
            {
                incomeForm = new IncomeForm();
            }
            ShowForm(incomeForm);
        }

        private void Btnexpenses_Click(object sender, EventArgs e)
        {
            if (expensesForm == null)
            {
                expensesForm = new ExpensesForm();
            }
            ShowForm(expensesForm);
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndata_Click_1(object sender, EventArgs e)
        {

        }
    }
}
