<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ampottery.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:textbox runat="server" id="txtEmail" cssclass="form-control" placeholder="Email" />
            </div>
            <div class="mb-3">
                <label class="form-label">Asunto</label>
                <asp:textbox runat="server" id="txtAsunto" cssclass="form-control" placeholder="Asunto" />
            </div>
            <div class="mb-3">
                <label class="form-label">Mensaje</label>
                <asp:textbox runat="server" id="txtMensaje" cssclass="form-control" placeholder="Mensaje" TextMode="MultiLine" />
            </div>
            <asp:Button runat="server" id="btnEnviar" cssclass="btn btn-primary" Text="Enviar" OnClick="btnEnviar_Click" />
        </div>
        <div class="col"></div>
    </div>

</asp:Content>
