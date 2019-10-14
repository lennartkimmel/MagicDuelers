using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDLproject.Models
{
    public class Format
    {
        public int FormatID { get; set; }

        public string Label { get; set; }

      
        // This is a navigation property that holds other entities that are related to this entity
        public List<Deck> Decks { get; set; }

       // public int DeckId { get; set; }
       // public Deck Deck { get; set; }
    }
}
