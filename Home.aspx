<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Hospital_Management_Database.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-family: OneSlot;
            font-size: xx-large;
            color: #FF0000;
        }
        .auto-style2 {}
        .auto-style3 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        Who Are You ?
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style2" Font-Size="Large" Height="47px" OnClick="Button3_Click" Text="Admin" Width="105px" BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Font-Size="Large" Height="47px" OnClick="Button1_Click" Text="Hospital Administration" Width="227px" BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style3" Font-Size="Large" Height="48px" OnClick="Button2_Click" Text="User" Width="108px" BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <br />
    
    </div>
    </form>
</body>
</html>
