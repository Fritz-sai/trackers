using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tracker
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
            FormManager.Instance.SetDataForm(this);
            LoadAllData();
        }

        public void LoadAllData()
        {
            try
            {
                LoadIncomeData();
                LoadExpensesData();
                LoadDetailedData();
                this.Invalidate();
                this.Update();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadIncomeData()
        {
            try
            {
                DatabaseConnection.OpenConnection();
                string query = @"
                    SELECT 
                        COALESCE((SELECT SUM(amount) FROM income WHERE category = 'Salary'), 0) as salary,
                        COALESCE((SELECT SUM(amount) FROM income WHERE category = 'Business'), 0) as business,
                        COALESCE((SELECT SUM(amount) FROM income WHERE category = 'Side Income'), 0) as side_income,
                        COALESCE((SELECT SUM(amount) FROM income WHERE category = 'Allowance'), 0) as allowance";

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            salary.Text = Convert.ToDecimal(reader["salary"]).ToString("N2");
                            bussiness.Text = Convert.ToDecimal(reader["business"]).ToString("N2");
                            sideincome.Text = Convert.ToDecimal(reader["side_income"]).ToString("N2");
                            allowance.Text = Convert.ToDecimal(reader["allowance"]).ToString("N2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading income data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        public void LoadExpensesData()
        {
            try
            {
                DatabaseConnection.OpenConnection();
                string query = @"
                    SELECT 
                        COALESCE((SELECT SUM(amount) FROM expenses WHERE category = 'Food'), 0) as food_cost,
                        COALESCE((SELECT SUM(amount) FROM expenses WHERE category = 'Bills'), 0) as bills,
                        COALESCE((SELECT SUM(amount) FROM expenses WHERE category = 'Transportation'), 0) as transportation,
                        COALESCE((SELECT SUM(amount) FROM expenses WHERE category = 'Things'), 0) as things";

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foodcost.Text = Convert.ToDecimal(reader["food_cost"]).ToString("N2");
                            bills.Text = Convert.ToDecimal(reader["bills"]).ToString("N2");
                            transportation.Text = Convert.ToDecimal(reader["transportation"]).ToString("N2");
                            thing.Text = Convert.ToDecimal(reader["things"]).ToString("N2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expenses data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        public void LoadDetailedData()
        {
            try
            {
                DatabaseConnection.OpenConnection();

                // Calculate and display totals
                string totalsQuery = @"
                    SELECT 
                        COALESCE((SELECT SUM(amount) FROM income), 0) as total_income,
                        COALESCE((SELECT SUM(amount) FROM expenses), 0) as total_expenses";

                using (MySqlCommand cmd = new MySqlCommand(totalsQuery, DatabaseConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal totalIncome = Convert.ToDecimal(reader["total_income"]);
                            decimal totalExpenses = Convert.ToDecimal(reader["total_expenses"]);
                            decimal balance = totalIncome - totalExpenses;

                            // Update the existing labels with totals
                            label7.Text = $"Total Income: {totalIncome:N2}";
                            label5.Text = $"Total Expenses: {totalExpenses:N2}";
                            totalbalance.Text = $"Balance: {balance:N2}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading detailed data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
