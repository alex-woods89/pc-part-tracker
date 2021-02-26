using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface IPSURepository
    {
        DbSet<PSU> getPSUs();
        PSU findPSU(int id);
    }
}
