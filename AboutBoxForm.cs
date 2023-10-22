using MijoSoftware.AssemblyInformation;

namespace Numeric_List_Generator
{
	partial class AboutBoxForm : Form
	{
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
	}
}
