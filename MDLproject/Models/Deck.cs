using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MDLproject.Models
{
    public class Deck
    {
        public int DeckID { get; set; }
        public int FormatID { get; set; }
        public int UserID { get; set; }

        public Format Format { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Name cannot be longer than 30 characters.")]
        [Display(Name = "Deck name")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
