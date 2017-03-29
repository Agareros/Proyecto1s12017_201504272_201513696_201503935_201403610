<%-- 
    Document   : Login
    Created on : 28/03/2017, 10:44:36 PM
    Author     : joseph
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%@page import="Servlet.IniciarSesion"%>
<!DOCTYPE html>
<html lang="en">

    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <title>Login</title>
        <!-- Font Awesome -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.0/css/font-awesome.min.css">
        <!-- Bootstrap core CSS -->
        <link href="css/bootstrap.min.css" rel="stylesheet">
        <!-- Material Design Bootstrap -->
        <link href="css/mdb.min.css" rel="stylesheet">
        <!-- Your custom styles (optional) -->
        <link href="css/style.css" rel="stylesheet">
    </head>

    <body>

        <!-- Start your project here-->
        <!--Panel-->
        <div class="card ">
            <div class="card-header default-color-dark white-text">
                </br>
            </div>
            <div class="card-block">
                <!--jumbotron-->
                <div class="row ">
                    <div class="col-md-1 col-md-4 center">
                    </div>
                    <div class="col-md-3 col-md-4 center">

                        <!--Form without header-->
                        <div class="card">
                            <div class="card-block">

                                <!--Header-->
                                <div class="text-center">
                                    <h3><i class="fa fa-user prefix"></i> Iniciar Sesión:</h3>
                                    <hr class="mt-2 mb-2">
                                </div>

                                <!--Body-->
                                <br>
                                <form action="Login">
                                    <div class="md-form">
                                        <i class="fa fa-user prefix"></i>
                                        <input type="text" id="usuario" class="form-control" name="usuario">
                                        <label for="form3">Usuario</label>
                                    </div>

                                    <div class="md-form">
                                        <i class="fa fa-lock prefix"></i>
                                        <input type="password" id="contraseña" class="form-control" name="contraseña">
                                        <label for="form4">Contraseña</label>
                                    </div>

                                    <div class="md-form">
                                        <input type="text" id="empresa" class="form-control" name="empresa">
                                        <label for="form2">Empresa</label>
                                    </div>

                                    <div class="md-form">
                                        <input type="text" id="departamento" class="form-control" name="departamento">
                                        <label for="form2">Departamento</label>
                                    </div>

                                    <div class="text-center">
                                        <button type="submit" value="submit" class="btn btn-primary">Aceptar</button>
                                        <a  href="Home.jsp" class="btn btn-default ">Cancelar</a> 

                                    </div>
                                </form>

                            </div>
                        </div>
                        <!--Form-->
                    </div>
                </div>
                <!--jumbotron-->
            </div>
            <div class="card-footer text-muted default-color-dark white-text">
                </br>
            </div>
        </div>
        <!--/.Panel-->

        <!-- /Start your project here-->

        <!-- SCRIPTS -->
        <!-- JQuery -->
        <script type="text/javascript" src="js/jquery-3.1.1.min.js"></script>
        <!-- Bootstrap tooltips -->
        <script type="text/javascript" src="js/tether.min.js"></script>
        <!-- Bootstrap core JavaScript -->
        <script type="text/javascript" src="js/bootstrap.min.js"></script>
        <!-- MDB core JavaScript -->
        <script type="text/javascript" src="js/mdb.min.js"></script>
    </body>

</html>
