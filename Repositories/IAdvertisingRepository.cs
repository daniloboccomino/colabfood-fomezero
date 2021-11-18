using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using globalsolution.fomezero.Models;

namespace globalsolution.fomezero.Repositories
{
    public interface IAdvertisingRepository
    {
        void Create(Advertising advertising);
        List<Advertising> List();
        void Update(Advertising advertising);
        void Delete(int id);
        void Save();
        Advertising FindById(int id);
        List<Advertising> SearchBy(Expression<Func<Advertising, bool>> filtro);
    }
}
