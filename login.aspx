<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<html>
<head><title>Login</title></head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email"></asp:TextBox><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password"></asp:TextBox><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </form>
</body>
</html>
