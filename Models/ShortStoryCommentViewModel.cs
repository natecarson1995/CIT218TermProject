using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class ShortStoryCommentViewModel
    {
        public string ShortStoryID { get; set; }
        public string StoryAuthor { get; set; }
        public string StoryTitle { get; set; }
        public string StoryContent { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ShortStoryReaction> Reactions { get; set; }
    }
}
