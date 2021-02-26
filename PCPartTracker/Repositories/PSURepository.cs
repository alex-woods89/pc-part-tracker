using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class PSURepository : IPSURepository
    {

        private Context _context;

        public PSURepository(Context context)
        {
            _context = context;
        }

        public PSU findPSU(int id)
        {
            return _context.PSUs.FirstOrDefault(x => x.PCID == id);
        }

        public DbSet<PSU> getPSUs()
        {
            return _context.PSUs;
        }
    }
}
