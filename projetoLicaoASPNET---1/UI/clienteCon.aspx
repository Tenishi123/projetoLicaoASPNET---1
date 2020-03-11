<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="clienteCon.aspx.cs" Inherits="projetoLicaoASPNET___1.UI.clienteCon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <h1>Consulta de Cliente</h1>
            </center><hr />
            <br />
            <asp:TextBox ID="txtFiltro" runat="server" Width="400"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
            <br />
            <br />
            <asp:GridView ID="gvResultado" runat="server" OnRowCommand="gvResultado_RowCommand">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnExcluir" runat="server" CausesValidation="false" CommandArgument='<% #Eval("CODCATEGORIA") %>' CommandName="cmdExcluir" Text="Excluir" OnClientClick="return alert('Deseja realmente excluir ?')" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
