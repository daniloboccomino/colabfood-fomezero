using System;
using System.Collections.Generic;
using System.Linq;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Persistence;

namespace globalsolution.fomezero.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        private ColabfoodContext _context;

        public ProviderRepository(ColabfoodContext context)
        {
            _context = context;
        }

        public void Create(Provider provider)
        {
            _context.Providers.Add(provider);
        }

        public List<Provider> List()
        {
            return _context.Providers.ToList();
        }

        public void Update(Provider provider)
        {
            _context.Providers.Update(provider);
        }

        public void Delete(int id)
        {
            _context.Providers.Remove(_context.Providers.Find(id));
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
