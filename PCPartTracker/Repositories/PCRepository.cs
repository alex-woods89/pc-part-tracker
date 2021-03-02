using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Data;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public class PCRepository : IPCRepositiory
    {
        private Context _context;

        public PCRepository(Context context)
        {
            _context = context;
        }
        public DbSet<PC> getPCs()
        {
            return _context.PCs;
        }

        public PC findPC(int id)
        {
            return _context.PCs.FirstOrDefault(x => x.ID == id);
        }

        public void savePC(PC pc)
        {
            _context.PCs.Add(pc);
            _context.SaveChanges();
        }

        public void deletePC(PC pc)
        {
            var local = _context.Set<PC>().Local.FirstOrDefault(entry => entry.ID.Equals(pc.ID));

            // check if local is not null 
            if (local != null)
            {
                // detach
                _context.Entry(local).State = EntityState.Detached;
            }

            _context.PCs.Remove(pc);
            _context.SaveChanges();
        }

        public void updatePC(PC newPC)
        {
            PC oldPC = _context.PCs.Find(newPC.ID);
            if (oldPC == null)
            {
                return;
            }

            _context.Entry(oldPC).CurrentValues.SetValues(newPC);
            _context.SaveChanges();
        }
    }
}
