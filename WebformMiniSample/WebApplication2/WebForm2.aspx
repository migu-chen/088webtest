<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <table>
          <tr><th>產品</th><td>
                  <asp:DropDownList ID="dd1Product" runat="server">
                      <asp:ListItem Value ="001">橘子</asp:ListItem>
                      <asp:ListItem Value ="002">草莓</asp:ListItem>
                      <asp:ListItem Value ="003">梨子</asp:ListItem>
                  </asp:DropDownList></td></tr>
          <tr><th>單價</th><td>
              <asp:TextBox ID="txtPrice" runat="server" Enabled ="false" >0</asp:TextBox></td></tr>
          <tr><th>數量</th><td>
              <asp:TextBox ID="txtQuantity" runat="server" TextMode="Number">0</asp:TextBox></td></tr>
       </table>
        <asp:Label ID="Ib1totalPrice" runat="server" >0</asp:Label><br />
        <asp:Button ID="btnSave" runat="server" Text="Button" OnClick="btnSave_Click" /><br />
        <asp:Label ID="Ib1Msg" runat="server" Text="123"></asp:Label>


        <script>
            var dd1Product = document.getElementById("dd1Product");
            var txtPrice = document.getElementById("txtPrice");
            var txtQuantity = document.getElementById("txtQuantity");
            var Ib1totalPrice = document.getElementById("Ib1totalPrice");


            var priceMapping = {
                "001": 50,
                "002": 160,
                "003": 400
            }

            dd1Product.onchange = function(){
                var productID = dd1Product.value;
                var price = priceMapping[productID];

                txtPrice.value = price;
            }

            txtQuantity.onblur = function () {
                var quantity = parseInt(txtQuantity.value, 10);
                var price = txtPrice.value;
                var totalPrice = price * quantity;
                Ib1totalPrice.innerText = totalPrice;
            }

        </script>

    </form>
</body>
</html>
