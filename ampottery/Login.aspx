<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ampottery.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Esta pagina es la de logeo</h3>
        <p>Se van a poder logear tanto compradores como estudiantes</p>
      <div class="col-md-6">
        <div class="mb-3">
            <label class="form-label">Usuario</label>
            <asp:TextBox runat="server" id="txtUsuario" placeholder="Usuario" CssClass="form-control" />
        </div>
        <div class="mb-3">
            <label class="form-label">Contraseña</label>
            <asp:TextBox runat="server" id="txtPass" placeholder="Contraseña" CssClass="form-control" />
        </div>
        <div class="mb-3">
        <asp:Button text="Ingresar" Id="btnIngrear" Onclick="btnIngresar_Click" runat="server" />
        </div>
      </div>
    </main>
</asp:Content>