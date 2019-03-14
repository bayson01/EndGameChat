<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/Login.css"
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <div class="container">
                    <label for="username"><b>Username</b></label>
                    <input type="text" placeholder="Enter Username" name="username" required>

                    <label for="password"><b>Password</b></label>
                    <input type="password" placeholder="Enter Password" name="password" required>

                    <button type="submit" name="btnLogin">Login</button>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
