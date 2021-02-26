using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface IGPURepository
    {
        DbSet<GPU> getGPUS();
        GPU findGPU(int id);
    }
}
