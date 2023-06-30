namespace Utilities;

public static partial class U
{
	public static bool IsNullOrEmpty(this string str)
	{
		return string.IsNullOrEmpty(str);
	}
	
	public static bool IsNotNullOrEmpty(this string str)
	{
		return string.IsNullOrEmpty(str) is false;
	}
}
