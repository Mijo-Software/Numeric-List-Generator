using System.Diagnostics;

namespace Numeric_List_Generator
{
	/// <summary>
	/// Represents the About Box form of the application.
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

	internal partial class AboutBoxForm : Form
	{
		/// <summary>
		/// Returns a string that represents the current object for debugging purposes.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		private string GetDebuggerDisplay() => ToString();

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
		/// Initializes a new instance of the <see cref="AboutBoxForm"/> class.
		/// Sets the text of the labels to the corresponding assembly information.
		/// </summary>
		public AboutBoxForm()
		{
			InitializeComponent();
			Text = $"Info über {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}

		/// <summary>
		/// Handles the Load event of the AboutBoxForm control.
		/// Initializes the status bar text to an empty string.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void AboutBoxForm_Load(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

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
	}
}