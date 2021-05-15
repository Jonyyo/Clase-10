<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frninicio.aspx.cs" Inherits="crubp1a.frninicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:Button ID="ButtonCargaDatos" runat="server" style="margin-bottom: 3px" Text="Cargar Datos a DB" OnClick="ButtonCargaDatos_Click" />
        </p>
        <div>
            <asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonBuscarID" runat="server" OnClick="ButtonBuscarID_Click" Text="Buscar por ID" />
        </div>
        <p>
            <asp:TextBox ID="TextBoxNombre" runat="server" style="margin-top: 47px" Width="382px"></asp:TextBox>
            <asp:Button ID="ButtonBuscarPorNombre" runat="server" OnClick="ButtonBuscarPorNombre_Click" Text="Buscar Por Nombre" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
