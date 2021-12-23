using Domain.Models;
using Repository.Data;
using Repository.Exceptions;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementations
{
    public class CompanyRepository : IRepository<Company>
    {
        public bool Create(Company entitiy)
        {
            try
            {
                if (entitiy == null) throw new CustomExceptions("Entitiy is null");

                AppDbContext<Company>.datas.Add(entitiy);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(Company entitiy)
        {
            throw new NotImplementedException();
        }

        public Company Get(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll(Predicate<Company> filter)
        {
            throw new NotImplementedException();
        }

        public bool Update(Company entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
