using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class ShortStory
    {
        [Required, Key, Column("ID")]
        public string ID { get; set; } = Guid.NewGuid().ToString();

        [StringLength(24, ErrorMessage = "Must enter a title less than 24 characters.")]
        [RegularExpression("^[^<>\\\\/]{1,1025}$", ErrorMessage = "No slashes or angle brackets allowed")]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [StringLength(1024, ErrorMessage = "Must enter a story less than 1024 characters.")]
        [RegularExpression("^[^<>\\\\/]{1,1025}$", ErrorMessage = "No slashes or angle brackets allowed")]
        public string Content { get; set; }
        [NotMapped]
        public int Likes {
            get {
                return Reactions.Where(reaction=>reaction.Reaction==Reaction.Like).Count();
            }
        }
        [NotMapped]
        public int Dislikes
        {
            get
            {
                return Reactions.Where(reaction => reaction.Reaction == Reaction.Dislike).Count();
            }
        }
        [NotMapped]
        public int Score { 
            get {
                return Likes - Dislikes;
            }
        }
        public List<ShortStoryReaction> Reactions { get; set; } = new List<ShortStoryReaction>();

        public List<Comment> Comments { get; set; }

        [Required]
        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
