using CsharpFinaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Method
    {
        public static string ToPassword(string txt, string? username, bool color)
        {
            string st = string.Empty;
            int count = 1;
            Console.Write(txt);
            while (true)
            {
                var key = Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ██▓     ▒█████    ▄████  ██▓ ███▄    █ ");
                Console.WriteLine("▓██▒    ▒██▒  ██▒ ██▒ ▀█▒▓░░▒ ██ ▀█   █ ");
                Console.WriteLine("▒██░    ▒██░  ██▒▒██░▄▄▄░▒██▒▓██  ▀█ ██▒");
                Console.WriteLine("▒██░    ▒██   ██░░▓█  ██▓░██░▓██▒  ▐▌██▒");
                Console.WriteLine("░██████▒░ ████▓▒░░▒▓███▀▒░██░▒██░   ▓██░");
                Console.WriteLine("░ ▒░▓  ░░ ▒░▒░▒░  ░▒   ▒ ░▓  ░ ▒░   ▒ ▒ ");
                Console.WriteLine("░ ░ ▒  ░  ░ ▒ ▒░   ░   ░  ▒ ░░ ░░   ░ ▒░");
                Console.WriteLine("  ░ ░   ░ ░ ░ ▒  ░ ░   ░  ▒ ░   ░   ░ ░ ");
                Console.WriteLine("    ░  ░    ░ ░        ░  ░           ░ ");
                if (color == true) 
                    Console.ForegroundColor= ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n\n\n\t\t\u25ba ENTER USERNAME: {username}");
                Console.Write(txt);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return st;
                }
                char ckey = key.KeyChar;
                st += ckey;
                for (int i = 0; i < count; i++)
                    Console.Write("*");
                count++;
            }

        }

        public static string? Login(object? collection)
        {
            List<Worker>? newcollection = collection as List<Worker>;
            List<Employer>? newcollectione = collection as List<Employer>;
            string? usernameOfPerson = "";

            labelLoginUsername:;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ██▓     ▒█████    ▄████  ██▓ ███▄    █ ");
            Console.WriteLine("▓██▒    ▒██▒  ██▒ ██▒ ▀█▒▓░░▒ ██ ▀█   █ ");
            Console.WriteLine("▒██░    ▒██░  ██▒▒██░▄▄▄░▒██▒▓██  ▀█ ██▒");
            Console.WriteLine("▒██░    ▒██   ██░░▓█  ██▓░██░▓██▒  ▐▌██▒");
            Console.WriteLine("░██████▒░ ████▓▒░░▒▓███▀▒░██░▒██░   ▓██░");
            Console.WriteLine("░ ▒░▓  ░░ ▒░▒░▒░  ░▒   ▒ ░▓  ░ ▒░   ▒ ▒ ");
            Console.WriteLine("░ ░ ▒  ░  ░ ▒ ▒░   ░   ░  ▒ ░░ ░░   ░ ▒░");
            Console.WriteLine("  ░ ░   ░ ░ ░ ▒  ░ ░   ░  ▒ ░   ░   ░ ░ ");
            Console.WriteLine("    ░  ░    ░ ░        ░  ░           ░ ");
            if (newcollectione != null) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n\n\n\t\t\u25ba ENTER USERNAME: ");
            var usnm = Console.ReadLine();
            bool check = false;
            if (newcollectione != null)
            {
                foreach (var person in newcollectione)
                {
                    if (person.Username == usnm)
                    {
                        usernameOfPerson = person.Username;
                        check = true;
                        break;
                    }
                }
            }
            else
            {
                foreach (var person in newcollection)
                {
                    if (person.Username == usnm)
                    {
                        usernameOfPerson = person.Username;
                        check = true;
                        break;
                    }
                }
            }
            
            if (!check)
                goto labelLoginUsername;

            labelLoginPassword:;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ██▓     ▒█████    ▄████  ██▓ ███▄    █ ");
            Console.WriteLine("▓██▒    ▒██▒  ██▒ ██▒ ▀█▒▓░░▒ ██ ▀█   █ ");
            Console.WriteLine("▒██░    ▒██░  ██▒▒██░▄▄▄░▒██▒▓██  ▀█ ██▒");
            Console.WriteLine("▒██░    ▒██   ██░░▓█  ██▓░██░▓██▒  ▐▌██▒");
            Console.WriteLine("░██████▒░ ████▓▒░░▒▓███▀▒░██░▒██░   ▓██░");
            Console.WriteLine("░ ▒░▓  ░░ ▒░▒░▒░  ░▒   ▒ ░▓  ░ ▒░   ▒ ▒ ");
            Console.WriteLine("░ ░ ▒  ░  ░ ▒ ▒░   ░   ░  ▒ ░░ ░░   ░ ▒░");
            Console.WriteLine("  ░ ░   ░ ░ ░ ▒  ░ ░   ░  ▒ ░   ░   ░ ░ ");
            Console.WriteLine("    ░  ░    ░ ░        ░  ░           ░ ");
            if (newcollectione != null) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n\n\n\t\t\u25ba ENTER USERNAME: {usnm}");
            var psw = Method.ToPassword("\t\t\u25ba ENTER PASSWORD: ", usnm, newcollectione != null);

            check = false;

            if (newcollectione != null)
            {
                foreach (var person in newcollectione)
                {
                    if (person.Password == psw)
                    {
                        check = true;
                        break;
                    }
                }
            }
            else
            {
                foreach (var person in newcollection)
                {
                    if (person.Password == psw)
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (!check)
                goto labelLoginPassword;
            return usernameOfPerson;
        }

        public static int Selecting(string[] menu, string txt)
        {
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(txt);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\n\t\t{menu[0]}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 1; i < menu.Length; i++)
            {
                Console.WriteLine($"\t\t{menu[i]}");
            }
            int ind = 0;


            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.CursorVisible = true;
                    return -1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.CursorVisible = true;
                    break;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    if (ind + 1 == menu.Length)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(txt);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        ind = 0;
                        Console.WriteLine("\n");
                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == ind)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\t\t{menu[i]}");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Green;
                                continue;
                            }
                            Console.WriteLine($"\t\t{menu[i]}");
                        }
                        Thread.Sleep(60);
                        continue;
                    }

                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(txt);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n");
                        ind++;
                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == ind)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\t\t{menu[i]}");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Green;
                                continue;
                            }
                            Console.WriteLine($"\t\t{menu[i]}");
                        }
                        Thread.Sleep(60);
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (ind - 1 < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(txt);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        ind = menu.Length - 1;
                        Console.WriteLine("\n");
                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == ind)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\t\t{menu[i]}");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Green;
                                continue;
                            }
                            Console.WriteLine($"\t\t{menu[i]}");
                        }
                        Thread.Sleep(60);
                        continue;
                    }

                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(txt);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Green;
                        ind--;
                        Console.WriteLine("\n");
                        for (int i = 0; i < menu.Length; i++)
                        {
                            if (i == ind)
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\t\t{menu[i]}");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Green;
                                continue;
                            }
                            Console.WriteLine($"\t\t{menu[i]}");
                        }
                        Thread.Sleep(60);
                    }
                }
                else
                    continue;
            }
            return ind;
        }
    }
}
