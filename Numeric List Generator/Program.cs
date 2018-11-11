using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumericListGenerator
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(true);
      Application.Run(new NumericListGeneratorForm());
    }
  }
}
