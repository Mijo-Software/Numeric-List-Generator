using System.Diagnostics;
using NLog;

namespace Numeric_List_Generator
{
	/// <summary>
	/// Represents the About Box form of the application.
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

	internal sealed partial class AboutBoxForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Sets a specific text to the status bar.
		/// </summary>
		/// <param name="text">The text with some information to display in the status bar.</param>
		private void SetStatusBarText(string text)
		{
			labelInformation.Enabled = !string.IsNullOrWhiteSpace(value: text);
			labelInformation.Text = text;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
		/// Sets the text of the labels to the corresponding assembly information.
		/// </summary>
		public AboutBoxForm()
		{
			InitializeComponent();
			Logger.Info(message: "AboutBoxForm initialisiert.");
			Text = $@"Info über {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $@"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			linkLabelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
			KeyDown += AboutBoxForm_KeyDown;
			KeyPreview = true; // Ensures the form receives key events before the controls
		}

		/// <summary>
		/// Handles the Load event of the AboutBoxForm control.
		/// Initializes the status bar text to an empty string.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void AboutBoxForm_Load(object sender, EventArgs e) => SetStatusBarText(text: string.Empty);

		/// <summary>
		/// Called when the mouse pointer moves over a control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusBar_Enter(object sender, EventArgs e)
		{
			// Set the status bar text based on the sender's accessible description
			switch (sender)
			{
				// If the sender is a control with an accessible description, set the status bar text
				// If the sender is a ToolStripItem with an accessible description, set the status bar text
				case Control { AccessibleDescription: not null } control:
					SetStatusBarText(text: control.AccessibleDescription);
					break;
				case ToolStripItem { AccessibleDescription: not null } item:
					SetStatusBarText(text: item.AccessibleDescription);
					break;
			}
		}

		/// <summary>
		/// Clears the information text of the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e) => SetStatusBarText(text: string.Empty);

		private void LabelCompanyName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Handle the link click event for the company name label
			if (linkLabelCompanyName.Tag == null)
			{
				return;
			}

			// Attempt to open the URL specified in the link label's Tag property
			string? url = linkLabelCompanyName.Tag.ToString();
			if (string.IsNullOrWhiteSpace(value: url))
			{
				return;
			}

			// Check if the URL starts with "http://" or "https://", if not, prepend "http://"
			try
			{
				using Process _ = Process.Start(fileName: url);
			}
			// Catch any exceptions that occur when trying to open the URL
			catch (Exception ex)
			{
				// Log the error and show a message box to the user
				string message = $"Fehler beim Öffnen der URL: {ex.Message}.";
				Debug.WriteLine(value: ex);
				Logger.Error(exception: ex, message: message);
				_ = MessageBox.Show(text: message, caption: @"Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void AboutBoxForm_KeyDown(object? sender, KeyEventArgs e)
		{
			// Check if the Escape key was pressed
			// If so, close the form
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
		}
	}
}