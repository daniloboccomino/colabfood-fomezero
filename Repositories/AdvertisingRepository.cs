using System;
using System.Collections.Generic;
using System.Linq;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Persistence;

namespace globalsolution.fomezero.Repositories
{
    public class AdvertisingRepository : IAdvertisingRepository
    {
        private ColabfoodContext _context;

        public AdvertisingRepository(ColabfoodContext context)
        {
            _context = context;
        }

        public void Create(Advertising advertising)
        {
            _context.Advertisings.Add(advertising);
        }

        public List<Advertising> List()
        {
            return _context.Advertisings.ToList();
        }

        public void Update(Advertising advertising)
        {
            _context.Advertisings.Update(advertising);
        }

        public void Delete(int id)
        {
            _context.Advertisings.Remove(_context.Advertisings.Find(id));
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
