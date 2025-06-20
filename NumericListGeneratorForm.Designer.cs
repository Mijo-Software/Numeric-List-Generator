﻿using System.ComponentModel;
using Numeric_List_Generator.Properties;

namespace Numeric_List_Generator
{
	partial class NumericListGeneratorForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private IContainer components = null;

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
			components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(NumericListGeneratorForm));
			labelStringBeforeNumber = new Label();
			labelStringAfterNumber = new Label();
			labelNumberMin = new Label();
			numericUpDownNumberMinimum = new NumericUpDown();
			labelNumberMax = new Label();
			numericUpDownNumberMaximum = new NumericUpDown();
			checkBoxFillWithZeros = new CheckBox();
			textBoxList = new TextBox();
			labelProgress = new Label();
			progressBar = new ProgressBar();
			toolTip = new ToolTip(components);
			textBoxStringBeforeNumber = new TextBox();
			textBoxStringAfterNumber = new TextBox();
			buttonRedo = new Button();
			buttonUndo = new Button();
			buttonCreateList = new Button();
			buttonDeleteList = new Button();
			buttonSaveList = new Button();
			buttonCopyList = new Button();
			buttonAddToList = new Button();
			labelResult = new Label();
			statusStripStatistic = new StatusStrip();
			toolStripStatusLabelSize = new ToolStripStatusLabel();
			toolStripStatusLabelLines = new ToolStripStatusLabel();
			toolStripStatusLabelTimeSpan = new ToolStripStatusLabel();
			statusStripInfo = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			menuStrip = new MenuStrip();
			toolStripMenuItemProgram = new ToolStripMenuItem();
			toolStripMenuItemInfo = new ToolStripMenuItem();
			toolStripMenuItemLicense = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripMenuItemExit = new ToolStripMenuItem();
			toolStripMenuItemList = new ToolStripMenuItem();
			toolStripMenuItemBatch = new ToolStripMenuItem();
			toolStripSeparator4 = new ToolStripSeparator();
			toolStripMenuItemListCreate = new ToolStripMenuItem();
			toolStripMenuItemListAdd = new ToolStripMenuItem();
			toolStripMenuItemListDelete = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripMenuItemListUndo = new ToolStripMenuItem();
			toolStripMenuItemListRedo = new ToolStripMenuItem();
			toolStripSeparator3 = new ToolStripSeparator();
			toolStripMenuItemListCopy = new ToolStripMenuItem();
			toolStripMenuItemListSave = new ToolStripMenuItem();
			toolStripMenuItemSettings = new ToolStripMenuItem();
			toolStripMenuItemSettingsStayOnTop = new ToolStripMenuItem();
			toolStripMenuItemSettingsDisableVisualStyle = new ToolStripMenuItem();
			buttonCancelProgress = new Button();
			toolStripContainer = new ToolStripContainer();
			backgroundWorker = new BackgroundWorker();
			((ISupportInitialize)numericUpDownNumberMinimum).BeginInit();
			((ISupportInitialize)numericUpDownNumberMaximum).BeginInit();
			statusStripStatistic.SuspendLayout();
			statusStripInfo.SuspendLayout();
			menuStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.TopToolStripPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// labelStringBeforeNumber
			// 
			labelStringBeforeNumber.AccessibleDescription = "Zeichenkette vor der Zahl";
			labelStringBeforeNumber.AccessibleName = "Zeichenkette vor der Zahl";
			labelStringBeforeNumber.AccessibleRole = AccessibleRole.StaticText;
			labelStringBeforeNumber.AutoEllipsis = true;
			labelStringBeforeNumber.AutoSize = true;
			labelStringBeforeNumber.Location = new Point(13, 12);
			labelStringBeforeNumber.Margin = new Padding(4, 0, 4, 0);
			labelStringBeforeNumber.Name = "labelStringBeforeNumber";
			labelStringBeforeNumber.Size = new Size(144, 15);
			labelStringBeforeNumber.TabIndex = 0;
			labelStringBeforeNumber.Text = "Zeichenkette &vor der Zahl:";
			toolTip.SetToolTip(labelStringBeforeNumber, "Zeichenkette vor der Zahl");
			labelStringBeforeNumber.Enter += SetStatusBar_Enter;
			labelStringBeforeNumber.Leave += ClearStatusBar_Leave;
			labelStringBeforeNumber.MouseEnter += SetStatusBar_Enter;
			labelStringBeforeNumber.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelStringAfterNumber
			// 
			labelStringAfterNumber.AccessibleDescription = "Zeichenkette nach der Zahl";
			labelStringAfterNumber.AccessibleName = "Zeichenkette nach der Zahl";
			labelStringAfterNumber.AccessibleRole = AccessibleRole.StaticText;
			labelStringAfterNumber.AutoEllipsis = true;
			labelStringAfterNumber.AutoSize = true;
			labelStringAfterNumber.Location = new Point(13, 109);
			labelStringAfterNumber.Margin = new Padding(4, 0, 4, 0);
			labelStringAfterNumber.Name = "labelStringAfterNumber";
			labelStringAfterNumber.Size = new Size(153, 15);
			labelStringAfterNumber.TabIndex = 7;
			labelStringAfterNumber.Text = "Zeichenkette &nach der Zahl:";
			toolTip.SetToolTip(labelStringAfterNumber, "Zeichenkette nach der Zahl");
			labelStringAfterNumber.Enter += SetStatusBar_Enter;
			labelStringAfterNumber.Leave += ClearStatusBar_Leave;
			labelStringAfterNumber.MouseEnter += SetStatusBar_Enter;
			labelStringAfterNumber.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelNumberMin
			// 
			labelNumberMin.AccessibleDescription = "Zahlen Minimum";
			labelNumberMin.AccessibleName = "Zahlen Minimum";
			labelNumberMin.AccessibleRole = AccessibleRole.StaticText;
			labelNumberMin.AutoEllipsis = true;
			labelNumberMin.AutoSize = true;
			labelNumberMin.Location = new Point(13, 70);
			labelNumberMin.Margin = new Padding(4, 0, 4, 0);
			labelNumberMin.Name = "labelNumberMin";
			labelNumberMin.Size = new Size(66, 15);
			labelNumberMin.TabIndex = 2;
			labelNumberMin.Text = "Zahlen v&on";
			toolTip.SetToolTip(labelNumberMin, "Zahlen Minimum");
			labelNumberMin.Enter += SetStatusBar_Enter;
			labelNumberMin.Leave += ClearStatusBar_Leave;
			labelNumberMin.MouseEnter += SetStatusBar_Enter;
			labelNumberMin.MouseLeave += ClearStatusBar_Leave;
			// 
			// numericUpDownNumberMinimum
			// 
			numericUpDownNumberMinimum.AccessibleDescription = "Minimun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMinimum.AccessibleName = "Minimun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMinimum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownNumberMinimum.Location = new Point(88, 68);
			numericUpDownNumberMinimum.Margin = new Padding(4, 3, 4, 3);
			numericUpDownNumberMinimum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numericUpDownNumberMinimum.Name = "numericUpDownNumberMinimum";
			numericUpDownNumberMinimum.Size = new Size(57, 23);
			numericUpDownNumberMinimum.TabIndex = 3;
			toolTip.SetToolTip(numericUpDownNumberMinimum, "Minimun der Zahl, mit der die Einträge erstellt werden sollen");
			numericUpDownNumberMinimum.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownNumberMinimum.Enter += SetStatusBar_Enter;
			numericUpDownNumberMinimum.Leave += ClearStatusBar_Leave;
			// 
			// labelNumberMax
			// 
			labelNumberMax.AccessibleDescription = "Zahlen Maximum";
			labelNumberMax.AccessibleName = "Zahlen Maximum";
			labelNumberMax.AccessibleRole = AccessibleRole.StaticText;
			labelNumberMax.AutoEllipsis = true;
			labelNumberMax.AutoSize = true;
			labelNumberMax.Location = new Point(152, 70);
			labelNumberMax.Margin = new Padding(4, 0, 4, 0);
			labelNumberMax.Name = "labelNumberMax";
			labelNumberMax.Size = new Size(22, 15);
			labelNumberMax.TabIndex = 4;
			labelNumberMax.Text = "b&is";
			toolTip.SetToolTip(labelNumberMax, "Zahlen Maximum");
			labelNumberMax.Enter += SetStatusBar_Enter;
			labelNumberMax.Leave += ClearStatusBar_Leave;
			labelNumberMax.MouseEnter += SetStatusBar_Enter;
			labelNumberMax.MouseLeave += ClearStatusBar_Leave;
			// 
			// numericUpDownNumberMaximum
			// 
			numericUpDownNumberMaximum.AccessibleDescription = "Maximun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMaximum.AccessibleName = "Maximun der Zahl, mit der die Einträge erstellt werden sollen";
			numericUpDownNumberMaximum.AccessibleRole = AccessibleRole.SpinButton;
			numericUpDownNumberMaximum.Location = new Point(182, 68);
			numericUpDownNumberMaximum.Margin = new Padding(4, 3, 4, 3);
			numericUpDownNumberMaximum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
			numericUpDownNumberMaximum.Name = "numericUpDownNumberMaximum";
			numericUpDownNumberMaximum.Size = new Size(57, 23);
			numericUpDownNumberMaximum.TabIndex = 5;
			toolTip.SetToolTip(numericUpDownNumberMaximum, "Maximun der Zahl, mit der die Einträge erstellt werden sollen");
			numericUpDownNumberMaximum.Value = new decimal(new int[] { 10, 0, 0, 0 });
			numericUpDownNumberMaximum.Enter += SetStatusBar_Enter;
			numericUpDownNumberMaximum.Leave += ClearStatusBar_Leave;
			// 
			// checkBoxFillWithZeros
			// 
			checkBoxFillWithZeros.AccessibleDescription = "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen";
			checkBoxFillWithZeros.AccessibleName = "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen";
			checkBoxFillWithZeros.AccessibleRole = AccessibleRole.CheckButton;
			checkBoxFillWithZeros.AutoSize = true;
			checkBoxFillWithZeros.Location = new Point(254, 70);
			checkBoxFillWithZeros.Margin = new Padding(4, 3, 4, 3);
			checkBoxFillWithZeros.Name = "checkBoxFillWithZeros";
			checkBoxFillWithZeros.Size = new Size(132, 19);
			checkBoxFillWithZeros.TabIndex = 6;
			checkBoxFillWithZeros.Text = "&mit Nullen auffüllen";
			toolTip.SetToolTip(checkBoxFillWithZeros, "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen");
			checkBoxFillWithZeros.UseVisualStyleBackColor = true;
			checkBoxFillWithZeros.Enter += SetStatusBar_Enter;
			checkBoxFillWithZeros.Leave += ClearStatusBar_Leave;
			checkBoxFillWithZeros.MouseEnter += SetStatusBar_Enter;
			checkBoxFillWithZeros.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxList
			// 
			textBoxList.AccessibleDescription = "Zeigt die Liste mit den generierten Einträgen an";
			textBoxList.AccessibleName = "Generierten Einträge";
			textBoxList.AccessibleRole = AccessibleRole.Text;
			textBoxList.Location = new Point(13, 303);
			textBoxList.Margin = new Padding(4, 3, 4, 3);
			textBoxList.MaxLength = int.MaxValue;
			textBoxList.Multiline = true;
			textBoxList.Name = "textBoxList";
			textBoxList.ScrollBars = ScrollBars.Both;
			textBoxList.Size = new Size(395, 192);
			textBoxList.TabIndex = 20;
			toolTip.SetToolTip(textBoxList, "Zeigt die Liste mit den generierten Einträgen an");
			textBoxList.WordWrap = false;
			textBoxList.Enter += SetStatusBar_Enter;
			textBoxList.Leave += ClearStatusBar_Leave;
			textBoxList.MouseEnter += SetStatusBar_Enter;
			textBoxList.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelProgress
			// 
			labelProgress.AccessibleDescription = "Verarbeitung";
			labelProgress.AccessibleName = "Verarbeitung";
			labelProgress.AccessibleRole = AccessibleRole.StaticText;
			labelProgress.AutoEllipsis = true;
			labelProgress.AutoSize = true;
			labelProgress.Location = new Point(13, 254);
			labelProgress.Margin = new Padding(4, 0, 4, 0);
			labelProgress.Name = "labelProgress";
			labelProgress.Size = new Size(77, 15);
			labelProgress.TabIndex = 17;
			labelProgress.Text = "Verarbeitung:";
			toolTip.SetToolTip(labelProgress, "Verarbeitung");
			labelProgress.Enter += SetStatusBar_Enter;
			labelProgress.Leave += ClearStatusBar_Leave;
			labelProgress.MouseEnter += SetStatusBar_Enter;
			labelProgress.MouseLeave += ClearStatusBar_Leave;
			// 
			// progressBar
			// 
			progressBar.AccessibleDescription = "Zeigt den laufenden Verarbeitungsstatus an";
			progressBar.AccessibleName = "Verarbeitungsstatus";
			progressBar.AccessibleRole = AccessibleRole.ProgressBar;
			progressBar.Location = new Point(98, 254);
			progressBar.Margin = new Padding(4, 3, 4, 3);
			progressBar.Name = "progressBar";
			progressBar.Size = new Size(310, 20);
			progressBar.Style = ProgressBarStyle.Continuous;
			progressBar.TabIndex = 18;
			toolTip.SetToolTip(progressBar, "Zeigt den laufenden Verarbeitungsstatus an");
			progressBar.MouseEnter += SetStatusBar_Enter;
			progressBar.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxStringBeforeNumber
			// 
			textBoxStringBeforeNumber.AccessibleDescription = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.AccessibleName = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.AccessibleRole = AccessibleRole.Text;
			textBoxStringBeforeNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBoxStringBeforeNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
			textBoxStringBeforeNumber.Location = new Point(13, 30);
			textBoxStringBeforeNumber.Margin = new Padding(4, 3, 4, 3);
			textBoxStringBeforeNumber.Name = "textBoxStringBeforeNumber";
			textBoxStringBeforeNumber.PlaceholderText = "Eingabe des Textes vor der Zahlenangabe";
			textBoxStringBeforeNumber.Size = new Size(395, 23);
			textBoxStringBeforeNumber.TabIndex = 1;
			textBoxStringBeforeNumber.Text = "http://www.domain.com/files/picture";
			toolTip.SetToolTip(textBoxStringBeforeNumber, "Eingabe des Textes vor der Zahlenangabe");
			textBoxStringBeforeNumber.Enter += SetStatusBar_Enter;
			textBoxStringBeforeNumber.Leave += ClearStatusBar_Leave;
			textBoxStringBeforeNumber.MouseEnter += SetStatusBar_Enter;
			textBoxStringBeforeNumber.MouseLeave += ClearStatusBar_Leave;
			// 
			// textBoxStringAfterNumber
			// 
			textBoxStringAfterNumber.AccessibleDescription = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.AccessibleName = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.AccessibleRole = AccessibleRole.Text;
			textBoxStringAfterNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			textBoxStringAfterNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
			textBoxStringAfterNumber.Location = new Point(13, 127);
			textBoxStringAfterNumber.Margin = new Padding(4, 3, 4, 3);
			textBoxStringAfterNumber.Name = "textBoxStringAfterNumber";
			textBoxStringAfterNumber.PlaceholderText = "Eingabe des Textes nach der Zahlenangabe";
			textBoxStringAfterNumber.Size = new Size(251, 23);
			textBoxStringAfterNumber.TabIndex = 8;
			textBoxStringAfterNumber.Text = ".jpg";
			toolTip.SetToolTip(textBoxStringAfterNumber, "Eingabe des Textes nach der Zahlenangabe");
			textBoxStringAfterNumber.Enter += SetStatusBar_Enter;
			textBoxStringAfterNumber.Leave += ClearStatusBar_Leave;
			textBoxStringAfterNumber.MouseEnter += SetStatusBar_Enter;
			textBoxStringAfterNumber.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonRedo
			// 
			buttonRedo.AccessibleDescription = "Verwirft die letzte rückgängig gemachte Änderung";
			buttonRedo.AccessibleName = "Letzte Änderung verwerfen";
			buttonRedo.AccessibleRole = AccessibleRole.PushButton;
			buttonRedo.AutoEllipsis = true;
			buttonRedo.Image = Resources.redo;
			buttonRedo.Location = new Point(85, 206);
			buttonRedo.Margin = new Padding(4, 3, 4, 3);
			buttonRedo.Name = "buttonRedo";
			buttonRedo.Size = new Size(68, 30);
			buttonRedo.TabIndex = 14;
			buttonRedo.Text = "&Redo";
			buttonRedo.TextAlign = ContentAlignment.MiddleRight;
			buttonRedo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonRedo, "Verwirft die letzte rückgängig gemachte Änderung");
			buttonRedo.UseVisualStyleBackColor = true;
			buttonRedo.Click += ButtonRedo_Click;
			buttonRedo.Enter += SetStatusBar_Enter;
			buttonRedo.Leave += ClearStatusBar_Leave;
			buttonRedo.MouseEnter += SetStatusBar_Enter;
			buttonRedo.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonUndo
			// 
			buttonUndo.AccessibleDescription = "Macht die letzte Änderung rückgängig";
			buttonUndo.AccessibleName = "Änderung rückgängigmachen";
			buttonUndo.AccessibleRole = AccessibleRole.PushButton;
			buttonUndo.AutoEllipsis = true;
			buttonUndo.Image = (Image)resources.GetObject("buttonUndo.Image");
			buttonUndo.Location = new Point(13, 206);
			buttonUndo.Margin = new Padding(4, 3, 4, 3);
			buttonUndo.Name = "buttonUndo";
			buttonUndo.Size = new Size(68, 30);
			buttonUndo.TabIndex = 13;
			buttonUndo.Text = "&Undo";
			buttonUndo.TextAlign = ContentAlignment.MiddleRight;
			buttonUndo.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonUndo, "Macht die letzte Änderung rückgängig");
			buttonUndo.UseVisualStyleBackColor = true;
			buttonUndo.Click += ButtonUndo_Click;
			buttonUndo.Enter += SetStatusBar_Enter;
			buttonUndo.Leave += ClearStatusBar_Leave;
			buttonUndo.MouseEnter += SetStatusBar_Enter;
			buttonUndo.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonCreateList
			// 
			buttonCreateList.AccessibleDescription = "Erstellt eine neue Liste";
			buttonCreateList.AccessibleName = "Liste neu erstellen";
			buttonCreateList.AccessibleRole = AccessibleRole.PushButton;
			buttonCreateList.AutoEllipsis = true;
			buttonCreateList.Image = Resources.document_index;
			buttonCreateList.Location = new Point(13, 169);
			buttonCreateList.Margin = new Padding(4, 3, 4, 3);
			buttonCreateList.Name = "buttonCreateList";
			buttonCreateList.Size = new Size(140, 30);
			buttonCreateList.TabIndex = 10;
			buttonCreateList.Text = "Liste neu &erstellen";
			buttonCreateList.TextAlign = ContentAlignment.MiddleRight;
			buttonCreateList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCreateList, "Erstellt eine neue Liste");
			buttonCreateList.UseVisualStyleBackColor = true;
			buttonCreateList.Click += ButtonCreateList_Click;
			buttonCreateList.Enter += SetStatusBar_Enter;
			buttonCreateList.Leave += ClearStatusBar_Leave;
			buttonCreateList.MouseEnter += SetStatusBar_Enter;
			buttonCreateList.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonDeleteList
			// 
			buttonDeleteList.AccessibleDescription = "Löscht die Liste";
			buttonDeleteList.AccessibleName = "Liste löschen";
			buttonDeleteList.AccessibleRole = AccessibleRole.PushButton;
			buttonDeleteList.AutoEllipsis = true;
			buttonDeleteList.Image = Resources.bin_empty;
			buttonDeleteList.Location = new Point(288, 169);
			buttonDeleteList.Margin = new Padding(4, 3, 4, 3);
			buttonDeleteList.Name = "buttonDeleteList";
			buttonDeleteList.Size = new Size(120, 30);
			buttonDeleteList.TabIndex = 12;
			buttonDeleteList.Text = "Liste &löschen";
			buttonDeleteList.TextAlign = ContentAlignment.MiddleRight;
			buttonDeleteList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonDeleteList, "Löscht die Liste");
			buttonDeleteList.UseVisualStyleBackColor = true;
			buttonDeleteList.Click += ButtonDeleteList_Click;
			buttonDeleteList.Enter += SetStatusBar_Enter;
			buttonDeleteList.Leave += ClearStatusBar_Leave;
			buttonDeleteList.MouseEnter += SetStatusBar_Enter;
			buttonDeleteList.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonSaveList
			// 
			buttonSaveList.AccessibleDescription = "Speichert die Liste als Textdatei ab";
			buttonSaveList.AccessibleName = "Liste speichern";
			buttonSaveList.AccessibleRole = AccessibleRole.PushButton;
			buttonSaveList.AutoEllipsis = true;
			buttonSaveList.Image = Resources.diskette;
			buttonSaveList.Location = new Point(288, 206);
			buttonSaveList.Margin = new Padding(4, 3, 4, 3);
			buttonSaveList.Name = "buttonSaveList";
			buttonSaveList.Size = new Size(120, 30);
			buttonSaveList.TabIndex = 16;
			buttonSaveList.Text = "Liste &speichern";
			buttonSaveList.TextAlign = ContentAlignment.MiddleRight;
			buttonSaveList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonSaveList, "Speichert die Liste als Textdatei ab");
			buttonSaveList.UseVisualStyleBackColor = true;
			buttonSaveList.Click += ButtonSaveList_Click;
			buttonSaveList.Enter += SetStatusBar_Enter;
			buttonSaveList.Leave += ClearStatusBar_Leave;
			buttonSaveList.MouseEnter += SetStatusBar_Enter;
			buttonSaveList.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonCopyList
			// 
			buttonCopyList.AccessibleDescription = "Kopiert die Liste in die Windows-Zwischenablage";
			buttonCopyList.AccessibleName = "Liste kopieren";
			buttonCopyList.AccessibleRole = AccessibleRole.PushButton;
			buttonCopyList.AutoEllipsis = true;
			buttonCopyList.Image = Resources.page_copy;
			buttonCopyList.Location = new Point(160, 206);
			buttonCopyList.Margin = new Padding(4, 3, 4, 3);
			buttonCopyList.Name = "buttonCopyList";
			buttonCopyList.Size = new Size(121, 30);
			buttonCopyList.TabIndex = 15;
			buttonCopyList.Text = "Liste &kopieren";
			buttonCopyList.TextAlign = ContentAlignment.MiddleRight;
			buttonCopyList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCopyList, "Kopiert die Liste in die Zwischenanlage");
			buttonCopyList.UseVisualStyleBackColor = true;
			buttonCopyList.Click += ButtonCopyList_Click;
			buttonCopyList.Enter += SetStatusBar_Enter;
			buttonCopyList.Leave += ClearStatusBar_Leave;
			buttonCopyList.MouseEnter += SetStatusBar_Enter;
			buttonCopyList.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonAddToList
			// 
			buttonAddToList.AccessibleDescription = "Fügt die Einträge an der vorhandenen Liste an";
			buttonAddToList.AccessibleName = "Liste anfügen";
			buttonAddToList.AccessibleRole = AccessibleRole.PushButton;
			buttonAddToList.AutoEllipsis = true;
			buttonAddToList.Image = Resources.add;
			buttonAddToList.Location = new Point(160, 169);
			buttonAddToList.Margin = new Padding(4, 3, 4, 3);
			buttonAddToList.Name = "buttonAddToList";
			buttonAddToList.Size = new Size(121, 30);
			buttonAddToList.TabIndex = 11;
			buttonAddToList.Text = "Liste &anfügen";
			buttonAddToList.TextAlign = ContentAlignment.MiddleRight;
			buttonAddToList.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonAddToList, "Fügt die Einträge an der vorhandenen Liste an");
			buttonAddToList.UseVisualStyleBackColor = true;
			buttonAddToList.Click += ButtonAddToList_Click;
			buttonAddToList.Enter += SetStatusBar_Enter;
			buttonAddToList.Leave += ClearStatusBar_Leave;
			buttonAddToList.MouseEnter += SetStatusBar_Enter;
			buttonAddToList.MouseLeave += ClearStatusBar_Leave;
			// 
			// labelResult
			// 
			labelResult.AccessibleDescription = "Ergebnis";
			labelResult.AccessibleName = "Ergebnis";
			labelResult.AccessibleRole = AccessibleRole.StaticText;
			labelResult.AutoEllipsis = true;
			labelResult.AutoSize = true;
			labelResult.Location = new Point(13, 285);
			labelResult.Margin = new Padding(4, 0, 4, 0);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(55, 15);
			labelResult.TabIndex = 19;
			labelResult.Text = "Er&gebnis:";
			toolTip.SetToolTip(labelResult, "Ergebnis");
			labelResult.MouseEnter += SetStatusBar_Enter;
			labelResult.MouseLeave += ClearStatusBar_Leave;
			// 
			// statusStripStatistic
			// 
			statusStripStatistic.AccessibleDescription = "Statusbar für statistische Angaben";
			statusStripStatistic.AccessibleName = "Statusbar";
			statusStripStatistic.AccessibleRole = AccessibleRole.StatusBar;
			statusStripStatistic.AllowItemReorder = true;
			statusStripStatistic.Dock = DockStyle.None;
			statusStripStatistic.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelSize, toolStripStatusLabelLines, toolStripStatusLabelTimeSpan });
			statusStripStatistic.Location = new Point(0, 22);
			statusStripStatistic.Name = "statusStripStatistic";
			statusStripStatistic.Padding = new Padding(1, 0, 16, 0);
			statusStripStatistic.ShowItemToolTips = true;
			statusStripStatistic.Size = new Size(422, 24);
			statusStripStatistic.SizingGrip = false;
			statusStripStatistic.TabIndex = 1;
			statusStripStatistic.TabStop = true;
			statusStripStatistic.Text = "statusStripStatistic";
			toolTip.SetToolTip(statusStripStatistic, "Statusbar für statistische Angaben");
			statusStripStatistic.Enter += SetStatusBar_Enter;
			statusStripStatistic.Leave += SetStatusBar_Enter;
			statusStripStatistic.MouseEnter += SetStatusBar_Enter;
			statusStripStatistic.MouseLeave += ClearStatusBar_Leave;
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
			toolStripStatusLabelSize.MouseEnter += SetStatusBar_Enter;
			toolStripStatusLabelSize.MouseLeave += ClearStatusBar_Leave;
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
			toolStripStatusLabelLines.MouseEnter += SetStatusBar_Enter;
			toolStripStatusLabelLines.MouseLeave += ClearStatusBar_Leave;
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
			toolStripStatusLabelTimeSpan.MouseEnter += SetStatusBar_Enter;
			toolStripStatusLabelTimeSpan.MouseLeave += ClearStatusBar_Leave;
			// 
			// statusStripInfo
			// 
			statusStripInfo.AccessibleDescription = "Statusbar für Informationstext";
			statusStripInfo.AccessibleName = "Statusbar";
			statusStripInfo.AccessibleRole = AccessibleRole.StatusBar;
			statusStripInfo.Dock = DockStyle.None;
			statusStripInfo.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation });
			statusStripInfo.Location = new Point(0, 0);
			statusStripInfo.Name = "statusStripInfo";
			statusStripInfo.ShowItemToolTips = true;
			statusStripInfo.Size = new Size(422, 22);
			statusStripInfo.SizingGrip = false;
			statusStripInfo.TabIndex = 0;
			statusStripInfo.TabStop = true;
			statusStripInfo.Text = "statusStripInfo";
			toolTip.SetToolTip(statusStripInfo, "Statusbar für Informationstext");
			statusStripInfo.Enter += SetStatusBar_Enter;
			statusStripInfo.Leave += ClearStatusBar_Leave;
			statusStripInfo.MouseEnter += SetStatusBar_Enter;
			statusStripInfo.MouseLeave += ClearStatusBar_Leave;
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
			// menuStrip
			// 
			menuStrip.AccessibleDescription = "Zeigt die Menübar";
			menuStrip.AccessibleName = "Menübar";
			menuStrip.AccessibleRole = AccessibleRole.MenuBar;
			menuStrip.AllowItemReorder = true;
			menuStrip.Dock = DockStyle.None;
			menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemProgram, toolStripMenuItemList, toolStripMenuItemSettings });
			menuStrip.Location = new Point(0, 0);
			menuStrip.MdiWindowListItem = toolStripMenuItemList;
			menuStrip.Name = "menuStrip";
			menuStrip.RenderMode = ToolStripRenderMode.System;
			menuStrip.ShowItemToolTips = true;
			menuStrip.Size = new Size(422, 24);
			menuStrip.TabIndex = 0;
			menuStrip.Text = "Menu";
			toolTip.SetToolTip(menuStrip, "Menü");
			menuStrip.Enter += SetStatusBar_Enter;
			menuStrip.Leave += ClearStatusBar_Leave;
			menuStrip.MouseEnter += SetStatusBar_Enter;
			menuStrip.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemProgram
			// 
			toolStripMenuItemProgram.AccessibleDescription = "Öffnet das Menü \"Programm\"";
			toolStripMenuItemProgram.AccessibleName = "Menü \"Programm\"";
			toolStripMenuItemProgram.AccessibleRole = AccessibleRole.MenuPopup;
			toolStripMenuItemProgram.AutoToolTip = true;
			toolStripMenuItemProgram.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInfo, toolStripMenuItemLicense, toolStripSeparator1, toolStripMenuItemExit });
			toolStripMenuItemProgram.Name = "toolStripMenuItemProgram";
			toolStripMenuItemProgram.ShortcutKeys = Keys.Alt | Keys.P;
			toolStripMenuItemProgram.Size = new Size(76, 20);
			toolStripMenuItemProgram.Text = "&Programm";
			toolStripMenuItemProgram.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemProgram.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemInfo
			// 
			toolStripMenuItemInfo.AccessibleDescription = "Ruft die Programminformationen auf";
			toolStripMenuItemInfo.AccessibleName = "Programminformationen";
			toolStripMenuItemInfo.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemInfo.AutoToolTip = true;
			toolStripMenuItemInfo.Image = Resources.information;
			toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
			toolStripMenuItemInfo.ShortcutKeyDisplayString = "";
			toolStripMenuItemInfo.ShortcutKeys = Keys.Alt | Keys.I;
			toolStripMenuItemInfo.Size = new Size(157, 22);
			toolStripMenuItemInfo.Text = "&Info";
			toolStripMenuItemInfo.Click += ToolStripMenuItemInfo_Click;
			toolStripMenuItemInfo.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemInfo.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemLicense
			// 
			toolStripMenuItemLicense.AccessibleDescription = "Ruft die Lizenz auf";
			toolStripMenuItemLicense.AccessibleName = "Lizenz";
			toolStripMenuItemLicense.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemLicense.AutoToolTip = true;
			toolStripMenuItemLicense.Image = Resources.script;
			toolStripMenuItemLicense.Name = "toolStripMenuItemLicense";
			toolStripMenuItemLicense.ShortcutKeys = Keys.Alt | Keys.Z;
			toolStripMenuItemLicense.Size = new Size(157, 22);
			toolStripMenuItemLicense.Text = "Lizen&z";
			toolStripMenuItemLicense.Click += ToolStripMenuItemLicense_Click;
			toolStripMenuItemLicense.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemLicense.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(154, 6);
			toolStripSeparator1.MouseEnter += SetStatusBar_Enter;
			toolStripSeparator1.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemExit
			// 
			toolStripMenuItemExit.AccessibleDescription = "Beendet das Programm";
			toolStripMenuItemExit.AccessibleName = "Programm beenden";
			toolStripMenuItemExit.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemExit.AutoToolTip = true;
			toolStripMenuItemExit.Image = Resources.door_open;
			toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			toolStripMenuItemExit.ShortcutKeys = Keys.Alt | Keys.B;
			toolStripMenuItemExit.Size = new Size(157, 22);
			toolStripMenuItemExit.Text = "&Beenden";
			toolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
			toolStripMenuItemExit.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemExit.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemList
			// 
			toolStripMenuItemList.AccessibleDescription = "Öffnet das Menü \"Liste\"";
			toolStripMenuItemList.AccessibleName = "Menü \"Liste\"";
			toolStripMenuItemList.AccessibleRole = AccessibleRole.MenuPopup;
			toolStripMenuItemList.AutoToolTip = true;
			toolStripMenuItemList.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemBatch, toolStripSeparator4, toolStripMenuItemListCreate, toolStripMenuItemListAdd, toolStripMenuItemListDelete, toolStripSeparator2, toolStripMenuItemListUndo, toolStripMenuItemListRedo, toolStripSeparator3, toolStripMenuItemListCopy, toolStripMenuItemListSave });
			toolStripMenuItemList.Name = "toolStripMenuItemList";
			toolStripMenuItemList.ShortcutKeys = Keys.Alt | Keys.L;
			toolStripMenuItemList.Size = new Size(43, 20);
			toolStripMenuItemList.Text = "Lis&te";
			toolStripMenuItemList.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemList.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemBatch
			// 
			toolStripMenuItemBatch.AccessibleDescription = "Öffnet die Stapelverarbeitung";
			toolStripMenuItemBatch.AccessibleName = "Stapelverarbeitung öffnen";
			toolStripMenuItemBatch.AutoToolTip = true;
			toolStripMenuItemBatch.Enabled = false;
			toolStripMenuItemBatch.Image = Resources.category;
			toolStripMenuItemBatch.Name = "toolStripMenuItemBatch";
			toolStripMenuItemBatch.Size = new Size(180, 22);
			toolStripMenuItemBatch.Text = "Stapelverarbeitung";
			toolStripMenuItemBatch.Click += ToolStripMenuItemBatch_Click;
			toolStripMenuItemBatch.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemBatch.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(177, 6);
			// 
			// toolStripMenuItemListCreate
			// 
			toolStripMenuItemListCreate.AccessibleDescription = "Erstellt eine neue Liste";
			toolStripMenuItemListCreate.AccessibleName = "Liste neu erstellen";
			toolStripMenuItemListCreate.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemListCreate.Image = Resources.document_index;
			toolStripMenuItemListCreate.Name = "toolStripMenuItemListCreate";
			toolStripMenuItemListCreate.ShortcutKeys = Keys.Alt | Keys.E;
			toolStripMenuItemListCreate.Size = new Size(180, 22);
			toolStripMenuItemListCreate.Text = "Neu &erstellen";
			toolStripMenuItemListCreate.ToolTipText = "Liste neu erstellen";
			toolStripMenuItemListCreate.Click += ToolStripMenuItemListCreate_Click;
			toolStripMenuItemListCreate.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemListCreate.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemListAdd
			// 
			toolStripMenuItemListAdd.AccessibleDescription = "Fügt die Einträge an der vorhandenen Liste an";
			toolStripMenuItemListAdd.AccessibleName = "Liste anfügen";
			toolStripMenuItemListAdd.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemListAdd.Image = Resources.add;
			toolStripMenuItemListAdd.Name = "toolStripMenuItemListAdd";
			toolStripMenuItemListAdd.ShortcutKeys = Keys.Alt | Keys.A;
			toolStripMenuItemListAdd.Size = new Size(180, 22);
			toolStripMenuItemListAdd.Text = "&Anfügen";
			toolStripMenuItemListAdd.ToolTipText = "Liste anfügen";
			toolStripMenuItemListAdd.Click += ToolStripMenuItemListAdd_Click;
			toolStripMenuItemListAdd.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemListAdd.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemListDelete
			// 
			toolStripMenuItemListDelete.AccessibleDescription = "Löscht die Liste";
			toolStripMenuItemListDelete.AccessibleName = "Liste löschen";
			toolStripMenuItemListDelete.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemListDelete.Image = Resources.bin_empty;
			toolStripMenuItemListDelete.Name = "toolStripMenuItemListDelete";
			toolStripMenuItemListDelete.ShortcutKeys = Keys.Alt | Keys.L;
			toolStripMenuItemListDelete.Size = new Size(180, 22);
			toolStripMenuItemListDelete.Text = "&Löschen";
			toolStripMenuItemListDelete.ToolTipText = "Liste löschen";
			toolStripMenuItemListDelete.Click += ToolStripMenuItemListDelete_Click;
			toolStripMenuItemListDelete.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemListDelete.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(177, 6);
			toolStripSeparator2.MouseEnter += SetStatusBar_Enter;
			toolStripSeparator2.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemListUndo
			// 
			toolStripMenuItemListUndo.AccessibleDescription = "Macht die letzte Änderung rückgängig";
			toolStripMenuItemListUndo.AccessibleName = "Änderung rückgängigmachen";
			toolStripMenuItemListUndo.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemListUndo.AutoToolTip = true;
			toolStripMenuItemListUndo.Image = Resources.undo;
			toolStripMenuItemListUndo.Name = "toolStripMenuItemListUndo";
			toolStripMenuItemListUndo.ShortcutKeys = Keys.Alt | Keys.U;
			toolStripMenuItemListUndo.Size = new Size(180, 22);
			toolStripMenuItemListUndo.Text = "&Undo";
			toolStripMenuItemListUndo.Click += ToolStripMenuItemListUndo_Click;
			toolStripMenuItemListUndo.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemListUndo.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemListRedo
			// 
			toolStripMenuItemListRedo.AccessibleDescription = "Verwirft die letzte rückgängig gemachte Änderung";
			toolStripMenuItemListRedo.AccessibleName = "Letzte Änderung verwerfen";
			toolStripMenuItemListRedo.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemListRedo.AutoToolTip = true;
			toolStripMenuItemListRedo.Image = Resources.redo;
			toolStripMenuItemListRedo.Name = "toolStripMenuItemListRedo";
			toolStripMenuItemListRedo.ShortcutKeys = Keys.Alt | Keys.R;
			toolStripMenuItemListRedo.Size = new Size(180, 22);
			toolStripMenuItemListRedo.Text = "&Redo";
			toolStripMenuItemListRedo.Click += ToolStripMenuItemListRedo_Click;
			toolStripMenuItemListRedo.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemListRedo.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.AccessibleRole = AccessibleRole.Separator;
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(177, 6);
			toolStripSeparator3.MouseEnter += SetStatusBar_Enter;
			toolStripSeparator3.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemListCopy
			// 
			toolStripMenuItemListCopy.AccessibleDescription = "Kopiert die Liste in die Windows-Zwischenablage";
			toolStripMenuItemListCopy.AccessibleName = "Liste kopieren";
			toolStripMenuItemListCopy.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemListCopy.Image = Resources.page_copy;
			toolStripMenuItemListCopy.Name = "toolStripMenuItemListCopy";
			toolStripMenuItemListCopy.ShortcutKeys = Keys.Alt | Keys.K;
			toolStripMenuItemListCopy.Size = new Size(180, 22);
			toolStripMenuItemListCopy.Text = "&Kopieren";
			toolStripMenuItemListCopy.ToolTipText = "Liste kopieren";
			toolStripMenuItemListCopy.Click += ToolStripMenuItemListCopy_Click;
			toolStripMenuItemListCopy.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemListCopy.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemListSave
			// 
			toolStripMenuItemListSave.AccessibleDescription = "Speichert die Liste als Textdatei ab";
			toolStripMenuItemListSave.AccessibleName = "Liste speichern";
			toolStripMenuItemListSave.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemListSave.Image = Resources.diskette;
			toolStripMenuItemListSave.Name = "toolStripMenuItemListSave";
			toolStripMenuItemListSave.ShortcutKeys = Keys.Alt | Keys.S;
			toolStripMenuItemListSave.Size = new Size(180, 22);
			toolStripMenuItemListSave.Text = "&Speichern";
			toolStripMenuItemListSave.ToolTipText = "Liste speichern";
			toolStripMenuItemListSave.Click += ToolStripMenuItemListSave_Click;
			toolStripMenuItemListSave.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemListSave.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemSettings
			// 
			toolStripMenuItemSettings.AccessibleDescription = "Öffnet das Menü \"Einstellungen\"";
			toolStripMenuItemSettings.AccessibleName = "Menü \"Einstellungen\"";
			toolStripMenuItemSettings.AccessibleRole = AccessibleRole.MenuPopup;
			toolStripMenuItemSettings.AutoToolTip = true;
			toolStripMenuItemSettings.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemSettingsStayOnTop, toolStripMenuItemSettingsDisableVisualStyle });
			toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
			toolStripMenuItemSettings.ShortcutKeys = Keys.Alt | Keys.E;
			toolStripMenuItemSettings.Size = new Size(90, 20);
			toolStripMenuItemSettings.Text = "&Einstellungen";
			toolStripMenuItemSettings.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemSettings.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemSettingsStayOnTop
			// 
			toolStripMenuItemSettingsStayOnTop.AccessibleDescription = "Hält das Fenster immer in den Vordergrund";
			toolStripMenuItemSettingsStayOnTop.AccessibleName = "Immer im Vordergrund halten";
			toolStripMenuItemSettingsStayOnTop.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemSettingsStayOnTop.AutoToolTip = true;
			toolStripMenuItemSettingsStayOnTop.CheckOnClick = true;
			toolStripMenuItemSettingsStayOnTop.Name = "toolStripMenuItemSettingsStayOnTop";
			toolStripMenuItemSettingsStayOnTop.ShortcutKeys = Keys.Alt | Keys.D1;
			toolStripMenuItemSettingsStayOnTop.Size = new Size(267, 22);
			toolStripMenuItemSettingsStayOnTop.Text = "Immer im Vordergrund halten";
			toolStripMenuItemSettingsStayOnTop.Click += ToolStripMenuItemSettingsStayOnTop_Click;
			toolStripMenuItemSettingsStayOnTop.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemSettingsStayOnTop.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripMenuItemSettingsDisableVisualStyle
			// 
			toolStripMenuItemSettingsDisableVisualStyle.AccessibleDescription = "Aktiviert oder deaktiviert den visuellen Stil des Programms";
			toolStripMenuItemSettingsDisableVisualStyle.AccessibleName = "Visuellen Stil de-/aktivieren";
			toolStripMenuItemSettingsDisableVisualStyle.AccessibleRole = AccessibleRole.MenuItem;
			toolStripMenuItemSettingsDisableVisualStyle.AutoToolTip = true;
			toolStripMenuItemSettingsDisableVisualStyle.CheckOnClick = true;
			toolStripMenuItemSettingsDisableVisualStyle.Name = "toolStripMenuItemSettingsDisableVisualStyle";
			toolStripMenuItemSettingsDisableVisualStyle.ShortcutKeys = Keys.Alt | Keys.D2;
			toolStripMenuItemSettingsDisableVisualStyle.Size = new Size(267, 22);
			toolStripMenuItemSettingsDisableVisualStyle.Text = "Visuellen Stil deaktivieren";
			toolStripMenuItemSettingsDisableVisualStyle.Click += ToolStripMenuItemSettingsDisableVisualStyle_Click;
			toolStripMenuItemSettingsDisableVisualStyle.MouseEnter += SetStatusBar_Enter;
			toolStripMenuItemSettingsDisableVisualStyle.MouseLeave += ClearStatusBar_Leave;
			// 
			// buttonCancelProgress
			// 
			buttonCancelProgress.AccessibleDescription = "Bricht den Vorgang ab";
			buttonCancelProgress.AccessibleName = "Vorgang abbrechen";
			buttonCancelProgress.AccessibleRole = AccessibleRole.PushButton;
			buttonCancelProgress.AutoEllipsis = true;
			buttonCancelProgress.Image = Resources.cross;
			buttonCancelProgress.Location = new Point(272, 120);
			buttonCancelProgress.Margin = new Padding(4, 3, 4, 3);
			buttonCancelProgress.Name = "buttonCancelProgress";
			buttonCancelProgress.Size = new Size(136, 32);
			buttonCancelProgress.TabIndex = 9;
			buttonCancelProgress.Text = "Vor&gang abbrechen";
			buttonCancelProgress.TextAlign = ContentAlignment.MiddleRight;
			buttonCancelProgress.TextImageRelation = TextImageRelation.ImageBeforeText;
			toolTip.SetToolTip(buttonCancelProgress, "Bricht den Vorgang ab");
			buttonCancelProgress.UseVisualStyleBackColor = true;
			buttonCancelProgress.Click += ButtonCancelProgress_Click;
			buttonCancelProgress.Enter += SetStatusBar_Enter;
			buttonCancelProgress.Leave += ClearStatusBar_Leave;
			buttonCancelProgress.MouseEnter += SetStatusBar_Enter;
			buttonCancelProgress.MouseLeave += ClearStatusBar_Leave;
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Container";
			toolStripContainer.AccessibleName = "Container";
			toolStripContainer.AccessibleRole = AccessibleRole.Pane;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStripInfo);
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStripStatistic);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.BackColor = SystemColors.Control;
			toolStripContainer.ContentPanel.Controls.Add(buttonCancelProgress);
			toolStripContainer.ContentPanel.Controls.Add(labelStringBeforeNumber);
			toolStripContainer.ContentPanel.Controls.Add(buttonRedo);
			toolStripContainer.ContentPanel.Controls.Add(labelStringAfterNumber);
			toolStripContainer.ContentPanel.Controls.Add(labelNumberMin);
			toolStripContainer.ContentPanel.Controls.Add(textBoxStringAfterNumber);
			toolStripContainer.ContentPanel.Controls.Add(numericUpDownNumberMinimum);
			toolStripContainer.ContentPanel.Controls.Add(textBoxStringBeforeNumber);
			toolStripContainer.ContentPanel.Controls.Add(labelNumberMax);
			toolStripContainer.ContentPanel.Controls.Add(buttonUndo);
			toolStripContainer.ContentPanel.Controls.Add(numericUpDownNumberMaximum);
			toolStripContainer.ContentPanel.Controls.Add(labelResult);
			toolStripContainer.ContentPanel.Controls.Add(checkBoxFillWithZeros);
			toolStripContainer.ContentPanel.Controls.Add(buttonCreateList);
			toolStripContainer.ContentPanel.Controls.Add(buttonAddToList);
			toolStripContainer.ContentPanel.Controls.Add(buttonCopyList);
			toolStripContainer.ContentPanel.Controls.Add(buttonSaveList);
			toolStripContainer.ContentPanel.Controls.Add(progressBar);
			toolStripContainer.ContentPanel.Controls.Add(buttonDeleteList);
			toolStripContainer.ContentPanel.Controls.Add(labelProgress);
			toolStripContainer.ContentPanel.Controls.Add(textBoxList);
			toolStripContainer.ContentPanel.Size = new Size(422, 508);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(422, 578);
			toolStripContainer.TabIndex = 0;
			toolStripContainer.Text = "Container";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.Controls.Add(menuStrip);
			// 
			// backgroundWorker
			// 
			backgroundWorker.WorkerReportsProgress = true;
			backgroundWorker.WorkerSupportsCancellation = true;
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			// 
			// NumericListGeneratorForm
			// 
			AccessibleDescription = "Programmfenster";
			AccessibleName = "Programmfenster";
			AccessibleRole = AccessibleRole.Window;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(422, 578);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			KeyPreview = true;
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			Name = "NumericListGeneratorForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Numeric List Generator";
			Load += NumericListGeneratorForm_Load;
			((ISupportInitialize)numericUpDownNumberMinimum).EndInit();
			((ISupportInitialize)numericUpDownNumberMaximum).EndInit();
			statusStripStatistic.ResumeLayout(false);
			statusStripStatistic.PerformLayout();
			statusStripInfo.ResumeLayout(false);
			statusStripInfo.PerformLayout();
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ContentPanel.PerformLayout();
			toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);
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
		private Label labelProgress;
		private ProgressBar progressBar;
		private Button buttonCreateList;
		private ToolTip toolTip;
		private Label labelResult;
		private Button buttonUndo;
		private StatusStrip statusStripStatistic;
		private ToolStripStatusLabel toolStripStatusLabelSize;
		private ToolStripStatusLabel toolStripStatusLabelLines;
		private TextBox textBoxStringBeforeNumber;
		private TextBox textBoxStringAfterNumber;
		private Button buttonRedo;
		private ToolStripStatusLabel toolStripStatusLabelTimeSpan;
		private StatusStrip statusStripInfo;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private ToolStripContainer toolStripContainer;
		private MenuStrip menuStrip;
		private ToolStripMenuItem toolStripMenuItemProgram;
		private ToolStripMenuItem toolStripMenuItemInfo;
		private ToolStripMenuItem toolStripMenuItemLicense;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem toolStripMenuItemExit;
		private ToolStripMenuItem toolStripMenuItemList;
		private ToolStripMenuItem toolStripMenuItemListCreate;
		private ToolStripMenuItem toolStripMenuItemListAdd;
		private ToolStripMenuItem toolStripMenuItemListDelete;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem toolStripMenuItemListUndo;
		private ToolStripMenuItem toolStripMenuItemListRedo;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem toolStripMenuItemListCopy;
		private ToolStripMenuItem toolStripMenuItemListSave;
		private ToolStripMenuItem toolStripMenuItemSettings;
		private ToolStripMenuItem toolStripMenuItemSettingsStayOnTop;
		private ToolStripMenuItem toolStripMenuItemSettingsDisableVisualStyle;
		private ToolStripMenuItem toolStripMenuItemBatch;
		private ToolStripSeparator toolStripSeparator4;
		private BackgroundWorker backgroundWorker;
		private Button buttonCancelProgress;
	}
}

