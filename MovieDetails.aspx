<%@ Page Title="Movie Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
         CodeBehind="MovieDetails.aspx.cs" Inherits="Music_Store.MovieDetails" %>
 <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="moviedetail" runat="server" ItemType="Music_Store.Models.Movie" SelectMethod ="GetMovies" RenderOuterTable="false">
         <ItemTemplate>
            <div>
                <h3><%#:Item.Title %></h3>
            </div>
            <br />
            <div class="row">
                <div class="col-sm-4">
                      <img src="<%#:Item.ImgUrl %>" class="img-thumbnail" alt="<%#:Item.Title %>"/>
                </div>
                <div class="col-sm-4">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Movie Number:</b>&nbsp;<%#:Item.MovieID %></span>
                    <br />
                    <br />
                        <a href="MovieList.aspx">Back to products</a>
                 
                    <a href="/AddToCart.aspx?movieId=<%#:Item.MovieID %>">               
                          <span class="movielistitems">
                             <b>Add To Cart<b>
                          </span>           
                        </a>
                </div>
            </div>

        </ItemTemplate>
    </asp:FormView>
</asp:Content>
