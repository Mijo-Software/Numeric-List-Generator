
namespace Hasher
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			labelFileName = new Label();
			textBoxFileName = new TextBox();
			labelMD5StringFromFile = new Label();
			textBoxMD5StringFromFile = new TextBox();
			openFileDialog = new OpenFileDialog();
			textBoxSHA1StringFromFile = new TextBox();
			labelSHA1StringFromFile = new Label();
			textBoxSHA256StringFromFile = new TextBox();
			labelSHA256StringFromFile = new Label();
			textBoxSHA384StringFromFile = new TextBox();
			labelSHA384FromFile = new Label();
			textBoxSHA512StringFromFile = new TextBox();
			labelSHA512StringFromFile = new Label();
			saveFileDialog = new SaveFileDialog();
			buttonSaveSHA512StringToFile = new Button();
			buttonSaveSHA384StringToFile = new Button();
			buttonSaveSHA256StringToFile = new Button();
			buttonSaveSHA1StringToFile = new Button();
			buttonSaveMD5StringToFile = new Button();
			buttonCopySHA512StringFromFileToClipboard = new Button();
			buttonCopySHA384StringFromFileToClipboard = new Button();
			buttonCopySHA256StringFromFileToClipboard = new Button();
			buttonCopySHA1StringFromFileToClipboard = new Button();
			buttonCopyMD5StringFromFileToClipboard = new Button();
			buttonOpenAndCalculateHashFromFile = new Button();
			tabControl = new TabControl();
			tabPageFile = new TabPage();
			buttonSaveAllHashValuesInList = new Button();
			buttonSaveAllHashValuesAutomatically = new Button();
			tabPageText = new TabPage();
			buttonInsertTextFromClipboard = new Button();
			buttonSaveAllHashValuesInClipboard = new Button();
			checkBoxAutoUpdateText = new CheckBox();
			labelText = new Label();
			textBoxText = new TextBox();
			buttonCalculateHashFromText = new Button();
			labelMD5StringFromText = new Label();
			textBoxMD5StringFromText = new TextBox();
			buttonCopyMD5StringFromTextToClipboard = new Button();
			buttonCopySHA512StringFromTextToClipboard = new Button();
			textBoxSHA512StringFromText = new TextBox();
			labelSHA1StringFromText = new Label();
			labelSHA512StringFromText = new Label();
			textBoxSHA1StringFromText = new TextBox();
			buttonCopySHA384StringFromTextToClipboard = new Button();
			buttonCopySHA1StringFromTextToClipboard = new Button();
			textBoxSHA384StringFromText = new TextBox();
			labelSHA256StringFromText = new Label();
			labelSHA384StringFromText = new Label();
			textBoxSHA256StringFromText = new TextBox();
			buttonCopySHA256StringFromTextToClipboard = new Button();
			tabPageInfo = new TabPage();
			buttonSelfTest = new Button();
			linkLabelUrl = new LinkLabel();
			textBoxDescription = new TextBox();
			labelCompanyName = new Label();
			labelCopyright = new Label();
			labelVersion = new Label();
			labelProductName = new Label();
			logoPictureBox = new PictureBox();
			tabPageLicense = new TabPage();
			textBoxLicense = new TextBox();
			imageListTab = new ImageList(components);
			statusStrip = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			toolTip = new ToolTip(components);
			toolStripContainer = new ToolStripContainer();
			buttonbuttonSaveCrc32StringToFile = new Button();
			buttonCopyCrc32StringFromFileToClipboard = new Button();
			textBoxCrc32StringFromFile = new TextBox();
			labelCrc32StringFromFile = new Label();
			tabControl.SuspendLayout();
			tabPageFile.SuspendLayout();
			tabPageText.SuspendLayout();
			tabPageInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			tabPageLicense.SuspendLayout();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// labelFileName
			// 
			labelFileName.AccessibleDescription = "file";
			labelFileName.AccessibleName = "file";
			labelFileName.AccessibleRole = AccessibleRole.StaticText;
			labelFileName.AutoSize = true;
			labelFileName.Location = new Point(8, 14);
			labelFileName.Margin = new Padding(4, 0, 4, 0);
			labelFileName.Name = "labelFileName";
			labelFileName.Size = new Size(28, 15);
			labelFileName.TabIndex = 0;
			labelFileName.Text = "File:";
			toolTip.SetToolTip(labelFileName, "file");
			labelFileName.Enter += SetStatusbar_Enter;
			labelFileName.Leave += ClearStatusbar_Leave;
			labelFileName.MouseEnter += SetStatusbar_Enter;
			labelFileName.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxFileName
			// 
			textBoxFileName.AccessibleDescription = "Show the path of the file";
			textBoxFileName.AccessibleName = "Path of the file";
			textBoxFileName.AccessibleRole = AccessibleRole.Text;
			textBoxFileName.Location = new Point(46, 10);
			textBoxFileName.Margin = new Padding(4, 3, 4, 3);
			textBoxFileName.Name = "textBoxFileName";
			textBoxFileName.ReadOnly = true;
			textBoxFileName.Size = new Size(401, 23);
			textBoxFileName.TabIndex = 1;
			toolTip.SetToolTip(textBoxFileName, "Path of the file");
			textBoxFileName.Enter += SetStatusbar_Enter;
			textBoxFileName.Leave += ClearStatusbar_Leave;
			textBoxFileName.MouseEnter += SetStatusbar_Enter;
			textBoxFileName.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMD5StringFromFile
			// 
			labelMD5StringFromFile.AccessibleDescription = "MD5";
			labelMD5StringFromFile.AccessibleName = "MD5";
			labelMD5StringFromFile.AccessibleRole = AccessibleRole.StaticText;
			labelMD5StringFromFile.AutoSize = true;
			labelMD5StringFromFile.Location = new Point(9, 48);
			labelMD5StringFromFile.Margin = new Padding(4, 0, 4, 0);
			labelMD5StringFromFile.Name = "labelMD5StringFromFile";
			labelMD5StringFromFile.Size = new Size(35, 15);
			labelMD5StringFromFile.TabIndex = 4;
			labelMD5StringFromFile.Text = "MD5:";
			toolTip.SetToolTip(labelMD5StringFromFile, "MD5 hash");
			labelMD5StringFromFile.Enter += SetStatusbar_Enter;
			labelMD5StringFromFile.Leave += ClearStatusbar_Leave;
			labelMD5StringFromFile.MouseEnter += SetStatusbar_Enter;
			labelMD5StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxMD5StringFromFile
			// 
			textBoxMD5StringFromFile.AccessibleDescription = "Show the MD5 hash value";
			textBoxMD5StringFromFile.AccessibleName = "MD5 hash value";
			textBoxMD5StringFromFile.AccessibleRole = AccessibleRole.Text;
			textBoxMD5StringFromFile.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxMD5StringFromFile.Location = new Point(67, 45);
			textBoxMD5StringFromFile.Margin = new Padding(4, 3, 4, 3);
			textBoxMD5StringFromFile.Name = "textBoxMD5StringFromFile";
			textBoxMD5StringFromFile.ReadOnly = true;
			textBoxMD5StringFromFile.Size = new Size(441, 20);
			textBoxMD5StringFromFile.TabIndex = 5;
			toolTip.SetToolTip(textBoxMD5StringFromFile, "MD5 hash value");
			textBoxMD5StringFromFile.TextChanged += TextBoxMD5StringFromFile_TextChanged;
			textBoxMD5StringFromFile.Enter += SetStatusbar_Enter;
			textBoxMD5StringFromFile.Leave += ClearStatusbar_Leave;
			textBoxMD5StringFromFile.MouseEnter += SetStatusbar_Enter;
			textBoxMD5StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// openFileDialog
			// 
			openFileDialog.SupportMultiDottedExtensions = true;
			openFileDialog.Title = "Load file";
			// 
			// textBoxSHA1StringFromFile
			// 
			textBoxSHA1StringFromFile.AccessibleDescription = "Show the SHA1 hash value";
			textBoxSHA1StringFromFile.AccessibleName = "SHA1 hash value";
			textBoxSHA1StringFromFile.AccessibleRole = AccessibleRole.Text;
			textBoxSHA1StringFromFile.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA1StringFromFile.Location = new Point(67, 79);
			textBoxSHA1StringFromFile.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA1StringFromFile.Name = "textBoxSHA1StringFromFile";
			textBoxSHA1StringFromFile.ReadOnly = true;
			textBoxSHA1StringFromFile.Size = new Size(441, 20);
			textBoxSHA1StringFromFile.TabIndex = 13;
			toolTip.SetToolTip(textBoxSHA1StringFromFile, "SHA1 hash value");
			textBoxSHA1StringFromFile.TextChanged += TextBoxSHA1StringFromFile_TextChanged;
			textBoxSHA1StringFromFile.Enter += SetStatusbar_Enter;
			textBoxSHA1StringFromFile.Leave += ClearStatusbar_Leave;
			textBoxSHA1StringFromFile.MouseEnter += SetStatusbar_Enter;
			textBoxSHA1StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA1StringFromFile
			// 
			labelSHA1StringFromFile.AccessibleDescription = "SHA1";
			labelSHA1StringFromFile.AccessibleName = "SHA1";
			labelSHA1StringFromFile.AccessibleRole = AccessibleRole.StaticText;
			labelSHA1StringFromFile.AutoSize = true;
			labelSHA1StringFromFile.Location = new Point(9, 82);
			labelSHA1StringFromFile.Margin = new Padding(4, 0, 4, 0);
			labelSHA1StringFromFile.Name = "labelSHA1StringFromFile";
			labelSHA1StringFromFile.Size = new Size(39, 15);
			labelSHA1StringFromFile.TabIndex = 12;
			labelSHA1StringFromFile.Text = "SHA1:";
			toolTip.SetToolTip(labelSHA1StringFromFile, "SHA1 hash");
			labelSHA1StringFromFile.Enter += SetStatusbar_Enter;
			labelSHA1StringFromFile.Leave += ClearStatusbar_Leave;
			labelSHA1StringFromFile.MouseEnter += SetStatusbar_Enter;
			labelSHA1StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSHA256StringFromFile
			// 
			textBoxSHA256StringFromFile.AccessibleDescription = "Show the SHA256 hash value";
			textBoxSHA256StringFromFile.AccessibleName = "SHA256 hash value";
			textBoxSHA256StringFromFile.AccessibleRole = AccessibleRole.Text;
			textBoxSHA256StringFromFile.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA256StringFromFile.Location = new Point(67, 113);
			textBoxSHA256StringFromFile.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA256StringFromFile.Name = "textBoxSHA256StringFromFile";
			textBoxSHA256StringFromFile.ReadOnly = true;
			textBoxSHA256StringFromFile.Size = new Size(442, 20);
			textBoxSHA256StringFromFile.TabIndex = 17;
			toolTip.SetToolTip(textBoxSHA256StringFromFile, "SHA256 hash value");
			textBoxSHA256StringFromFile.TextChanged += TextBoxSHA256StringFromFile_TextChanged;
			textBoxSHA256StringFromFile.Enter += SetStatusbar_Enter;
			textBoxSHA256StringFromFile.Leave += ClearStatusbar_Leave;
			textBoxSHA256StringFromFile.MouseEnter += SetStatusbar_Enter;
			textBoxSHA256StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA256StringFromFile
			// 
			labelSHA256StringFromFile.AccessibleDescription = "SHA256";
			labelSHA256StringFromFile.AccessibleName = "SHA256";
			labelSHA256StringFromFile.AccessibleRole = AccessibleRole.StaticText;
			labelSHA256StringFromFile.AutoSize = true;
			labelSHA256StringFromFile.Location = new Point(9, 116);
			labelSHA256StringFromFile.Margin = new Padding(4, 0, 4, 0);
			labelSHA256StringFromFile.Name = "labelSHA256StringFromFile";
			labelSHA256StringFromFile.Size = new Size(51, 15);
			labelSHA256StringFromFile.TabIndex = 16;
			labelSHA256StringFromFile.Text = "SHA256:";
			toolTip.SetToolTip(labelSHA256StringFromFile, "SHA256 hash");
			labelSHA256StringFromFile.Enter += SetStatusbar_Enter;
			labelSHA256StringFromFile.Leave += ClearStatusbar_Leave;
			labelSHA256StringFromFile.MouseEnter += SetStatusbar_Enter;
			labelSHA256StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSHA384StringFromFile
			// 
			textBoxSHA384StringFromFile.AccessibleDescription = "Show the SHA384 hash value";
			textBoxSHA384StringFromFile.AccessibleName = "SHA384 hash value";
			textBoxSHA384StringFromFile.AccessibleRole = AccessibleRole.Text;
			textBoxSHA384StringFromFile.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA384StringFromFile.Location = new Point(67, 147);
			textBoxSHA384StringFromFile.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA384StringFromFile.Name = "textBoxSHA384StringFromFile";
			textBoxSHA384StringFromFile.ReadOnly = true;
			textBoxSHA384StringFromFile.Size = new Size(442, 20);
			textBoxSHA384StringFromFile.TabIndex = 21;
			toolTip.SetToolTip(textBoxSHA384StringFromFile, "SHA384 hash value");
			textBoxSHA384StringFromFile.TextChanged += TextBoxSHA384StringFromFile_TextChanged;
			textBoxSHA384StringFromFile.Enter += SetStatusbar_Enter;
			textBoxSHA384StringFromFile.Leave += ClearStatusbar_Leave;
			textBoxSHA384StringFromFile.MouseEnter += SetStatusbar_Enter;
			textBoxSHA384StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA384FromFile
			// 
			labelSHA384FromFile.AccessibleDescription = "SHA384";
			labelSHA384FromFile.AccessibleName = "SHA384";
			labelSHA384FromFile.AccessibleRole = AccessibleRole.StaticText;
			labelSHA384FromFile.AutoSize = true;
			labelSHA384FromFile.Location = new Point(9, 150);
			labelSHA384FromFile.Margin = new Padding(4, 0, 4, 0);
			labelSHA384FromFile.Name = "labelSHA384FromFile";
			labelSHA384FromFile.Size = new Size(51, 15);
			labelSHA384FromFile.TabIndex = 20;
			labelSHA384FromFile.Text = "SHA384:";
			toolTip.SetToolTip(labelSHA384FromFile, "SHA384 hash");
			labelSHA384FromFile.Enter += SetStatusbar_Enter;
			labelSHA384FromFile.Leave += ClearStatusbar_Leave;
			labelSHA384FromFile.MouseEnter += SetStatusbar_Enter;
			labelSHA384FromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSHA512StringFromFile
			// 
			textBoxSHA512StringFromFile.AccessibleDescription = "Show the SHA512 hash value";
			textBoxSHA512StringFromFile.AccessibleName = "SHA512 hash value";
			textBoxSHA512StringFromFile.AccessibleRole = AccessibleRole.Text;
			textBoxSHA512StringFromFile.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA512StringFromFile.Location = new Point(67, 181);
			textBoxSHA512StringFromFile.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA512StringFromFile.Name = "textBoxSHA512StringFromFile";
			textBoxSHA512StringFromFile.ReadOnly = true;
			textBoxSHA512StringFromFile.Size = new Size(441, 20);
			textBoxSHA512StringFromFile.TabIndex = 25;
			toolTip.SetToolTip(textBoxSHA512StringFromFile, "SHA512 hash value");
			textBoxSHA512StringFromFile.TextChanged += TextBoxSHA512StringFromFile_TextChanged;
			textBoxSHA512StringFromFile.Enter += SetStatusbar_Enter;
			textBoxSHA512StringFromFile.Leave += ClearStatusbar_Leave;
			textBoxSHA512StringFromFile.MouseEnter += SetStatusbar_Enter;
			textBoxSHA512StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA512StringFromFile
			// 
			labelSHA512StringFromFile.AccessibleDescription = "SHA512";
			labelSHA512StringFromFile.AccessibleName = "SHA512";
			labelSHA512StringFromFile.AccessibleRole = AccessibleRole.StaticText;
			labelSHA512StringFromFile.AutoSize = true;
			labelSHA512StringFromFile.Location = new Point(8, 184);
			labelSHA512StringFromFile.Margin = new Padding(4, 0, 4, 0);
			labelSHA512StringFromFile.Name = "labelSHA512StringFromFile";
			labelSHA512StringFromFile.Size = new Size(51, 15);
			labelSHA512StringFromFile.TabIndex = 24;
			labelSHA512StringFromFile.Text = "SHA512:";
			toolTip.SetToolTip(labelSHA512StringFromFile, "SHA512 hash");
			labelSHA512StringFromFile.Enter += SetStatusbar_Enter;
			labelSHA512StringFromFile.Leave += ClearStatusbar_Leave;
			labelSHA512StringFromFile.MouseEnter += SetStatusbar_Enter;
			labelSHA512StringFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// saveFileDialog
			// 
			saveFileDialog.SupportMultiDottedExtensions = true;
			saveFileDialog.Title = "Save hash value to file";
			// 
			// buttonSaveSHA512StringToFile
			// 
			buttonSaveSHA512StringToFile.AccessibleDescription = "Save the SHA512 hash value in a file";
			buttonSaveSHA512StringToFile.AccessibleName = "Save SHA512 hash to file";
			buttonSaveSHA512StringToFile.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveSHA512StringToFile.AutoEllipsis = true;
			buttonSaveSHA512StringToFile.Image = (Image)resources.GetObject("buttonSaveSHA512StringToFile.Image");
			buttonSaveSHA512StringToFile.Location = new Point(552, 177);
			buttonSaveSHA512StringToFile.Margin = new Padding(4, 3, 4, 3);
			buttonSaveSHA512StringToFile.Name = "buttonSaveSHA512StringToFile";
			buttonSaveSHA512StringToFile.Size = new Size(28, 28);
			buttonSaveSHA512StringToFile.TabIndex = 27;
			buttonSaveSHA512StringToFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveSHA512StringToFile, "Save the SHA512 hash value in a file");
			buttonSaveSHA512StringToFile.UseVisualStyleBackColor = true;
			buttonSaveSHA512StringToFile.Click += ButtonSaveSHA512StringToFile_Click;
			buttonSaveSHA512StringToFile.Enter += SetStatusbar_Enter;
			buttonSaveSHA512StringToFile.Leave += ClearStatusbar_Leave;
			buttonSaveSHA512StringToFile.MouseEnter += SetStatusbar_Enter;
			buttonSaveSHA512StringToFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveSHA384StringToFile
			// 
			buttonSaveSHA384StringToFile.AccessibleDescription = "Save the SHA384 hash value in a file";
			buttonSaveSHA384StringToFile.AccessibleName = "Save SHA384 hash to file";
			buttonSaveSHA384StringToFile.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveSHA384StringToFile.AutoEllipsis = true;
			buttonSaveSHA384StringToFile.Image = (Image)resources.GetObject("buttonSaveSHA384StringToFile.Image");
			buttonSaveSHA384StringToFile.Location = new Point(552, 143);
			buttonSaveSHA384StringToFile.Margin = new Padding(4, 3, 4, 3);
			buttonSaveSHA384StringToFile.Name = "buttonSaveSHA384StringToFile";
			buttonSaveSHA384StringToFile.Size = new Size(28, 28);
			buttonSaveSHA384StringToFile.TabIndex = 23;
			buttonSaveSHA384StringToFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveSHA384StringToFile, "Save the SHA384 hash value in a file");
			buttonSaveSHA384StringToFile.UseVisualStyleBackColor = true;
			buttonSaveSHA384StringToFile.Click += ButtonSaveSHA384StringToFile_Click;
			buttonSaveSHA384StringToFile.Enter += SetStatusbar_Enter;
			buttonSaveSHA384StringToFile.Leave += ClearStatusbar_Leave;
			buttonSaveSHA384StringToFile.MouseEnter += SetStatusbar_Enter;
			buttonSaveSHA384StringToFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveSHA256StringToFile
			// 
			buttonSaveSHA256StringToFile.AccessibleDescription = "Save the SHA1 hash value in a file";
			buttonSaveSHA256StringToFile.AccessibleName = "Save SHA1 hash to file";
			buttonSaveSHA256StringToFile.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveSHA256StringToFile.AutoEllipsis = true;
			buttonSaveSHA256StringToFile.Image = (Image)resources.GetObject("buttonSaveSHA256StringToFile.Image");
			buttonSaveSHA256StringToFile.Location = new Point(552, 109);
			buttonSaveSHA256StringToFile.Margin = new Padding(4, 3, 4, 3);
			buttonSaveSHA256StringToFile.Name = "buttonSaveSHA256StringToFile";
			buttonSaveSHA256StringToFile.Size = new Size(28, 28);
			buttonSaveSHA256StringToFile.TabIndex = 19;
			buttonSaveSHA256StringToFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveSHA256StringToFile, "Save the SHA256 hash value in a file");
			buttonSaveSHA256StringToFile.UseVisualStyleBackColor = true;
			buttonSaveSHA256StringToFile.Click += ButtonSaveSHA256StringToFile_Click;
			buttonSaveSHA256StringToFile.Enter += SetStatusbar_Enter;
			buttonSaveSHA256StringToFile.Leave += ClearStatusbar_Leave;
			buttonSaveSHA256StringToFile.MouseEnter += SetStatusbar_Enter;
			buttonSaveSHA256StringToFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveSHA1StringToFile
			// 
			buttonSaveSHA1StringToFile.AccessibleDescription = "Save the SHA1 hash value in a file";
			buttonSaveSHA1StringToFile.AccessibleName = "Save SHA1 hash to file";
			buttonSaveSHA1StringToFile.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveSHA1StringToFile.AutoEllipsis = true;
			buttonSaveSHA1StringToFile.Image = (Image)resources.GetObject("buttonSaveSHA1StringToFile.Image");
			buttonSaveSHA1StringToFile.Location = new Point(552, 75);
			buttonSaveSHA1StringToFile.Margin = new Padding(4, 3, 4, 3);
			buttonSaveSHA1StringToFile.Name = "buttonSaveSHA1StringToFile";
			buttonSaveSHA1StringToFile.Size = new Size(28, 28);
			buttonSaveSHA1StringToFile.TabIndex = 15;
			buttonSaveSHA1StringToFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveSHA1StringToFile, "Save the SHA1 hash value in a file");
			buttonSaveSHA1StringToFile.UseVisualStyleBackColor = true;
			buttonSaveSHA1StringToFile.Click += ButtonSaveSHA1StringToFile_Click;
			buttonSaveSHA1StringToFile.Enter += SetStatusbar_Enter;
			buttonSaveSHA1StringToFile.Leave += ClearStatusbar_Leave;
			buttonSaveSHA1StringToFile.MouseEnter += SetStatusbar_Enter;
			buttonSaveSHA1StringToFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveMD5StringToFile
			// 
			buttonSaveMD5StringToFile.AccessibleDescription = "Save the MD5 hash value in a file";
			buttonSaveMD5StringToFile.AccessibleName = "Save MD5 hash to file";
			buttonSaveMD5StringToFile.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveMD5StringToFile.AutoEllipsis = true;
			buttonSaveMD5StringToFile.Image = (Image)resources.GetObject("buttonSaveMD5StringToFile.Image");
			buttonSaveMD5StringToFile.Location = new Point(552, 41);
			buttonSaveMD5StringToFile.Margin = new Padding(4, 3, 4, 3);
			buttonSaveMD5StringToFile.Name = "buttonSaveMD5StringToFile";
			buttonSaveMD5StringToFile.Size = new Size(28, 28);
			buttonSaveMD5StringToFile.TabIndex = 7;
			buttonSaveMD5StringToFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveMD5StringToFile, "Save the MD5 hash value in a file");
			buttonSaveMD5StringToFile.UseVisualStyleBackColor = true;
			buttonSaveMD5StringToFile.Click += ButtonSaveMD5StringToFile_Click;
			buttonSaveMD5StringToFile.Enter += SetStatusbar_Enter;
			buttonSaveMD5StringToFile.Leave += ClearStatusbar_Leave;
			buttonSaveMD5StringToFile.MouseEnter += SetStatusbar_Enter;
			buttonSaveMD5StringToFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA512StringFromFileToClipboard
			// 
			buttonCopySHA512StringFromFileToClipboard.AccessibleDescription = "Copy the SHA512 hash value to the clipboard";
			buttonCopySHA512StringFromFileToClipboard.AccessibleName = "Copy SHA512 hash value to clipboard";
			buttonCopySHA512StringFromFileToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA512StringFromFileToClipboard.AutoEllipsis = true;
			buttonCopySHA512StringFromFileToClipboard.Image = (Image)resources.GetObject("buttonCopySHA512StringFromFileToClipboard.Image");
			buttonCopySHA512StringFromFileToClipboard.Location = new Point(517, 177);
			buttonCopySHA512StringFromFileToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA512StringFromFileToClipboard.Name = "buttonCopySHA512StringFromFileToClipboard";
			buttonCopySHA512StringFromFileToClipboard.Size = new Size(28, 28);
			buttonCopySHA512StringFromFileToClipboard.TabIndex = 26;
			buttonCopySHA512StringFromFileToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA512StringFromFileToClipboard, "Copy the SHA512 hash value to the clipboard");
			buttonCopySHA512StringFromFileToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA512StringFromFileToClipboard.Click += ButtonCopySHA512StringFromFileToClipboard_Click;
			buttonCopySHA512StringFromFileToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA512StringFromFileToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA512StringFromFileToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA512StringFromFileToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA384StringFromFileToClipboard
			// 
			buttonCopySHA384StringFromFileToClipboard.AccessibleDescription = "Copy the SHA384 hash value to the clipboard";
			buttonCopySHA384StringFromFileToClipboard.AccessibleName = "Copy SHA384 hash value to clipboard";
			buttonCopySHA384StringFromFileToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA384StringFromFileToClipboard.AutoEllipsis = true;
			buttonCopySHA384StringFromFileToClipboard.Image = (Image)resources.GetObject("buttonCopySHA384StringFromFileToClipboard.Image");
			buttonCopySHA384StringFromFileToClipboard.Location = new Point(517, 143);
			buttonCopySHA384StringFromFileToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA384StringFromFileToClipboard.Name = "buttonCopySHA384StringFromFileToClipboard";
			buttonCopySHA384StringFromFileToClipboard.Size = new Size(28, 28);
			buttonCopySHA384StringFromFileToClipboard.TabIndex = 22;
			buttonCopySHA384StringFromFileToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA384StringFromFileToClipboard, "Copy the SHA384 hash value to the clipboard");
			buttonCopySHA384StringFromFileToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA384StringFromFileToClipboard.Click += ButtonCopySHA384StringFromFileToClipboard_Click;
			buttonCopySHA384StringFromFileToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA384StringFromFileToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA384StringFromFileToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA384StringFromFileToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA256StringFromFileToClipboard
			// 
			buttonCopySHA256StringFromFileToClipboard.AccessibleDescription = "Copy the SHA256 hash value to the clipboard";
			buttonCopySHA256StringFromFileToClipboard.AccessibleName = "Copy SHA256 hash value to clipboard";
			buttonCopySHA256StringFromFileToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA256StringFromFileToClipboard.AutoEllipsis = true;
			buttonCopySHA256StringFromFileToClipboard.Image = (Image)resources.GetObject("buttonCopySHA256StringFromFileToClipboard.Image");
			buttonCopySHA256StringFromFileToClipboard.Location = new Point(517, 109);
			buttonCopySHA256StringFromFileToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA256StringFromFileToClipboard.Name = "buttonCopySHA256StringFromFileToClipboard";
			buttonCopySHA256StringFromFileToClipboard.Size = new Size(28, 28);
			buttonCopySHA256StringFromFileToClipboard.TabIndex = 18;
			buttonCopySHA256StringFromFileToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA256StringFromFileToClipboard, "Copy the SHA256 hash value to the clipboard");
			buttonCopySHA256StringFromFileToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA256StringFromFileToClipboard.Click += ButtonCopySHA256StringFromFileToClipboard_Click;
			buttonCopySHA256StringFromFileToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA256StringFromFileToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA256StringFromFileToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA256StringFromFileToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA1StringFromFileToClipboard
			// 
			buttonCopySHA1StringFromFileToClipboard.AccessibleDescription = "Copy the SHA1 hash value to the clipboard";
			buttonCopySHA1StringFromFileToClipboard.AccessibleName = "Copy SHA1 hash value to clipboard";
			buttonCopySHA1StringFromFileToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA1StringFromFileToClipboard.AutoEllipsis = true;
			buttonCopySHA1StringFromFileToClipboard.Image = (Image)resources.GetObject("buttonCopySHA1StringFromFileToClipboard.Image");
			buttonCopySHA1StringFromFileToClipboard.Location = new Point(516, 75);
			buttonCopySHA1StringFromFileToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA1StringFromFileToClipboard.Name = "buttonCopySHA1StringFromFileToClipboard";
			buttonCopySHA1StringFromFileToClipboard.Size = new Size(28, 28);
			buttonCopySHA1StringFromFileToClipboard.TabIndex = 14;
			buttonCopySHA1StringFromFileToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA1StringFromFileToClipboard, "Copy the SHA1 hash value to the clipboard");
			buttonCopySHA1StringFromFileToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA1StringFromFileToClipboard.Click += ButtonCopySHA1StringFromFileToClipboard_Click;
			buttonCopySHA1StringFromFileToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA1StringFromFileToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA1StringFromFileToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA1StringFromFileToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopyMD5StringFromFileToClipboard
			// 
			buttonCopyMD5StringFromFileToClipboard.AccessibleDescription = "Copy the MD5 hash value to the clipboard";
			buttonCopyMD5StringFromFileToClipboard.AccessibleName = "Copy MD5 hash value to clipboard";
			buttonCopyMD5StringFromFileToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyMD5StringFromFileToClipboard.AutoEllipsis = true;
			buttonCopyMD5StringFromFileToClipboard.Image = (Image)resources.GetObject("buttonCopyMD5StringFromFileToClipboard.Image");
			buttonCopyMD5StringFromFileToClipboard.Location = new Point(516, 41);
			buttonCopyMD5StringFromFileToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopyMD5StringFromFileToClipboard.Name = "buttonCopyMD5StringFromFileToClipboard";
			buttonCopyMD5StringFromFileToClipboard.Size = new Size(28, 28);
			buttonCopyMD5StringFromFileToClipboard.TabIndex = 6;
			buttonCopyMD5StringFromFileToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopyMD5StringFromFileToClipboard, "Copy the MD5 hash value to the clipboard");
			buttonCopyMD5StringFromFileToClipboard.UseVisualStyleBackColor = true;
			buttonCopyMD5StringFromFileToClipboard.Click += ButtonCopyMD5StringFromFileToClipboard_Click;
			buttonCopyMD5StringFromFileToClipboard.Enter += SetStatusbar_Enter;
			buttonCopyMD5StringFromFileToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopyMD5StringFromFileToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopyMD5StringFromFileToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonOpenAndCalculateHashFromFile
			// 
			buttonOpenAndCalculateHashFromFile.AccessibleDescription = "Open a file and calculate the hash values";
			buttonOpenAndCalculateHashFromFile.AccessibleName = "Open and calculate hash values from file";
			buttonOpenAndCalculateHashFromFile.AccessibleRole = AccessibleRole.PushButton;
			buttonOpenAndCalculateHashFromFile.AutoEllipsis = true;
			buttonOpenAndCalculateHashFromFile.Image = Properties.Resources.fatcow_document_hash_tag_16;
			buttonOpenAndCalculateHashFromFile.ImageAlign = ContentAlignment.MiddleLeft;
			buttonOpenAndCalculateHashFromFile.Location = new Point(455, 7);
			buttonOpenAndCalculateHashFromFile.Margin = new Padding(4, 3, 4, 3);
			buttonOpenAndCalculateHashFromFile.Name = "buttonOpenAndCalculateHashFromFile";
			buttonOpenAndCalculateHashFromFile.Size = new Size(125, 28);
			buttonOpenAndCalculateHashFromFile.TabIndex = 2;
			buttonOpenAndCalculateHashFromFile.Text = "Open && Calculate";
			buttonOpenAndCalculateHashFromFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonOpenAndCalculateHashFromFile, "Open a file and calculate the hash value");
			buttonOpenAndCalculateHashFromFile.UseVisualStyleBackColor = true;
			buttonOpenAndCalculateHashFromFile.Click += ButtonOpenAndCalculateFile_Click;
			buttonOpenAndCalculateHashFromFile.Enter += SetStatusbar_Enter;
			buttonOpenAndCalculateHashFromFile.Leave += ClearStatusbar_Leave;
			buttonOpenAndCalculateHashFromFile.MouseEnter += SetStatusbar_Enter;
			buttonOpenAndCalculateHashFromFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabControl
			// 
			tabControl.AccessibleDescription = "Just a tab control";
			tabControl.AccessibleName = "tab control";
			tabControl.AccessibleRole = AccessibleRole.Pane;
			tabControl.AllowDrop = true;
			tabControl.Controls.Add(tabPageFile);
			tabControl.Controls.Add(tabPageText);
			tabControl.Controls.Add(tabPageInfo);
			tabControl.Controls.Add(tabPageLicense);
			tabControl.Dock = DockStyle.Fill;
			tabControl.HotTrack = true;
			tabControl.ImageList = imageListTab;
			tabControl.Location = new Point(0, 0);
			tabControl.Margin = new Padding(4, 3, 4, 3);
			tabControl.Name = "tabControl";
			tabControl.SelectedIndex = 0;
			tabControl.ShowToolTips = true;
			tabControl.Size = new Size(596, 360);
			tabControl.TabIndex = 0;
			tabControl.DragDrop += MainForm_DragDrop;
			tabControl.DragEnter += MainForm_DragEnter;
			// 
			// tabPageFile
			// 
			tabPageFile.AccessibleDescription = "Show the file tab page";
			tabPageFile.AccessibleName = "file tab page";
			tabPageFile.AccessibleRole = AccessibleRole.PageTab;
			tabPageFile.Controls.Add(buttonbuttonSaveCrc32StringToFile);
			tabPageFile.Controls.Add(buttonCopyCrc32StringFromFileToClipboard);
			tabPageFile.Controls.Add(textBoxCrc32StringFromFile);
			tabPageFile.Controls.Add(labelCrc32StringFromFile);
			tabPageFile.Controls.Add(buttonSaveAllHashValuesInList);
			tabPageFile.Controls.Add(buttonSaveAllHashValuesAutomatically);
			tabPageFile.Controls.Add(labelFileName);
			tabPageFile.Controls.Add(textBoxFileName);
			tabPageFile.Controls.Add(buttonSaveSHA512StringToFile);
			tabPageFile.Controls.Add(buttonOpenAndCalculateHashFromFile);
			tabPageFile.Controls.Add(buttonSaveSHA384StringToFile);
			tabPageFile.Controls.Add(labelMD5StringFromFile);
			tabPageFile.Controls.Add(buttonSaveSHA256StringToFile);
			tabPageFile.Controls.Add(textBoxMD5StringFromFile);
			tabPageFile.Controls.Add(buttonSaveSHA1StringToFile);
			tabPageFile.Controls.Add(buttonCopyMD5StringFromFileToClipboard);
			tabPageFile.Controls.Add(buttonSaveMD5StringToFile);
			tabPageFile.Controls.Add(buttonCopySHA512StringFromFileToClipboard);
			tabPageFile.Controls.Add(textBoxSHA512StringFromFile);
			tabPageFile.Controls.Add(labelSHA1StringFromFile);
			tabPageFile.Controls.Add(labelSHA512StringFromFile);
			tabPageFile.Controls.Add(textBoxSHA1StringFromFile);
			tabPageFile.Controls.Add(buttonCopySHA384StringFromFileToClipboard);
			tabPageFile.Controls.Add(buttonCopySHA1StringFromFileToClipboard);
			tabPageFile.Controls.Add(textBoxSHA384StringFromFile);
			tabPageFile.Controls.Add(labelSHA256StringFromFile);
			tabPageFile.Controls.Add(labelSHA384FromFile);
			tabPageFile.Controls.Add(textBoxSHA256StringFromFile);
			tabPageFile.Controls.Add(buttonCopySHA256StringFromFileToClipboard);
			tabPageFile.ImageKey = "fatcow_page_16.png";
			tabPageFile.Location = new Point(4, 24);
			tabPageFile.Margin = new Padding(4, 3, 4, 3);
			tabPageFile.Name = "tabPageFile";
			tabPageFile.Padding = new Padding(4, 3, 4, 3);
			tabPageFile.Size = new Size(588, 332);
			tabPageFile.TabIndex = 0;
			tabPageFile.Text = "File";
			toolTip.SetToolTip(tabPageFile, "Hash a file");
			tabPageFile.ToolTipText = "Hash a file";
			tabPageFile.UseVisualStyleBackColor = true;
			tabPageFile.Enter += SetStatusbar_Enter;
			tabPageFile.Leave += ClearStatusbar_Leave;
			tabPageFile.MouseEnter += SetStatusbar_Enter;
			tabPageFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveAllHashValuesInList
			// 
			buttonSaveAllHashValuesInList.AccessibleDescription = "Save all hash values in a list";
			buttonSaveAllHashValuesInList.AccessibleName = "Save all in a list";
			buttonSaveAllHashValuesInList.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveAllHashValuesInList.AutoEllipsis = true;
			buttonSaveAllHashValuesInList.Image = Properties.Resources.fatcow_page_save_16;
			buttonSaveAllHashValuesInList.ImageAlign = ContentAlignment.MiddleLeft;
			buttonSaveAllHashValuesInList.Location = new Point(470, 211);
			buttonSaveAllHashValuesInList.Margin = new Padding(4, 3, 4, 3);
			buttonSaveAllHashValuesInList.Name = "buttonSaveAllHashValuesInList";
			buttonSaveAllHashValuesInList.Size = new Size(110, 27);
			buttonSaveAllHashValuesInList.TabIndex = 29;
			buttonSaveAllHashValuesInList.Text = "Save all in a list";
			buttonSaveAllHashValuesInList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveAllHashValuesInList, "Save all in a list");
			buttonSaveAllHashValuesInList.UseVisualStyleBackColor = true;
			buttonSaveAllHashValuesInList.Click += ButtonSaveAllHashValuesInList_Click;
			buttonSaveAllHashValuesInList.Enter += SetStatusbar_Enter;
			buttonSaveAllHashValuesInList.Leave += ClearStatusbar_Leave;
			buttonSaveAllHashValuesInList.MouseEnter += SetStatusbar_Enter;
			buttonSaveAllHashValuesInList.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveAllHashValuesAutomatically
			// 
			buttonSaveAllHashValuesAutomatically.AccessibleDescription = "Save all hash values automatically in separate files";
			buttonSaveAllHashValuesAutomatically.AccessibleName = "Save all automatically";
			buttonSaveAllHashValuesAutomatically.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveAllHashValuesAutomatically.AutoEllipsis = true;
			buttonSaveAllHashValuesAutomatically.Image = Properties.Resources.fatcow_diskette_16;
			buttonSaveAllHashValuesAutomatically.ImageAlign = ContentAlignment.MiddleLeft;
			buttonSaveAllHashValuesAutomatically.Location = new Point(317, 211);
			buttonSaveAllHashValuesAutomatically.Margin = new Padding(4, 3, 4, 3);
			buttonSaveAllHashValuesAutomatically.Name = "buttonSaveAllHashValuesAutomatically";
			buttonSaveAllHashValuesAutomatically.Size = new Size(145, 27);
			buttonSaveAllHashValuesAutomatically.TabIndex = 28;
			buttonSaveAllHashValuesAutomatically.Text = "Save all automatically";
			buttonSaveAllHashValuesAutomatically.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveAllHashValuesAutomatically, "Save all automatically");
			buttonSaveAllHashValuesAutomatically.UseVisualStyleBackColor = true;
			buttonSaveAllHashValuesAutomatically.Click += ButtonSaveAllHashValuesAutomatically_Click;
			buttonSaveAllHashValuesAutomatically.Enter += SetStatusbar_Enter;
			buttonSaveAllHashValuesAutomatically.Leave += ClearStatusbar_Leave;
			buttonSaveAllHashValuesAutomatically.MouseEnter += SetStatusbar_Enter;
			buttonSaveAllHashValuesAutomatically.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabPageText
			// 
			tabPageText.AccessibleDescription = "Show the text tab page";
			tabPageText.AccessibleName = "text tab page";
			tabPageText.AccessibleRole = AccessibleRole.PageTab;
			tabPageText.Controls.Add(buttonInsertTextFromClipboard);
			tabPageText.Controls.Add(buttonSaveAllHashValuesInClipboard);
			tabPageText.Controls.Add(checkBoxAutoUpdateText);
			tabPageText.Controls.Add(labelText);
			tabPageText.Controls.Add(textBoxText);
			tabPageText.Controls.Add(buttonCalculateHashFromText);
			tabPageText.Controls.Add(labelMD5StringFromText);
			tabPageText.Controls.Add(textBoxMD5StringFromText);
			tabPageText.Controls.Add(buttonCopyMD5StringFromTextToClipboard);
			tabPageText.Controls.Add(buttonCopySHA512StringFromTextToClipboard);
			tabPageText.Controls.Add(textBoxSHA512StringFromText);
			tabPageText.Controls.Add(labelSHA1StringFromText);
			tabPageText.Controls.Add(labelSHA512StringFromText);
			tabPageText.Controls.Add(textBoxSHA1StringFromText);
			tabPageText.Controls.Add(buttonCopySHA384StringFromTextToClipboard);
			tabPageText.Controls.Add(buttonCopySHA1StringFromTextToClipboard);
			tabPageText.Controls.Add(textBoxSHA384StringFromText);
			tabPageText.Controls.Add(labelSHA256StringFromText);
			tabPageText.Controls.Add(labelSHA384StringFromText);
			tabPageText.Controls.Add(textBoxSHA256StringFromText);
			tabPageText.Controls.Add(buttonCopySHA256StringFromTextToClipboard);
			tabPageText.ImageKey = "fatcow_text_effects_16.png";
			tabPageText.Location = new Point(4, 24);
			tabPageText.Margin = new Padding(4, 3, 4, 3);
			tabPageText.Name = "tabPageText";
			tabPageText.Padding = new Padding(4, 3, 4, 3);
			tabPageText.Size = new Size(588, 248);
			tabPageText.TabIndex = 1;
			tabPageText.Text = "Text";
			toolTip.SetToolTip(tabPageText, "Hash a text");
			tabPageText.ToolTipText = "Hash a text";
			tabPageText.UseVisualStyleBackColor = true;
			tabPageText.Enter += SetStatusbar_Enter;
			tabPageText.Leave += ClearStatusbar_Leave;
			tabPageText.MouseEnter += SetStatusbar_Enter;
			tabPageText.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonInsertTextFromClipboard
			// 
			buttonInsertTextFromClipboard.AccessibleDescription = "Insert text from clipboard";
			buttonInsertTextFromClipboard.AccessibleName = "buttonInsert text from clipboard";
			buttonInsertTextFromClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonInsertTextFromClipboard.Image = Properties.Resources.fatcow_paste_plain_16;
			buttonInsertTextFromClipboard.ImageAlign = ContentAlignment.MiddleLeft;
			buttonInsertTextFromClipboard.Location = new Point(7, 211);
			buttonInsertTextFromClipboard.Name = "buttonInsertTextFromClipboard";
			buttonInsertTextFromClipboard.Size = new Size(166, 27);
			buttonInsertTextFromClipboard.TabIndex = 32;
			buttonInsertTextFromClipboard.Text = "Insert text from clipboard";
			buttonInsertTextFromClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonInsertTextFromClipboard.UseVisualStyleBackColor = true;
			buttonInsertTextFromClipboard.Click += ButtonInsertTextFromClipboard_Click;
			buttonInsertTextFromClipboard.Enter += SetStatusbar_Enter;
			buttonInsertTextFromClipboard.Leave += ClearStatusbar_Leave;
			buttonInsertTextFromClipboard.MouseEnter += SetStatusbar_Enter;
			buttonInsertTextFromClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveAllHashValuesInClipboard
			// 
			buttonSaveAllHashValuesInClipboard.AccessibleDescription = "Save all hash values into the clipboard";
			buttonSaveAllHashValuesInClipboard.AccessibleName = "Save all in clipboard";
			buttonSaveAllHashValuesInClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveAllHashValuesInClipboard.AutoEllipsis = true;
			buttonSaveAllHashValuesInClipboard.Image = Properties.Resources.fatcow_clipboard_empty_16;
			buttonSaveAllHashValuesInClipboard.ImageAlign = ContentAlignment.MiddleLeft;
			buttonSaveAllHashValuesInClipboard.Location = new Point(444, 211);
			buttonSaveAllHashValuesInClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonSaveAllHashValuesInClipboard.Name = "buttonSaveAllHashValuesInClipboard";
			buttonSaveAllHashValuesInClipboard.Size = new Size(136, 27);
			buttonSaveAllHashValuesInClipboard.TabIndex = 31;
			buttonSaveAllHashValuesInClipboard.Text = "Save all in clipboard";
			buttonSaveAllHashValuesInClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveAllHashValuesInClipboard, "Save all hash values into the clipboard");
			buttonSaveAllHashValuesInClipboard.UseVisualStyleBackColor = true;
			buttonSaveAllHashValuesInClipboard.Click += ButtonSaveAllHashValuesInClipboard_Click;
			buttonSaveAllHashValuesInClipboard.Enter += SetStatusbar_Enter;
			buttonSaveAllHashValuesInClipboard.Leave += ClearStatusbar_Leave;
			buttonSaveAllHashValuesInClipboard.MouseEnter += SetStatusbar_Enter;
			buttonSaveAllHashValuesInClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// checkBoxAutoUpdateText
			// 
			checkBoxAutoUpdateText.AccessibleDescription = "Enable/disable the permanent calculation";
			checkBoxAutoUpdateText.AccessibleName = "Permanent calculation";
			checkBoxAutoUpdateText.AccessibleRole = AccessibleRole.PushButton;
			checkBoxAutoUpdateText.Appearance = Appearance.Button;
			checkBoxAutoUpdateText.AutoSize = true;
			checkBoxAutoUpdateText.Image = Properties.Resources.fatcow_arrow_refresh_small_16;
			checkBoxAutoUpdateText.Location = new Point(552, 10);
			checkBoxAutoUpdateText.Margin = new Padding(4, 3, 4, 3);
			checkBoxAutoUpdateText.Name = "checkBoxAutoUpdateText";
			checkBoxAutoUpdateText.Size = new Size(22, 22);
			checkBoxAutoUpdateText.TabIndex = 3;
			checkBoxAutoUpdateText.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(checkBoxAutoUpdateText, "Enable/disable the permanent calculation");
			checkBoxAutoUpdateText.UseVisualStyleBackColor = true;
			checkBoxAutoUpdateText.CheckedChanged += CheckBoxAutoUpdateText_CheckedChanged;
			checkBoxAutoUpdateText.Enter += SetStatusbar_Enter;
			checkBoxAutoUpdateText.Leave += ClearStatusbar_Leave;
			checkBoxAutoUpdateText.MouseEnter += SetStatusbar_Enter;
			checkBoxAutoUpdateText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelText
			// 
			labelText.AccessibleDescription = "text";
			labelText.AccessibleName = "text";
			labelText.AccessibleRole = AccessibleRole.StaticText;
			labelText.AutoEllipsis = true;
			labelText.AutoSize = true;
			labelText.Location = new Point(8, 14);
			labelText.Margin = new Padding(4, 0, 4, 0);
			labelText.Name = "labelText";
			labelText.Size = new Size(31, 15);
			labelText.TabIndex = 0;
			labelText.Text = "Text:";
			toolTip.SetToolTip(labelText, "text");
			labelText.Enter += SetStatusbar_Enter;
			labelText.Leave += ClearStatusbar_Leave;
			labelText.MouseEnter += SetStatusbar_Enter;
			labelText.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxText
			// 
			textBoxText.AccessibleDescription = "Show the text";
			textBoxText.AccessibleName = "text";
			textBoxText.AccessibleRole = AccessibleRole.Text;
			textBoxText.Location = new Point(51, 10);
			textBoxText.Margin = new Padding(4, 3, 4, 3);
			textBoxText.Name = "textBoxText";
			textBoxText.Size = new Size(401, 23);
			textBoxText.TabIndex = 1;
			toolTip.SetToolTip(textBoxText, "text to hash");
			textBoxText.TextChanged += TextBoxText_TextChanged;
			textBoxText.Enter += SetStatusbar_Enter;
			textBoxText.Leave += ClearStatusbar_Leave;
			textBoxText.MouseEnter += SetStatusbar_Enter;
			textBoxText.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCalculateHashFromText
			// 
			buttonCalculateHashFromText.AccessibleDescription = "Calculate the hash values from a text";
			buttonCalculateHashFromText.AccessibleName = "Calculate hash values from text";
			buttonCalculateHashFromText.AccessibleRole = AccessibleRole.PushButton;
			buttonCalculateHashFromText.AutoEllipsis = true;
			buttonCalculateHashFromText.Image = Properties.Resources.fatcow_document_hash_tag_16;
			buttonCalculateHashFromText.ImageAlign = ContentAlignment.MiddleLeft;
			buttonCalculateHashFromText.Location = new Point(460, 7);
			buttonCalculateHashFromText.Margin = new Padding(4, 3, 4, 3);
			buttonCalculateHashFromText.Name = "buttonCalculateHashFromText";
			buttonCalculateHashFromText.Size = new Size(84, 28);
			buttonCalculateHashFromText.TabIndex = 2;
			buttonCalculateHashFromText.Text = "Calculate";
			buttonCalculateHashFromText.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCalculateHashFromText, "Calculate the hash values from a text");
			buttonCalculateHashFromText.UseVisualStyleBackColor = true;
			buttonCalculateHashFromText.Click += ButtonCalculateHashFromText_Click;
			buttonCalculateHashFromText.Enter += SetStatusbar_Enter;
			buttonCalculateHashFromText.Leave += ClearStatusbar_Leave;
			buttonCalculateHashFromText.MouseEnter += SetStatusbar_Enter;
			buttonCalculateHashFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelMD5StringFromText
			// 
			labelMD5StringFromText.AccessibleDescription = "MD5";
			labelMD5StringFromText.AccessibleName = "MD5";
			labelMD5StringFromText.AccessibleRole = AccessibleRole.StaticText;
			labelMD5StringFromText.AutoEllipsis = true;
			labelMD5StringFromText.AutoSize = true;
			labelMD5StringFromText.Location = new Point(9, 48);
			labelMD5StringFromText.Margin = new Padding(4, 0, 4, 0);
			labelMD5StringFromText.Name = "labelMD5StringFromText";
			labelMD5StringFromText.Size = new Size(35, 15);
			labelMD5StringFromText.TabIndex = 4;
			labelMD5StringFromText.Text = "MD5:";
			toolTip.SetToolTip(labelMD5StringFromText, "MD5 hash");
			labelMD5StringFromText.Enter += SetStatusbar_Enter;
			labelMD5StringFromText.Leave += ClearStatusbar_Leave;
			labelMD5StringFromText.MouseEnter += SetStatusbar_Enter;
			labelMD5StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxMD5StringFromText
			// 
			textBoxMD5StringFromText.AccessibleDescription = "Show the MD5 hash value";
			textBoxMD5StringFromText.AccessibleName = "MD5 hash value";
			textBoxMD5StringFromText.AccessibleRole = AccessibleRole.Text;
			textBoxMD5StringFromText.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxMD5StringFromText.Location = new Point(67, 45);
			textBoxMD5StringFromText.Margin = new Padding(4, 3, 4, 3);
			textBoxMD5StringFromText.Name = "textBoxMD5StringFromText";
			textBoxMD5StringFromText.ReadOnly = true;
			textBoxMD5StringFromText.Size = new Size(477, 20);
			textBoxMD5StringFromText.TabIndex = 5;
			toolTip.SetToolTip(textBoxMD5StringFromText, "MD5 hash value");
			textBoxMD5StringFromText.TextChanged += TextBoxMD5StringFromText_TextChanged;
			textBoxMD5StringFromText.Enter += SetStatusbar_Enter;
			textBoxMD5StringFromText.Leave += ClearStatusbar_Leave;
			textBoxMD5StringFromText.MouseEnter += SetStatusbar_Enter;
			textBoxMD5StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopyMD5StringFromTextToClipboard
			// 
			buttonCopyMD5StringFromTextToClipboard.AccessibleDescription = "Copy the MD5hash value to the clipboard";
			buttonCopyMD5StringFromTextToClipboard.AccessibleName = "Copy MD5 hash value to clipboard";
			buttonCopyMD5StringFromTextToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyMD5StringFromTextToClipboard.AutoEllipsis = true;
			buttonCopyMD5StringFromTextToClipboard.Image = (Image)resources.GetObject("buttonCopyMD5StringFromTextToClipboard.Image");
			buttonCopyMD5StringFromTextToClipboard.Location = new Point(552, 41);
			buttonCopyMD5StringFromTextToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopyMD5StringFromTextToClipboard.Name = "buttonCopyMD5StringFromTextToClipboard";
			buttonCopyMD5StringFromTextToClipboard.Size = new Size(28, 28);
			buttonCopyMD5StringFromTextToClipboard.TabIndex = 6;
			buttonCopyMD5StringFromTextToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopyMD5StringFromTextToClipboard, "Copy the MD5 hash value to the clipboard");
			buttonCopyMD5StringFromTextToClipboard.UseVisualStyleBackColor = true;
			buttonCopyMD5StringFromTextToClipboard.Click += ButtonCopyMD5StringFromTextToClipboard_Click;
			buttonCopyMD5StringFromTextToClipboard.Enter += SetStatusbar_Enter;
			buttonCopyMD5StringFromTextToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopyMD5StringFromTextToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopyMD5StringFromTextToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA512StringFromTextToClipboard
			// 
			buttonCopySHA512StringFromTextToClipboard.AccessibleDescription = "Copy the SHA512 hash value to the clipboard";
			buttonCopySHA512StringFromTextToClipboard.AccessibleName = "Copy SHA512 hash value to clipboard";
			buttonCopySHA512StringFromTextToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA512StringFromTextToClipboard.AutoEllipsis = true;
			buttonCopySHA512StringFromTextToClipboard.Image = (Image)resources.GetObject("buttonCopySHA512StringFromTextToClipboard.Image");
			buttonCopySHA512StringFromTextToClipboard.Location = new Point(552, 177);
			buttonCopySHA512StringFromTextToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA512StringFromTextToClipboard.Name = "buttonCopySHA512StringFromTextToClipboard";
			buttonCopySHA512StringFromTextToClipboard.Size = new Size(28, 28);
			buttonCopySHA512StringFromTextToClipboard.TabIndex = 21;
			buttonCopySHA512StringFromTextToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA512StringFromTextToClipboard, "Copy the SHA512 hash value to the clipboard");
			buttonCopySHA512StringFromTextToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA512StringFromTextToClipboard.Click += ButtonCopySHA512StringFromTextToClipboard_Click;
			buttonCopySHA512StringFromTextToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA512StringFromTextToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA512StringFromTextToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA512StringFromTextToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSHA512StringFromText
			// 
			textBoxSHA512StringFromText.AccessibleDescription = "Show the SHA512 hash value";
			textBoxSHA512StringFromText.AccessibleName = "SHA512 hash value";
			textBoxSHA512StringFromText.AccessibleRole = AccessibleRole.Text;
			textBoxSHA512StringFromText.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA512StringFromText.Location = new Point(67, 181);
			textBoxSHA512StringFromText.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA512StringFromText.Name = "textBoxSHA512StringFromText";
			textBoxSHA512StringFromText.ReadOnly = true;
			textBoxSHA512StringFromText.Size = new Size(476, 20);
			textBoxSHA512StringFromText.TabIndex = 20;
			toolTip.SetToolTip(textBoxSHA512StringFromText, "SHA512 hash value");
			textBoxSHA512StringFromText.TextChanged += TextBoxSHA512StringFromText_TextChanged;
			textBoxSHA512StringFromText.Enter += SetStatusbar_Enter;
			textBoxSHA512StringFromText.Leave += ClearStatusbar_Leave;
			textBoxSHA512StringFromText.MouseEnter += SetStatusbar_Enter;
			textBoxSHA512StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA1StringFromText
			// 
			labelSHA1StringFromText.AccessibleDescription = "SHA1";
			labelSHA1StringFromText.AccessibleName = "SHA1";
			labelSHA1StringFromText.AccessibleRole = AccessibleRole.StaticText;
			labelSHA1StringFromText.AutoEllipsis = true;
			labelSHA1StringFromText.AutoSize = true;
			labelSHA1StringFromText.Location = new Point(9, 82);
			labelSHA1StringFromText.Margin = new Padding(4, 0, 4, 0);
			labelSHA1StringFromText.Name = "labelSHA1StringFromText";
			labelSHA1StringFromText.Size = new Size(39, 15);
			labelSHA1StringFromText.TabIndex = 10;
			labelSHA1StringFromText.Text = "SHA1:";
			toolTip.SetToolTip(labelSHA1StringFromText, "SHA1 hash");
			labelSHA1StringFromText.Enter += SetStatusbar_Enter;
			labelSHA1StringFromText.Leave += ClearStatusbar_Leave;
			labelSHA1StringFromText.MouseEnter += SetStatusbar_Enter;
			labelSHA1StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA512StringFromText
			// 
			labelSHA512StringFromText.AccessibleDescription = "SHA512";
			labelSHA512StringFromText.AccessibleName = "SHA512";
			labelSHA512StringFromText.AccessibleRole = AccessibleRole.StaticText;
			labelSHA512StringFromText.AutoEllipsis = true;
			labelSHA512StringFromText.AutoSize = true;
			labelSHA512StringFromText.Location = new Point(8, 184);
			labelSHA512StringFromText.Margin = new Padding(4, 0, 4, 0);
			labelSHA512StringFromText.Name = "labelSHA512StringFromText";
			labelSHA512StringFromText.Size = new Size(51, 15);
			labelSHA512StringFromText.TabIndex = 19;
			labelSHA512StringFromText.Text = "SHA512:";
			toolTip.SetToolTip(labelSHA512StringFromText, "SHA512 hash");
			labelSHA512StringFromText.Enter += SetStatusbar_Enter;
			labelSHA512StringFromText.Leave += ClearStatusbar_Leave;
			labelSHA512StringFromText.MouseEnter += SetStatusbar_Enter;
			labelSHA512StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSHA1StringFromText
			// 
			textBoxSHA1StringFromText.AccessibleDescription = "Show the SHA1 hash value";
			textBoxSHA1StringFromText.AccessibleName = "SHA1 hash value";
			textBoxSHA1StringFromText.AccessibleRole = AccessibleRole.Text;
			textBoxSHA1StringFromText.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA1StringFromText.Location = new Point(67, 79);
			textBoxSHA1StringFromText.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA1StringFromText.Name = "textBoxSHA1StringFromText";
			textBoxSHA1StringFromText.ReadOnly = true;
			textBoxSHA1StringFromText.Size = new Size(477, 20);
			textBoxSHA1StringFromText.TabIndex = 11;
			toolTip.SetToolTip(textBoxSHA1StringFromText, "SHA1 hash value");
			textBoxSHA1StringFromText.TextChanged += TextBoxSHA1StringFromText_TextChanged;
			textBoxSHA1StringFromText.Enter += SetStatusbar_Enter;
			textBoxSHA1StringFromText.Leave += ClearStatusbar_Leave;
			textBoxSHA1StringFromText.MouseEnter += SetStatusbar_Enter;
			textBoxSHA1StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA384StringFromTextToClipboard
			// 
			buttonCopySHA384StringFromTextToClipboard.AccessibleDescription = "Copy the SHA384 hash value to the clipboard";
			buttonCopySHA384StringFromTextToClipboard.AccessibleName = "Copy SHA384 hash value to clipboard";
			buttonCopySHA384StringFromTextToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA384StringFromTextToClipboard.AutoEllipsis = true;
			buttonCopySHA384StringFromTextToClipboard.Image = (Image)resources.GetObject("buttonCopySHA384StringFromTextToClipboard.Image");
			buttonCopySHA384StringFromTextToClipboard.Location = new Point(552, 143);
			buttonCopySHA384StringFromTextToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA384StringFromTextToClipboard.Name = "buttonCopySHA384StringFromTextToClipboard";
			buttonCopySHA384StringFromTextToClipboard.Size = new Size(28, 28);
			buttonCopySHA384StringFromTextToClipboard.TabIndex = 18;
			buttonCopySHA384StringFromTextToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA384StringFromTextToClipboard, "Copy the SHA384 hash value to the clipboard");
			buttonCopySHA384StringFromTextToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA384StringFromTextToClipboard.Click += ButtonCopySHA384StringFromTextToClipboard_Click;
			buttonCopySHA384StringFromTextToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA384StringFromTextToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA384StringFromTextToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA384StringFromTextToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA1StringFromTextToClipboard
			// 
			buttonCopySHA1StringFromTextToClipboard.AccessibleDescription = "Copy the SHA1 hash value to the clipboard";
			buttonCopySHA1StringFromTextToClipboard.AccessibleName = "Copy SHA1 hash value to clipboard";
			buttonCopySHA1StringFromTextToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA1StringFromTextToClipboard.AutoEllipsis = true;
			buttonCopySHA1StringFromTextToClipboard.Image = (Image)resources.GetObject("buttonCopySHA1StringFromTextToClipboard.Image");
			buttonCopySHA1StringFromTextToClipboard.Location = new Point(552, 75);
			buttonCopySHA1StringFromTextToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA1StringFromTextToClipboard.Name = "buttonCopySHA1StringFromTextToClipboard";
			buttonCopySHA1StringFromTextToClipboard.Size = new Size(28, 28);
			buttonCopySHA1StringFromTextToClipboard.TabIndex = 12;
			buttonCopySHA1StringFromTextToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA1StringFromTextToClipboard, "Copy the SHA1 hash value to the clipboard");
			buttonCopySHA1StringFromTextToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA1StringFromTextToClipboard.Click += ButtonCopySHA1StringFromTextToClipboard_Click;
			buttonCopySHA1StringFromTextToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA1StringFromTextToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA1StringFromTextToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA1StringFromTextToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSHA384StringFromText
			// 
			textBoxSHA384StringFromText.AccessibleDescription = "Show the SHA384 hash value";
			textBoxSHA384StringFromText.AccessibleName = "SHA384 hash value";
			textBoxSHA384StringFromText.AccessibleRole = AccessibleRole.Text;
			textBoxSHA384StringFromText.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA384StringFromText.Location = new Point(67, 147);
			textBoxSHA384StringFromText.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA384StringFromText.Name = "textBoxSHA384StringFromText";
			textBoxSHA384StringFromText.ReadOnly = true;
			textBoxSHA384StringFromText.Size = new Size(477, 20);
			textBoxSHA384StringFromText.TabIndex = 17;
			toolTip.SetToolTip(textBoxSHA384StringFromText, "SHA384 hash value");
			textBoxSHA384StringFromText.TextChanged += TextBoxSHA384StringFromText_TextChanged;
			textBoxSHA384StringFromText.Enter += SetStatusbar_Enter;
			textBoxSHA384StringFromText.Leave += ClearStatusbar_Leave;
			textBoxSHA384StringFromText.MouseEnter += SetStatusbar_Enter;
			textBoxSHA384StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA256StringFromText
			// 
			labelSHA256StringFromText.AccessibleDescription = "SHA256";
			labelSHA256StringFromText.AccessibleName = "SHA256";
			labelSHA256StringFromText.AccessibleRole = AccessibleRole.StaticText;
			labelSHA256StringFromText.AutoEllipsis = true;
			labelSHA256StringFromText.AutoSize = true;
			labelSHA256StringFromText.Location = new Point(9, 116);
			labelSHA256StringFromText.Margin = new Padding(4, 0, 4, 0);
			labelSHA256StringFromText.Name = "labelSHA256StringFromText";
			labelSHA256StringFromText.Size = new Size(51, 15);
			labelSHA256StringFromText.TabIndex = 13;
			labelSHA256StringFromText.Text = "SHA256:";
			toolTip.SetToolTip(labelSHA256StringFromText, "SHA256 hash");
			labelSHA256StringFromText.Enter += SetStatusbar_Enter;
			labelSHA256StringFromText.Leave += ClearStatusbar_Leave;
			labelSHA256StringFromText.MouseEnter += SetStatusbar_Enter;
			labelSHA256StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelSHA384StringFromText
			// 
			labelSHA384StringFromText.AccessibleDescription = "SHA384";
			labelSHA384StringFromText.AccessibleName = "SHA384";
			labelSHA384StringFromText.AccessibleRole = AccessibleRole.StaticText;
			labelSHA384StringFromText.AutoEllipsis = true;
			labelSHA384StringFromText.AutoSize = true;
			labelSHA384StringFromText.Location = new Point(9, 150);
			labelSHA384StringFromText.Margin = new Padding(4, 0, 4, 0);
			labelSHA384StringFromText.Name = "labelSHA384StringFromText";
			labelSHA384StringFromText.Size = new Size(51, 15);
			labelSHA384StringFromText.TabIndex = 16;
			labelSHA384StringFromText.Text = "SHA384:";
			toolTip.SetToolTip(labelSHA384StringFromText, "SHA384 hash");
			labelSHA384StringFromText.Enter += SetStatusbar_Enter;
			labelSHA384StringFromText.Leave += ClearStatusbar_Leave;
			labelSHA384StringFromText.MouseEnter += SetStatusbar_Enter;
			labelSHA384StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxSHA256StringFromText
			// 
			textBoxSHA256StringFromText.AccessibleDescription = "Show the SHA256 hash value";
			textBoxSHA256StringFromText.AccessibleName = "SHA256 hash value";
			textBoxSHA256StringFromText.AccessibleRole = AccessibleRole.Text;
			textBoxSHA256StringFromText.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxSHA256StringFromText.Location = new Point(67, 113);
			textBoxSHA256StringFromText.Margin = new Padding(4, 3, 4, 3);
			textBoxSHA256StringFromText.Name = "textBoxSHA256StringFromText";
			textBoxSHA256StringFromText.ReadOnly = true;
			textBoxSHA256StringFromText.Size = new Size(477, 20);
			textBoxSHA256StringFromText.TabIndex = 14;
			toolTip.SetToolTip(textBoxSHA256StringFromText, "SHA256 hash value");
			textBoxSHA256StringFromText.TextChanged += TextBoxSHA256StringFromText_TextChanged;
			textBoxSHA256StringFromText.Enter += SetStatusbar_Enter;
			textBoxSHA256StringFromText.Leave += ClearStatusbar_Leave;
			textBoxSHA256StringFromText.MouseEnter += SetStatusbar_Enter;
			textBoxSHA256StringFromText.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopySHA256StringFromTextToClipboard
			// 
			buttonCopySHA256StringFromTextToClipboard.AccessibleDescription = "Copy the SHA256 hash value to the clipboard";
			buttonCopySHA256StringFromTextToClipboard.AccessibleName = "Copy SHA256 hash value to clipboard";
			buttonCopySHA256StringFromTextToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopySHA256StringFromTextToClipboard.AutoEllipsis = true;
			buttonCopySHA256StringFromTextToClipboard.Image = (Image)resources.GetObject("buttonCopySHA256StringFromTextToClipboard.Image");
			buttonCopySHA256StringFromTextToClipboard.Location = new Point(552, 109);
			buttonCopySHA256StringFromTextToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopySHA256StringFromTextToClipboard.Name = "buttonCopySHA256StringFromTextToClipboard";
			buttonCopySHA256StringFromTextToClipboard.Size = new Size(28, 28);
			buttonCopySHA256StringFromTextToClipboard.TabIndex = 15;
			buttonCopySHA256StringFromTextToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopySHA256StringFromTextToClipboard, "Copy the SHA256 hash value to the clipboard");
			buttonCopySHA256StringFromTextToClipboard.UseVisualStyleBackColor = true;
			buttonCopySHA256StringFromTextToClipboard.Click += ButtonCopySHA256StringFromTextToClipboard_Click;
			buttonCopySHA256StringFromTextToClipboard.Enter += SetStatusbar_Enter;
			buttonCopySHA256StringFromTextToClipboard.Leave += ClearStatusbar_Leave;
			buttonCopySHA256StringFromTextToClipboard.MouseEnter += SetStatusbar_Enter;
			buttonCopySHA256StringFromTextToClipboard.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabPageInfo
			// 
			tabPageInfo.AccessibleDescription = "Show the info tab page";
			tabPageInfo.AccessibleName = "info tabe page";
			tabPageInfo.AccessibleRole = AccessibleRole.PageTab;
			tabPageInfo.Controls.Add(buttonSelfTest);
			tabPageInfo.Controls.Add(linkLabelUrl);
			tabPageInfo.Controls.Add(textBoxDescription);
			tabPageInfo.Controls.Add(labelCompanyName);
			tabPageInfo.Controls.Add(labelCopyright);
			tabPageInfo.Controls.Add(labelVersion);
			tabPageInfo.Controls.Add(labelProductName);
			tabPageInfo.Controls.Add(logoPictureBox);
			tabPageInfo.ImageKey = "fatcow_infomation_16.png";
			tabPageInfo.Location = new Point(4, 24);
			tabPageInfo.Margin = new Padding(4, 3, 4, 3);
			tabPageInfo.Name = "tabPageInfo";
			tabPageInfo.Padding = new Padding(4, 3, 4, 3);
			tabPageInfo.Size = new Size(588, 248);
			tabPageInfo.TabIndex = 2;
			tabPageInfo.Text = "Info";
			toolTip.SetToolTip(tabPageInfo, "Show some info");
			tabPageInfo.ToolTipText = "Show some info";
			tabPageInfo.UseVisualStyleBackColor = true;
			tabPageInfo.Enter += SetStatusbar_Enter;
			tabPageInfo.Leave += ClearStatusbar_Leave;
			tabPageInfo.MouseEnter += SetStatusbar_Enter;
			tabPageInfo.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSelfTest
			// 
			buttonSelfTest.AccessibleDescription = "Start a self test";
			buttonSelfTest.AccessibleName = "Self test";
			buttonSelfTest.AccessibleRole = AccessibleRole.PushButton;
			buttonSelfTest.AutoEllipsis = true;
			buttonSelfTest.Image = Properties.Resources.fatfow_tubes_16;
			buttonSelfTest.ImageAlign = ContentAlignment.MiddleLeft;
			buttonSelfTest.Location = new Point(508, 6);
			buttonSelfTest.Name = "buttonSelfTest";
			buttonSelfTest.Size = new Size(72, 26);
			buttonSelfTest.TabIndex = 14;
			buttonSelfTest.Text = "Self test";
			buttonSelfTest.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonSelfTest.UseVisualStyleBackColor = true;
			buttonSelfTest.Click += ButtonSelfTest_Click;
			buttonSelfTest.Enter += SetStatusbar_Enter;
			buttonSelfTest.Leave += ClearStatusbar_Leave;
			buttonSelfTest.MouseEnter += SetStatusbar_Enter;
			buttonSelfTest.MouseLeave += ClearStatusbar_Leave;
			// 
			// linkLabelUrl
			// 
			linkLabelUrl.AccessibleDescription = "Open the Link to Github";
			linkLabelUrl.AccessibleName = "Github link";
			linkLabelUrl.AccessibleRole = AccessibleRole.Link;
			linkLabelUrl.AutoEllipsis = true;
			linkLabelUrl.AutoSize = true;
			linkLabelUrl.Location = new Point(135, 84);
			linkLabelUrl.Margin = new Padding(4, 0, 4, 0);
			linkLabelUrl.Name = "linkLabelUrl";
			linkLabelUrl.Size = new Size(236, 15);
			linkLabelUrl.TabIndex = 4;
			linkLabelUrl.TabStop = true;
			linkLabelUrl.Text = "https://github.com/Mijo-Software/Hasher/";
			toolTip.SetToolTip(linkLabelUrl, "Open the link to Github");
			linkLabelUrl.Click += LinkLabelUrl_Click;
			linkLabelUrl.Enter += SetStatusbar_Enter;
			linkLabelUrl.Leave += ClearStatusbar_Leave;
			linkLabelUrl.MouseEnter += SetStatusbar_Enter;
			linkLabelUrl.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxDescription
			// 
			textBoxDescription.AccessibleDescription = "Show the description";
			textBoxDescription.AccessibleName = "Description";
			textBoxDescription.AccessibleRole = AccessibleRole.Text;
			textBoxDescription.Location = new Point(11, 120);
			textBoxDescription.Margin = new Padding(7, 3, 4, 3);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(572, 122);
			textBoxDescription.TabIndex = 5;
			textBoxDescription.Text = "Description";
			toolTip.SetToolTip(textBoxDescription, "Description");
			textBoxDescription.Enter += SetStatusbar_Enter;
			textBoxDescription.Leave += ClearStatusbar_Leave;
			textBoxDescription.MouseEnter += SetStatusbar_Enter;
			textBoxDescription.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelCompanyName
			// 
			labelCompanyName.AccessibleDescription = "Show the company name";
			labelCompanyName.AccessibleName = "Company name";
			labelCompanyName.AccessibleRole = AccessibleRole.StaticText;
			labelCompanyName.AutoEllipsis = true;
			labelCompanyName.AutoSize = true;
			labelCompanyName.Location = new Point(135, 65);
			labelCompanyName.Margin = new Padding(7, 0, 4, 0);
			labelCompanyName.MaximumSize = new Size(0, 20);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(92, 15);
			labelCompanyName.TabIndex = 3;
			labelCompanyName.Text = "Company name";
			labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCompanyName, "Copyright name");
			labelCompanyName.Enter += SetStatusbar_Enter;
			labelCompanyName.Leave += ClearStatusbar_Leave;
			labelCompanyName.MouseEnter += SetStatusbar_Enter;
			labelCompanyName.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelCopyright
			// 
			labelCopyright.AccessibleDescription = "Show the copyright";
			labelCopyright.AccessibleName = "Copyright";
			labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			labelCopyright.AutoEllipsis = true;
			labelCopyright.AutoSize = true;
			labelCopyright.Location = new Point(135, 45);
			labelCopyright.Margin = new Padding(7, 0, 4, 0);
			labelCopyright.MaximumSize = new Size(0, 20);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(60, 15);
			labelCopyright.TabIndex = 2;
			labelCopyright.Text = "Copyright";
			labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCopyright, "Copyright");
			labelCopyright.Enter += SetStatusbar_Enter;
			labelCopyright.Leave += ClearStatusbar_Leave;
			labelCopyright.MouseEnter += SetStatusbar_Enter;
			labelCopyright.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelVersion
			// 
			labelVersion.AccessibleDescription = "Show the version";
			labelVersion.AccessibleName = "Version";
			labelVersion.AccessibleRole = AccessibleRole.StaticText;
			labelVersion.AutoEllipsis = true;
			labelVersion.AutoSize = true;
			labelVersion.Location = new Point(135, 26);
			labelVersion.Margin = new Padding(7, 0, 4, 0);
			labelVersion.MaximumSize = new Size(0, 20);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(45, 15);
			labelVersion.TabIndex = 1;
			labelVersion.Text = "Version";
			labelVersion.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelVersion, "Version");
			labelVersion.Enter += SetStatusbar_Enter;
			labelVersion.Leave += ClearStatusbar_Leave;
			labelVersion.MouseEnter += SetStatusbar_Enter;
			labelVersion.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelProductName
			// 
			labelProductName.AccessibleDescription = "Show the product name";
			labelProductName.AccessibleName = "Product name";
			labelProductName.AccessibleRole = AccessibleRole.StaticText;
			labelProductName.AutoEllipsis = true;
			labelProductName.AutoSize = true;
			labelProductName.Location = new Point(135, 6);
			labelProductName.Margin = new Padding(7, 0, 4, 0);
			labelProductName.MaximumSize = new Size(0, 20);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(82, 15);
			labelProductName.TabIndex = 0;
			labelProductName.Text = "Product name";
			labelProductName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelProductName, "Product name");
			labelProductName.Enter += SetStatusbar_Enter;
			labelProductName.Leave += ClearStatusbar_Leave;
			labelProductName.MouseEnter += SetStatusbar_Enter;
			labelProductName.MouseLeave += ClearStatusbar_Leave;
			// 
			// logoPictureBox
			// 
			logoPictureBox.AccessibleDescription = "This is the program icon.";
			logoPictureBox.AccessibleName = "program icon";
			logoPictureBox.AccessibleRole = AccessibleRole.Graphic;
			logoPictureBox.Image = Properties.Resources.logo_hasher_96;
			logoPictureBox.Location = new Point(11, 6);
			logoPictureBox.Margin = new Padding(4, 3, 4, 3);
			logoPictureBox.Name = "logoPictureBox";
			logoPictureBox.Size = new Size(113, 108);
			logoPictureBox.TabIndex = 13;
			logoPictureBox.TabStop = false;
			toolTip.SetToolTip(logoPictureBox, "program icon");
			logoPictureBox.MouseEnter += SetStatusbar_Enter;
			logoPictureBox.MouseLeave += ClearStatusbar_Leave;
			// 
			// tabPageLicense
			// 
			tabPageLicense.AccessibleDescription = "Show the license tab page";
			tabPageLicense.AccessibleName = "license tab page";
			tabPageLicense.AccessibleRole = AccessibleRole.PageTab;
			tabPageLicense.Controls.Add(textBoxLicense);
			tabPageLicense.ImageKey = "fatcow_script_text_16.png";
			tabPageLicense.Location = new Point(4, 24);
			tabPageLicense.Margin = new Padding(4, 3, 4, 3);
			tabPageLicense.Name = "tabPageLicense";
			tabPageLicense.Padding = new Padding(4, 3, 4, 3);
			tabPageLicense.Size = new Size(588, 248);
			tabPageLicense.TabIndex = 3;
			tabPageLicense.Text = "License";
			toolTip.SetToolTip(tabPageLicense, "Show the license");
			tabPageLicense.ToolTipText = "Show the license";
			tabPageLicense.UseVisualStyleBackColor = true;
			tabPageLicense.Enter += SetStatusbar_Enter;
			tabPageLicense.Leave += ClearStatusbar_Leave;
			tabPageLicense.MouseEnter += SetStatusbar_Enter;
			tabPageLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxLicense
			// 
			textBoxLicense.AccessibleDescription = "Show the license";
			textBoxLicense.AccessibleName = "License";
			textBoxLicense.AccessibleRole = AccessibleRole.Text;
			textBoxLicense.Dock = DockStyle.Fill;
			textBoxLicense.Location = new Point(4, 3);
			textBoxLicense.Margin = new Padding(7, 3, 4, 3);
			textBoxLicense.MaxLength = 9999999;
			textBoxLicense.Multiline = true;
			textBoxLicense.Name = "textBoxLicense";
			textBoxLicense.PlaceholderText = "license here... 😉";
			textBoxLicense.ReadOnly = true;
			textBoxLicense.ScrollBars = ScrollBars.Both;
			textBoxLicense.Size = new Size(580, 242);
			textBoxLicense.TabIndex = 5;
			textBoxLicense.Text = resources.GetString("textBoxLicense.Text");
			toolTip.SetToolTip(textBoxLicense, "License");
			textBoxLicense.Enter += SetStatusbar_Enter;
			textBoxLicense.Leave += ClearStatusbar_Leave;
			textBoxLicense.MouseEnter += SetStatusbar_Enter;
			textBoxLicense.MouseLeave += ClearStatusbar_Leave;
			// 
			// imageListTab
			// 
			imageListTab.ColorDepth = ColorDepth.Depth8Bit;
			imageListTab.ImageStream = (ImageListStreamer)resources.GetObject("imageListTab.ImageStream");
			imageListTab.TransparentColor = Color.Transparent;
			imageListTab.Images.SetKeyName(0, "fatcow_page_16.png");
			imageListTab.Images.SetKeyName(1, "fatcow_text_effects_16.png");
			imageListTab.Images.SetKeyName(2, "fatcow_infomation_16.png");
			imageListTab.Images.SetKeyName(3, "fatcow_script_text_16.png");
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Just a status bar";
			statusStrip.AccessibleName = "status bar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation });
			statusStrip.Location = new Point(0, 25);
			statusStrip.Name = "statusStrip";
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(596, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
			statusStrip.TabStop = true;
			statusStrip.Text = "status bar";
			toolTip.SetToolTip(statusStrip, "Just a status bar");
			statusStrip.Enter += SetStatusbar_Enter;
			statusStrip.Leave += ClearStatusbar_Leave;
			statusStrip.MouseEnter += SetStatusbar_Enter;
			statusStrip.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripStatusLabelInformation
			// 
			toolStripStatusLabelInformation.AccessibleDescription = "Show some information";
			toolStripStatusLabelInformation.AccessibleName = "information";
			toolStripStatusLabelInformation.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelInformation.AutoToolTip = true;
			toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			toolStripStatusLabelInformation.Size = new Size(70, 17);
			toolStripStatusLabelInformation.Text = "information";
			toolStripStatusLabelInformation.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelInformation.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Just an container";
			toolStripContainer.AccessibleName = "Container";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(tabControl);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(596, 360);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(596, 407);
			toolStripContainer.TabIndex = 29;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// buttonbuttonSaveCrc32StringToFile
			// 
			buttonbuttonSaveCrc32StringToFile.AccessibleDescription = "Save the CRC32 hash value in a file";
			buttonbuttonSaveCrc32StringToFile.AccessibleName = "Save CRC32 hash to file";
			buttonbuttonSaveCrc32StringToFile.AccessibleRole = AccessibleRole.PushButton;
			buttonbuttonSaveCrc32StringToFile.AutoEllipsis = true;
			buttonbuttonSaveCrc32StringToFile.Image = (Image)resources.GetObject("buttonbuttonSaveCrc32StringToFile.Image");
			buttonbuttonSaveCrc32StringToFile.Location = new Point(551, 244);
			buttonbuttonSaveCrc32StringToFile.Margin = new Padding(4, 3, 4, 3);
			buttonbuttonSaveCrc32StringToFile.Name = "buttonbuttonSaveCrc32StringToFile";
			buttonbuttonSaveCrc32StringToFile.Size = new Size(28, 28);
			buttonbuttonSaveCrc32StringToFile.TabIndex = 33;
			buttonbuttonSaveCrc32StringToFile.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonbuttonSaveCrc32StringToFile, "Save the CRC32 hash value in a file");
			buttonbuttonSaveCrc32StringToFile.UseVisualStyleBackColor = true;
			// 
			// buttonCopyCrc32StringFromFileToClipboard
			// 
			buttonCopyCrc32StringFromFileToClipboard.AccessibleDescription = "Copy the CRC32 hash value to the clipboard";
			buttonCopyCrc32StringFromFileToClipboard.AccessibleName = "Copy CRC32 hash value to clipboard";
			buttonCopyCrc32StringFromFileToClipboard.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyCrc32StringFromFileToClipboard.AutoEllipsis = true;
			buttonCopyCrc32StringFromFileToClipboard.Image = (Image)resources.GetObject("buttonCopyCrc32StringFromFileToClipboard.Image");
			buttonCopyCrc32StringFromFileToClipboard.Location = new Point(516, 244);
			buttonCopyCrc32StringFromFileToClipboard.Margin = new Padding(4, 3, 4, 3);
			buttonCopyCrc32StringFromFileToClipboard.Name = "buttonCopyCrc32StringFromFileToClipboard";
			buttonCopyCrc32StringFromFileToClipboard.Size = new Size(28, 28);
			buttonCopyCrc32StringFromFileToClipboard.TabIndex = 32;
			buttonCopyCrc32StringFromFileToClipboard.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopyCrc32StringFromFileToClipboard, "Copy the CRC32 hash value to the clipboard");
			buttonCopyCrc32StringFromFileToClipboard.UseVisualStyleBackColor = true;
			// 
			// textBoxCrc32StringFromFile
			// 
			textBoxCrc32StringFromFile.AccessibleDescription = "Show the CRC32 hash value";
			textBoxCrc32StringFromFile.AccessibleName = "CRC32 hash value";
			textBoxCrc32StringFromFile.AccessibleRole = AccessibleRole.Text;
			textBoxCrc32StringFromFile.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
			textBoxCrc32StringFromFile.Location = new Point(66, 248);
			textBoxCrc32StringFromFile.Margin = new Padding(4, 3, 4, 3);
			textBoxCrc32StringFromFile.Name = "textBoxCrc32StringFromFile";
			textBoxCrc32StringFromFile.ReadOnly = true;
			textBoxCrc32StringFromFile.Size = new Size(441, 20);
			textBoxCrc32StringFromFile.TabIndex = 31;
			toolTip.SetToolTip(textBoxCrc32StringFromFile, "CRC32 hash value");
			// 
			// labelCrc32StringFromFile
			// 
			labelCrc32StringFromFile.AccessibleDescription = "CRC32";
			labelCrc32StringFromFile.AccessibleName = "CRC32";
			labelCrc32StringFromFile.AccessibleRole = AccessibleRole.StaticText;
			labelCrc32StringFromFile.AutoSize = true;
			labelCrc32StringFromFile.Location = new Point(7, 251);
			labelCrc32StringFromFile.Margin = new Padding(4, 0, 4, 0);
			labelCrc32StringFromFile.Name = "labelCrc32StringFromFile";
			labelCrc32StringFromFile.Size = new Size(45, 15);
			labelCrc32StringFromFile.TabIndex = 30;
			labelCrc32StringFromFile.Text = "CRC32:";
			toolTip.SetToolTip(labelCrc32StringFromFile, "CRC512 hash");
			// 
			// MainForm
			// 
			AccessibleDescription = "This is the window of the application";
			AccessibleName = "Window of the application";
			AccessibleRole = AccessibleRole.Window;
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(596, 407);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Hasher";
			Load += MainForm_Load;
			DragDrop += MainForm_DragDrop;
			DragEnter += MainForm_DragEnter;
			tabControl.ResumeLayout(false);
			tabPageFile.ResumeLayout(false);
			tabPageFile.PerformLayout();
			tabPageText.ResumeLayout(false);
			tabPageText.PerformLayout();
			tabPageInfo.ResumeLayout(false);
			tabPageInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			tabPageLicense.ResumeLayout(false);
			tabPageLicense.PerformLayout();
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

		private Label labelFileName;
		private TextBox textBoxFileName;
		private Button buttonOpenAndCalculateHashFromFile;
		private Label labelMD5StringFromFile;
		private TextBox textBoxMD5StringFromFile;
		private OpenFileDialog openFileDialog;
		private Button buttonCopyMD5StringFromFileToClipboard;
		private Button buttonCopySHA1StringFromFileToClipboard;
		private TextBox textBoxSHA1StringFromFile;
		private Label labelSHA1StringFromFile;
		private Button buttonCopySHA256StringFromFileToClipboard;
		private TextBox textBoxSHA256StringFromFile;
		private Label labelSHA256StringFromFile;
		private Button buttonCopySHA384StringFromFileToClipboard;
		private TextBox textBoxSHA384StringFromFile;
		private Label labelSHA384FromFile;
		private Button buttonCopySHA512StringFromFileToClipboard;
		private TextBox textBoxSHA512StringFromFile;
		private Label labelSHA512StringFromFile;
		private Button buttonSaveSHA512StringToFile;
		private Button buttonSaveSHA384StringToFile;
		private Button buttonSaveSHA256StringToFile;
		private Button buttonSaveSHA1StringToFile;
		private Button buttonSaveMD5StringToFile;
		private SaveFileDialog saveFileDialog;
		private TabControl tabControl;
		private TabPage tabPageFile;
		private TabPage tabPageText;
		private Label labelText;
		private TextBox textBoxText;
		private Button buttonCalculateHashFromText;
		private Label labelMD5StringFromText;
		private TextBox textBoxMD5StringFromText;
		private Button buttonCopyMD5StringFromTextToClipboard;
		private Button buttonCopySHA512StringFromTextToClipboard;
		private TextBox textBoxSHA512StringFromText;
		private Label labelSHA1StringFromText;
		private Label labelSHA512StringFromText;
		private TextBox textBoxSHA1StringFromText;
		private Button buttonCopySHA384StringFromTextToClipboard;
		private Button buttonCopySHA1StringFromTextToClipboard;
		private TextBox textBoxSHA384StringFromText;
		private Label labelSHA256StringFromText;
		private Label labelSHA384StringFromText;
		private TextBox textBoxSHA256StringFromText;
		private Button buttonCopySHA256StringFromTextToClipboard;
		private CheckBox checkBoxAutoUpdateText;
		private ToolTip toolTip;
		private StatusStrip statusStrip;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private ToolStripContainer toolStripContainer;
		private ImageList imageListTab;
		private TabPage tabPageInfo;
		private Label labelVersion;
		private Label labelProductName;
		private PictureBox logoPictureBox;
		private Label labelCopyright;
		private Label labelCompanyName;
		private TextBox textBoxDescription;
		private TabPage tabPageLicense;
		private TextBox textBoxLicense;
		private LinkLabel linkLabelUrl;
		private Button buttonSaveAllHashValuesAutomatically;
		private Button buttonSaveAllHashValuesInClipboard;
		private Button buttonSaveAllHashValuesInList;
		private Button buttonSelfTest;
		private Button buttonInsertTextFromClipboard;
		private Button buttonbuttonSaveCrc32StringToFile;
		private Button buttonCopyCrc32StringFromFileToClipboard;
		private TextBox textBoxCrc32StringFromFile;
		private Label labelCrc32StringFromFile;
	}
}

