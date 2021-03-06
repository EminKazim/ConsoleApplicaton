using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company_App.Controls
{
    public class CompanyController
    {
        private CompanyService _companyServise { get; }
        public CompanyController()
        {
            _companyServise = new CompanyService();
        }
        public void Create()
        {
        EnterOption:
            Helper.WriteToConsole(ConsoleColor.Blue, "Add Company Name: ");
            string companyName = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Blue, "Add Company Address: ");
            string address = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(address))
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try again");
                goto EnterOption;
            }
            else
            {
                Company company = new Company
                {
                    Name = companyName,
                    Adress = address,
                };
                var createResult = _companyServise.Create(company);

                if (createResult != null)
                {
                    Helper.WriteToConsole(ConsoleColor.Green, $"{company.Id} - {company.Name} company in {company.Adress} created");
                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Something get wrong");
                    goto EnterOption;
                }
            }
        }

        public void GetById()
        {
            Helper.WriteToConsole(ConsoleColor.Blue, "Add Company Id: ");
        EnterId:
            string companyId = Console.ReadLine();

            int id;

            bool isIdTrue = int.TryParse(companyId, out id);

            if (isIdTrue)
            {
                var company = _companyServise.GetById(id);

                if (company == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found, try id again");
                    goto EnterId;
                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Green, $"{company.Id} - {company.Name} - {company.Adress}");
                }
            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try id again");
                goto EnterId;
            }
        }

        public void Delete()
        {
            Helper.WriteToConsole(ConsoleColor.Blue, "Add Company Id: ");
        EnterId:
            string companyId = Console.ReadLine();

            int id;

            bool isIdTrue = int.TryParse(companyId, out id);

            if (isIdTrue)
            {
                var company = _companyServise.GetById(id);

                if (company == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found, try id again");
                    goto EnterId;
                }
                else
                {
                    _companyServise.Delete(company);
                    Helper.WriteToConsole(ConsoleColor.Green, "Company is deleted");
                }
            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try id again");
                goto EnterId;
            }

        }

        public void GetAll()
        {
            var companies = _companyServise.GetAll();

            foreach (var item in companies)
            {
                Helper.WriteToConsole(ConsoleColor.Green, $"{item.Id} - {item.Name} - {item.Adress}");
            }
        }

        public void GetByName()
        {
            Helper.WriteToConsole(ConsoleColor.Blue, "Add Company Name: ");
        EnterCompanyName:
            string companyName = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(companyName))
            {

                Helper.WriteToConsole(ConsoleColor.Red, "Try Company Name again");
                goto EnterCompanyName;
            }
            else
            {
                var companyNames = _companyServise.GetAll();
                foreach (var item in companyNames)
                {
                    if (item.Name != companyName)
                    {
                        Helper.WriteToConsole(ConsoleColor.Red, "Company not found try again");
                        goto EnterCompanyName;

                    }
                    else
                    {
                        Helper.WriteToConsole(ConsoleColor.Green, $"{item.Id} - {item.Name} - {item.Adress}");
                    }
                }
            }


        }

        public void Update()
        {
            Helper.WriteToConsole(ConsoleColor.Blue, "Add Company Id: ");
        EnterId:
            string companyId = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Blue, "Add new Company Name: ");
        EnterName:
            string newName = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Blue, "Add new Company Address: ");
            string newAddress = Console.ReadLine();
            int id;

            bool isIdTrue = int.TryParse(companyId, out id);


            if (isIdTrue)
            {
                if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newAddress))
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Try Name and Address again");
                    goto EnterName;
                }
                else
                {
                    Company company = new Company
                    {
                        Name = newName,
                        Adress = newAddress,
                    };
                    var newCompany = _companyServise.Update(id, company);

                    Helper.WriteToConsole(ConsoleColor.Green, $"{newCompany.Id} - {newCompany.Name} in {newCompany.Adress} updated");
                }


            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try id again");
                goto EnterId;
            }

        }
    }
}

 