using System;
using System.Collections.Generic;
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
    }
}
