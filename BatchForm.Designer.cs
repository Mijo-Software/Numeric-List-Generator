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
			labelProgess = new Label();
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
			listView = new ListView();
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
			buttonAddToList = new Button();
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
			buttonRedo.Location = new Point(345, 125);
			buttonRedo.Margin = new Padding(4, 3, 4, 3);
			buttonRedo.Name = "buttonRedo";
			buttonRedo.Size = new Size(64, 23);
			buttonRedo.TabIndex = 11;
			buttonRedo.Text = "&Redo";
			buttonRedo.TextAlign = ContentAlignment.MiddleRight;
			buttonRedo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonRedo, "Letzte Änderung verwerfen");
			buttonRedo.UseVisualStyleBackColor = true;
			buttonRedo.Click += ButtonRedo_Click;
			buttonRedo.Enter += SetStatusbar_Enter;
			buttonRedo.Leave += ClearStatusbar_Leave;
			buttonRedo.MouseEnter += SetStatusbar_Enter;
			buttonRedo.MouseLeave += ClearStatusbar_Leave;
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
			textBoxStringAfterNumber.Size = new Size(153, 23);
			textBoxStringAfterNumber.TabIndex = 8;
			textBoxStringAfterNumber.Text = ".jpg";
			toolTip.SetToolTip(textBoxStringAfterNumber, "Eingabe des Textes nach der Zahlenangabe");
			textBoxStringAfterNumber.Enter += SetStatusbar_Enter;
			textBoxStringAfterNumber.Leave += ClearStatusbar_Leave;
			textBoxStringAfterNumber.MouseEnter += SetStatusbar_Enter;
			textBoxStringAfterNumber.MouseLeave += ClearStatusbar_Leave;
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
			textBoxStringBeforeNumber.TabIndex = 1;
			textBoxStringBeforeNumber.Text = "http://www.domain.com/files/picture";
			toolTip.SetToolTip(textBoxStringBeforeNumber, "Eingabe des Textes vor der Zahlenangabe");
			textBoxStringBeforeNumber.Enter += SetStatusbar_Enter;
			textBoxStringBeforeNumber.Leave += ClearStatusbar_Leave;
			textBoxStringBeforeNumber.MouseEnter += SetStatusbar_Enter;
			textBoxStringBeforeNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonUndo
			// 
			buttonUndo.AccessibleDescription = "Macht die letzte Änderung rückgängig";
			buttonUndo.AccessibleName = "Änderung rückgängigmachen";
			buttonUndo.AccessibleRole = AccessibleRole.PushButton;
			buttonUndo.AutoEllipsis = true;
			buttonUndo.Image = (Image)resources.GetObject("buttonUndo.Image");
			buttonUndo.Location = new Point(273, 125);
			buttonUndo.Margin = new Padding(4, 3, 4, 3);
			buttonUndo.Name = "buttonUndo";
			buttonUndo.Size = new Size(64, 23);
			buttonUndo.TabIndex = 10;
			buttonUndo.Text = "&Undo";
			buttonUndo.TextAlign = ContentAlignment.MiddleRight;
			buttonUndo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonUndo, "Änderung rückgängigmachen");
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
			buttonCreateList.Location = new Point(13, 331);
			buttonCreateList.Margin = new Padding(4, 3, 4, 3);
			buttonCreateList.Name = "buttonCreateList";
			buttonCreateList.Size = new Size(101, 30);
			buttonCreateList.TabIndex = 13;
			buttonCreateList.Text = "Neu &erstellen";
			buttonCreateList.TextAlign = ContentAlignment.MiddleRight;
			buttonCreateList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCreateList, "Liste neu erstellen");
			buttonCreateList.UseVisualStyleBackColor = true;
			buttonCreateList.Click += ButtonCreateList_Click;
			buttonCreateList.Enter += SetStatusbar_Enter;
			buttonCreateList.Leave += ClearStatusbar_Leave;
			buttonCreateList.MouseEnter += SetStatusbar_Enter;
			buttonCreateList.MouseLeave += ClearStatusbar_Leave;
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
			progressBar.TabIndex = 18;
			toolTip.SetToolTip(progressBar, "Zeigt den laufenden Verarbeitungsstatus an");
			progressBar.MouseEnter += SetStatusbar_Enter;
			progressBar.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelProgess
			// 
			labelProgess.AccessibleDescription = "Verarbeitung";
			labelProgess.AccessibleName = "Verarbeitung";
			labelProgess.AccessibleRole = AccessibleRole.StaticText;
			labelProgess.AutoEllipsis = true;
			labelProgess.AutoSize = true;
			labelProgess.Location = new Point(12, 377);
			labelProgess.Margin = new Padding(4, 0, 4, 0);
			labelProgess.Name = "labelProgess";
			labelProgess.Size = new Size(77, 15);
			labelProgess.TabIndex = 17;
			labelProgess.Text = "Verarbeitun&g:";
			toolTip.SetToolTip(labelProgess, "Verarbeitung");
			labelProgess.Enter += SetStatusbar_Enter;
			labelProgess.Leave += ClearStatusbar_Leave;
			labelProgess.MouseEnter += SetStatusbar_Enter;
			labelProgess.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonDeleteList
			// 
			buttonDeleteList.AccessibleDescription = "Löscht die Liste";
			buttonDeleteList.AccessibleName = "Liste löschen";
			buttonDeleteList.AccessibleRole = AccessibleRole.PushButton;
			buttonDeleteList.AutoEllipsis = true;
			buttonDeleteList.Image = Properties.Resources.bin_empty;
			buttonDeleteList.Location = new Point(122, 331);
			buttonDeleteList.Margin = new Padding(4, 3, 4, 3);
			buttonDeleteList.Name = "buttonDeleteList";
			buttonDeleteList.Size = new Size(77, 30);
			buttonDeleteList.TabIndex = 14;
			buttonDeleteList.Text = "&Löschen";
			buttonDeleteList.TextAlign = ContentAlignment.MiddleRight;
			buttonDeleteList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonDeleteList, "Liste löschen");
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
			buttonSaveList.Location = new Point(294, 331);
			buttonSaveList.Margin = new Padding(4, 3, 4, 3);
			buttonSaveList.Name = "buttonSaveList";
			buttonSaveList.Size = new Size(83, 30);
			buttonSaveList.TabIndex = 16;
			buttonSaveList.Text = "&Speichern";
			buttonSaveList.TextAlign = ContentAlignment.MiddleRight;
			buttonSaveList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveList, "Liste abspeichern");
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
			buttonCopyList.AccessibleName = "Liste kopieren";
			buttonCopyList.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyList.AutoEllipsis = true;
			buttonCopyList.Image = Properties.Resources.page_copy;
			buttonCopyList.Location = new Point(207, 331);
			buttonCopyList.Margin = new Padding(4, 3, 4, 3);
			buttonCopyList.Name = "buttonCopyList";
			buttonCopyList.Size = new Size(79, 30);
			buttonCopyList.TabIndex = 15;
			buttonCopyList.Text = "&Kopieren";
			buttonCopyList.TextAlign = ContentAlignment.MiddleRight;
			buttonCopyList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopyList, "Liste kopieren");
			buttonCopyList.UseVisualStyleBackColor = true;
			buttonCopyList.Click += ButtonCopyList_Click;
			buttonCopyList.Enter += SetStatusbar_Enter;
			buttonCopyList.Leave += ClearStatusbar_Leave;
			buttonCopyList.MouseEnter += SetStatusbar_Enter;
			buttonCopyList.MouseLeave += ClearStatusbar_Leave;
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
			checkBoxFillWithZeros.TabIndex = 6;
			checkBoxFillWithZeros.Text = "&mit Nullen auffüllen";
			toolTip.SetToolTip(checkBoxFillWithZeros, "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen");
			checkBoxFillWithZeros.UseVisualStyleBackColor = true;
			checkBoxFillWithZeros.Enter += SetStatusbar_Enter;
			checkBoxFillWithZeros.Leave += ClearStatusbar_Leave;
			checkBoxFillWithZeros.MouseEnter += SetStatusbar_Enter;
			checkBoxFillWithZeros.MouseLeave += ClearStatusbar_Leave;
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
			numericUpDownNumberMaximum.TabIndex = 5;
			toolTip.SetToolTip(numericUpDownNumberMaximum, "Maximun der Zahl, mit der die Einträge erstellt werden sollen");
			numericUpDownNumberMaximum.Value = new decimal(new int[] { 10, 0, 0, 0 });
			numericUpDownNumberMaximum.Enter += SetStatusbar_Enter;
			numericUpDownNumberMaximum.Leave += ClearStatusbar_Leave;
			// 
			// labelNumberMax
			// 
			labelNumberMax.AccessibleDescription = "Zahlen Maximum";
			labelNumberMax.AccessibleName = "Zahlen Maximum";
			labelNumberMax.AccessibleRole = AccessibleRole.StaticText;
			labelNumberMax.AutoEllipsis = true;
			labelNumberMax.AutoSize = true;
			labelNumberMax.Location = new Point(152, 68);
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
			numericUpDownNumberMinimum.TabIndex = 3;
			toolTip.SetToolTip(numericUpDownNumberMinimum, "Minimun der Zahl, mit der die Einträge erstellt werden sollen");
			numericUpDownNumberMinimum.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownNumberMinimum.Enter += SetStatusbar_Enter;
			numericUpDownNumberMinimum.Leave += ClearStatusbar_Leave;
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
			labelNumberMin.TabIndex = 2;
			labelNumberMin.Text = "Zahlen v&on";
			toolTip.SetToolTip(labelNumberMin, "Zahlen Minimum");
			labelNumberMin.Enter += SetStatusbar_Enter;
			labelNumberMin.Leave += ClearStatusbar_Leave;
			labelNumberMin.MouseEnter += SetStatusbar_Enter;
			labelNumberMin.MouseLeave += ClearStatusbar_Leave;
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
			labelStringAfterNumber.TabIndex = 7;
			labelStringAfterNumber.Text = "Zeichenkette &nach der Zahl:";
			toolTip.SetToolTip(labelStringAfterNumber, "Zeichenkette nach der Zahl");
			labelStringAfterNumber.Enter += SetStatusbar_Enter;
			labelStringAfterNumber.Leave += ClearStatusbar_Leave;
			labelStringAfterNumber.MouseEnter += SetStatusbar_Enter;
			labelStringAfterNumber.MouseLeave += ClearStatusbar_Leave;
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
			labelStringBeforeNumber.TabIndex = 0;
			labelStringBeforeNumber.Text = "Zeichenkette &vor der Zahl:";
			toolTip.SetToolTip(labelStringBeforeNumber, "Zeichenkette vor der Zahl");
			labelStringBeforeNumber.Enter += SetStatusbar_Enter;
			labelStringBeforeNumber.Leave += ClearStatusbar_Leave;
			labelStringBeforeNumber.MouseEnter += SetStatusbar_Enter;
			labelStringBeforeNumber.MouseLeave += ClearStatusbar_Leave;
			// 
			// listView
			// 
			listView.Activation = ItemActivation.OneClick;
			listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.HoverSelection = true;
			listView.Location = new Point(13, 165);
			listView.Name = "listView";
			listView.ShowItemToolTips = true;
			listView.Size = new Size(396, 145);
			listView.TabIndex = 12;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = View.Details;
			listView.Enter += SetStatusbar_Enter;
			listView.Leave += ClearStatusbar_Leave;
			listView.MouseEnter += SetStatusbar_Enter;
			listView.MouseLeave += ClearStatusbar_Leave;
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
			statusStripInfo.Location = new Point(0, 410);
			statusStripInfo.Name = "statusStripInfo";
			statusStripInfo.ShowItemToolTips = true;
			statusStripInfo.Size = new Size(422, 22);
			statusStripInfo.SizingGrip = false;
			statusStripInfo.TabIndex = 19;
			statusStripInfo.TabStop = true;
			statusStripInfo.Text = "statusStripInfo";
			toolTip.SetToolTip(statusStripInfo, "Statusbar für Informationstext");
			statusStripInfo.Enter += SetStatusbar_Enter;
			statusStripInfo.Leave += ClearStatusbar_Leave;
			statusStripInfo.MouseEnter += SetStatusbar_Enter;
			statusStripInfo.MouseLeave += ClearStatusbar_Leave;
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
			toolStripStatusLabelInformation.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelInformation.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStripStatistic
			// 
			statusStripStatistic.AccessibleDescription = "Statusbar für statistische Angaben";
			statusStripStatistic.AccessibleName = "Statusbar";
			statusStripStatistic.AccessibleRole = AccessibleRole.StatusBar;
			statusStripStatistic.AllowItemReorder = true;
			statusStripStatistic.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelSize, toolStripStatusLabelLines, toolStripStatusLabelTimeSpan, toolStripStatusLabelLim, toolStripSplitButtonStyle });
			statusStripStatistic.Location = new Point(0, 432);
			statusStripStatistic.Name = "statusStripStatistic";
			statusStripStatistic.Padding = new Padding(1, 0, 16, 0);
			statusStripStatistic.ShowItemToolTips = true;
			statusStripStatistic.Size = new Size(422, 24);
			statusStripStatistic.SizingGrip = false;
			statusStripStatistic.TabIndex = 20;
			statusStripStatistic.TabStop = true;
			statusStripStatistic.Text = "statusStripStatistic";
			toolTip.SetToolTip(statusStripStatistic, "Statusbar für statistische Angaben");
			statusStripStatistic.Enter += SetStatusbar_Enter;
			statusStripStatistic.Leave += ClearStatusbar_Leave;
			statusStripStatistic.MouseEnter += SetStatusbar_Enter;
			statusStripStatistic.MouseLeave += ClearStatusbar_Leave;
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
			toolStripStatusLabelSize.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelSize.MouseLeave += ClearStatusbar_Leave;
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
			toolStripStatusLabelLines.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelLines.MouseLeave += ClearStatusbar_Leave;
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
			toolStripStatusLabelTimeSpan.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelTimeSpan.MouseLeave += ClearStatusbar_Leave;
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
			toolStripStatusLabelLim.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelLim.MouseLeave += ClearStatusbar_Leave;
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
			toolStripSplitButtonStyle.MouseEnter += SetStatusbar_Enter;
			toolStripSplitButtonStyle.MouseLeave += ClearStatusbar_Leave;
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
			toolStripMenuItemActivateVisualStyle.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemActivateVisualStyle.MouseLeave += ClearStatusbar_Leave;
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
			toolStripMenuItemDeactivateVisualStyle.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemDeactivateVisualStyle.MouseLeave += ClearStatusbar_Leave;
			// 
			// buttonAddToList
			// 
			buttonAddToList.AccessibleDescription = "Fügt die Einträge an der vorhandenen Liste an";
			buttonAddToList.AccessibleName = "Liste anfügen";
			buttonAddToList.AccessibleRole = AccessibleRole.PushButton;
			buttonAddToList.AutoEllipsis = true;
			buttonAddToList.Image = Properties.Resources.add;
			buttonAddToList.Location = new Point(177, 125);
			buttonAddToList.Margin = new Padding(4, 3, 4, 3);
			buttonAddToList.Name = "buttonAddToList";
			buttonAddToList.Size = new Size(88, 23);
			buttonAddToList.TabIndex = 9;
			buttonAddToList.Text = "&Anfügen";
			buttonAddToList.TextAlign = ContentAlignment.MiddleRight;
			buttonAddToList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonAddToList, "Liste anfügen");
			buttonAddToList.UseVisualStyleBackColor = true;
			buttonAddToList.Click += ButtonAddToList_Click;
			buttonAddToList.Enter += SetStatusbar_Enter;
			buttonAddToList.Leave += ClearStatusbar_Leave;
			buttonAddToList.MouseEnter += SetStatusbar_Enter;
			buttonAddToList.MouseLeave += ClearStatusbar_Leave;
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
			ClientSize = new Size(422, 456);
			Controls.Add(buttonAddToList);
			Controls.Add(statusStripInfo);
			Controls.Add(statusStripStatistic);
			Controls.Add(listView);
			Controls.Add(buttonRedo);
			Controls.Add(textBoxStringAfterNumber);
			Controls.Add(textBoxStringBeforeNumber);
			Controls.Add(buttonUndo);
			Controls.Add(buttonCreateList);
			Controls.Add(progressBar);
			Controls.Add(labelProgess);
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
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "BatchForm";
			Text = "Stapelverarbeitung";
			Load += BatchForm_Load;
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
		private Label labelProgess;
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
		private ListView listView;
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
		private Button buttonAddToList;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private ToolTip toolTip;
		private ToolStripSplitButton toolStripSplitButtonStyle;
		private ToolStripMenuItem toolStripMenuItemActivateVisualStyle;
		private ToolStripMenuItem toolStripMenuItemDeactivateVisualStyle;
	}
}