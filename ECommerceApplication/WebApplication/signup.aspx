<%@ Page Language="C#"%>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 254px;
        }
        .auto-style3 {
            width: 19px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</head>
       <script runat="server">

           protected void refcheck_CheckedChanged(object sender, EventArgs e)
           {
               //Response.Write("is checked"+refcheck.Checked);
               if (refcheck.Checked)
                   this.chk.Text = "true";
               else
                   this.chk.Text = "false";
           }

           protected void sign_Click(object sender, EventArgs e)
           {
               Response.Write("submited");

           }

           protected void custradion_CheckedChanged(object sender, EventArgs e)
           {
               HtmlInputRadioButton radio = (HtmlInputRadioButton)sender;
               if (radio.Checked)
                   this.rd.Text = "customer";

           }

           protected void Adminradio_CheckedChanged(object sender, EventArgs e)
           {
               HtmlInputRadioButton radio1 = (HtmlInputRadioButton)sender;
               if (radio1.Checked)
                   this.rd.Text = "admin";

           }

           protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
           {
               this.pkg.Text = Select1.Value;

           }
</script>
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
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emaill" ErrorMessage="Invalid EmailID" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>UserName</td>
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="username" ErrorMessage="name is mandatory" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="password" runat="server" TextMode="Password" ></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="password" ErrorMessage="must contain 6 char with special char " ForeColor="Red" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Cnform Password</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="cpass" runat="server" ></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="cpass" ControlToValidate="password" ErrorMessage="not matched" ForeColor="Red" ValueToCompare="password"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="phone" ErrorMessage="not valid phone number" ForeColor="#CC0000" ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="address" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="sign" runat="server" Text="SignUp" OnClick="sign_Click"  />
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" id="referred">
                    <input id="refcheck" class="auto-style3" onserverchange="refcheck_CheckedChanged" type="checkbox" runat="server" />Referred</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" id="radio">
                    <input id="Radio1" type="radio" name="radio" onserverchange="custradion_CheckedChanged" runat="server"/>customer</td>
                <td id="radio1">
                    <input id="Radio2" type="radio" name="radio" onserverchange="Adminradio_CheckedChanged" runat="server"/>admin</td>
            </tr>
            <tr>
                <td class="auto-style2">Package</td>
                <td>
                    <select id="Select1" name="D1"  onserverchange="DropDownList1_SelectedIndexChanged" runat="server">
                       <option>Select below</option>
                        <option>Premium</option>
                        <option>Standard</option>
                        <option>Regular</option>
                    </select></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    CheckBox</td>
                <td>
                    <asp:Label ID="chk" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    Radio</td>
                <td>
                    <asp:Label ID="rd" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    Select</td>
                <td>
                    <asp:Label ID="pkg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
