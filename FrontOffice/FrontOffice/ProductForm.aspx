<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductForm.aspx.cs" Inherits="ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>  Product Name<br>
            <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>  Product Description<br>
            <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>  Unit Price<br>
            <asp:TextBox ID="txtStockAmount" runat="server"></asp:TextBox>  Stock Amount<br>
            <asp:RadioButton ID="Active" runat="server"/>Active<br> 
            <asp:Button ID="OK" runat="server" Text="OK" OnClick="OK_Click" /><br>      
        </div>
    </form>
</body>
</html>
