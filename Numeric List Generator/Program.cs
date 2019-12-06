using System;
using System.Windows.Forms;

namespace NumericListGenerator
{
  /// <summary>
  /// Program
  /// </summary>
  internal static class Program
  {
    /// <summary>
    /// main entrance point of the application
    /// </summary>
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(defaultValue: false);
      using (NumericListGeneratorForm numericListGenerator = new NumericListGeneratorForm())
      {
        Application.Run(mainForm: numericListGenerator);
      }
    }
  }
}
