<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAll.aspx.cs" Inherits="Hospital_Management_Database.ShowAll" %>

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
        .auto-style2 {
            text-align: center;
            margin-left: 328px;
        }
        .auto-style3 {
            text-align: left;
        }
    </style>
</head>
<body class="auto-style1">
    <form id="form1" runat="server">
    <div class="auto-style3">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Showing all Hospital Informtion<br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style2" Width="628px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
