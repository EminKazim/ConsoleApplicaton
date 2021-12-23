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
        public CompanyService _companyService;
        public CompanyController()
        {
            _companyService = new CompanyService();
        }
        public void Create()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add Company Name  :");
            string companyName = Console.ReadLine();
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add Company Adress: ");
            string adress = Console.ReadLine();
            Company company = new Company
            {
                Name = companyName,
                Adress = adress
            };
            var result = _companyService.Create(company);
            if (result != null)
            {
                Helper.WriteToConsole(ConsoleColor.Cyan, $"{ company.Id} - { company.Name} - { company.Adress} company created");
            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Something is wrong");
                return;
            }

        }
        public void GetById()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id : ");
            string companyId = Console.ReadLine();
            int id;
            bool isIdTure = int.TryParse(companyId, out id);
            if (isIdTure)
            {
                var company1 = _companyService.GetById(id);
                if (company1 == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Compay not found");
                    return;

                }
                else
                {
                    Helper.WriteToConsole(ConsoleColor.Green, $"{company1.Id} - {company1.Name} - {company1.Adress}");
                }
            }
        }
        public void Delete()
        {
            Helper.WriteToConsole(ConsoleColor.Cyan, "Add company id : ");
        EnterId: string companyId = Console.ReadLine();
            int id;
            bool isIdTrue = int.TryParse(companyId, out id);
            if (isIdTrue)
            {
                var company = _companyService.GetById(id);
                if(company == null)
                {
                    Helper.WriteToConsole(ConsoleColor.Red, "Company not found:");
                    return;
                }
                else
                {
                    _companyService.Delete(company);
                    Helper.WriteToConsole(ConsoleColor.DarkCyan, $"Company succesfully deleted");
                }
            }
            else
            {
                Helper.WriteToConsole(ConsoleColor.Red, "Try again for new ID:");
                goto EnterId;
            }
        }
        public void GetAll()
        {
            var companies = _companyService.GetAll();
            foreach (var item in companies)
            {
                Helper.WriteToConsole(ConsoleColor.Cyan, $"{item.Id} - {item.Name} - {item.Adress}");

            }
        }
    }
}
 