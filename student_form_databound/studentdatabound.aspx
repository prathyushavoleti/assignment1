<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentdatabound.aspx.cs" Inherits="studentdatabound.studentdatabound" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <style type="text/css">
        .auto-style1 {
            height: 34px;
             
        }
        .auto-style5 {
            height: 34px;
            width: 122px;
             background-color:aqua;
        }
        .auto-style4 {
            width: 122px;
        }
        .auto-style6 {
            width: 104%;
            height: 321px;
            background-color:aqua;
        }
        .auto-style7 {
            height: 133px;
            width: 122px;
             background-color:aqua;
        }
        .auto-style11 {
            width: 68px;
        }
        .auto-style12 {
            width: 68px;
            height: 34px;
             background-color:aqua;
        }
        .auto-style13 {
            width: 68px;
            height: 133px;
             background-color:aqua;
        }
        </style>
            </head>
<body  style="height: 1810px">
    <form id="form2" runat="server">
        <div>
                                

            <asp:Repeater ID="rpr1" runat="server">
            <HeaderTemplate>
                            <table style="width:200px;padding-top:0px;background-color:gold" >
                <tr>

                                    <td style="font-size:20px;text-align:center;height:48px">
                                        <asp:Label ID="lbl1" runat="server" Text="Student profile"></asp:Label>

                                    </td>
                                </tr>
                                </table>
            </HeaderTemplate>
                <ItemTemplate>
            
            <table class="auto-style6">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Text="stID"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="Label7" runat="server" Text='<%#Eval("stID") %>'></asp:Label>
                    
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="stName"></asp:Label>
                    </td>
                     <td class="auto-style11">
                        <asp:Label ID="Label8" runat="server" Text='<%#Eval("stName") %>'></asp:Label>
                    
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="stEmailID"></asp:Label>
                    </td>
                     <td class="auto-style11">
                        <asp:Label ID="Label9" runat="server" Text='<%#Eval("stEmailID") %>'></asp:Label>
                    
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label4" runat="server" Text="stMobileNum"></asp:Label>
                    </td>
                     <td class="auto-style11">
                        <asp:Label ID="Label10" runat="server" Text='<%#Eval("stMobileNum") %>'></asp:Label>
                    
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label6" runat="server" Text="stGender"></asp:Label>
                    </td>
                     <td>
                        <asp:Label ID="Label11" runat="server" Text='<%#Eval("stGender") %>'></asp:Label>
                    
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label13" runat="server" Text="stCity"></asp:Label>
                    </td>
                     <td>
                        <asp:Label ID="Label14" runat="server" Text='<%#Eval("stCity") %>'></asp:Label>
                    
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label15" runat="server" Text="stAddress"></asp:Label>
                    </td>
                     <td>
                        <asp:Label ID="Label16" runat="server" Text='<%#Eval("stAddress") %>'></asp:Label>
                    
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label5" runat="server" Text="stImg"></asp:Label>
                    </td>
                    <td rowspan="5" class="auto-style13">
                        <asp:Image ID="img1" runat="server" Width="65px" ImageUrl='<%#"https://www.bing.com/th?id=OIP.rtaM-AfxZ9HSLOdFDeY5aAHaE8&w=158&h=106&c=8&rs=1&qlt=90&pid=3.1&rm=2"+ Eval("stImg")%>' Height="78px" />
                        <br />
                                                <asp:Label ID="Label12" runat="server" Text='<%#Eval("stImg") %>'></asp:Label>

                    
                    </td>
                    
                </tr>
                
            </table>
        
    
    </ItemTemplate>
                <FooterTemplate>
                    <table>
                        <tr>
                            <td>
                                @developed by prathyusha<br />
                                @All rights reserved
                            </td>
                        </tr>
                    </table>
                </FooterTemplate>

            </asp:Repeater>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentdetails %>" SelectCommand="SELECT * FROM [studentdetails]"></asp:SqlDataSource>

            </div>
                </form>                   

        
</body>
</html>
