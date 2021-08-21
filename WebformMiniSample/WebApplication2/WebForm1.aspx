<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" 
    Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
           <script>
               //要注意順序先初始化再執行
           <%--var val = <%= this.ForJSInt  %>;
           var va2 = <%= (this.ForJSBool) ? "true": "false" %>;
           var va3 = '<%= this.ForJSString  %>';
           var ForJSBase = <%= this.ForJSBase %>;
           var ForJSCoffecion = <%= this.ForJSCoffecion %>;--%>
               var obj = <%= this.StringObject %>;
           </script>
    <script src="Scripts/WebForm1.js"></script>
     <%-- <script src="Scripts/WebFprm1,js"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <Button type="button" onClick="exec()">Click me</Button>

    </form>
</body>
</html>
