using System.Reflection;

namespace Numeric_List_Generator
{
	/// <summary>
	/// Provides access to various assembly metadata attributes such as title, version, description, product, copyright, and company.
	/// </summary>
	public static class AssemblyInfo
	{
		#region Assembly attribute accessors

		/// <summary>
		/// Gets the title of the assembly.
		/// If the AssemblyTitleAttribute is not set, returns the file name without extension.
		/// </summary>
		public static string AssemblyTitle
		{
			get
			{
				// Retrieve all AssemblyTitleAttribute attributes from the executing assembly
				object[] attributes = Assembly.GetExecutingAssembly()
					.GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);

				// If the attribute exists and has a non-empty title, return it; otherwise, return the file name
				return attributes.Length > 0 && attributes[0] is AssemblyTitleAttribute titleAttribute
					? !string.IsNullOrEmpty(value: titleAttribute.Title) ? titleAttribute.Title : Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().Location)
					: Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().Location);
			}
		}

		/// <summary>
		/// Gets the version of the assembly as a string.
		/// Returns an empty string if the version is not available.
		/// </summary>
		public static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? string.Empty;

		/// <summary>
		/// Gets the description of the assembly.
		/// Returns an empty string if the AssemblyDescriptionAttribute is not set.
		/// </summary>
		public static string AssemblyDescription
		{
			get
			{
				// Retrieve all AssemblyDescriptionAttribute attributes from the executing assembly
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);

				// Return the description if available, otherwise an empty string
				return attributes.Length == 0 ? string.Empty : ((AssemblyDescriptionAttribute)attributes[0]).Description;
			}
		}

		/// <summary>
		/// Gets the product name of the assembly.
		/// Returns an empty string if the AssemblyProductAttribute is not set.
		/// </summary>
		public static string AssemblyProduct
		{
			get
			{
				// Retrieve all AssemblyProductAttribute attributes from the executing assembly
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);

				// Return the product name if available, otherwise an empty string
				return attributes.Length == 0 ? string.Empty : ((AssemblyProductAttribute)attributes[0]).Product;
			}
		}

		/// <summary>
		/// Gets the copyright information of the assembly.
		/// Returns an empty string if the AssemblyCopyrightAttribute is not set.
		/// </summary>
		public static string AssemblyCopyright
		{
			get
			{
				// Retrieve all AssemblyCopyrightAttribute attributes from the executing assembly
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);

				// Return the copyright if available, otherwise an empty string
				return attributes.Length == 0 ? string.Empty : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
			}
		}

		/// <summary>
		/// Gets the company name of the assembly.
		/// Returns an empty string if the AssemblyCompanyAttribute is not set.
		/// </summary>
		public static string AssemblyCompany
		{
			get
			{
				// Retrieve all AssemblyCompanyAttribute attributes from the executing assembly
				object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);

				// Return the company name if available, otherwise an empty string
				return attributes.Length == 0 ? string.Empty : ((AssemblyCompanyAttribute)attributes[0]).Company;
			}
		}

		#endregion
	}
}