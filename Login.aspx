<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hospital_Management_Database.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style3 {
            font-family: "DejaVu Serif";
        }
        .auto-style5 {}
        #Password1 {
            height: 28px;
            width: 159px;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {}
        </style>
</head>
<body style="text-align: center; background-color: #FFFFFF; font-size: x-large; font-family: OneSlot; color: #FF0000;">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <span class="auto-style6">LogIn Here</span><span class="auto-style3"><br />
            <br />
            </span>Hospital ID<span class="auto-style3">&nbsp;&nbsp;&nbsp; </span>&nbsp;<asp:TextBox ID="TextBoxano" runat="server" CssClass="auto-style3" Width="182px" Height="29px" Font-Size="Large" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br class="auto-style3" />
            Password<span class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style7" Height="26px" TextMode="Password" Width="175px"></asp:TextBox>
            <br />
            <br class="auto-style3" />
            <asp:Button ID="LoginAdmin" runat="server" CssClass="auto-style5" Height="34px" OnClick="LoginAdmin_Click1" Text="Login" Width="71px" BackColor="#339933" ForeColor="White" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
