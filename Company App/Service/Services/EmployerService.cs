using Domain.Models;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeRepository _employeeRepository { get; }
        private CompanyRepository _companyRepository { get; }
        private int count { get; set; }

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
            _companyRepository = new CompanyRepository();
        }

        public Employer Create(Employer model, int companyId)
        {
            try
            {
                Company company = _companyRepository.GetById(m => m.Id == companyId);
                if (company == null) return null;
                model.Id = count;
                count++;
                model.Company = company;
                _employeeRepository.Create(model);

                return model;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Delete(Employer employee)
        {
            _employeeRepository.Delete(employee);
        }

        public Employer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employer> GetByAge(int Age)
        {
            throw new NotImplementedException();
        }

        public List<Employer> GetAllByCompanyId(int companyId)
        {
            throw new NotImplementedException();
        }

        public Employer Update(int id, Employer model, Company company)
        {
            throw new NotImplementedException();
        }
    }
}
