<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterPage.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/Register.css"
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <div class="container">
                    <label for="username"><b>Username</b></label>
                    <input type="text" placeholder="Enter Username" name="username" required>

                    <label for="email"><b>Email</b></label>
                    <input type="text" placeholder="Enter Email" name="email" required>

                    <label for="password"><b>Password</b></label>
                    <input type="password" placeholder="Enter Password" name="password" required>

                    <label for="passwordCfm"><b>Password</b></label>
                    <input type="password" placeholder="Enter Password" name="passwordCfm" required>

                    <button type="submit" name="btnRegister">Register</button>
                    <button type="submit" name="btnBack">Back</button>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
