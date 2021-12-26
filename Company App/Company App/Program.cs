﻿using Company_App.Controls;
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

                    Helper.WriteToConsole(ConsoleColor.Cyan, "1 - Create Company , 2 - Update Company   , 3 - Delete Company   , 4 - Get Company   by id," +
                   " 5 - Get all Company  by name,6 - Get all Company   , 7 - Create Employee  8 - Update Employee   , 9 - Get Employee   by id," +
                   " 10 - Delete Employee,11 - Get Employee   by age, 12 - Get all Employee  by Company  id , 13 - Exit programm");
                }

            }

        }
    }
}
