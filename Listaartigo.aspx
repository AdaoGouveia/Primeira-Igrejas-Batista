<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listaartigo.aspx.cs" Inherits="PIBLUANDA.Listaartigo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <!-- Responsive/Encoding Metas -->
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- SEO Metas -->
    <meta name="description" content="Zedekiah - MultiPurpose Church &amp; Religion HTML Template" />
    <meta name="keywords" content="church, html, template, zedekiah, fundraising, charity" />
    <meta name="author" content="ThemeSLR" />

    <!-- Page Title -->
    <title>PRIMEIRA IGREJA BAPTISTA DE LUANDA</title>

    <!-- Favicon -->
    <link rel="shortcut icon" href="img/favicon.png" />

    <!-- Begin: CSS Stylesheets -->
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/styles.css" />
    <link rel="stylesheet" type="text/css" href="css/responsive.css" />
    <link rel="stylesheet" type="text/css" href="css/owl.carousel.css" />
    <link rel="stylesheet" type="text/css" href="css/owl.theme.css" />
    <link rel="stylesheet" type="text/css" href="css/owl.transitions.css" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css" />
    <link rel="stylesheet" type="text/css" href="css/font-awesome-animation.min.css" />
    <link rel="stylesheet" type="text/css" href="css/YTPlayer.css" />
    <!-- CSS: YTPlayer CSS -->
    <link rel="stylesheet" type="text/css" href="css/swipebox.css" />
    <link rel="stylesheet" type="text/css" href="css/simple-line-icons.css" />
    <link rel="stylesheet" type="text/css" href="css/navigation.css" />
    <link rel="stylesheet" type="text/css" href="css/animate.css" />
    <link rel="stylesheet" type="text/css" href="css/bootstrap-touch-slider.css" />
    <link rel="stylesheet" type="text/css" href="css/color-schemes/skin-main.css" id="css-default" />
    <!-- End: CSS Stylesheets -->

    <!-- Google Fonts -->
    <link href="//fonts.googleapis.com/css?family=Poppins:300,400,500,600,700%7COpen+Sans:300,300italic,regular,italic,600,600italic,700,700italic,800,800italic,vietnamese,greek,latin-ext,greek-ext,cyrillic-ext,latin,cyrillic" rel="stylesheet" type="text/css" />
    <script type="text/javascript" charset="UTF-8" src="https://maps.googleapis.com/maps-api-v3/api/js/34/16/intl/pt_pt/common.js"></script>
    <script type="text/javascript" charset="UTF-8" src="https://maps.googleapis.com/maps-api-v3/api/js/34/16/intl/pt_pt/util.js"></script>
</head>

<body class="home page-loaded" id="body">
    <!-- PAGE LOADER -->
    <div class="amaezi-page-loader" style="display: none;">
        <div id="loader-wrapper">
            <div id="loader"></div>
        </div>
    </div>


    <div class="row">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <a class="navbar-brand" href="default.aspx">
                        <img alt="logo" src="img/theme_logo_dark.png" />
                    </a>
                </div>
                <div class="col-md-9 fundraising-contact-details">

                    <nav class="navbar navbar-default">
                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#theme-main-nav-menu" aria-expanded="false">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>
                        </div>

                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div class="collapse navbar-collapse" id="theme-main-nav-menu">
                            <ul class="nav navbar-nav navbar-left">
                                <%=sHTMLMenu %>
                            </ul>
                        </div>
                        <!-- /.navbar-collapse -->
                    </nav>
                </div>
            </div>
        </div>
    </div>

   <%=sHTMLProjectos %>
   <%-- <header class="amaezi-fullscreen-header breadcrumbs section-bg" data-image-src="img/gallery/6.jpg" style="background-image: url(&quot;img/gallery/6.jpg&quot;);">

        <!-- HEADER OVERLAY -->
        <div class="amaezi-header-overlay"></div>

        <!-- Header Video -->
        <!-- <div class='youtube-video'></div>
        <a class="youtube-player" data-property="{videoURL:'Tl8E1DzJ0bo',containment:'.youtube-video',autoPlay:true, mute:true, startAt:0, opacity:1,ratio:'16/9',showControls:false,showYTLogo:false}"></a> -->

        <!-- HEADER CONTENT -->
        <div class="amaezi_header_content">
            <h1 class="amaezi_header_title">From the Blog</h1>
        </div>
    </header>--%>


<%--<div id="container" class="main-content">
        <!-- Page content -->
        <div class="container high-padding">
            <div class="row">
                <div class="col-md-12 main-container">
                    <!-- Post content -->
                    <div class="post-content">
                        <!-- Blog posts section -->
                        <div class="items-wrap blog_posts_list blog-posts-shortcode">
                            <div class="posts-list grid">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="row">
                                            <div class="single-post clearfix animateIn animated fadeIn" data-animate="fadeIn" style="opacity: 100;">
                                               
                                                <div class="col-md-12 post-details">
                                                    <div class="post-details-holder">
                                                        <h3 class="post-title text-center"><a href="blog-article.html">New Education During National Day</a></h3>
                                                        <div class="more-post-details text-center">
                                                            <a class="more-link" href="blog-article.html"><i class="icon-user"></i> Jim Hauzi</a>
                                                            <a class="more-link" href="blog-article.html"><i class="icon-clock"></i> 12/01/2017</a>
                                                        </div>
                                                        <p class="post-excerpt text-center">Nam auctor id nisi ut tempus. Aenean pulvinar ex sit amet dolor euismod.</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="spacer_30"></div>

                                    <div class="col-md-12">
                                        <div class="row">
                                            <div class="single-post clearfix animateIn animated fadeIn" data-animate="fadeIn" style="opacity: 100;">
                                               
                                                <div class="col-md-12 post-details">
                                                    <div class="post-details-holder">
                                                        <h3 class="post-title text-center"><a href="blog-article.html">Stitching Together A New Life</a></h3>
                                                        <div class="more-post-details text-center">
                                                            <a class="more-link" href="blog-article.html"><i class="icon-user"></i> Jim Hauzi</a>
                                                            <a class="more-link" href="blog-article.html"><i class="icon-clock"></i> 12/01/2017</a>
                                                        </div>
                                                        <p class="post-excerpt text-center">Nam auctor id nisi ut tempus. Aenean pulvinar ex sit amet dolor euismod.</p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="spacer_30"></div>--%>

                                                
                                </div>
                            </div>
                        </div>
                    </div>

                   
                </div>

               
            </div>
        </div>
    </div>



   <!-- FOOTER -->
    <footer class="footer">

        <div class="row footer-bottom">
            <a class="back-to-top-btn is-visible" href="#body">
                <i class="fa fa-angle-up"></i>
            </a>
            <div class="container">
                <div class="row animateIn animated fadeIn" data-animate="fadeIn" style="opacity: 100;">
                    <%=sHTMLFooter %>
                    <%--  <div class="copyright-informations text-left col-md-6">
                        Made with <i class="icon-heart fa faa-tada faa-fast animated"></i> in Europe by ThemeSLR
                    </div>--%>
                </div>
            </div>
        </div>
    </footer>


    <!-- Begin: JS Scripts -->
    <script src="js/jquery.min.js"></script>
    <script src="js/plugins.js"></script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAl-EDTJ5_uU3zBIX7-wNTu-qSZr1DO5Dw"></script>
    <script src="js/gmaps-v3.js"></script>
    <script src="js/custom.js"></script>
    <!-- End: JS Scripts -->


</body>

</html>
