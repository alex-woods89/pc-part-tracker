using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class HardriveRepository : IHarddriveRepository
    {
        private Context _context;

        public HardriveRepository(Context context)
        {
            _context = context;
        }

        public Harddrive findHarddrive(int id)
        {
            return _context.Harddrives.FirstOrDefault(x => x.PCID == id);
        }

        public DbSet<Harddrive> getHarddrives()
        {
            return _context.Harddrives;
        }
    }
}
