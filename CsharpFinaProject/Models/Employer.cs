using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpFinaProject.Models
{
    sealed partial class Employer
    {
        public static int statId = 1;

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public int Age { get; set; }

        public List<Vacancie> Vacancies { get; set; }

        public List<Notification> Notifications { get; set; }
    }

    sealed partial class Employer
    {
        // constructor
        public Employer(string name, string surname, string city, string phone, 
            int age, List<Vacancie> vacancies, string username, string password, List<Notification> notifications)
        {
            statId += 1;
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            Vacancies = vacancies;
            Username = username;
            Password = password;
            Notifications = notifications;
        }
    }



    sealed partial class Vacancie
    {
        public static int ID;

        public List<string> LanguagesOfPrograming { get; set; }

        public int StartingAge { get; set; }

        public int MinUniScore { get; set; }

        public List<string> NeedToKnowLanguages { get; set; }

        public bool HaveToSpecifiedDiplom { get; set; }

        public double Salary { get; set; }

        public bool IsRemoted { get; set; }

    }

    sealed partial class Vacancie
    {
        // constructor
        public Vacancie() { }
        public Vacancie(List<string> languagesOfPrograming, int startingAge, int minUniScore, 
            List<string> needToKnowLanguages, bool haveToSpecifiedDiplom, double salary, bool isRemoted)
        {
            ID += 1;
            LanguagesOfPrograming = languagesOfPrograming;
            StartingAge = startingAge;
            MinUniScore = minUniScore;
            NeedToKnowLanguages = needToKnowLanguages;
            HaveToSpecifiedDiplom = haveToSpecifiedDiplom;
            Salary = salary;
            IsRemoted = isRemoted;
        }

        // method
        public void ShowVacansie()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t███████████████████████████████████████████████");
            Console.WriteLine("\t\t███     ╦  ╦ ╔═╗ ╔═╗ ╔═╗ ╔╗╔ ╔═╗ ╦ ╔═╗      ███");
            Console.WriteLine("\t\t███     ╚╗╔╝ ╠═╣ ║   ╠═╣ ║║║ ╚═╗ ║ ║╣       ███");
            Console.WriteLine("\t\t███      ╚╝  ╩ ╩ ╚═╝ ╩ ╩ ╝╚╝ ╚═╝ ╩ ╚═╝      ███");
            Console.WriteLine("\t\t███████████████████████████████████████████████");
            Console.Write("\t\t\u25ba LANGUAGES OF PROGRAMING: ");
            LanguagesOfPrograming.ForEach(lan => Console.Write(lan + " "));
            Console.WriteLine($"\n\t\t\u25ba STARTING AGE: {StartingAge}");
            Console.WriteLine($"\t\t\u25ba MINIMUM UNI SCORE: {MinUniScore}");
            Console.Write("\t\t\u25ba NEED TO KNOW LANGUAGES: ");
            NeedToKnowLanguages.ForEach(lan => Console.Write(lan + " "));
            Console.WriteLine($"\n\t\t\u25ba SPECIFIED DIPLOM NEED: {HaveToSpecifiedDiplom}");
            Console.WriteLine($"\t\t\u25ba SALARY: {Salary}");
            Console.WriteLine($"\t\t\u25ba IS REMOTED: {IsRemoted}");
        }

    }



    sealed partial class Notification
    {
        public string Info { get; set; }

        public DateTime Datetime { get; set; }

        public string FromUser { get; set; }
    }

    sealed partial class Notification
    {
        // constructor
        public Notification(string info, string fromUser)
        {
            Info = info;
            Datetime = DateTime.Now;
            FromUser = fromUser;
        }

        // override
        public override string ToString() =>
            $"NOTIFICATION: INFO: {Info} | DATETIME: {Datetime.ToShortDateString()} | FROM: {FromUser}\n";
        
    }


}