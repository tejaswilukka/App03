<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignInPage.aspx.cs" Inherits="ASP.NETLab.SignInPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 40%;
        }
        .auto-style3 {
            width: 361px;
        }
        .auto-style4 {
            width: 578px;
        }
        .auto-style5 {
            width: 578px;
            height: 26px;
        }
        .auto-style6 {
            width: 361px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1 style="text-align:center">Sign-In Page</h1>
        <table class="auto-style1" align="center" style="text-align:center">
            <tr>
                <td class="auto-style5">UserId :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <span style="color:red">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name cannot be empty" ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
                        </span>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Password :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is required" ControlToValidate="TextBox2" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Not in correct format" ForeColor="Red" ValidationExpression="^[A-Z](?=.*[A-Za-z])(?=.*\d)[a-zA-Z\d]{7,}$">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RegistrationPage.aspx">Create new account</asp:HyperLink>
                </td>
                <td class="auto-style3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
            </tr>
        </table>
    </form>
    </body>
</html>
