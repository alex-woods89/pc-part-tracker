using System;
namespace PCPartTracker.Models
{
    public class RAM : IComponent
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int NumberOfCards { get; set; }

        public RAM(string name, string size, int numberOfCards)
        {
            Name = name;
            Size = size;
            NumberOfCards = numberOfCards;
        }
    }
}
