using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Music_Store.Models;

namespace Music_Store
{
    public partial class MovieList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Movie> GetMovies([QueryString("id")] int? genreId)
        {
            var _db = new Music_Store.Models.MovieContext();
            IQueryable<Movie> query = _db.Movies;
            if (genreId.HasValue && genreId > 0)
            {
                query = query.Where(p => p.GenreID == genreId);
            }
            return query;
        }
    }
}