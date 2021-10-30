
namespace NumericListGenerator
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
			this.components = new System.ComponentModel.Container();
			this.checkedListBoxStatusbar = new System.Windows.Forms.CheckedListBox();
			this.groupBoxStatusbar = new System.Windows.Forms.GroupBox();
			this.groupBoxWindowBehaviour = new System.Windows.Forms.GroupBox();
			this.checkedListBoxWindowBehaviour = new System.Windows.Forms.CheckedListBox();
			this.groupBoxStyle = new System.Windows.Forms.GroupBox();
			this.checkedListBoxStyle = new System.Windows.Forms.CheckedListBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxStatusbar.SuspendLayout();
			this.groupBoxWindowBehaviour.SuspendLayout();
			this.groupBoxStyle.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkedListBoxStatusbar
			// 
			this.checkedListBoxStatusbar.CheckOnClick = true;
			this.checkedListBoxStatusbar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxStatusbar.FormattingEnabled = true;
			this.checkedListBoxStatusbar.Items.AddRange(new object[] {
            "Angabe der Größe deaktivieren",
            "Angabe der Zeilen deaktivieren",
            "Angabe der Dauer deaktivieren",
            "Angabe des LIM deaktivieren"});
			this.checkedListBoxStatusbar.Location = new System.Drawing.Point(3, 16);
			this.checkedListBoxStatusbar.Name = "checkedListBoxStatusbar";
			this.checkedListBoxStatusbar.Size = new System.Drawing.Size(197, 66);
			this.checkedListBoxStatusbar.TabIndex = 0;
			// 
			// groupBoxStatusbar
			// 
			this.groupBoxStatusbar.Controls.Add(this.checkedListBoxStatusbar);
			this.groupBoxStatusbar.Location = new System.Drawing.Point(12, 117);
			this.groupBoxStatusbar.Name = "groupBoxStatusbar";
			this.groupBoxStatusbar.Size = new System.Drawing.Size(203, 85);
			this.groupBoxStatusbar.TabIndex = 2;
			this.groupBoxStatusbar.TabStop = false;
			this.groupBoxStatusbar.Text = "Statusbar";
			// 
			// groupBoxWindowBehaviour
			// 
			this.groupBoxWindowBehaviour.Controls.Add(this.checkedListBoxWindowBehaviour);
			this.groupBoxWindowBehaviour.Location = new System.Drawing.Point(12, 12);
			this.groupBoxWindowBehaviour.Name = "groupBoxWindowBehaviour";
			this.groupBoxWindowBehaviour.Size = new System.Drawing.Size(200, 55);
			this.groupBoxWindowBehaviour.TabIndex = 0;
			this.groupBoxWindowBehaviour.TabStop = false;
			this.groupBoxWindowBehaviour.Text = "Fensterverhalten";
			// 
			// checkedListBoxWindowBehaviour
			// 
			this.checkedListBoxWindowBehaviour.CheckOnClick = true;
			this.checkedListBoxWindowBehaviour.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxWindowBehaviour.FormattingEnabled = true;
			this.checkedListBoxWindowBehaviour.Items.AddRange(new object[] {
            "immer im Vordergrund halten",
            "ins Tray minimieren"});
			this.checkedListBoxWindowBehaviour.Location = new System.Drawing.Point(3, 16);
			this.checkedListBoxWindowBehaviour.Name = "checkedListBoxWindowBehaviour";
			this.checkedListBoxWindowBehaviour.Size = new System.Drawing.Size(194, 36);
			this.checkedListBoxWindowBehaviour.TabIndex = 0;
			// 
			// groupBoxStyle
			// 
			this.groupBoxStyle.Controls.Add(this.checkedListBoxStyle);
			this.groupBoxStyle.Location = new System.Drawing.Point(12, 70);
			this.groupBoxStyle.Name = "groupBoxStyle";
			this.groupBoxStyle.Size = new System.Drawing.Size(203, 41);
			this.groupBoxStyle.TabIndex = 1;
			this.groupBoxStyle.TabStop = false;
			this.groupBoxStyle.Text = "Aussehen";
			// 
			// checkedListBoxStyle
			// 
			this.checkedListBoxStyle.CheckOnClick = true;
			this.checkedListBoxStyle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxStyle.FormattingEnabled = true;
			this.checkedListBoxStyle.Items.AddRange(new object[] {
            "Visueller Stil deaktivieren"});
			this.checkedListBoxStyle.Location = new System.Drawing.Point(3, 16);
			this.checkedListBoxStyle.Name = "checkedListBoxStyle";
			this.checkedListBoxStyle.Size = new System.Drawing.Size(197, 22);
			this.checkedListBoxStyle.TabIndex = 0;
			this.checkedListBoxStyle.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxStyle_SelectedIndexChanged);
			// 
			// buttonApply
			// 
			this.buttonApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonApply.Image = global::NumericListGenerator.Properties.Resources.tick;
			this.buttonApply.Location = new System.Drawing.Point(12, 208);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 3;
			this.buttonApply.Text = "&Okay";
			this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonApply, "Wendet die Einstellungen an");
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Image = global::NumericListGenerator.Properties.Resources.cross;
			this.buttonCancel.Location = new System.Drawing.Point(140, 208);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "&Abbruch";
			this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCancel, "Bricht den Vorgang ab");
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.buttonApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(227, 243);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.groupBoxStyle);
			this.Controls.Add(this.groupBoxWindowBehaviour);
			this.Controls.Add(this.groupBoxStatusbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Einstellungen";
			this.groupBoxStatusbar.ResumeLayout(false);
			this.groupBoxWindowBehaviour.ResumeLayout(false);
			this.groupBoxStyle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBoxStatusbar;
		private System.Windows.Forms.GroupBox groupBoxStatusbar;
		private System.Windows.Forms.GroupBox groupBoxWindowBehaviour;
		private System.Windows.Forms.CheckedListBox checkedListBoxWindowBehaviour;
		private System.Windows.Forms.GroupBox groupBoxStyle;
		private System.Windows.Forms.CheckedListBox checkedListBoxStyle;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button buttonCancel;
	}
}