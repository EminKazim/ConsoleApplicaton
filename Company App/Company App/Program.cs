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
            EmployeeController employeeController = new EmployeeController();

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
                            employeeController.Create();
                            break;
                        case (int)MyEnum.Options.UpdateEmployee:
                            employeeController.Update();
                            
                            break;
                        case (int)MyEnum.Options.DeleteEmployee:
                            employeeController.Delete();
                            break;
                        case (int)MyEnum.Options.GetEmployeeById:
                            employeeController.GetById();
                            break;
                        case (int)MyEnum.Options.GetEmployeeByAge:
                            employeeController.GetByAge();
                            break;
                        case (int)MyEnum.Options.GetAllEmployeeByCompanyId:
                            employeeController.GetAllByCompanyId();
                            break;
                        case (int)MyEnum.Options.ExitProgramm:
                            goto Exit;
                    }
                Exit:
                    Helper.WriteToConsole(ConsoleColor.Green, "Programm is exit");
                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Check correct option");
                    goto EnterOption;
                }
                static void GetMenus()
                {

                    Helper.WriteToConsole(ConsoleColor.Gray, "Please Select option");
                    Helper.WriteToConsole(ConsoleColor.Blue, "1 - Creat Company       4 - Get Company By Id        7 - Creat Employee         10 - Delete Employee");
                    Helper.WriteToConsole(ConsoleColor.Blue, "2 - Update Company      5- Get Company by Name       8 - UpdateEmployee         11 - Get Employee By Age");
                    Helper.WriteToConsole(ConsoleColor.Blue, "3 - Delete Company      6 - Get All Company          9 - Get Employee By Id     12 - Get All Employee By Company Id");
                    Helper.WriteToConsole(ConsoleColor.Blue, "13 - Exit programm");
                    Helper.WriteToConsole(ConsoleColor.Green, "======================================================================================================================"); 
                }

            }

        }
    }
}
