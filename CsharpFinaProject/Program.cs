using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Methods;
using CsharpFinaProject.Models;
using CsharpFinaProject.JSON_Control;
Console.Title = "BOSS AZ";
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

List<Employer>? employers = JsonEditor.JsonDeSerializeEmployers() as List<Employer>;

List<Worker>? workers = JsonEditor.JsonDeSerializeWorker() as List<Worker>;

void Loading()
{
    Console.CursorVisible = false;
    string sym = @"█";
    for (int i = 0; i < 100; i+=3)
    {
        if (i % 4 == 0) Console.ForegroundColor = ConsoleColor.Red;
        else if (i % 4 == 1) Console.ForegroundColor = ConsoleColor.Green;
        else if (i % 4 == 2) Console.ForegroundColor = ConsoleColor.Blue;
        else if (i % 4 == 3) Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(
@"
██╗   ██╗███████╗██████╗ ██╗███████╗██╗███╗   ██╗ ██████╗     ██████╗  █████╗ ████████╗ █████╗ 
██║   ██║██╔════╝██╔══██╗██║██╔════╝██║████╗  ██║██╔════╝     ██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗
██║   ██║█████╗  ██████╔╝██║█████╗  ██║██╔██╗ ██║██║  ███╗    ██║  ██║███████║   ██║   ███████║
╚██╗ ██╔╝██╔══╝  ██╔══██╗██║██╔══╝  ██║██║╚██╗██║██║   ██║    ██║  ██║██╔══██║   ██║   ██╔══██║
 ╚████╔╝ ███████╗██║  ██║██║██║     ██║██║ ╚████║╚██████╔╝    ██████╔╝██║  ██║   ██║   ██║  ██║
  ╚═══╝  ╚══════╝╚═╝  ╚═╝╚═╝╚═╝     ╚═╝╚═╝  ╚═══╝ ╚═════╝     ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝
");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"\n\n\t\t\t{i} %");
        Console.Write("\t\t\t");
        for (int j = 0; j < i / 3; j++)
        {
            Console.Write(sym);
        }
        if (i == 99)
            Thread.Sleep(1000);
        Thread.Sleep(20);
        Console.Clear();
    }
}

Console.CursorVisible = false;

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.WriteLine("\n\n\n\n\n\t▀█████████▄   ▄██████▄     ▄████████    ▄████████         ▄████████  ▄███████▄  ");
Console.WriteLine(         "\t  ███    ███ ███    ███   ███    █▀    ███    █▀         ███    ███       ▄███▀ ");
Console.WriteLine(         "\t ▄███▄▄▄██▀  ███    ███   ███          ███               ███    ███  ▀█▀▄███▀▄▄ ");
Console.WriteLine(         "\t▀▀███▀▀▀██▄  ███    ███ ▀███████████ ▀███████████      ▀███████████   ▄███▀   ▀ ");
Console.WriteLine(         "\t  ███    ██▄ ███    ███          ███          ███        ███    ███ ▄███▀       ");
Console.WriteLine(         "\t  ███    ███ ███    ███    ▄█    ███    ▄█    ███        ███    ███ ███▄     ▄█ ");
Console.WriteLine(         "\t▄█████████▀   ▀██████▀   ▄████████▀   ▄████████▀          ███    █▀   ▀████████▀ ");

Thread.Sleep(3000);

labelMenu:;
Console.Clear();
string txt2 = @"███████╗███████╗██╗     ███████╗ ██████╗████████╗     ██████╗ ███╗   ██╗███████╗
██╔════╝██╔════╝██║     ██╔════╝██╔════╝╚══██╔══╝    ██╔═══██╗████╗  ██║██╔════╝
███████╗█████╗  ██║     █████╗  ██║        ██║       ██║   ██║██╔██╗ ██║█████╗  
╚════██║██╔══╝  ██║     ██╔══╝  ██║        ██║       ██║   ██║██║╚██╗██║██╔══╝  
███████║███████╗███████╗███████╗╚██████╗   ██║       ╚██████╔╝██║ ╚████║███████╗
╚══════╝╚══════╝╚══════╝╚══════╝ ╚═════╝   ╚═╝        ╚═════╝ ╚═╝  ╚═══╝╚══════╝
";
int ind = Method.Selecting(new string[] {

    "\t\t╔═╗╔╦╗╔═╗╦  ╔═╗╦ ╦╔═╗╦═╗\n" +
    "\t\t\t\t║╣ ║║║╠═╝║  ║ ║╚╦╝║╣ ╠╦╝\n" +
    "\t\t\t\t╚═╝╩ ╩╩  ╩═╝╚═╝ ╩ ╚═╝╩╚═",

    "\t\t   ╦ ╦╔═╗╦═╗╦╔═╔═╗╦═╗   \n" +
    "\t\t\t\t   ║║║║ ║╠╦╝╠╩╗║╣ ╠╦╝   \n" +
    "\t\t\t\t   ╚╩╝╚═╝╩╚═╩ ╩╚═╝╩╚═   "


}, txt2);

// EMPLOYER
if (ind == 0)
{
    var username = Method.Login(employers);
    int indexOfEmployer = 0;
    for (int i = 0; i < workers.Count; i++)
    {
        if (employers[i].Username == username)
        {
            indexOfEmployer = i;
            break;
        }
    }
    Loading();
labelEmployerMenu:;
    Console.Clear();

    ind = Method.Selecting(new string[] {
        "\t\t╔═╗╔╦╗╔╦╗  ╦  ╦╔═╗╔═╗╔═╗╔╗╔╔═╗╦╔═╗\n" +
        "\t\t\t\t╠═╣ ║║ ║║  ╚╗╔╝╠═╣║  ╠═╣║║║║  ║║╣ \n" +
        "\t\t\t\t╩ ╩═╩╝═╩╝   ╚╝ ╩ ╩╚═╝╩ ╩╝╚╝╚═╝╩╚═╝",

        "\t\t╔╗╔╔═╗╔╦╗╦╔═╗╦╔═╗╔═╗╔╦╗╦╔═╗╔╗╔╔═╗ \n" +
        "\t\t\t\t║║║║ ║ ║ ║╠╣ ║║  ╠═╣ ║ ║║ ║║║║╚═╗ \n" +
        "\t\t\t\t╝╚╝╚═╝ ╩ ╩╚  ╩╚═╝╩ ╩ ╩ ╩╚═╝╝╚╝╚═╝ "
    }, @"
███████╗███╗   ███╗██████╗ ██╗      ██████╗ ██╗   ██╗███████╗██████╗     
██╔════╝████╗ ████║██╔══██╗██║     ██╔═══██╗╚██╗ ██╔╝██╔════╝██╔══██╗    
█████╗  ██╔████╔██║██████╔╝██║     ██║   ██║ ╚████╔╝ █████╗  ██████╔╝    
██╔══╝  ██║╚██╔╝██║██╔═══╝ ██║     ██║   ██║  ╚██╔╝  ██╔══╝  ██╔══██╗    
███████╗██║ ╚═╝ ██║██║     ███████╗╚██████╔╝   ██║   ███████╗██║  ██║    
╚══════╝╚═╝     ╚═╝╚═╝     ╚══════╝ ╚═════╝    ╚═╝   ╚══════╝╚═╝  ╚═╝    
                                                                         
            ███╗   ███╗███████╗███╗   ██╗██╗   ██╗       
            ████╗ ████║██╔════╝████╗  ██║██║   ██║       
            ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║       
            ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║       
            ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝       
            ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝                                       
");
    
    if (ind == 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"
███╗   ██╗███████╗██╗    ██╗    ██╗   ██╗ █████╗  ██████╗ █████╗ ███╗   ██╗ ██████╗██╗███████╗
████╗  ██║██╔════╝██║    ██║    ██║   ██║██╔══██╗██╔════╝██╔══██╗████╗  ██║██╔════╝██║██╔════╝
██╔██╗ ██║█████╗  ██║ █╗ ██║    ██║   ██║███████║██║     ███████║██╔██╗ ██║██║     ██║█████╗  
██║╚██╗██║██╔══╝  ██║███╗██║    ╚██╗ ██╔╝██╔══██║██║     ██╔══██║██║╚██╗██║██║     ██║██╔══╝  
██║ ╚████║███████╗╚███╔███╔╝     ╚████╔╝ ██║  ██║╚██████╗██║  ██║██║ ╚████║╚██████╗██║███████╗
╚═╝  ╚═══╝╚══════╝ ╚══╝╚══╝       ╚═══╝  ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝╚═╝╚══════╝
");
        Console.ForegroundColor = ConsoleColor.Green;
        Vacancie newVacancie = new();
        Console.Write("\n\t\u25ba ENTER LANGUAGES OF PROGRAMING: ");
        newVacancie.LanguagesOfPrograming = Console.ReadLine().ToUpper().Split(' ').ToList();
        Console.Write("\t\u25ba ENTER STARTING AGE: ");
        newVacancie.StartingAge = int.Parse(Console.ReadLine());
        Console.Write("\t\u25ba ENTER MIN UNI SCORE: ");
        newVacancie.MinUniScore = int.Parse(Console.ReadLine());
        Console.Write("\t\u25ba ENTER FOREIGN LANGUAGES: ");
        newVacancie.NeedToKnowLanguages = Console.ReadLine().ToUpper().Split(' ').ToList();
        Console.Write("\t\u25ba NEED SPECIFIED DIPLOM?([1] - yes, [0] - no): ");
        newVacancie.HaveToSpecifiedDiplom = (int.Parse(Console.ReadLine()) == 0) ? false : true;
        Console.Write("\t\u25ba ENTER SALARY: ");
        newVacancie.Salary = int.Parse(Console.ReadLine());
        Console.Write("\t\u25ba IS YOUR WORK REMOTED?([1] - yes, [0] - no): ");
        newVacancie.IsRemoted = (int.Parse(Console.ReadLine()) == 0) ? false : true;
        employers[indexOfEmployer].Vacancies.Add(newVacancie);
        JsonEditor.JsonSerializeEmployers(employers);
        Loading();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n");
        Console.WriteLine(@"
      ╦  ╦╔═╗╔═╗╔═╗╔╗╔╔═╗╦╔═╗  ╔═╗╔╦╗╔╦╗╔═╗╔╦╗
      ╚╗╔╝╠═╣║  ╠═╣║║║╚═╗║║╣   ╠═╣ ║║ ║║║╣  ║║
       ╚╝ ╩ ╩╚═╝╩ ╩╝╚╝╚═╝╩╚═╝  ╩ ╩═╩╝═╩╝╚═╝═╩╝
            ╔═╗╦ ╦╔═╗╔═╗╔═╗╔═╗╔═╗╦ ╦╦ ╦ ╦     
            ╚═╗║ ║║  ║  ║╣ ╚═╗╠╣ ║ ║║ ╚╦╝     
            ╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚  ╚═╝╩═╝╩      
");
        Thread.Sleep(2500);
        goto labelEmployerMenu;
    }

    else if (ind == 1)
    {
        if (employers[indexOfEmployer].Notifications.Count == 0)
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine(@"
          ╦ ╦╔═╗╦ ╦  ╦ ╦╔═╗╦  ╦╔═╗  ╔╗╔╔═╗╔╦╗  
          ╚╦╝║ ║║ ║  ╠═╣╠═╣╚╗╔╝║╣   ║║║║ ║ ║   
           ╩ ╚═╝╚═╝  ╩ ╩╩ ╩ ╚╝ ╚═╝  ╝╚╝╚═╝ ╩   
      ╔═╗╔╗╔╦ ╦  ╔╗╔╔═╗╔╦╗╦╔═╗╦╔═╗╔═╗╔╦╗╦╔═╗╔╗╔
      ╠═╣║║║╚╦╝  ║║║║ ║ ║ ║╠╣ ║║  ╠═╣ ║ ║║ ║║║║
      ╩ ╩╝╚╝ ╩   ╝╚╝╚═╝ ╩ ╩╚  ╩╚═╝╩ ╩ ╩ ╩╚═╝╝╚╝
");
            Thread.Sleep(2000);
            goto labelEmployerMenu;
        }

        labelShowNotifications:;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        string text = @"
    ████████████████████████████████████████████
    ██    ╔╗╔╔═╗╔╦╗╦╔═╗╦╔═╗╔═╗╔╦╗╦╔═╗╔╗╔╔═╗   ██
    ██    ║║║║ ║ ║ ║╠╣ ║║  ╠═╣ ║ ║║ ║║║║╚═╗   ██
    ██    ╝╚╝╚═╝ ╩ ╩╚  ╩╚═╝╩ ╩ ╩ ╩╚═╝╝╚╝╚═╝   ██
    ████████████████████████████████████████████
";
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Green;
        int k = 1;
        foreach (var notification in employers[indexOfEmployer].Notifications)
            Console.WriteLine($"[{k++}] {notification}");
        Console.Write("\n\u25ba ENTER ID OF NOTIFICATION: ");
        string? id = Console.ReadLine();
        int id_;
        if (!int.TryParse(id, out id_))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
            Thread.Sleep(1500);
            goto labelShowNotifications;
        }
        id_ = int.Parse(id);
        if (id_ - 1 >= employers[indexOfEmployer].Notifications.Count || id_ <= 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
            Thread.Sleep(1500);
            goto labelShowNotifications;
        }

        Console.Clear();
        for (int i = 0; i < workers.Count; i++)
        {
            if (workers[i].Username == employers[indexOfEmployer].Notifications[id_ - 1].FromUser)
            {
                workers[i].CV.ShowCV();
                k = i;
                break;
            }
        }
        lbl:;
        Console.CursorVisible = false;
        Console.WriteLine("\n\t[1] ACCEPT\n\t[2] REJECT\n\t[ESC] COMEBACK");
        var key = Console.ReadKey();
        if (key.Key == ConsoleKey.D1)
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(@"
╦ ╦╔═╗╦ ╦  ╔═╗╦ ╦╔═╗╔═╗╔═╗╔═╗╔═╗╦ ╦╦ ╦ ╦  ╔═╗╔═╗╔═╗╔═╗╔═╗╔╦╗╔═╗╔╦╗
╚╦╝║ ║║ ║  ╚═╗║ ║║  ║  ║╣ ╚═╗╠╣ ║ ║║ ╚╦╝  ╠═╣║  ║  ║╣ ╠═╝ ║ ║╣  ║║
 ╩ ╚═╝╚═╝  ╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚  ╚═╝╩═╝╩   ╩ ╩╚═╝╚═╝╚═╝╩   ╩ ╚═╝═╩╝
");
            Thread.Sleep(2000);
            workers[k].IsWorking = true;
            employers[indexOfEmployer].Notifications.Remove(employers[indexOfEmployer].Notifications[id_ - 1]);
            JsonEditor.JsonSerializeWorker(workers);
            JsonEditor.JsonSerializeEmployers(employers);
            goto labelEmployerMenu;
        }
        else if (key.Key == ConsoleKey.D2)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
╦ ╦╔═╗╦ ╦  ╔═╗╦ ╦╔═╗╔═╗╔═╗╔═╗╔═╗╦ ╦╦ ╦ ╦  ╦═╗╔═╗ ╦╔═╗╔═╗╔╦╗╔═╗╔╦╗
╚╦╝║ ║║ ║  ╚═╗║ ║║  ║  ║╣ ╚═╗╠╣ ║ ║║ ╚╦╝  ╠╦╝║╣  ║║╣ ║   ║ ║╣  ║║
 ╩ ╚═╝╚═╝  ╚═╝╚═╝╚═╝╚═╝╚═╝╚═╝╚  ╚═╝╩═╝╩   ╩╚═╚═╝╚╝╚═╝╚═╝ ╩ ╚═╝═╩╝
");
            Thread.Sleep(2000);
            workers[k].IsWorking = false;
            employers[indexOfEmployer].Notifications.Remove(employers[indexOfEmployer].Notifications[id_ - 1]);
            JsonEditor.JsonSerializeWorker(workers);
            JsonEditor.JsonSerializeEmployers(employers);
            goto labelEmployerMenu;
        }
        else if (key.Key == ConsoleKey.Escape)
            goto labelEmployerMenu;
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            workers[k].CV.ShowCV();
            goto lbl;
        }
    }

    else if (ind == -1)
        goto labelMenu;
    
}

// WORKER
else if (ind == 1)
{
    Console.Clear();
    Console.CursorVisible = false;
    string? username = "";
    ind = Method.Selecting(new string[] {
        "\t\t   ╦   ╔═╗ ╔═╗ ╦ ╔╗╔  \n"+
        "\t\t\t\t   ║   ║ ║ ║ ╦ ║ ║║║  \n" +
        "\t\t\t\t   ╩═╝ ╚═╝ ╚═╝ ╩ ╝╚╝  ",

        "\t\t╦═╗╔═╗╔═╗╦╔═╗╔╦╗╔═╗╦═╗\n" +
        "\t\t\t\t╠╦╝║╣ ║ ╦║╚═╗ ║ ║╣ ╠╦╝\n" +
        "\t\t\t\t╩╚═╚═╝╚═╝╩╚═╝ ╩ ╚═╝╩╚═"


    }, @"
██╗    ██╗ ██████╗ ██████╗ ██╗  ██╗███████╗██████╗     ██╗      ██████╗  ██████╗ 
██║    ██║██╔═══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗    ██║     ██╔═══██╗██╔════╝ 
██║ █╗ ██║██║   ██║██████╔╝█████╔╝ █████╗  ██████╔╝    ██║     ██║   ██║██║  ███╗
██║███╗██║██║   ██║██╔══██╗██╔═██╗ ██╔══╝  ██╔══██╗    ██║     ██║   ██║██║   ██║
╚███╔███╔╝╚██████╔╝██║  ██║██║  ██╗███████╗██║  ██║    ███████╗╚██████╔╝╚██████╔╝
 ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝    ╚══════╝ ╚═════╝  ╚═════╝
");

    // LOGIN
    if (ind == 0)
    {
        username = Method.Login(workers);

        Loading();
    }

    // REGISTER
    else if (ind == 1)
    {
        #region WorkerRegister

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        var text =
@"
 ██▀███  ▓█████   ▄████  ██▓  ██████ ▄▄▄█████▓ ██▀███   ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████   ███▄    █ 
▓██ ▒ ██▒▓█   ▀  ██▒ ▀█▒▓██▒▒██    ▒ ▓  ██▒ ▓▒▓██ ▒ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒ ██ ▀█   █ 
▓██ ░▄█ ▒▒███   ▒██░▄▄▄░▒██▒░ ▓██▄   ▒ ▓██░ ▒░▓██ ░▄█ ▒▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒▓██  ▀█ ██▒
▒██▀▀█▄  ▒▓█  ▄ ░▓█  ██▓░██░  ▒   ██▒░ ▓██▓ ░ ▒██▀▀█▄  ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░▓██▒  ▐▌██▒
░██▓ ▒██▒░▒████▒░▒▓███▀▒░██░▒██████▒▒  ▒██▒ ░ ░██▓ ▒██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░▒██░   ▓██░
░ ▒▓ ░▒▓░░░ ▒░ ░ ░▒   ▒ ░▓  ▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒▓ ░▒▓░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ 
  ░▒ ░ ▒░ ░ ░  ░  ░   ░  ▒ ░░ ░▒  ░ ░    ░      ░▒ ░ ▒░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░ ░ ░░   ░ ▒░
  ░░   ░    ░   ░ ░   ░  ▒ ░░  ░  ░    ░        ░░   ░   ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░   ░ ░ 
   ░        ░  ░      ░  ░        ░              ░           ░  ░         ░      ░ ░           ░ 
";
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Green;
        Worker newworker = new Worker();

        Console.Write("\t\t\t\u25ba Enter your Name: ");
        newworker.Name = Console.ReadLine();

        Console.Write("\t\t\t\u25ba Enter your Surname: ");
        newworker.Surname = Console.ReadLine();

    label1:;
        Console.Write("\t\t\t\u25ba Enter your Username: ");
        var usn = Console.ReadLine();
        foreach (var item in workers)
        {
            if (usn == item.Username)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\t\t\tERROR: T H I S   N A M E   I S   E X I S T!");
                Thread.Sleep(1500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t\t\u25ba Enter your Name: {newworker.Name}");
                Console.WriteLine($"\t\t\t\u25ba Enter your Surname: {newworker.Surname}");
                goto label1;
            }
        }
        newworker.Username = usn;

    label2:;
        Console.Write("\t\t\t\u25ba Enter your Password: ");
        var password = Console.ReadLine();
        if (password.Length < 8)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\t\t\tERROR: Password lenght must be bigger than 8 or equal to 8!");
            Thread.Sleep(1500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t\t\u25ba Enter your Name: {newworker.Name}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Surname: {newworker.Surname}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Username: {newworker.Username}");
            goto label2;
        }
        newworker.Password = password;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\t\t\t\u25ba Enter your Name: {newworker.Name}");
        Console.WriteLine($"\t\t\t\u25ba Enter your Surname: {newworker.Surname}");
        Console.WriteLine($"\t\t\t\u25ba Enter your Username: {newworker.Username}");
        Console.Write("\t\t\t\u25ba Enter your Password: ");
        for (int i = 0; i < newworker.Password.Length; i++)
            Console.Write('*');
        Console.WriteLine();

    labelConfirmPsw:;
        Console.Write("\t\t\t\u25ba Confirm your Password: ");
        var password1 = Console.ReadLine();
        if (string.Equals(password, password1))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t\t\u25ba Enter your Name: {newworker.Name}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Surname: {newworker.Surname}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Username: {newworker.Username}");
            Console.Write("\t\t\t\u25ba Enter your Password: ");
            for (int i = 0; i < newworker.Password.Length; i++)
                Console.Write('*');
            Console.Write("\n\t\t\t\u25ba Confirm your Password: ");
            for (int i = 0; i < newworker.Password.Length; i++)
                Console.Write('*');
            Console.WriteLine();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\t\t\tERROR: Passwords are not the same!");
            Thread.Sleep(1500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t\t\u25ba Enter your Name: {newworker.Name}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Surname: {newworker.Surname}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Username: {newworker.Username}");
            Console.Write("\t\t\t\u25ba Enter your Password: ");
            for (int i = 0; i < newworker.Password.Length; i++)
                Console.Write('*');
            Console.WriteLine();
            goto labelConfirmPsw;
        }

        Console.Write("\t\t\t\u25ba Enter City where you live: ");
        newworker.City = Console.ReadLine();

        Console.Write("\t\t\t\u25ba Enter your telephone: ");
        newworker.Phone = Console.ReadLine();

    label3:;
        Console.Write("\t\t\t\u25ba Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        if (age <= 0) {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\t\t\tERROR: Age must be bigger than 0!");
            Thread.Sleep(1500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\t\t\t\u25ba Enter your Name: {newworker.Name}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Surname: {newworker.Surname}");
            Console.WriteLine($"\t\t\t\u25ba Enter your Username: {newworker.Username}");
            Console.Write("\t\t\t\u25ba Enter your Password: ");
            for (int i = 0; i < newworker.Password.Length; i++)
                Console.Write('*');
            Console.Write($"\n\t\t\t\u25ba Confirm your Password: ");
            for (int i = 0; i < newworker.Password.Length; i++)
                Console.Write('*');
            Console.WriteLine($"\n\t\t\t\u25ba Enter City where you live: {newworker.City}");
            Console.WriteLine($"\t\t\t\u25ba Enter your telephone: {newworker.Phone}");
            goto label3;
        }
        newworker.Age = age;

        newworker.BeginToWorkTime = null;
        newworker.EndWorkTime = null;
        newworker.IsWorking = false;

        Loading();

        #region RegisteringCV

        Console.Clear();
        Console.CursorVisible = true;
        Console.ForegroundColor = ConsoleColor.Red;
        CV cv = new CV();
        text =
@"
  █████▒██▓ ██▓     ██▓        ▄████▄ ██▒     █▓
▓██   ▒▓██▒▓██▒    ▓██▒       ▒██▀ ▀█▓██░     █▒
▒████ ░▒██▒▒██░    ▒██░       ▒██    ▄▓██    █▒░
░▓█▒  ░░██░▒██░    ▒██░       ▒▓█▄ ▄██▒▒██  ██░
░▒█░   ░██░░██████▒░██████▒   ▒ ▓███▀ ░ ▒▀██▓▒
 ▒ ░   ░▓  ░ ▒░▓  ░░ ▒░▓  ░   ░ ░▒ ▒  ░ ░ ▐░ ░
 ░      ▒ ░░ ░ ▒  ░░ ░ ▒  ░     ░  ▒    ░ ░ ░  
 ░ ░    ▒ ░  ░ ░     ░ ░      ░           ░░  
        ░      ░  ░    ░  ░   ░ ░          ░  
                              ░           ░   
";
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\n\t\t\t\u25ba Enter your Profession: ");
        cv.School = Console.ReadLine();

        Console.Write("\t\t\t\u25ba Enter your School: ");
        cv.School = Console.ReadLine();

    labelAge:;
        Console.Write("\t\t\t\u25ba Enter your UniScore: ");
        cv.UniScore = int.Parse(Console.ReadLine());
        if (cv.UniScore <= 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\tERROR: UniScore must be bigger than 0!");
            Thread.Sleep(1500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\t\t\t\u25ba Enter your Profession: {cv.Ixtisas}");
            Console.WriteLine($"\t\t\t\u25ba Enter your School: {cv.School}");
            goto labelAge;
        }

        Console.Write("\t\t\t\u25ba Enter your Abilities Language: ");
        cv.AbilituesLanguage = Console.ReadLine().ToUpper().Split(' ').ToList();

        Console.Write("\t\t\t\u25ba Enter Companies where do you work in: ");
        cv.Companies = Console.ReadLine().ToUpper().Split(' ').ToList();

        Console.Write("\t\t\t\u25ba Enter foreign languages which know: ");
        cv.KnowForeignLanguage = Console.ReadLine().ToUpper().Split(' ').ToList();

        Console.Write("\t\t\t\u25ba Enter your GITHUB username: ");
        cv.GITLINK = $"https://github.com/" + Console.ReadLine();

        Console.Write("\t\t\t\u25ba Enter your LINKEDIN username: ");
        cv.LINKEDLINK = $"https://linkedin.com/" + Console.ReadLine();

        Console.Write("\t\t\t\u25ba Do you have specified diplom? ([1] - yes | [0] - no): ");
        cv.HasDiplom = (int.Parse(Console.ReadLine()) == 0) ? false : true;

        #endregion

        newworker.CV = cv;

        workers.Add(newworker);
        JsonEditor.JsonSerializeWorker(workers);
        username = newworker.Username;
        
        #endregion

        Loading();
    }

    // ESC
    else if (ind == -1)
    {
        goto labelMenu;
    }

    int indexOfWorker = 0;
    for (int i = 0; i < workers.Count; i++)
    {
        if (workers[i].Username == username)
        {
            indexOfWorker = i;
            break;
        }
    }

//// WORKER MENU AFTER WORKER
labelMenuAfterLOGWorker:;
    Console.Clear();

    ind = Method.Selecting(new string[]
    {
                "\t\t   ╔═╗╦ ╦╔═╗╔╗╔╔═╗╔═╗  ╔═╗╦  ╦  \n" +
                "\t\t\t\t   ║  ╠═╣╠═╣║║║║ ╦║╣   ║  ╚╗╔╝  \n" +
                "\t\t\t\t   ╚═╝╩ ╩╩ ╩╝╚╝╚═╝╚═╝  ╚═╝ ╚╝   ",

                "\t\t╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦  ╦ ╦╔═╗╦═╗╦╔═\n" +
                "\t\t\t\t╚═╗║╣ ╠═╣╠╦╝║  ╠═╣  ║║║║ ║╠╦╝╠╩╗\n" +
                "\t\t\t\t╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩  ╚╩╝╚═╝╩╚═╩ ╩",

                "\t\t     ╔═╗ ╦ ╦╦╔╦╗   ╦╔═╗╔╗      \n" +
                "\t\t\t\t     ║═╬╗║ ║║ ║    ║║ ║╠╩╗     \n" +
                "\t\t\t\t     ╚═╝╚╚═╝╩ ╩   ╚╝╚═╝╚═╝     \n"
    }, @"
██╗    ██╗ ██████╗ ██████╗ ██╗  ██╗███████╗██████╗     ███╗   ███╗███████╗███╗   ██╗██╗   ██╗
██║    ██║██╔═══██╗██╔══██╗██║ ██╔╝██╔════╝██╔══██╗    ████╗ ████║██╔════╝████╗  ██║██║   ██║
██║ █╗ ██║██║   ██║██████╔╝█████╔╝ █████╗  ██████╔╝    ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
██║███╗██║██║   ██║██╔══██╗██╔═██╗ ██╔══╝  ██╔══██╗    ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║
╚███╔███╔╝╚██████╔╝██║  ██║██║  ██╗███████╗██║  ██║    ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
 ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝    ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 
"); // change cv and search work or quit job

    // CHANGING CV FROM USER
    if (ind == 0)
    {
        labelChangeCV:;
        Console.Clear();
        ind = Method.Selecting(new string[] { "PROFESSION", "SCHOOL", "UNISCORE", "ABILITIES", "COMPANIES", "FOREIGN LANGUAHES", "HASDIPLOM" }, @"
╔═╗╔═╗╦  ╔═╗╔═╗╔╦╗  ╔═╗╔╗╔╔═╗  ╦ ╦╦╔╦╗╔═╗╦ ╦  
╚═╗║╣ ║  ║╣ ║   ║   ║ ║║║║║╣   ║║║║ ║ ║  ╠═╣  
╚═╝╚═╝╩═╝╚═╝╚═╝ ╩   ╚═╝╝╚╝╚═╝  ╚╩╝╩ ╩ ╚═╝╩ ╩  
      ╦ ╦╔═╗╦ ╦  ╦ ╦╔═╗╔╗╔╔╦╗  ╔╦╗╔═╗         
      ╚╦╝║ ║║ ║  ║║║╠═╣║║║ ║    ║ ║ ║         
       ╩ ╚═╝╚═╝  ╚╩╝╩ ╩╝╚╝ ╩    ╩ ╚═╝         
          ╔═╗╦ ╦╔═╗╔╗╔╔═╗╔═╗                  
          ║  ╠═╣╠═╣║║║║ ╦║╣                   
          ╚═╝╩ ╩╩ ╩╝╚╝╚═╝╚═╝                  
");
        if (ind == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\u25ba ENTER PROFFESION: ");
            workers[indexOfWorker].CV.Ixtisas = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"
            ▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄          █     █░ ▄▄▄        ██████    
            ▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▒████▄       ▓█░ █ ░█░▒████▄    ▒██    ▒    
            ░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ▒█░ █ ░█ ▒██  ▀█▄  ░ ▓██▄      
            ░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░█░ █ ░█ ░██▄▄▄▄██   ▒   ██▒   
            ░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░░██▒██▓  ▓█   ▓██▒▒██████▒▒   
             ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░   ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   
             ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░     ▒ ░ ░    ▒   ▒▒ ░░ ░▒  ░ ░   
             ░ ░  ░   ░   ▒    ░        ░   ▒        ░   ░    ░   ▒   ░  ░  ░     
               ░          ░  ░              ░  ░       ░          ░  ░      ░     
             ░                                                                    
          ▄████▄   ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄             
         ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌            
         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌            
         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌            
         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓             
         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒             
           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒             
         ░         ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░             
         ░ ░       ░  ░  ░      ░  ░         ░       ░    ░  ░   ░                
         ░                                                     ░                  
");
            Thread.Sleep(2000);
            goto labelChangeCV;
        }
        else if (ind == 1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\u25ba ENTER SCHOOL: ");
            workers[indexOfWorker].CV.School = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"
            ▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄          █     █░ ▄▄▄        ██████    
            ▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▒████▄       ▓█░ █ ░█░▒████▄    ▒██    ▒    
            ░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ▒█░ █ ░█ ▒██  ▀█▄  ░ ▓██▄      
            ░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░█░ █ ░█ ░██▄▄▄▄██   ▒   ██▒   
            ░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░░██▒██▓  ▓█   ▓██▒▒██████▒▒   
             ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░   ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   
             ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░     ▒ ░ ░    ▒   ▒▒ ░░ ░▒  ░ ░   
             ░ ░  ░   ░   ▒    ░        ░   ▒        ░   ░    ░   ▒   ░  ░  ░     
               ░          ░  ░              ░  ░       ░          ░  ░      ░     
             ░                                                                    
          ▄████▄   ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄             
         ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌            
         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌            
         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌            
         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓             
         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒             
           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒             
         ░         ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░             
         ░ ░       ░  ░  ░      ░  ░         ░       ░    ░  ░   ░                
         ░                                                     ░                  
");
            Thread.Sleep(2000);
            goto labelChangeCV;
        }
        else if (ind == 2)
        {
            labelUniscore:;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\u25ba ENTER UNISCORE: ");
            int uniscore = int.Parse(Console.ReadLine());
            if (uniscore <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine(@"
    ╔═╗╔═╗╔═╗  ╔╦╗╦ ╦╔═╗╔╦╗  ╔╗ ╔═╗               
    ╠═╣║ ╦║╣   ║║║║ ║╚═╗ ║   ╠╩╗║╣                
    ╩ ╩╚═╝╚═╝  ╩ ╩╚═╝╚═╝ ╩   ╚═╝╚═╝               
      ╔╗ ╦╔═╗╔═╗╔═╗╦═╗  ╔╦╗╦ ╦╔═╗╔╗╔  ╔═╗╔═╗╦═╗╔═╗
      ╠╩╗║║ ╦║ ╦║╣ ╠╦╝   ║ ╠═╣╠═╣║║║  ╔═╝║╣ ╠╦╝║ ║
      ╚═╝╩╚═╝╚═╝╚═╝╩╚═   ╩ ╩ ╩╩ ╩╝╚╝  ╚═╝╚═╝╩╚═╚═╝
");
                Thread.Sleep(1200);
                goto labelUniscore;
            }
            workers[indexOfWorker].CV.UniScore = uniscore;
            Console.Clear();
            Console.WriteLine(@"
            ▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄          █     █░ ▄▄▄        ██████    
            ▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▒████▄       ▓█░ █ ░█░▒████▄    ▒██    ▒    
            ░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ▒█░ █ ░█ ▒██  ▀█▄  ░ ▓██▄      
            ░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░█░ █ ░█ ░██▄▄▄▄██   ▒   ██▒   
            ░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░░██▒██▓  ▓█   ▓██▒▒██████▒▒   
             ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░   ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   
             ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░     ▒ ░ ░    ▒   ▒▒ ░░ ░▒  ░ ░   
             ░ ░  ░   ░   ▒    ░        ░   ▒        ░   ░    ░   ▒   ░  ░  ░     
               ░          ░  ░              ░  ░       ░          ░  ░      ░     
             ░                                                                    
          ▄████▄   ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄             
         ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌            
         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌            
         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌            
         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓             
         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒             
           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒             
         ░         ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░             
         ░ ░       ░  ░  ░      ░  ░         ░       ░    ░  ░   ░                
         ░                                                     ░                  
");
            Thread.Sleep(2000);
            goto labelChangeCV;
        }
        else if (ind == 3)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\u25ba ENTER ABILITIES: ");
            workers[indexOfWorker].CV.AbilituesLanguage = Console.ReadLine().Split(' ').ToList();
            Console.Clear();
            Console.WriteLine(@"
            ▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄          █     █░ ▄▄▄        ██████    
            ▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▒████▄       ▓█░ █ ░█░▒████▄    ▒██    ▒    
            ░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ▒█░ █ ░█ ▒██  ▀█▄  ░ ▓██▄      
            ░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░█░ █ ░█ ░██▄▄▄▄██   ▒   ██▒   
            ░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░░██▒██▓  ▓█   ▓██▒▒██████▒▒   
             ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░   ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   
             ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░     ▒ ░ ░    ▒   ▒▒ ░░ ░▒  ░ ░   
             ░ ░  ░   ░   ▒    ░        ░   ▒        ░   ░    ░   ▒   ░  ░  ░     
               ░          ░  ░              ░  ░       ░          ░  ░      ░     
             ░                                                                    
          ▄████▄   ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄             
         ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌            
         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌            
         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌            
         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓             
         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒             
           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒             
         ░         ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░             
         ░ ░       ░  ░  ░      ░  ░         ░       ░    ░  ░   ░                
         ░                                                     ░                  
");
            Thread.Sleep(2000);
            goto labelChangeCV;
        }
        else if (ind == 4)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\u25ba ENTER COMPANIES: ");
            workers[indexOfWorker].CV.Companies = Console.ReadLine().Split(' ').ToList();
            Console.Clear();
            Console.WriteLine(@"
            ▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄          █     █░ ▄▄▄        ██████    
            ▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▒████▄       ▓█░ █ ░█░▒████▄    ▒██    ▒    
            ░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ▒█░ █ ░█ ▒██  ▀█▄  ░ ▓██▄      
            ░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░█░ █ ░█ ░██▄▄▄▄██   ▒   ██▒   
            ░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░░██▒██▓  ▓█   ▓██▒▒██████▒▒   
             ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░   ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   
             ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░     ▒ ░ ░    ▒   ▒▒ ░░ ░▒  ░ ░   
             ░ ░  ░   ░   ▒    ░        ░   ▒        ░   ░    ░   ▒   ░  ░  ░     
               ░          ░  ░              ░  ░       ░          ░  ░      ░     
             ░                                                                    
          ▄████▄   ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄             
         ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌            
         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌            
         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌            
         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓             
         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒             
           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒             
         ░         ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░             
         ░ ░       ░  ░  ░      ░  ░         ░       ░    ░  ░   ░                
         ░                                                     ░                  
");
            Thread.Sleep(2000);
            goto labelChangeCV;
        }
        else if (ind == 5)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\u25ba ENTER FOREIGN LANGUAGES: ");
            workers[indexOfWorker].CV.KnowForeignLanguage = Console.ReadLine().Split(' ').ToList();
            Console.Clear();
            Console.WriteLine(@"
            ▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄          █     █░ ▄▄▄        ██████    
            ▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▒████▄       ▓█░ █ ░█░▒████▄    ▒██    ▒    
            ░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ▒█░ █ ░█ ▒██  ▀█▄  ░ ▓██▄      
            ░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░█░ █ ░█ ░██▄▄▄▄██   ▒   ██▒   
            ░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░░██▒██▓  ▓█   ▓██▒▒██████▒▒   
             ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░   ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   
             ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░     ▒ ░ ░    ▒   ▒▒ ░░ ░▒  ░ ░   
             ░ ░  ░   ░   ▒    ░        ░   ▒        ░   ░    ░   ▒   ░  ░  ░     
               ░          ░  ░              ░  ░       ░          ░  ░      ░     
             ░                                                                    
          ▄████▄   ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄             
         ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌            
         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌            
         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌            
         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓             
         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒             
           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒             
         ░         ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░             
         ░ ░       ░  ░  ░      ░  ░         ░       ░    ░  ░   ░                
         ░                                                     ░                  
");
            Thread.Sleep(2000);
            goto labelChangeCV;
        }
        else if (ind == 6)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\u25ba HAVE YOU SPECIFIED DIPLOM([1] - yes, [0] - no): ");
            workers[indexOfWorker].CV.HasDiplom = (int.Parse(Console.ReadLine()) == 0) ? false : true;
            Console.Clear();
            Console.WriteLine(@"
            ▓█████▄  ▄▄▄     ▄▄▄█████▓ ▄▄▄          █     █░ ▄▄▄        ██████    
            ▒██▀ ██▌▒████▄   ▓  ██▒ ▓▒▒████▄       ▓█░ █ ░█░▒████▄    ▒██    ▒    
            ░██   █▌▒██  ▀█▄ ▒ ▓██░ ▒░▒██  ▀█▄     ▒█░ █ ░█ ▒██  ▀█▄  ░ ▓██▄      
            ░▓█▄   ▌░██▄▄▄▄██░ ▓██▓ ░ ░██▄▄▄▄██    ░█░ █ ░█ ░██▄▄▄▄██   ▒   ██▒   
            ░▒████▓  ▓█   ▓██▒ ▒██▒ ░  ▓█   ▓██▒   ░░██▒██▓  ▓█   ▓██▒▒██████▒▒   
             ▒▒▓  ▒  ▒▒   ▓▒█░ ▒ ░░    ▒▒   ▓▒█░   ░ ▓░▒ ▒   ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░   
             ░ ▒  ▒   ▒   ▒▒ ░   ░      ▒   ▒▒ ░     ▒ ░ ░    ▒   ▒▒ ░░ ░▒  ░ ░   
             ░ ░  ░   ░   ▒    ░        ░   ▒        ░   ░    ░   ▒   ░  ░  ░     
               ░          ░  ░              ░  ░       ░          ░  ░      ░     
             ░                                                                    
          ▄████▄   ██░ ██  ▄▄▄       ███▄    █   ▄████ ▓█████ ▓█████▄             
         ▒██▀ ▀█  ▓██░ ██▒▒████▄     ██ ▀█   █  ██▒ ▀█▒▓█   ▀ ▒██▀ ██▌            
         ▒▓█    ▄ ▒██▀▀██░▒██  ▀█▄  ▓██  ▀█ ██▒▒██░▄▄▄░▒███   ░██   █▌            
         ▒▓▓▄ ▄██▒░▓█ ░██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░▓█  ██▓▒▓█  ▄ ░▓█▄   ▌            
         ▒ ▓███▀ ░░▓█▒░██▓ ▓█   ▓██▒▒██░   ▓██░░▒▓███▀▒░▒████▒░▒████▓             
         ░ ░▒ ▒  ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░   ▒ ▒  ░▒   ▒ ░░ ▒░ ░ ▒▒▓  ▒             
           ░  ▒    ▒ ░▒░ ░  ▒   ▒▒ ░░ ░░   ░ ▒░  ░   ░  ░ ░  ░ ░ ▒  ▒             
         ░         ░  ░░ ░  ░   ▒      ░   ░ ░ ░ ░   ░    ░    ░ ░  ░             
         ░ ░       ░  ░  ░      ░  ░         ░       ░    ░  ░   ░                
         ░                                                     ░                  
");
            Thread.Sleep(2000);
            goto labelChangeCV;
        }
        else if (ind == -1)
        {
            JsonEditor.JsonSerializeWorker(workers);
            goto labelMenuAfterLOGWorker;
        }
    }

    // SEARCH WORK FROM USER
    else if (ind == 1)
    {
        if (workers[indexOfWorker].IsWorking)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
╦ ╦╔═╗╦ ╦  ╔═╗╦  ╦═╗╔═╗╔╦╗╦ ╦  ╦╔═╗  ╦ ╦╔═╗╦═╗╦╔═╦╔╗╔╔═╗
╚╦╝║ ║║ ║  ╠═╣║  ╠╦╝║╣  ║║╚╦╝  ║╚═╗  ║║║║ ║╠╦╝╠╩╗║║║║║ ╦
 ╩ ╚═╝╚═╝  ╩ ╩╩═╝╩╚═╚═╝═╩╝ ╩   ╩╚═╝  ╚╩╝╚═╝╩╚═╩ ╩╩╝╚╝╚═╝
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╔═╗ ╦ ╦╦╔╦╗  ╔╦╗╦ ╦╦╔═╗   ╦╔═╗╔╗    
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║═╬╗║ ║║ ║    ║ ╠═╣║╚═╗   ║║ ║╠╩╗   
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚═╝╚╚═╝╩ ╩    ╩ ╩ ╩╩╚═╝  ╚╝╚═╝╚═╝   
╔═╗╔═╗╦═╗  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦╦╔╗╔╔═╗  ╔╗╔╔═╗╦ ╦         
╠╣ ║ ║╠╦╝  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣║║║║║ ╦  ║║║║╣ ║║║         
╚  ╚═╝╩╚═  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩╩╝╚╝╚═╝  ╝╚╝╚═╝╚╩╝         
");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(3000);
            goto labelMenuAfterLOGWorker;
        }
        labelSearchingWork:;
        Console.Clear();
        ind = Method.Selecting(new string[] {
            "\t\t       ╔═╗╦ ╦╔═╗╦ ╦  ╦ ╦╔═╗╦═╗╦╔═╔═╗       \n" +
            "\t\t\t\t       ╚═╗╠═╣║ ║║║║  ║║║║ ║╠╦╝╠╩╗╚═╗       \n" +
            "\t\t\t\t       ╚═╝╩ ╩╚═╝╚╩╝  ╚╩╝╚═╝╩╚═╩ ╩╚═╝       ",

            "\t\t╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦  ╦ ╦╔═╗╦═╗╦╔═  ╔═╗╔═╗╦═╗\n" +
            "\t\t\t\t╚═╗║╣ ╠═╣╠╦╝║  ╠═╣  ║║║║ ║╠╦╝╠╩╗  ╠╣ ║ ║╠╦╝\n" +
            "\t\t\t\t╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩  ╚╩╝╚═╝╩╚═╩ ╩  ╚  ╚═╝╩╚═"
        }, txt2); // show works or search work for

        if (ind == 0)
        {
            labelVacancies:;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            List<Vacancie> vacancies = new();
            for (int i = 0; i < employers.Count; i++)
                for (int j = 0; j < employers[i].Vacancies.Count; j++)
                    vacancies.Add(employers[i].Vacancies[j]);
            for (int i = 0; i < vacancies.Count; i++)
            {
                Console.WriteLine($"\n\n\t\t____________________ NO: {i + 1} ____________________");
                vacancies[i].ShowVacansie();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\t\u25ba ENTER ID OF THE POST: ");
            string? id = Console.ReadLine();
            int id_;
            if (!int.TryParse(id, out id_)) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
                Thread.Sleep(1500);
                goto labelVacancies;
            }
            id_ = int.Parse(id);
            if (id_ - 1 >= vacancies.Count || id_ <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
                Thread.Sleep(1500);
                goto labelVacancies;
            }
            lbl:;
            Console.WriteLine("\t\u25ba WHAT DOU YOU WANT TO DO? [1] - APPLY  |  [2] - COME BACK: ");
            var key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                foreach (var item in employers)
                {
                    if (item.Vacancies.Contains(vacancies[id_ - 1]))
                    {
                        item.Notifications.Add(new Notification("Worker applyed this job", username));
                        break;
                    }
                }
                JsonEditor.JsonSerializeEmployers(employers);

                Console.WriteLine(@"
╦═╗╔═╗╔═╗ ╦ ╦╔═╗╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔╦╗         
╠╦╝║╣ ║═╬╗║ ║║╣ ╚═╗ ║   ╚═╗║╣ ║║║ ║║║╣  ║║         
╩╚═╚═╝╚═╝╚╚═╝╚═╝╚═╝ ╩   ╚═╝╚═╝╝╚╝═╩╝╚═╝═╩╝         
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╦ ╦╔═╗╦╔╦╗  ╔╦╗╦╔╦╗╔═╗         
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║║║╠═╣║ ║    ║ ║║║║║╣          
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚╩╝╩ ╩╩ ╩    ╩ ╩╩ ╩╚═╝         
╦ ╦╦ ╦╔═╗╔╗╔  ╔═╗╔╦╗╔═╗╦ ╦ ╦╔═╗╦═╗  ╔═╗╦ ╦╔═╗╔═╗╦╔═
║║║╠═╣║╣ ║║║  ║╣ ║║║╠═╝║ ╚╦╝║╣ ╠╦╝  ║  ╠═╣║╣ ║  ╠╩╗
╚╩╝╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩  ╩═╝╩ ╚═╝╩╚═  ╚═╝╩ ╩╚═╝╚═╝╩ ╩
╦ ╦╔═╗╦ ╦╦═╗  ╦╔╗╔╔═╗╔═╗╦═╗╔╦╗╔═╗╔╦╗╦╔═╗╔╗╔        
╚╦╝║ ║║ ║╠╦╝  ║║║║╠╣ ║ ║╠╦╝║║║╠═╣ ║ ║║ ║║║║        
 ╩ ╚═╝╚═╝╩╚═  ╩╝╚╝╚  ╚═╝╩╚═╩ ╩╩ ╩ ╩ ╩╚═╝╝╚╝           
");
                Thread.Sleep(4000);
                goto labelMenuAfterLOGWorker;
            }
            else if (key.Key == ConsoleKey.D2)
                goto labelSearchingWork;
            else
                goto lbl;

        }

        else if (ind == 1)
        {
            labelSearchFor:;
            Console.Clear();
            ind = Method.Selecting(new string[] 
            { 
                "FOR: LANGUAGES OF PROGRAMING", 
                "FOR: AGE", 
                "FOR: MINUMIM UNI SCORE", 
                "FOR: NEED SPECIFIED DIPLOM", 
                "FOR: SALARY", 
                "FOR: REMOTED"}, @"
╔═╗╔═╗╦  ╔═╗╔═╗╔╦╗  ╔═╗╔╗╔╔═╗  ╔╦╗╔═╗
╚═╗║╣ ║  ║╣ ║   ║   ║ ║║║║║╣    ║ ║ ║
╚═╝╚═╝╩═╝╚═╝╚═╝ ╩   ╚═╝╝╚╝╚═╝   ╩ ╚═╝
  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦  ╔═╗╔═╗╦═╗      
  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣  ╠╣ ║ ║╠╦╝      
  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩  ╚  ╚═╝╩╚═      

");
            Console.ForegroundColor = ConsoleColor.Green;

            if (ind == 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
███████╗███████╗ █████╗ ██████╗  ██████╗██╗  ██╗    ███████╗ ██████╗ ██████╗ 
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝██║  ██║    ██╔════╝██╔═══██╗██╔══██╗
███████╗█████╗  ███████║██████╔╝██║     ███████║    █████╗  ██║   ██║██████╔╝
╚════██║██╔══╝  ██╔══██║██╔══██╗██║     ██╔══██║    ██╔══╝  ██║   ██║██╔══██╗
███████║███████╗██║  ██║██║  ██║╚██████╗██║  ██║    ██║     ╚██████╔╝██║  ██║
╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝
");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER PROGRAMINGLANGUAGES WHICH YOU WANT TO SEARCH: ");
                List<string> lans = Console.ReadLine().ToUpper().Split(' ').ToList();

                labelSearchWorkForPL:;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                List<Vacancie> vacancies = new();
                for (int i = 0; i < employers.Count; i++)
                    for (int j = 0; j < employers[i].Vacancies.Count; j++)
                        vacancies.Add(employers[i].Vacancies[j]);
                List<Vacancie> updatedVacancies = new();
                bool check = false;
                int k = 0;
                foreach (var item in vacancies)
                {
                    for (int i = 0; i < lans.Count; i++)
                    {
                        if (item.LanguagesOfPrograming.Contains(lans[i]))
                        {
                            check = true;
                            Console.WriteLine($"\n\n\t\t____________________ NO: {++k} ____________________");
                            updatedVacancies.Add(item);
                            item.ShowVacansie();
                            break;
                        }
                    }
                }
                if (!check)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                  ╔╗╔╔═╗  ╦ ╦╔═╗╦═╗╦╔═╔═╗          
                  ║║║║ ║  ║║║║ ║╠╦╝╠╩╗╚═╗          
                  ╝╚╝╚═╝  ╚╩╝╚═╝╩╚═╩ ╩╚═╝          
        ╔═╗╔═╗╦═╗  ╦ ╦╔═╗╦ ╦╦═╗  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦
        ╠╣ ║ ║╠╦╝  ╚╦╝║ ║║ ║╠╦╝  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣
        ╚  ╚═╝╩╚═   ╩ ╚═╝╚═╝╩╚═  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(2000);
                    goto labelSearchFor;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER ID OF THE POST: ");
                string? id = Console.ReadLine();
                int id_;
                if (!int.TryParse(id, out id_))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForPL;
                }
                id_ = int.Parse(id);
                if (id_ - 1 >= updatedVacancies.Count || id_ <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForPL;
                }

                lbl:;
                Console.WriteLine("\t\u25ba WHAT DOU YOU WANT TO DO? [1] - APPLY  |  [2] - COME BACK: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
╦═╗╔═╗╔═╗ ╦ ╦╔═╗╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔╦╗         
╠╦╝║╣ ║═╬╗║ ║║╣ ╚═╗ ║   ╚═╗║╣ ║║║ ║║║╣  ║║         
╩╚═╚═╝╚═╝╚╚═╝╚═╝╚═╝ ╩   ╚═╝╚═╝╝╚╝═╩╝╚═╝═╩╝         
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╦ ╦╔═╗╦╔╦╗  ╔╦╗╦╔╦╗╔═╗         
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║║║╠═╣║ ║    ║ ║║║║║╣          
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚╩╝╩ ╩╩ ╩    ╩ ╩╩ ╩╚═╝         
╦ ╦╦ ╦╔═╗╔╗╔  ╔═╗╔╦╗╔═╗╦ ╦ ╦╔═╗╦═╗  ╔═╗╦ ╦╔═╗╔═╗╦╔═
║║║╠═╣║╣ ║║║  ║╣ ║║║╠═╝║ ╚╦╝║╣ ╠╦╝  ║  ╠═╣║╣ ║  ╠╩╗
╚╩╝╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩  ╩═╝╩ ╚═╝╩╚═  ╚═╝╩ ╩╚═╝╚═╝╩ ╩
╦ ╦╔═╗╦ ╦╦═╗  ╦╔╗╔╔═╗╔═╗╦═╗╔╦╗╔═╗╔╦╗╦╔═╗╔╗╔        
╚╦╝║ ║║ ║╠╦╝  ║║║║╠╣ ║ ║╠╦╝║║║╠═╣ ║ ║║ ║║║║        
 ╩ ╚═╝╚═╝╩╚═  ╩╝╚╝╚  ╚═╝╩╚═╩ ╩╩ ╩ ╩ ╩╚═╝╝╚╝           
");
                    foreach (var item in employers)
                    {
                        if (item.Vacancies.Contains(updatedVacancies[id_ - 1]))
                        {
                            item.Notifications.Add(new Notification("Worker applyed this job", username));
                            break;
                        }
                    }
                    JsonEditor.JsonSerializeEmployers(employers);
                    Thread.Sleep(4000);
                    goto labelMenuAfterLOGWorker;
                }
                else if (key.Key == ConsoleKey.D2)
                    goto labelSearchingWork;
                else
                    goto lbl;

            }

            else if (ind == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
███████╗███████╗ █████╗ ██████╗  ██████╗██╗  ██╗    ███████╗ ██████╗ ██████╗ 
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝██║  ██║    ██╔════╝██╔═══██╗██╔══██╗
███████╗█████╗  ███████║██████╔╝██║     ███████║    █████╗  ██║   ██║██████╔╝
╚════██║██╔══╝  ██╔══██║██╔══██╗██║     ██╔══██║    ██╔══╝  ██║   ██║██╔══██╗
███████║███████╗██║  ██║██║  ██║╚██████╗██║  ██║    ██║     ╚██████╔╝██║  ██║
╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝
");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER STARTING AGE: ");
                int age = int.Parse(Console.ReadLine());
                List<Vacancie> vacancies = new();
                for (int i = 0; i < employers.Count; i++)
                    for (int j = 0; j < employers[i].Vacancies.Count; j++)
                        vacancies.Add(employers[i].Vacancies[j]);

                    labelSearchWorkForAge:;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                List<Vacancie> updatedVacancies = new();
                bool check = false;
                int k = 0;
                foreach (var item in vacancies)
                {
                    if (item.StartingAge >= age)
                    {
                        check = true;
                        Console.WriteLine($"\n\n\t\t____________________ NO: {++k} ____________________");
                        updatedVacancies.Add(item);
                        item.ShowVacansie();
                    }
                }
                if (!check)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                  ╔╗╔╔═╗  ╦ ╦╔═╗╦═╗╦╔═╔═╗          
                  ║║║║ ║  ║║║║ ║╠╦╝╠╩╗╚═╗          
                  ╝╚╝╚═╝  ╚╩╝╚═╝╩╚═╩ ╩╚═╝          
        ╔═╗╔═╗╦═╗  ╦ ╦╔═╗╦ ╦╦═╗  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦
        ╠╣ ║ ║╠╦╝  ╚╦╝║ ║║ ║╠╦╝  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣
        ╚  ╚═╝╩╚═   ╩ ╚═╝╚═╝╩╚═  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(2000);
                    goto labelSearchFor;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER ID OF THE POST: ");
                string? id = Console.ReadLine();
                int id_;
                if (!int.TryParse(id, out id_))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForAge;
                }
                id_ = int.Parse(id);
                if (id_ - 1 >= updatedVacancies.Count || id_ <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForAge;
                }

            lbl:;
                Console.WriteLine("\t\u25ba WHAT DOU YOU WANT TO DO? [1] - APPLY  |  [2] - COME BACK: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
╦═╗╔═╗╔═╗ ╦ ╦╔═╗╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔╦╗         
╠╦╝║╣ ║═╬╗║ ║║╣ ╚═╗ ║   ╚═╗║╣ ║║║ ║║║╣  ║║         
╩╚═╚═╝╚═╝╚╚═╝╚═╝╚═╝ ╩   ╚═╝╚═╝╝╚╝═╩╝╚═╝═╩╝         
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╦ ╦╔═╗╦╔╦╗  ╔╦╗╦╔╦╗╔═╗         
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║║║╠═╣║ ║    ║ ║║║║║╣          
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚╩╝╩ ╩╩ ╩    ╩ ╩╩ ╩╚═╝         
╦ ╦╦ ╦╔═╗╔╗╔  ╔═╗╔╦╗╔═╗╦ ╦ ╦╔═╗╦═╗  ╔═╗╦ ╦╔═╗╔═╗╦╔═
║║║╠═╣║╣ ║║║  ║╣ ║║║╠═╝║ ╚╦╝║╣ ╠╦╝  ║  ╠═╣║╣ ║  ╠╩╗
╚╩╝╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩  ╩═╝╩ ╚═╝╩╚═  ╚═╝╩ ╩╚═╝╚═╝╩ ╩
╦ ╦╔═╗╦ ╦╦═╗  ╦╔╗╔╔═╗╔═╗╦═╗╔╦╗╔═╗╔╦╗╦╔═╗╔╗╔        
╚╦╝║ ║║ ║╠╦╝  ║║║║╠╣ ║ ║╠╦╝║║║╠═╣ ║ ║║ ║║║║        
 ╩ ╚═╝╚═╝╩╚═  ╩╝╚╝╚  ╚═╝╩╚═╩ ╩╩ ╩ ╩ ╩╚═╝╝╚╝           
");
                    foreach (var item in employers)
                    {
                        if (item.Vacancies.Contains(updatedVacancies[id_ - 1]))
                        {
                            item.Notifications.Add(new Notification("Worker applyed this job", username));
                            break;
                        }
                    }
                    JsonEditor.JsonSerializeEmployers(employers);
                    Thread.Sleep(4000);
                    goto labelMenuAfterLOGWorker;
                }
                else if (key.Key == ConsoleKey.D2)
                    goto labelSearchingWork;
                else
                    goto lbl;

            }

            else if (ind == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
███████╗███████╗ █████╗ ██████╗  ██████╗██╗  ██╗    ███████╗ ██████╗ ██████╗ 
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝██║  ██║    ██╔════╝██╔═══██╗██╔══██╗
███████╗█████╗  ███████║██████╔╝██║     ███████║    █████╗  ██║   ██║██████╔╝
╚════██║██╔══╝  ██╔══██║██╔══██╗██║     ██╔══██║    ██╔══╝  ██║   ██║██╔══██╗
███████║███████╗██║  ██║██║  ██║╚██████╗██║  ██║    ██║     ╚██████╔╝██║  ██║
╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝
");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER MINIMUM UNI SCORE: ");
                int score = int.Parse(Console.ReadLine());
                List<Vacancie> vacancies = new();
                for (int i = 0; i < employers.Count; i++)
                    for (int j = 0; j < employers[i].Vacancies.Count; j++)
                        vacancies.Add(employers[i].Vacancies[j]);

                    labelSearchWorkForAge:;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                List<Vacancie> updatedVacancies = new();
                bool check = false;
                int k = 0;
                foreach (var item in vacancies)
                {
                    if (item.MinUniScore >= score)
                    {
                        check = true;
                        Console.WriteLine($"\n\n\t\t____________________ NO: {++k} ____________________");
                        updatedVacancies.Add(item);
                        item.ShowVacansie();
                    }
                }
                if (!check)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                  ╔╗╔╔═╗  ╦ ╦╔═╗╦═╗╦╔═╔═╗          
                  ║║║║ ║  ║║║║ ║╠╦╝╠╩╗╚═╗          
                  ╝╚╝╚═╝  ╚╩╝╚═╝╩╚═╩ ╩╚═╝          
        ╔═╗╔═╗╦═╗  ╦ ╦╔═╗╦ ╦╦═╗  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦
        ╠╣ ║ ║╠╦╝  ╚╦╝║ ║║ ║╠╦╝  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣
        ╚  ╚═╝╩╚═   ╩ ╚═╝╚═╝╩╚═  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(2000);
                    goto labelSearchFor;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER ID OF THE POST: ");
                string? id = Console.ReadLine();
                int id_;
                if (!int.TryParse(id, out id_))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForAge;
                }
                id_ = int.Parse(id);
                if (id_ - 1 >= updatedVacancies.Count || id_ <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForAge;
                }

            lbl:;
                Console.WriteLine("\t\u25ba WHAT DOU YOU WANT TO DO? [1] - APPLY  |  [2] - COME BACK: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
╦═╗╔═╗╔═╗ ╦ ╦╔═╗╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔╦╗         
╠╦╝║╣ ║═╬╗║ ║║╣ ╚═╗ ║   ╚═╗║╣ ║║║ ║║║╣  ║║         
╩╚═╚═╝╚═╝╚╚═╝╚═╝╚═╝ ╩   ╚═╝╚═╝╝╚╝═╩╝╚═╝═╩╝         
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╦ ╦╔═╗╦╔╦╗  ╔╦╗╦╔╦╗╔═╗         
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║║║╠═╣║ ║    ║ ║║║║║╣          
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚╩╝╩ ╩╩ ╩    ╩ ╩╩ ╩╚═╝         
╦ ╦╦ ╦╔═╗╔╗╔  ╔═╗╔╦╗╔═╗╦ ╦ ╦╔═╗╦═╗  ╔═╗╦ ╦╔═╗╔═╗╦╔═
║║║╠═╣║╣ ║║║  ║╣ ║║║╠═╝║ ╚╦╝║╣ ╠╦╝  ║  ╠═╣║╣ ║  ╠╩╗
╚╩╝╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩  ╩═╝╩ ╚═╝╩╚═  ╚═╝╩ ╩╚═╝╚═╝╩ ╩
╦ ╦╔═╗╦ ╦╦═╗  ╦╔╗╔╔═╗╔═╗╦═╗╔╦╗╔═╗╔╦╗╦╔═╗╔╗╔        
╚╦╝║ ║║ ║╠╦╝  ║║║║╠╣ ║ ║╠╦╝║║║╠═╣ ║ ║║ ║║║║        
 ╩ ╚═╝╚═╝╩╚═  ╩╝╚╝╚  ╚═╝╩╚═╩ ╩╩ ╩ ╩ ╩╚═╝╝╚╝           
");
                    foreach (var item in employers)
                    {
                        if (item.Vacancies.Contains(updatedVacancies[id_ - 1]))
                        {
                            item.Notifications.Add(new Notification("Worker applyed this job", username));
                            break;
                        }
                    }
                    JsonEditor.JsonSerializeEmployers(employers);
                    Thread.Sleep(4000);
                    goto labelMenuAfterLOGWorker;
                }
                else if (key.Key == ConsoleKey.D2)
                    goto labelSearchingWork;
                else
                    goto lbl;
            }

            else if (ind == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
███████╗███████╗ █████╗ ██████╗  ██████╗██╗  ██╗    ███████╗ ██████╗ ██████╗ 
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝██║  ██║    ██╔════╝██╔═══██╗██╔══██╗
███████╗█████╗  ███████║██████╔╝██║     ███████║    █████╗  ██║   ██║██████╔╝
╚════██║██╔══╝  ██╔══██║██╔══██╗██║     ██╔══██║    ██╔══╝  ██║   ██║██╔══██╗
███████║███████╗██║  ██║██║  ██║╚██████╗██║  ██║    ██║     ╚██████╔╝██║  ██║
╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝
");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba NEED TO SPECIFIED DIPLOM? ([1] - yes, [0] - no): ");
                bool hasdiplom = (int.Parse(Console.ReadLine()) == 0) ? false : true;
                List<Vacancie> vacancies = new();
                for (int i = 0; i < employers.Count; i++)
                    for (int j = 0; j < employers[i].Vacancies.Count; j++)
                        vacancies.Add(employers[i].Vacancies[j]);

                    labelSearchWorkForAge:;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                List<Vacancie> updatedVacancies = new();
                bool check = false;
                int k = 0;
                foreach (var item in vacancies)
                {
                    if (item.HaveToSpecifiedDiplom == hasdiplom)
                    {
                        check = true;
                        Console.WriteLine($"\n\n\t\t____________________ NO: {++k} ____________________");
                        updatedVacancies.Add(item);
                        item.ShowVacansie();
                    }
                }
                if (!check)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                  ╔╗╔╔═╗  ╦ ╦╔═╗╦═╗╦╔═╔═╗          
                  ║║║║ ║  ║║║║ ║╠╦╝╠╩╗╚═╗          
                  ╝╚╝╚═╝  ╚╩╝╚═╝╩╚═╩ ╩╚═╝          
        ╔═╗╔═╗╦═╗  ╦ ╦╔═╗╦ ╦╦═╗  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦
        ╠╣ ║ ║╠╦╝  ╚╦╝║ ║║ ║╠╦╝  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣
        ╚  ╚═╝╩╚═   ╩ ╚═╝╚═╝╩╚═  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(2000);
                    goto labelSearchFor;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER ID OF THE POST: ");
                string? id = Console.ReadLine();
                int id_;
                if (!int.TryParse(id, out id_))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForAge;
                }
                id_ = int.Parse(id);
                if (id_ - 1 >= updatedVacancies.Count || id_ <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForAge;
                }

            lbl:;
                Console.WriteLine("\t\u25ba WHAT DOU YOU WANT TO DO? [1] - APPLY  |  [2] - COME BACK: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
╦═╗╔═╗╔═╗ ╦ ╦╔═╗╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔╦╗         
╠╦╝║╣ ║═╬╗║ ║║╣ ╚═╗ ║   ╚═╗║╣ ║║║ ║║║╣  ║║         
╩╚═╚═╝╚═╝╚╚═╝╚═╝╚═╝ ╩   ╚═╝╚═╝╝╚╝═╩╝╚═╝═╩╝         
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╦ ╦╔═╗╦╔╦╗  ╔╦╗╦╔╦╗╔═╗         
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║║║╠═╣║ ║    ║ ║║║║║╣          
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚╩╝╩ ╩╩ ╩    ╩ ╩╩ ╩╚═╝         
╦ ╦╦ ╦╔═╗╔╗╔  ╔═╗╔╦╗╔═╗╦ ╦ ╦╔═╗╦═╗  ╔═╗╦ ╦╔═╗╔═╗╦╔═
║║║╠═╣║╣ ║║║  ║╣ ║║║╠═╝║ ╚╦╝║╣ ╠╦╝  ║  ╠═╣║╣ ║  ╠╩╗
╚╩╝╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩  ╩═╝╩ ╚═╝╩╚═  ╚═╝╩ ╩╚═╝╚═╝╩ ╩
╦ ╦╔═╗╦ ╦╦═╗  ╦╔╗╔╔═╗╔═╗╦═╗╔╦╗╔═╗╔╦╗╦╔═╗╔╗╔        
╚╦╝║ ║║ ║╠╦╝  ║║║║╠╣ ║ ║╠╦╝║║║╠═╣ ║ ║║ ║║║║        
 ╩ ╚═╝╚═╝╩╚═  ╩╝╚╝╚  ╚═╝╩╚═╩ ╩╩ ╩ ╩ ╩╚═╝╝╚╝           
");
                    foreach (var item in employers)
                    {
                        if (item.Vacancies.Contains(updatedVacancies[id_ - 1]))
                        {
                            item.Notifications.Add(new Notification("Worker applyed this job", username));
                            break;
                        }
                    }
                    JsonEditor.JsonSerializeEmployers(employers);
                    Thread.Sleep(4000);
                    goto labelMenuAfterLOGWorker;
                }
                else if (key.Key == ConsoleKey.D2)
                    goto labelSearchingWork;
                else
                    goto lbl;
            }

            else if (ind == 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
███████╗███████╗ █████╗ ██████╗  ██████╗██╗  ██╗    ███████╗ ██████╗ ██████╗ 
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝██║  ██║    ██╔════╝██╔═══██╗██╔══██╗
███████╗█████╗  ███████║██████╔╝██║     ███████║    █████╗  ██║   ██║██████╔╝
╚════██║██╔══╝  ██╔══██║██╔══██╗██║     ██╔══██║    ██╔══╝  ██║   ██║██╔══██╗
███████║███████╗██║  ██║██║  ██║╚██████╗██║  ██║    ██║     ╚██████╔╝██║  ██║
╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝
");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER MINIMUM SALARY: ");
                int salary = int.Parse(Console.ReadLine());
                List<Vacancie> vacancies = new();
                for (int i = 0; i < employers.Count; i++)
                    for (int j = 0; j < employers[i].Vacancies.Count; j++)
                        vacancies.Add(employers[i].Vacancies[j]);

                labelSearchWorkSalary:;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                List<Vacancie> updatedVacancies = new();
                bool check = false;
                int k = 0;
                foreach (var item in vacancies)
                {
                    if (item.Salary >= salary)
                    {
                        check = true;
                        Console.WriteLine($"\n\n\t\t____________________ NO: {++k} ____________________");
                        updatedVacancies.Add(item);
                        item.ShowVacansie();
                    }
                }
                if (!check)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                  ╔╗╔╔═╗  ╦ ╦╔═╗╦═╗╦╔═╔═╗          
                  ║║║║ ║  ║║║║ ║╠╦╝╠╩╗╚═╗          
                  ╝╚╝╚═╝  ╚╩╝╚═╝╩╚═╩ ╩╚═╝          
        ╔═╗╔═╗╦═╗  ╦ ╦╔═╗╦ ╦╦═╗  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦
        ╠╣ ║ ║╠╦╝  ╚╦╝║ ║║ ║╠╦╝  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣
        ╚  ╚═╝╩╚═   ╩ ╚═╝╚═╝╩╚═  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(2000);
                    goto labelSearchFor;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER ID OF THE POST: ");
                string? id = Console.ReadLine();
                int id_;
                if (!int.TryParse(id, out id_))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkSalary;
                }
                id_ = int.Parse(id);
                if (id_ - 1 >= updatedVacancies.Count || id_ <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkSalary;
                }

                lbl:;
                Console.WriteLine("\t\u25ba WHAT DOU YOU WANT TO DO? [1] - APPLY  |  [2] - COME BACK: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
╦═╗╔═╗╔═╗ ╦ ╦╔═╗╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔╦╗         
╠╦╝║╣ ║═╬╗║ ║║╣ ╚═╗ ║   ╚═╗║╣ ║║║ ║║║╣  ║║         
╩╚═╚═╝╚═╝╚╚═╝╚═╝╚═╝ ╩   ╚═╝╚═╝╝╚╝═╩╝╚═╝═╩╝         
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╦ ╦╔═╗╦╔╦╗  ╔╦╗╦╔╦╗╔═╗         
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║║║╠═╣║ ║    ║ ║║║║║╣          
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚╩╝╩ ╩╩ ╩    ╩ ╩╩ ╩╚═╝         
╦ ╦╦ ╦╔═╗╔╗╔  ╔═╗╔╦╗╔═╗╦ ╦ ╦╔═╗╦═╗  ╔═╗╦ ╦╔═╗╔═╗╦╔═
║║║╠═╣║╣ ║║║  ║╣ ║║║╠═╝║ ╚╦╝║╣ ╠╦╝  ║  ╠═╣║╣ ║  ╠╩╗
╚╩╝╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩  ╩═╝╩ ╚═╝╩╚═  ╚═╝╩ ╩╚═╝╚═╝╩ ╩
╦ ╦╔═╗╦ ╦╦═╗  ╦╔╗╔╔═╗╔═╗╦═╗╔╦╗╔═╗╔╦╗╦╔═╗╔╗╔        
╚╦╝║ ║║ ║╠╦╝  ║║║║╠╣ ║ ║╠╦╝║║║╠═╣ ║ ║║ ║║║║        
 ╩ ╚═╝╚═╝╩╚═  ╩╝╚╝╚  ╚═╝╩╚═╩ ╩╩ ╩ ╩ ╩╚═╝╝╚╝           
");
                    foreach (var item in employers)
                    {
                        if (item.Vacancies.Contains(updatedVacancies[id_ - 1]))
                        {
                            item.Notifications.Add(new Notification("Worker applyed this job", username));
                            break;
                        }
                    }
                    JsonEditor.JsonSerializeEmployers(employers);
                    Thread.Sleep(4000);
                    goto labelMenuAfterLOGWorker;
                }
                else if (key.Key == ConsoleKey.D2)
                    goto labelSearchingWork;
                else
                    goto lbl;
            }

            else if (ind == 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"
███████╗███████╗ █████╗ ██████╗  ██████╗██╗  ██╗    ███████╗ ██████╗ ██████╗ 
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝██║  ██║    ██╔════╝██╔═══██╗██╔══██╗
███████╗█████╗  ███████║██████╔╝██║     ███████║    █████╗  ██║   ██║██████╔╝
╚════██║██╔══╝  ██╔══██║██╔══██╗██║     ██╔══██║    ██╔══╝  ██║   ██║██╔══██╗
███████║███████╗██║  ██║██║  ██║╚██████╗██║  ██║    ██║     ╚██████╔╝██║  ██║
╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝
");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba DO YOU WANT REMOTED WORK? ([1] - yes, [0] - no): ");
                bool remoted = (int.Parse(Console.ReadLine()) == 0) ? false : true;
                List<Vacancie> vacancies = new();
                for (int i = 0; i < employers.Count; i++)
                    for (int j = 0; j < employers[i].Vacancies.Count; j++)
                        vacancies.Add(employers[i].Vacancies[j]);

                labelSearchWorkForRemoted:;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                List<Vacancie> updatedVacancies = new();
                bool check = false;
                int k = 0;
                foreach (var item in vacancies)
                {
                    if (item.IsRemoted == remoted)
                    {
                        check = true;
                        Console.WriteLine($"\n\n\t\t____________________ NO: {++k} ____________________");
                        updatedVacancies.Add(item);
                        item.ShowVacansie();
                    }
                }
                if (!check)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
                  ╔╗╔╔═╗  ╦ ╦╔═╗╦═╗╦╔═╔═╗          
                  ║║║║ ║  ║║║║ ║╠╦╝╠╩╗╚═╗          
                  ╝╚╝╚═╝  ╚╩╝╚═╝╩╚═╩ ╩╚═╝          
        ╔═╗╔═╗╦═╗  ╦ ╦╔═╗╦ ╦╦═╗  ╔═╗╔═╗╔═╗╦═╗╔═╗╦ ╦
        ╠╣ ║ ║╠╦╝  ╚╦╝║ ║║ ║╠╦╝  ╚═╗║╣ ╠═╣╠╦╝║  ╠═╣
        ╚  ╚═╝╩╚═   ╩ ╚═╝╚═╝╩╚═  ╚═╝╚═╝╩ ╩╩╚═╚═╝╩ ╩
");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(2000);
                    goto labelSearchFor;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\t\u25ba ENTER ID OF THE POST: ");
                string? id = Console.ReadLine();
                int id_;
                if (!int.TryParse(id, out id_))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
╔═╗╔═╗╔╗╔╔╗╔╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╦  ╦╔═╗╦═╗╔╦╗  
║  ╠═╣║║║║║║║ ║ ║   ║  ║ ║║║║╚╗╔╝║╣ ╠╦╝ ║   
╚═╝╩ ╩╝╚╝╝╚╝╚═╝ ╩   ╚═╝╚═╝╝╚╝ ╚╝ ╚═╝╩╚═ ╩   
    ╔═╗╔╦╗╦═╗╦╔╗╔╔═╗  ╔╦╗╔═╗  ╦╔╗╔╔╦╗       
    ╚═╗ ║ ╠╦╝║║║║║ ╦   ║ ║ ║  ║║║║ ║        
    ╚═╝ ╩ ╩╚═╩╝╚╝╚═╝   ╩ ╚═╝  ╩╝╚╝ ╩        
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForRemoted;
                }
                id_ = int.Parse(id);
                if (id_ - 1 >= updatedVacancies.Count || id_ <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
      ╦ ╦╦═╗╔═╗╔╗╔╔═╗       
      ║║║╠╦╝║ ║║║║║ ╦       
      ╚╩╝╩╚═╚═╝╝╚╝╚═╝       
    ╔═╗╦═╗╔═╗╦ ╦╔╦╗╔═╗╔╗╔╔╦╗
    ╠═╣╠╦╝║ ╦║ ║║║║║╣ ║║║ ║ 
    ╩ ╩╩╚═╚═╝╚═╝╩ ╩╚═╝╝╚╝ ╩       
");
                    Thread.Sleep(1500);
                    goto labelSearchWorkForRemoted;
                }

            lbl:;
                Console.WriteLine("\t\u25ba WHAT DOU YOU WANT TO DO? [1] - APPLY  |  [2] - COME BACK: ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
╦═╗╔═╗╔═╗ ╦ ╦╔═╗╔═╗╔╦╗  ╔═╗╔═╗╔╗╔╔╦╗╔═╗╔╦╗         
╠╦╝║╣ ║═╬╗║ ║║╣ ╚═╗ ║   ╚═╗║╣ ║║║ ║║║╣  ║║         
╩╚═╚═╝╚═╝╚╚═╝╚═╝╚═╝ ╩   ╚═╝╚═╝╝╚╝═╩╝╚═╝═╩╝         
╔═╗╦  ╔═╗╔═╗╔═╗╔═╗  ╦ ╦╔═╗╦╔╦╗  ╔╦╗╦╔╦╗╔═╗         
╠═╝║  ║╣ ╠═╣╚═╗║╣   ║║║╠═╣║ ║    ║ ║║║║║╣          
╩  ╩═╝╚═╝╩ ╩╚═╝╚═╝  ╚╩╝╩ ╩╩ ╩    ╩ ╩╩ ╩╚═╝         
╦ ╦╦ ╦╔═╗╔╗╔  ╔═╗╔╦╗╔═╗╦ ╦ ╦╔═╗╦═╗  ╔═╗╦ ╦╔═╗╔═╗╦╔═
║║║╠═╣║╣ ║║║  ║╣ ║║║╠═╝║ ╚╦╝║╣ ╠╦╝  ║  ╠═╣║╣ ║  ╠╩╗
╚╩╝╩ ╩╚═╝╝╚╝  ╚═╝╩ ╩╩  ╩═╝╩ ╚═╝╩╚═  ╚═╝╩ ╩╚═╝╚═╝╩ ╩
╦ ╦╔═╗╦ ╦╦═╗  ╦╔╗╔╔═╗╔═╗╦═╗╔╦╗╔═╗╔╦╗╦╔═╗╔╗╔        
╚╦╝║ ║║ ║╠╦╝  ║║║║╠╣ ║ ║╠╦╝║║║╠═╣ ║ ║║ ║║║║        
 ╩ ╚═╝╚═╝╩╚═  ╩╝╚╝╚  ╚═╝╩╚═╩ ╩╩ ╩ ╩ ╩╚═╝╝╚╝           
");
                    foreach (var item in employers)
                    {
                        if (item.Vacancies.Contains(updatedVacancies[id_ - 1]))
                        {
                            item.Notifications.Add(new Notification("Worker applyed this job", username));
                            break;
                        }
                    }
                    JsonEditor.JsonSerializeEmployers(employers);
                    Thread.Sleep(4000);
                    goto labelMenuAfterLOGWorker;
                }
                else if (key.Key == ConsoleKey.D2)
                    goto labelSearchingWork;
                else
                    goto lbl;
            }

            else if(ind == -1)
                goto labelSearchingWork;

        }

        else if (ind == -1)
            goto labelMenuAfterLOGWorker;
    }

    // QUIT JOB
    else if (ind == 2)
    {
        Console.Clear();
        if (!workers[indexOfWorker].IsWorking)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
    ╦ ╦╔═╗╦ ╦  ╔═╗╦═╗╔═╗  ╔╗╔╔═╗╔╦╗  
    ╚╦╝║ ║║ ║  ╠═╣╠╦╝║╣   ║║║║ ║ ║   
     ╩ ╚═╝╚═╝  ╩ ╩╩╚═╚═╝  ╝╚╝╚═╝ ╩   
        ╦ ╦╔═╗╦═╗╦╔═╦╔╗╔╔═╗          
        ║║║║ ║╠╦╝╠╩╗║║║║║ ╦          
        ╚╩╝╚═╝╩╚═╩ ╩╩╝╚╝╚═╝                  
");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2000);
            goto labelMenuAfterLOGWorker;
        }
        
        ind = Method.Selecting(new string[] {
        "\t╦ ╦╔═╗╔═╗\n" +
        "\t\t\t╚╦╝║╣ ╚═╗\n" +
        "\t\t\t ╩ ╚═╝╚═╝",
        "\t  ╔╗╔╔═╗ \n" +
        "\t\t\t  ║║║║ ║ \n" +
        "\t\t\t  ╝╚╝╚═╝ " }, @"
  ╔╦╗╔═╗  ╦ ╦╔═╗╦ ╦  ╦═╗╔═╗╔═╗╦  ╦ ╦ ╦ 
   ║║║ ║  ╚╦╝║ ║║ ║  ╠╦╝║╣ ╠═╣║  ║ ╚╦╝ 
  ═╩╝╚═╝   ╩ ╚═╝╚═╝  ╩╚═╚═╝╩ ╩╩═╝╩═╝╩  
    ╦ ╦╔═╗╔╗╔╔╦╗  ╔╦╗╔═╗  ╔═╗ ╦ ╦╦╔╦╗  
    ║║║╠═╣║║║ ║    ║ ║ ║  ║═╬╗║ ║║ ║   
    ╚╩╝╩ ╩╝╚╝ ╩    ╩ ╚═╝  ╚═╝╚╚═╝╩ ╩   
      ╦ ╦╔═╗╦ ╦╦═╗   ╦╔═╗╔╗  ┌─┐          
      ╚╦╝║ ║║ ║╠╦╝   ║║ ║╠╩╗  ┌┘          
       ╩ ╚═╝╚═╝╩╚═  ╚╝╚═╝╚═╝  o          
");
        if (ind == 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
╦ ╦╔═╗╦ ╦  ╔═╗╦ ╦╔═╗╔═╗╦ ╦╔═╗╔═╗╦ ╦╦ ╦ ╦
╚╦╝║ ║║ ║  ╚═╗║ ║║  ║  ║║║╚═╗╠╣ ║ ║║ ╚╦╝
 ╩ ╚═╝╚═╝  ╚═╝╚═╝╚═╝╚═╝╚╩╝╚═╝╚  ╚═╝╩═╝╩ 
    ╔═╗ ╦ ╦╦╔╦╗╔═╗╔╦╗   ╦╔═╗╔╗          
    ║═╬╗║ ║║ ║ ║╣  ║║   ║║ ║╠╩╗         
    ╚═╝╚╚═╝╩ ╩ ╚═╝═╩╝  ╚╝╚═╝╚═╝         
");
            workers[indexOfWorker].IsWorking = false;
            JsonEditor.JsonSerializeWorker(workers);
            Thread.Sleep(2500);
            goto labelMenuAfterLOGWorker;
        }

        else if (ind == 1 || ind == -1)
            goto labelMenuAfterLOGWorker;
    }

    else if (ind == -1)
    {
        goto labelMenu;
    }
}

// Esc
else if (ind == -1)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.CursorVisible = false;
    Console.WriteLine("\n\n");
    Console.WriteLine("\t\t_/_/_/_/  _/      _/  _/_/_/  _/_/_/_/_/  _/_/_/_/  _/_/_/       ");
    Console.WriteLine("\t      _/          _/  _/      _/        _/      _/        _/    _/ ");   
    Console.WriteLine("\t     _/_/_/        _/        _/        _/      _/_/_/    _/    _/  ");   
    Console.WriteLine("\t    _/          _/  _/      _/        _/      _/        _/    _/   ");   
    Console.WriteLine("\t   _/_/_/_/  _/      _/  _/_/_/      _/      _/_/_/_/  _/_/_/      ");  
    Console.Read();
}
