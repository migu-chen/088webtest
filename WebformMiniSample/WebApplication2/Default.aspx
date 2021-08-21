<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #txt1{
            display: none;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="Ib1name" runat="server" Text="Label">hlep </asp:Label>
        <br />
        <asp:TextBox ID="txt1" runat="server" ></asp:TextBox><!--Visible="false" -->
        <asp:HiddenField ID="hf1" runat="server" />
        <asp:HiddenField ID="hf2" runat="server" />

        <!--瀏覽器端的警告   -->
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick ="Unnamed_Click"
            OnClientClick ="exec(); alert('123')" />


        

        <script>

            var val = <%= this.ForJSInt  %>;
            alert(val*40);

            var va2 = <%= (this.ForJSBool) ? "true": "false" %>;
            alert(va2);

            var va3 = '<%= this.ForJSString  %>';
            alert(va3);

            var val3 = true;

            function exec2() {
                var hf2 = document.getElementById("hf2");
                var va1 = hf2.value;

                alert(va1);
            }
            exec2();

            //瀏覽器端的警告
            // alert("123")
            function exec() {
                var IbI = document.getElementById("Ib1name");
                IbI.innerHTML = "World";

               // var txt = document.getElementById("txt1");
               // txt.value = "World 56";
                var hf1 = document.getElementById("hf1");
                hf1.value = "World 46";
            }

        </script>
    </form>
</body>
</html>
