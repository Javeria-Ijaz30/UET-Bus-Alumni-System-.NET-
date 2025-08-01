<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>
<html>
<head><title>Signup</title></head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtName" runat="server" Placeholder="Full Name"></asp:TextBox><br />
        <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email"></asp:TextBox><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password"></asp:TextBox><br />
        <asp:Button ID="btnSignup" runat="server" Text="Register" OnClick="btnSignup_Click" />
    </form>
</body>
</html>
