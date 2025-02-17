namespace Numeric_List_Generator
{
	/// <summary>
	/// Main class of the program.
	/// </summary>
	internal static class Program
	{
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

				// Starts the main form of the application
				using NumericListGeneratorForm mainForm = new();
				Application.Run(mainForm);
			}
			catch (InvalidOperationException ex)
			{
				// Handle specific InvalidOperationException
				LogError(ex);
				ShowErrorMessage(message: "An invalid operation occurred. Please try again.");
			}
			catch (Exception ex)
			{
				// Error handling: Log the error and display an error message
				LogError(ex);
				ShowErrorMessage(message: "An unexpected error occurred. Please contact support.");
			}
		}

		/// <summary>
		/// Logs the error details to the console or a logging system.
		/// </summary>
		/// <param name="ex">The exception to log.</param>
		private static void LogError(Exception ex)
		{
			// Implement logging logic here (e.g., log to a file or monitoring system)
			Console.WriteLine(value: $"Error: {ex.Message}\n{ex.StackTrace}");
		}

		/// <summary>
		/// Displays an error message to the user.
		/// </summary>
		/// <param name="message">The error message to display.</param>
		private static void ShowErrorMessage(string message)
		{
			_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}
	}
}