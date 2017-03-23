<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicineIn.aspx.cs" Inherits="Hospital_Management_Database.MedicineIn" %>

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
        .auto-style4 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        Medicine Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Height="23px" Width="138px"></asp:TextBox>
        <br />
        <br />
        <br />
        Name of Medicine&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Height="26px" Width="134px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style4" Height="35px" OnClick="Button1_Click" Text="Submit" Width="81px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
