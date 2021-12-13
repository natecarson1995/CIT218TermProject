using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class ShortStoryReaction
    {
        [Required, Key, Column("ID")]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string ShortStoryID { get; set; }
        public ShortStory ShortStory { get; set; }
        [Required]
        public Reaction Reaction { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
