namespace NumericListGenerator
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxForm));
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			this.toolStripContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
			this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel);
			resources.ApplyResources(this.toolStripContainer, "toolStripContainer");
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// statusStrip
			// 
			this.statusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
			resources.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.SizingGrip = false;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox);
			this.tableLayoutPanel.Controls.Add(this.labelProductName);
			this.tableLayoutPanel.Controls.Add(this.labelVersion);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription);
			this.tableLayoutPanel.Controls.Add(this.okButton);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
			resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
			this.logoPictureBox.Image = global::NumericListGenerator.Properties.Resources.text_list_numbers;
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelProductName.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.labelProductName, "labelProductName");
			this.labelProductName.Name = "labelProductName";
			// 
			// labelVersion
			// 
			this.labelVersion.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelVersion.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.labelVersion, "labelVersion");
			this.labelVersion.Name = "labelVersion";
			// 
			// labelCopyright
			// 
			this.labelCopyright.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.labelCopyright, "labelCopyright");
			this.labelCopyright.Name = "labelCopyright";
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.labelCompanyName, "labelCompanyName");
			this.labelCompanyName.Name = "labelCompanyName";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.TabStop = false;
			// 
			// okButton
			// 
			this.okButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			resources.ApplyResources(this.okButton, "okButton");
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Image = global::NumericListGenerator.Properties.Resources.tick;
			this.okButton.Name = "okButton";
			// 
			// AboutBoxForm
			// 
			this.AcceptButton = this.okButton;
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBoxForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.AboutBoxForm_Load);
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.PictureBox logoPictureBox;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.Label labelCompanyName;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
	}
}
