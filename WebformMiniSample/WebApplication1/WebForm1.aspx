﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <table > 
          <tr>
              <td colspam="2">
                 <h1>示範系統 - 後台</h1>
              </td>
          </tr>
        <tr>
          <td>
              <a href ="WebForm1.aspx" >第 一頁</a><br />
              <a href ="WebForm2.aspx" >第 二頁</a><br />
              <a href ="WebForm3.aspx" >第 三頁</a><br />
          </td>
          <td>
              <!--這裡放主要內容-->
              <asp:Button ID="Button1" runat="server" Text="Button" />

          </td>
         </tr>
       </table>
    </form>
</body>
</html>