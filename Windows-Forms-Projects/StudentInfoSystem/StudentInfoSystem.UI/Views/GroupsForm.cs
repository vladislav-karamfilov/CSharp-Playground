namespace StudentInfoSystem.UI.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    using global::StudentInfoSystem.Controllers;
    using global::StudentInfoSystem.Data;
    using global::StudentInfoSystem.Data.Contracts;

    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            this.InitializeComponent();
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            var data = new StudentInfoSystemData();
            var studentsController = new StudentsController(data);
            this.studentsDataGrid.DataSource = studentsController.GetStudentsInGroup().ToList();
            this.LoadGroupsComboboxDataSource(data);
        }

        private void btnGroupFilter_Click(object sender, EventArgs e)
        {
            var studentsController = new StudentsController(new StudentInfoSystemData());
            if (!string.IsNullOrWhiteSpace(this.comboBoxGroup.Text))
            {
                int group;
                if (int.TryParse(this.comboBoxGroup.Text, out group))
                {
                    this.studentsDataGrid.DataSource = studentsController.GetStudentsInGroup(group).ToList();
                }
                else
                {
                    MessageBox.Show("Групата трябва да е число!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.studentsDataGrid.DataSource = studentsController.GetStudentsInGroup().ToList();
            }
        }

        private void LoadGroupsComboboxDataSource(IStudentInfoSystemData data)
        {
            var groupsList = data.Students.All().GroupBy(x => x.Group).Select(x => new { x.Key, Value = x.Key }).ToList();

            this.comboGroupsBindingSource.DataSource = groupsList;
            this.comboBoxGroup.DataSource = this.comboGroupsBindingSource.DataSource;

            this.comboBoxGroup.DisplayMember = "Value";
            this.comboBoxGroup.ValueMember = "Key";
        }
    }
}
