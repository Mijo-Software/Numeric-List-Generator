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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumericListGeneratorForm));
      this.labelStringBeforeNumber = new System.Windows.Forms.Label();
      this.textBoxStringBeforeNumber = new System.Windows.Forms.TextBox();
      this.textBoxStringAfterNumber = new System.Windows.Forms.TextBox();
      this.labelStringAfterNumber = new System.Windows.Forms.Label();
      this.labelNumberMin = new System.Windows.Forms.Label();
      this.numericUpDownNumberMinimum = new System.Windows.Forms.NumericUpDown();
      this.labelNumberMax = new System.Windows.Forms.Label();
      this.numericUpDownNumberMaximum = new System.Windows.Forms.NumericUpDown();
      this.checkBoxFillWithZeros = new System.Windows.Forms.CheckBox();
      this.buttonCreateList = new System.Windows.Forms.Button();
      this.buttonCopyList = new System.Windows.Forms.Button();
      this.buttonSaveList = new System.Windows.Forms.Button();
      this.buttonDeleteList = new System.Windows.Forms.Button();
      this.textBoxList = new System.Windows.Forms.TextBox();
      this.labelProcress = new System.Windows.Forms.Label();
      this.progressBarProcress = new System.Windows.Forms.ProgressBar();
      this.buttonExitApp = new System.Windows.Forms.Button();
      this.buttonInformationAboutApp = new System.Windows.Forms.Button();
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
      // textBoxStringBeforeNumber
      // 
      this.textBoxStringBeforeNumber.Location = new System.Drawing.Point(12, 25);
      this.textBoxStringBeforeNumber.Name = "textBoxStringBeforeNumber";
      this.textBoxStringBeforeNumber.Size = new System.Drawing.Size(322, 20);
      this.textBoxStringBeforeNumber.TabIndex = 1;
      this.textBoxStringBeforeNumber.Text = "http://www.domain.com/files/picture";
      // 
      // textBoxStringAfterNumber
      // 
      this.textBoxStringAfterNumber.Location = new System.Drawing.Point(12, 109);
      this.textBoxStringAfterNumber.Name = "textBoxStringAfterNumber";
      this.textBoxStringAfterNumber.Size = new System.Drawing.Size(322, 20);
      this.textBoxStringAfterNumber.TabIndex = 8;
      this.textBoxStringAfterNumber.Text = ".jpg";
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
      this.checkBoxFillWithZeros.Text = "mit Nullen &auffüllen";
      this.checkBoxFillWithZeros.UseVisualStyleBackColor = true;
      // 
      // buttonCreateList
      // 
      this.buttonCreateList.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateList.Image")));
      this.buttonCreateList.Location = new System.Drawing.Point(12, 144);
      this.buttonCreateList.Name = "buttonCreateList";
      this.buttonCreateList.Size = new System.Drawing.Size(102, 26);
      this.buttonCreateList.TabIndex = 9;
      this.buttonCreateList.Text = "Liste &erstellen";
      this.buttonCreateList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonCreateList.UseVisualStyleBackColor = true;
      this.buttonCreateList.Click += new System.EventHandler(this.buttonCreateList_Click);
      // 
      // buttonCopyList
      // 
      this.buttonCopyList.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopyList.Image")));
      this.buttonCopyList.Location = new System.Drawing.Point(120, 144);
      this.buttonCopyList.Name = "buttonCopyList";
      this.buttonCopyList.Size = new System.Drawing.Size(104, 26);
      this.buttonCopyList.TabIndex = 10;
      this.buttonCopyList.Text = "Liste &kopieren";
      this.buttonCopyList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonCopyList.UseVisualStyleBackColor = true;
      this.buttonCopyList.Click += new System.EventHandler(this.buttonCopyList_Click);
      // 
      // buttonSaveList
      // 
      this.buttonSaveList.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveList.Image")));
      this.buttonSaveList.Location = new System.Drawing.Point(230, 144);
      this.buttonSaveList.Name = "buttonSaveList";
      this.buttonSaveList.Size = new System.Drawing.Size(104, 26);
      this.buttonSaveList.TabIndex = 11;
      this.buttonSaveList.Text = "Liste &speichern";
      this.buttonSaveList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonSaveList.UseVisualStyleBackColor = true;
      this.buttonSaveList.Click += new System.EventHandler(this.buttonSaveList_Click);
      // 
      // buttonDeleteList
      // 
      this.buttonDeleteList.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteList.Image")));
      this.buttonDeleteList.Location = new System.Drawing.Point(232, 386);
      this.buttonDeleteList.Name = "buttonDeleteList";
      this.buttonDeleteList.Size = new System.Drawing.Size(102, 26);
      this.buttonDeleteList.TabIndex = 17;
      this.buttonDeleteList.Text = "Liste &löschen";
      this.buttonDeleteList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonDeleteList.UseVisualStyleBackColor = true;
      this.buttonDeleteList.Click += new System.EventHandler(this.buttonDeleteList_Click);
      // 
      // textBoxList
      // 
      this.textBoxList.Location = new System.Drawing.Point(12, 213);
      this.textBoxList.MaxLength = 2147483647;
      this.textBoxList.Multiline = true;
      this.textBoxList.Name = "textBoxList";
      this.textBoxList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxList.Size = new System.Drawing.Size(322, 167);
      this.textBoxList.TabIndex = 14;
      this.textBoxList.WordWrap = false;
      // 
      // labelProcress
      // 
      this.labelProcress.AutoSize = true;
      this.labelProcress.Location = new System.Drawing.Point(12, 183);
      this.labelProcress.Name = "labelProcress";
      this.labelProcress.Size = new System.Drawing.Size(70, 13);
      this.labelProcress.TabIndex = 12;
      this.labelProcress.Text = "Verarbeitung:";
      // 
      // progressBarProcress
      // 
      this.progressBarProcress.Location = new System.Drawing.Point(88, 183);
      this.progressBarProcress.Name = "progressBarProcress";
      this.progressBarProcress.Size = new System.Drawing.Size(246, 17);
      this.progressBarProcress.TabIndex = 13;
      // 
      // buttonExitApp
      // 
      this.buttonExitApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitApp.Image")));
      this.buttonExitApp.Location = new System.Drawing.Point(12, 386);
      this.buttonExitApp.Name = "buttonExitApp";
      this.buttonExitApp.Size = new System.Drawing.Size(130, 26);
      this.buttonExitApp.TabIndex = 15;
      this.buttonExitApp.Text = "Programm &beenden";
      this.buttonExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonExitApp.UseVisualStyleBackColor = true;
      this.buttonExitApp.Click += new System.EventHandler(this.buttonExitApp_Click);
      // 
      // buttonInformationAboutApp
      // 
      this.buttonInformationAboutApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonInformationAboutApp.Image")));
      this.buttonInformationAboutApp.Location = new System.Drawing.Point(148, 386);
      this.buttonInformationAboutApp.Name = "buttonInformationAboutApp";
      this.buttonInformationAboutApp.Size = new System.Drawing.Size(58, 26);
      this.buttonInformationAboutApp.TabIndex = 16;
      this.buttonInformationAboutApp.Text = "&Info";
      this.buttonInformationAboutApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonInformationAboutApp.UseVisualStyleBackColor = true;
      this.buttonInformationAboutApp.Click += new System.EventHandler(this.buttonInformationAboutApp_Click);
      // 
      // NumericListGeneratorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(346, 422);
      this.Controls.Add(this.buttonInformationAboutApp);
      this.Controls.Add(this.buttonExitApp);
      this.Controls.Add(this.progressBarProcress);
      this.Controls.Add(this.labelProcress);
      this.Controls.Add(this.textBoxList);
      this.Controls.Add(this.buttonDeleteList);
      this.Controls.Add(this.buttonSaveList);
      this.Controls.Add(this.buttonCopyList);
      this.Controls.Add(this.buttonCreateList);
      this.Controls.Add(this.checkBoxFillWithZeros);
      this.Controls.Add(this.numericUpDownNumberMaximum);
      this.Controls.Add(this.labelNumberMax);
      this.Controls.Add(this.numericUpDownNumberMinimum);
      this.Controls.Add(this.labelNumberMin);
      this.Controls.Add(this.textBoxStringAfterNumber);
      this.Controls.Add(this.labelStringAfterNumber);
      this.Controls.Add(this.textBoxStringBeforeNumber);
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
    private System.Windows.Forms.TextBox textBoxStringBeforeNumber;
    private System.Windows.Forms.TextBox textBoxStringAfterNumber;
    private System.Windows.Forms.Label labelStringAfterNumber;
    private System.Windows.Forms.Label labelNumberMin;
    private System.Windows.Forms.NumericUpDown numericUpDownNumberMinimum;
    private System.Windows.Forms.Label labelNumberMax;
    private System.Windows.Forms.NumericUpDown numericUpDownNumberMaximum;
    private System.Windows.Forms.CheckBox checkBoxFillWithZeros;
    private System.Windows.Forms.Button buttonCreateList;
    private System.Windows.Forms.Button buttonCopyList;
    private System.Windows.Forms.Button buttonSaveList;
    private System.Windows.Forms.Button buttonDeleteList;
    private System.Windows.Forms.TextBox textBoxList;
    private System.Windows.Forms.Label labelProcress;
    private System.Windows.Forms.ProgressBar progressBarProcress;
    private System.Windows.Forms.Button buttonExitApp;
    private System.Windows.Forms.Button buttonInformationAboutApp;
  }
}

