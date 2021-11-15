using System;
using System.Collections.Generic;
using globalsolution.fomezero.Models;

namespace globalsolution.fomezero.Repositories
{
    public interface IDonationRepository
    {
        void Create(Donation advertising);
        List<Donation> List();
        void Update(Donation advertising);
        void Delete(int id);
        void Save();
    }
}
