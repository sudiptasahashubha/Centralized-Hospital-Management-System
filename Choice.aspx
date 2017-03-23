<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Choice.aspx.cs" Inherits="Hospital_Management_Database.Choice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            text-align: center;
        }
        #form1 {
            font-size: x-large;
        }
    </style>
</head>
<body class="auto-style2">
    <form id="form1" runat="server">
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#339933" CssClass="auto-style1" Font-Bold="True" ForeColor="White" Height="39px" OnClick="Button1_Click" Text="Add Hospital" Width="125px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" BackColor="#339933" CssClass="auto-style1" Font-Bold="True" ForeColor="White" Height="39px" OnClick="Button2_Click" Text="Delete Hospital" Width="122px" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" BackColor="#339933" CssClass="auto-style1" Font-Bold="True" ForeColor="White" Height="38px" OnClick="Button3_Click" Text="Show All" Width="134px" />
    <div>
    
    </div>
    </form>
</body>
</html>
