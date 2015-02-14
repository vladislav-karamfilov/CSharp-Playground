namespace StudentInfoSystem.UI.Views
{
    using System;
    using System.Windows.Forms;
    using global::StudentInfoSystem.Controllers;
    using global::StudentInfoSystem.Data;
    using global::StudentInfoSystem.Models;

    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            this.InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var usersController = new UsersController(new StudentInfoSystemData());
            try
            {
                usersController.RegisterUser(
                    this.textBoxUsername.Text,
                    this.textBoxPassword.Text,
                    this.textBoxFacultyNumber.Text,
                    this.radioButtonTeacher.Checked ? Role.Teacher : Role.Student);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
