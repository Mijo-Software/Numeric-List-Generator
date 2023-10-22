using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Hasher.Properties;
using MijoSoftware.AssemblyInformation;

namespace Hasher
{
	/// <summary>
	/// Main Form
	/// </summary>
	[DebuggerDisplay(value: "{" + nameof(GetDebuggerDisplay) + "(),nq}")]
	public partial class MainForm : Form
	{
		/// <summary>
		/// isSaveAutomatically
		/// </summary>
		private bool isSaveAutomatically = false;

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public MainForm() => InitializeComponent();

		#endregion

		#region Helpers

		/// <summary>
		/// Get Debugger Display
		/// </summary>
		/// <returns>Return the debugger display</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Copy the text to the clipboard
		/// </summary>
		/// <param name="text">some text to clipboard</param>
		private static void CopyToClipboard(string text)
		{
			if (!string.IsNullOrEmpty(value: text))
			{
				Clipboard.SetText(text: text);
			}
		}

		/// <summary>
		/// Open a url
		/// </summary>
		/// <param name="url">web page</param>
		private static void OpenUrl(string url)
		{
			try
			{
				Process.Start(fileName: url);
			}
			catch
			{
				// hack because of this: https://github.com/dotnet/corefx/issues/10361
				if (RuntimeInformation.IsOSPlatform(osPlatform: OSPlatform.Windows))
				{
					url = url.Replace(oldValue: "&", newValue: "^&");
					Process.Start(startInfo: new ProcessStartInfo(fileName: url) { UseShellExecute = true });
				}
				else if (RuntimeInformation.IsOSPlatform(osPlatform: OSPlatform.Linux))
				{
					Process.Start(fileName: "xdg-open", arguments: url);
				}
				else if (RuntimeInformation.IsOSPlatform(osPlatform: OSPlatform.OSX))
				{
					Process.Start(fileName: "open", arguments: url);
				}
				else
				{
					throw;
				}
			}
		}

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
		/// Calculate hash values from a file
		/// </summary>
		private void CalculateHashesFromFile()
		{
			textBoxMD5StringFromFile.Text = GetMD5HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA1StringFromFile.Text = GetSHA1HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA256StringFromFile.Text = GetSHA256HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA384StringFromFile.Text = GetSHA384HashFromFile(fileName: textBoxFileName.Text);
			textBoxSHA512StringFromFile.Text = GetSHA512HashFromFile(fileName: textBoxFileName.Text);
			textBoxCrc32StringFromFile.Text = GetCrc32HashFromFile(fileName: textBoxFileName.Text);
		}

		/// <summary>
		/// Calculate hash values from a text/string
		/// </summary>
		private void CalculateHashesFromText()
		{
			textBoxMD5StringFromText.Text = GetMD5HashFromText(input: textBoxText.Text);
			textBoxSHA1StringFromText.Text = GetSHA1HashFromText(input: textBoxText.Text);
			textBoxSHA256StringFromText.Text = GetSHA256HashFromText(input: textBoxText.Text);
			textBoxSHA384StringFromText.Text = GetSHA384HashFromText(input: textBoxText.Text);
			textBoxSHA512StringFromText.Text = GetSHA512HashFromText(input: textBoxText.Text);
		}

		/// <summary>
		/// Calculate the MD5 hash value from a file
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <returns>MD5 hash value</returns>
		private static string GetMD5HashFromFile(string fileName)
		{
			using FileStream fileStream = File.OpenRead(path: fileName);
			return BitConverter.ToString(value: MD5.Create().ComputeHash(inputStream: fileStream))
				.Replace(oldValue: Resources.dash, newValue: string.Empty);
		}

		/// <summary>
		/// Calculate the MD5 hash value from a text
		/// </summary>
		/// <param name="input">text</param>
		/// <returns>MD5 hash value</returns>
		private static string GetMD5HashFromText(string input)
		{
			byte[] hashBytes = MD5.HashData(source: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new();
			foreach (byte v in hashBytes)
			{
				stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		/// <summary>
		/// Calculate the SHA1 hash value from a file
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <returns>SHA1 hash value</returns>
		private static string GetSHA1HashFromFile(string fileName)
		{
			using FileStream fileStream = File.OpenRead(path: fileName);
			return BitConverter.ToString(value: SHA1.Create().ComputeHash(inputStream: fileStream))
				.Replace(oldValue: Resources.dash, newValue: string.Empty);
		}

		/// <summary>
		/// Calculate the SHA1 hash value from a text
		/// </summary>
		/// <param name="input">text</param>
		/// <returns>SHA1 hash value</returns>
		private static string GetSHA1HashFromText(string input)
		{
			byte[] hashBytes = SHA1.HashData(source: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new();
			foreach (byte v in hashBytes)
			{
				stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		/// <summary>
		/// Calculate the SHA256 hash value from a file
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <returns>SHA256 hash value</returns>
		private static string GetSHA256HashFromFile(string fileName)
		{
			using FileStream fileStream = File.OpenRead(path: fileName);
			return BitConverter.ToString(value: SHA256.Create().ComputeHash(inputStream: fileStream))
				.Replace(oldValue: Resources.dash, newValue: string.Empty);
		}

		/// <summary>
		/// Calculate the SHA256 hash value from a text
		/// </summary>
		/// <param name="input">text</param>
		/// <returns>SHA256 hash value</returns>
		private static string GetSHA256HashFromText(string input)
		{
			byte[] hashBytes = SHA256.HashData(source: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new();
			foreach (byte v in hashBytes)
			{
				stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		/// <summary>
		/// Calculate the SHA384 hash value from a file
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <returns>SHA384 hash value</returns>
		private static string GetSHA384HashFromFile(string fileName)
		{
			using FileStream fileStream = File.OpenRead(path: fileName);
			return BitConverter.ToString(value: SHA384.Create().ComputeHash(inputStream: fileStream))
				.Replace(oldValue: Resources.dash, newValue: string.Empty);
		}

		/// <summary>
		/// Calculate the SHA384 hash value from a text
		/// </summary>
		/// <param name="input">text</param>
		/// <returns>SHA384 hash value</returns>
		private static string GetSHA384HashFromText(string input)
		{
			byte[] hashBytes = SHA384.HashData(source: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new();
			foreach (byte v in hashBytes)
			{
				stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		/// <summary>
		/// Calculate the SHA512 hash value from a file
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <returns>SHA512 hash value</returns>
		private static string GetSHA512HashFromFile(string fileName)
		{
			using FileStream fileStream = File.OpenRead(path: fileName);
			return BitConverter.ToString(value: SHA512.Create().ComputeHash(inputStream: fileStream))
				.Replace(oldValue: Resources.dash, newValue: string.Empty);
		}

		/// <summary>
		/// Calculate the SHA512 hash value from a text
		/// </summary>
		/// <param name="input">text</param>
		/// <returns>SHA512 hash value</returns>
		private static string GetSHA512HashFromText(string input)
		{
			byte[] hashBytes = SHA512.HashData(source: Encoding.ASCII.GetBytes(s: input));
			StringBuilder stringBuilder = new();
			foreach (byte v in hashBytes)
			{
				stringBuilder.Append(value: v.ToString(format: "X2", provider: CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		/// <summary>
		/// Calculate the CRC32 hash value from a file
		/// </summary>
		/// <param name="fileName">file name</param>
		/// <returns>CRC32 hash value</returns>
		private static string GetCrc32HashFromFile(string fileName)
		{
			string str;
			using (Stream fs1 = File.Open(fileName, FileMode.Open))
			{
				using StreamReader sr = new(fs1);
				var temp = sr.ReadLine();//skip first line
				var data = sr.ReadToEnd();//reading data from next line
				byte[] plainText = Encoding.UTF8.GetBytes(data);
				str = System.IO.Hashing.Crc32.Hash(plainText).ToString();
			}
			return str;
			//return BitConverter.ToString(value: SHA512.Create().ComputeHash(inputStream: fileStream))
			//.Replace(oldValue: Resources.dash, newValue: string.Empty);
		}


		/// <summary>
		/// Save a hash value a file
		/// </summary>
		/// <param name="hashFileExtension">file extension</param>
		/// <param name="hashValue">hash value</param>
		/// <param name="saveAutomatic">save automatic</param>
		private void SaveHashValueToFile(string hashFileExtension, string hashValue, bool saveAutomatic)
		{
			saveFileDialog.FileName = $"{textBoxFileName.Text}{hashFileExtension}";
			if (saveAutomatic)
			{
				using FileStream fileStream = new(
					path: saveFileDialog.FileName,
					mode: FileMode.Create,
					access: FileAccess.Write);
				using StreamWriter streamWriter = new(stream: fileStream);
				streamWriter.Write(value: hashValue);
				streamWriter.Flush();
				streamWriter.Close();
			}
			else
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					using FileStream fileStream = new(
						path: saveFileDialog.FileName,
						mode: FileMode.Create,
						access: FileAccess.Write);
					using StreamWriter streamWriter = new(stream: fileStream);
					streamWriter.Write(value: hashValue);
					streamWriter.Flush();
					streamWriter.Close();
				}
			}
		}

		#endregion

		#region Load event handlers

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void MainForm_Load(object sender, EventArgs e)
		{
			SetStatusbarText(text: string.Empty);
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = AssemblyInfo.AssemblyVersion;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
			buttonCopyMD5StringFromFileToClipboard.Enabled = false;
			buttonCopySHA1StringFromFileToClipboard.Enabled = false;
			buttonCopySHA256StringFromFileToClipboard.Enabled = false;
			buttonCopySHA384StringFromFileToClipboard.Enabled = false;
			buttonCopySHA512StringFromFileToClipboard.Enabled = false;
			buttonSaveMD5StringToFile.Enabled = false;
			buttonSaveSHA1StringToFile.Enabled = false;
			buttonSaveSHA256StringToFile.Enabled = false;
			buttonSaveSHA384StringToFile.Enabled = false;
			buttonSaveSHA512StringToFile.Enabled = false;
			buttonCopyMD5StringFromTextToClipboard.Enabled = false;
			buttonCopySHA1StringFromTextToClipboard.Enabled = false;
			buttonCopySHA256StringFromTextToClipboard.Enabled = false;
			buttonCopySHA384StringFromTextToClipboard.Enabled = false;
			buttonCopySHA512StringFromTextToClipboard.Enabled = false;
			buttonSaveAllHashValuesAutomatically.Enabled = false;
			buttonSaveAllHashValuesInList.Enabled = false;
			buttonSaveAllHashValuesInClipboard.Enabled = false;
		}

		#endregion

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
				case ToolStripDropDown toolStripDropDown:SetStatusbarText(text: toolStripDropDown.AccessibleDescription); break;
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

		#region Click event handlers

		/// <summary>
		/// Open a url with the default web browser
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LinkLabelUrl_Click(object sender, EventArgs e) => OpenUrl(url: linkLabelUrl.Text);

		/// <summary>
		/// Open a file and calculate all hash values
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonOpenAndCalculateFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxFileName.Text = openFileDialog.FileName;
				CalculateHashesFromFile();
			}
		}

		/// <summary>
		/// Calculate the hash values from a string
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCalculateHashFromText_Click(object sender, EventArgs e) => CalculateHashesFromText();

		/// <summary>
		/// Copy the MD5 hash value from a file to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopyMD5StringFromFileToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxMD5StringFromFile.Text);

		/// <summary>
		/// Copy the MD5 hash value from a text to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopyMD5StringFromTextToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxMD5StringFromText.Text);

		/// <summary>
		/// Copy the SHA1 hash value from a file to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA1StringFromFileToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA1StringFromFile.Text);

		/// <summary>
		/// Copy the SHA1 hash value from a text to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA1StringFromTextToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA1StringFromText.Text);

		/// <summary>
		/// Copy the SHA512 hash value from a file to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA256StringFromFileToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA256StringFromFile.Text);

		/// <summary>
		/// Copy the SHA hash value from a text to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA256StringFromTextToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA256StringFromText.Text);

		/// <summary>
		/// Copy the SHA384 hash value from a file to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA384StringFromFileToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA384StringFromFile.Text);

		/// <summary>
		/// Copy the SHA384 hash value from a file to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA384StringFromTextToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA384StringFromText.Text);

		/// <summary>
		/// Copy the SHA512 hash value from a file to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA512StringFromFileToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA512StringFromFile.Text);

		/// <summary>
		/// Copy the SHA512 hash value from a text to the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonCopySHA512StringFromTextToClipboard_Click(object sender, EventArgs e) => CopyToClipboard(text: textBoxSHA512StringFromText.Text);

		/// <summary>
		/// Save the MD5 hash value to a file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveMD5StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
			hashFileExtension: Resources.md5FileExt,
			hashValue: textBoxMD5StringFromFile.Text,
			saveAutomatic: isSaveAutomatically);

		/// <summary>
		/// Save the SHA1 hash value to a file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveSHA1StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
			hashFileExtension: Resources.sha1FileExt,
			hashValue: textBoxSHA1StringFromFile.Text,
			saveAutomatic: isSaveAutomatically);

		/// <summary>
		/// Save the SHA256 hash value to a file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveSHA256StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
			hashFileExtension: Resources.sha256FileExt,
			hashValue: textBoxSHA256StringFromFile.Text,
			saveAutomatic: isSaveAutomatically);

		/// <summary>
		/// Save the SHA384 hash value to a file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveSHA384StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
			hashFileExtension: Resources.sha384FileExt,
			hashValue: textBoxSHA384StringFromFile.Text,
			saveAutomatic: isSaveAutomatically);

		/// <summary>
		/// Save the SHA512 hash value to a file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveSHA512StringToFile_Click(object sender, EventArgs e) => SaveHashValueToFile(
			hashFileExtension: Resources.sha512FileExt,
			hashValue: textBoxSHA512StringFromFile.Text,
			saveAutomatic: isSaveAutomatically);

		/// <summary>
		/// Save all hash values automatically in separate files
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveAllHashValuesAutomatically_Click(object sender, EventArgs e)
		{
			isSaveAutomatically = true;
			SaveHashValueToFile(
				hashFileExtension: Resources.md5FileExt,
				hashValue: textBoxMD5StringFromFile.Text,
				saveAutomatic: isSaveAutomatically);
			SaveHashValueToFile(
				hashFileExtension: Resources.sha1FileExt,
				hashValue: textBoxSHA1StringFromFile.Text,
				saveAutomatic: isSaveAutomatically);
			SaveHashValueToFile(
				hashFileExtension: Resources.sha256FileExt,
				hashValue: textBoxSHA256StringFromFile.Text,
				saveAutomatic: isSaveAutomatically);
			SaveHashValueToFile(
				hashFileExtension: Resources.sha384FileExt,
				hashValue: textBoxSHA384StringFromFile.Text,
				saveAutomatic: isSaveAutomatically);
			SaveHashValueToFile(
				hashFileExtension: Resources.sha512FileExt,
				hashValue: textBoxSHA512StringFromFile.Text,
				saveAutomatic: isSaveAutomatically);
			isSaveAutomatically = false;
			MessageBox.Show(
				text: Resources.saved,
				caption: Resources.info,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// Save all hash values in a list
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveAllHashValuesInList_Click(object sender, EventArgs e)
		{
			saveFileDialog.FileName = $"{textBoxFileName.Text}{Resources.checksumFileExt}";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string delimiter = $"{Resources.colonDelimiter}{Resources.spaceDelimiter}";
				using FileStream fileStream = new(
						path: saveFileDialog.FileName,
						mode: FileMode.Create,
						access: FileAccess.Write);
				using StreamWriter streamWriter = new(stream: fileStream);
				streamWriter.WriteLine(value: $"{Resources.md5}{delimiter}{textBoxMD5StringFromFile.Text}");
				streamWriter.WriteLine(value: $"{Resources.sha1}{delimiter}{textBoxSHA1StringFromFile.Text}");
				streamWriter.WriteLine(value: $"{Resources.sha256}{delimiter}{textBoxSHA256StringFromFile.Text}");
				streamWriter.WriteLine(value: $"{Resources.sha384}{delimiter}{textBoxSHA384StringFromFile.Text}");
				streamWriter.WriteLine(value: $"{Resources.sha512}{delimiter}{textBoxSHA512StringFromFile.Text}");
				streamWriter.Flush();
				streamWriter.Close();
			}
		}

		/// <summary>
		/// Save all hash values into the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSaveAllHashValuesInClipboard_Click(object sender, EventArgs e)
		{
			string delimiter = $"{Resources.colonDelimiter}{Resources.spaceDelimiter}";
			string listToClipboard = $"{Resources.md5}{delimiter}{textBoxMD5StringFromText.Text}{Environment.NewLine}";
			listToClipboard = $"{listToClipboard}{Resources.sha1}{delimiter}{textBoxSHA1StringFromText.Text}{Environment.NewLine}";
			listToClipboard = $"{listToClipboard}{Resources.sha256}{delimiter}{textBoxSHA256StringFromText.Text}{Environment.NewLine}";
			listToClipboard = $"{listToClipboard}{Resources.sha384}{delimiter}{textBoxSHA384StringFromText.Text}{Environment.NewLine}";
			listToClipboard = $"{listToClipboard}{Resources.sha512}{delimiter}{textBoxSHA512StringFromText.Text}{Environment.NewLine}";
			Clipboard.SetText(text: listToClipboard);
		}

		/// <summary>
		/// Start a self test and calculate his own hash values
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSelfTest_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tabPageFile;
			textBoxFileName.Text = Application.ExecutablePath;
			CalculateHashesFromFile();
		}

		/// <summary>
		/// Insert text from the clipboard
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonInsertTextFromClipboard_Click(object sender, EventArgs e)
		{
			if (Clipboard.ContainsText(format: TextDataFormat.Text) || Clipboard.ContainsText(format: TextDataFormat.Text))
			{
				textBoxText.Text = Clipboard.GetText(format: TextDataFormat.Text);
				CalculateHashesFromText();
			}
		}


		#endregion

		#region CheckedChange event handlers

		/// <summary>
		/// Enable/disable the calculation button to calculate the hash values from a text if the auto calculation mode is checked/unchecked.
		/// If unchecked the calculation button is enabled.
		/// If checked the calculation button is disabled.
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void CheckBoxAutoUpdateText_CheckedChanged(object sender, EventArgs e) => buttonCalculateHashFromText.Enabled = !buttonCalculateHashFromText.Enabled;

		#endregion

		#region DragDrop event handlers

		/// <summary>
		/// Pass the drag and drop events on the tabs
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException(paramName: nameof(e), message: $"{nameof(e)} is null.");
			}
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
			{
				tabControl.SelectedTab = tabPageFile;
				string[] files = e.Data.GetData(format: DataFormats.FileDrop) as string[];
				if (files.Length > 1)
				{
					MessageBox.Show(
						text: Resources.onlyFirstFileIsAccepted,
						caption: Resources.warning,
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Warning);
				}
				textBoxFileName.Text = files[0];
				CalculateHashesFromFile();
			}
			else
			{
				if (e.Data.GetDataPresent(format: DataFormats.Text) || e.Data.GetDataPresent(format: DataFormats.UnicodeText))
				{
					tabControl.SelectedTab = tabPageText;
					if (e.Data.GetDataPresent(format: DataFormats.Text))
					{
						textBoxText.Text = e.Data.GetData(format: DataFormats.Text) as string;
					}
					else if (e.Data.GetDataPresent(format: DataFormats.UnicodeText))
					{
						textBoxText.Text = e.Data.GetData(format: DataFormats.UnicodeText) as string;
					}
					CalculateHashesFromText();
				}
				else
				{
					MessageBox.Show(
						text: Resources.onlyFileOrTextAreAccepted,
						caption: Resources.warning,
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Warning);
				}
			}
		}

		/// <summary>
		/// Filters the acceptable drag and drop events
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e == null)
			{
				throw new ArgumentNullException(paramName: nameof(e), message: $"{nameof(e)} is null.");
			}
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop) ||
				e.Data.GetDataPresent(format: DataFormats.Text) ||
				e.Data.GetDataPresent(format: DataFormats.UnicodeText))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		#endregion

		#region TextChanged event handlers

		/// <summary>
		/// Calculate the hashes if input text is changed
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxText_TextChanged(object sender, EventArgs e)
		{
			if (checkBoxAutoUpdateText.Checked)
			{
				CalculateHashesFromText();
			}
		}

		/// <summary>
		/// Enable button to copy the MD5 hash value from a file into the clipboard and save in a file if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxMD5StringFromFile_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxMD5StringFromFile.Text))
			{
				buttonCopyMD5StringFromFileToClipboard.Enabled = true;
				buttonSaveMD5StringToFile.Enabled = true;
				buttonSaveAllHashValuesAutomatically.Enabled = true;
				buttonSaveAllHashValuesInList.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA1 hash value from a file into the clipboard and save in a file if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA1StringFromFile_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA1StringFromFile.Text))
			{
				buttonCopySHA1StringFromFileToClipboard.Enabled = true;
				buttonSaveSHA1StringToFile.Enabled = true;
				buttonSaveAllHashValuesAutomatically.Enabled = true;
				buttonSaveAllHashValuesInList.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA256 hash value from a file into the clipboard and save in a file if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA256StringFromFile_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA256StringFromFile.Text))
			{
				buttonCopySHA256StringFromFileToClipboard.Enabled = true;
				buttonSaveSHA256StringToFile.Enabled = true;
				buttonSaveAllHashValuesAutomatically.Enabled = true;
				buttonSaveAllHashValuesInList.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA384 hash value from a file into the clipboard and save in a file if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA384StringFromFile_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA384StringFromFile.Text))
			{
				buttonCopySHA384StringFromFileToClipboard.Enabled = true;
				buttonSaveSHA384StringToFile.Enabled = true;
				buttonSaveAllHashValuesAutomatically.Enabled = true;
				buttonSaveAllHashValuesInList.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA512 hash value from a file into the clipboard and save in a file if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA512StringFromFile_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA512StringFromFile.Text))
			{
				buttonCopySHA512StringFromFileToClipboard.Enabled = true;
				buttonSaveSHA512StringToFile.Enabled = true;
				buttonSaveAllHashValuesAutomatically.Enabled = true;
				buttonSaveAllHashValuesInList.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the MD5 hash value from a text into the clipboard if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxMD5StringFromText_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxMD5StringFromText.Text))
			{
				buttonCopyMD5StringFromTextToClipboard.Enabled = true;
				buttonSaveAllHashValuesInClipboard.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA1 hash value from a text into the clipboard if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA1StringFromText_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA1StringFromText.Text))
			{
				buttonCopySHA1StringFromTextToClipboard.Enabled = true;
				buttonSaveAllHashValuesInClipboard.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA256 hash value from a text into the clipboard if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA256StringFromText_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA256StringFromText.Text))
			{
				buttonCopySHA256StringFromTextToClipboard.Enabled = true;
				buttonSaveAllHashValuesInClipboard.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA384 hash value from a text into the clipboard if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA384StringFromText_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA384StringFromText.Text))
			{
				buttonCopySHA384StringFromTextToClipboard.Enabled = true;
				buttonSaveAllHashValuesInClipboard.Enabled = true;
			}
		}

		/// <summary>
		/// Enable button to copy the SHA512 hash value from a text into the clipboard if checked the input isn't empty or null
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void TextBoxSHA512StringFromText_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(value: textBoxSHA512StringFromText.Text))
			{
				buttonCopySHA512StringFromTextToClipboard.Enabled = true;
				buttonSaveAllHashValuesInClipboard.Enabled = true;
			}
		}
	}

	#endregion
}