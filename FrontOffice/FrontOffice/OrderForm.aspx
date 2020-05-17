<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="orderForm" runat="server">
    <div>
        OrderNo:<br/>
    <asp:TextBox ID="txtOrderNo" runat="server" Width="109px"></asp:TextBox>

        <br />

        CustomerNo:<br/>
    <asp:TextBox ID="txtCustomerNo" runat="server" Width="109px"></asp:TextBox><asp:Button ID="FindBtn" runat="server" style="z-index: 1; left: 151px; top: 31px; position: absolute" Text="Find" OnClick="FindBtn_Click" />
        <br/>

        Customer First Name:<br/>
    <asp:TextBox ID="txtCustomerFirstName" runat="server" Width="109px"></asp:TextBox>

        <br />

        Customer Last Name:<br/>
    <asp:TextBox ID="txtCustomerLastName" runat="server" Width="109px"></asp:TextBox>

        <br />

        OrderDate:<br/>
    <asp:TextBox ID="txtOrderDate" runat="server" Width="109px"></asp:TextBox>

    &nbsp;
        <br />
        

        <asp:CheckBox ID="Active" runat="server" style="z-index: 1; left: 12px; top: 236px; position: absolute" Text="Active" />
        </div>
        <p>
                <asp:Label ID="lblError" runat="server"></asp:Label>
            <div class="error">
    <asp:Button ID="OKBtn" runat="server" Text="OK" OnClick="BtnOK_Click" Height="33px" style="margin-top: 40px" Width="45px" />
        </p>
    </form>
</body>
</html>
