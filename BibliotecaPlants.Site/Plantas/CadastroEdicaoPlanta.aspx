<%@ Page Title="" Language="C#" MasterPageFile="~/Plantas/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroEdicaoPlanta.aspx.cs" Inherits="BibliotecaPlants.Site.Plantas.CadastroEdicaoPlanta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-group">
        <label>Título</label>
        <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Valor Pago</label>
        <asp:TextBox runat="server" ID="ValorPago" TextMode="Number" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Data da Compra</label>
        <asp:TextBox runat="server" ID="DataCompra" TextMode="Date" CssClass="form-control"></asp:TextBox>
    </div>
    <br />

    <div class="form-group">
        <label>Imagem</label>
        <asp:FileUpload CssClass="form-control" ID="FileUpLoadImg" runat="server" />
        <br />
    </div>

    <div class="form-group">
        <label>Tipo</label>
        <asp:DropDownList ID="DdlTipo" runat="server" DataValueField="ID" DataTextField="Descricao" CssClass="form-control"></asp:DropDownList>
    </div>

    <div class="form-group">
        <label>Origem</label>
        <asp:DropDownList ID="DdlOrigem" runat="server" DataValueField="ID" DataTextField="Nome" CssClass="form-control"></asp:DropDownList>
        <br />
    </div>
    <br />
    <asp:Label runat="server" ID="lblMensagem"></asp:Label>
    <asp:Button ID="btnGravar" Text="Salvar" runat="server" CssClass="btn btn-primary" OnClick="btnGravar_Click" />

    <a href="Catalogo.aspx">Voltar ao Catálogo de Plantas</a>

</asp:Content>
