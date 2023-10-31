namespace Numeric_List_Generator
{
	partial class AboutBoxForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxForm));
			tableLayoutPanel = new TableLayoutPanel();
			logoPictureBox = new PictureBox();
			labelProductName = new Label();
			labelVersion = new Label();
			labelCopyright = new Label();
			labelCompanyName = new Label();
			textBoxDescription = new TextBox();
			okButton = new Button();
			toolTip = new ToolTip(components);
			statusStrip = new StatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Gruppiert die Elemente";
			tableLayoutPanel.AccessibleName = "Gruppiert die Elemente";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Grouping;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.50365F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.49635F));
			tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
			tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
			tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
			tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
			tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
			tableLayoutPanel.Controls.Add(okButton, 1, 5);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 6;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45.50265F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.40212F));
			tableLayoutPanel.Size = new Size(321, 172);
			tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			logoPictureBox.AccessibleDescription = "Zeigt das Programmlogo an";
			logoPictureBox.AccessibleName = "Programmlogo";
			logoPictureBox.AccessibleRole = AccessibleRole.Graphic;
			logoPictureBox.Dock = DockStyle.Fill;
			logoPictureBox.Image = Properties.Resources.text_list_numbers;
			logoPictureBox.Location = new Point(4, 3);
			logoPictureBox.Margin = new Padding(4, 3, 4, 3);
			logoPictureBox.Name = "logoPictureBox";
			tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
			logoPictureBox.Size = new Size(35, 166);
			logoPictureBox.TabIndex = 12;
			logoPictureBox.TabStop = false;
			toolTip.SetToolTip(logoPictureBox, "Programmlogo");
			logoPictureBox.MouseEnter += SetStatusbar_Enter;
			logoPictureBox.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelProductName
			// 
			labelProductName.AccessibleDescription = "Zeigt den Produktnamen an";
			labelProductName.AccessibleName = "Produktname";
			labelProductName.AccessibleRole = AccessibleRole.StaticText;
			labelProductName.AutoEllipsis = true;
			labelProductName.Dock = DockStyle.Fill;
			labelProductName.Location = new Point(50, 0);
			labelProductName.Margin = new Padding(7, 0, 4, 0);
			labelProductName.MaximumSize = new Size(0, 20);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(267, 16);
			labelProductName.TabIndex = 0;
			labelProductName.Text = "Produktname";
			labelProductName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelProductName, "Produktname");
			labelProductName.Enter += SetStatusbar_Enter;
			labelProductName.Leave += ClearStatusbar_Leave;
			labelProductName.MouseEnter += SetStatusbar_Enter;
			labelProductName.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelVersion
			// 
			labelVersion.AccessibleDescription = "Zeigt die Version an";
			labelVersion.AccessibleName = "Version";
			labelVersion.AccessibleRole = AccessibleRole.StaticText;
			labelVersion.AutoEllipsis = true;
			labelVersion.Dock = DockStyle.Fill;
			labelVersion.Location = new Point(50, 16);
			labelVersion.Margin = new Padding(7, 0, 4, 0);
			labelVersion.MaximumSize = new Size(0, 20);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(267, 16);
			labelVersion.TabIndex = 1;
			labelVersion.Text = "Version";
			labelVersion.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelVersion, "Version");
			labelVersion.Enter += SetStatusbar_Enter;
			labelVersion.Leave += ClearStatusbar_Leave;
			labelVersion.MouseEnter += SetStatusbar_Enter;
			labelVersion.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelCopyright
			// 
			labelCopyright.AccessibleDescription = "Zeigt den Copyrightvermerk an";
			labelCopyright.AccessibleName = "Copyright";
			labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			labelCopyright.AutoEllipsis = true;
			labelCopyright.Dock = DockStyle.Fill;
			labelCopyright.Location = new Point(50, 32);
			labelCopyright.Margin = new Padding(7, 0, 4, 0);
			labelCopyright.MaximumSize = new Size(0, 20);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(267, 16);
			labelCopyright.TabIndex = 2;
			labelCopyright.Text = "Copyright";
			labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCopyright, "Copyright");
			labelCopyright.Enter += SetStatusbar_Enter;
			labelCopyright.Leave += ClearStatusbar_Leave;
			labelCopyright.MouseEnter += SetStatusbar_Enter;
			labelCopyright.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelCompanyName
			// 
			labelCompanyName.AccessibleDescription = "Zeigt den Firmenname an";
			labelCompanyName.AccessibleName = "Firmenname";
			labelCompanyName.AccessibleRole = AccessibleRole.StaticText;
			labelCompanyName.AutoEllipsis = true;
			labelCompanyName.Dock = DockStyle.Fill;
			labelCompanyName.Location = new Point(50, 48);
			labelCompanyName.Margin = new Padding(7, 0, 4, 0);
			labelCompanyName.MaximumSize = new Size(0, 20);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(267, 16);
			labelCompanyName.TabIndex = 3;
			labelCompanyName.Text = "Firmenname";
			labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCompanyName, "Firmenname");
			labelCompanyName.Enter += SetStatusbar_Enter;
			labelCompanyName.Leave += ClearStatusbar_Leave;
			labelCompanyName.MouseEnter += SetStatusbar_Enter;
			labelCompanyName.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxDescription
			// 
			textBoxDescription.AccessibleDescription = "Zeigt die Beschreibung an";
			textBoxDescription.AccessibleName = "Beschreibung";
			textBoxDescription.AccessibleRole = AccessibleRole.Text;
			textBoxDescription.Dock = DockStyle.Fill;
			textBoxDescription.Location = new Point(50, 67);
			textBoxDescription.Margin = new Padding(7, 3, 4, 3);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.PlaceholderText = "Beschreibung";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(267, 70);
			textBoxDescription.TabIndex = 4;
			textBoxDescription.TabStop = false;
			textBoxDescription.Text = "Beschreibung";
			toolTip.SetToolTip(textBoxDescription, "Beschreibung");
			textBoxDescription.Enter += SetStatusbar_Enter;
			textBoxDescription.Leave += ClearStatusbar_Leave;
			textBoxDescription.MouseEnter += SetStatusbar_Enter;
			textBoxDescription.MouseLeave += ClearStatusbar_Leave;
			// 
			// okButton
			// 
			okButton.AccessibleDescription = "Schließt das Genster";
			okButton.AccessibleName = "Okay";
			okButton.AccessibleRole = AccessibleRole.PushButton;
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.AutoEllipsis = true;
			okButton.DialogResult = DialogResult.Cancel;
			okButton.Image = Properties.Resources.tick;
			okButton.Location = new Point(251, 143);
			okButton.Margin = new Padding(4, 3, 4, 3);
			okButton.Name = "okButton";
			okButton.Size = new Size(66, 26);
			okButton.TabIndex = 5;
			okButton.Text = "&OK";
			okButton.TextAlign = ContentAlignment.MiddleRight;
			okButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(okButton, "Okay");
			okButton.Enter += SetStatusbar_Enter;
			okButton.Leave += ClearStatusbar_Leave;
			okButton.MouseEnter += SetStatusbar_Enter;
			okButton.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Show the status bar";
			statusStrip.AccessibleName = "status bar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.AllowItemReorder = true;
			statusStrip.Dock = DockStyle.None;
			statusStrip.GripStyle = ToolStripGripStyle.Visible;
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(321, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 1;
			statusStrip.TabStop = true;
			statusStrip.Text = "statusStrip";
			toolTip.SetToolTip(statusStrip, "Show the status bar");
			statusStrip.Enter += SetStatusbar_Enter;
			statusStrip.Leave += ClearStatusbar_Leave;
			statusStrip.MouseEnter += SetStatusbar_Enter;
			statusStrip.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Show some information";
			labelInformation.AccessibleName = "some information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(28, 17);
			labelInformation.Text = "info";
			labelInformation.MouseEnter += SetStatusbar_Enter;
			labelInformation.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Container";
			toolStripContainer.AccessibleName = "Container";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanel);
			toolStripContainer.ContentPanel.Size = new Size(321, 172);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(10, 10);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(321, 219);
			toolStripContainer.TabIndex = 2;
			toolStripContainer.Text = "Container";
			// 
			// AboutBoxForm
			// 
			AcceptButton = okButton;
			AccessibleDescription = "Fenster der Programminformation";
			AccessibleName = "Fenster der Programminformation";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(341, 239);
			Controls.Add(toolStripContainer);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutBoxForm";
			Padding = new Padding(10);
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Informationen";
			Load += AboutBoxForm_Load;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel;
		private PictureBox logoPictureBox;
		private Label labelProductName;
		private Label labelVersion;
		private Label labelCopyright;
		private Label labelCompanyName;
		private TextBox textBoxDescription;
		private Button okButton;
		private ToolTip toolTip;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel labelInformation;
		private ToolStripContainer toolStripContainer;
	}
}
