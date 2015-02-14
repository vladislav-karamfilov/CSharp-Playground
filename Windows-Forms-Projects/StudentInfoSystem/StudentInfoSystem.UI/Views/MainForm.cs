namespace StudentInfoSystem.UI.Views
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Text;
    using System.Windows.Forms;

    using global::StudentInfoSystem.Controllers;
    using global::StudentInfoSystem.Controllers.ViewModels;
    using global::StudentInfoSystem.Data;
    using global::StudentInfoSystem.Data.Migrations;
    using global::StudentInfoSystem.Models;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<StudentInfoSystemDbContext, DefaultConfiguration>());

            this.InitializeComponent();
            this.UserStatus = UserStatus.Anonymous;
            this.InitializeComponentsForUser();
        }

        public UserStatus UserStatus { get; private set; }

        private void InitializeComponentsForUser()
        {
            switch (this.UserStatus)
            {
                case UserStatus.Anonymous:
                    this.EmptyValues();
                    this.DisableAllControls();
                    this.openPictureToolStripMenuItem.Visible = false;
                    this.miStudents.Visible = false;
                    this.miUverenie.Visible = false;
                    this.miRegister.Visible = true;
                    this.menuMain.Enabled = true;
                    this.logInOutMenuItem.Text = "Login";
                    break;

                case UserStatus.Student:
                    this.EnableAllControls();
                    this.LoadOksComboboxDataSource();
                    this.LoadStatusComboboxDataSource();
                    this.openPictureToolStripMenuItem.Visible = true;
                    this.miRegister.Visible = false;
                    this.miStudents.Visible = false;
                    this.miUverenie.Visible = true;
                    this.btnAddStudent.Visible = false;
                    this.menuMain.Enabled = true;
                    this.logInOutMenuItem.Text = "Logout";
                    break;

                case UserStatus.Administrator:
                    this.EnableAllControls();
                    this.LoadOksComboboxDataSource();
                    this.LoadStatusComboboxDataSource();
                    this.openPictureToolStripMenuItem.Visible = true;
                    this.miUverenie.Visible = true;
                    this.miStudents.Visible = true;
                    this.btnAddStudent.Visible = true;
                    this.miRegister.Visible = false;
                    this.menuMain.Enabled = true;
                    this.logInOutMenuItem.Text = "Logout";
                    break;
            }
        }

        private void LoadOksComboboxDataSource()
        {
            var oksItemsList = new List<dynamic>
            {
                new { Key = Degree.Bachelor, Value = "Бакалавър" },
                new { Key = Degree.Master, Value = "Магистър" }
            };

            this.oksItemsBindingSource.DataSource = oksItemsList;
            this.comboOks.DataSource = this.oksItemsBindingSource.DataSource;

            this.comboOks.DisplayMember = "Value";
            this.comboOks.ValueMember = "Key";
        }

        private void LoadStatusComboboxDataSource()
        {
            var statusesItemsList = new List<dynamic>
            {
                new { Key = StudentStatus.Regular, Value = "Активен" },
                new { Key = StudentStatus.Interupted, Value = "Прекъснал" },
                new { Key = StudentStatus.Absolvent, Value = "Абсолвент" },
            };

            this.statusesBindingSource.DataSource = statusesItemsList;
            this.comboStatus.DataSource = this.statusesBindingSource.DataSource;

            this.comboStatus.DisplayMember = "Value";
            this.comboStatus.ValueMember = "Key";
        }

        private void EmptyValues()
        {
            this.pbStudentPhoto.Image = null;

            this.textBoxFirstName.ResetText();
            this.textBoxSecondName.ResetText();
            this.textBoxLastName.ResetText();

            this.textBoxFaculty.ResetText();
            this.textBoxSpeciality.ResetText();
            this.comboOks.DataSource = null;
            this.comboOks.ResetText();
            this.comboStatus.DataSource = null;
            this.comboStatus.ResetText();
            this.textBoxFacultyNumber.ResetText();
            this.numCourse.ResetText();
            this.textBoxPotok.ResetText();
            this.textBoxGroup.ResetText();
        }

        private void LoadStudentInfo(StudentInfoViewModel studentInfo)
        {
            if (studentInfo != null)
            {
                this.textBoxFirstName.Text = studentInfo.FirstName;
                this.textBoxSecondName.Text = studentInfo.SecondName;
                this.textBoxLastName.Text = studentInfo.LastName;
                this.textBoxFaculty.Text = studentInfo.Faculty;
                this.textBoxSpeciality.Text = studentInfo.Speciality;
                this.textBoxGroup.Text = studentInfo.Group.ToString();
                this.textBoxPotok.Text = studentInfo.Potok;
                this.textBoxFacultyNumber.Text = studentInfo.FacultyNumber;
                this.numCourse.Value = studentInfo.Course;
                this.comboOks.SelectedValue = studentInfo.Degree;
                this.comboStatus.SelectedValue = studentInfo.Status;
            }
        }

        private void EnableAllControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }

        private void DisableAllControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutBox();
            aboutForm.ShowDialog(this);
        }

        private void logInOutMenuItem_Click(object sender, EventArgs e)
        {
            if (this.UserStatus == UserStatus.Anonymous)
            {
                var loginForm = new LoginForm();
                var dialogResult = loginForm.ShowDialog(this);

                if (dialogResult == DialogResult.OK)
                {
                    switch (loginForm.User.Role)
                    {
                        case Role.Administrator:
                        case Role.Teacher:
                            this.UserStatus = UserStatus.Administrator;
                            break;
                        case Role.Student:
                            this.UserStatus = UserStatus.Student;
                            break;
                    }

                    this.InitializeComponentsForUser();

                    var studentsController = new StudentsController(new StudentInfoSystemData());
                    var studentInfo = studentsController.GetStudentInfo(loginForm.User.FacultyNumber);
                    this.LoadStudentInfo(studentInfo);
                }
            }
            else
            {
                this.UserStatus = UserStatus.Anonymous;
                this.InitializeComponentsForUser();
            }
        }

        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadStudentPicture();
        }

        private void LoadStudentPicture()
        {
            if (this.openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                this.pbStudentPhoto.ImageLocation = this.openPictureDialog.FileName;
            }
        }

        private void miUverenie_Click(object sender, EventArgs e)
        {
            var text = this.GenerateInfoText();
            var infoForm = new InfoForm(text);
            infoForm.Show();
        }

        private string GenerateInfoText()
        {
            var infoTextBuilder = new StringBuilder();

            infoTextBuilder.AppendLine("Уверение");
            infoTextBuilder.AppendFormat(
                "{0} {1} {2} е студент/ка във факултет {3}, специалност {4}, ОКС {5}, поток {6}, група {7}.{8}",
                this.textBoxFirstName.Text,
                this.textBoxSecondName.Text,
                this.textBoxLastName.Text,
                this.textBoxFaculty.Text,
                this.textBoxSpeciality.Text,
                this.comboOks.Text,
                this.textBoxPotok.Text,
                this.textBoxGroup.Text,
                Environment.NewLine);

            infoTextBuilder.AppendFormat(
                "Студентът/ката е със статус {0} в {1} курс.{2}",
                this.comboStatus.Text,
                this.numCourse.Value,
                Environment.NewLine);

            return infoTextBuilder.ToString();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                var studentInfo = new StudentInfoViewModel
                {
                    Course = (byte)this.numCourse.Value,
                    Faculty = this.textBoxFaculty.Text,
                    FacultyNumber = this.textBoxFacultyNumber.Text,
                    FirstName = this.textBoxFirstName.Text,
                    SecondName = this.textBoxSecondName.Text,
                    LastName = this.textBoxLastName.Text,
                    Status = (StudentStatus)this.comboStatus.SelectedValue,
                    Group = byte.Parse(this.textBoxGroup.Text),
                    Degree = (Degree)this.comboOks.SelectedValue,
                    Potok = this.textBoxPotok.Text,
                    Speciality = this.textBoxSpeciality.Text
                };

                var studentsContoller = new StudentsController(new StudentInfoSystemData());

                studentsContoller.AddStudent(studentInfo);
                MessageBox.Show(
                    "Успешно добавихте нов студент!",
                    "Успешно добавен студент",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void miRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog(this);
        }

        private void miStudents_Click(object sender, EventArgs e)
        {
            var groupStudentsForm = new GroupsForm();
            groupStudentsForm.ShowDialog(this);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
