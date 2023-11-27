using EcomersCryptoLib;
using EComersDBworkerLib;
using EComersObjectLib;

using (var context = new EComersContext())
{
    //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    EComersDBInitializer.EComersDBInitializ(context, true);
}

Console.WriteLine("Test HashPassword");
string password = "password1234";
Console.WriteLine(password);
string pasHash = EcomersCrypto.GetHashPassword(password);
Console.WriteLine(pasHash);

Console.WriteLine("Test VerifyHashPassword");
if (EcomersCrypto.VerifyHashedPassword(EcomersCrypto.GetHashPassword(password), password))
{
    Console.WriteLine("OK");
}
else
{
    Console.WriteLine("False");
}

Console.WriteLine("Test EComersDBworkerLib");

Console.WriteLine("EComersDBworkerLib.CreateEmploye");
/*
Employe employe = new Employe()
{
    CreatedDate = DateTime.UtcNow,
    CreatedUserId = 1

};

EmployeHistory employeHistory = new EmployeHistory()
{
    Name = "TestEmployeName",
    SecondName = "TestEmployeSecondName",
    MiddleName = "TestEmployeMiddleName",
    GenderId = 1,
    BirthDay = DateTime.UtcNow,
    PhoneNumber = "453548",
    PhoneNumberSecond = "346201",
    Email = "shtefan88@mail.ru",
    StatusId = 1,
    NumHistory = 1,
    StartDate = DateTime.UtcNow,
    EndDate = DateTime.MaxValue,
    UserId = 1
};

EComersDBWorker EComersDBWorker = new EComersDBWorker(new EComersContext());
EComersDBWorker.CreateEmploye(employe, employeHistory);

Console.WriteLine(new EComersContext().Employe.First().CreatedDate.ToString());
DateTime CreatedDate = new EComersContext().Employe.First().CreatedDate;
*/
//Console.WriteLine( TimeZoneInfo.Local);
//Console.WriteLine(CreatedDate.ToString());
//Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(CreatedDate, TimeZoneInfo.Local) );

Console.WriteLine("InitComplite!!!");
Console.ReadKey();