﻿using System.Reflection;

namespace Utilities;

public static partial class U
{
	public static void TrimStringProperties(this object obj)
	{
		PropertyInfo[] properties = obj.GetType().GetProperties();

		foreach(PropertyInfo property in properties)
		{
			if(property.PropertyType != typeof(string))
			{
				continue;
			}

			string value = (string)property.GetValue(obj);

			if(value == null)
			{
				continue;
			}

			value = value.Trim();
			property.SetValue(obj, value);
		}
	}
}
