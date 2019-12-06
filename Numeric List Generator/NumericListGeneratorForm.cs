using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace NumericListGenerator
{
	/// <summary>
	/// NumericListGeneratorForm
	/// </summary>
	public partial class NumericListGeneratorForm : Form
	{
		/// <summary>
		/// culture info for the date
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Constructor
		/// </summary>
		public NumericListGeneratorForm() => InitializeComponent();

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NumericListGeneratorForm_Load(object sender, EventArgs e)
		{
			comboBoxLanguage.Items.Add(new CultureInfo(name: "de"));
			comboBoxLanguage.Items.Add(new CultureInfo(name: "en"));
			comboBoxLanguage.Items.Add(new CultureInfo(name: "es"));
			comboBoxLanguage.Items.Add(new CultureInfo(name: "fr"));
			comboBoxLanguage.Items.Add(new CultureInfo(name: "it"));
			comboBoxLanguage.SelectedIndex = 0;
		}

		private void ButtonAddToList_Click(object sender, EventArgs e)
		{
			progressBarProcress.Minimum = 0;
			progressBarProcress.Maximum = (int)numericUpDownNumberMaximum.Value;
			progressBarProcress.Value = 0;
			progressBarProcress.Step = 1;
			backgroundWorker.RunWorkerAsync();
		}

		private void ButtonCopyList_Click(object sender, EventArgs e)
		{
			textBoxList.SelectAll();
			textBoxList.Copy();
			MessageBox.Show(text: L10N.strCopiedToClipboard, caption: L10N.strCaptionInformation);
		}

		private void ButtonSaveList_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog save = new SaveFileDialog()
			{
				FileName = L10N.strDefaultFilename,
				Filter = L10N.strDefaultFileFilter
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
						MessageBox.Show(text: L10N.strSavedToFile, caption: L10N.strCaptionInformation);
					}
				}
			}
		}

		private void ButtonDeleteList_Click(object sender, EventArgs e) => textBoxList.Clear();

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

		private static void ApplyResourceToControl(ComponentResourceManager res, Control control)
		{
			foreach (Control c in control.Controls)
			{
				ApplyResourceToControl(res: res, control: c);
			}

			string text = res.GetString(name: $"{control.Name}.Text", culture: culture);
			control.Text = text ?? control.Text;
		}

		private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxLanguage.SelectedIndex == -1)
			{
				return;
			}
			Thread.CurrentThread.CurrentUICulture = (CultureInfo)comboBoxLanguage.SelectedItem;
			ComponentResourceManager resources = new ComponentResourceManager(t: GetType());
			ApplyResourceToControl(res: resources, control: this);
		}

		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = (int)numericUpDownNumberMinimum.Value; i < (int)numericUpDownNumberMaximum.Value + 1; i++)
			{
				string strTemp = string.Empty;
				// Alternativen: progressBarProcress.Increment(1); oder progressBarProcress.Value = i;
				if (checkBoxFillWithZeros.Checked)
				{
					if (i < 1000000000 && numericUpDownNumberMaximum.Value > 999999999)
					{
						strTemp += "0";
					}
					if (i < 100000000 && numericUpDownNumberMaximum.Value > 99999999)
					{
						strTemp += "0";
					}
					if (i < 10000000 && numericUpDownNumberMaximum.Value > 9999999)
					{
						strTemp += "0";
					}
					if (i < 1000000 && numericUpDownNumberMaximum.Value > 999999)
					{
						strTemp += "0";
					}
					if (i < 100000 && numericUpDownNumberMaximum.Value > 99999)
					{
						strTemp += "0";
					}
					if (i < 10000 && numericUpDownNumberMaximum.Value > 9999)
					{
						strTemp += "0";
					}
					if (i < 1000 && numericUpDownNumberMaximum.Value > 999)
					{
						strTemp += "0";
					}
					if (i < 100 && numericUpDownNumberMaximum.Value > 99)
					{
						strTemp += "0";
					}
					if (i < 10 && numericUpDownNumberMaximum.Value > 9)
					{
						strTemp += "0";
					}
				}
				backgroundWorker.ReportProgress(percentProgress: 0, userState: $"{comboBoxStringBeforeNumber.Text}{strTemp}{i.ToString(provider: culture)}{comboBoxStringAfterNumber.Text}{Environment.NewLine}");
			}
		}

		private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			progressBarProcress.PerformStep();
			textBoxList.Text += e.UserState.ToString();
		}
	}
}
