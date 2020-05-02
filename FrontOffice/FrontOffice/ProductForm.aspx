﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductForm.aspx.cs" Inherits="ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <title>Product Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtProductNo" runat="server"></asp:TextBox> Product No
            <asp:Button ID="Find" runat="server" Text="Find" OnClick="Find_Click"/><br>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>  Product Name<br>
            <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>  Product Description<br>
            <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>  Unit Price<br>
            <asp:TextBox ID="txtStockAmount" runat="server"></asp:TextBox>  Stock Amount<br>
            <asp:TextBox ID="txtDiscountPercentage" runat="server"></asp:TextBox>  DiscountPercentage<br>
            <asp:RadioButton ID="Active" runat="server"/>Product Active<br> 
            <asp:Button ID="OK" runat="server" Text="OK" OnClick="OK_Click"/>
            <br>   
        </div>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
