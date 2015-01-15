<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="apps.fullEventCard.SignUp" %>

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
    <div style="width: 200px; margin: auto">
        <img src="Img/logo.png" style="width: 60px" />
        <span style="color: black; font-size: 2em">Rumbapp</span>
    </div>
    <br />
    <div class="container">

      <form class="form-signin" role="form" runat="server">
        <h2 class="form-signin-heading">Reg&iacute;strate</h2>
        <br />
        <label>Nombres</label>
        <asp:TextBox name="nombres" class="form-control" required="" autofocus="" runat="server" ID="txtNombres"></asp:TextBox>
        <br />
        <label for="inputEmail">Correo electr&oacute;nico</label>
        <asp:TextBox name="inputEmail" class="form-control" placeholder="alguien@example.com" runat="server" required="" autofocus="" type="email" ID="txtCorreos"></asp:TextBox>
        <br />
        <label for="inputPassword">Contrase&ntilde;a</label>
        <asp:TextBox name="inputPassword" class="form-control" placeholder="Tu contrase&ntilde;a" runat="server" required="" type="password" ID="txtContra" TextMode="Password"></asp:TextBox>
        <br />
        <label for="inputPassword">Confirma tu contrase&ntilde;a</label>
        <asp:TextBox name="inputPasswordConfirm" class="form-control" placeholder="Tu contrase&ntilde;a de nuevo" runat="server" required="" type="password" ID="txtConcontra" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="SigningUp" Text="Reg&iacute;strate" class="btn btn-lg btn-primary btn-block" />
      </form>

    </div> <!-- /container -->


    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="Include/ie10-viewport-bug-workaround.js"></script>
  

</body>
</html>