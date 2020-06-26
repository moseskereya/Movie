using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Music_Store.Models
{
    public class Genre
    {
        [ScaffoldColumn(false)]
        public int GenreID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string GenreName { get; set; }

        [Display(Name = "Genre Description type")]
        public string Description { get; set; }

        public virtual ICollection<Genre> Products { get; set; }
    }
}