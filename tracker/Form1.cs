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
    public partial class Form1 : Form
    {
        public static int CurrentUserId { get; private set; }

        private MySqlConnection conn = new MySqlConnection("server=localhost;database=expenses_tracker;username=root;password=;");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();
                string query = "SELECT id, password FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseConnection.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader.GetString("password");
                            string enteredPassword = textBox2.Text;

                            if (storedPassword == enteredPassword)
                            {
                                CurrentUserId = reader.GetInt32("id");
                                MessageBox.Show("Current User ID: " + Form1.CurrentUserId);
                                AccountForm mainForm = new AccountForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Do you want to close the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
