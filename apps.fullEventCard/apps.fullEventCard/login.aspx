<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="apps.fullEventCard.login" %>

<!DOCTYPE html>
<html lang="en"><head>
<meta http-equiv="content-type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="http://getbootstrap.com/favicon.ico">

    <title>Inicia sesi&oacute;n - Rumbapp</title>

    <!-- Bootstrap core CSS -->
    <link href="Include/bootstrap.min.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="Include/signin.css" rel="stylesheet">

    <script src="Include/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>

  <body>
    <div style="width: 260px; margin: auto">
        <img src="Img/logo.png" style="width: 60px" />
        <span style="color: black; font-size: 2em">Rumbapp</span>
    </div>
    <br />

    <div class="container">
      <form class="form-signin" role="form" method="post" action="listaEventos.aspx" runat="server">
        <h2 class="form-signin-heading">Ingresa tus datos</h2>
        <br />
        <label for="inputEmail" class="sr-only">Correo electr&oacute;nico</label>
        <%--<input id="inputEmail" class="form-control" placeholder="Correo electr&oacute;nico" required="" autofocus="" type="email">--%>          
        <asp:TextBox ID="tbUsuario" runat="server" class="form-control"  required="" ></asp:TextBox>
        <br />
        <label for="inputPassword" class="sr-only">Contrase&ntilde;a</label>
        <asp:TextBox ID="tbPassword" runat="server" class="form-control" required="" type="password"></asp:TextBox>
        <br />
        <div class="checkbox">
          <label>
            <input value="remember-me" type="checkbox"> Recordarme
          </label>
        </div>
        <br />
          <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar sesi&oacute;n" class="btn btn-lg btn-primary btn-block" OnClick="btnIniciarSesion_Click1" />
      </form>

    </div> <!-- /container -->


    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="Include/ie10-viewport-bug-workaround.js"></script>
    </body>
</html>