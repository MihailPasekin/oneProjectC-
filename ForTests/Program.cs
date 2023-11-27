// See https://aka.ms/new-console-template for more information
using EcomersCryptoLib;

Console.WriteLine(DateTime.Now.Date.AddDays(1).AddHours(7).ToString());
string exit = "no";
string pas = "";
string hashPas = "";
while (exit=="no")
{
    Console.WriteLine("Enter password: ");
    pas = Console.ReadLine();
    
    hashPas = EcomersCrypto.GetHashPassword(pas);
    Console.WriteLine(hashPas);

    Console.WriteLine("Test VerifyHashPassword");
    if (EcomersCrypto.VerifyHashedPassword(EcomersCrypto.GetHashPassword(pas), pas))
    {
        Console.WriteLine("OK");
    }
    else
    {
        Console.WriteLine("False");
    }
    exit = Console.ReadLine()??"no";
}

Console.ReadKey();
