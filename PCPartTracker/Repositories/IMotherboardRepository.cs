using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface IMotherboardRepository
    {
        DbSet<Motherboard> getMotherboards();
        Motherboard findMotherboard(int id);
    }
}
