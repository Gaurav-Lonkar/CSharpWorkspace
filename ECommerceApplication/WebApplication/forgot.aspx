<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot.aspx.cs" Inherits="WebApplication.forgot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body style="height: 483px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Username</td>
                    <td>
                        <asp:TextBox ID="uname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>New Password</td>
                    <td>
                        <asp:TextBox ID="n_pass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Conform Password</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="change" runat="server" Text="Change" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
