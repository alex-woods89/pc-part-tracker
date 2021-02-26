using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class RAMRepository : IRAMRepository
    {

        private Context _context;

        public RAMRepository(Context context)
        {
            _context = context;
        }

        public RAM findRam(int id)
        {
            return _context.RAMs.FirstOrDefault(x => x.PCID == id);
        }

        public DbSet<RAM> getRAMs()
        {
            return _context.RAMs;
        }
    }
}
