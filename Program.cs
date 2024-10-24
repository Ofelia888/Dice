
using System.ComponentModel.Design;
using System.Security.Cryptography;

var r = new Random();
int dice = r.Next(20) + 1;

Console.WriteLine(dice);

if (dice >= 10)
{
    if (dice == 20)
        Console.WriteLine("CRITICAL HIT");
    else
    Console.WriteLine("HIT!");
}
else if (dice >5)
    Console.WriteLine("WEAK");
else
{
    Console.WriteLine("MISS");
}
