<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginA.aspx.cs" Inherits="apps.fullEventCard.LoginA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Bootstrap core CSS -->
    <link href="Include/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="Include/signin.css" rel="stylesheet">

    <script src="Include/ie-emulation-modes-warning.js"></script>
</head>
<body>
    <div style="width: 200px; margin: auto">
        <img src="Img/logo.png" style="width: 60px" />
        <span style="color: black; font-size: 2em">Rumbapp</span>
    </div>
    <br />
    <form id="form1" runat="server" class="form-signin">
        <div>
            <h2 class="form-signin-heading">Ingresa tus datos</h2>
            <br />
            <label for="inputEmail" class="sr-only">Correo electr&oacute;nico</label>
            <%--<input id="inputEmail" class="form-control" placeholder="Correo electr&oacute;nico" required="" autofocus="" type="email">--%>
            <asp:TextBox ID="tbUsuario" runat="server" class="form-control" required=""></asp:TextBox>
            <br />
            <label for="inputPassword" class="sr-only">Contrase&ntilde;a</label>
            <asp:TextBox ID="tbPassword" runat="server" class="form-control" required="" type="password"></asp:TextBox>
            <br />
            <div class="checkbox">
                <label>
                    <asp:CheckBox ID="cbRememberme" runat="server" Text="Recordarme" />
                </label>
            </div>
            <br />
            <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar sesi&oacute;n" class="btn btn-lg btn-primary btn-block" OnClick="btnIniciarSesion_Click" />
        </div>
        <div class="btn-link">
        <asp:HyperLink NavigateUrl="~/SignUp.aspx" Text="Registrarse" runat="server"></asp:HyperLink>
        </div> 
    </form>
    <script src="Include/ie10-viewport-bug-workaround.js"></script>
</body>
</html>
