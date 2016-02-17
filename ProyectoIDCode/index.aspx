<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProyectoIDCode.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet">

    <link href="css/animate.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">

    <form id="form1" runat="server">

        <div id="wrapper">

            <nav class="navbar-default navbar-static-side" role="navigation">
                <div class="sidebar-collapse">
                    <ul class="nav" id="side-menu">
                        <li class="nav-header">
                            <div class="dropdown profile-element">
                                <span>
                                    <img alt="image" class="img-circle" src="img/profile_small.jpg" />
                                </span>
                                <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                                    <span class="clear"><span class="block m-t-xs"><strong class="font-bold">Naruto Uzumaki</strong>
                                    </span><span class="text-muted text-xs block">Padre de familia <b class="caret"></b></span></span></a>
                                <ul class="dropdown-menu animated fadeInRight m-t-xs">
                                    <li><a href="profile.html">Mis datos</a></li>
                                    <li class="divider"></li>
                                    <li><a href="login.html">Salir</a></li>
                                </ul>
                            </div>
                            <div class="logo-element">
                                SCH+
                            </div>
                        </li>

                        <li class="active">
                            <a href="#"><i class="fa fa-desktop"></i><span class="nav-label">App Views</span>  <span class="pull-right label label-primary">SPECIAL</span></a>
                            <ul class="nav nav-second-level">
                                <li class="active"><a href="index.aspx">Matrícula 2016</a></li>
                                <%--<li><a href="profile.html">Notas Académicas</a></li>
                                <li><a href="projects.html">Horario Académico</a></li>
                                <li><a href="project_detail.html">Datos Personales</a></li>
                                <li><a href="file_manager.html">Pagos y deudas</a></li>--%>
                            </ul>
                        </li>

                    </ul>

                </div>
            </nav>

            <div id="page-wrapper" class="gray-bg">
                <div class="row border-bottom">
                    <nav class="navbar navbar-static-top" role="navigation" style="margin-bottom: 0">
                        <div class="navbar-header">
                            <a class="navbar-minimalize minimalize-styl-2 btn btn-primary " href="#"><i class="fa fa-bars"></i></a>

                        </div>
                        <ul class="nav navbar-top-links navbar-right">
                            <li>
                                <span class="m-r-sm text-muted welcome-message">Bienbenido a la I.E.P. School++</span>
                            </li>
                            <li class="dropdown">
                                <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                                    <i class="fa fa-envelope"></i><span class="label label-warning">16</span>
                                </a>
                                <ul class="dropdown-menu dropdown-messages">
                                    <li>
                                        <div class="dropdown-messages-box">
                                            <a href="profile.html" class="pull-left">
                                                <img alt="image" class="img-circle" src="img/a7.jpg">
                                            </a>
                                            <div class="media-body">
                                                <small class="pull-right">46h ago</small>
                                                <strong>Mike Loreipsum</strong> started following <strong>Monica Smith</strong>.
                                                <br>
                                                <small class="text-muted">3 days ago at 7:58 pm - 10.06.2014</small>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="dropdown-messages-box">
                                            <a href="profile.html" class="pull-left">
                                                <img alt="image" class="img-circle" src="img/a4.jpg">
                                            </a>
                                            <div class="media-body ">
                                                <small class="pull-right text-navy">5h ago</small>
                                                <strong>Chris Johnatan Overtunk</strong> started following <strong>Monica Smith</strong>.
                                                <br>
                                                <small class="text-muted">Yesterday 1:21 pm - 11.06.2014</small>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="dropdown-messages-box">
                                            <a href="profile.html" class="pull-left">
                                                <img alt="image" class="img-circle" src="img/profile.jpg">
                                            </a>
                                            <div class="media-body ">
                                                <small class="pull-right">23h ago</small>
                                                <strong>Monica Smith</strong> love <strong>Kim Smith</strong>.
                                                <br>
                                                <small class="text-muted">2 days ago at 2:30 am - 11.06.2014</small>
                                            </div>
                                        </div>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="text-center link-block">
                                            <a href="mailbox.html">
                                                <i class="fa fa-envelope"></i><strong>Read All Messages</strong>
                                            </a>
                                        </div>
                                    </li>
                                </ul>
                            </li>
                            <li class="dropdown">
                                <a class="dropdown-toggle count-info" data-toggle="dropdown" href="#">
                                    <i class="fa fa-bell"></i><span class="label label-primary">8</span>
                                </a>
                                <ul class="dropdown-menu dropdown-alerts">
                                    <li>
                                        <a href="mailbox.html">
                                            <div>
                                                <i class="fa fa-envelope fa-fw"></i>You have 16 messages
                                    <span class="pull-right text-muted small">4 minutes ago</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <a href="profile.html">
                                            <div>
                                                <i class="fa fa-twitter fa-fw"></i>3 New Followers
                                    <span class="pull-right text-muted small">12 minutes ago</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <a href="grid_options.html">
                                            <div>
                                                <i class="fa fa-upload fa-fw"></i>Server Rebooted
                                    <span class="pull-right text-muted small">4 minutes ago</span>
                                            </div>
                                        </a>
                                    </li>
                                    <li class="divider"></li>
                                    <li>
                                        <div class="text-center link-block">
                                            <a href="notifications.html">
                                                <strong>See All Alerts</strong>
                                                <i class="fa fa-angle-right"></i>
                                            </a>
                                        </div>
                                    </li>
                                </ul>
                            </li>


                            <li>
                                <a href="login.html">
                                    <i class="fa fa-sign-out"></i>Log out
                                </a>
                            </li>
                        </ul>

                    </nav>
                </div>
                <div class="row wrapper border-bottom white-bg page-heading">
                    <div class="col-lg-9">
                        <h2>Matrícula 2016</h2>
                        <ol class="breadcrumb">
                            <li>
                                <a href="index.aspx">Home</a>
                            </li>
                            <li>App Views
                            </li>
                            <li class="active">
                                <strong>Matricula 2016</strong>
                            </li>
                        </ol>
                    </div>
                </div>
                <div class="wrapper wrapper-content animated fadeInRight">
                    <div class="row">


                        <%--    <div class="col-lg-4">
                <div class="contact-box">
                    <a href="form_wizard.html">
                    <div class="col-sm-4">
                        <div class="text-center">
                            <img alt="image" class="img-circle m-t-xs img-responsive" src="img/a2.jpg">
                            <div class="m-t-xs font-bold">3° Primaria</div>
                        </div>
                    </div>
                    <div class="col-sm-8">
                        <h3><strong>John Smith</strong></h3>
                        <p><i class="fa fa-map-marker"></i>Av. La Fontana 208</p>
                        <address>
                            <strong>School++</strong><br>
                            7 años<br>
                            15 de abril 2009<br>
                            <abbr title="Phone">P:</abbr> (01) 456-7890
                        </address>
                    </div>
                    <div class="clearfix"></div>
                        </a>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="contact-box">
                    <a href="form_wizard.html">
                    <div class="col-sm-4">
                        <div class="text-center">
                            <img alt="image" class="img-circle m-t-xs img-responsive" src="img/a1.jpg">
                            <div class="m-t-xs font-bold">1° Primaria</div>
                        </div>
                    </div>
                    <div class="col-sm-8">
                        <h3><strong>Alex Johnatan</strong></h3>
                         <p><i class="fa fa-map-marker"></i>Av. La Fontana 208</p>
                        <address>
                            <strong>School++</strong><br>
                            8 años<br>
                            05 de Mayo 2008<br>
                            <abbr title="Phone">P:</abbr> (01) 456-7890
                        </address>
                    </div>
                    <div class="clearfix"></div>
                        </a>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="contact-box">
                    <a href="form_wizard.html">
                    <div class="col-sm-4">
                        <div class="text-center">
                            <img alt="image" class="img-circle m-t-xs img-responsive" src="img/a3.jpg">
                            <div class="m-t-xs font-bold">2° Primaria</div>
                        </div>
                    </div>
                    <div class="col-sm-8">
                        <h3><strong>Monica Smith</strong></h3>
                        <p><i class="fa fa-map-marker"></i>Av. La Fontana 208</p>
                        <address>
                            <strong>School++</strong><br>
                            10 años<br>
                            18 de Agosto 2007<br>
                            <abbr title="Phone">P:</abbr> (01) 456-7890
                        </address>
                    </div>
                    <div class="clearfix"></div>
                        </a>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="contact-box">
                    <a href="profile.html">
                    <div class="col-sm-4">
                        <div class="text-center">
                            <img alt="image" class="img-circle m-t-xs img-responsive" src="img/a4.jpg">
                            <div class="m-t-xs font-bold">4° Primaria</div>
                        </div>
                    </div>
                    <div class="col-sm-8">
                        <h3><strong>Michael Zimber</strong></h3>
                        <p><i class="fa fa-map-marker"></i>Av. La Fontana 208</p>
                        <address>
                            <strong>School++</strong><br>
                            8 años<br>
                            05 de Mayo 2008<br>
                            <abbr title="Phone">P:</abbr> (01) 456-7890
                        </address>
                    </div>
                    <div class="clearfix"></div>
                        </a>
                </div>
            </div>--%>
                        <asp:ListView ID="lvalumnos" runat="server" OnDataBound="lvalumnos_DataBound" OnItemCommand="lvalumnos_ItemCommand" OnPagePropertiesChanged="lvalumnos_PagePropertiesChanged">
                            <ItemTemplate>
                                <table align="left" class="contact-box" class="col-sm-4">
                                    <tr>
                                        <td class="col-sm-4">
                                            <asp:Image ID="Image2" runat="server" Width="140" Height="140" ImageUrl='<%#traercodimg(Eval("cd_alumno").ToString()) %>' />

                                        </td>
                                        <td class="col-sm-8">
                                            <table>
                                                <tr>
                                                    <td>
                                                        Nombre : 
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblnombre" runat="server" Text='<%# Eval("ds_nombre") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        Apellido : 
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblapellido" runat="server" Text='<%#  Eval("ds_apellido")%>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        Grado escolar: 
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lblpago" runat="server" Text='<%# Eval("cd_pago") %>'></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:LinkButton ID="lbver" runat="server" CommandName="lbnver" CommandArgument='<%# Eval("cd_alumno") %>' >Ver</asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>



                                    </tr>

                                </table>

                            </ItemTemplate>

                        </asp:ListView>

                    </div>
                </div>





                <div class="footer">
                    <div class="pull-right">
                        10GB of <strong>250GB</strong> Free.
                    </div>
                    <div>
                        <strong>Copyright</strong> Example Company &copy; 2014-2015
                    </div>
                </div>

            </div>
        </div>

        <!-- Mainly scripts -->
        <script src="js/jquery-2.1.1.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/plugins/metisMenu/jquery.metisMenu.js"></script>
        <script src="js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

        <!-- Custom and plugin javascript -->
        <script src="js/inspinia.js"></script>
        <script src="js/plugins/pace/pace.min.js"></script>


        <script>
            $(document).ready(function () {
                $('.contact-box').each(function () {
                    animationHover(this, 'pulse');
                });
            });
        </script>


    </form>

</body>
</html>
