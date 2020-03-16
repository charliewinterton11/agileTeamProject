<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderForm.aspx.cs" Inherits="OrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="orderForm" runat="server"/>
        OrderNo:<br/>
    <input type="number" name="txtOrderNo"/><br/>

        CustomerNo:<br/>
    <input type="number" name="txtCustomerNo"/><asp:Button ID="FindBtn" runat="server" style="z-index: 1; left: 163px; top: 49px; position: absolute" Text="Find" />
        <br/>

        Customer First Name:<br/>
    <input type="text" name="customerFirstName"/><br/>

        Customer Last Name:<br/>
    <input type="text" name="customerLastName"/><br/>

        OrderDate:<br/>
    <input type="datetime-local" name="orderdate"/><br/>

    <input type="radio" name="active" value="active"/> Active <br/>
    <button type="button">OK</button>
    <form/>
</body>
</html>
