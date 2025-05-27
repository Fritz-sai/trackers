using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tracker
{
    public partial class income : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;database=expenses_tracker;username=root;password=;");
        private int selectedId = -1;
        public income()
        {
            InitializeComponent();
            LoadIncomeData();
            comboBox1.Items.AddRange(new string[] { "Salary", "Business", "Side Income", "Allowance" });

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                selectedId = Convert.ToInt32(row.Cells["id"].Value);
                txtAmount.Text = row.Cells["amount"].Value.ToString();
                comboBox1.Text = row.Cells["category"].Value.ToString();
                txtDescription.Text = row.Cells["description"].Value.ToString();
            }
        }
        private void LoadIncomeData()
        {
            try
            {
                DatabaseConnection.OpenConnection();
                string query = "SELECT * FROM income WHERE user_id = @userId ORDER BY date DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@userId", Form1.CurrentUserId);
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
                MessageBox.Show("Error loading income data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DatabaseConnection.OpenConnection();
                string query = "INSERT INTO income (user_id, amount, category, date, description) VALUES (@userId, @amount, @category, @date, @description)";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@userId", Form1.CurrentUserId);
                    cmd.Parameters.AddWithValue("@amount", decimal.Parse(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@category", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadIncomeData();
                    FormManager.Instance.RefreshDataForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding income: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DatabaseConnection.OpenConnection();
                string query = "UPDATE income SET amount = @amount, category = @category, description = @description WHERE id = @id AND user_id = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@amount", decimal.Parse(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@category", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.Parameters.AddWithValue("@userId", Form1.CurrentUserId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Income updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIncomeData();
                ClearFields();
                selectedId = -1;
                FormManager.Instance.RefreshDataForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating income: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string query = "DELETE FROM income WHERE id = @id AND user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.Parameters.AddWithValue("@userId", Form1.CurrentUserId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Income deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIncomeData();
                    ClearFields();
                    selectedId = -1;
                    FormManager.Instance.RefreshDataForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting income: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }

        }
        private void ClearFields()
        {
            txtAmount.Clear();
            comboBox1.SelectedIndex = -1;
            txtDescription.Clear();
        }
    }
}
