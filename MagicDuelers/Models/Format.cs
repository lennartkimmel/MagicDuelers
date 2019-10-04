using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicDuelers.Models
{
    public class Format
    {
        public int Id { get; set; }
        public string Standard { get; set; }
        public string Modern { get; set; }
        public string Legacy { get; set; }
        public string Vintage { get; set; }
        public string Limited { get; set; }
        public string Commander { get; set; }
        public string Constructed { get; set; }
        public string SealedDeck { get; set; }
        public string Traditional { get; set; }
        public string Advanced { get; set; }

    }
}
