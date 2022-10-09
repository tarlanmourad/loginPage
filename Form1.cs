namespace loginPage
{
    public partial class loginPage : Form
    {

        const string username = "t_mourad";
        const string password = "t12345";

        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                new frmSuccess().Show();
                this.Hide();
            }

            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter both Username and Password!", "Unassigned value", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            else
            {
                if (txtUsername.Text != username)
                {
                    MessageBox.Show("Invalid Username!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void checkboxChecked(object sender, EventArgs e)
        {

            if (!checkBoxPswd.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }

            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        #region useless part
        private void pswdEnter(object sender, EventArgs e)
        {
            //txtPassword.PasswordChar = '*';
        }

        private void checkboxClick(object sender, EventArgs e)
        {

        }
        #endregion
    }
}