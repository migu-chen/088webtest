<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryjQuery2.aspx.cs" Inherits="WebApplication2.TryjQuery2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/ajquery-3.6.0.js"></script>
    <script >
        $(document).ready(function () {
            $(".pp").click(function () {
                $(this).hide('slow');
            });
            $("#btn1").click(function () {
                //$(".pp").show('fast');
                $(".pp").show(1000).css("color", "red").css("font-size","24pt")
            });
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>If you click on me, I will disappear.</p>
            <p class="pp">Click me away!</p>
            <p class="pp">Click me too!</p>
            <p class="pp">Click me too1!</p>
            <p class="pp">Click me too2!</p>
            <p class="pp" id="p1">Click me too3!</p>

            <input type="text" id="txt1" />
            <button type="button" id="btn1">Click me</button>
        </div>
    </form>
</body>
</html>
