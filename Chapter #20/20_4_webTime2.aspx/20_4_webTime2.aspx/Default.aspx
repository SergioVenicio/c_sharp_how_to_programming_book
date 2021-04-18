<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<html>
    <head>
        <title>WebTime</title>
    </head>
    <body>
        <form id="WebForm" method="post" runat="server">
            <asp:Label
                id="promptLabel"
                style="z-index: 101; left: 25px; position: absolute; top: 23px"
                runat="server" Font-Size="Medium">
                A Simple Web Form Example
            </asp:Label>

            <asp:Label
                id="timeLabel"
                style="z-index: 102; left: 25px; position: absolute; top: 55px"
                runat="server" Font-Size="XX-Large"
                BackColor="Black" ForeColor="LimeGreen">
            </asp:Label>
        </form>
    </body>
</html>
