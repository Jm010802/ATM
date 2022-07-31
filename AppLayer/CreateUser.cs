using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace AppLayer
{
    public class CreateUser
    {
        public static List<string> accountName()
        {
            List<string> dataList = new List<string>();
            string userName;
            do
            {
                Console.WriteLine("Account Name: ");
                userName = Console.ReadLine();

                if (userName.Length == 15 && userName.StartsWith("20") && userName.EndsWith("BN-0"))
                {
                    dataList.Add($"\n{userName}");
                    using (StreamWriter sw = new StreamWriter(File.Create("C:\\Users\\ADMIN\\source\\repos\\ATM\\ClassLibrary1\\AccountName.txt")))
                    {
                        sw.WriteLine(userName);
                        sw.Close();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input \n userName must have 15 length and starts with (20) ends with (BN-0)", Console.ForegroundColor = ConsoleColor.Yellow);
                    Console.ResetColor();
                }
                Console.ReadLine();
            } while (userName.Length != 0);
            return dataList;
        }

        public static List<string> accountPassword()
        {
            List<string> dataList = new List<string>();
            string password;
            do
            {
                Console.WriteLine("Account Password: ");
                password = Console.ReadLine();

                if (password.Length == 6)
                {
                    dataList.Add($"\n{password}");
                    Console.WriteLine("\nYour pincode was accepted.\n", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                    using (StreamWriter sw = new StreamWriter(File.Create("C:\\Users\\ADMIN\\source\\repos\\ATM\\ClassLibrary1\\AccountPass.txt")))
                    {
                        sw.WriteLine(password);
                        sw.Close();
                    }
                    CreateUser.UserLogin();
                    break;
                }
                else
                {
                    Console.WriteLine("The password must be a number and have at least 6 digit pincode.", Console.ForegroundColor = ConsoleColor.Yellow);
                    Console.ResetColor();
                }
                Console.ReadLine();
            } while (password.Length != 0);
            return dataList;
        }
        public static void UserLogin()
        {
            string YesNo;
            {
                do
                {
                    Console.WriteLine("Do you want to login your account?");
                    Console.WriteLine("Yes or No?");
                    YesNo = Console.ReadLine().ToUpper().Trim();

                    if (YesNo != "YES" && YesNo != "NO")
                    {
                        Console.WriteLine($"Your choice {YesNo} is invalid! Please try again.", Console.ForegroundColor = ConsoleColor.Red);
                        Console.ResetColor();
                        CreateUser.accountName();
                    }
                    else if (YesNo.ToUpper() == "YES")
                    {
                        LoginForm.UserLogin();
                    }
                    while (YesNo != "YES" && YesNo != "NO") ;
                }
                while (YesNo.ToUpper() != "NO");
                Console.WriteLine("Exiting the system... Don't worry your account was successfully saved. :)", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.ResetColor();
                System.Environment.Exit(0);
            }
        }
    }
}
