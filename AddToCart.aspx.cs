using Music_Store.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Music_Store
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["MovieID"];
            int movieId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out movieId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a movieId.");
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a movieId.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}