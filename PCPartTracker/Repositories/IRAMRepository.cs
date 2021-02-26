using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface IRAMRepository
    {
        DbSet<RAM> getRAMs();
        RAM findRam(int id);
    }
}
