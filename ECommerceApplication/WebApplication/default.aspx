<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 100px;
        }
        .auto-style3 {
            position: relative;
            z-index: auto;
            width: 342px;
            left: 106px;
            top: 2px;
        }
        .auto-style4 {
            width: 97px;
        }
        .auto-style5 {
            width: 309px;
        }
        .auto-style6 {
            width: 81%;
        }
    </style>
</head>
<body style="height: 486px; width: 557px; margin-left: 94px">
    <form id="form1" runat="server" aria-dropeffect="none">
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" Height="87px" ImageUrl="~/images/firefox.png" Width="97px" />
                </td>
                <td class="auto-style3" style="font-family: sans-serif; font-size: x-large; font-style: oblique; font-weight: bold; color: #800000;">Login Form</td>
                <td><br />
                </td>
            </tr>
        </table>
        <table class="auto-style6">
            <tr>
                <td class="auto-style4">UserName</td>
                <td class="auto-style5">
                    <asp:TextBox ID="uname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="pass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="login" runat="server" OnClick="Onclick" style="height: 26px" Text="Login" />
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5" id="forgot" aria-hidden="True">
                    <asp:LinkButton ID="forgot" runat="server" OnClick="forgot_Click">Forgot password?</asp:LinkButton>
                    <asp:LinkButton ID="sign" runat="server" OnClick="On_signup">SignUp</asp:LinkButton>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
