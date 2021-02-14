using System;
namespace PCPartTracker.Models
{
    public class Harddrive : IComponent
    {

        public string Name { get; set; }

        public string Size { get; set; }

        public Harddrive(string name, string size)
        {
            Name = name;
            Size = size;
        }

    }
}
