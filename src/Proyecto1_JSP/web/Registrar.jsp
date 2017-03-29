<%-- 
    Document   : Registrar
    Created on : 28/03/2017, 10:52:18 PM
    Author     : joseph
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en"> 
    <head> 
        <meta charset="utf-8"> 
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"> 
        <meta http-equiv="x-ua-compatible" content="ie=edge"> 
        <title>Registrarse</title>         
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
                        <div class="modal fade pg-show-modal" id="modal1" tabindex="-1" role="dialog" aria-hidden="true"> 
                            <div class="modal-dialog"> 
                                <div class="modal-content"> 
                                    <div class="modal-header"> 
                                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>                                     

                                        <h4 class="modal-title">Modal title</h4> 
                                    </div>                                 

                                    <div class="modal-body"> 
                                        <p>One fine body&hellip;</p> 
                                    </div>                                 

                                    <div class="modal-footer"> 
                                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>                                     

                                        <button type="button" class="btn btn-primary">Save changes</button>                                     
                                    </div>                                 
                                </div>                             
                            </div>                         
                        </div>                     
                    </div>                 
                    <div class="col-md-3 col-md-4 center"> 
                        <!--Form without header-->                     
                        <div class="card"> 
                            <div class="card-block"> 
                                <!--Header-->                             
                                <div class="text-center"> 
                                    <h3><i class="fa fa-user prefix"></i> Registrarse</h3> 
                                    <hr class="mt-2 mb-2"> 
                                </div>                             
                                <!--Body-->                             
                                <br> 
                                <!--Body-->                             
                                <div class="md-form"> 
                                    <i class="fa fa-user prefix"></i> 
                                    <input type="text" id="form3" class="form-control"> 
                                    <label for="form3">Nombre de Usuario</label>                                 
                                </div>                             
                                <div class="md-form"> 
                                    <i class="fa fa-lock prefix"></i> 
                                    <input type="password" id="form4" class="form-control"> 
                                    <label for="form4">Contraseña</label>                                 
                                </div>                             
                                <div class="md-form"> 
                                    <input type="text" id="form2" class="form-control"> 
                                    <label for="form2">Nombre Completo</label>                                 
                                </div>                             
                                <div class="md-form"> 
                                    <input type="text" id="form2" class="form-control"> 
                                    <label for="form2">Empresa para la que trabaja</label>                                 
                                </div>                             
                                <div class="md-form"> 
                                    <input type="text" id="form2" class="form-control"> 
                                    <label for="form2">Departamento en el que trabaja</label>                                 
                                </div>                             
                                <div class="text-center"> 
                                    <button type="button" class="btn btn-primary">Crear Usuario</button>                                 
                                    <button type="button" class="btn btn-default">Cancelar</button>                                 
                                </div>                             
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
