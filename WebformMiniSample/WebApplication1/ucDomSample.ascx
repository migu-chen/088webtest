<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="ucDomSample.ascx.cs" 
    Inherits="WebApplication1.ucDomSample" %>
<asp:PlaceHolder ID="PlaceHolder1" runat="server">
     <asp:Literal ID="Literal1" runat="server">Literal1</asp:Literal>
     <asp:PlaceHolder ID="PlaceHolder2" runat="server">
          <asp:Button ID="Button1" runat="server" Text="Button" />
          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         </asp:PlaceHolder>
    <asp:Image ID="Image1" runat="server" src="/Images/png.png "  Width ="100" Height ="70" />
</asp:PlaceHolder>
