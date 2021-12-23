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
            CompanyService companyService = new CompanyService();
           
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
                            Helper.WriteToConsole(ConsoleColor.Cyan, "Add Company Adress: ");
                            string adress = Console.ReadLine();
                            Company company = new Company
                           
                          
                            {
                                Name = companyName,
                                Adress = adress
                            };
                            var result = companyService.Create(company);
                            if (result != null)
                            {
                                Helper.WriteToConsole(ConsoleColor.Cyan, $"({ company.Id} - { company.Name} - { company.Adress} company created");
                            }
                            else
                            {
                                Helper.WriteToConsole(ConsoleColor.Red, "Something is wrong");
                                return;
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id : ");
                        EnterId: string companyId = Console.ReadLine();
                            int id;
                            bool isIdTure = int.TryParse(companyId, out id);
                            if (isIdTure)
                            {
                                var company1 = companyService.GetById(id);
                                if(company1 == null)
                                {
                                    Helper.WriteToConsole(ConsoleColor.Red, "Compay not found");
                                    return;

                                }
                                else
                                {
                                    Helper.WriteToConsole(ConsoleColor.Green, $"{company1.Id} - {company1.Name} - {company1.Adress}");
                                }
                            }
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
