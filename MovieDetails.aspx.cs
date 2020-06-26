using Music_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Music_Store
{
    public partial class MovieDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Movie> GetMovies([QueryString("movieId")] int? movieId)
        {
            var _db = new Music_Store.Models.MovieContext();
            IQueryable<Movie> query = _db.Movies;
            if (movieId.HasValue && movieId > 0)
            {
                query = query.Where(p => p.MovieID == movieId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}