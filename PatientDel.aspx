<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientDel.aspx.cs" Inherits="Hospital_Management_Database.PatientDel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {}
        .auto-style3 {
            text-align: center;
            font-family: oneSlot;
            font-size: x-large;
            color: #FF0000;
        }
        .auto-style4 {}
    </style>
</head>
<body class="auto-style3">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        Delete Patient Whose<br />
        <br />
        <br />
        Patient Id&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" Height="25px" Width="131px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="40px" OnClick="Button1_Click" Text="Delete" Width="79px" BackColor="#339933" Font-Bold="True" ForeColor="White" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style2" Height="39px" OnClick="Button2_Click" Text="Delete All" Width="81px" BackColor="#339933" ForeColor="White" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
