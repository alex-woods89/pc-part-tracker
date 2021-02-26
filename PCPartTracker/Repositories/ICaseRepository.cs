using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface ICaseRepository
    {
        DbSet<Case> getCases();
        Case findCase(int id);
    }
}
