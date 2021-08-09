<%@ Page Title="" Language="C#" MasterPageFile="~/SystemAdmin/Admin.Master"
    AutoEventWireup="true" CodeBehind="Userlist.aspx.cs" Inherits="AccountingNote.SystemAdmin.Userlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="btnnew" runat="server" Text="Add" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
