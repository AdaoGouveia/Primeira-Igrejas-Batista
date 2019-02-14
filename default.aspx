<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIBLUANDA._default" %>

<!DOCTYPE html>

<html lang="en" class=" js cssanimations csstransforms csstransforms3d csstransitions js flexbox flexboxlegacy canvas canvastext webgl no-touch geolocation postmessage websqldatabase indexeddb hashchange history draganddrop websockets rgba hsla multiplebgs backgroundsize borderimage borderradius boxshadow textshadow opacity cssanimations csscolumns cssgradients cssreflections csstransforms csstransforms3d csstransitions fontface generatedcontent video audio localstorage sessionstorage webworkers no-applicationcache svg inlinesvg smil svgclippaths">
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
    <title>PRIMEIRA IGREJA BAPTISTA DE LUANDA MC</title>

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

<!-- BODY -->
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
                                <%--<li><a href="home-image.html">Home</a></li>
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





    <div id="bootstrap-touch-slider" class="carousel bs-slider fade control-round indicators-line" data-ride="carousel" data-pause="hover" data-interval="false">


        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#bootstrap-touch-slider" data-slide-to="0" class="active"></li>
            <li data-target="#bootstrap-touch-slider" data-slide-to="1"></li>
            <li data-target="#bootstrap-touch-slider" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper For Slides -->
        <div class="carousel-inner" role="listbox">

            <!-- First Slide -->
            <div class="item active">
                <%=sHTMLBanner %>
                <%-- <img src="img/header-banners/holyspirit_sider_001_ok.jpg" alt="" class="slide-image">
               <div class="bs-slider-overlay"></div>

                <div class="container">
                    <div class="row">
                        <!-- Slide Text Layer -->
                        <div class="slide-text slide_style_left slide_style_top15">
                            <div class="col-md-6">
                                <h1 data-animation="animated fadeIn" class="">Faith. Hope Love</h1>
                                <p data-animation="animated fadeIn" class="">Love is patient, love is kind. It does not<br>envy,it does not boast, it is not proud. </p>
                                
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>
            <!-- End of Slide -->

            <!-- Second Slide -->
            <div class="item">
                <%=sHTMLBanner2 %>
                <!-- Slide Background -->
               <%-- <img src="img/header-banners/holyspirit_sider_002_ok.jpg" alt="" class="slide-image">
                <!-- <div class="bs-slider-overlay"></div> -->

                <!-- Slide Text Layer -->
                <div class="slide-text slide_style_right slide_style_top15">
                    <div class="col-md-6 col-md-offset-6">
                        <h1 data-animation="animated fadeIn">Life is Fragile<br>
                            Handle With<br>
                            Prayer</h1>
                        <p data-animation="animated fadeIn">Love is patient, love is kind. It does not envy,<br>
                            it does not boast, it is not proud.</p>
                        <a href="#" target="_blank" class="btn btn-default" data-animation="animated fadeIn">Prayers List</a>
                        <a href="#" target="_blank" class="btn btn-primary" data-animation="animated fadeIn">Give Donation</a>
                    </div>
                </div>--%>
            </div>
            <!-- End of Slide -->

            <!-- Third Slide -->
            <div class="item">
                <%=sHTMLBanner3 %>
                <%--<img src="img/header-banners/holyspirit_sider_003_ok.jpg" alt="" class="slide-image">
                <!-- <div class="bs-slider-overlay"></div> -->

                <div class="container">
                    <div class="row">
                        <!-- Slide Text Layer -->
                        <div class="slide-text slide_style_left slide_style_top15">
                            <div class="col-md-6">
                                <h1 data-animation="animated fadeIn">With God As<br>
                                    Shepherd...</h1>
                                <p data-animation="animated fadeIn">With God as shepherd, you are truly<br>
                                    cared for, in every way!</p>
                                <a href="#" target="_blank" class="btn btn-default" data-animation="animated fadeIn">Listen Sermons</a>
                                <a href="#" target="_blank" class="btn btn-primary" data-animation="animated fadeIn">Give Donation</a>
                            </div>
                        </div>
                    </div>
                </div>--%>
            </div>
            
            <!-- End of Slide -->
        </div>
        <!-- End of Wrapper For Slides -->

        <!-- Left Control -->
        <a class="left carousel-control" href="#bootstrap-touch-slider" role="button" data-slide="prev">
            <span class="fa fa-angle-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>

        <!-- Right Control -->
        <a class="right carousel-control" href="#bootstrap-touch-slider" role="button" data-slide="next">
            <span class="fa fa-angle-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <!-- End  bootstrap-touch-slider Slider -->



    <!-- MAIN CONTAINER -->
    <div id="container" class="main-content">

        <!-- SECTION: GOALS/ACHIEVEMENTS -->
        <section class="high-padding section-bg" data-image-src="img/header-banners/overlay_MEMBERS-min.png" style="background-image: url(&quot;img/header-banners/overlay_MEMBERS-min.png&quot;);">
            <div class="container">
                <%=sHTMLDestaques1 %>
                <!-- TITLE + SUBTITLE section -->
                <%--  <div class="relative section-header"> 
                    <h2 class="section-title">You Are Here! You are Blessed!</h2>
                    <p>Sermons are now made easy using Church HTML Template! Share the news and press releases to your focus group and complete causes using donations.</p>
                </div>
                <%--<div class="row">
                    <div class="col-md-6 text-center">
                        <div class="spacer_10"></div>
                        <h2>Our Verses For God</h2>
                        <p><strong>11:</strong> "For I know the plans I have for you," declares the LORD, "plans to prosper you and not to harm you, plans to give you hope and a future."</p>
                        <p><strong>14:</strong> "I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD"</p>
                        <p><strong>17:</strong> "Yes, this is what the LORD Almighty says: "I will send the sword, famine and plague against them and I will make them like figs that are so bad they cannot be eaten."</p>
                    </div>
                    <div class="col-md-6">
                        <div class="embed-responsive embed-responsive-16by9">
                            <iframe class="embed-responsive-item" src="//www.youtube.com/embed/QyvavfIGyLs?rel=0"></iframe>
                        </div>
                    </div>
                </div>--%>
            </div>
        </section>


        <!-- SECTION: GET INVOLVED -->
        <%-- <section class="section-bg" data-image-src="img/header-banners/holyspirit_wordpress_theme_themeslr-10.jpg" style="background-image: url(&quot;img/header-banners/holyspirit_wordpress_theme_themeslr-10.jpg&quot;);">
            <!-- HEADER CONTENT -->

            <div class="amaezi_header_content light-texts">--%>
        <%=sHTMLDestaques2 %>
        <%-- <h3 class="amaezi_header_title">Get Involved</h3>
                <div class="spacer_30"></div>
                <p class="amaezi_header_subtitle">"For I know the plans I have for you," declares the LORD, "plans to prosper you and not to harm you, plans to give you hope and a future."</p>
        --%>    <%-- <p class="amaezi_header_subtitle">"I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD"</p>
             <p class="amaezi_header_subtitle">"Yes, this is what the LORD Almighty says: "I will send the sword, famine and plague against them and I will make them like figs that are so bad they cannot be eaten."</p>
        --%>
        <div class="spacer_30"></div>
        <%--  <a class="btn tslr-btn btn-primary" href="#"></a>--%>
    </div>
    </section>


        <!-- SECTION: OUR SERVICES -->
    <section class="high-padding gray-section">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <!-- SERVICES SHORTCODE -->
                    <div class="row services-shortcode">

                        <%=sHTMLDestaques3 %>
                        <%-- <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-12 text-center">
                                        <img src="img/content/our-church.jpg" alt="" class="img-rounded">
                                    </div>
                                </div>
                            </div>--%>

                        <%--<div class="col-md-4">
                                <div class="spacer_20"></div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <h3 class="text-left"><strong>Modern Church</strong></h3>
                                        <p class="text-left">Nullam non efficitur purus. Sed vitae lorem vel arcu imperdiet ullamcorper. Ut quis odio est. In vestibulum dignissim nisl.</p>
                                    </div>
                                </div>

                                <div class="spacer_20"></div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <h3 class="text-left"><strong>Sunday Liturgies</strong></h3>
                                        <p class="text-left">Nullam non efficitur purus. Sed vitae lorem vel arcu imperdiet ullamcorper. Ut quis odio est. In vestibulum dignissim nisl.</p>
                                    </div>
                                </div>
                                <div class="spacer_20"></div>

                                <div class="row">
                                    <div class="col-md-12">
                                        <h3 class="text-left"><strong>Daily Sermons</strong></h3>
                                        <p class="text-left">Nullam non efficitur purus. Sed vitae lorem vel arcu imperdiet ullamcorper. Ut quis odio est. In vestibulum dignissim nisl.</p>
                                    </div>
                                </div>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
    </section>


    <!-- SECTION: TESTIMONIALS -->
    <%--<section class="high-padding white-section">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <!-- TITLE + SUBTITLE section -->
                        <div class="relative section-header text-center animateIn" data-animate="fadeIn" style="opacity: 0;"> 
                            <h2 class="section-title">Contributor's Testimonials</h2>
                            <p>Testimonials are always a good source of quality infos.</p>
                        </div>
                        <!-- Testimonials -->
                        <div>
                            <div class="testimonials_slider owl-carousel owl-theme animateIn" data-animate="fadeIn" style="opacity: 0; display: block;">
                                <div class="owl-wrapper-outer"><div class="owl-wrapper" style="width: 5700px; left: 0px; display: block;"><div class="owl-item" style="width: 570px;"><div class="item">
                                    <div class="testimonial-content">
                                        <h4>
                                            <img src="img/testimonials/1-wide.jpg" alt="">
                                            <span class="testimonial-author">Jacob Luiz</span> <span class="testimonial-job">- Gold Donor</span>
                                        </h4>
                                        <p>When faith and hope fail, as they do sometimes, we must try charity, which is love in action. We must speculate no more on our duty, but simply do it. When we have done it, however blindly, perhaps Heaven will show us why.</p>
                                    </div>
                                </div></div><div class="owl-item" style="width: 570px;"><div class="item">
                                    <div class="testimonial-content">
                                        <h4>
                                            <img src="img/testimonials/2.jpg" alt="">
                                            <span class="testimonial-author">Jacob Luiz</span> <span class="testimonial-job">- Platinum Donor</span>
                                        </h4>
                                        <p>When faith and hope fail, as they do sometimes, we must try charity, which is love in action. We must speculate no more on our duty, but simply do it. When we have done it, however blindly, perhaps Heaven will show us why.</p>
                                    </div>
                                </div></div><div class="owl-item" style="width: 570px;"><div class="item">
                                    <div class="testimonial-content">
                                        <h4>
                                            <img src="img/testimonials/3.jpg" alt="">
                                            <span class="testimonial-author">Jacob Luiz</span> <span class="testimonial-job">- Diamond Donor</span>
                                        </h4>
                                        <p>When faith and hope fail, as they do sometimes, we must try charity, which is love in action. We must speculate no more on our duty, but simply do it. When we have done it, however blindly, perhaps Heaven will show us why.</p>
                                    </div>
                                </div></div><div class="owl-item" style="width: 570px;"><div class="item">
                                    <div class="testimonial-content">
                                        <h4>
                                            <img src="img/testimonials/2.jpg" alt="">
                                            <span class="testimonial-author">Jacob Luiz</span> <span class="testimonial-job">- Starter Donor</span>
                                        </h4>
                                        <p>When faith and hope fail, as they do sometimes, we must try charity, which is love in action. We must speculate no more on our duty, but simply do it. When we have done it, however blindly, perhaps Heaven will show us why.</p>
                                    </div>
                                </div></div><div class="owl-item" style="width: 570px;"><div class="item">
                                    <div class="testimonial-content">
                                        <h4>
                                            <img src="img/testimonials/3.jpg" alt="">
                                            <span class="testimonial-author">Jacob Luiz</span> <span class="testimonial-job">- Charity Donor</span>
                                        </h4>
                                        <p>When faith and hope fail, as they do sometimes, we must try charity, which is love in action. We must speculate no more on our duty, but simply do it. When we have done it, however blindly, perhaps Heaven will show us why.</p>
                                    </div>
                                </div></div></div></div>
                                
                                
                                
                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>--%>


    <%-- <section class="high-padding gray-section section-bg" data-image-src="img/header-banners/semitransparent_blog-min.png" style="background-image: url(&quot;img/header-banners/semitransparent_blog-min.png&quot;);">
            <div class="container">
                <!-- TITLE + SUBTITLE section -->
                <div class="relative section-header animateIn" data-animate="fadeIn" style="opacity: 0;"> 
                    <h2 class="section-title">From The Blog</h2>
                    <p>Blogging is now made easy using Church HTML Template! Share the news and press<br> releases to your focus group and complete charity causes using donations.</p>
                </div>
                <!-- Blog posts section -->
                <div class="items-wrap blog_posts_list blog-posts-shortcode">
                    <div class="posts-list grid">
                        <div class="row">
                            <div class="col-md-4">
                                <div class="row">
                                    <div class="single-post clearfix animateIn" data-animate="fadeIn" style="opacity: 0;">
                                        <div class="col-md-12 post-thumbnail">
                                            <figure class="effect-lexi">
                                                <img src="img/content/blogpost_01.jpg" alt="">
                                                <figcaption>
                                                    <i class="icon-arrow-right-circle"></i>
                                                </figcaption>           
                                            </figure>
                                        </div>
                                        <div class="col-md-12 post-details">
                                            <div class="post-details-holder">
                                                <h3 class="post-title text-center"><a href="blog-article.html">The Priest is Sent by God for You</a></h3>
                                                <div class="more-post-details text-center">
                                                    <a class="more-link" href="blog-article.html"><i class="icon-user"></i> Pope Franciss</a>
                                                    <a class="more-link" href="blog-article.html"><i class="icon-clock"></i> 12/01/2017</a>
                                                </div>
                                                <p class="post-excerpt text-center">Nam auctor id nisi ut tempus. Aenean pulvinar ex sit amet dolor euismod.</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div> 
                            <div class="col-md-4">
                                <div class="row">
                                    <div class="single-post clearfix animateIn" data-animate="fadeIn" style="opacity: 0;">
                                        <div class="col-md-12 post-thumbnail">
                                            <figure class="effect-lexi">
                                                <img src="img/content/blogpost_02.jpg" alt="">
                                                <figcaption>
                                                    <i class="icon-arrow-right-circle"></i>
                                                </figcaption>           
                                            </figure>
                                        </div>
                                        <div class="col-md-12 post-details">
                                            <div class="post-details-holder">
                                                <h3 class="post-title text-center"><a href="blog-article.html">Jesus = Faith in Humanity = Love</a></h3>
                                                <div class="more-post-details text-center">
                                                    <a class="more-link" href="blog-article.html"><i class="icon-user"></i> Pope Franciss</a>
                                                    <a class="more-link" href="blog-article.html"><i class="icon-clock"></i> 12/01/2017</a>
                                                </div>
                                                <p class="post-excerpt text-center">Nam auctor id nisi ut tempus. Aenean pulvinar ex sit amet dolor euismod.</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="row">
                                    <div class="single-post clearfix animateIn" data-animate="fadeIn" style="opacity: 0;">
                                        <div class="col-md-12 post-thumbnail">
                                            <figure class="effect-lexi">
                                                <img src="img/content/blogpost_03.jpg" alt="">
                                                <figcaption>
                                                    <i class="icon-arrow-right-circle"></i>
                                                </figcaption>           
                                            </figure>
                                        </div>
                                        <div class="col-md-12 post-details">
                                            <div class="post-details-holder">
                                                <h3 class="post-title text-center"><a href="blog-article.html">Leviticus 14:12: Take the one male lamb</a></h3>
                                                <div class="more-post-details text-center">
                                                    <a class="more-link" href="blog-article.html"><i class="icon-user"></i> Pope Franciss</a>
                                                    <a class="more-link" href="blog-article.html"><i class="icon-clock"></i> 12/01/2017</a>
                                                </div>
                                                <p class="post-excerpt text-center">Nam auctor id nisi ut tempus. Aenean pulvinar ex sit amet dolor euismod.</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>                                
                        </div>
                    </div>
                </div>    
            </div>
        </section>--%>


    <section class="high-padding white-section section-bg" data-image-src="img/header-banners/overlay_MEMBERS-min.png" style="background-image: url(&quot;img/header-banners/overlay_MEMBERS-min.png&quot;);">
        <div class="container">
            <!-- TITLE + SUBTITLE section -->
            <%=sHTMLDestaques4%>
            <%--     <div class="relative section-header animateIn" data-animate="fadeIn" style="opacity: 0;"> 
                    <h2 class="section-title">Our Church Members</h2>
                    <p>Volunteering is now made easy using Church HTML Template! Share the news and press releases<br> to your focus group and complete charity causes using donations.</p>
                </div>
                <!-- Blog posts section -->
                <div class="items-wrap blog_posts_list blog-posts-shortcode">
                    <div class="posts-list grid">
                        <div class="row">--%>
            <%-- <div class="col-md-3 text-center">
                                <div class="row">
                                    <img src="img/members/member_05-1.jpg" class="img-circle width_80" alt="">
                                    <div class="team-member-text text-center width_90">
                                        <h3 class="team-member-title">John Marcus</h3>
                                        <div class="team-member-position">The Priest</div>
                                        <p class="team-member-details">Duis vel nibh at velit scelerisque suscipit. Curabitur blandit mollis lacus. Proin viverra</p>
                                    </div>
                                </div>
                            </div> --%>
            <%-- <div class="col-md-3 text-center">
                                <div class="row">
                                    <img src="img/members/member_05-3.jpg" class="img-circle width_80" alt="">
                                    <div class="team-member-text text-center width_90">
                                        <h3 class="team-member-title">Maria Herrzi</h3>
                                        <div class="team-member-position">The Priestess</div>
                                        <p class="team-member-details">Duis vel nibh at velit scelerisque suscipit. Curabitur blandit mollis lacus. Proin viverra</p>
                                    </div>
                                </div>
                            </div> --%>
            <%--<div class="col-md-3 text-center">
                                <div class="row">
                                    <img src="img/members/member_05-4.jpg" class="img-circle width_80" alt="">
                                    <div class="team-member-text text-center width_90">
                                        <h3 class="team-member-title">Derek &amp; Maria</h3>
                                        <div class="team-member-position">Youngest Members</div>
                                        <p class="team-member-details">Duis vel nibh at velit scelerisque suscipit. Curabitur blandit mollis lacus. Proin viverra</p>
                                    </div>
                                </div>
                            </div> --%>
            <%-- <div class="col-md-3 text-center">
                                <div class="row">
                                    <img src="img/members/member_05-6.jpg" class="img-circle width_80" alt="">
                                    <div class="team-member-text text-center width_90">
                                        <h3 class="team-member-title">Lois Defoa</h3>
                                        <div class="team-member-position">Teenagers Assistant</div>
                                        <p class="team-member-details">Duis vel nibh at velit scelerisque suscipit. Curabitur blandit mollis lacus. Proin viverra</p>
                                    </div>
                                </div>
                            </div> --%>
        </div>
        </div>
    </div>    
            </div>
    </section>


    <!-- SECTION: OUR WORK -->
    <%--  <section class="section-bg" data-image-src="img/header-banners/holyspirit_wordpress_theme_themeslr-41.jpg" style="background-image: url(&quot;img/header-banners/holyspirit_wordpress_theme_themeslr-41.jpg&quot;);">

            <!-- HEADER CONTENT -->
            <div class="amaezi_header_content">
                <h3 class="amaezi_header_title">Psalms, Verses &amp; Ministries</h3>
                <div class="spacer_10"></div>
                <p class="amaezi_header_subtitle">Achievements are now made easy using Church HTML Template! Share the news and press releases to your focus group and complete causes using donations.</p>
                <div class="spacer_50"></div>

                <div class="container">
                    <div class="row">
                        <div class="col-md-5">
                            <div class="panel-group" id="accordion">
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapse-accordion-1">1 Chronicles 16:11</a>
                                        </h4>
                                    </div>
                                    <div id="collapse-accordion-1" class="panel-collapse collapse in">
                                        <div class="panel-body">
                                            <p><strong>11: </strong>"For I know the plans I have for you," declares the LORD, "plans to prosper you and not to harm you, plans to give you hope and a future."</p>
                                            <p><strong>14: </strong>"I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD, "and will bring you back to the place from which I carried you into exile."</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapse-accordion-2">John 3:16</a>
                                        </h4>
                                    </div>
                                    <div id="collapse-accordion-2" class="panel-collapse collapse">
                                        <div class="panel-body">
                                            <p><strong>11: </strong>"For I know the plans I have for you," declares the LORD, "plans to prosper you and not to harm you, plans to give you hope and a future."</p>
                                            <p><strong>14: </strong>"I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD, "and will bring you back to the place from which I carried you into exile."</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapse-accordion-3">Luke 6:31</a>
                                        </h4>
                                    </div>
                                    <div id="collapse-accordion-3" class="panel-collapse collapse">
                                        <div class="panel-body">
                                            <p><strong>11: </strong>"For I know the plans I have for you," declares the LORD, "plans to prosper you and not to harm you, plans to give you hope and a future."</p>
                                            <p><strong>14: </strong>"I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD, "and will bring you back to the place from which I carried you into exile."</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapse-accordion-4">Matthew 5:14</a>
                                        </h4>
                                    </div>
                                    <div id="collapse-accordion-4" class="panel-collapse collapse">
                                        <div class="panel-body">
                                            <p><strong>11: </strong>"For I know the plans I have for you," declares the LORD, "plans to prosper you and not to harm you, plans to give you hope and a future."</p>
                                            <p><strong>14: </strong>"I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD, "and will bring you back to the place from which I carried you into exile."</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapse-accordion-5">Proverbs 3:5</a>
                                        </h4>
                                    </div>
                                    <div id="collapse-accordion-5" class="panel-collapse collapse">
                                        <div class="panel-body">
                                            <p><strong>11: </strong>"For I know the plans I have for you," declares the LORD, "plans to prosper you and not to harm you, plans to give you hope and a future."</p>
                                            <p><strong>14: </strong>"I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD, "and will bring you back to the place from which I carried you into exile."</p>
                                        </div>
                                    </div>
                                </div>
                                <div class="panel panel-default">
                                    <div class="panel-heading">
                                        <h4 class="panel-title">
                                            <a class="accordion-toggle collapsed" data-toggle="collapse" data-parent="#accordion" href="#collapse-accordion-6">Psalm 119:105</a>
                                        </h4>
                                    </div>
                                    <div id="collapse-accordion-6" class="panel-collapse collapse">
                                        <div class="panel-body">
                                            <p><strong>14: </strong>"I will be found by you," declares the LORD, "and will bring you back from captivity. I will gather you from all the nations and places where I have banished you," declares the LORD, "and will bring you back to the place from which I carried you into exile."</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- STARTING TABS -->
                        <div class="tabs tabs-style-flip col-md-7">
                            <nav>
                                <ul>
                                    <li class="tab-current"><a href="#section-tab-1"><i class="icon-heart icons"></i> <span>Donate</span></a></li>
                                    <li><a href="#section-tab-2"><i class="icon-calendar icons"></i> <span>Events</span></a></li>
                                    <li><a href="#section-tab-3"><i class="icon-list icons"></i> <span>Shop Goodies</span></a></li>
                                </ul>
                            </nav>
                            <div class="content-wrap">
                                <section id="section-tab-1" class="content-current">
                                    <h3><strong>Join the Church. Be Unite!</strong></h3>
                                    <p>Donec orci lectus, aliquam ut, faucibus non, euismod id, nulla. Fusce fermentum odio nec arcu integer tincidunt cras ultricies sem orci lectus</p>
                                    <p>Aliquam ut, faucibus non, aliquam ut, faucibus non faucibus non, euismod id, nulla. Fusce fermentum odio</p>
                                    <div class="spacer_10"></div>
                                    <img src="img/gallery/3.jpg" alt="">
                                </section>
                                <section id="section-tab-2">
                                    <h3><strong>19th of June - Church Sermons</strong></h3>
                                    <p>Donec orci lectus, aliquam ut, faucibus non, euismod id, nulla. Fusce fermentum odio nec arcu integer tincidunt cras ultricies sem orci lectus, aliquam ut, faucibus non, aliquam ut.</p>
                                    <h3><strong>1rd of September - Ministries</strong></h3>
                                    <p>Cras ultricies sem orci lectus, aliquam ut, faucibus non, aliquam ut onec orci lectus, aliquam ut, faucibus non, euismod id, nulla. Fusce fermentum odio nec arcu integer tincidunt.</p>
                                    <div class="spacer_10"></div>
                                    <img src="img/gallery/1.jpg" alt="">
                                </section>
                                <section id="section-tab-3">
                                    <h3><strong>Shop Goodies from our Boutique!</strong></h3>
                                    <p>Donec orci lectus, aliquam ut, faucibus non, euismod id, nulla. Fusce fermentum odio nec arcu integer tincidunt cras ultricies sem orci lectus, aliquam ut, faucibus non, aliquam ut, faucibus non faucibus non, euismod id, nulla.</p>
                                    <div class="spacer_10"></div>
                                    <img src="img/gallery/5-wide.jpg" alt="">
                                </section>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>--%>
    <%-- Seção de Galeria --%>

    <section class="white-section high-padding">
        <div class="container">
            <!-- Blog posts section -->
            <div class="items-wrap blog_posts_list blog-posts-shortcode gallery-posts-shortcode animateIn animated fadeIn" data-animate="fadeIn" style="opacity: 100;">
                <div class="posts-list grid">
                    <div class="row">
                        <%=sHTMLDestaques5 %>
                        <%-- <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/1.jpg" alt="">
                                <figcaption>
                                    <p>Help Parrots <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/1.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>          
                            </figure>
                            <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/1.jpg" alt="">
                                <figcaption>
                                    <p>Dog Surgery <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/1.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>          
                            </figure>
                            <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/3.jpg" alt="">
                                <figcaption>
                                    <p>GoFund Family <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/3.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>          
                            </figure>
                            <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/1.jpg" alt="">
                                <figcaption>
                                    <p>Family Together <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/1.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>  
                            </figure>
                            <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/1.jpg" alt="">
                                <figcaption>
                                    <p>Africa Childs <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/1.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>          
                            </figure>
                            <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/1.jpg" alt="">
                                <figcaption>
                                    <p>Poor Children <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/1.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>          
                            </figure>
                            <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/1.jpg" alt="">
                                <figcaption>
                                    <p>Poor Children <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/1.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>          
                            </figure>
                            <figure class="lift-thumbnail blog_post col-md-3">
                                <img src="img/gallery/1.jpg" alt="">
                                <figcaption>
                                    <p>Poor Children <i class="icon-size-fullscreen"></i></p>
                                    <a class="swipebox" href="img/gallery/8.jpg"></a>
                                    <div class="love-post">
                                        <i class="fa fa-heart-o" data-original-title="Love post" data-placement="right" data-toggle="tooltip"></i>
                                        <i class="fa fa-heart" data-original-title="Loved" data-placement="right" data-toggle="tooltip"></i>
                                    </div>
                                </figcaption>          
                            </figure>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <%-- Fim galeria  --%>

    <!-- SECTION: INSTAGRAM FEED -->
    <%--<section>
        <div id="tslr_instagram_feed" class="tslr_instagram_feed row">
            <%=sHTMLDestaques5 %>--%>
    <%-- <div class="item col-md-2 no_gap">
                    <div class="instagram_group">
                        <a target="_blank" href="#">
                            <div class="instagram_overlay">
                                <i class="icon-social-instagram icons"></i>
                            </div>
                            <img alt="" src="img/instagram-feed/insta_01.jpg">
                        </a>
                    </div>
                </div>
                <div class="item col-md-2 no_gap">
                    <div class="instagram_group">
                        <a target="_blank" href="#">
                            <div class="instagram_overlay">
                                <i class="icon-social-instagram icons"></i>
                            </div>
                            <img alt="" src="img/instagram-feed/insta_02.jpg">
                        </a>
                    </div>
                </div>
                <div class="item col-md-2 no_gap">
                    <div class="instagram_group">
                        <a target="_blank" href="#">
                            <div class="instagram_overlay">
                                <i class="icon-social-instagram icons"></i>
                            </div>
                            <img alt="" src="img/instagram-feed/insta_03.jpg">
                        </a>
                    </div>
                </div>
                <div class="item col-md-2 no_gap">
                    <div class="instagram_group">
                        <a target="_blank" href="#">
                            <div class="instagram_overlay">
                                <i class="icon-social-instagram icons"></i>
                            </div>
                            <img alt="" src="img/instagram-feed/insta_04.jpg">
                        </a>
                    </div>
                </div>
                <div class="item col-md-2 no_gap">
                    <div class="instagram_group">
                        <a target="_blank" href="#">
                            <div class="instagram_overlay">
                                <i class="icon-social-instagram icons"></i>
                            </div>
                            <img alt="" src="img/instagram-feed/insta_05.jpg">
                        </a>
                    </div>
                </div>
                <div class="item col-md-2 no_gap">
                    <div class="instagram_group">
                        <a target="_blank" href="#">
                            <div class="instagram_overlay">
                                <i class="icon-social-instagram icons"></i>
                            </div>
                            <img alt="" src="img/instagram-feed/insta_06.jpg">
                        </a>
                    </div>
                </div>--%>
    <%--   </div>
    </section>--%>



    <!-- FOOTER -->
    <footer class="footer">
        <div class="row footer-top animateIn" data-animate="fadeIn" style="opacity: 0;">
            <div class="container">
                <%=sHTMLDestaques6 %>
                <%--<div class="high-padding row">--%>
                <%--<div class="widget widget_text col-md-6">
                        <a href="#" class="footer-logo">
                            <img src="img/theme_logo_light.png" alt="">
                        </a>
                        <div class="spacer_10"></div>

                        <p>Church HTML lectus vitae convallis. Ut ipsum enim, consectetur at lobortis at, sagittis vel nisl. Nam non maximus elit, at sollicitudin mi. Donec ut tortor varius, feugiat ante venenatis, efficitur mauris. </p>
                        <p>Sagittis vel nisl. Nam non maximus elit, at sollicitudin mi. Donec ut tortor varius, feugiat ante venenatis, efficitur mauris. </p>
                        <div class="spacer_15"></div>

                        <!-- SOCIAL LINKS -->
                        <aside class="widget widget_social_links">
                            <div class="social_links">
                                <a href="#">
                                    <i class="fa fa-facebook"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-dribbble"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-stumbleupon"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-linkedin"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-instagram"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-google-plus"></i>
                                </a>
                                <a href="#">
                                    <i class="fa fa-twitter"></i>
                                </a>
                            </div>
                        </aside>
                    </div>--%>

                <div class="widget widget_nav_menu col-md-3">
                    <h3 class="widget-title row">Notícias Recentes</h3>
                    <ul class="widget_blog_posts row">
                        <%=sHTMLNoticiasRecentes %>
                        <%--<li>
                                <div class="col-md-3 no_gap post-thumbnail relative">
                                    <a href="#">
                                        <img alt="" class="img-rounded" src="img/content/fundraising_activism_33-70x70.jpg">
                                    </a>
                                </div>
                                <div class="col-md-9 post-details">
                                    <a href="#">New Education During National LMS Day</a>
                                    <div class="clearfix"></div>
                                    <span class="post-date">July 18, 2017</span>
                                </div>
                            </li>
                            <li>
                                <div class="col-md-3 no_gap post-thumbnail relative">
                                    <a href="#">
                                        <img alt="" class="img-rounded" src="img/content/fundraising_activism_11-70x70.jpg">
                                    </a>
                                </div>
                                <div class="col-md-9 post-details">
                                    <a href="#">Stitching Together A New Life</a>
                                    <div class="clearfix"></div>
                                    <span class="post-date">July 18, 2017</span>
                                </div>
                            </li>--%>
                    </ul>
                </div>
                <div class="widget widget_nav_menu col-md-3">
                    <h3 class="widget-title row">Sites Relacionados</h3>
                    <ul class="widget_blog_posts row">
                        <%=sHTMLsitesRelacionados %>
                        <%--<li>
                                <div class="col-md-3 no_gap post-thumbnail relative">
                                    <a href="#">
                                        <img alt="" class="img-rounded" src="img/content/fundraising_activism_33-70x70.jpg">
                                    </a>
                                </div>
                                <div class="col-md-9 post-details">
                                    <a href="#">New Education During National LMS Day</a>
                                    <div class="clearfix"></div>
                                    <span class="post-date">July 18, 2017</span>
                                </div>
                            </li>
                            <li>
                                <div class="col-md-3 no_gap post-thumbnail relative">
                                    <a href="#">
                                        <img alt="" class="img-rounded" src="img/content/fundraising_activism_11-70x70.jpg">
                                    </a>
                                </div>
                                <div class="col-md-9 post-details">
                                    <a href="#">Stitching Together A New Life</a>
                                    <div class="clearfix"></div>
                                    <span class="post-date">July 18, 2017</span>
                                </div>
                            </li>--%>
                    </ul>
                </div>
            </div>
        </div>
        </div>
        <div class="row footer-bottom">
            <a class="back-to-top-btn" href="#body">
                <i class="fa fa-angle-up"></i>
            </a>
            <div class="container">
                <div class="row animateIn" data-animate="fadeIn" style="opacity: 0;">
                    <%=sHTMLFooter %>
                    <%-- <div class="copyright-informations text-left col-md-6">
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
