namespace Numeric_List_Generator
{
	partial class BatchForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchForm));
			buttonRedo = new Button();
			textBoxStringAfterNumber = new TextBox();
			textBoxStringBeforeNumber = new TextBox();
			buttonUndo = new Button();
			buttonCreateList = new Button();
			progressBar = new ProgressBar();
			labelProcress = new Label();
			buttonDeleteList = new Button();
			buttonSaveList = new Button();
			buttonCopyList = new Button();
			checkBoxFillWithZeros = new CheckBox();
			numericUpDownNumberMaximum = new NumericUpDown();
			labelNumberMax = new Label();
			numericUpDownNumberMinimum = new NumericUpDown();
			labelNumberMin = new Label();
			labelStringAfterNumber = new Label();
			labelStringBeforeNumber = new Label();
			listView1 = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			statusStripInfo = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			statusStripStatistic = new StatusStrip();
			toolStripStatusLabelSize = new ToolStripStatusLabel();
			toolStripStatusLabelLines = new ToolStripStatusLabel();
			toolStripStatusLabelTimeSpan = new ToolStripStatusLabel();
			toolStripStatusLabelLim = new ToolStripStatusLabel();
			toolStripSplitButtonStyle = new ToolStripSplitButton();
			toolStripMenuItemActivateVisualStyle = new ToolStripMenuItem();
			toolStripMenuItemDeactivateVisualStyle = new ToolStripMenuItem();
			button1 = new Button();
			backgroundWorker = new System.ComponentModel.BackgroundWorker();
			toolTip = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMaximum).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMinimum).BeginInit();
			statusStripInfo.SuspendLayout();
			statusStripStatistic.SuspendLayout();
			SuspendLayout();
			// 
			// buttonRedo
			// 
			buttonRedo.AccessibleDescription = "Verwirft die letzte rückgängig gemachte Änderung";
			buttonRedo.AccessibleName = "Letzte Änderung verwerfen";
			buttonRedo.AccessibleRole = AccessibleRole.PushButton;
			buttonRedo.AutoEllipsis = true;
			buttonRedo.Image = Properties.Resources.redo;
			buttonRedo.Location = new Point(218, 331);
			buttonRedo.Margin = new Padding(4, 3, 4, 3);
			buttonRedo.Name = "buttonRedo";
			buttonRedo.Size = new Size(64, 30);
			buttonRedo.TabIndex = 31;
			buttonRedo.Text = "&Redo";
			buttonRedo.TextAlign = ContentAlignment.MiddleRight;
			buttonRedo.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonRedo.UseVisualStyleBackColor = true;
			// 
			// textBoxStringAfterNumber
			// 
			textBoxStringAfterNumber.AccessibleDescription = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.AccessibleName = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.AccessibleRole = AccessibleRole.Text;
			textBoxStringAfterNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBoxStringAfterNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
			textBoxStringAfterNumber.Location = new Point(13, 125);
			textBoxStringAfterNumber.Margin = new Padding(4, 3, 4, 3);
			textBoxStringAfterNumber.Name = "textBoxStringAfterNumber";
			textBoxStringAfterNumber.PlaceholderText = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.Size = new Size(282, 23);
			textBoxStringAfterNumber.TabIndex = 26;
			textBoxStringAfterNumber.Text = ".jpg";
			// 
			// textBoxStringBeforeNumber
			// 
			textBoxStringBeforeNumber.AccessibleDescription = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.AccessibleName = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.AccessibleRole = AccessibleRole.Text;
			textBoxStringBeforeNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBoxStringBeforeNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
			textBoxStringBeforeNumber.Location = new Point(13, 28);
			textBoxStringBeforeNumber.Margin = new Padding(4, 3, 4, 3);
			textBoxStringBeforeNumber.Name = "textBoxStringBeforeNumber";
			textBoxStringBeforeNumber.PlaceholderText = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.Size = new Size(395, 23);
			textBoxStringBeforeNumber.TabIndex = 19;
			textBoxStringBeforeNumber.Text = "http://www.domain.com/files/picture";
			// 
			// buttonUndo
			// 
			buttonUndo.AccessibleDescription = "Macht die letzte Änderung rückgängig";
			buttonUndo.AccessibleName = "Änderung rückgängigmachen";
			buttonUndo.AccessibleRole = AccessibleRole.PushButton;
			buttonUndo.AutoEllipsis = true;
			buttonUndo.Image = (Image)resources.GetObject("buttonUndo.Image");
			buttonUndo.Location = new Point(146, 331);
			buttonUndo.Margin = new Padding(4, 3, 4, 3);
			buttonUndo.Name = "buttonUndo";
			buttonUndo.Size = new Size(64, 30);
			buttonUndo.TabIndex = 30;
			buttonUndo.Text = "&Undo";
			buttonUndo.TextAlign = ContentAlignment.MiddleRight;
			buttonUndo.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonUndo.UseVisualStyleBackColor = true;
			// 
			// buttonCreateList
			// 
			buttonCreateList.AccessibleDescription = "Erstellt eine neue Liste";
			buttonCreateList.AccessibleName = "Liste neu erstellen";
			buttonCreateList.AccessibleRole = AccessibleRole.PushButton;
			buttonCreateList.AutoEllipsis = true;
			buttonCreateList.Image = Properties.Resources.document_index;
			buttonCreateList.Location = new Point(13, 331);
			buttonCreateList.Margin = new Padding(4, 3, 4, 3);
			buttonCreateList.Name = "buttonCreateList";
			buttonCreateList.Size = new Size(125, 30);
			buttonCreateList.TabIndex = 27;
			buttonCreateList.Text = "Liste neu &erstellen";
			buttonCreateList.TextAlign = ContentAlignment.MiddleRight;
			buttonCreateList.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonCreateList.UseVisualStyleBackColor = true;
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Zeigt den laufenden Verarbeitungsstatus an";
			progressBar.AccessibleName = "Verarbeitungsstatus";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Location = new Point(97, 377);
			progressBar.Margin = new Padding(4, 3, 4, 3);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(310, 20);
			progressBar.Style = ProgressBarStyle.Continuous;
			progressBar.TabIndex = 35;
			// 
			// labelProcress
			// 
			labelProcress.AccessibleDescription = "Verarbeitung";
			labelProcress.AccessibleName = "Verarbeitung";
			labelProcress.AccessibleRole = AccessibleRole.StaticText;
			labelProcress.AutoEllipsis = true;
			labelProcress.AutoSize = true;
			labelProcress.Location = new Point(12, 377);
			labelProcress.Margin = new Padding(4, 0, 4, 0);
			labelProcress.Name = "labelProcress";
			labelProcress.Size = new Size(77, 15);
			labelProcress.TabIndex = 34;
			labelProcress.Text = "Verarbeitun&g:";
			// 
			// buttonDeleteList
			// 
			buttonDeleteList.AccessibleDescription = "Löscht die Liste";
			buttonDeleteList.AccessibleName = "Liste löschen";
			buttonDeleteList.AccessibleRole = AccessibleRole.PushButton;
			buttonDeleteList.AutoEllipsis = true;
			buttonDeleteList.Image = Properties.Resources.bin_empty;
			buttonDeleteList.Location = new Point(290, 331);
			buttonDeleteList.Margin = new Padding(4, 3, 4, 3);
			buttonDeleteList.Name = "buttonDeleteList";
			buttonDeleteList.Size = new Size(117, 30);
			buttonDeleteList.TabIndex = 29;
			buttonDeleteList.Text = "Liste &löschen";
			buttonDeleteList.TextAlign = ContentAlignment.MiddleRight;
			buttonDeleteList.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonDeleteList.UseVisualStyleBackColor = true;
			// 
			// buttonSaveList
			// 
			buttonSaveList.AccessibleDescription = "Speichert die Liste als Textdatei ab";
			buttonSaveList.AccessibleName = "Liste abspeichern";
			buttonSaveList.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveList.AutoEllipsis = true;
			buttonSaveList.Image = Properties.Resources.diskette;
			buttonSaveList.Location = new Point(142, 414);
			buttonSaveList.Margin = new Padding(4, 3, 4, 3);
			buttonSaveList.Name = "buttonSaveList";
			buttonSaveList.Size = new Size(120, 30);
			buttonSaveList.TabIndex = 33;
			buttonSaveList.Text = "Liste &speichern";
			buttonSaveList.TextAlign = ContentAlignment.MiddleRight;
			buttonSaveList.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonSaveList.UseVisualStyleBackColor = true;
			// 
			// buttonCopyList
			// 
			buttonCopyList.AccessibleDescription = "Kopiert die Liste in die Windows-Zwischenablage";
			buttonCopyList.AccessibleName = "Liste koperien";
			buttonCopyList.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyList.AutoEllipsis = true;
			buttonCopyList.Image = Properties.Resources.page_copy;
			buttonCopyList.Location = new Point(13, 414);
			buttonCopyList.Margin = new Padding(4, 3, 4, 3);
			buttonCopyList.Name = "buttonCopyList";
			buttonCopyList.Size = new Size(121, 30);
			buttonCopyList.TabIndex = 32;
			buttonCopyList.Text = "Liste &kopieren";
			buttonCopyList.TextAlign = ContentAlignment.MiddleRight;
			buttonCopyList.TextImageRelation = TextImageRelation.ImageBeforeText;
			buttonCopyList.UseVisualStyleBackColor = true;
			// 
			// checkBoxFillWithZeros
			// 
			checkBoxFillWithZeros.AccessibleDescription = "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen";
			checkBoxFillWithZeros.AccessibleName = "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen";
			checkBoxFillWithZeros.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxFillWithZeros.AutoSize = true;
			checkBoxFillWithZeros.Location = new Point(254, 68);
			checkBoxFillWithZeros.Margin = new Padding(4, 3, 4, 3);
			checkBoxFillWithZeros.Name = "checkBoxFillWithZeros";
			checkBoxFillWithZeros.Size = new Size(132, 19);
			checkBoxFillWithZeros.TabIndex = 24;
			checkBoxFillWithZeros.Text = "&mit Nullen auffüllen";
			checkBoxFillWithZeros.UseVisualStyleBackColor = true;
			// 
			// numericUpDownNumberMaximum
			// 
			numericUpDownNumberMaximum.AccessibleDescription = "Maximun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMaximum.AccessibleName = "Maximun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMaximum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownNumberMaximum.Location = new Point(182, 66);
			numericUpDownNumberMaximum.Margin = new Padding(4, 3, 4, 3);
			numericUpDownNumberMaximum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numericUpDownNumberMaximum.Name = "numericUpDownNumberMaximum";
			numericUpDownNumberMaximum.Size = new Size(57, 23);
			numericUpDownNumberMaximum.TabIndex = 23;
			numericUpDownNumberMaximum.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// labelNumberMax
			// 
			labelNumberMax.AccessibleDescription = "Zahlen Maximum";
			labelNumberMax.AccessibleName = "Zahlen Maximum";
			labelNumberMax.AccessibleRole = AccessibleRole.StaticText;
			labelNumberMax.AutoSize = true;
			labelNumberMax.Location = new Point(152, 68);
			labelNumberMax.Margin = new Padding(4, 0, 4, 0);
			labelNumberMax.Name = "labelNumberMax";
			labelNumberMax.Size = new Size(22, 15);
			labelNumberMax.TabIndex = 22;
			labelNumberMax.Text = "b&is";
			// 
			// numericUpDownNumberMinimum
			// 
			numericUpDownNumberMinimum.AccessibleDescription = "Minimun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMinimum.AccessibleName = "Minimun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMinimum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownNumberMinimum.Location = new Point(88, 66);
			numericUpDownNumberMinimum.Margin = new Padding(4, 3, 4, 3);
			numericUpDownNumberMinimum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numericUpDownNumberMinimum.Name = "numericUpDownNumberMinimum";
			numericUpDownNumberMinimum.Size = new Size(57, 23);
			numericUpDownNumberMinimum.TabIndex = 21;
			numericUpDownNumberMinimum.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// labelNumberMin
			// 
			labelNumberMin.AccessibleDescription = "Zahlen Minimum";
			labelNumberMin.AccessibleName = "Zahlen Minimum";
			labelNumberMin.AccessibleRole = AccessibleRole.StaticText;
			labelNumberMin.AutoEllipsis = true;
			labelNumberMin.AutoSize = true;
			labelNumberMin.Location = new Point(13, 68);
			labelNumberMin.Margin = new Padding(4, 0, 4, 0);
			labelNumberMin.Name = "labelNumberMin";
			labelNumberMin.Size = new Size(66, 15);
			labelNumberMin.TabIndex = 20;
			labelNumberMin.Text = "Zahlen v&on";
			// 
			// labelStringAfterNumber
			// 
			labelStringAfterNumber.AccessibleDescription = "Zeichenkette nach der Zahl";
			labelStringAfterNumber.AccessibleName = "Zeichenkette nach der Zahl";
			labelStringAfterNumber.AccessibleRole = AccessibleRole.StaticText;
			labelStringAfterNumber.AutoEllipsis = true;
			labelStringAfterNumber.AutoSize = true;
			labelStringAfterNumber.Location = new Point(13, 107);
			labelStringAfterNumber.Margin = new Padding(4, 0, 4, 0);
			labelStringAfterNumber.Name = "labelStringAfterNumber";
			labelStringAfterNumber.Size = new Size(153, 15);
			labelStringAfterNumber.TabIndex = 25;
			labelStringAfterNumber.Text = "Zeichenkette &nach der Zahl:";
			// 
			// labelStringBeforeNumber
			// 
			labelStringBeforeNumber.AccessibleDescription = "Zeichenkette vor der Zahl";
			labelStringBeforeNumber.AccessibleName = "Zeichenkette vor der Zahl";
			labelStringBeforeNumber.AccessibleRole = AccessibleRole.StaticText;
			labelStringBeforeNumber.AutoEllipsis = true;
			labelStringBeforeNumber.AutoSize = true;
			labelStringBeforeNumber.Location = new Point(13, 9);
			labelStringBeforeNumber.Margin = new Padding(4, 0, 4, 0);
			labelStringBeforeNumber.Name = "labelStringBeforeNumber";
			labelStringBeforeNumber.Size = new Size(144, 15);
			labelStringBeforeNumber.TabIndex = 18;
			labelStringBeforeNumber.Text = "Zeichenkette &vor der Zahl:";
			// 
			// listView1
			// 
			listView1.Activation = ItemActivation.OneClick;
			listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			listView1.FullRowSelect = true;
			listView1.GridLines = true;
			listView1.HoverSelection = true;
			listView1.Location = new Point(12, 165);
			listView1.Name = "listView1";
			listView1.ShowItemToolTips = true;
			listView1.Size = new Size(395, 145);
			listView1.TabIndex = 36;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Zeichenkette davor";
			columnHeader1.Width = 180;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Zahl Min.";
			columnHeader2.Width = 65;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Zahl Max.";
			columnHeader3.Width = 65;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Zeichenkette danach";
			columnHeader4.Width = 180;
			// 
			// statusStripInfo
			// 
			statusStripInfo.AccessibleDescription = "Statusbar für Informationstext";
			statusStripInfo.AccessibleName = "Statusbar";
			statusStripInfo.AccessibleRole = AccessibleRole.StatusBar;
			statusStripInfo.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation });
			statusStripInfo.Location = new Point(0, 460);
			statusStripInfo.Name = "statusStripInfo";
			statusStripInfo.ShowItemToolTips = true;
			statusStripInfo.Size = new Size(422, 22);
			statusStripInfo.SizingGrip = false;
			statusStripInfo.TabIndex = 38;
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
			// statusStripStatistic
			// 
			statusStripStatistic.AccessibleDescription = "Statusbar für statistische Angaben";
			statusStripStatistic.AccessibleName = "Statusbar";
			statusStripStatistic.AccessibleRole = AccessibleRole.StatusBar;
			statusStripStatistic.AllowItemReorder = true;
			statusStripStatistic.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelSize, toolStripStatusLabelLines, toolStripStatusLabelTimeSpan, toolStripStatusLabelLim, toolStripSplitButtonStyle });
			statusStripStatistic.Location = new Point(0, 482);
			statusStripStatistic.Name = "statusStripStatistic";
			statusStripStatistic.Padding = new Padding(1, 0, 16, 0);
			statusStripStatistic.ShowItemToolTips = true;
			statusStripStatistic.Size = new Size(422, 24);
			statusStripStatistic.SizingGrip = false;
			statusStripStatistic.TabIndex = 37;
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
			// 
			// toolStripStatusLabelLim
			// 
			toolStripStatusLabelLim.AccessibleDescription = "Zeigt den berechneten LIM an";
			toolStripStatusLabelLim.AccessibleName = "Berechneter LIM";
			toolStripStatusLabelLim.AccessibleRole = AccessibleRole.StaticText;
			toolStripStatusLabelLim.AutoToolTip = true;
			toolStripStatusLabelLim.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelLim.Name = "toolStripStatusLabelLim";
			toolStripStatusLabelLim.Size = new Size(245, 19);
			toolStripStatusLabelLim.Spring = true;
			toolStripStatusLabelLim.Tag = "LIM";
			toolStripStatusLabelLim.Text = "LIM";
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
			// 
			// button1
			// 
			button1.AccessibleDescription = "Fügt die Einträge an der vorhandenen Liste an";
			button1.AccessibleName = "Liste anfügen";
			button1.AccessibleRole = AccessibleRole.PushButton;
			button1.AutoEllipsis = true;
			button1.Image = Properties.Resources.add;
			button1.Location = new Point(302, 125);
			button1.Margin = new Padding(4, 3, 4, 3);
			button1.Name = "button1";
			button1.Size = new Size(106, 23);
			button1.TabIndex = 39;
			button1.Text = "&Anfügen";
			button1.TextAlign = ContentAlignment.MiddleRight;
			button1.TextImageRelation = TextImageRelation.ImageBeforeText;
			button1.UseVisualStyleBackColor = true;
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			// 
			// BatchForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(422, 506);
			Controls.Add(button1);
			Controls.Add(statusStripInfo);
			Controls.Add(statusStripStatistic);
			Controls.Add(listView1);
			Controls.Add(buttonRedo);
			Controls.Add(textBoxStringAfterNumber);
			Controls.Add(textBoxStringBeforeNumber);
			Controls.Add(buttonUndo);
			Controls.Add(buttonCreateList);
			Controls.Add(progressBar);
			Controls.Add(labelProcress);
			Controls.Add(buttonDeleteList);
			Controls.Add(buttonSaveList);
			Controls.Add(buttonCopyList);
			Controls.Add(checkBoxFillWithZeros);
			Controls.Add(numericUpDownNumberMaximum);
			Controls.Add(labelNumberMax);
			Controls.Add(numericUpDownNumberMinimum);
			Controls.Add(labelNumberMin);
			Controls.Add(labelStringAfterNumber);
			Controls.Add(labelStringBeforeNumber);
			Name = "BatchForm";
			Text = "BatchForm";
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMaximum).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownNumberMinimum).EndInit();
			statusStripInfo.ResumeLayout(false);
			statusStripInfo.PerformLayout();
			statusStripStatistic.ResumeLayout(false);
			statusStripStatistic.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonRedo;
		private TextBox textBoxStringAfterNumber;
		private TextBox textBoxStringBeforeNumber;
		private Button buttonUndo;
		private Button buttonCreateList;
		private ProgressBar progressBar;
		private Label labelProcress;
		private Button buttonDeleteList;
		private Button buttonSaveList;
		private Button buttonCopyList;
		private CheckBox checkBoxFillWithZeros;
		private NumericUpDown numericUpDownNumberMaximum;
		private Label labelNumberMax;
		private NumericUpDown numericUpDownNumberMinimum;
		private Label labelNumberMin;
		private Label labelStringAfterNumber;
		private Label labelStringBeforeNumber;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private StatusStrip statusStripInfo;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private StatusStrip statusStripStatistic;
		private ToolStripStatusLabel toolStripStatusLabelSize;
		private ToolStripStatusLabel toolStripStatusLabelLines;
		private ToolStripStatusLabel toolStripStatusLabelTimeSpan;
		private ToolStripStatusLabel toolStripStatusLabelLim;
		private ToolStripSplitButton toolStripSplitButtonStyle;
		private ToolStripMenuItem toolStripMenuItemActivateVisualStyle;
		private ToolStripMenuItem toolStripMenuItemDeactivateVisualStyle;
		private Button button1;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private ToolTip toolTip;
	}
}