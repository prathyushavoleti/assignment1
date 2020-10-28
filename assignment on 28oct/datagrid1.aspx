<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datagrid1.aspx.cs" Inherits="Datagrid.datagrid1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p> details of students</p>
            <br /><asp:DataGrid ID="datagrid" runat="server"/>
            <p>list of employees</p>
            <br /><asp:DataGrid ID="datagrid2" runat="server"/>
            <p>list of indian cricket players</p><br />
            <asp:DataGrid ID="datagrid3" runat="server"/>
             <p>list of Trains</p><br />
            <asp:DataGrid ID="datagrid4" runat="server"/>
             <p>Bank employee details</p><br />
            <asp:DataGrid ID="datagrid5" runat="server"/>
  

        </div>
    </form>
</body>
</html>
