<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientUp.aspx.cs" Inherits="Hospital_Management_Database.PatientUp" %>

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
        .auto-style3 {
            margin-left: 51px;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div>
    
        Patient Id&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2" Height="18px" Width="130px">
        </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        New Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        New Age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        New Contact No
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style3" Height="37px" Text="Submit" Width="84px" OnClick="Button1_Click" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
