﻿using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using NLog;

namespace Numeric_List_Generator
{
	/// <summary>
	/// Represents the main form for generating numeric lists.
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
	public partial class NumericListGeneratorForm : Form
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Stores the duration of the list generation process.
		/// </summary>
		private TimeSpan timeSpan;

		/// <summary>
		/// Stores the backup of the list for undo operation.
		/// </summary>
		private string backupListUndo = string.Empty, backupListRedo = string.Empty;

		/// <summary>
		/// Stores the start time of the list generation process.
		/// </summary>
		private DateTime startTime, endTime;

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="NumericListGeneratorForm"/> class.
		/// </summary>
		public NumericListGeneratorForm()
		{
			InitializeComponent();
			Logger.Info(message: "NumericListGeneratorForm initialized.");
		}

		#endregion

		#region	Helpers

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

		/// <summary>
		/// Updates the status bar with the current statistics of the list.
		/// </summary>
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

		/// <summary>
		/// Disables all controls on the form.
		/// </summary>
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

		/// <summary>
		/// Enables all controls on the form.
		/// </summary>
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

		/// <summary>
		/// Checks if the form should stay on top of other windows.
		/// </summary>
		private void CheckStayOnTop() => TopMost = toolStripMenuItemSettingsStayOnTop.Checked;

		#endregion

		/// <summary>
		/// Handles the Load event of the form.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
		/// Called when the mouse pointer moves over a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			if (sender is Control control && control.AccessibleDescription != null)
			{
				SetStatusbarText(text: control.AccessibleDescription);
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clears the information text of the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		#endregion

		/// <summary>
		/// Handles the Click event of the Add To List button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonAddToList_Click(object sender, EventArgs e)
		{
			try
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
			catch (Exception ex)
			{
				// Log the exception (example: log to a file or logging framework)
				Logger.Error(exception: ex, message: "An unexpected error occurred while adding to the list.");
				Debug.WriteLine(value: ex);
				_ = MessageBox.Show(text: "An unexpected error occurred while adding to the list. Please try again.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
				EnableControls();
			}
		}

		/// <summary>
		/// Handles the Click event of the Copy List button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonCopyList_Click(object sender, EventArgs e)
		{
			textBoxList.SelectAll();
			textBoxList.Copy();
			_ = MessageBox.Show(text: "Die Liste wurde in die Zwischenablage kopiert.");
		}

		/// <summary>
		/// Handles the Click event of the Save List button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonSaveList_Click(object sender, EventArgs e)
		{
			try
			{
				using SaveFileDialog save = new()
				{
					FileName = "liste.txt",
					Filter = "Textdatei | *.txt"
				};
				if (save.ShowDialog() == DialogResult.OK)
				{
					using StreamWriter writer = new(stream: save.OpenFile());
					writer.WriteLine(value: textBoxList.Text);
					_ = MessageBox.Show(text: "Die Liste wurde in die Textdatei kopiert.");
				}
			}
			catch (IOException ioEx)
			{
				// Log the exception (example: log to a file or logging framework)
				Debug.WriteLine(value: ioEx);
				Logger.Error(exception: ioEx, message: "An error occurred while saving the file.");
				_ = MessageBox.Show(text: "An error occurred while saving the file. Please try again.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				// Log the exception (example: log to a file or logging framework)
				Debug.WriteLine(value: ex);
				Logger.Error(exception: ex, message: "An unexpected error occurred.");
				_ = MessageBox.Show(text: "An unexpected error occurred. Please try again.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Handles the Click event of the Delete List button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonDeleteList_Click(object sender, EventArgs e)
		{
			textBoxList.Clear();
			timeSpan = TimeSpan.Zero;
			UpdateStatusBarStatistic();
		}

		/// <summary>
		/// Handles the Click event of the Create List button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonCreateList_Click(object sender, EventArgs e)
		{
			DisableControls();
			ButtonDeleteList_Click(sender: sender, e: e);
			ButtonAddToList_Click(sender: sender, e: e);
		}

		/// <summary>
		/// Handles the Click event of the Undo button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonUndo_Click(object sender, EventArgs e)
		{
			textBoxList.Text = backupListUndo;
			buttonUndo.Enabled = false;
			buttonRedo.Enabled = true;
			toolStripMenuItemListUndo.Enabled = false;
			toolStripMenuItemListRedo.Enabled = true;
			UpdateStatusBarStatistic();
		}

		/// <summary>
		/// Handles the Click event of the Redo button.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ButtonRedo_Click(object sender, EventArgs e)
		{
			textBoxList.Text = backupListRedo;
			buttonUndo.Enabled = true;
			buttonRedo.Enabled = false;
			toolStripMenuItemListUndo.Enabled = true;
			toolStripMenuItemListRedo.Enabled = false;
			UpdateStatusBarStatistic();
		}

		/// <summary>
		/// Handles the DoWork event of the BackgroundWorker.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DoWorkEventArgs"/> instance containing the event data.</param>
		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			try
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
			catch (Exception ex)
			{
				// Log the exception (example: log to a file or logging framework)
				Debug.WriteLine(value: ex);
				Logger.Error(exception: ex, message: "An unexpected error occurred during list generation.");
				_ = MessageBox.Show(text: "An unexpected error occurred during list generation. Please try again.", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Handles the ProgressChanged event of the BackgroundWorker.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="ProgressChangedEventArgs"/> instance containing the event data.</param>
		private void BackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) => progressBar.PerformStep();

		/// <summary>
		/// Handles the Click event of the Size status label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripStatusLabelSize_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelSize.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelSize.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelSize.Text = toolStripStatusLabelSize.Tag?.ToString() ?? string.Empty;
			}
			else
			{
				toolStripStatusLabelSize.ForeColor = SystemColors.ControlText;
			}
		}

		/// <summary>
		/// Handles the Click event of the Lines status label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripStatusLabelLines_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelLines.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelLines.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelLines.Text = toolStripStatusLabelLines.Tag?.ToString() ?? string.Empty;
			}
			else
			{
				toolStripStatusLabelLines.ForeColor = SystemColors.ControlText;
			}
		}

		/// <summary>
		/// Handles the Click event of the TimeSpan status label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripStatusLabelTimeSpan_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelTimeSpan.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelTimeSpan.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelTimeSpan.Text = toolStripStatusLabelTimeSpan.Tag?.ToString() ?? string.Empty;
			}
			else
			{
				toolStripStatusLabelTimeSpan.ForeColor = SystemColors.ControlText;
			}
		}

		/// <summary>
		/// Handles the Click event of the LIM status label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripStatusLabelLim_Click(object sender, EventArgs e)
		{
			if (toolStripStatusLabelLim.ForeColor == SystemColors.ControlText)
			{
				toolStripStatusLabelLim.ForeColor = SystemColors.GrayText;
				toolStripStatusLabelLim.Text = toolStripStatusLabelLim.Tag?.ToString() ?? string.Empty;
			}
			else
			{
				toolStripStatusLabelLim.ForeColor = SystemColors.ControlText;
			}
		}

		/// <summary>
		/// Handles the Click event of the Style status label.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripStatusLabelStyle_Click(object sender, EventArgs e)
		{
			Application.VisualStyleState = Application.VisualStyleState == VisualStyleState.ClientAndNonClientAreasEnabled
				? VisualStyleState.NoneEnabled
				: VisualStyleState.ClientAndNonClientAreasEnabled;
			Invalidate(invalidateChildren: true);
		}

		/// <summary>
		/// Handles the RunWorkerCompleted event of the BackgroundWorker.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) => EnableControls();

		/// <summary>
		/// Handles the Click event of the Info menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
		{
			using AboutBoxForm formAboutBox = new();
			formAboutBox.TopMost = TopMost;
			_ = formAboutBox.ShowDialog();
		}

		/// <summary>
		/// Handles the Click event of the License menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemLicense_Click(object sender, EventArgs e)
		{
			using LicenseForm formLicense = new();
			formLicense.TopMost = TopMost;
			_ = formLicense.ShowDialog();
		}

		/// <summary>
		/// Handles the Click event of the Exit menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemExit_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// Handles the Click event of the Create List menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemListCreate_Click(object sender, EventArgs e) => ButtonCreateList_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Add List menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemListAdd_Click(object sender, EventArgs e) => ButtonAddToList_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Delete List menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemListDelete_Click(object sender, EventArgs e) => ButtonDeleteList_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Undo menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemListUndo_Click(object sender, EventArgs e) => ButtonUndo_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Redo menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemListRedo_Click(object sender, EventArgs e) => ButtonRedo_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Copy List menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemListCopy_Click(object sender, EventArgs e) => ButtonCopyList_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Save List menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemListSave_Click(object sender, EventArgs e) => ButtonSaveList_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Disable Visual Style menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemSettingsDisableVisualStyle_Click(object sender, EventArgs e) => ToolStripStatusLabelStyle_Click(sender: sender, e: e);

		/// <summary>
		/// Handles the Click event of the Stay On Top menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemSettingsStayOnTop_Click(object sender, EventArgs e) => CheckStayOnTop();

		/// <summary>
		/// Handles the Click event of the Batch menu item.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void ToolStripMenuItemBatch_Click(object sender, EventArgs e)
		{
			Hide();
			using BatchForm formBatch = new();
			formBatch.TopMost = TopMost;
			_ = formBatch.ShowDialog();
			Show();
		}
	}
}