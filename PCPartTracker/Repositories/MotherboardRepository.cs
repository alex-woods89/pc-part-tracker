using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class MotherboardRepository : IMotherboardRepository
    {

        private Context _context;

        public MotherboardRepository(Context context)
        {
            _context = context;
        }

        public Motherboard findMotherboard(int id)
        {
            return _context.Motherboards.FirstOrDefault(x => x.PCID == id);
        }

        public DbSet<Motherboard> getMotherboards()
        {
            return _context.Motherboards;
        }
    }
}
