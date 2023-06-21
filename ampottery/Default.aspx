<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ampottery._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">AM Pottery</h1>
            <p class="lead">Aca podría ir un slider con fotos o fondo foto y una frae de slogan</p>
            <p><a href="" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">A ver contenido o que iría acá</h2>
                <p>
                    Un catalogo de productos destacados/nuevos o proximos eventos / promociones / Noticias / mostrar fotos de clases
                </p>
                <p>
                    <a runat="server" class="btn btn-default"  href="~/About">>Botón para esa noticia/evento</a>
                </p>
            </section>
            
        </div>
    </main>

</asp:Content>
