using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface ICPURepository
    {
        DbSet<CPU> getCPUs();

        CPU findCPU(int id);
    }
}
