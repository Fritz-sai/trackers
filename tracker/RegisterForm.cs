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
using System.Security.Cryptography;

namespace tracker
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
           
            btnsignup.Click += Btnsignup_Click;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Hide the current form
        }

        private void Btnsignup_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if username already exists
                DatabaseConnection.OpenConnection();
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, DatabaseConnection.GetConnection()))
                {
                    checkCmd.Parameters.AddWithValue("@username", textBox1.Text);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert new user
                string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, DatabaseConnection.GetConnection()))
                {
                    insertCmd.Parameters.AddWithValue("@username", textBox1.Text);
                    insertCmd.Parameters.AddWithValue("@password", textBox2.Text);
                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields and return to login form
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Do you want to close the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void chbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowpassword.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}
