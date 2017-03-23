<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="Hospital_Management_Database.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        #form1 {
            text-align: center;
            background-color: #FFFFFF;
        }
        .auto-style1 {
            margin-bottom: 3px;
        }
        .auto-style2 {
            color: #FF0000;
            background-color: #FFFFFF;
        }
        .auto-style3 {
            font-size: x-large;
            font-family: OneSlot;
        }
        .auto-style4 {}
    </style>
</head>
<body class="auto-style2">
    <form id="form1" runat="server">
        <span class="auto-style3">Where to Insert</span><br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="34px" Text="Doctor" Width="108px" OnClick="Button1_Click" BackColor="#336600" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style1" Height="35px" Text="Patient" Width="104px" OnClick="Button2_Click" BackColor="#336600" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" BackColor="#336600" CssClass="auto-style4" ForeColor="White" Height="35px" OnClick="Button7_Click" Text="Room &amp; Admission" Width="126px" />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" CssClass="auto-style1" Height="45px" Text="Disease &amp; Medicine of Patient" Width="183px" OnClick="Button6_Click" BackColor="#336600" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" CssClass="auto-style1" Height="35px" Text="Employee" Width="104px" OnClick="Button3_Click1" BackColor="#336600" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" CssClass="auto-style1" Height="35px" Text="Disease" Width="96px" OnClick="Button4_Click" BackColor="#336600" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" CssClass="auto-style1" Height="35px" Text="Medicine" Width="100px" OnClick="Button5_Click" BackColor="#336600" ForeColor="White" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
