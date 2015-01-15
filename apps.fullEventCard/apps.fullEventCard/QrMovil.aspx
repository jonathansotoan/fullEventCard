<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QrMovil.aspx.cs" Inherits="apps.fullEventCard.QrMovil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Include/bootstrap.min.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="Include/font-awesome.min.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="Include/main.min.css" rel="stylesheet" type="text/css" media="screen" />
    <link href="Include/FontAwesome/css/font-awesome.css" rel="stylesheet"/>
    <link href="Include/fulldark.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div class="navbar navbar-default">
  <div class="navbar-header">
    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-responsive-collapse">
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
      <span class="icon-bar"></span>
    </button>
    <a class="navbar-brand" href="#">FULL EVENT</a>
  </div>
  <div class="navbar-collapse collapse navbar-responsive-collapse">
    <ul class="nav navbar-nav">
      <li class="active"><a href="listaEventos.aspx">Lista de eventos</a></li>
    </ul>
  </div>
</div>



    <div>
    <asp:panel runat="server" ID="pnlcodigo" Visible="true">
        <br />
        <asp:Image ID="imgQr" CssClass="img-responsive" runat="server" />
        <br />
     </asp:panel>
    
    </div>

     <script src="Include/jquery-2.1.0.min.js"></script>
	<script src="Include/bootstrap.js"></script>
	<script src="Include/modernizr.js"></script>
	<script src="Include/bootstrap-tour.custom.js"></script>
	<script src="Include/king-common.min.js"></script>
	<script src="Include/deliswitch.js"></script>

	<script src="Include/jquery.easypiechart.min.js"></script>
	<script src="Include/raphael-2.1.0.min.js"></script>
	<script src="Include/jquery.flot.min.js"></script>
	<script src="Include/jquery.flot.resize.min.js"></script>
	<script src="Include/jquery.flot.time.min.js"></script>
	<script src="Include/jquery.flot.pie.min.js"></script>
	<script src="Include/jquery.flot.tooltip.min.js"></script>
	<script src="Include/jquery.sparkline.min.js"></script>
	<script src="Include/jquery.dataTables.min.js"></script>
	<script src="Include/dataTables.bootstrap.js"></script>
	<script src="Include/jquery.mapael.js"></script>
	<script src="Include/usa_states.js"></script>
	<script src="Include/king-chart-stat.min.js"></script>
	<script src="Include/king-table.min.js"></script>
	<script src="Include/king-components.min.js"></script>
    </form>
</body>
</html>
