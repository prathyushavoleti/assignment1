<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dispose.aspx.cs" Inherits="commands.dispose" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="linkbutton1" runat="server" OnDisposed="linkbutton1_Disposed" OnClick="linkbutton1_Disposed" >DXC Training</asp:LinkButton><br />
			

        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
