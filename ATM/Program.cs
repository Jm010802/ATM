using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using AppLayer;

namespace ATM
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Want do you want to do?");

            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Login your account");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Please enter 1, 2, and 3 only.");


            bool invalidInput = true;
            while (invalidInput)
            {
                string choice = Console.ReadLine().Trim();
                char option = char.Parse(choice);

                switch (option)
                {
                    case '1':
                        invalidInput = false;
                        createUser.Creating();
                        break;
                    case '2':
                        invalidInput = false;
                        LoginForm.UserLogin();
                        break;
                    case '3':
                        invalidInput = false;
                        Console.WriteLine("Exiting the system now. . . Thankyou for using our system. :)", Console.ForegroundColor = ConsoleColor.Yellow);
                        Console.ResetColor();
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"Your choice {choice} is invalid! The choices are 1, 2 and 3 only.", Console.ForegroundColor = ConsoleColor.Red);
                        Console.WriteLine("Please choose again.");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}