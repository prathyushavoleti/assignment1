<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void btn1_Click(object sender, EventArgs e)
    {
        Response.Write("Programming is fun");
    }

    protected void textbox1_TextChanged(object sender, EventArgs e)
    {
        string m = "Hello " + textbox1.Text+ " welcome to dotnet training";
		Response.Write(m);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>inline code</title>
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
