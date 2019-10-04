using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicDuelers.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string User_id { get; set; }
        public string Type_id { get; set; }
    }
}
