using System.Diagnostics;
using NLog;

namespace Numeric_List_Generator
{
	/// <summary>
	/// Main class of the program.
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			try
			{
				// Initializes the application configurations
				ApplicationConfiguration.Initialize();
				Logger.Info(message: "Anwendung gestartet.");

				// Starts the main form of the application
				using NumericListGeneratorForm mainForm = new();
				Application.Run(mainForm);
			}
			catch (InvalidOperationException ex)
			{
				// Handle specific InvalidOperationException
				string message = "Ein ungültiger Vorgang ist aufgetreten. Bitte versuchen Sie es erneut.";
				Debug.WriteLine(value: ex);
				Logger.Error(exception: ex, message: message);
				LogError(ex);
				ShowErrorMessage(message: message);
			}
			catch (Exception ex)
			{
				// Error handling: Log the error and display an error message
				string message = "Ein unerwarteter Fehler ist aufgetreten. Bitte kontaktieren Sie den Support.";
				Debug.WriteLine(value: ex);
				Logger.Error(exception: ex, message: message);
				LogError(ex);
				ShowErrorMessage(message: message);
			}
		}

		/// <summary>
		/// Logs the error details to the console or a logging system.
		/// </summary>
		/// <param name="ex">The exception to log.</param>
		private static void LogError(Exception ex)
		{
			// Implement logging logic here (e.g., log to a file or monitoring system)
			Console.WriteLine(value: $"Fehler: {ex.Message}\n{ex.StackTrace}");
		}

		/// <summary>
		/// Displays an error message to the user.
		/// </summary>
		/// <param name="message">The error message to display.</param>
		private static void ShowErrorMessage(string message)
		{
			_ = MessageBox.Show(text: message, caption: "Fehler", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}
	}
}