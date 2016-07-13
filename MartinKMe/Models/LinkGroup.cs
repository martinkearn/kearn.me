﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MartinKMe.Models
{
    public class LinkGroup
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string CssClass { get; set; }

        public bool VisibleOnSite { get; set; }

        public virtual ICollection<Link> Links { get; set; }
    }
}