using System.Windows.Forms.VisualStyles;

namespace Numeric_List_Generator
{
	public partial class SettingsForm : Form
	{
		public SettingsForm() => InitializeComponent();

		private void CheckedListBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			Application.VisualStyleState = checkedListBoxStyle.GetItemChecked(index: 0) ? VisualStyleState.NoneEnabled : VisualStyleState.ClientAndNonClientAreasEnabled;
			Invalidate(invalidateChildren: true);
		}

		private void ButtonApply_Click(object sender, EventArgs e)
		{
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
		}
	}
}
