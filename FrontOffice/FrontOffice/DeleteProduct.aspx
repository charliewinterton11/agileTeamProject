<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteProduct.aspx.cs" Inherits="DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset=”utf-8″>
    <meta http-equiv=”X-UA-Compatible” content=”IE=edge”>
    <meta name=”viewport” content=”width=device-width, initial-scale=1″>
    <link rel="stylesheet" href="css/bootstrap.css">
    <title>Delete Product</title>    
</head>
<body>
    <form id="form1" runat="server">
    <div class="col-4 padding">
        <div class="title">
            <asp:Label ID="lblTitle" runat="server" Text="Delete Product"></asp:Label><br>
         </div>
         Name: <asp:Label ID="lblName" runat="server"></asp:Label> <br>
         Description: <asp:Label ID="lblDesc" runat="server"></asp:Label> 
      </div>
      <div class="col-4 text-center">
        <div>
            <br><asp:Label ID="lblConfirm" runat="server" Text="Are you sure you want to delete this product?"></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Yes" />
            <asp:Button ID="btnCancel" runat="server" Text="No" OnClick="btnCancel_Click" />
        </div>
      </div>
    </form>
</body>
</html>
