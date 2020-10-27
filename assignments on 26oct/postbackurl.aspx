<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postbackurl.aspx.cs" Inherits="commands.postbackurl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="linkbutton1" runat="server" PostBackUrl= "~/Default.aspx" OnClick="linkbutton1_Click" >Click me</asp:LinkButton>
       <asp:LinkButton ID="linkbtn1" Visible="True" runat="server"></asp:LinkButton>
            </div>
        <asp:Label ID="label1" runat="server" />
    </form>
</body>
</html>
