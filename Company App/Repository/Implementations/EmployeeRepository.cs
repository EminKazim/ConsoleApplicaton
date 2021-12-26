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
            return filter == null ? AppDbContext<Employer>.datas[0] : AppDbContext<Employer>.datas.Find(filter);
        }

        public List<Employer> GetByAge(Predicate<Employer> filter)
        {
            return filter == null ? AppDbContext<Employer>.datas : AppDbContext<Employer>.datas.FindAll(filter);
        }

        public List<Employer> GetAllByCompanyId(Predicate<Employer> filter)
        {
            return filter == null ? AppDbContext<Employer>.datas : AppDbContext<Employer>.datas.FindAll(filter);
        }

        public bool Update(Employer entity, Company company)
        {
            try
            {
                var employee = GetById(m => m.Id == entity.Id);

                if (employee != null)
                {
                    if (!string.IsNullOrEmpty(entity.Name))
                        employee.Name = entity.Name;

                    if (!string.IsNullOrEmpty(entity.Surname))
                        employee.Surname = entity.Surname;
                    employee.Company = company;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
    }
}