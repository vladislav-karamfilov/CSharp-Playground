namespace StudentInfoSystem.UI.Views
{
    using System;
    using System.Windows.Forms;

    using global::StudentInfoSystem.Controllers;
    using global::StudentInfoSystem.Controllers.ViewModels;
    using global::StudentInfoSystem.Data;

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.InitializeComponent();
        }

        public UserViewModel User { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.textBoxUsername.ResetText();
            this.textBoxPassword.ResetText();
            
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginController = new UsersController(new StudentInfoSystemData());
            try
            {
                var user = loginController.LoginUser(this.textBoxUsername.Text, this.textBoxPassword.Text);
                this.User = user;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
