<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductForm.aspx.cs" Inherits="ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset=”utf-8″>
    <meta http-equiv=”X-UA-Compatible” content=”IE=edge”>
    <meta name=”viewport” content=”width=device-width, initial-scale=1″>
    <link rel="stylesheet" href="css/bootstrap.css">
    <title>Product Form</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="col-12 padding">
        <div class="title">
            <asp:Label ID="lblTitle" runat="server"></asp:Label>
        </div>
        <div>
            Product No <asp:TextBox ID="txtProductNo" runat="server" Width="109px"></asp:TextBox> 
        </div>
        <div class="form-button-div text-right">
            <asp:Button ID="Find" runat="server" Text="Find" OnClick="Find_Click" Width="50px"/>
        </div>
        <div id="form">
            <div class="multi-line-field">
                Product Name<br/><asp:TextBox ID="txtProductName" runat="server" TextMode="MultiLine" Width="199px" Height="63px" style="resize:none;"></asp:TextBox>  
            </div>
            <div class="multi-line-field">
                Product Description<br><asp:TextBox ID="txtProductDescription" runat="server" TextMode="MultiLine" Height="63px" Width="199px" style="resize:none;"></asp:TextBox>  
            </div>
            <div>
                Unit Price<br><asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>  
            </div>
            <div>
                Stock Amount<br><asp:TextBox ID="txtStockAmount" runat="server"></asp:TextBox>  
            </div>
            <div>
                 Discount Percentage<br><asp:TextBox ID="txtDiscountPercentage" runat="server"></asp:TextBox> 
            </div>
            <div class="form-button-div">
                <asp:RadioButton ID="Active" runat="server" Text="Product Active"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="OK" runat="server" Text="OK" OnClick="OK_Click"/>
            </div>       
            <div class="error">
                <asp:Label ID="lblError" runat="server"></asp:Label>
            </div>
        </div>
    </div> 
    </form>    
</body>
</html>
