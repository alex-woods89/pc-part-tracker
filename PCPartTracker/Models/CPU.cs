using System;
namespace PCPartTracker.Models
{
    public class CPU : IComponent
    {
        public string Name { get; set; }

        public int Cores { get; set; }

        public string ClockSpeed { get; set; }

        public CPU(string name, int cores, string clockSpeed)
        {
            Name = name;
            Cores = cores;
            ClockSpeed = clockSpeed;
        }
    }
}
