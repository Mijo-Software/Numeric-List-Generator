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
			this.buttonCreateList = new System.Windows.Forms.Button();
			this.buttonInformationAboutApp = new System.Windows.Forms.Button();
			this.buttonExitApp = new System.Windows.Forms.Button();
			this.buttonDeleteList = new System.Windows.Forms.Button();
			this.buttonSaveList = new System.Windows.Forms.Button();
			this.buttonCopyList = new System.Windows.Forms.Button();
			this.buttonAddToList = new System.Windows.Forms.Button();
			this.comboBoxStringAfterNumber = new System.Windows.Forms.ComboBox();
			this.comboBoxStringBeforeNumber = new System.Windows.Forms.ComboBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
			this.labelResult = new System.Windows.Forms.Label();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberMinimum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberMaximum)).BeginInit();
			this.SuspendLayout();
			// 
			// labelStringBeforeNumber
			// 
			resources.ApplyResources(this.labelStringBeforeNumber, "labelStringBeforeNumber");
			this.labelStringBeforeNumber.Name = "labelStringBeforeNumber";
			// 
			// labelStringAfterNumber
			// 
			resources.ApplyResources(this.labelStringAfterNumber, "labelStringAfterNumber");
			this.labelStringAfterNumber.Name = "labelStringAfterNumber";
			// 
			// labelNumberMin
			// 
			resources.ApplyResources(this.labelNumberMin, "labelNumberMin");
			this.labelNumberMin.Name = "labelNumberMin";
			// 
			// numericUpDownNumberMinimum
			// 
			resources.ApplyResources(this.numericUpDownNumberMinimum, "numericUpDownNumberMinimum");
			this.numericUpDownNumberMinimum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericUpDownNumberMinimum.Name = "numericUpDownNumberMinimum";
			this.toolTip.SetToolTip(this.numericUpDownNumberMinimum, resources.GetString("numericUpDownNumberMinimum.ToolTip"));
			this.numericUpDownNumberMinimum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// labelNumberMax
			// 
			resources.ApplyResources(this.labelNumberMax, "labelNumberMax");
			this.labelNumberMax.Name = "labelNumberMax";
			// 
			// numericUpDownNumberMaximum
			// 
			resources.ApplyResources(this.numericUpDownNumberMaximum, "numericUpDownNumberMaximum");
			this.numericUpDownNumberMaximum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.numericUpDownNumberMaximum.Name = "numericUpDownNumberMaximum";
			this.toolTip.SetToolTip(this.numericUpDownNumberMaximum, resources.GetString("numericUpDownNumberMaximum.ToolTip"));
			this.numericUpDownNumberMaximum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// checkBoxFillWithZeros
			// 
			resources.ApplyResources(this.checkBoxFillWithZeros, "checkBoxFillWithZeros");
			this.checkBoxFillWithZeros.Name = "checkBoxFillWithZeros";
			this.toolTip.SetToolTip(this.checkBoxFillWithZeros, resources.GetString("checkBoxFillWithZeros.ToolTip"));
			this.checkBoxFillWithZeros.UseVisualStyleBackColor = true;
			// 
			// textBoxList
			// 
			resources.ApplyResources(this.textBoxList, "textBoxList");
			this.textBoxList.Name = "textBoxList";
			this.toolTip.SetToolTip(this.textBoxList, resources.GetString("textBoxList.ToolTip"));
			// 
			// labelProcress
			// 
			resources.ApplyResources(this.labelProcress, "labelProcress");
			this.labelProcress.Name = "labelProcress";
			// 
			// progressBarProcress
			// 
			resources.ApplyResources(this.progressBarProcress, "progressBarProcress");
			this.progressBarProcress.Name = "progressBarProcress";
			this.progressBarProcress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.toolTip.SetToolTip(this.progressBarProcress, resources.GetString("progressBarProcress.ToolTip"));
			// 
			// buttonCreateList
			// 
			this.buttonCreateList.Image = global::NumericListGenerator.Properties.Resources.gear_in;
			resources.ApplyResources(this.buttonCreateList, "buttonCreateList");
			this.buttonCreateList.Name = "buttonCreateList";
			this.toolTip.SetToolTip(this.buttonCreateList, resources.GetString("buttonCreateList.ToolTip"));
			this.buttonCreateList.UseVisualStyleBackColor = true;
			this.buttonCreateList.Click += new System.EventHandler(this.ButtonCreateListe_Click);
			// 
			// buttonInformationAboutApp
			// 
			this.buttonInformationAboutApp.Image = global::NumericListGenerator.Properties.Resources.information;
			resources.ApplyResources(this.buttonInformationAboutApp, "buttonInformationAboutApp");
			this.buttonInformationAboutApp.Name = "buttonInformationAboutApp";
			this.toolTip.SetToolTip(this.buttonInformationAboutApp, resources.GetString("buttonInformationAboutApp.ToolTip"));
			this.buttonInformationAboutApp.UseVisualStyleBackColor = true;
			this.buttonInformationAboutApp.Click += new System.EventHandler(this.ButtonInformationAboutApp_Click);
			// 
			// buttonExitApp
			// 
			this.buttonExitApp.Image = global::NumericListGenerator.Properties.Resources.door_open;
			resources.ApplyResources(this.buttonExitApp, "buttonExitApp");
			this.buttonExitApp.Name = "buttonExitApp";
			this.toolTip.SetToolTip(this.buttonExitApp, resources.GetString("buttonExitApp.ToolTip"));
			this.buttonExitApp.UseVisualStyleBackColor = true;
			this.buttonExitApp.Click += new System.EventHandler(this.ButtonExitApp_Click);
			// 
			// buttonDeleteList
			// 
			this.buttonDeleteList.Image = global::NumericListGenerator.Properties.Resources.bin_empty;
			resources.ApplyResources(this.buttonDeleteList, "buttonDeleteList");
			this.buttonDeleteList.Name = "buttonDeleteList";
			this.toolTip.SetToolTip(this.buttonDeleteList, resources.GetString("buttonDeleteList.ToolTip"));
			this.buttonDeleteList.UseVisualStyleBackColor = true;
			this.buttonDeleteList.Click += new System.EventHandler(this.ButtonDeleteList_Click);
			// 
			// buttonSaveList
			// 
			this.buttonSaveList.Image = global::NumericListGenerator.Properties.Resources.diskette;
			resources.ApplyResources(this.buttonSaveList, "buttonSaveList");
			this.buttonSaveList.Name = "buttonSaveList";
			this.toolTip.SetToolTip(this.buttonSaveList, resources.GetString("buttonSaveList.ToolTip"));
			this.buttonSaveList.UseVisualStyleBackColor = true;
			this.buttonSaveList.Click += new System.EventHandler(this.ButtonSaveList_Click);
			// 
			// buttonCopyList
			// 
			this.buttonCopyList.Image = global::NumericListGenerator.Properties.Resources.page_copy;
			resources.ApplyResources(this.buttonCopyList, "buttonCopyList");
			this.buttonCopyList.Name = "buttonCopyList";
			this.toolTip.SetToolTip(this.buttonCopyList, resources.GetString("buttonCopyList.ToolTip"));
			this.buttonCopyList.UseVisualStyleBackColor = true;
			this.buttonCopyList.Click += new System.EventHandler(this.ButtonCopyList_Click);
			// 
			// buttonAddToList
			// 
			this.buttonAddToList.Image = global::NumericListGenerator.Properties.Resources.add;
			resources.ApplyResources(this.buttonAddToList, "buttonAddToList");
			this.buttonAddToList.Name = "buttonAddToList";
			this.toolTip.SetToolTip(this.buttonAddToList, resources.GetString("buttonAddToList.ToolTip"));
			this.buttonAddToList.UseVisualStyleBackColor = true;
			this.buttonAddToList.Click += new System.EventHandler(this.ButtonAddToList_Click);
			// 
			// comboBoxStringAfterNumber
			// 
			this.comboBoxStringAfterNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			resources.ApplyResources(this.comboBoxStringAfterNumber, "comboBoxStringAfterNumber");
			this.comboBoxStringAfterNumber.Name = "comboBoxStringAfterNumber";
			this.toolTip.SetToolTip(this.comboBoxStringAfterNumber, resources.GetString("comboBoxStringAfterNumber.ToolTip"));
			// 
			// comboBoxStringBeforeNumber
			// 
			this.comboBoxStringBeforeNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			resources.ApplyResources(this.comboBoxStringBeforeNumber, "comboBoxStringBeforeNumber");
			this.comboBoxStringBeforeNumber.Name = "comboBoxStringBeforeNumber";
			this.toolTip.SetToolTip(this.comboBoxStringBeforeNumber, resources.GetString("comboBoxStringBeforeNumber.ToolTip"));
			// 
			// comboBoxLanguage
			// 
			this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLanguage.FormattingEnabled = true;
			resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
			this.comboBoxLanguage.Name = "comboBoxLanguage";
			this.toolTip.SetToolTip(this.comboBoxLanguage, resources.GetString("comboBoxLanguage.ToolTip"));
			this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguage_SelectedIndexChanged);
			// 
			// labelResult
			// 
			resources.ApplyResources(this.labelResult, "labelResult");
			this.labelResult.Name = "labelResult";
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
			// 
			// NumericListGenerator
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.comboBoxLanguage);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.comboBoxStringBeforeNumber);
			this.Controls.Add(this.comboBoxStringAfterNumber);
			this.Controls.Add(this.buttonCreateList);
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
			this.MaximizeBox = false;
			this.Name = "NumericListGenerator";
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
		private System.Windows.Forms.Button buttonCreateList;
		private System.Windows.Forms.ComboBox comboBoxStringAfterNumber;
		private System.Windows.Forms.ComboBox comboBoxStringBeforeNumber;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.ComboBox comboBoxLanguage;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
	}
}

