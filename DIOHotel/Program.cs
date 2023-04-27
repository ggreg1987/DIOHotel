using DIOHotel.models;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

Console.WriteLine("---------Wellcome to DIOHOTEL---------- \n");

Console.WriteLine("1 - Add a new client");
Console.WriteLine("2 - Suite \n");

int add = int.Parse(Console.ReadLine());
if(add != 1 &&  add != 2)
{
    throw new Exception("Press 1 or 2");
}


add = 1;
if (add == 1)
{
    Client client = new Client();
    Reserve reserve = new Reserve();

    while (add == 1)
    {
        Console.WriteLine("Name");
        client.Name = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("LastName");
        client.LastName = Console.ReadLine();
        Console.WriteLine("\n");

        Console.WriteLine("CredCard");
        Console.WriteLine("1 - VISA");
        Console.WriteLine("2 - MASTERCARD");
        Console.WriteLine("Or Press Enter");
        client.CredCard = Console.ReadLine();

        reserve.SaveClient(client);

        Console.WriteLine("1 - Add a new client");
        Console.WriteLine("2 - Suite \n");
        add = int.Parse(Console.ReadLine());
    }

    Suite free = new(suiteName: "BE FREE", capacity: 2, dailyValue: 50);
    Suite pro = new(suiteName: "BE PRO", capacity: 4, dailyValue: 100);
    Suite global = new(suiteName: "BE GLOBAL", capacity: 7, dailyValue: 150);

    Console.WriteLine(free.ShowSuite);
    Console.WriteLine(pro.ShowSuite);
    Console.WriteLine(global.ShowSuite + "\n \n");

    Console.WriteLine("Choose a Suite \n");
    Console.WriteLine("1 - BE FREE");
    Console.WriteLine("2 - BE PRO");
    Console.WriteLine("3 - BE HOTEL");

    int suite = int.Parse(Console.ReadLine());

    Console.WriteLine("Days \n");
    reserve.ReservedDays = int.Parse(Console.ReadLine());
    var peoples = reserve.AllClient();

    int allClients = 0;
    for (int i = 0; i < peoples.Count; i++)
    {
        allClients++;
    }
    if (suite == 1)
    {
        reserve.CapacityRoom(free.Capacity, allClients);
        var total = reserve.TotalDaily(reserve.ReservedDays, free.DailyValue);
        Console.WriteLine($"People- {allClients} \n" +
                          $"Suite - {free.SuiteName} \n" +
                          $"Total - {total}");

    }
    else if (suite == 2)
    {
        reserve.CapacityRoom(pro.Capacity, allClients);
        var total = reserve.TotalDaily(reserve.ReservedDays, pro.DailyValue);
        Console.WriteLine($"People- {allClients} \n" +
                         $"Suite - {pro.SuiteName} \n" +
                         $"Total - {total}");
    }
    else
    {
        reserve.CapacityRoom(global.Capacity, allClients);
        var total = reserve.TotalDaily(reserve.ReservedDays, global.DailyValue);
        Console.WriteLine($"People- {allClients} \n" +
                         $"Suite - {global.SuiteName} \n" +
                         $"Total - {total}");
    }

}
