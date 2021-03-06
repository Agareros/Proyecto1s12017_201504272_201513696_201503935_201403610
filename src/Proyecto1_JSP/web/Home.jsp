<%-- 
    Document   : Home
    Created on : 28/03/2017, 10:41:24 PM
    Author     : joseph
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en"> 
    <head> 
        <meta charset="utf-8"> 
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"> 
        <meta http-equiv="x-ua-compatible" content="ie=edge"> 
        <title>Home</title>         
        <!-- Font Awesome -->         
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.0/css/font-awesome.min.css"> 
        <!-- Bootstrap core CSS -->         
        <link href="css/bootstrap.min.css" rel="stylesheet"> 
        <!-- Material Design Bootstrap -->         
        <link href="css/mdb.min.css" rel="stylesheet"> 
        <!-- Template styles -->         
        <style> 
            /* TEMPLATE STYLES */
            html,
            body,
            .view {
            height: 100%;
            }
            /* Navigation*/
            .navbar {
            background-color: transparent;
            }
            .scrolling-navbar {
            -webkit-transition: background .5s ease-in-out, padding .5s ease-in-out;
            -moz-transition: background .5s ease-in-out, padding .5s ease-in-out;
            transition: background .5s ease-in-out, padding .5s ease-in-out;
            }
            .top-nav-collapse {
            background-color: #3c4f74;
            }
            footer.page-footer {
            background-color: #3c4f74;
            margin-top: 2rem;
            }
            @media only screen and (max-width: 768px) {
            .navbar {
            background-color: #1C2331;
            }
            }
            /*Call to action*/
            .flex-center {
            color: #fff;
            }
            .view {
            background: url("fondo.jpg")no-repeat center center fixed;
            -webkit-background-size: cover;
            -moz-background-size: cover;
            -o-background-size: cover;
            background-size: cover;
            }
            /*Contact section*/
            #contact .fa {
            font-size: 2.5rem;
            margin-bottom: 1rem;
            color: #1C2331;
            }
</style>         
    </head>     
    <body> 
        <!--Navbar-->         
        <nav class="navbar navbar-toggleable-md navbar-dark fixed-top scrolling-navbar"> 
            <div class="container"> 
                <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarNav1" aria-controls="navbarNav1" aria-expanded="false" aria-label="Toggle navigation"> 
                    <span class="navbar-toggler-icon"></span> 
                </button>                 
                <a class="navbar-brand" href="#"> <strong>Navegación<br></strong> </a> 
                <div class="collapse navbar-collapse" id="navbarNav1"> 
                    <ul class="navbar-nav mr-auto"> 
                        <li class="nav-item active"> 
                            <a class="nav-link">Inicio <span class="sr-only">(current)</span></a> 
                        </li>                         
                                               
                    </ul>                       
                </div>                 
            </div>             
        </nav>         
        <!--/.Navbar-->         
        <!--Mask-->         
        <div class="view hm-black-strong"> 
            <div class="full-bg-img flex-center"> 
                <ul> 
                    <li> 
                        <h1 class="h1-responsive wow fadeInDown" data-wow-delay="0.2s">Bienvenido al sistema.</h1>
                    </li>
                    
                    <li> 
                        <a href="Login.jsp" class="btn btn-primary btn-lg wow fadeInLeft" data-wow-delay="0.2s">Iniciar Sesión!</a> 
                        <a  href="Registrar.jsp" class="btn btn-default btn-lg wow fadeInRight" data-wow-delay="0.2s">Registrarse</a> 
                    </li>                     
                </ul>                 
            </div>             
        </div>         
        <!--/.Mask-->         
        <!-- Main container-->         
        <div class="container"> 
            <div class="divider-new"> 
                <h2 class="h2-responsive wow bounceIn">About us</h2> 
            </div>             
            <!--Section: About-->             
            <section id="about" class="text-center wow bounceIn" data-wow-delay="0.2s"> 
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Velit explicabo assumenda eligendi ex exercitationem harum deleniti quaerat beatae ducimus dolor voluptates magnam, reiciendis pariatur culpa tempore quibusdam quidem, saepe eius.</p> 
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Velit explicabo assumenda eligendi ex exercitationem harum deleniti quaerat beatae ducimus dolor voluptates magnam, reiciendis pariatur culpa tempore quibusdam quidem, saepe eius.</p> 
            </section>                                  
            <!--Section: Contact-->             
        </div>         
        <!--/ Main container-->         
        <!--Footer-->         
        <footer class="page-footer center-on-small-only"> 
            <!--Footer Links-->             
            <div class="container-fluid"> 
                <div class="row"> 
                                      
                    <hr class="hidden-md-up"> 
                    <!--Second column-->                     
                    <div class="col-lg-2 col-md-4 offset-lg-1"> 
                        <ul> 
                            <li>
                                <a href="#!"></a>
                            </li>                             
                            <li>
                                <a href="#!"><br></a>
                            </li>                             
                            <li>
                                <a href="#!">[EDD] Estructura de datos</a>
                            </li>                              
                        </ul>                         
                    </div>                         
                </div>                 
            </div>             
            <!--/.Footer Links-->             
            <hr> 
            <!--Call to action-->             
            <!--/.Call to action-->             
            <!--Copyright-->         
            
            <!--/.Copyright-->             
        </footer>         
        <!--/.Footer-->         
        <!-- SCRIPTS -->         
        <!-- JQuery -->         
        <script type="text/javascript" src="js/jquery-2.2.3.min.js"></script>         
        <!-- Bootstrap tooltips -->         
        <script type="text/javascript" src="js/tether.min.js"></script>         
        <!-- Bootstrap core JavaScript -->         
        <script type="text/javascript" src="js/bootstrap.min.js"></script>         
        <!-- MDB core JavaScript -->         
        <script type="text/javascript" src="js/mdb.min.js"></script>         
        <!--Google Maps-->         
        <script src="http://maps.google.com/maps/api/js"></script>         
        <script>
        function init_map() {

            var var_location = new google.maps.LatLng(40.725118, -73.997699);

            var var_mapoptions = {
                center: var_location,

                zoom: 14
            };

            var var_marker = new google.maps.Marker({
                position: var_location,
                map: var_map,
                title: "New York"
            });

            var var_map = new google.maps.Map(document.getElementById("map-container"),
                var_mapoptions);

            var_marker.setMap(var_map);

        }

        google.maps.event.addDomListener(window, 'load', init_map);
    </script>         
        <!-- Animations init-->         
        <script>
        new WOW().init();
    </script>         
    </body>     
</html>
