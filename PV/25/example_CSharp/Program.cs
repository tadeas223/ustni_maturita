using System.Text.RegularExpressions;

Regex re = new Regex("([+]\\d{3})?([ ]?\\d{3}){3}");

while(true)
{
    Console.Write("check number:");
    string input = Console.ReadLine()!;
    if(input == "exit")
    {
        break;
    }
    
    Console.WriteLine($"is number: {re.IsMatch(input)}");
}
