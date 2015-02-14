namespace StudentInfoSystem.UI.Views
{
    using System;
    using System.Windows.Forms;

    public partial class InfoForm : Form
    {
        public InfoForm()
            : this(string.Empty)
        {
        }

        public InfoForm(string text)
        {
            this.InitializeComponent();
            this.richTextBoxText.Text = text;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (this.fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.richTextBoxText.SelectedText == string.Empty)
                {
                    this.richTextBoxText.Font = this.fontDialog.Font;
                }
                else
                {
                    this.richTextBoxText.SelectionFont = this.fontDialog.Font;
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (this.richTextBoxText.SelectedText == string.Empty)
                {
                    this.richTextBoxText.ForeColor = this.colorDialog.Color;
                }
                else
                {
                    this.richTextBoxText.SelectionColor = this.colorDialog.Color;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.DefaultExt = "*.rtf";
            this.saveFileDialog.Filter = "RTF Files|*.rtf";
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && 
                this.saveFileDialog.FileName.Length > 0)
            {
                try
                {
                    // Save the contents of the RichTextBox into the file.
                    this.richTextBoxText.SaveFile(this.saveFileDialog.FileName);
                    MessageBox.Show(
                        "Успешно записахте уверението в избрания файл!",
                        "Успешно записано уверение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "Файлът не беше съхранен, поради грешка в записа!",
                        "Грешка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
