namespace StudentInfoSystem.UI.Views
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using global::StudentInfoSystem.Controllers;
    using global::StudentInfoSystem.Data;
    
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            this.InitializeComponent();
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            var studentsController = new StudentsController(new StudentInfoSystemData());
            this.studentsDataGrid.DataSource = studentsController.GetStudentsInGroup().ToList();
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
        }
    }
}
