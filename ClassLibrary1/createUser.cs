using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AppLayer;

namespace DataLayer
{
    public class createUser
    {
        public static string userCreation = "CreateUser.txt";
        public static void AppendFile(List<string> userInput)
        {
            Queue<string> defferedLines = new Queue<string>();

            using (StreamWriter file = File.AppendText(userCreation))
            {
                WriteDataInFile(file, userInput);
            }

        }
        internal static void WriteDataInFile(StreamWriter file, List<string> userInput)
        {
            foreach (var data in userInput)
            {
                file.Write(data);
            }
        }
        public static void Creating()
        {
            List<string> userName = CreateUser.accountName();
            List<string> userPass = CreateUser.accountPassword();
            AppendFile(userName);
            AppendFile(userPass);
        }
        public static void Verifying()
        {
            List<string> dataList = new List<string>();
            string verification, verification1;
            Console.WriteLine("Account Name: ");
            verification = Console.ReadLine();
            var line1 = File.ReadAllLines(userCreation);
            Console.WriteLine("Account Password: ");
            verification1 = Console.ReadLine();
            var lines = File.ReadAllLines(userCreation);
            string result = null;
            foreach (var line in line1)
            {
                if (line.Contains(verification))
                {
                    result = line;
                    break;
                }
            }
            if (result == verification)
            {
                Console.WriteLine("\nLogin Successful!\n", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
                Transaction.Transactions();
            }
            else
            {
                Console.WriteLine("\nYou have entered the incorrect information. Login Failed.", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("Please login again.\n");
                Console.ResetColor();
            }

        }
    }
}
