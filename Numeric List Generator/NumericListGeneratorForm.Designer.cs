namespace NumericListGenerator
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumericListGeneratorForm));
			this.labelStringBeforeNumber = new System.Windows.Forms.Label();
			this.labelStringAfterNumber = new System.Windows.Forms.Label();
			this.labelNumberMin = new System.Windows.Forms.Label();
			this.numericUpDownNumberMinimum = new System.Windows.Forms.NumericUpDown();
			this.labelNumberMax = new System.Windows.Forms.Label();
			this.numericUpDownNumberMaximum = new System.Windows.Forms.NumericUpDown();
			this.checkBoxFillWithZeros = new System.Windows.Forms.CheckBox();
			this.textBoxList = new System.Windows.Forms.TextBox();
			this.labelProcress = new System.Windows.Forms.Label();
			this.progressBarProcress = new System.Windows.Forms.ProgressBar();
			this.buttonCreateListe = new System.Windows.Forms.Button();
			this.buttonInformationAboutApp = new System.Windows.Forms.Button();
			this.buttonExitApp = new System.Windows.Forms.Button();
			this.buttonDeleteList = new System.Windows.Forms.Button();
			this.buttonSaveList = new System.Windows.Forms.Button();
			this.buttonCopyList = new System.Windows.Forms.Button();
			this.buttonAddToList = new System.Windows.Forms.Button();
			this.comboBoxStringAfterNumber = new System.Windows.Forms.ComboBox();
			this.comboBoxStringBeforeNumber = new System.Windows.Forms.ComboBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.labelResult = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberMinimum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberMaximum)).BeginInit();
			this.SuspendLayout();
			// 
			// labelStringBeforeNumber
			// 
			this.labelStringBeforeNumber.AutoSize = true;
			this.labelStringBeforeNumber.Location = new System.Drawing.Point(9, 9);
			this.labelStringBeforeNumber.Name = "labelStringBeforeNumber";
			this.labelStringBeforeNumber.Size = new System.Drawing.Size(133, 13);
			this.labelStringBeforeNumber.TabIndex = 0;
			this.labelStringBeforeNumber.Text = "Zeichenkette &vor der Zahl:";
			// 
			// labelStringAfterNumber
			// 
			this.labelStringAfterNumber.AutoSize = true;
			this.labelStringAfterNumber.Location = new System.Drawing.Point(9, 93);
			this.labelStringAfterNumber.Name = "labelStringAfterNumber";
			this.labelStringAfterNumber.Size = new System.Drawing.Size(142, 13);
			this.labelStringAfterNumber.TabIndex = 7;
			this.labelStringAfterNumber.Text = "Zeichenkette &nach der Zahl:";
			// 
			// labelNumberMin
			// 
			this.labelNumberMin.AutoSize = true;
			this.labelNumberMin.Location = new System.Drawing.Point(9, 60);
			this.labelNumberMin.Name = "labelNumberMin";
			this.labelNumberMin.Size = new System.Drawing.Size(61, 13);
			this.labelNumberMin.TabIndex = 2;
			this.labelNumberMin.Text = "Zahlen von";
			// 
			// numericUpDownNumberMinimum
			// 
			this.numericUpDownNumberMinimum.Location = new System.Drawing.Point(76, 58);
			this.numericUpDownNumberMinimum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericUpDownNumberMinimum.Name = "numericUpDownNumberMinimum";
			this.numericUpDownNumberMinimum.Size = new System.Drawing.Size(49, 20);
			this.numericUpDownNumberMinimum.TabIndex = 3;
			this.toolTip.SetToolTip(this.numericUpDownNumberMinimum, "Minimun der Zahl, mit der die Einträge erstellt werden sollen");
			this.numericUpDownNumberMinimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelNumberMax
			// 
			this.labelNumberMax.AutoSize = true;
			this.labelNumberMax.Location = new System.Drawing.Point(131, 60);
			this.labelNumberMax.Name = "labelNumberMax";
			this.labelNumberMax.Size = new System.Drawing.Size(20, 13);
			this.labelNumberMax.TabIndex = 4;
			this.labelNumberMax.Text = "bis";
			// 
			// numericUpDownNumberMaximum
			// 
			this.numericUpDownNumberMaximum.Location = new System.Drawing.Point(157, 58);
			this.numericUpDownNumberMaximum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericUpDownNumberMaximum.Name = "numericUpDownNumberMaximum";
			this.numericUpDownNumberMaximum.Size = new System.Drawing.Size(49, 20);
			this.numericUpDownNumberMaximum.TabIndex = 5;
			this.toolTip.SetToolTip(this.numericUpDownNumberMaximum, "Maximun der Zahl, mit der die Einträge erstellt werden sollen");
			this.numericUpDownNumberMaximum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// checkBoxFillWithZeros
			// 
			this.checkBoxFillWithZeros.AutoSize = true;
			this.checkBoxFillWithZeros.Location = new System.Drawing.Point(219, 60);
			this.checkBoxFillWithZeros.Name = "checkBoxFillWithZeros";
			this.checkBoxFillWithZeros.Size = new System.Drawing.Size(115, 17);
			this.checkBoxFillWithZeros.TabIndex = 6;
			this.checkBoxFillWithZeros.Text = "&mit Nullen auffüllen";
			this.toolTip.SetToolTip(this.checkBoxFillWithZeros, "Markieren, wenn die Einträge mit voranführenden Nullen aufgefüllt werden sollen");
			this.checkBoxFillWithZeros.UseVisualStyleBackColor = true;
			// 
			// textBoxList
			// 
			this.textBoxList.Location = new System.Drawing.Point(12, 262);
			this.textBoxList.MaxLength = 2147483647;
			this.textBoxList.Multiline = true;
			this.textBoxList.Name = "textBoxList";
			this.textBoxList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxList.Size = new System.Drawing.Size(322, 167);
			this.textBoxList.TabIndex = 17;
			this.toolTip.SetToolTip(this.textBoxList, "Zeigt die Liste mit den generierten Einträgen an");
			this.textBoxList.WordWrap = false;
			// 
			// labelProcress
			// 
			this.labelProcress.AutoSize = true;
			this.labelProcress.Location = new System.Drawing.Point(9, 219);
			this.labelProcress.Name = "labelProcress";
			this.labelProcress.Size = new System.Drawing.Size(70, 13);
			this.labelProcress.TabIndex = 14;
			this.labelProcress.Text = "Verarbeitung:";
			// 
			// progressBarProcress
			// 
			this.progressBarProcress.Location = new System.Drawing.Point(85, 219);
			this.progressBarProcress.Name = "progressBarProcress";
			this.progressBarProcress.Size = new System.Drawing.Size(249, 17);
			this.progressBarProcress.TabIndex = 15;
			this.toolTip.SetToolTip(this.progressBarProcress, "Zeigt den laufenden Verarbeitungsstatus an");
			// 
			// buttonCreateListe
			// 
			this.buttonCreateListe.Image = global::NumericListGenerator.Properties.Resources.gear_in;
			this.buttonCreateListe.Location = new System.Drawing.Point(12, 146);
			this.buttonCreateListe.Name = "buttonCreateListe";
			this.buttonCreateListe.Size = new System.Drawing.Size(212, 26);
			this.buttonCreateListe.TabIndex = 9;
			this.buttonCreateListe.Text = "Liste neu &erstellen";
			this.buttonCreateListe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonCreateListe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCreateListe, "Erstellt eine neue Liste");
			this.buttonCreateListe.UseVisualStyleBackColor = true;
			this.buttonCreateListe.Click += new System.EventHandler(this.ButtonCreateListe_Click);
			// 
			// buttonInformationAboutApp
			// 
			this.buttonInformationAboutApp.Image = global::NumericListGenerator.Properties.Resources.information;
			this.buttonInformationAboutApp.Location = new System.Drawing.Point(12, 435);
			this.buttonInformationAboutApp.Name = "buttonInformationAboutApp";
			this.buttonInformationAboutApp.Size = new System.Drawing.Size(58, 26);
			this.buttonInformationAboutApp.TabIndex = 18;
			this.buttonInformationAboutApp.Text = "&Info";
			this.buttonInformationAboutApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonInformationAboutApp, "Öffnet ein neues Fenste rmit ein paar Programminformationen");
			this.buttonInformationAboutApp.UseVisualStyleBackColor = true;
			this.buttonInformationAboutApp.Click += new System.EventHandler(this.ButtonInformationAboutApp_Click);
			// 
			// buttonExitApp
			// 
			this.buttonExitApp.Image = global::NumericListGenerator.Properties.Resources.door_open;
			this.buttonExitApp.Location = new System.Drawing.Point(204, 435);
			this.buttonExitApp.Name = "buttonExitApp";
			this.buttonExitApp.Size = new System.Drawing.Size(130, 26);
			this.buttonExitApp.TabIndex = 19;
			this.buttonExitApp.Text = "Programm &beenden";
			this.buttonExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonExitApp, "Beendet das Programm");
			this.buttonExitApp.UseVisualStyleBackColor = true;
			this.buttonExitApp.Click += new System.EventHandler(this.ButtonExitApp_Click);
			// 
			// buttonDeleteList
			// 
			this.buttonDeleteList.Image = global::NumericListGenerator.Properties.Resources.bin_empty;
			this.buttonDeleteList.Location = new System.Drawing.Point(230, 178);
			this.buttonDeleteList.Name = "buttonDeleteList";
			this.buttonDeleteList.Size = new System.Drawing.Size(104, 26);
			this.buttonDeleteList.TabIndex = 13;
			this.buttonDeleteList.Text = "Liste &löschen";
			this.buttonDeleteList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonDeleteList, "Löscht die Liste");
			this.buttonDeleteList.UseVisualStyleBackColor = true;
			this.buttonDeleteList.Click += new System.EventHandler(this.ButtonDeleteList_Click);
			// 
			// buttonSaveList
			// 
			this.buttonSaveList.Image = global::NumericListGenerator.Properties.Resources.diskette;
			this.buttonSaveList.Location = new System.Drawing.Point(230, 146);
			this.buttonSaveList.Name = "buttonSaveList";
			this.buttonSaveList.Size = new System.Drawing.Size(104, 26);
			this.buttonSaveList.TabIndex = 10;
			this.buttonSaveList.Text = "Liste &speichern";
			this.buttonSaveList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonSaveList, "Speichert die Liste als Textdatei ab");
			this.buttonSaveList.UseVisualStyleBackColor = true;
			this.buttonSaveList.Click += new System.EventHandler(this.ButtonSaveList_Click);
			// 
			// buttonCopyList
			// 
			this.buttonCopyList.Image = global::NumericListGenerator.Properties.Resources.page_copy;
			this.buttonCopyList.Location = new System.Drawing.Point(120, 178);
			this.buttonCopyList.Name = "buttonCopyList";
			this.buttonCopyList.Size = new System.Drawing.Size(104, 26);
			this.buttonCopyList.TabIndex = 12;
			this.buttonCopyList.Text = "Liste &kopieren";
			this.buttonCopyList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonCopyList, "Kopiert die Liste in die Zwischenanlage");
			this.buttonCopyList.UseVisualStyleBackColor = true;
			this.buttonCopyList.Click += new System.EventHandler(this.ButtonCopyList_Click);
			// 
			// buttonAddToList
			// 
			this.buttonAddToList.Image = global::NumericListGenerator.Properties.Resources.add;
			this.buttonAddToList.Location = new System.Drawing.Point(12, 178);
			this.buttonAddToList.Name = "buttonAddToList";
			this.buttonAddToList.Size = new System.Drawing.Size(102, 26);
			this.buttonAddToList.TabIndex = 11;
			this.buttonAddToList.Text = "Liste &anfügen";
			this.buttonAddToList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip.SetToolTip(this.buttonAddToList, "Fügt die Einträge an der vorhandenen Liste an");
			this.buttonAddToList.UseVisualStyleBackColor = true;
			this.buttonAddToList.Click += new System.EventHandler(this.ButtonAddToList_Click);
			// 
			// comboBoxStringAfterNumber
			// 
			this.comboBoxStringAfterNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxStringAfterNumber.Location = new System.Drawing.Point(12, 108);
			this.comboBoxStringAfterNumber.Name = "comboBoxStringAfterNumber";
			this.comboBoxStringAfterNumber.Size = new System.Drawing.Size(322, 21);
			this.comboBoxStringAfterNumber.TabIndex = 8;
			this.comboBoxStringAfterNumber.Text = ".jpg";
			this.toolTip.SetToolTip(this.comboBoxStringAfterNumber, "Eingabe des Textes nach der Zahlenangabe");
			// 
			// comboBoxStringBeforeNumber
			// 
			this.comboBoxStringBeforeNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBoxStringBeforeNumber.Location = new System.Drawing.Point(12, 25);
			this.comboBoxStringBeforeNumber.Name = "comboBoxStringBeforeNumber";
			this.comboBoxStringBeforeNumber.Size = new System.Drawing.Size(322, 21);
			this.comboBoxStringBeforeNumber.TabIndex = 1;
			this.comboBoxStringBeforeNumber.Text = "http://www.domain.com/files/picture";
			this.toolTip.SetToolTip(this.comboBoxStringBeforeNumber, "Eingabe des Textes vor der Zahlenangabe");
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(9, 246);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(51, 13);
			this.labelResult.TabIndex = 16;
			this.labelResult.Text = "E&rgebnis:";
			// 
			// NumericListGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 472);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.comboBoxStringBeforeNumber);
			this.Controls.Add(this.comboBoxStringAfterNumber);
			this.Controls.Add(this.buttonCreateListe);
			this.Controls.Add(this.buttonInformationAboutApp);
			this.Controls.Add(this.buttonExitApp);
			this.Controls.Add(this.progressBarProcress);
			this.Controls.Add(this.labelProcress);
			this.Controls.Add(this.textBoxList);
			this.Controls.Add(this.buttonDeleteList);
			this.Controls.Add(this.buttonSaveList);
			this.Controls.Add(this.buttonCopyList);
			this.Controls.Add(this.buttonAddToList);
			this.Controls.Add(this.checkBoxFillWithZeros);
			this.Controls.Add(this.numericUpDownNumberMaximum);
			this.Controls.Add(this.labelNumberMax);
			this.Controls.Add(this.numericUpDownNumberMinimum);
			this.Controls.Add(this.labelNumberMin);
			this.Controls.Add(this.labelStringAfterNumber);
			this.Controls.Add(this.labelStringBeforeNumber);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "NumericListGeneratorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Numeric List Generator";
			this.Load += new System.EventHandler(this.NumericListGeneratorForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberMinimum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberMaximum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelStringBeforeNumber;
    private System.Windows.Forms.Label labelStringAfterNumber;
    private System.Windows.Forms.Label labelNumberMin;
    private System.Windows.Forms.NumericUpDown numericUpDownNumberMinimum;
    private System.Windows.Forms.Label labelNumberMax;
    private System.Windows.Forms.NumericUpDown numericUpDownNumberMaximum;
    private System.Windows.Forms.CheckBox checkBoxFillWithZeros;
    private System.Windows.Forms.Button buttonAddToList;
    private System.Windows.Forms.Button buttonCopyList;
    private System.Windows.Forms.Button buttonSaveList;
    private System.Windows.Forms.Button buttonDeleteList;
    private System.Windows.Forms.TextBox textBoxList;
    private System.Windows.Forms.Label labelProcress;
    private System.Windows.Forms.ProgressBar progressBarProcress;
    private System.Windows.Forms.Button buttonExitApp;
    private System.Windows.Forms.Button buttonInformationAboutApp;
		private System.Windows.Forms.Button buttonCreateListe;
		private System.Windows.Forms.ComboBox comboBoxStringAfterNumber;
		private System.Windows.Forms.ComboBox comboBoxStringBeforeNumber;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label labelResult;
	}
}

