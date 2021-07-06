<%@ Page Title="" Language="C#" MasterPageFile="~/Plantas/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="BibliotecaPlants.Site.Plantas.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Content/plants/catalogo.css" rel="stylesheet" />
    <h2>Catalogo de Plantas</h2>
    <hr />
    <asp:Repeater ID="RepeaterPlantas" runat="server">
        <ItemTemplate>
            <div class="planta" onclick="redirecionarPaginaPlanta('<%= Session["Perfil"].ToString() %>', <%# DataBinder.Eval(Container.DataItem, "ID") %>)">
                <div class="capa-plant">
                    <!-- aqui para ser dinamico as fotos assim-->
                    <img src="../Content/imagensPlants/<%# DataBinder.Eval(Container.DataItem, "imagem" ) %>" alt="<%# DataBinder.Eval(Container.DataItem, "Titulo" ) %>" />
                </div>
                <div class="nome-plant">
                    <%# DataBinder.Eval(Container.DataItem, "Titulo" ) %>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <script>
        function redirecionarPaginaPlanta(Perfil, Id) {
            if (perfil === "A") {
                top.location.href = "CadastroEdicaoPlants.aspx?id=" + id;
            } else {
                top.location.href = "DetalhesPlants.aspx?id=" + id;
            }
        }
    </script>


</asp:Content>
