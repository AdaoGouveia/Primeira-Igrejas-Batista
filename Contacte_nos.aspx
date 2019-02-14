<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contacte_nos.aspx.cs" Inherits="PIBLUANDA.Contacte_nos" %>

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

    <%=sHTMLContactos %>
    

    <form id="form1" runat="server" class="row make-reservation submit-contact animateIn animated fadeIn" data-animate="fadeIn" style="opacity: 100;" action="message.aspx" method="POST">
        <div class="col-md-6">
            <div class="contact-section">
                <div id="google-map" style="position: relative; overflow: hidden; height: 485px;">
                    <div style="height: 100%; width: 100%; position: absolute; top: 0px; left: 0px; background-color: rgb(229, 227, 223);">
                        <div class="gm-err-container">
                            <div class="gm-err-content">
                                <div class="gm-err-icon">
                                   <iframe src="https://snazzymaps.com/embed/25626" width="100%" height="550px" style="border:none;"></iframe>
                                    <%--  <img src="https://maps.gstatic.com/mapfiles/api-3/images/icon_error.png" draggable="false" style="user-select: none;" />--%>
                                </div>
                                <div class="gm-err-title">Ups! Ocorreu um erro.</div>
                                <div class="gm-err-message">Esta página não carregou corretamente o Google Maps. Consulte a Consola de JavaScript para obter detalhes técnicos.</div>
                            </div>
                        </div>
                    </div>
                </div>


            </div>
        </div>
        <div class="col-md-6">
            <div class="row">
                <div class="col-md-12">

                    <input runat="server" id="nome" type="text" name="nome" data-constraints="@Required" placeholder="Seu nome" class="form-control form-control-has-validation form-control-last-child" />

                    <asp:RequiredFieldValidator runat="server" ID="reqnome" Style='color: red' ControlToValidate="nome" Text="Preencha seu nome na caixa de texto a cima" Display="Dynamic" EnableClientScript="true" ValidationGroup="form"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" ID="cmpnome" Style='color: red' ControlToValidate="nome" ValueToCompare="Nome:" Type="String" Operator="NotEqual" Display="Dynamic" EnableClientScript="true" ValidationGroup="form" Text="Preencha seu nome na caixa de texto a cima"></asp:CompareValidator>

                   
                </div>
                <div class="col-md-12">
                     <input runat="server" id="email" type="text" name="email" data-constraints="@Required" placeholder="Seu E-mail"  class="form-control form-control-has-validation form-control-last-child" />
                     <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" Style='color: red' ControlToValidate="email" Text="Preencha seu E-mail na caixa de texto a cima" Display="Dynamic" EnableClientScript="true" ValidationGroup="form"></asp:RequiredFieldValidator>
             
                    <span class="form-validation"></span>
                    
                </div>
                <div class="col-md-6">
                    <input tabindex="4" type="text" placeholder="Seu contacto" id="telemovel" runat="server" class="form-control" />
                   <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" Style='color: red' ControlToValidate="telemovel" Text="Preencha seu contacto " Display="Dynamic" EnableClientScript="true" ValidationGroup="form"></asp:RequiredFieldValidator>
             

               
                </div>
             
                <div class="col-md-12">
                    <textarea tabindex="5" type="text" rows="5" cols="50" placeholder="Mensagem" id="mensagem" runat="server" class="form-control form-control-has-validation form-control-last-child"></textarea><span class="form-validation"></span>
                   <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" Style='color: red' ControlToValidate="mensagem" Text="Preencha seua mensagem na caixa de texto a cima" Display="Dynamic" EnableClientScript="true" ValidationGroup="form"></asp:RequiredFieldValidator>
             
                </div>

                <div class="col-md-12">

                    <asp:Button ID="btnenviar" runat="server" class="btn btn-danger fullwidth btn-lg unbordered right-side" Text="Enviar Mensagem" OnClientClick="apagaForm()" ValidationGroup="form" />

                    <%--<asp:Button ID="btnenviarmail" runat="server" OnClick="btnenviarmail_Click" Text="Enviar Mensagem" ValidationGroup="form" />--%>
                    <%--<button name="submit_contact" runat="server" class="btn btn-danger fullwidth btn-lg unbordered right-side" validationgroup="form" type="submit" onclick="apagaForm()">Enviar Mensagem<i class="icon-cursor"></i></button>--%>
                </div>
                <p class="success-message">Obrigado por nos contactar! Entraremos em contacto consigo o mas breve possivel!</p>

            </div>
        </div>
    </form>


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

<script>


    $('form').submit(function () {
        $(this)[1].reset();
    });

    function apagaForm() {
        if ((form1.nome.value != "") && (form1.email.value != "") && (form1.telemovel.value != "") && (form1.mensagem.value != "")) {
            alert("Obrigado por nos contactar! Entraremos em contacto consigo o mais breve possivel!");
        }

    }





    //$('form').submit(function () {
    //    $(this)[0].reset();
    //});

    //function MessageBoxSucesso() {
    //    $("#dialog-Sucesso").dialog({
    //        title: "PIB",
    //        resizable: false,
    //        width: 430,
    //        height: 200,
    //        modal: true,
    //        buttons: {
    //            "OK": function () {
    //                location.href = 'Contacte_nos.aspx'
    //                $(this).dialog("close");
    //                return true;
    //            }

    //        }


    //    });
    //    return false;
    //}

</script>

</html>
