using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class GPURepository : IGPURepository
    {

        private Context _context;

        public GPURepository(Context context)
        {
            _context = context;
        }

        public GPU findGPU(int id)
        {
            return _context.GPUs.FirstOrDefault(x => x.PCID == id);
        }

        public DbSet<GPU> getGPUS()
        {
            return _context.GPUs;
        }
    }
}
