
namespace Numeric_List_Generator
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			checkedListBoxStatusbar = new CheckedListBox();
			groupBoxStatusbar = new GroupBox();
			groupBoxWindowBehaviour = new GroupBox();
			checkedListBoxWindowBehaviour = new CheckedListBox();
			groupBoxStyle = new GroupBox();
			checkedListBoxStyle = new CheckedListBox();
			toolTip = new ToolTip(components);
			buttonApply = new Button();
			buttonCancel = new Button();
			groupBoxStatusbar.SuspendLayout();
			groupBoxWindowBehaviour.SuspendLayout();
			groupBoxStyle.SuspendLayout();
			SuspendLayout();
			// 
			// checkedListBoxStatusbar
			// 
			checkedListBoxStatusbar.CheckOnClick = true;
			checkedListBoxStatusbar.Dock = DockStyle.Fill;
			checkedListBoxStatusbar.FormattingEnabled = true;
			checkedListBoxStatusbar.Items.AddRange(new object[] { "Angabe der Größe deaktivieren", "Angabe der Zeilen deaktivieren", "Angabe der Dauer deaktivieren", "Angabe des LIM deaktivieren" });
			checkedListBoxStatusbar.Location = new Point(4, 19);
			checkedListBoxStatusbar.Margin = new Padding(4, 3, 4, 3);
			checkedListBoxStatusbar.Name = "checkedListBoxStatusbar";
			checkedListBoxStatusbar.Size = new Size(229, 76);
			checkedListBoxStatusbar.TabIndex = 0;
			// 
			// groupBoxStatusbar
			// 
			groupBoxStatusbar.Controls.Add(checkedListBoxStatusbar);
			groupBoxStatusbar.Location = new Point(14, 135);
			groupBoxStatusbar.Margin = new Padding(4, 3, 4, 3);
			groupBoxStatusbar.Name = "groupBoxStatusbar";
			groupBoxStatusbar.Padding = new Padding(4, 3, 4, 3);
			groupBoxStatusbar.Size = new Size(237, 98);
			groupBoxStatusbar.TabIndex = 2;
			groupBoxStatusbar.TabStop = false;
			groupBoxStatusbar.Text = "Statusbar";
			// 
			// groupBoxWindowBehaviour
			// 
			groupBoxWindowBehaviour.Controls.Add(checkedListBoxWindowBehaviour);
			groupBoxWindowBehaviour.Location = new Point(14, 14);
			groupBoxWindowBehaviour.Margin = new Padding(4, 3, 4, 3);
			groupBoxWindowBehaviour.Name = "groupBoxWindowBehaviour";
			groupBoxWindowBehaviour.Padding = new Padding(4, 3, 4, 3);
			groupBoxWindowBehaviour.Size = new Size(233, 63);
			groupBoxWindowBehaviour.TabIndex = 0;
			groupBoxWindowBehaviour.TabStop = false;
			groupBoxWindowBehaviour.Text = "Fensterverhalten";
			// 
			// checkedListBoxWindowBehaviour
			// 
			checkedListBoxWindowBehaviour.CheckOnClick = true;
			checkedListBoxWindowBehaviour.Dock = DockStyle.Fill;
			checkedListBoxWindowBehaviour.FormattingEnabled = true;
			checkedListBoxWindowBehaviour.Items.AddRange(new object[] { "immer im Vordergrund halten", "ins Tray minimieren" });
			checkedListBoxWindowBehaviour.Location = new Point(4, 19);
			checkedListBoxWindowBehaviour.Margin = new Padding(4, 3, 4, 3);
			checkedListBoxWindowBehaviour.Name = "checkedListBoxWindowBehaviour";
			checkedListBoxWindowBehaviour.Size = new Size(225, 41);
			checkedListBoxWindowBehaviour.TabIndex = 0;
			// 
			// groupBoxStyle
			// 
			groupBoxStyle.Controls.Add(checkedListBoxStyle);
			groupBoxStyle.Location = new Point(14, 81);
			groupBoxStyle.Margin = new Padding(4, 3, 4, 3);
			groupBoxStyle.Name = "groupBoxStyle";
			groupBoxStyle.Padding = new Padding(4, 3, 4, 3);
			groupBoxStyle.Size = new Size(237, 47);
			groupBoxStyle.TabIndex = 1;
			groupBoxStyle.TabStop = false;
			groupBoxStyle.Text = "Aussehen";
			// 
			// checkedListBoxStyle
			// 
			checkedListBoxStyle.CheckOnClick = true;
			checkedListBoxStyle.Dock = DockStyle.Fill;
			checkedListBoxStyle.FormattingEnabled = true;
			checkedListBoxStyle.Items.AddRange(new object[] { "Visueller Stil deaktivieren" });
			checkedListBoxStyle.Location = new Point(4, 19);
			checkedListBoxStyle.Margin = new Padding(4, 3, 4, 3);
			checkedListBoxStyle.Name = "checkedListBoxStyle";
			checkedListBoxStyle.Size = new Size(229, 25);
			checkedListBoxStyle.TabIndex = 0;
			checkedListBoxStyle.SelectedIndexChanged += CheckedListBoxStyle_SelectedIndexChanged;
			// 
			// buttonApply
			// 
			buttonApply.DialogResult = DialogResult.OK;
			buttonApply.Image = Numeric_List_Generator.Properties.Resources.tick;
			buttonApply.Location = new Point(14, 240);
			buttonApply.Margin = new Padding(4, 3, 4, 3);
			buttonApply.Name = "buttonApply";
			buttonApply.Size = new Size(88, 27);
			buttonApply.TabIndex = 3;
			buttonApply.Text = "&Okay";
			buttonApply.TextAlign = ContentAlignment.MiddleRight;
			buttonApply.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonApply, "Wendet die Einstellungen an");
			buttonApply.UseVisualStyleBackColor = true;
			buttonApply.Click += ButtonApply_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Image = Numeric_List_Generator.Properties.Resources.cross;
			buttonCancel.Location = new Point(163, 240);
			buttonCancel.Margin = new Padding(4, 3, 4, 3);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(88, 27);
			buttonCancel.TabIndex = 4;
			buttonCancel.Text = "&Abbruch";
			buttonCancel.TextAlign = ContentAlignment.MiddleRight;
			buttonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCancel, "Bricht den Vorgang ab");
			buttonCancel.UseVisualStyleBackColor = true;
			buttonCancel.Click += ButtonCancel_Click;
			// 
			// SettingsForm
			// 
			AcceptButton = buttonApply;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(265, 280);
			Controls.Add(buttonCancel);
			Controls.Add(buttonApply);
			Controls.Add(groupBoxStyle);
			Controls.Add(groupBoxWindowBehaviour);
			Controls.Add(groupBoxStatusbar);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "SettingsForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Einstellungen";
			groupBoxStatusbar.ResumeLayout(false);
			groupBoxWindowBehaviour.ResumeLayout(false);
			groupBoxStyle.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private CheckedListBox checkedListBoxStatusbar;
		private GroupBox groupBoxStatusbar;
		private GroupBox groupBoxWindowBehaviour;
		private CheckedListBox checkedListBoxWindowBehaviour;
		private GroupBox groupBoxStyle;
		private CheckedListBox checkedListBoxStyle;
		private Button buttonApply;
		private ToolTip toolTip;
		private Button buttonCancel;
	}
}