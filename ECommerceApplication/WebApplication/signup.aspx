<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="WebApplication.signup" %>

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
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2" style="font-family: saNs-serif; font-size: large; font-weight: bold; color: #000080; position: static">SignUp New User</td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="emaill" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>UserName</td>
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="password" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Resume</td>
                    <td>
                        <asp:FileUpload ID="FileUpload" runat="server" EnableTheming="False" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="sign" runat="server" Text="SignUp" OnClick="OnSubmit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
