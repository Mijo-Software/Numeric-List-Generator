using NumericListGenerator.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NumericListGenerator
{
	public partial class NumericListGeneratorForm : Form
	{
		private TimeSpan timeSpan;
		private string backupListUndo, backupListRedo;
		private DateTime startTime, endTime;

		private void UpdateStatusBar()
		{
			if (toolStripStatusLabelSize.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelSize.Text = $"Größe: {textBoxList.Text.Length} Bytes";
			}
			if (toolStripStatusLabelLines.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelLines.Text = $"Zeilen: {textBoxList.Lines.LongLength}";
			}
			if (toolStripStatusLabelTimeSpan.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelTimeSpan.Text = $"Dauer: {timeSpan:hh\\:mm\\:ss\\.ff}";
			}
			if (toolStripStatusLabelLim.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelLim.Text = $"LIM: {(int)numericUpDownNumberMaximum.Value / timeSpan.TotalSeconds:N4} ips";
			}
		}

		private void DisableControls()
		{
			textBoxStringBeforeNumber.Enabled = false;
			numericUpDownNumberMinimum.Enabled = false;
			numericUpDownNumberMaximum.Enabled = false;
			checkBoxFillWithZeros.Enabled = false;
			textBoxStringAfterNumber.Enabled = false;
			buttonCreateList.Enabled = false;
			buttonAddToList.Enabled = false;
			buttonDeleteList.Enabled = false;
			buttonUndo.Enabled = false;
			buttonRedo.Enabled = false;
			buttonCopyList.Enabled = false;
			buttonSaveList.Enabled = false;
			textBoxList.Enabled = false;
		}

		private void EnableControls()
		{
			textBoxStringBeforeNumber.Enabled = true;
			numericUpDownNumberMinimum.Enabled = true;
			numericUpDownNumberMaximum.Enabled = true;
			checkBoxFillWithZeros.Enabled = true;
			textBoxStringAfterNumber.Enabled = true;
			buttonCreateList.Enabled = true;
			buttonAddToList.Enabled = true;
			buttonDeleteList.Enabled = true;
			buttonUndo.Enabled = true;
			buttonCopyList.Enabled = true;
			buttonSaveList.Enabled = true;
			textBoxList.Enabled = true;
		}

		public NumericListGeneratorForm()
		{
			InitializeComponent();
		}

		private void NumericListGeneratorForm_Load(object sender, EventArgs e)
		{
			buttonSettings.Visible = false;
			buttonUndo.Enabled = false;
			buttonRedo.Enabled = false;
			UpdateStatusBar();
		}

		private void ButtonAddToList_Click(object sender, EventArgs e)
		{
			DisableControls();
			backupListUndo = textBoxList.Text;
			startTime = DateTime.Now;
			progressBar.Minimum = 0;
			progressBar.Maximum = (int)numericUpDownNumberMaximum.Value;
			progressBar.Value = 0;
			progressBar.Step = 1;
			backgroundWorker.RunWorkerAsync();
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

		private void ButtonCreateList_Click(object sender, EventArgs e)
		{
			DisableControls();
			ButtonDeleteList_Click(sender: sender, e: e);
			ButtonAddToList_Click(sender: sender, e: e);
		}

		private void ButtonUndo_Click(object sender, EventArgs e)
		{
			textBoxList.Text = backupListUndo;
			buttonUndo.Enabled = false;
			buttonRedo.Enabled = true;
			UpdateStatusBar();
		}

		private void ButtonRedo_Click(object sender, EventArgs e)
		{
			textBoxList.Text = backupListRedo;
			buttonUndo.Enabled = true;
			buttonRedo.Enabled = false;
			UpdateStatusBar();
		}

		private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			for (int i = (int)numericUpDownNumberMinimum.Value; i < (int)numericUpDownNumberMaximum.Value + 1; i++)
			{
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
				backgroundWorker.ReportProgress(percentProgress: i);
				endTime = DateTime.Now;
				timeSpan = endTime - startTime;
				UpdateStatusBar();
				backupListRedo = textBoxList.Text;
			}
		}

		private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar.PerformStep();
		}

		private void ButtonSettings_Click(object sender, EventArgs e)
		{
			using (SettingsForm formSettings = new SettingsForm())
			{
				formSettings.ShowDialog();
			}
		}

		private void ToolStripStatusLabelSize_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelSize.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelSize.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelSize.Text = toolStripStatusLabelSize.Tag.ToString();
			}
			else
			{
				toolStripStatusLabelSize.ForeColor = SystemColors.ControlText;
			}
		}

		private void ToolStripStatusLabelLines_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelLines.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelLines.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelLines.Text = toolStripStatusLabelLines.Tag.ToString();
			}
			else
			{
				toolStripStatusLabelLines.ForeColor = SystemColors.ControlText;
			}
		}

		private void ToolStripStatusLabelTimeSpan_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelTimeSpan.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelTimeSpan.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelTimeSpan.Text = toolStripStatusLabelTimeSpan.Tag.ToString();
			}
			else
			{
				toolStripStatusLabelTimeSpan.ForeColor = SystemColors.ControlText;
			}
		}

		private void ToolStripStatusLabelLim_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelLim.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelLim.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelLim.Text = toolStripStatusLabelLim.Tag.ToString();
			}
			else
			{
				toolStripStatusLabelLim.ForeColor = SystemColors.ControlText;
			}
		}

		private void ToolStripStatusLabelStyle_Click(object sender, EventArgs e)
		{
			if (Application.VisualStyleState == VisualStyleState.ClientAndNonClientAreasEnabled)
			{
				toolStripSplitButtonStyle.Image = Resources.application;
				Application.VisualStyleState = VisualStyleState.NoneEnabled;
			}
			else
			{
				toolStripSplitButtonStyle.Image = Resources.application_grey;
				Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
			}
			Invalidate(invalidateChildren: true);
		}

		private void ToolStripMenuItemActivateVisualStyle_Click(object sender, EventArgs e)
		{
			toolStripSplitButtonStyle.Image = Resources.application_grey;
			Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
			Invalidate(invalidateChildren: true);
		}

		private void ToolStripMenuItemDeactivateVisualStyle_Click(object sender, EventArgs e)
		{
			toolStripSplitButtonStyle.Image = Resources.application;
			Application.VisualStyleState = VisualStyleState.NoneEnabled;
			Invalidate(invalidateChildren: true);
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			EnableControls();
		}
	}
}