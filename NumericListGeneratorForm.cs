using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace Numeric_List_Generator
{
	/// <summary>
	/// Main Form
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
	public partial class NumericListGeneratorForm : Form
	{
		/// <summary>
		/// timeSpan
		/// </summary>
		private TimeSpan timeSpan;

		/// <summary>
		/// backupListUndo, backupListRedo
		/// </summary>
		private string backupListUndo, backupListRedo;

		/// <summary>
		/// startTime, endTime
		/// </summary>
		private DateTime startTime, endTime;

		#region

		/// <summary>
		/// Constructor
		/// </summary>
		public NumericListGeneratorForm() => InitializeComponent();

		#endregion

		#region

		/// <summary>
		/// Get Debugger Display
		/// </summary>
		/// <returns>Return the debugger display</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			toolStripStatusLabelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			toolStripStatusLabelInformation.Text = text;
		}

		private void UpdateStatusBarStatistic()
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
			toolStripMenuItemList.Enabled = false;
			textBoxStringBeforeNumber.Enabled = false;
			numericUpDownNumberMinimum.Enabled = false;
			numericUpDownNumberMaximum.Enabled = false;
			checkBoxFillWithZeros.Enabled = false;
			textBoxStringAfterNumber.Enabled = false;
			buttonCreateList.Enabled = false;
			buttonAddToList.Enabled = false;
			buttonDeleteList.Enabled = false;
			buttonCopyList.Enabled = false;
			buttonSaveList.Enabled = false;
			buttonUndo.Enabled = false;
			buttonRedo.Enabled = false;
			toolStripMenuItemListUndo.Enabled = false;
			toolStripMenuItemListRedo.Enabled = false;
			textBoxList.Enabled = false;
		}

		private void EnableControls()
		{
			toolStripMenuItemList.Enabled = true;
			textBoxStringBeforeNumber.Enabled = true;
			numericUpDownNumberMinimum.Enabled = true;
			numericUpDownNumberMaximum.Enabled = true;
			checkBoxFillWithZeros.Enabled = true;
			textBoxStringAfterNumber.Enabled = true;
			buttonCreateList.Enabled = true;
			buttonAddToList.Enabled = true;
			buttonDeleteList.Enabled = true;
			buttonCopyList.Enabled = true;
			buttonSaveList.Enabled = true;
			buttonUndo.Enabled = true;
			toolStripMenuItemListUndo.Enabled = true;
			textBoxList.Enabled = true;
		}

		private void CheckStayOnTop() => TopMost = toolStripMenuItemSettingsStayOnTop.Checked;

		#endregion

		private void NumericListGeneratorForm_Load(object sender, EventArgs e)
		{
			SetStatusbarText(text: string.Empty);
			buttonUndo.Enabled = false;
			buttonRedo.Enabled = false;
			toolStripMenuItemListUndo.Enabled = false;
			toolStripMenuItemListRedo.Enabled = false;
			UpdateStatusBarStatistic();
		}

		#region Enter event handlers

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox textBox: SetStatusbarText(text: textBox.AccessibleDescription); break;
				case Button button: SetStatusbarText(text: button.AccessibleDescription); break;
				case RadioButton radioButton: SetStatusbarText(text: radioButton.AccessibleDescription); break;
				case CheckBox checkBox: SetStatusbarText(text: checkBox.AccessibleDescription); break;
				case DateTimePicker dateTimePicker: SetStatusbarText(text: dateTimePicker.AccessibleDescription); break;
				case Label label: SetStatusbarText(text: label.AccessibleDescription); break;
				case PictureBox pictureBox: SetStatusbarText(text: pictureBox.AccessibleDescription); break;
				case CheckedListBox checkedListBox: SetStatusbarText(text: checkedListBox.AccessibleDescription); break;
				case ComboBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case DataGridView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case GroupBox group: SetStatusbarText(text: group.AccessibleDescription); break;
				case ListBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case ListView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case MaskedTextBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case NumericUpDown numericUpDown: SetStatusbarText(text: numericUpDown.AccessibleDescription); break;
				case MonthCalendar monthCalendar: SetStatusbarText(text: monthCalendar.AccessibleDescription); break;
				case PropertyGrid propertyGrid: SetStatusbarText(text: propertyGrid.AccessibleDescription); break;
				case RichTextBox richTextBox: SetStatusbarText(text: richTextBox.AccessibleDescription); break;
				case ScrollBar scrollBar: SetStatusbarText(text: scrollBar.AccessibleDescription); break;
				case TrackBar trackBar: SetStatusbarText(text: trackBar.AccessibleDescription); break;
				case WebBrowser webBrowser: SetStatusbarText(text: webBrowser.AccessibleDescription); break;
				case DomainUpDown domainUpDown: SetStatusbarText(text: domainUpDown.AccessibleDescription); break;
				case ToolStripButton toolStripButton: SetStatusbarText(text: toolStripButton.AccessibleDescription); break;
				case ToolStripMenuItem toolStripMenuItem: SetStatusbarText(text: toolStripMenuItem.AccessibleDescription); break;
				case ToolStripLabel toolStripLabel: SetStatusbarText(text: toolStripLabel.AccessibleDescription); break;
				case ToolStripComboBox toolStripComboBox: SetStatusbarText(text: toolStripComboBox.AccessibleDescription); break;
				case ToolStripDropDown toolStripDropDown: SetStatusbarText(text: toolStripDropDown.AccessibleDescription); break;
				case ToolStripDropDownButton toolStripDropDownButton: SetStatusbarText(text: toolStripDropDownButton.AccessibleDescription); break;
				case ToolStripDropDownItem toolStripDropDownItem: SetStatusbarText(text: toolStripDropDownItem.AccessibleDescription); break;
				case ToolStripProgressBar progressBar: SetStatusbarText(text: progressBar.AccessibleDescription); break;
				case ToolStripSeparator toolStripSeparator: SetStatusbarText(text: toolStripSeparator.AccessibleDescription); break;
				case ToolStripTextBox toolStripTextBox: SetStatusbarText(text: toolStripTextBox.AccessibleDescription); break;
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		#endregion

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
			using SaveFileDialog save = new()
			{
				FileName = "liste.txt",
				Filter = "Textdatei | *.txt"
			};
			if (save.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter writer = new(stream: save.OpenFile());
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

		private void ButtonDeleteList_Click(object sender, EventArgs e)
		{
			textBoxList.Clear();
			timeSpan = TimeSpan.Zero;
			UpdateStatusBarStatistic();
		}

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
			toolStripMenuItemListUndo.Enabled = false;
			toolStripMenuItemListRedo.Enabled = true;
			UpdateStatusBarStatistic();
		}

		private void ButtonRedo_Click(object sender, EventArgs e)
		{
			textBoxList.Text = backupListRedo;
			buttonUndo.Enabled = true;
			buttonRedo.Enabled = false;
			toolStripMenuItemListUndo.Enabled = true;
			toolStripMenuItemListRedo.Enabled = false;
			UpdateStatusBarStatistic();
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
				UpdateStatusBarStatistic();
				backupListRedo = textBoxList.Text;
			}
		}

		private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) => progressBar.PerformStep();

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
			Application.VisualStyleState = Application.VisualStyleState == VisualStyleState.ClientAndNonClientAreasEnabled
				? VisualStyleState.NoneEnabled
				: VisualStyleState.ClientAndNonClientAreasEnabled;
			Invalidate(invalidateChildren: true);
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) => EnableControls();

		private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
		{
			using AboutBoxForm formAboutBox = new();
			formAboutBox.TopMost = TopMost;
			formAboutBox.ShowDialog();
		}

		private void ToolStripMenuItemLicense_Click(object sender, EventArgs e)
		{
			//LicenseForm
			using LicenseForm formLicense = new();
			formLicense.TopMost = TopMost;
			formLicense.ShowDialog();
		}

		private void ToolStripMenuItemExit_Click(object sender, EventArgs e) => Close();

		private void ToolStripMenuItemListCreate_Click(object sender, EventArgs e) => ButtonCreateList_Click(sender: sender, e: e);

		private void ToolStripMenuItemListAdd_Click(object sender, EventArgs e) => ButtonAddToList_Click(sender: sender, e: e);

		private void ToolStripMenuItemListDelete_Click(object sender, EventArgs e) => ButtonDeleteList_Click(sender: sender, e: e);

		private void ToolStripMenuItemListUndo_Click(object sender, EventArgs e) => ButtonUndo_Click(sender: sender, e: e);

		private void ToolStripMenuItemListRedo_Click(object sender, EventArgs e) => ButtonRedo_Click(sender: sender, e: e);

		private void ToolStripMenuItemListCopy_Click(object sender, EventArgs e) => ButtonCopyList_Click(sender: sender, e: e);

		private void ToolStripMenuItemListSave_Click(object sender, EventArgs e) => ButtonSaveList_Click(sender: sender, e: e);

		private void ToolStripMenuItemSettingsDisableVisualStyle_Click(object sender, EventArgs e) => ToolStripStatusLabelStyle_Click(sender: sender, e: e);

		private void ToolStripMenuItemSettingsStayOnTop_Click(object sender, EventArgs e) => CheckStayOnTop();
	}
}