using MijoSoftware.AssemblyInformation;

using System;
using System.Windows.Forms;

namespace NumericListGenerator
{
	/// <summary>
	/// AboutBoxForm
	/// </summary>
	internal partial class AboutBoxForm : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AboutBoxForm() => InitializeComponent();

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e) => toolStripStatusLabel.Text = ((Control)sender).AccessibleDescription;

		/// <summary>
		/// Clear the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => toolStripStatusLabel.Text = string.Empty;

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void AboutBoxForm_Load(object sender, EventArgs e)
		{
			Text = $"Info über {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}
	}
}
