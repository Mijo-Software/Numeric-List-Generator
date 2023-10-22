namespace Numeric_List_Generator
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(mainForm: new NumericListGeneratorForm());
		}
	}
}