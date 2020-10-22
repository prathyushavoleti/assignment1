<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webpage.aspx.cs" Inherits="website_assignment.webpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>web page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>ASP.Net web page</h1>
        <div>
            <%Response.Write("Hello World!!!"); %><br />
            <%Response.Write("This is printing"); %>
        
        </div>
    </form>
</body>
</html>
