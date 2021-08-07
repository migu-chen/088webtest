<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="AccountingNote.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        123<br />

        <asp:Label ID="aid" runat="server" Text="id"></asp:Label>

        <asp:TextBox ID="tid" runat="server"></asp:TextBox>
        <br />

        <p>

        <asp:Label ID="aaccount" runat="server" Text="account"></asp:Label>

        <asp:TextBox ID="taccount" runat="server"></asp:TextBox>
        </p>
        <p>

        <asp:Label ID="aPWD" runat="server" Text=" PWD"></asp:Label>

        <asp:TextBox ID="tPWD" runat="server"></asp:TextBox>
        </p>
        <p>

        <asp:Label ID="laname" runat="server" Text=" name"></asp:Label>

        <asp:TextBox ID="tname" runat="server"></asp:TextBox>
        </p>
        <p>

        <asp:Label ID="aEmail" runat="server" Text="Email"></asp:Label>&nbsp;&nbsp;

        <asp:TextBox ID="tEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
