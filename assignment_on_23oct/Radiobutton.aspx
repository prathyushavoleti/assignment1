<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Radiobutton.aspx.cs" Inherits="Radiobutton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Red" Font-Bold="True" ForeColor="Red" GroupName="rbn1" /><br /><br />
				<asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Blue" Font-Bold="True" ForeColor="#0033CC" GroupName="rbn1" /><br /><br />
		
			<asp:RadioButton ID="RadioButton3" runat="server" OnCheckedChanged="RadioButton3_CheckedChanged" Text="Green" Font-Bold="True" ForeColor="#009900" GroupName="rbn1" /><br /><br />
			<br />
            <asp:Button runat="server" ID="btn1" Text="Submit" OnClick="btn1_Click" />
        </div>
    </form>
    <asp:Label ID="colorid" runat="server" ></asp:Label>
</body>
</html>
