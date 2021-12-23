using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IRepository<T>  where T : BaseEntitiy
    {
        bool Create(T entitiy);
        bool Update(T entitiy);
        bool Delete(T entitiy);
        T Get(Predicate<T> filter);
        List<T> GetAll(Predicate<T> filter);
    }
}
