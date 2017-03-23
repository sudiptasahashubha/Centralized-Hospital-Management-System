<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Disease.aspx.cs" Inherits="Hospital_Management_Database.Disease" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-family: OneSlot;
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style2 {}
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {
            margin-left: 476px;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        <br />
        Search Disease
        <br />
        <br />
        DISEASE NAME&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style2" Height="30px" Width="143px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" Height="36px" OnClick="Button1_Click" Text="Submit" Width="78px" BackColor="#339933" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style4" Height="32px" OnClick="Button2_Click" Text="Show All" Width="75px" BackColor="#339933" ForeColor="White" />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style5">
        </asp:GridView>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
