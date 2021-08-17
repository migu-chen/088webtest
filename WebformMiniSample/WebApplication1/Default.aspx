<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>
<%@ Register Src="~/ucControlImage.ascx" TagPrefix="uc1" TagName="ucControlImage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" 
    ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <uc1:ucControlImage runat="server" id="ucControl1" 
         Mytitle ="測試 uc 1"  BackColor="Green"  />
    <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
    <uc1:ucControlImage runat="server" id="ucControl2" />
    <uc1:WebUserControl1 runat="server" ID="WebUserControl2" />
      <uc1:ucControlImage runat="server" id="ucControl3" />
    <uc1:WebUserControl1 runat="server" ID="WebUserControl3" />
  
</asp:Content>
