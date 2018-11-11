using System;
using System.IO;
using System.Windows.Forms;

namespace NumericListGenerator
{
	public partial class NumericListGeneratorForm : Form
  {
    public NumericListGeneratorForm()
    {
      InitializeComponent();
    }

    private void NumericListGeneratorForm_Load(object sender, EventArgs e)
    {
    }

    private void ButtonAddToList_Click(object sender, EventArgs e)
    {
			string strTemp = "";
			progressBarProcress.Minimum = 0;
      progressBarProcress.Maximum = (int)numericUpDownNumberMaximum.Value;
			progressBarProcress.Value = 0;
			progressBarProcress.Step = 1;
      for (int i = (int)numericUpDownNumberMinimum.Value; i < (int)numericUpDownNumberMaximum.Value + 1; i++)
      {
        strTemp = "";
				// Alternativen: progressBarProcress.Increment(1); oder progressBarProcress.Value = i;
				progressBarProcress.PerformStep();
        if (checkBoxFillWithZeros.Checked)
        {
          if (i < 1000000000 && numericUpDownNumberMaximum.Value > 999999999) strTemp = strTemp + "0";
          if (i < 100000000 && numericUpDownNumberMaximum.Value > 99999999) strTemp = strTemp + "0";
          if (i < 10000000 && numericUpDownNumberMaximum.Value > 9999999) strTemp = strTemp + "0";
          if (i < 1000000 && numericUpDownNumberMaximum.Value > 999999) strTemp = strTemp + "0";
          if (i < 100000 && numericUpDownNumberMaximum.Value > 99999) strTemp = strTemp + "0";
          if (i < 10000 && numericUpDownNumberMaximum.Value > 9999) strTemp = strTemp + "0";
          if (i < 1000 && numericUpDownNumberMaximum.Value > 999) strTemp = strTemp + "0";
          if (i < 100 && numericUpDownNumberMaximum.Value > 99) strTemp = strTemp + "0";
          if (i < 10 && numericUpDownNumberMaximum.Value > 9) strTemp = strTemp + "0";
        }
        textBoxList.Text = textBoxList.Text + comboBoxStringBeforeNumber.Text + strTemp + i.ToString() + comboBoxStringAfterNumber.Text + "\r\n";
      }
    }

    private void ButtonCopyList_Click(object sender, EventArgs e)
    {
      textBoxList.SelectAll();
      textBoxList.Copy();
			MessageBox.Show("Die Liste wurde in die Zwischenablage kopiert.");
    }

    private void ButtonSaveList_Click(object sender, EventArgs e)
    {
			SaveFileDialog save = new SaveFileDialog
			{
				FileName = "liste.txt",
				Filter = "Textdatei | *.txt"
			};
			if (save.ShowDialog() == DialogResult.OK)
      {
				StreamWriter writer = new StreamWriter(stream: save.OpenFile());
				try { 
					writer.WriteLine(value: textBoxList.Text);
				}
				finally {
					writer.Close();
					MessageBox.Show("Die Liste wurde in die Textdatei kopiert.");
				}
			}
    }

		private void ButtonDeleteList_Click(object sender, EventArgs e) => textBoxList.Clear();

		private void ButtonInformationAboutApp_Click(object sender, EventArgs e)
    {
      AboutBoxForm formAboutBox = new AboutBoxForm();
      formAboutBox.ShowDialog();
    }

		private void ButtonExitApp_Click(object sender, EventArgs e) => Close();

		private void ButtonCreateListe_Click(object sender, EventArgs e)
		{
			ButtonDeleteList_Click(sender, e);
			ButtonAddToList_Click(sender, e);
		}
	}
}
