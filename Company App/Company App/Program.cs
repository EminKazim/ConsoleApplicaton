using Company_App.Controls;
using Domain.Models;
using Service.Helpers;
using Service.Services;
using Service.Services.Interfaces;
using System;

namespace Company_App
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyController companyController = new CompanyController();

            Helper.WriteToConsole(ConsoleColor.DarkCyan, "Select options");
            while (true)
            {
                GetMenus();
            EnterOption: string selectOption = Console.ReadLine();
                int option;
                bool isTrueOption = int.TryParse(selectOption, out option);
                if (isTrueOption)
                {
                    switch (option)
                    {
                        case (int)MyEnum.Options.CreateCompany:
                            companyController.Create();
                            break;
                        case (int)MyEnum.Options.UpdateCompany:
                            companyController.Update();
                            break;
                        case (int)MyEnum.Options.DeleteCompany:
                            companyController.Delete();
                            break;
                        case (int)MyEnum.Options.GetCompanyById:
                            companyController.GetById();
                            break;
                        case (int)MyEnum.Options.GetAllCompanyByName:
                            companyController.GetByName();
                            break;
                        case (int)MyEnum.Options.GetAllCompany:
                            companyController.GetAll();                         
                            break;
                        case (int)MyEnum.Options.CreateEmployee:
                            break;
                        case (int)MyEnum.Options.UpdateEmployee:
                            break;
                        case (int)MyEnum.Options.DeleteEmployee:
                            break;
                        case (int)MyEnum.Options.GetEmployeeById:
                            break;
                        case (int)MyEnum.Options.GetEmployeeByAge:
                            break;
                        case (int)MyEnum.Options.GetAllEmployeeByCompanyId:
                            break;
                    }

                }
                else
                {
                    goto EnterOption;
                }
                 static void GetMenus()
                {

                    Helper.WriteToConsole(ConsoleColor.Cyan, "1 - Create Company , 2 - Update Company   , 3 - Delete Company   , 4 - Get Company   by id," +
                   " 5 - Get all Company  by name,6 - Get all Company   , 7 - Create Employee  8 - Update Employee   , 9 - Get Employee   by id," +
                   " 10 - Delete Employee,11 - Get Employee   by age, 12 - Get all Employee  by Company  id ");
                }

            }

        }
    }
}
