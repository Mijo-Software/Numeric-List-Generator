using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NumericListGenerator
{
  public partial class NumericListGeneratorForm : Form
  {
    public NumericListGeneratorForm()
    {
      InitializeComponent();
    }

    private void NumericListGeneratorForm_Load(object sender, EventArgs e)
    {

    }

    private void buttonCreateList_Click(object sender, EventArgs e)
    {
      progressBarProcress.Minimum = 0;
      progressBarProcress.Maximum = (int)numericUpDownNumberMaximum.Value;
      progressBarProcress.Step = 1;
      for (int i = (int)numericUpDownNumberMinimum.Value; i < (int)numericUpDownNumberMaximum.Value + 1; i++)
      {
        string strTemp = "";
        //progressBarProcress.Increment(1);
        progressBarProcress.Value = i;
        if (checkBoxFillWithZeros.Checked)
        {
          if (i < 1000000000 && numericUpDownNumberMaximum.Value > 999999999) strTemp = strTemp + "0";
          if (i < 100000000 && numericUpDownNumberMaximum.Value > 99999999) strTemp = strTemp + "0";
          if (i < 10000000 && numericUpDownNumberMaximum.Value > 9999999) strTemp = strTemp + "0";
          if (i < 1000000 && numericUpDownNumberMaximum.Value > 999999) strTemp = strTemp + "0";
          if (i < 100000 && numericUpDownNumberMaximum.Value > 99999) strTemp = strTemp + "0";
          if (i < 10000 && numericUpDownNumberMaximum.Value > 9999) strTemp = strTemp + "0";
          if (i < 1000 && numericUpDownNumberMaximum.Value > 999) strTemp = strTemp + "0";
          if (i < 100 && numericUpDownNumberMaximum.Value > 99) strTemp = strTemp + "0";
          if (i < 10 && numericUpDownNumberMaximum.Value > 9) strTemp = strTemp + "0";
        }
        textBoxList.Text = textBoxList.Text + textBoxStringBeforeNumber.Text + strTemp + i.ToString() + textBoxStringAfterNumber.Text + "\r\n";
      }
    }

    private void buttonCopyList_Click(object sender, EventArgs e)
    {
      textBoxList.SelectAll();
      textBoxList.Copy();
    }

    private void buttonSaveList_Click(object sender, EventArgs e)
    {
        SaveFileDialog save = new SaveFileDialog();
        save.FileName = "DefaultOutputName.txt";
        save.Filter = "Text File | *.txt";
        if (save.ShowDialog() == DialogResult.OK)
        {
            StreamWriter writer = new StreamWriter(save.OpenFile());
            writer.WriteLine(textBoxList.Text);
            writer.Dispose();
            writer.Close();
        }
    }

    private void buttonDeleteList_Click(object sender, EventArgs e)
    {
      textBoxList.Clear();
    }

    private void buttonInformationAboutApp_Click(object sender, EventArgs e)
    {
      AboutBoxForm formAboutBox = new AboutBoxForm();
      formAboutBox.ShowDialog();
    }

    private void buttonExitApp_Click(object sender, EventArgs e)
    {
      Close();
    }

  }
}
