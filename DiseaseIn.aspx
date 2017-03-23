<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiseaseIn.aspx.cs" Inherits="Hospital_Management_Database.DiseaseIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
            font-family: OneSlot;
            color: #FF0000;
        }
        .auto-style2 {
            font-family: OneSlot;
        }
        .auto-style3 {}
        .auto-style4 {}
        .auto-style5 {}
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div class="auto-style2">
    
        <br />
        Disease Id&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Height="24px" Width="127px"></asp:TextBox>
        <br />
        <br />
        Disease Name&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style4" Height="24px" Width="132px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CssClass="auto-style5" Height="37px" Width="75px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>
