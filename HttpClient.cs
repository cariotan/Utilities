namespace ManagedNetworks.Net;

public static class HttpClient
{
	private static System.Net.Http.HttpClient httpClient;

	public static System.Net.Http.HttpClient Get() => httpClient;

	static HttpClient()
	{
		SocketsHttpHandler handler = new()
		{
			PooledConnectionLifetime = TimeSpan.FromMinutes(2)
		};

		httpClient = new System.Net.Http.HttpClient(handler);
		httpClient.BaseAddress = new Uri(Config.Host);
	}
}