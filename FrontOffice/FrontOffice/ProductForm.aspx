<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductForm.aspx.cs" Inherits="ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
            <asp:Button ID="OK" runat="server" Text="OK" OnClick="OK_Click"/><br>      
        </div>
    </form>
</body>
</html>
