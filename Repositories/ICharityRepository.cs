using System;
using System.Collections.Generic;
using globalsolution.fomezero.Models;

namespace globalsolution.fomezero.Repositories
{
    public interface ICharityRepository
    {
        void Create(Charity advertising);
        List<Charity> List();
        void Update(Charity advertising);
        void Delete(int id);
        void Save();
    }
}
