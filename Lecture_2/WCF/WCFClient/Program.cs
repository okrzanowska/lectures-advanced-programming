using CalculatorService; // take care about namespace from your project form service reference

class Program
{
    static async Task Main()
    {
        var client = new CalculatorServiceClient();

        try
        {
            int a = 30, b = 5;

            int sum = await client.AddAsync(a, b);
            Console.WriteLine($"{a} + {b} = {sum}");

            int difference = await client.SubtractAsync(a, b);
            Console.WriteLine($"{a} - {b} = {difference}");

            int multiplication = await client.MultiplyAsync(a, b);
            Console.WriteLine($"{a} * {b} = {multiplication}");

            int division = await client.DivideAsync(a, b);
            Console.WriteLine($"{a} / {b} = {division}");

            Console.WriteLine("Press any key to close the client...");
            Console.ReadLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during executing SOAP: " + ex.Message);
        }
        finally
        {
            await client.CloseAsync(); //optional but recommended action
        }
    }
}
