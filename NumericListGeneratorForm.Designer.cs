namespace Numeric_List_Generator
{
	partial class NumericListGeneratorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumericListGeneratorForm));
			labelStringBeforeNumber = new Label();
			labelStringAfterNumber = new Label();
			labelNumberMin = new Label();
			numericUpDownNumberMinimum = new NumericUpDown();
			labelNumberMax = new Label();
			numericUpDownNumberMaximum = new NumericUpDown();
			checkBoxFillWithZeros = new CheckBox();
			textBoxList = new TextBox();
			labelProcress = new Label();
			progressBar = new ProgressBar();
			toolTip = new ToolTip(components);
			textBoxStringBeforeNumber = new TextBox();
			textBoxStringAfterNumber = new TextBox();
			buttonRedo = new Button();
			buttonUndo = new Button();
			buttonCreateList = new Button();
			buttonInformationAboutApp = new Button();
			buttonExitApp = new Button();
			buttonDeleteList = new Button();
			buttonSaveList = new Button();
			buttonCopyList = new Button();
			buttonAddToList = new Button();
			labelResult = new Label();
			statusStripStatistic = new StatusStrip();
			toolStripStatusLabelSize = new ToolStripStatusLabel();
			toolStripStatusLabelLines = new ToolStripStatusLabel();
			toolStripStatusLabelTimeSpan = new ToolStripStatusLabel();
			toolStripStatusLabelLim = new ToolStripStatusLabel();
			toolStripSplitButtonStyle = new ToolStripSplitButton();
			toolStripMenuItemActivateVisualStyle = new ToolStripMenuItem();
			toolStripMenuItemDeactivateVisualStyle = new ToolStripMenuItem();
			backgroundWorker = new System.ComponentModel.BackgroundWorker();
			buttonSettings = new Button();
			statusStripInfo = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMinimum).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMaximum).BeginInit();
			statusStripStatistic.SuspendLayout();
			statusStripInfo.SuspendLayout();
			SuspendLayout();
			// 
			// labelStringBeforeNumber
			// 
			labelStringBeforeNumber.AccessibleDescription = "Zeichenkette vor der Zahl";
			labelStringBeforeNumber.AccessibleName = "Zeichenkette vor der Zahl";
			labelStringBeforeNumber.AccessibleRole = AccessibleRole.StaticText;
			labelStringBeforeNumber.AutoEllipsis = true;
			labelStringBeforeNumber.AutoSize = true;
			labelStringBeforeNumber.Location = new Point(10, 10);
			labelStringBeforeNumber.Margin = new Padding(4, 0, 4, 0);
			labelStringBeforeNumber.Name = "labelStringBeforeNumber";
			labelStringBeforeNumber.Size = new Size(144, 15);
			labelStringBeforeNumber.TabIndex = 0;
			labelStringBeforeNumber.Text = "Zeichenkette &vor der Zahl:";
			labelStringBeforeNumber.Enter += SetStatusbar_Enter;
			labelStringBeforeNumber.Leave += ClearStatusbar_Leave;
			labelStringBeforeNumber.MouseEnter += SetStatusbar_Enter;
			labelStringBeforeNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelStringAfterNumber
			// 
			labelStringAfterNumber.AccessibleDescription = "Zeichenkette nach der Zahl";
			labelStringAfterNumber.AccessibleName = "Zeichenkette nach der Zahl";
			labelStringAfterNumber.AccessibleRole = AccessibleRole.StaticText;
			labelStringAfterNumber.AutoEllipsis = true;
			labelStringAfterNumber.AutoSize = true;
			labelStringAfterNumber.Location = new Point(10, 107);
			labelStringAfterNumber.Margin = new Padding(4, 0, 4, 0);
			labelStringAfterNumber.Name = "labelStringAfterNumber";
			labelStringAfterNumber.Size = new Size(153, 15);
			labelStringAfterNumber.TabIndex = 7;
			labelStringAfterNumber.Text = "Zeichenkette &nach der Zahl:";
			toolTip.SetToolTip(labelStringAfterNumber, "Zeichenkette nach der Zahl");
			labelStringAfterNumber.Enter += SetStatusbar_Enter;
			labelStringAfterNumber.Leave += ClearStatusbar_Leave;
			labelStringAfterNumber.MouseEnter += SetStatusbar_Enter;
			labelStringAfterNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelNumberMin
			// 
			labelNumberMin.AccessibleDescription = "Zahlen Minimum";
			labelNumberMin.AccessibleName = "Zahlen Minimum";
			labelNumberMin.AccessibleRole = AccessibleRole.StaticText;
			labelNumberMin.AutoEllipsis = true;
			labelNumberMin.AutoSize = true;
			labelNumberMin.Location = new Point(10, 69);
			labelNumberMin.Margin = new Padding(4, 0, 4, 0);
			labelNumberMin.Name = "labelNumberMin";
			labelNumberMin.Size = new Size(66, 15);
			labelNumberMin.TabIndex = 2;
			labelNumberMin.Text = "Zahlen v&on";
			toolTip.SetToolTip(labelNumberMin, "Zahlen Minimum");
			labelNumberMin.Enter += SetStatusbar_Enter;
			labelNumberMin.Leave += ClearStatusbar_Leave;
			labelNumberMin.MouseEnter += SetStatusbar_Enter;
			labelNumberMin.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownNumberMinimum
			// 
			numericUpDownNumberMinimum.AccessibleDescription = "Minimun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMinimum.AccessibleName = "Minimun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMinimum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownNumberMinimum.Location = new Point(89, 67);
			numericUpDownNumberMinimum.Margin = new Padding(4, 3, 4, 3);
			numericUpDownNumberMinimum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numericUpDownNumberMinimum.Name = "numericUpDownNumberMinimum";
			numericUpDownNumberMinimum.Size = new Size(57, 23);
			numericUpDownNumberMinimum.TabIndex = 3;
			toolTip.SetToolTip(numericUpDownNumberMinimum, "Minimun der Zahl, mit der die Einträge erstellt werden sollen");
			numericUpDownNumberMinimum.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownNumberMinimum.Enter += SetStatusbar_Enter;
			numericUpDownNumberMinimum.Leave += ClearStatusbar_Leave;
			// 
			// labelNumberMax
			// 
			labelNumberMax.AccessibleDescription = "Zahlen Maximum";
			labelNumberMax.AccessibleName = "Zahlen Maximum";
			labelNumberMax.AccessibleRole = AccessibleRole.StaticText;
			labelNumberMax.AutoSize = true;
			labelNumberMax.Location = new Point(153, 69);
			labelNumberMax.Margin = new Padding(4, 0, 4, 0);
			labelNumberMax.Name = "labelNumberMax";
			labelNumberMax.Size = new Size(22, 15);
			labelNumberMax.TabIndex = 4;
			labelNumberMax.Text = "b&is";
			toolTip.SetToolTip(labelNumberMax, "Zahlen Maximum");
			labelNumberMax.Enter += SetStatusbar_Enter;
			labelNumberMax.Leave += ClearStatusbar_Leave;
			labelNumberMax.MouseEnter += SetStatusbar_Enter;
			labelNumberMax.MouseLeave += ClearStatusbar_Leave;
			// 
			// numericUpDownNumberMaximum
			// 
			numericUpDownNumberMaximum.AccessibleDescription = "Maximun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMaximum.AccessibleName = "Maximun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMaximum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownNumberMaximum.Location = new Point(183, 67);
			numericUpDownNumberMaximum.Margin = new Padding(4, 3, 4, 3);
			numericUpDownNumberMaximum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numericUpDownNumberMaximum.Name = "numericUpDownNumberMaximum";
			numericUpDownNumberMaximum.Size = new Size(57, 23);
			numericUpDownNumberMaximum.TabIndex = 5;
			toolTip.SetToolTip(numericUpDownNumberMaximum, "Maximun der Zahl, mit der die Einträge erstellt werden sollen");
			numericUpDownNumberMaximum.Value = new decimal(new int[] { 10, 0, 0, 0 });
			numericUpDownNumberMaximum.Enter += SetStatusbar_Enter;
			numericUpDownNumberMaximum.Leave += ClearStatusbar_Leave;
			// 
			// checkBoxFillWithZeros
			// 
			checkBoxFillWithZeros.AccessibleDescription = "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen";
			checkBoxFillWithZeros.AccessibleName = "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen";
			checkBoxFillWithZeros.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxFillWithZeros.AutoSize = true;
			checkBoxFillWithZeros.Location = new Point(255, 69);
			checkBoxFillWithZeros.Margin = new Padding(4, 3, 4, 3);
			checkBoxFillWithZeros.Name = "checkBoxFillWithZeros";
			checkBoxFillWithZeros.Size = new Size(132, 19);
			checkBoxFillWithZeros.TabIndex = 6;
			checkBoxFillWithZeros.Text = "&mit Nullen auffüllen";
			toolTip.SetToolTip(checkBoxFillWithZeros, "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen");
			checkBoxFillWithZeros.UseVisualStyleBackColor = true;
			checkBoxFillWithZeros.Enter += SetStatusbar_Enter;
			checkBoxFillWithZeros.Leave += ClearStatusbar_Leave;
			checkBoxFillWithZeros.MouseEnter += SetStatusbar_Enter;
			checkBoxFillWithZeros.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxList
			// 
			textBoxList.AccessibleDescription = "Zeigt die Liste mit den generierten Einträgen an";
			textBoxList.AccessibleName = "Generierten Einträge";
			textBoxList.AccessibleRole = AccessibleRole.Text;
			textBoxList.Location = new Point(14, 302);
			textBoxList.Margin = new Padding(4, 3, 4, 3);
			textBoxList.MaxLength = int.MaxValue;
			textBoxList.Multiline = true;
			textBoxList.Name = "textBoxList";
			textBoxList.ScrollBars = ScrollBars.Both;
			textBoxList.Size = new Size(395, 192);
			textBoxList.TabIndex = 19;
			toolTip.SetToolTip(textBoxList, "Zeigt die Liste mit den generierten Einträgen an");
			textBoxList.WordWrap = false;
			textBoxList.Enter += SetStatusbar_Enter;
			textBoxList.Leave += ClearStatusbar_Leave;
			textBoxList.MouseEnter += SetStatusbar_Enter;
			textBoxList.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelProcress
			// 
			labelProcress.AccessibleDescription = "Verarbeitung";
			labelProcress.AccessibleName = "Verarbeitung";
			labelProcress.AccessibleRole = AccessibleRole.StaticText;
			labelProcress.AutoEllipsis = true;
			labelProcress.AutoSize = true;
			labelProcress.Location = new Point(10, 253);
			labelProcress.Margin = new Padding(4, 0, 4, 0);
			labelProcress.Name = "labelProcress";
			labelProcress.Size = new Size(77, 15);
			labelProcress.TabIndex = 16;
			labelProcress.Text = "Verarbeitun&g:";
			toolTip.SetToolTip(labelProcress, "Verarbeitung");
			labelProcress.Enter += SetStatusbar_Enter;
			labelProcress.Leave += ClearStatusbar_Leave;
			labelProcress.MouseEnter += SetStatusbar_Enter;
			labelProcress.MouseLeave += ClearStatusbar_Leave;
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Zeigt den laufenden Verarbeitungsstatus an";
			progressBar.AccessibleName = "Verarbeitungsstatus";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Location = new Point(95, 253);
			progressBar.Margin = new Padding(4, 3, 4, 3);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(314, 20);
			progressBar.Style = ProgressBarStyle.Continuous;
			progressBar.TabIndex = 17;
			toolTip.SetToolTip(progressBar, "Zeigt den laufenden Verarbeitungsstatus an");
			progressBar.MouseEnter += SetStatusbar_Enter;
			progressBar.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxStringBeforeNumber
			// 
			textBoxStringBeforeNumber.AccessibleDescription = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.AccessibleName = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.AccessibleRole = AccessibleRole.Text;
			textBoxStringBeforeNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBoxStringBeforeNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
			textBoxStringBeforeNumber.Location = new Point(14, 29);
			textBoxStringBeforeNumber.Margin = new Padding(4, 3, 4, 3);
			textBoxStringBeforeNumber.Name = "textBoxStringBeforeNumber";
			textBoxStringBeforeNumber.PlaceholderText = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.Size = new Size(395, 23);
			textBoxStringBeforeNumber.TabIndex = 1;
			textBoxStringBeforeNumber.Text = "http://www.domain.com/files/picture";
			toolTip.SetToolTip(textBoxStringBeforeNumber, "Eingabe des Textes vor der Zahlenangabe");
			textBoxStringBeforeNumber.Enter += SetStatusbar_Enter;
			textBoxStringBeforeNumber.Leave += ClearStatusbar_Leave;
			textBoxStringBeforeNumber.MouseEnter += SetStatusbar_Enter;
			textBoxStringBeforeNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxStringAfterNumber
			// 
			textBoxStringAfterNumber.AccessibleDescription = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.AccessibleName = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.AccessibleRole = AccessibleRole.Text;
			textBoxStringAfterNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBoxStringAfterNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
			textBoxStringAfterNumber.Location = new Point(14, 126);
			textBoxStringAfterNumber.Margin = new Padding(4, 3, 4, 3);
			textBoxStringAfterNumber.Name = "textBoxStringAfterNumber";
			textBoxStringAfterNumber.PlaceholderText = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.Size = new Size(395, 23);
			textBoxStringAfterNumber.TabIndex = 8;
			textBoxStringAfterNumber.Text = ".jpg";
			toolTip.SetToolTip(textBoxStringAfterNumber, "Eingabe des Textes nach der Zahlenangabe");
			textBoxStringAfterNumber.Enter += SetStatusbar_Enter;
			textBoxStringAfterNumber.Leave += ClearStatusbar_Leave;
			textBoxStringAfterNumber.MouseEnter += SetStatusbar_Enter;
			textBoxStringAfterNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonRedo
			// 
			buttonRedo.AccessibleDescription = "Verwirft die letzte rückgängig gemachte Änderung";
			buttonRedo.AccessibleName = "Letzte Änderung verwerfen";
			buttonRedo.AccessibleRole = AccessibleRole.PushButton;
			buttonRedo.AutoEllipsis = true;
			buttonRedo.Image = Properties.Resources.redo;
			buttonRedo.Location = new Point(86, 205);
			buttonRedo.Margin = new Padding(4, 3, 4, 3);
			buttonRedo.Name = "buttonRedo";
			buttonRedo.Size = new Size(68, 30);
			buttonRedo.TabIndex = 13;
			buttonRedo.Text = "&Redo";
			buttonRedo.TextAlign = ContentAlignment.MiddleRight;
			buttonRedo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonRedo, "Verwirft die letzte rückgängig gemachte Änderung");
			buttonRedo.UseVisualStyleBackColor = true;
			buttonRedo.Click += ButtonRedo_Click;
			buttonRedo.Enter += SetStatusbar_Enter;
			buttonRedo.Leave += ClearStatusbar_Leave;
			buttonRedo.MouseEnter += SetStatusbar_Enter;
			buttonRedo.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonUndo
			// 
			buttonUndo.AccessibleDescription = "Macht die letzte Änderung rückgängig";
			buttonUndo.AccessibleName = "Änderung rückgängigmachen";
			buttonUndo.AccessibleRole = AccessibleRole.PushButton;
			buttonUndo.AutoEllipsis = true;
			buttonUndo.Image = (Image)resources.GetObject("buttonUndo.Image");
			buttonUndo.Location = new Point(14, 205);
			buttonUndo.Margin = new Padding(4, 3, 4, 3);
			buttonUndo.Name = "buttonUndo";
			buttonUndo.Size = new Size(68, 30);
			buttonUndo.TabIndex = 12;
			buttonUndo.Text = "&Undo";
			buttonUndo.TextAlign = ContentAlignment.MiddleRight;
			buttonUndo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonUndo, "Macht die letzte Änderung rückgängig");
			buttonUndo.UseVisualStyleBackColor = true;
			buttonUndo.Click += ButtonUndo_Click;
			buttonUndo.Enter += SetStatusbar_Enter;
			buttonUndo.Leave += ClearStatusbar_Leave;
			buttonUndo.MouseEnter += SetStatusbar_Enter;
			buttonUndo.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCreateList
			// 
			buttonCreateList.AccessibleDescription = "Erstellt eine neue Liste";
			buttonCreateList.AccessibleName = "Liste neu erstellen";
			buttonCreateList.AccessibleRole = AccessibleRole.PushButton;
			buttonCreateList.AutoEllipsis = true;
			buttonCreateList.Image = Properties.Resources.document_index;
			buttonCreateList.Location = new Point(14, 168);
			buttonCreateList.Margin = new Padding(4, 3, 4, 3);
			buttonCreateList.Name = "buttonCreateList";
			buttonCreateList.Size = new Size(140, 30);
			buttonCreateList.TabIndex = 9;
			buttonCreateList.Text = "Liste neu &erstellen";
			buttonCreateList.TextAlign = ContentAlignment.MiddleRight;
			buttonCreateList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCreateList, "Erstellt eine neue Liste");
			buttonCreateList.UseVisualStyleBackColor = true;
			buttonCreateList.Click += ButtonCreateList_Click;
			buttonCreateList.Enter += SetStatusbar_Enter;
			buttonCreateList.Leave += ClearStatusbar_Leave;
			buttonCreateList.MouseEnter += SetStatusbar_Enter;
			buttonCreateList.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonInformationAboutApp
			// 
			buttonInformationAboutApp.AccessibleDescription = "Ruft die Programminformationen auf";
			buttonInformationAboutApp.AccessibleName = "Programminformationen";
			buttonInformationAboutApp.AccessibleRole = AccessibleRole.PushButton;
			buttonInformationAboutApp.AutoEllipsis = true;
			buttonInformationAboutApp.Image = Properties.Resources.information;
			buttonInformationAboutApp.Location = new Point(14, 502);
			buttonInformationAboutApp.Margin = new Padding(4, 3, 4, 3);
			buttonInformationAboutApp.Name = "buttonInformationAboutApp";
			buttonInformationAboutApp.Size = new Size(68, 30);
			buttonInformationAboutApp.TabIndex = 20;
			buttonInformationAboutApp.Text = "&Info";
			buttonInformationAboutApp.TextAlign = ContentAlignment.MiddleRight;
			buttonInformationAboutApp.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonInformationAboutApp, "Ruft die Programminformationen auf");
			buttonInformationAboutApp.UseVisualStyleBackColor = true;
			buttonInformationAboutApp.Click += ButtonInformationAboutApp_Click;
			buttonInformationAboutApp.Enter += SetStatusbar_Enter;
			buttonInformationAboutApp.Leave += ClearStatusbar_Leave;
			buttonInformationAboutApp.MouseEnter += SetStatusbar_Enter;
			buttonInformationAboutApp.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonExitApp
			// 
			buttonExitApp.AccessibleDescription = "Beendet das Program";
			buttonExitApp.AccessibleName = "Programm beenden";
			buttonExitApp.AccessibleRole = AccessibleRole.PushButton;
			buttonExitApp.AutoEllipsis = true;
			buttonExitApp.Image = Properties.Resources.door_open;
			buttonExitApp.Location = new Point(259, 502);
			buttonExitApp.Margin = new Padding(4, 3, 4, 3);
			buttonExitApp.Name = "buttonExitApp";
			buttonExitApp.Size = new Size(150, 30);
			buttonExitApp.TabIndex = 22;
			buttonExitApp.Text = "Programm &beenden";
			buttonExitApp.TextAlign = ContentAlignment.MiddleRight;
			buttonExitApp.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonExitApp, "Beendet das Programm");
			buttonExitApp.UseVisualStyleBackColor = true;
			buttonExitApp.Click += ButtonExitApp_Click;
			buttonExitApp.Enter += SetStatusbar_Enter;
			buttonExitApp.Leave += ClearStatusbar_Leave;
			buttonExitApp.MouseEnter += SetStatusbar_Enter;
			buttonExitApp.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonDeleteList
			// 
			buttonDeleteList.AccessibleDescription = "Löscht die Liste";
			buttonDeleteList.AccessibleName = "Liste löschen";
			buttonDeleteList.AccessibleRole = AccessibleRole.PushButton;
			buttonDeleteList.AutoEllipsis = true;
			buttonDeleteList.Image = Properties.Resources.bin_empty;
			buttonDeleteList.Location = new Point(289, 168);
			buttonDeleteList.Margin = new Padding(4, 3, 4, 3);
			buttonDeleteList.Name = "buttonDeleteList";
			buttonDeleteList.Size = new Size(120, 30);
			buttonDeleteList.TabIndex = 11;
			buttonDeleteList.Text = "Liste &löschen";
			buttonDeleteList.TextAlign = ContentAlignment.MiddleRight;
			buttonDeleteList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonDeleteList, "Löscht die Liste");
			buttonDeleteList.UseVisualStyleBackColor = true;
			buttonDeleteList.Click += ButtonDeleteList_Click;
			buttonDeleteList.Enter += SetStatusbar_Enter;
			buttonDeleteList.Leave += ClearStatusbar_Leave;
			buttonDeleteList.MouseEnter += SetStatusbar_Enter;
			buttonDeleteList.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonSaveList
			// 
			buttonSaveList.AccessibleDescription = "Speichert die Liste als Textdatei ab";
			buttonSaveList.AccessibleName = "Liste abspeichern";
			buttonSaveList.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveList.AutoEllipsis = true;
			buttonSaveList.Image = Properties.Resources.diskette;
			buttonSaveList.Location = new Point(289, 205);
			buttonSaveList.Margin = new Padding(4, 3, 4, 3);
			buttonSaveList.Name = "buttonSaveList";
			buttonSaveList.Size = new Size(120, 30);
			buttonSaveList.TabIndex = 15;
			buttonSaveList.Text = "Liste &speichern";
			buttonSaveList.TextAlign = ContentAlignment.MiddleRight;
			buttonSaveList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveList, "Speichert die Liste als Textdatei ab");
			buttonSaveList.UseVisualStyleBackColor = true;
			buttonSaveList.Click += ButtonSaveList_Click;
			buttonSaveList.Enter += SetStatusbar_Enter;
			buttonSaveList.Leave += ClearStatusbar_Leave;
			buttonSaveList.MouseEnter += SetStatusbar_Enter;
			buttonSaveList.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonCopyList
			// 
			buttonCopyList.AccessibleDescription = "Kopiert die Liste in die Windows-Zwischenablage";
			buttonCopyList.AccessibleName = "Liste koperien";
			buttonCopyList.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyList.AutoEllipsis = true;
			buttonCopyList.Image = Properties.Resources.page_copy;
			buttonCopyList.Location = new Point(161, 205);
			buttonCopyList.Margin = new Padding(4, 3, 4, 3);
			buttonCopyList.Name = "buttonCopyList";
			buttonCopyList.Size = new Size(121, 30);
			buttonCopyList.TabIndex = 14;
			buttonCopyList.Text = "Liste &kopieren";
			buttonCopyList.TextAlign = ContentAlignment.MiddleRight;
			buttonCopyList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopyList, "Kopiert die Liste in die Zwischenanlage");
			buttonCopyList.UseVisualStyleBackColor = true;
			buttonCopyList.Click += ButtonCopyList_Click;
			buttonCopyList.Enter += SetStatusbar_Enter;
			buttonCopyList.Leave += ClearStatusbar_Leave;
			buttonCopyList.MouseEnter += SetStatusbar_Enter;
			buttonCopyList.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonAddToList
			// 
			buttonAddToList.AccessibleDescription = "Fügt die Einträge an der vorhandenen Liste an";
			buttonAddToList.AccessibleName = "Liste anfügen";
			buttonAddToList.AccessibleRole = AccessibleRole.PushButton;
			buttonAddToList.AutoEllipsis = true;
			buttonAddToList.Image = Properties.Resources.add;
			buttonAddToList.Location = new Point(161, 168);
			buttonAddToList.Margin = new Padding(4, 3, 4, 3);
			buttonAddToList.Name = "buttonAddToList";
			buttonAddToList.Size = new Size(121, 30);
			buttonAddToList.TabIndex = 10;
			buttonAddToList.Text = "Liste &anfügen";
			buttonAddToList.TextAlign = ContentAlignment.MiddleRight;
			buttonAddToList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonAddToList, "Fügt die Einträge an der vorhandenen Liste an");
			buttonAddToList.UseVisualStyleBackColor = true;
			buttonAddToList.Click += ButtonAddToList_Click;
			buttonAddToList.Enter += SetStatusbar_Enter;
			buttonAddToList.Leave += ClearStatusbar_Leave;
			buttonAddToList.MouseEnter += SetStatusbar_Enter;
			buttonAddToList.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelResult
			// 
			labelResult.AccessibleDescription = "Ergebnis";
			labelResult.AccessibleName = "Ergebnis";
			labelResult.AccessibleRole = AccessibleRole.StaticText;
			labelResult.AutoEllipsis = true;
			labelResult.AutoSize = true;
			labelResult.Location = new Point(10, 284);
			labelResult.Margin = new Padding(4, 0, 4, 0);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(55, 15);
			labelResult.TabIndex = 18;
			labelResult.Text = "E&rgebnis:";
			toolTip.SetToolTip(labelResult, "Ergebnis");
			labelResult.MouseEnter += SetStatusbar_Enter;
			labelResult.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStripStatistic
			// 
			statusStripStatistic.AccessibleDescription = "Statusbar für statistische Angaben";
			statusStripStatistic.AccessibleName = "Statusbar";
			statusStripStatistic.AccessibleRole = AccessibleRole.StatusBar;
			statusStripStatistic.AllowItemReorder = true;
			statusStripStatistic.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelSize, toolStripStatusLabelLines, toolStripStatusLabelTimeSpan, toolStripStatusLabelLim, toolStripSplitButtonStyle });
			statusStripStatistic.Location = new Point(0, 561);
			statusStripStatistic.Name = "statusStripStatistic";
			statusStripStatistic.Padding = new Padding(1, 0, 16, 0);
			statusStripStatistic.ShowItemToolTips = true;
			statusStripStatistic.Size = new Size(424, 24);
			statusStripStatistic.SizingGrip = false;
			statusStripStatistic.TabIndex = 23;
			statusStripStatistic.TabStop = true;
			statusStripStatistic.Text = "statusStripStatistic";
			// 
			// toolStripStatusLabelSize
			// 
			toolStripStatusLabelSize.AccessibleDescription = "Gibt die Größe der Liste in Bytes an";
			toolStripStatusLabelSize.AccessibleName = "Größe der Liste";
			toolStripStatusLabelSize.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelSize.AutoToolTip = true;
			toolStripStatusLabelSize.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelSize.Name = "toolStripStatusLabelSize";
			toolStripStatusLabelSize.Size = new Size(43, 19);
			toolStripStatusLabelSize.Tag = "Größe";
			toolStripStatusLabelSize.Text = "Größe";
			toolStripStatusLabelSize.Click += ToolStripStatusLabelSize_Click;
			// 
			// toolStripStatusLabelLines
			// 
			toolStripStatusLabelLines.AccessibleDescription = "Gibt die Anzahl der Zeilen in der Liste an";
			toolStripStatusLabelLines.AccessibleName = "Anzahl der Zeilen in der Liste";
			toolStripStatusLabelLines.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelLines.AutoToolTip = true;
			toolStripStatusLabelLines.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelLines.Name = "toolStripStatusLabelLines";
			toolStripStatusLabelLines.Size = new Size(43, 19);
			toolStripStatusLabelLines.Tag = "Zeilen";
			toolStripStatusLabelLines.Text = "Zeilen";
			toolStripStatusLabelLines.Click += ToolStripStatusLabelLines_Click;
			// 
			// toolStripStatusLabelTimeSpan
			// 
			toolStripStatusLabelTimeSpan.AccessibleDescription = "Gibt die Dauer der Listengenerierung an";
			toolStripStatusLabelTimeSpan.AccessibleName = "Dauer der Listengenerierung";
			toolStripStatusLabelTimeSpan.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelTimeSpan.AutoToolTip = true;
			toolStripStatusLabelTimeSpan.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelTimeSpan.Name = "toolStripStatusLabelTimeSpan";
			toolStripStatusLabelTimeSpan.Size = new Size(42, 19);
			toolStripStatusLabelTimeSpan.Tag = "Dauer";
			toolStripStatusLabelTimeSpan.Text = "Dauer";
			toolStripStatusLabelTimeSpan.ToolTipText = "Dauer";
			toolStripStatusLabelTimeSpan.Click += ToolStripStatusLabelTimeSpan_Click;
			// 
			// toolStripStatusLabelLim
			// 
			toolStripStatusLabelLim.AccessibleDescription = "Zeigt den berechneten LIM an";
			toolStripStatusLabelLim.AccessibleName = "Berechneter LIM";
			toolStripStatusLabelLim.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelLim.AutoToolTip = true;
			toolStripStatusLabelLim.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelLim.Name = "toolStripStatusLabelLim";
			toolStripStatusLabelLim.Size = new Size(247, 19);
			toolStripStatusLabelLim.Spring = true;
			toolStripStatusLabelLim.Tag = "LIM";
			toolStripStatusLabelLim.Text = "LIM";
			toolStripStatusLabelLim.Click += ToolStripStatusLabelLim_Click;
			// 
			// toolStripSplitButtonStyle
			// 
			toolStripSplitButtonStyle.AccessibleDescription = "Aktiviert oder deaktiviert den visuellen Stil des Programms";
			toolStripSplitButtonStyle.AccessibleName = "Visuellen Stil de-/aktivieren";
			toolStripSplitButtonStyle.AccessibleRole = AccessibleRole.PushButton;
			toolStripSplitButtonStyle.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripSplitButtonStyle.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemActivateVisualStyle, toolStripMenuItemDeactivateVisualStyle });
			toolStripSplitButtonStyle.Image = Properties.Resources.application_grey;
			toolStripSplitButtonStyle.ImageTransparentColor = Color.Magenta;
			toolStripSplitButtonStyle.Name = "toolStripSplitButtonStyle";
			toolStripSplitButtonStyle.Size = new Size(32, 22);
			toolStripSplitButtonStyle.Text = "Visueller Stil";
			toolStripSplitButtonStyle.ButtonClick += ToolStripStatusLabelStyle_Click;
			// 
			// toolStripMenuItemActivateVisualStyle
			// 
			toolStripMenuItemActivateVisualStyle.AccessibleDescription = "Aktiviert den visuellen Stil des Programms";
			toolStripMenuItemActivateVisualStyle.AccessibleName = "Visuellen Stil aktivieren";
			toolStripMenuItemActivateVisualStyle.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemActivateVisualStyle.AutoToolTip = true;
			toolStripMenuItemActivateVisualStyle.Image = Properties.Resources.application;
			toolStripMenuItemActivateVisualStyle.Name = "toolStripMenuItemActivateVisualStyle";
			toolStripMenuItemActivateVisualStyle.Size = new Size(204, 22);
			toolStripMenuItemActivateVisualStyle.Text = "Visueller Stil &aktivieren";
			toolStripMenuItemActivateVisualStyle.ToolTipText = "Visueller Stil aktivieren";
			toolStripMenuItemActivateVisualStyle.Click += ToolStripMenuItemActivateVisualStyle_Click;
			// 
			// toolStripMenuItemDeactivateVisualStyle
			// 
			toolStripMenuItemDeactivateVisualStyle.AccessibleDescription = "Deaktiviert den visuellen Stil des Programms";
			toolStripMenuItemDeactivateVisualStyle.AccessibleName = "Visuellen Stil deaktivieren";
			toolStripMenuItemDeactivateVisualStyle.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemDeactivateVisualStyle.AutoToolTip = true;
			toolStripMenuItemDeactivateVisualStyle.Image = Properties.Resources.application_grey;
			toolStripMenuItemDeactivateVisualStyle.Name = "toolStripMenuItemDeactivateVisualStyle";
			toolStripMenuItemDeactivateVisualStyle.Size = new Size(204, 22);
			toolStripMenuItemDeactivateVisualStyle.Text = "Visueller Stil &deaktivieren";
			toolStripMenuItemDeactivateVisualStyle.ToolTipText = "Visueller Stil deaktivieren";
			toolStripMenuItemDeactivateVisualStyle.Click += ToolStripMenuItemDeactivateVisualStyle_Click;
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			// 
			// buttonSettings
			// 
			buttonSettings.AccessibleDescription = "Öffnet die Einstellungen";
			buttonSettings.AccessibleName = "Einstellungen";
			buttonSettings.AccessibleRole = AccessibleRole.PushButton;
			buttonSettings.AutoEllipsis = true;
			buttonSettings.Image = Properties.Resources.wrench_orange;
			buttonSettings.Location = new Point(89, 502);
			buttonSettings.Margin = new Padding(4, 3, 4, 3);
			buttonSettings.Name = "buttonSettings";
			buttonSettings.Size = new Size(115, 30);
			buttonSettings.TabIndex = 21;
			buttonSettings.Text = "Eins&tellungen";
			buttonSettings.TextAlign = ContentAlignment.MiddleRight;
			buttonSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSettings, "Öffnet die Einstellungen");
			buttonSettings.UseVisualStyleBackColor = true;
			buttonSettings.Click += ButtonSettings_Click;
			buttonSettings.Enter += SetStatusbar_Enter;
			buttonSettings.Leave += ClearStatusbar_Leave;
			buttonSettings.MouseEnter += SetStatusbar_Enter;
			buttonSettings.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStripInfo
			// 
			statusStripInfo.AccessibleDescription = "Statusbar für Informationstext";
			statusStripInfo.AccessibleName = "Statusbar";
			statusStripInfo.AccessibleRole = AccessibleRole.StatusBar;
			statusStripInfo.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation });
			statusStripInfo.Location = new Point(0, 539);
			statusStripInfo.Name = "statusStripInfo";
			statusStripInfo.ShowItemToolTips = true;
			statusStripInfo.Size = new Size(424, 22);
			statusStripInfo.SizingGrip = false;
			statusStripInfo.TabIndex = 24;
			statusStripInfo.TabStop = true;
			statusStripInfo.Text = "statusStripInfo";
			// 
			// toolStripStatusLabelInformation
			// 
			toolStripStatusLabelInformation.AccessibleDescription = "Zeigt Informationsstext an";
			toolStripStatusLabelInformation.AccessibleName = "Informationen";
			toolStripStatusLabelInformation.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelInformation.AutoToolTip = true;
			toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			toolStripStatusLabelInformation.Size = new Size(28, 17);
			toolStripStatusLabelInformation.Text = "info";
			// 
			// NumericListGeneratorForm
			// 
			AccessibleDescription = "Programmfenster";
			AccessibleName = "Programmfenster";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(424, 585);
			Controls.Add(statusStripInfo);
			Controls.Add(buttonRedo);
			Controls.Add(buttonSettings);
			Controls.Add(textBoxStringAfterNumber);
			Controls.Add(textBoxStringBeforeNumber);
			Controls.Add(statusStripStatistic);
			Controls.Add(buttonUndo);
			Controls.Add(labelResult);
			Controls.Add(buttonCreateList);
			Controls.Add(buttonInformationAboutApp);
			Controls.Add(buttonExitApp);
			Controls.Add(progressBar);
			Controls.Add(labelProcress);
			Controls.Add(textBoxList);
			Controls.Add(buttonDeleteList);
			Controls.Add(buttonSaveList);
			Controls.Add(buttonCopyList);
			Controls.Add(buttonAddToList);
			Controls.Add(checkBoxFillWithZeros);
			Controls.Add(numericUpDownNumberMaximum);
			Controls.Add(labelNumberMax);
			Controls.Add(numericUpDownNumberMinimum);
			Controls.Add(labelNumberMin);
			Controls.Add(labelStringAfterNumber);
			Controls.Add(labelStringBeforeNumber);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "NumericListGeneratorForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Numeric List Generator";
			Load += NumericListGeneratorForm_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMinimum).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMaximum).EndInit();
			statusStripStatistic.ResumeLayout(false);
			statusStripStatistic.PerformLayout();
			statusStripInfo.ResumeLayout(false);
			statusStripInfo.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelStringBeforeNumber;
		private Label labelStringAfterNumber;
		private Label labelNumberMin;
		private NumericUpDown numericUpDownNumberMinimum;
		private Label labelNumberMax;
		private NumericUpDown numericUpDownNumberMaximum;
		private CheckBox checkBoxFillWithZeros;
		private Button buttonAddToList;
		private Button buttonCopyList;
		private Button buttonSaveList;
		private Button buttonDeleteList;
		private TextBox textBoxList;
		private Label labelProcress;
		private ProgressBar progressBar;
		private Button buttonExitApp;
		private Button buttonInformationAboutApp;
		private Button buttonCreateList;
		private ToolTip toolTip;
		private Label labelResult;
		private Button buttonUndo;
		private StatusStrip statusStripStatistic;
		private ToolStripStatusLabel toolStripStatusLabelSize;
		private ToolStripStatusLabel toolStripStatusLabelLines;
		private ToolStripStatusLabel toolStripStatusLabelLim;
		private TextBox textBoxStringBeforeNumber;
		private TextBox textBoxStringAfterNumber;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private Button buttonSettings;
		private Button buttonRedo;
		private ToolStripStatusLabel toolStripStatusLabelTimeSpan;
		private ToolStripSplitButton toolStripSplitButtonStyle;
		private ToolStripMenuItem toolStripMenuItemActivateVisualStyle;
		private ToolStripMenuItem toolStripMenuItemDeactivateVisualStyle;
		private StatusStrip statusStripInfo;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
	}
}

