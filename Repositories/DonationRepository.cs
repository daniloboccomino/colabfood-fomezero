using System;
using System.Collections.Generic;
using System.Linq;
using globalsolution.fomezero.Models;
using globalsolution.fomezero.Persistence;

namespace globalsolution.fomezero.Repositories
{
    public class DonationRepository : IDonationRepository
    {
        private ColabfoodContext _context;

        public DonationRepository(ColabfoodContext context)
        {
            _context = context;
        }

        public void Create(Donation donation)
        {
            _context.Donations.Add(donation);
        }

        public List<Donation> List()
        {
            return _context.Donations.ToList();
        }

        public void Update(Donation donation)
        {
            _context.Donations.Update(donation);
        }

        public void Delete(int id)
        {
            _context.Donations.Remove(_context.Donations.Find(id));
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
