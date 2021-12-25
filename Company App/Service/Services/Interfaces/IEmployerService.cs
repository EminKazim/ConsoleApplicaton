using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    class IEmployerService
    {
    }
    public interface IEmployeeService
    {
        Employer Create(Employer model, int companyId);
        void Delete(Employer employee);
        Employer GetById(int id);
        List<Employer> GetByAge(int Age);
        List<Employer> GetAllByCompanyId(int companyId);
        Employer Update(int id, Employer model, Company company);

    }
}
