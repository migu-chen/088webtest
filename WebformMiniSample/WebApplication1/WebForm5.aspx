<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication1.WebForm5" %>

<%@ Register Src="~/ucControlImage.ascx" TagPrefix="uc1" TagName="ucControlImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h1>第五頁</h1>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <uc1:ucControlImage runat="server" ID="ucControlImage" />
</asp:Content>
