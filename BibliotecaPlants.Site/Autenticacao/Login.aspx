<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BibliotecaPlants.Site.Autenticacao.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PLANTS</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fuid" style="background-color: aliceblue; height: 500px">
            Login
         <div class="container-fluid" style="background-color: lightgreen; height: max-content; align-items: flex-start">
             <div class="container-fluid">
                 Usuário
                 <asp:TextBox ID="txtUsuario" runat="server" BackColor="#F0F0F0" BorderColor="#99FF99" Width="169px" Border-Radius="15"></asp:TextBox>
             </div>
             <div class="container-fluid">
                 Senha
                 <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" Width="169px" BackColor="#F0F0F0" BorderColor="#99FF66" Style="margin-left: 10px"></asp:TextBox>
             </div>
             <div style="border-radius: 10px">
                 <asp:Button ID="btnEntrar" Text="Entrar" runat="server" BackColor="#00FF99" OnClick="btnEntrar_Click1" BorderStyle="Solid"></asp:Button>
             </div>
             <div>
                 <asp:Label runat="server" ID="txtstatus"></asp:Label>

             </div>
         </div>
        </div>
    </form>
</body>
</html>
