using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NumericListGenerator
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void CheckedListBoxStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (checkedListBoxStyle.GetItemChecked(index: 0))
			{
				Application.VisualStyleState = VisualStyleState.NoneEnabled;
			}
			else
			{
				Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
			}
			Invalidate(invalidateChildren: true);
		}

		private void ButtonApply_Click(object sender, System.EventArgs e)
		{
		}

		private void ButtonCancel_Click(object sender, System.EventArgs e)
		{
		}
	}
}
