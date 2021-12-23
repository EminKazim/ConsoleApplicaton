using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;

namespace Company_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.WriteToConsole(ConsoleColor.DarkCyan, "Select options");
            while (true)
            {
                Helper.WriteToConsole(ConsoleColor.Cyan, "1 - Create Company , 2 - Update Company   , 3 - Delete Company   , 4 - Get Company   by id," +
               " 5 - Get all Company  by name,6 - Get all Company   , 7 - Create Employee  8 - Update Employee   , 9 - Get Employee   by id," +
               " 10 - Delete Employee,11 - Get Employee   by age, 12 - Get all Employee  by Company  id ");
               EnterOption: string selectOption = Console.ReadLine();
                int option;
                bool isTrueOption = int.TryParse(selectOption, out option);
                if (isTrueOption)
                {
                    switch (option)
                    {
                        case 1:
                            Helper.WriteToConsole(ConsoleColor.Cyan, "Add Company Name  :");
                            string companyName = Console.ReadLine();
                            Helper.WriteToConsole(ConsoleColor.Cyan, "Add Company Place  :");
                            string adress = Console.ReadLine();
                            int count;
                            //Company = new Company
                            //{
                            //    Name = companyName,
                            //    Adress = adress
                            //};
                            //var result = company;
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        case 10:
                            break;
                        case 11:
                            break;
                        case 12:
                            break;
                    }

                }
                else
                {
                    goto EnterOption;
                }

            }

        }
    }
}
