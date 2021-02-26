using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class CPURepository : ICPURepository
    {
        private Context _context;

        public CPURepository(Context context)
        {
            _context = context;
        }

        public DbSet<CPU> getCPUs()
        {
            return _context.CPUs;
        }

        public CPU findCPU(int id)
        {
            return _context.CPUs.FirstOrDefault(x => x.PCID == id);
        }
    }
}
