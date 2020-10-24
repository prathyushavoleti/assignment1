<%@ Page Language="C#" AutoEventWireup="true" CodeFile="codebehind.aspx.cs" Inherits="codebehind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>code behind</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="textbox1" runat="server" OnTextChanged="textbox1_TextChanged"></asp:TextBox><br /><br />
                        <asp:Button ID="btn1" runat="server" Text="Submit" OnClick="btn1_Click" />


        </div>
    </form>
</body>
</html>
