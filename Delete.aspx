<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Hospital_Management_Database.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-family: oneSlot;
            font-size: large;
            color: #FF0000;
        }
        .auto-style2 {}
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {}
        .auto-style6 {}
        .auto-style7 {
            font-size: x-large;
        }
        .auto-style8 {
            font-size: x-large;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div class="auto-style8">
    
        <span class="auto-style7">Delete Operation In</span><br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="32px" OnClick="Button1_Click" Text="Doctor" Width="68px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style3" Height="35px" OnClick="Button2_Click" Text="Patient" Width="69px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style4" Height="36px" OnClick="Button3_Click" Text="Employee" Width="78px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" CssClass="auto-style5" Height="38px" OnClick="Button4_Click" Text="Disease" Width="66px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" CssClass="auto-style6" Height="35px" OnClick="Button5_Click" Text="Medicine" Width="68px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" CssClass="auto-style6" Height="37px" OnClick="Button6_Click" Text="Room and Admission" Width="153px" BackColor="#339933" Font-Bold="True" Font-Italic="False" ForeColor="White" />
    
    </div>
    </form>
</body>
</html>
