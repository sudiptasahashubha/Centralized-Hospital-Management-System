<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Options.aspx.cs" Inherits="Hospital_Management_Database.Options" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            text-align: center;
            color: #99FF99;
            background-color: #FFFFFF;
        }
        .auto-style3 {}
        .auto-style4 {
            font-family: "DejaVu Sans Mono";
            color: #0000CC;
        }
    </style>
</head>
<body class="auto-style2">
    <form id="form1" runat="server" class="auto-style1">
        <strong><span class="auto-style4">What Do You Want To Do</span><br />
        <br />
        <asp:Button ID="QueryButton" runat="server" BackColor="#339933" BorderColor="Black" BorderStyle="Inset" CssClass="auto-style3" Font-Size="X-Large" Height="42px" Text="Query" Width="87px" OnClick="QueryButton_Click" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="InsertButton" runat="server" BackColor="#339933" BorderColor="Black" BorderStyle="Inset" CssClass="auto-style3" Font-Size="X-Large" Height="42px" Text="Insert" Width="87px" OnClick="InsertButton_Click" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="UpdateButton" runat="server" BackColor="#339933" BorderColor="Black" BorderStyle="Inset" CssClass="auto-style3" Font-Size="X-Large" Height="42px" Text="Update" Width="87px" OnClick="UpdateButton_Click" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="DeleteButton" runat="server" BackColor="#339933" BorderColor="Black" BorderStyle="Inset" CssClass="auto-style3" Font-Size="X-Large" Height="42px" Text="Delete" Width="87px" OnClick="DeleteButton_Click" ForeColor="White" />
        <br />
        </strong>
    </form>
</body>
</html>
