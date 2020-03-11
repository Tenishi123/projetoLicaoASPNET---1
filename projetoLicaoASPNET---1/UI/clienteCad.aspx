<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clienteCad.aspx.cs" Inherits="projetoLicaoASPNET___1.UI.clienteCad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Cadastro de Cliente</h1>
            <hr />
            Nome:
            <br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            Cpf:
            <br />
            <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox>
            <br />
            E-mail:
            <br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Endereço:
            <br />
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            <br />
             <asp:Button ID="btnCasdatrar" runat="server" Text="Cadastrar" OnClick="btnCasdatrar_Click" Width="95px" />

        </div>
    </form>
</body>
</html>
