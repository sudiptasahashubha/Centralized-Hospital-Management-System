<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Hospital_Management_Database.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            font-family: oneSlot;
            font-size: x-large;
            text-align: center;
            color: #FF0000;
        }
        .auto-style2 {}
        .auto-style3 {}
        .auto-style4 {}
    </style>
    
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        Where You Want to Update ?
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Doctor" OnClick="Button1_Click" CssClass="auto-style3" ForeColor="White" Height="36px" Width="72px" BackColor="#339933" Font-Bold="True" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Patient" OnClick="Button2_Click" CssClass="auto-style4" ForeColor="White" Height="36px" Width="73px" BackColor="#339933" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Employee" CssClass="auto-style2" OnClick="Button3_Click" Width="72px" ForeColor="White" Height="41px" BackColor="#339933" />
    
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Room And Admission" CssClass="auto-style2" OnClick="Button4_Click" Width="148px" ForeColor="White" Height="41px" BackColor="#339933" />
    
        <br />
    
    </div>
    </form>
</body>
</html>
