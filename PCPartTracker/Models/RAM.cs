using System;
using System.ComponentModel.DataAnnotations;

namespace PCPartTracker.Models
{
    public class RAM : IComponent
    {
        [Key]
        public int PCID { get; set; }
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
