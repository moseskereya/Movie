using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Music_Store.Models
{
    public class Movie
    {
        [ScaffoldColumn(false)]
        public int MovieID { get; set; }
        [Required, StringLength(100), Display(Name = "Title")]
        public string Title { get; set; }
        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Rating { get; set; }
        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }
        public int? GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}