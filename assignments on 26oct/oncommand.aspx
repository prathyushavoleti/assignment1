<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="oncommand.aspx.cs" Inherits="commands.oncommand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="linkbutton1" runat="server" OnCommand="linkbtn1_Command" Text="item1" CommandName="Selected" CommandArgument="1" ></asp:LinkButton>
            <asp:LinkButton ID="linkbutton2" runat="server" OnCommand="linkbtn2_Command" Text="item2" CommandName="Selected" CommandArgument="2" ></asp:LinkButton>
      
        </div>
        <asp:Label ID="label1" runat="server"></asp:Label>
    </form>
</body>
</html>
