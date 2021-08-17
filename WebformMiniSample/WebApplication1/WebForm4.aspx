<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication1.WebForm4" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>
<%@ Register Src="~/ucControlImage.ascx" TagPrefix="uc1" TagName="ucControlImage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h1>第1234四頁</h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>第四頁</h1>
    <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
    <uc1:ucControlImage runat="server" ID="ucControlImage" />
</asp:Content>
