using System;
using System.IO;
using System.Windows.Forms;

namespace NumericListGenerator
{
  public partial class NumericListGeneratorForm : Form
  {
    private TimeSpan timeSpan;
    private String backupList;

		private void UpdateStatusBar()
    {
      toolStripStatusLabelSize.Text = $"Größe: {textBoxList.Text.Length} Bytes";
      toolStripStatusLabelLines.Text = $"Linien: {textBoxList.Lines.LongLength}";
      toolStripStatusLabelLim.Text = $"LIM: {(int)numericUpDownNumberMaximum.Value / timeSpan.TotalSeconds:N4} ips";
    }

    public NumericListGeneratorForm()
    {
      InitializeComponent();
    }

    private void NumericListGeneratorForm_Load(object sender, EventArgs e)
    {
      buttonUndo.Enabled = false;
      UpdateStatusBar();
    }

    private void ButtonAddToList_Click(object sender, EventArgs e)
    {
      buttonUndo.Enabled = true;
      backupList = textBoxList.Text;
      DateTime startTime = DateTime.Now, endTime;
      progressBar.Minimum = 0;
      progressBar.Maximum = (int)numericUpDownNumberMaximum.Value;
			progressBar.Value = 0;
			progressBar.Step = 1;
      for (int i = (int)numericUpDownNumberMinimum.Value; i < (int)numericUpDownNumberMaximum.Value + 1; i++)
      {
        // Alternativen: progressBar.Increment(1); oder progressBar.Value = i;
        progressBar.PerformStep();
        if (textBoxList.Text.Length > 0)
        {
          textBoxList.AppendText(text: Environment.NewLine);
        }
        if (checkBoxFillWithZeros.Checked)
        {
          textBoxList.AppendText(text: $"{textBoxStringBeforeNumber.Text}{i.ToString().PadLeft(totalWidth: ((int)numericUpDownNumberMaximum.Value).ToString().Length, paddingChar: '0')}{textBoxStringAfterNumber.Text}");
        }
        else
        {
          textBoxList.AppendText(text: $"{textBoxStringBeforeNumber.Text}{i}{textBoxStringAfterNumber.Text}");
        }
        endTime = DateTime.Now;
        timeSpan = endTime - startTime;
        UpdateStatusBar();
      }
    }

    private void ButtonCopyList_Click(object sender, EventArgs e)
    {
      textBoxList.SelectAll();
      textBoxList.Copy();
			MessageBox.Show(text: "Die Liste wurde in die Zwischenablage kopiert.");
    }

    private void ButtonSaveList_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog save = new SaveFileDialog
			{
				FileName = "liste.txt",
				Filter = "Textdatei | *.txt"
			})
			{
				if (save.ShowDialog() == DialogResult.OK)
				{
					StreamWriter writer = new StreamWriter(stream: save.OpenFile());
					try
					{
						writer.WriteLine(value: textBoxList.Text);
					}
					finally
					{
						writer.Close();
						MessageBox.Show(text: "Die Liste wurde in die Textdatei kopiert.");
					}
				}
			}
		}

		private void ButtonDeleteList_Click(object sender, EventArgs e)
    {
      textBoxList.Clear();
      timeSpan = TimeSpan.Zero;
      UpdateStatusBar();
    }

    private void ButtonInformationAboutApp_Click(object sender, EventArgs e)
		{
			using (AboutBoxForm formAboutBox = new AboutBoxForm())
			{
				formAboutBox.ShowDialog();
			}
		}

		private void ButtonExitApp_Click(object sender, EventArgs e) => Close();

		private void ButtonCreateListe_Click(object sender, EventArgs e)
		{
			ButtonDeleteList_Click(sender: sender, e: e);
			ButtonAddToList_Click(sender: sender, e: e);
		}

		private void ButtonUndo_Click(object sender, EventArgs e)
		{
      textBoxList.Text = backupList;
      buttonUndo.Enabled = false;
      UpdateStatusBar();
    }
  }
}