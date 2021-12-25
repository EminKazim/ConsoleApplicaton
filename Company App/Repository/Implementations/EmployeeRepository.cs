using Domain.Models;
using Repository.Data;
using Repository.Exceptions;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementations
{
    public class EmployeeRepository : IRepository<Employer>
    {
        public bool Create(Employer entity)
        {
            try
            {
                if (entity == null)
                    throw new CustomExceptions("Entity is null");

                AppDbContext<Employer>.datas.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Delete(Employer entity)
        {
            try
            {
                AppDbContext<Employer>.datas.Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Employer GetById(Predicate<Employer> filter)
        {
            throw new NotImplementedException();
        }
    }
}