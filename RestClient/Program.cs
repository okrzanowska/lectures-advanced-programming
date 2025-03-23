class RestClient
{
    static async Task Main()
    {
        using var client = new HttpClient();
        string url = "http://localhost:5129/api/calculator/add?a=5&b=10";

        var response = await client.GetStringAsync(url);
        Console.WriteLine($"Response from server: {response}");
    }
}
