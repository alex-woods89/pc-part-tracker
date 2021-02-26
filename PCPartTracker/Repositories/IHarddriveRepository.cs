using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface IHarddriveRepository
    {
        DbSet<Harddrive> getHarddrives();
        Harddrive findHarddrive(int id);
    }
}
