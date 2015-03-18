namespace StudentInfoSystem.UI.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInOutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUverenie = new System.Windows.Forms.ToolStripMenuItem();
            this.miStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlStudentInfo = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.textBoxPotok = new System.Windows.Forms.TextBox();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.numCourse = new System.Windows.Forms.NumericUpDown();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblPotok = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboOks = new System.Windows.Forms.ComboBox();
            this.textBoxFacultyNumber = new System.Windows.Forms.TextBox();
            this.textBoxSpeciality = new System.Windows.Forms.TextBox();
            this.textBoxFaculty = new System.Windows.Forms.TextBox();
            this.lblFacultyNumber = new System.Windows.Forms.Label();
            this.lblSpeciality = new System.Windows.Forms.Label();
            this.lblOks = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbStudentPhoto = new System.Windows.Forms.GroupBox();
            this.pbStudentPhoto = new System.Windows.Forms.PictureBox();
            this.tabMarks = new System.Windows.Forms.TabPage();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.oksItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuMain.SuspendLayout();
            this.tabControlStudentInfo.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.gbStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
            this.gbPersonalData.SuspendLayout();
            this.gbStudentPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oksItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.helpMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(690, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInOutMenuItem,
            this.miRegister,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // logInOutMenuItem
            // 
            this.logInOutMenuItem.Name = "logInOutMenuItem";
            this.logInOutMenuItem.Size = new System.Drawing.Size(116, 22);
            this.logInOutMenuItem.Text = "Login";
            this.logInOutMenuItem.Click += new System.EventHandler(this.logInOutMenuItem_Click);
            // 
            // miRegister
            // 
            this.miRegister.Name = "miRegister";
            this.miRegister.Size = new System.Drawing.Size(116, 22);
            this.miRegister.Text = "Register";
            this.miRegister.Click += new System.EventHandler(this.miRegister_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPictureToolStripMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "&Edit";
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openPictureToolStripMenuItem.Text = "Open Picture";
            this.openPictureToolStripMenuItem.Click += new System.EventHandler(this.openPictureToolStripMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUverenie,
            this.miStudents});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "&View";
            // 
            // miUverenie
            // 
            this.miUverenie.Name = "miUverenie";
            this.miUverenie.Size = new System.Drawing.Size(165, 22);
            this.miUverenie.Text = "Уверение";
            this.miUverenie.Click += new System.EventHandler(this.miUverenie_Click);
            // 
            // miStudents
            // 
            this.miStudents.Name = "miStudents";
            this.miStudents.Size = new System.Drawing.Size(165, 22);
            this.miStudents.Text = "Всички студенти";
            this.miStudents.Click += new System.EventHandler(this.miStudents_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // tabControlStudentInfo
            // 
            this.tabControlStudentInfo.Controls.Add(this.tabStudent);
            this.tabControlStudentInfo.Controls.Add(this.tabMarks);
            this.tabControlStudentInfo.Location = new System.Drawing.Point(12, 27);
            this.tabControlStudentInfo.Name = "tabControlStudentInfo";
            this.tabControlStudentInfo.SelectedIndex = 0;
            this.tabControlStudentInfo.Size = new System.Drawing.Size(662, 398);
            this.tabControlStudentInfo.TabIndex = 1;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.btnAddStudent);
            this.tabStudent.Controls.Add(this.textBoxPotok);
            this.tabStudent.Controls.Add(this.gbStudentInfo);
            this.tabStudent.Controls.Add(this.gbPersonalData);
            this.tabStudent.Controls.Add(this.gbStudentPhoto);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(654, 372);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Студент";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(63, 284);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(112, 48);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Добави студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // textBoxPotok
            // 
            this.textBoxPotok.Location = new System.Drawing.Point(552, 211);
            this.textBoxPotok.Name = "textBoxPotok";
            this.textBoxPotok.Size = new System.Drawing.Size(56, 20);
            this.textBoxPotok.TabIndex = 90;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.numCourse);
            this.gbStudentInfo.Controls.Add(this.textBoxGroup);
            this.gbStudentInfo.Controls.Add(this.lblGroup);
            this.gbStudentInfo.Controls.Add(this.lblPotok);
            this.gbStudentInfo.Controls.Add(this.lblCourse);
            this.gbStudentInfo.Controls.Add(this.comboStatus);
            this.gbStudentInfo.Controls.Add(this.comboOks);
            this.gbStudentInfo.Controls.Add(this.textBoxFacultyNumber);
            this.gbStudentInfo.Controls.Add(this.textBoxSpeciality);
            this.gbStudentInfo.Controls.Add(this.textBoxFaculty);
            this.gbStudentInfo.Controls.Add(this.lblFacultyNumber);
            this.gbStudentInfo.Controls.Add(this.lblSpeciality);
            this.gbStudentInfo.Controls.Add(this.lblOks);
            this.gbStudentInfo.Controls.Add(this.lblStatus);
            this.gbStudentInfo.Controls.Add(this.lblFaculty);
            this.gbStudentInfo.Location = new System.Drawing.Point(250, 148);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(385, 212);
            this.gbStudentInfo.TabIndex = 3;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Студентска информация";
            // 
            // numCourse
            // 
            this.numCourse.Location = new System.Drawing.Point(303, 28);
            this.numCourse.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCourse.Name = "numCourse";
            this.numCourse.Size = new System.Drawing.Size(55, 20);
            this.numCourse.TabIndex = 80;
            this.numCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(302, 97);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(56, 20);
            this.textBoxGroup.TabIndex = 100;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(258, 100);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 11;
            this.lblGroup.Text = "Група:";
            // 
            // lblPotok
            // 
            this.lblPotok.AutoSize = true;
            this.lblPotok.Location = new System.Drawing.Point(256, 66);
            this.lblPotok.Name = "lblPotok";
            this.lblPotok.Size = new System.Drawing.Size(41, 13);
            this.lblPotok.TabIndex = 10;
            this.lblPotok.Text = "Поток:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(263, 31);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(34, 13);
            this.lblCourse.TabIndex = 9;
            this.lblCourse.Text = "Курс:";
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(89, 136);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStatus.TabIndex = 60;
            // 
            // comboOks
            // 
            this.comboOks.FormattingEnabled = true;
            this.comboOks.Items.AddRange(new object[] {
            "Бакалавър",
            "Магистър"});
            this.comboOks.Location = new System.Drawing.Point(89, 97);
            this.comboOks.Name = "comboOks";
            this.comboOks.Size = new System.Drawing.Size(121, 21);
            this.comboOks.TabIndex = 50;
            // 
            // textBoxFacultyNumber
            // 
            this.textBoxFacultyNumber.Location = new System.Drawing.Point(89, 171);
            this.textBoxFacultyNumber.Name = "textBoxFacultyNumber";
            this.textBoxFacultyNumber.Size = new System.Drawing.Size(122, 20);
            this.textBoxFacultyNumber.TabIndex = 70;
            // 
            // textBoxSpeciality
            // 
            this.textBoxSpeciality.Location = new System.Drawing.Point(89, 63);
            this.textBoxSpeciality.Name = "textBoxSpeciality";
            this.textBoxSpeciality.Size = new System.Drawing.Size(122, 20);
            this.textBoxSpeciality.TabIndex = 40;
            // 
            // textBoxFaculty
            // 
            this.textBoxFaculty.Location = new System.Drawing.Point(89, 28);
            this.textBoxFaculty.Name = "textBoxFaculty";
            this.textBoxFaculty.Size = new System.Drawing.Size(122, 20);
            this.textBoxFaculty.TabIndex = 30;
            // 
            // lblFacultyNumber
            // 
            this.lblFacultyNumber.AutoSize = true;
            this.lblFacultyNumber.Location = new System.Drawing.Point(12, 174);
            this.lblFacultyNumber.Name = "lblFacultyNumber";
            this.lblFacultyNumber.Size = new System.Drawing.Size(71, 13);
            this.lblFacultyNumber.TabIndex = 4;
            this.lblFacultyNumber.Text = "Фак. номер:";
            // 
            // lblSpeciality
            // 
            this.lblSpeciality.AutoSize = true;
            this.lblSpeciality.Location = new System.Drawing.Point(7, 66);
            this.lblSpeciality.Name = "lblSpeciality";
            this.lblSpeciality.Size = new System.Drawing.Size(76, 13);
            this.lblSpeciality.TabIndex = 3;
            this.lblSpeciality.Text = "Специалност:";
            // 
            // lblOks
            // 
            this.lblOks.AutoSize = true;
            this.lblOks.Location = new System.Drawing.Point(51, 100);
            this.lblOks.Name = "lblOks";
            this.lblOks.Size = new System.Drawing.Size(32, 13);
            this.lblOks.TabIndex = 2;
            this.lblOks.Text = "ОКС:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(39, 139);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Статус:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(23, 31);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(60, 13);
            this.lblFaculty.TabIndex = 0;
            this.lblFaculty.Text = "Факултет:";
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.textBoxLastName);
            this.gbPersonalData.Controls.Add(this.textBoxSecondName);
            this.gbPersonalData.Controls.Add(this.textBoxFirstName);
            this.gbPersonalData.Controls.Add(this.lblLastName);
            this.gbPersonalData.Controls.Add(this.lblSecondName);
            this.gbPersonalData.Controls.Add(this.lblFirstName);
            this.gbPersonalData.Location = new System.Drawing.Point(250, 18);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(385, 124);
            this.gbPersonalData.TabIndex = 2;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Лични данни";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(85, 87);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(284, 20);
            this.textBoxLastName.TabIndex = 20;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(85, 56);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(284, 20);
            this.textBoxSecondName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(85, 25);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(284, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Фамилия:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(23, 59);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(56, 13);
            this.lblSecondName.TabIndex = 1;
            this.lblSecondName.Text = "Презиме:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(47, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(32, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Име:";
            // 
            // gbStudentPhoto
            // 
            this.gbStudentPhoto.Controls.Add(this.pbStudentPhoto);
            this.gbStudentPhoto.Location = new System.Drawing.Point(15, 18);
            this.gbStudentPhoto.Name = "gbStudentPhoto";
            this.gbStudentPhoto.Size = new System.Drawing.Size(218, 222);
            this.gbStudentPhoto.TabIndex = 0;
            this.gbStudentPhoto.TabStop = false;
            this.gbStudentPhoto.Text = "Снимка";
            // 
            // pbStudentPhoto
            // 
            this.pbStudentPhoto.Location = new System.Drawing.Point(30, 28);
            this.pbStudentPhoto.Name = "pbStudentPhoto";
            this.pbStudentPhoto.Size = new System.Drawing.Size(158, 171);
            this.pbStudentPhoto.TabIndex = 0;
            this.pbStudentPhoto.TabStop = false;
            // 
            // tabMarks
            // 
            this.tabMarks.Location = new System.Drawing.Point(4, 22);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarks.Size = new System.Drawing.Size(654, 372);
            this.tabMarks.TabIndex = 1;
            this.tabMarks.Text = "Оценки";
            this.tabMarks.UseVisualStyleBackColor = true;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openPictureDialog";
            this.openPictureDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 448);
            this.Controls.Add(this.tabControlStudentInfo);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "Информационна система";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabControlStudentInfo.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            this.gbStudentPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oksItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.TabControl tabControlStudentInfo;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.GroupBox gbStudentPhoto;
        private System.Windows.Forms.PictureBox pbStudentPhoto;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label lblFacultyNumber;
        private System.Windows.Forms.Label lblSpeciality;
        private System.Windows.Forms.Label lblOks;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboOks;
        private System.Windows.Forms.TextBox textBoxFacultyNumber;
        private System.Windows.Forms.TextBox textBoxSpeciality;
        private System.Windows.Forms.TextBox textBoxFaculty;
        private System.Windows.Forms.TextBox textBoxPotok;
        private System.Windows.Forms.NumericUpDown numCourse;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblPotok;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TabPage tabMarks;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInOutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.ToolStripMenuItem miUverenie;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.BindingSource oksItemsBindingSource;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private System.Windows.Forms.ToolStripMenuItem miRegister;
        private System.Windows.Forms.ToolStripMenuItem miStudents;
    }
}

