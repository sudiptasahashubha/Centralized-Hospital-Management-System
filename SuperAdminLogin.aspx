<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuperAdminLogin.aspx.cs" Inherits="Hospital_Management_Database.SuperAdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-family: oneSlot;
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style2 {}
        .auto-style3 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        Admin Login</div>
        <p>
            Enter Password&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" Height="30px" Width="143px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#006600" CssClass="auto-style3" Font-Bold="True" ForeColor="White" Height="37px" OnClick="Button1_Click" Text="Submit" Width="67px" />
        </p>
    </form>
</body>
</html>
