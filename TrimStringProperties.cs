using System.Reflection;

public static partial class ExtensionClasses
{
	public static void TrimStringProperties(this object obj)
	{
		PropertyInfo[] properties = obj.GetType().GetProperties();

		foreach (PropertyInfo property in properties)
		{
			if (property.PropertyType != typeof(string))
			{
				continue;
			}

			if (!property.CanRead || !property.CanWrite)
			{
				continue;
			}

			string value = (string)property.GetValue(obj);

			if (value == null)
			{
				continue;
			}

			string trimmed = value.Trim();
			if (trimmed != value) // only set if changed
			{
				property.SetValue(obj, trimmed);
			}
		}
	}
}