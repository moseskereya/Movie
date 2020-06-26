<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Music_Store._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><%: Title %></h4>
    <h3>Movies of the Week</h3>
    <div class="row">
        <div class="col-md-4">
            <img src="https://image.tmdb.org/t/p/original/c3F4P2oauA7IQmy4hM0OmRt2W7d.jpg" class="img-thumbnail" alt="Alternate Text" />
            <h3>Gemini Man</h3>
             <p>Date</p>
            <b>13/3/2020</b>
        </div>
        <div class="col-md-4">
          <img src="https://image.tmdb.org/t/p/original/t8m4Z8Wo9MdhuvpoRCTVZgV3KDF.jpg" class="img-thumbnail" alt="Alternate Text" />
            <h3>The Equlizer</h3>
             <p>Date</p>
            <b>12/3/2020</b>
        </div>
        <div class="col-md-4">
            <img src="http://jimoncars.files.wordpress.com/2013/05/fast-and-furious-6.jpg" class="img-thumbnail" alt="Alternate Text" />
            <h3>Fast Furious 7</h3>
            <p>Date</p>
            <b>12/3/2020</b>
        </div>
    </div>
    
    <h4>This App help you to get the perfect Movie of your choice</h4>
    <p>We all love Movies. You can one of our Movie_Store lists. Each of the listing has a detailed information to help you to choose the right Movie</p>
</asp:Content>
