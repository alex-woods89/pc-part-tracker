using System;
namespace PCPartTracker.Models
{
    public class PSU : IComponent
    {

        public string Name { get; set; }

        public int Watts { get; set; }

        public PSU(string name, int watts)
        {
            Name = name;
            Watts = watts;
        }

        
    }
}
