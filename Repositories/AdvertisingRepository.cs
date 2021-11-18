using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Persistence;
using Microsoft.EntityFrameworkCore;

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
            return _context.Advertisings.Include(a => a.Provider).ToList();
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

        public Advertising FindById(int id)
        {
            return _context.Advertisings.Include(a => a.Provider).Where(a => a.AdvertisingId == id).FirstOrDefault();
        }

        public List<Advertising> SearchBy(Expression<Func<Advertising, bool>> filtro)
        {
            return _context.Advertisings.Include(a => a.Provider).Where(filtro).ToList();
        }
    }
}
