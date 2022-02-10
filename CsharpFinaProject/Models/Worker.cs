using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFinaProject.Models
{
    sealed partial class Worker
    { 
        public static int statId;

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? City { get; set; }

        public string? Phone { get; set; }

        public int Age { get; set; }

        public DateTime? BeginToWorkTime { get; set; }

        public DateTime? EndWorkTime { get; set; }

        public CV CV { get; set; }

        public bool IsWorking { get; set; }
    }

    sealed partial class Worker
    {
        // constructor
        public Worker() { }

        public Worker(string name, string surname, string username, string password, string city, string phone, int age, DateTime? beginToWorkTime, DateTime? endWorkTime, CV cV, bool isWorking)
        {
            statId += 1;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            City = city;
            Phone = phone;
            Age = age;
            BeginToWorkTime = beginToWorkTime;
            EndWorkTime = endWorkTime;
            CV = cV;
            IsWorking = isWorking;
        }
    }



    sealed partial class CV
    {
        public static int ID;

        public string Ixtisas { get; set; }

        public string School { get; set; }

        public int UniScore { get; set; }

        public List<string> AbilituesLanguage { get; set; }

        public List<string> Companies { get; set; }

        public List<string> KnowForeignLanguage { get; set; }

        public string GITLINK { get; set; }

        public string LINKEDLINK { get; set; }

        public bool HasDiplom { get; set; }

    }

    sealed partial class CV
    {
        // constructors
        public CV() { }

        public CV(string ixtisas, string school, int uniScore, List<string> abilituesLanguage, List<string> companies, 
            List<string> knowForeignLanguage, bool hasDiplom, string gitlink, string linkedlink)
        {
            ID += 1;
            Ixtisas = ixtisas;
            School = school;
            UniScore = uniScore;
            AbilituesLanguage = abilituesLanguage;
            Companies = companies;
            KnowForeignLanguage = knowForeignLanguage;
            HasDiplom = hasDiplom;
            GITLINK = gitlink;
            LINKEDLINK = linkedlink;
        }
        // method
        public void ShowCV()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("█████████████████████████████");
            Console.WriteLine("██         ╔═╗╦  ╦         ██");
            Console.WriteLine("██         ║  ╚╗╔╝         ██");
            Console.WriteLine("██         ╚═╝ ╚╝          ██");
            Console.WriteLine("█████████████████████████████");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nProfession: {Ixtisas}");
            Console.WriteLine($"School: {School}");
            Console.WriteLine($"Uni Score: {UniScore}");
            Console.Write("Scills: ");
            AbilituesLanguage.ForEach(lan => Console.Write($"{lan} "));
            Console.Write("\nWorks in: ");
            Companies.ForEach(com => Console.Write($"{com} "));
            Console.Write("\nKnows Foreign Languages: ");
            KnowForeignLanguage.ForEach(lan => Console.Write($"{lan} "));
            Console.WriteLine($"\nHas Specified Diplom: {HasDiplom}");
            Console.WriteLine($"GITLINK: {GITLINK}");
            Console.WriteLine($"LINKEDLINK: {LINKEDLINK}");



        }

    }
}
