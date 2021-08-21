<%@ Page Title="" Language="C#" MasterPageFile="~/SystemAdmin/Admin.Master"
    AutoEventWireup="true" CodeBehind="Userlist.aspx.cs"
    Inherits="AccountingNote.SystemAdmin.Userlist" %>

<%@ Register Src="~/UserControls/ucPager.ascx" TagPrefix="uc1" TagName="ucPager" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="btnnew" runat="server" Text="Add" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <uc1:ucPager runat="server" id="ucPager" />
  <%--  <uc1:ucPager runat="server" id="ucPager1" />
    <uc1:ucPager runat="server" id="ucPager2" />--%>
</asp:Content>
