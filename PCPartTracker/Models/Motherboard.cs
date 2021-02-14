using System;
namespace PCPartTracker.Models
{
    public class Motherboard : IComponent
    {
        public string Name { get; set; }

        public FormFactor FormFactor { get; set; }

        public Motherboard(string name, FormFactor formFactor)
        {
            Name = name;
            FormFactor = formFactor;
        }

    }
}
