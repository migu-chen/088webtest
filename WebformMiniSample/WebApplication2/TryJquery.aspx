﻿ <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryJquery.aspx.cs" Inherits="WebApplication2.TryJquery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <script src="Scripts/ajquery-3.6.0.js"></script>
    <script>
        //$(document).ready(function () {
         $(function () {
            $(".pp").click(function () {
                $(this).hide();
            });

            //$("#p1").click(function () {
            //    $(".pp").show();
            //});
             $("#txt1").change(function () {
                 alert($(this).val());
             });
             $("#btn1").click(function () {
                 $("#txt1").val('');
             });
             //$("#btn1").click(function () {
             //    alert(123456);
             //});
             $("#btn1").on("click",function () {
                 alert(123);
             });

             $("#btn1").mouseenter(function () {
                 alert("You entered p1!");
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
        <script>

            //var array = document.getElementsByClassName("pp");
            //for (item of array) {
            //    item.onclick = function () {
            //        item.style["display"] = "none";
            //    }
            //}               
        </script>

    </form>
</body>
</html>
