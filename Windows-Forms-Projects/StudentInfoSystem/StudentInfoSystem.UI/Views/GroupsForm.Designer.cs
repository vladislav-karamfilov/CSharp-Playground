namespace StudentInfoSystem.UI.Views
{
    partial class GroupsForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.studentsDataGrid = new System.Windows.Forms.DataGridView();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnGroupFilter = new System.Windows.Forms.Button();
            this.comboGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGroupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGrid
            // 
            this.studentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGrid.Location = new System.Drawing.Point(12, 44);
            this.studentsDataGrid.Name = "studentsDataGrid";
            this.studentsDataGrid.Size = new System.Drawing.Size(906, 425);
            this.studentsDataGrid.TabIndex = 0;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(81, 12);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroup.TabIndex = 1;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(26, 15);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 2;
            this.lblGroup.Text = "Група:";
            // 
            // btnGroupFilter
            // 
            this.btnGroupFilter.Location = new System.Drawing.Point(228, 10);
            this.btnGroupFilter.Name = "btnGroupFilter";
            this.btnGroupFilter.Size = new System.Drawing.Size(75, 23);
            this.btnGroupFilter.TabIndex = 3;
            this.btnGroupFilter.Text = "Филтрирай";
            this.btnGroupFilter.UseVisualStyleBackColor = true;
            this.btnGroupFilter.Click += new System.EventHandler(this.btnGroupFilter_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 481);
            this.Controls.Add(this.btnGroupFilter);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.studentsDataGrid);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGroupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGrid;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnGroupFilter;
        private System.Windows.Forms.BindingSource comboGroupsBindingSource;
    }
}