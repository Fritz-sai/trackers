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
    public partial class ExpensesForm : Form
    {
        private int selectedId = -1;

        public ExpensesForm()
        {
            InitializeComponent();
            LoadExpensesData();
            InitializeComboBox();
            btnADD.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.AddRange(new string[] { "Food", "Bills", "Transportation", "Things" });
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                selectedId = Convert.ToInt32(row.Cells["id"].Value);
                textBox3.Text = row.Cells["amount"].Value.ToString();
                comboBox1.Text = row.Cells["category"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
            }
        }

        private void LoadExpensesData()
        {
            try
            {
                DatabaseConnection.OpenConnection();
                string query = "SELECT * FROM expenses ORDER BY date DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
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

        private decimal GetCurrentBalance()
        {
            try
            {
                DatabaseConnection.OpenConnection();
                string query = @"
                    SELECT 
                        COALESCE((SELECT SUM(amount) FROM income), 0) as total_income,
                        COALESCE((SELECT SUM(amount) FROM expenses), 0) as total_expenses";

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal totalIncome = Convert.ToDecimal(reader["total_income"]);
                            decimal totalExpenses = Convert.ToDecimal(reader["total_expenses"]);
                            return totalIncome - totalExpenses;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking balance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
            return 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal newExpenseAmount = decimal.Parse(textBox3.Text);
                decimal currentBalance = GetCurrentBalance();

                if (currentBalance < 0)
                {
                    MessageBox.Show("Cannot add expenses when balance is negative. Please add income first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newExpenseAmount > currentBalance)
                {
                    MessageBox.Show($"Cannot add expense. Current balance ({currentBalance:N2}) is insufficient for this expense ({newExpenseAmount:N2}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DatabaseConnection.OpenConnection();
                string query = "INSERT INTO expenses (amount, category, date, description) VALUES (@amount, @category, @date, @description)";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@amount", newExpenseAmount);
                    cmd.Parameters.AddWithValue("@category", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadExpensesData();
                    FormManager.Instance.RefreshDataForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Please select a record to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DatabaseConnection.OpenConnection();
                string query = "UPDATE expenses SET amount = @amount, category = @category, description = @description WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@amount", decimal.Parse(textBox3.Text));
                    cmd.Parameters.AddWithValue("@category", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Expense updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadExpensesData();
                ClearFields();
                selectedId = -1;
                FormManager.Instance.RefreshDataForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Please select a record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DatabaseConnection.OpenConnection();
                    string query = "DELETE FROM expenses WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Expense deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExpensesData();
                    ClearFields();
                    selectedId = -1;
                    FormManager.Instance.RefreshDataForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting expense: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void ClearFields()
        {
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            txtDescription.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
