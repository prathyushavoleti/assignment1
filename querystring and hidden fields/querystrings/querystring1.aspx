<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="querystring1.aspx.cs" Inherits="QueryString1.querystring1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 149px;
        }
        .auto-style2 {
            width: 100%;
            height: 177px;
        }
    </style>
</head>
<body style="height: 209px; width: 397px">
    <form id="form1" runat="server">
        <div>
                     </div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style1">Username</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                    <td>
                    <asp:Button ID="Button2" runat="server" Text="Reset" />
                &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

