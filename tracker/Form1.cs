using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace tracker
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn = new MySqlConnection("server=localhost;database=dbdaniel;username=root;password=;");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
            this.Hide(); // Hide the current form
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}
