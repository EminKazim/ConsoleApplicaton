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
            try
            {
                AppDbContext<Company>.datas.Remove(entitiy);
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Company Get(Predicate<Company> filter = null)
        {
            return filter == null ? AppDbContext<Company>.datas[0] :  AppDbContext<Company>.datas.Find(filter); 
        }

        public List<Company> GetAll(Predicate<Company> filter = null)
        {
            return filter == null ? AppDbContext<Company>.datas : AppDbContext<Company>.datas.FindAll(filter);
        }

        public bool Update(Company entitiy)
        {
            throw new NotImplementedException();
        }

       
    }
}
