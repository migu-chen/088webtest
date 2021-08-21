<%@ Control Language="C#" AutoEventWireup="true"
    CodeBehind="ucControlImage.ascx.cs" 
    Inherits="WebApplication1.ucControl2" %>
<div runat="server" id= "divMain" styple="background-color:darkkhaki">
  <img runat="server" ID="imgCover" src="/Images/png.png " width ="50" height= "40"/>

 <%-- &nbsp;<div style ="background-color : aquamarine ">--%>
  <span>
    <asp:Literal ID="ItItitle" runat="server"></asp:Literal>
    
  </span>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick ="Button1_Click" />

</div>
