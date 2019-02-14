<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detalheartigo.aspx.cs" Inherits="PIBLUANDA.detalheartigo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <!-- Responsive/Encoding Metas -->
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- SEO Metas -->
    <meta name="description" content="Zedekiah - MultiPurpose Church &amp; Religion HTML Template">
    <meta name="keywords" content="church, html, template, zedekiah, fundraising, charity">
    <meta name="author" content="ThemeSLR">

    <!-- Page Title -->
    <title>PRIMEIRA IGREJA BAPTISTA DE LUANDA</title>

    <!-- Favicon -->
    <link rel="shortcut icon" href="img/favicon.png">

    <!-- Begin: CSS Stylesheets -->
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="css/styles.css">
    <link rel="stylesheet" type="text/css" href="css/responsive.css">
    <link rel="stylesheet" type="text/css" href="css/owl.carousel.css">
    <link rel="stylesheet" type="text/css" href="css/owl.theme.css">
    <link rel="stylesheet" type="text/css" href="css/owl.transitions.css">
    <link rel="stylesheet" type="text/css" href="css/font-awesome.min.css">
    <link rel="stylesheet" type="text/css" href="css/font-awesome-animation.min.css">
    <link rel="stylesheet" type="text/css" href="css/YTPlayer.css">
    <!-- CSS: YTPlayer CSS -->
    <link rel="stylesheet" type="text/css" href="css/swipebox.css">
    <link rel="stylesheet" type="text/css" href="css/simple-line-icons.css">
    <link rel="stylesheet" type="text/css" href="css/navigation.css">
    <link rel="stylesheet" type="text/css" href="css/animate.css">
    <link rel="stylesheet" type="text/css" href="css/bootstrap-touch-slider.css">
    <link rel="stylesheet" type="text/css" href="css/color-schemes/skin-main.css" id="css-default">
    <!-- End: CSS Stylesheets -->

    <!-- Google Fonts -->
    <link href="//fonts.googleapis.com/css?family=Poppins:300,400,500,600,700%7COpen+Sans:300,300italic,regular,italic,600,600italic,700,700italic,800,800italic,vietnamese,greek,latin-ext,greek-ext,cyrillic-ext,latin,cyrillic" rel="stylesheet" type="text/css">
    <script type="text/javascript" charset="UTF-8" src="https://maps.googleapis.com/maps-api-v3/api/js/34/16/intl/pt_pt/common.js"></script>
    <script type="text/javascript" charset="UTF-8" src="https://maps.googleapis.com/maps-api-v3/api/js/34/16/intl/pt_pt/util.js"></script>
</head>


<body class="page-single-blog page-loaded" id="body">
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
                        <img alt="logo" src="img/theme_logo_dark.png">
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
                              <%--  <li><a href="home-image.html">Home</a></li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Gallery</a>
                                    <ul class="dropdown-menu">
                                        <li><a href="gallery-2-columns.html"><i class="icon-picture icons"></i> Gallery 2 Columns</a></li>
                                        <li><a href="gallery-3-columns.html"><i class="icon-picture icons"></i> Gallery 3 Columns</a></li>
                                        <li><a href="gallery-4-columns.html"><i class="icon-picture icons"></i> Gallery 4 Columns</a></li>
                                        <li><a href="gallery-mixed-columns.html"><i class="icon-grid icons"></i> Gallery Mixed Columns</a></li>
                                        <li><a href="gallery-instagram-3-columns.html"><i class="icon-social-instagram icons"></i> Instagram 3 Columns</a></li>
                                        <li><a href="gallery-instagram-4-columns.html"><i class="icon-social-instagram icons"></i> Instagram 4 Columns</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown">
                                    <a href="home-image.html" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Pages</a>
                                    <ul class="dropdown-menu">
                                        <li><a href="what-we-fight-for.html"><i class="icon-graduation icons"></i> What We Fight For</a></li>
                                        <li><a href="our-sponsors.html"><i class="icon-user-following icons"></i> Our Sponsors</a></li>
                                        <li><a href="become-contributor.html"><i class="icon-heart icons"></i> Become Contributor</a></li>
                                        <li><a href="our-partners.html"><i class="icon-people icons"></i> Our Partners</a></li>
                                        <li><a href="contact.html"><i class="icon-location-pin icons"></i> Contact us</a></li>
                                        <li><a href="about.html"><i class="icon-graduation icons"></i> About us</a></li>
                                        <li><a href="404.html"><i class="icon-close icons"></i> 404 Not Found</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Blog</a>
                                    <ul class="dropdown-menu">
                                        <li><a href="blog-list.html"><i class="icon-list icons"></i> Blog List</a></li>
                                        <li><a href="blog-grid.html"><i class="icon-grid icons"></i> Blog Grid</a></li>
                                        <li><a href="blog-article.html"><i class="icon-book-open icons"></i> Article Page</a></li>
                                    </ul>
                                </li>
                                <li><a href="contact.html">Contact</a></li>
                                <li><a href="about.html">About</a></li>
                                <li><a href="#">Purchase</a></li>--%>
                            </ul>
                        </div>
                        <!-- /.navbar-collapse -->
                    </nav>
                </div>
            </div>
        </div>
    </div>

    <%=sHTMLArtigo %>
    <!-- HEADER -->
   <%-- <header class="amaezi-fullscreen-header section-bg" data-image-src="img/gallery/6.jpg" style="background-image: url(&quot;img/gallery/6.jpg&quot;);">

        <!-- HEADER OVERLAY -->
        <div class="amaezi-header-overlay"></div>

        <!-- Header Video -->
        <!-- <div class='youtube-video'></div>
        <a class="youtube-player" data-property="{videoURL:'Tl8E1DzJ0bo',containment:'.youtube-video',autoPlay:true, mute:true, startAt:0, opacity:1,ratio:'16/9',showControls:false,showYTLogo:false}"></a> -->

        <!-- HEADER CONTENT -->
        <div class="amaezi_header_content">
            <h1 class="amaezi_header_title">Título do Artigo</h1>
            <div class="post-details-list text-center">
                <span class="post-author post-date">By<a href="#">Autor</a>Data do Artigo</span>
            </div>
        </div>
    </header>


    <!-- MAIN CONTAINER -->
    <div id="container" class="main-content">
        <!-- Page content -->
        <div class="container high-padding">
            <div class="row">
                <div class="col-md-11 main-container">
                    <!-- Post content -->
                    <div class="post-content animateIn animated fadeIn" data-animate="fadeIn" style="opacity: 100;">
                        <p>We've been enjoying the summer season for more than a few weeks already, but it's right now -- when July melts its way into August -- that the summer harvest is at its peak. Summer squash are plentiful, bouquets of basil are everywhere, and tomatoes are starting to ripen. It's at this moment that you should be running to the kitchen to take advantage of the most bountiful time of year. </p>

                        <blockquote>To help you do just that, we gathered a handful of our favorite food bloggers who really know their way around summer produce. Not only are they experts at packing in as much summer flavor onto one plate, they seem to know exactly what we want to eat, even before we do. Check out these purveyors of summer cooking inspiration, then get yourself into the kitchen. </blockquote>

                        <img src="img/gallery/7.jpg" alt="">
                        <p>Right now, Tieghan is making dishes that include all of summer's bounty in one dish -- like this caramelized peach and cherry salad with corn, basil and buckwheat crepes. Plus, she also made a fresh watermelon cake last week that is the prettiest thing we've ever seen. Check out Half Baked Harvest.</p>

                        <p>If you don't already read Local Milk, stop everything you're doing (even the reading of this list) and head on over there right now. You're liable to spend a couple of hours reading through Beth's beautiful prose and taking in her lovely images, along with ton of great inspiration on cooking during these bountiful summer months. Check out Local Milk.</p>

                        <p><span class="dropcap">S</span>Expedite maximize quality e-services after cutting-edge e-markets. Dramatically expedite viral systems without ethical platforms. Competently innovate goal-oriented action items for standardized internal or "organic" sources. Distinctively empower cross functional partnerships and open-source meta-services. Globally expedite unique experiences without.</p>

                        <p>Credibly engage cost effective platforms vis-a-vis just in time partnerships. Phosfluorescently recaptiualize end-to-end best practices whereas scalable e-business. Energistically e-enable 2.0 human capital rather than.</p>
                    </div>--%>
                    <!-- Post details -->
                   
                    <!-- Post footer -->
                   
                   
                </div>

              
            </div>
        </div>
    </div>


    <!-- SECTION: INSTAGRAM FEED -->
   


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
    <script src="js/custom.js"></script>
    <!-- End: JS Scripts -->


<iframe scrolling="no" frameborder="0" allowtransparency="true" src="https://platform.twitter.com/widgets/widget_iframe.6a4ed48f02c42484dcac7ad4945520ca.html?origin=http%3A%2F%2Fthemeslr.com&amp;settingsEndpoint=https%3A%2F%2Fsyndication.twitter.com%2Fsettings" title="Twitter settings iframe" style="display: none;"></iframe><iframe id="rufous-sandbox" scrolling="no" frameborder="0" allowtransparency="true" allowfullscreen="true" style="position: absolute; visibility: hidden; display: none; width: 0px; height: 0px; padding: 0px; border: none;" title="Twitter analytics iframe"></iframe></body>

</html>
