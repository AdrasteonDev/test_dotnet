// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

public class Account
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DOB { get; set; }

    public static void Main(string[] args)
    {
        Account account = new Account
        {
            Name = "John Doe",
            Email = "john@microsoft.com",
            DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
        };
        string json = JsonConvert.SerializeObject(account, Newtonsoft.Json.Formatting.Indented);


        Console.WriteLine(json);
    }
}
