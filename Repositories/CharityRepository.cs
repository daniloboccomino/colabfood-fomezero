using System;
using System.Collections.Generic;
using System.Linq;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Persistence;

namespace globalsolution.fomezero.Repositories
{
    public class CharityRepository : ICharityRepository
    {
        private ColabfoodContext _context;

        public CharityRepository(ColabfoodContext context)
        {
            _context = context;
        }

        public void Create(Charity charity)
        {
            _context.Charities.Add(charity);
        }

        public List<Charity> List()
        {
            return _context.Charities.ToList();
        }

        public void Update(Charity charity)
        {
            _context.Charities.Update(charity);
        }

        public void Delete(int id)
        {
            _context.Charities.Remove(_context.Charities.Find(id));
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Charity FindById(int id)
        {
            return _context.Charities.Where(a => a.CharityId == id).FirstOrDefault();
        }
    }
}
