﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class ShortStoryIndexViewModel
    {
        public string SearchQuery { get; set; }
        public List<ShortStory> Stories { get; set; }
    }
}
