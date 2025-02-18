using System.Diagnostics;
using NLog;

namespace Numeric_List_Generator
{
	/// <summary>
	/// Represents a form that displays license information.
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

	internal partial class LicenseForm : Form
	{
		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Sets a specific text to the status bar.
		/// </summary>
		/// <param name="text">The text with some information to display in the status bar.</param>
		private void SetStatusbarText(string text)
		{
			labelInformation.Enabled = !string.IsNullOrWhiteSpace(value: text);
			labelInformation.Text = text;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LicenseForm"/> class.
		/// </summary>
		public LicenseForm()
		{
			InitializeComponent();
			Logger.Info(message: "LicenseForm initialisiert.");
			this.KeyDown += new KeyEventHandler(LicenseForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
		}

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void LicenseForm_Load(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

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

		/// <summary>
		/// Clears the information text of the status bar.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LicenseForm_KeyDown(object? sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
