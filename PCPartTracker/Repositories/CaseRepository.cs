using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class CaseRepository : ICaseRepository
    {
        private Context _context;

        public CaseRepository(Context context)
        {
            _context = context;
        }

        public Case findCase(int id)
        {
            return _context.Cases.FirstOrDefault(x => x.ID == id);
        }

        public DbSet<Case> getCases()
        {
            return _context.Cases;
        }
    }
}
