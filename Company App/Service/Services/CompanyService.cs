using Domain.Models;
using Repository.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class CompanyService : ICompanyService
    {
        private CompanyRepository _companyRepository;
        private int count { get; set; }
        public CompanyService()
        {
            _companyRepository = new CompanyRepository();
        }
        public Company Create(Company model)
        {
            model.Id = count;
            _companyRepository.Create(model);
            count++;
            return model;
        }
        public Company GetById(int id)
        {
            return _companyRepository.Get(x => x.Id == id);
        }
        public Company Update(Company model, int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(Company company)
        {
            
            _companyRepository.Delete(company);
        }
        public List<Company> GetByName(string name)
        {
            return _companyRepository.GetAll(x => x.Name == name);
        }
        public List<Company> GetAllByName(string name)
        {
            return _companyRepository.GetAll(x => x.Name == name);
        }
        public List<Company> GetAll()
        {
            return _companyRepository.GetAll();
                
        }

    }
}
