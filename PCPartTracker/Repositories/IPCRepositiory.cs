using System;
using Microsoft.EntityFrameworkCore;
using PCPartTracker.Models;

namespace PCPartTracker.Repositories
{
    public interface IPCRepositiory
    {
        DbSet<PC> getPCs();

        void deletePC(PC pc);

        void savePC(PC pc);

        void updatePC(PC newPC);

        PC findPC(int id);

    }
}
