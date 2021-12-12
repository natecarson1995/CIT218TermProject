﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class Comment
    {
        [Required, Key, Column("ID")]
        public string ID { get; set; }

        [Required]
        [StringLength(1024, ErrorMessage = "Must enter a comment less than 1024 characters.")]
        [RegularExpression("^[^<>/\\]{1,1025}$", ErrorMessage ="No slashes or angle brackets allowed")]
        public string Content { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage ="May not have a negative amount of likes")]
        public int Likes { get; set; }
        [Required, Range(0, int.MaxValue, ErrorMessage = "May not have a negative amount of dislikes")]
        public int Dislikes { get; set; }

        [Required]
        public string ShortStoryID { get; set; }
        public ShortStory ShortStory;

        [Required]
        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}