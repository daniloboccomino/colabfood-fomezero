using System;
using System.Collections.Generic;
using globalsolution.fomezero.Models;

namespace globalsolution.fomezero.Repositories
{
    public interface IProviderRepository
    {
        void Create(Provider advertising);
        List<Provider> List();
        void Update(Provider advertising);
        void Delete(int id);
        void Save();
    }
}
