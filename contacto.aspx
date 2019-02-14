<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="PIBLUANDA.contacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Contacte-nos</title>
    <meta charset="utf-8" />
    <meta name="format-detection" content="telephone=no" />
    <script async="" src="//www.googletagmanager.com/gtm.js?id=GTM-P9FT69"></script>
    <script src="/cdn-cgi/apps/head/3ts2ksMwXvKRuG480KNifJ2_JNM.js"></script>
    <script src="/cdn-cgi/apps/body/4o300efCt-CXoq1JEC-sVReFz48.js"></script>
    <link rel="icon" href="images/favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon" />
    <link rel="stylesheet" type="text/css" media="screen" href="css/style.css" />
    <link rel="stylesheet" type="text/css" media="screen" href="css/form.css" />
    <script type="text/javascript" src="js/jquery.js"></script>
    <script src="js/jquery-migrate-1.1.1.js"></script>
    <script src="js/script.js"></script>
    <script src="js/forms.js"></script>
    <meta name="viewport" content="width=device-width,initial-scale=1.0,user-scalable=0" />
    <script type="text/javascript" src="js/superfish.js"></script>
    <script type="text/javascript" src="js/jquery.mobilemenu.js"></script>
    <script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
    <script src="js/jquery.ui.totop.js"></script>
    <script>
        jQuery(function () {
            $().UItoTop({ easingType: 'easeOutQuart' });
        });
     </script>
    <!--[if lt IE 8]>
       <div style=' clear: both; text-align:center; position: relative;'>
         <a href="https://windows.microsoft.com/en-US/internet-explorer/products/ie/home?ocid=ie6_countdown_bannercode">
           <img src="https://storage.ie6countdown.com/assets/100/images/banners/warning_bar_0000_us.jpg" border="0" height="42" width="820" alt="You are using an outdated browser. For a faster, safer browsing experience, upgrade for free today." />
         </a>
      </div>
    <![endif]-->
    <!--[if lt IE 9]>
      <script src="js/html5shiv.js"></script>
      <link rel="stylesheet" type="text/css" media="screen" href="css/ie.css">

    <![endif]-->
    <link rel="stylesheet" href="data:text/css;charset=utf-8;base64,Y2xvdWRmbGFyZS1hcHBbYXBwLWlkPSJhLWJldHRlci1icm93c2VyIl0gewogIGRpc3BsYXk6IGJsb2NrOwogIGJhY2tncm91bmQ6ICM0NTQ4NGQ7CiAgY29sb3I6ICNmZmY7CiAgbGluZS1oZWlnaHQ6IDEuNDU7CiAgcG9zaXRpb246IGZpeGVkOwogIHotaW5kZXg6IDkwMDAwMDAwOwogIHRvcDogMDsKICBsZWZ0OiAwOwogIHJpZ2h0OiAwOwogIHBhZGRpbmc6IC41ZW0gMWVtOwogIHRleHQtYWxpZ246IGNlbnRlcjsKICAtd2Via2l0LXVzZXItc2VsZWN0OiBub25lOwogICAgIC1tb3otdXNlci1zZWxlY3Q6IG5vbmU7CiAgICAgIC1tcy11c2VyLXNlbGVjdDogbm9uZTsKICAgICAgICAgIHVzZXItc2VsZWN0OiBub25lOwp9CgpjbG91ZGZsYXJlLWFwcFthcHAtaWQ9ImEtYmV0dGVyLWJyb3dzZXIiXVtkYXRhLXZpc2liaWxpdHk9ImhpZGRlbiJdIHsKICBkaXNwbGF5OiBub25lOwp9CgpjbG91ZGZsYXJlLWFwcFthcHAtaWQ9ImEtYmV0dGVyLWJyb3dzZXIiXSBjbG91ZGZsYXJlLWFwcC1tZXNzYWdlIHsKICBkaXNwbGF5OiBibG9jazsKfQoKY2xvdWRmbGFyZS1hcHBbYXBwLWlkPSJhLWJldHRlci1icm93c2VyIl0gYSB7CiAgdGV4dC1kZWNvcmF0aW9uOiB1bmRlcmxpbmU7CiAgY29sb3I6ICNlYmViZjQ7Cn0KCmNsb3VkZmxhcmUtYXBwW2FwcC1pZD0iYS1iZXR0ZXItYnJvd3NlciJdIGE6aG92ZXIsCmNsb3VkZmxhcmUtYXBwW2FwcC1pZD0iYS1iZXR0ZXItYnJvd3NlciJdIGE6YWN0aXZlIHsKICBjb2xvcjogI2RiZGJlYjsKfQoKY2xvdWRmbGFyZS1hcHBbYXBwLWlkPSJhLWJldHRlci1icm93c2VyIl0gY2xvdWRmbGFyZS1hcHAtY2xvc2UgewogIGRpc3BsYXk6IGJsb2NrOwogIGN1cnNvcjogcG9pbnRlcjsKICBmb250LXNpemU6IDEuNWVtOwogIHBvc2l0aW9uOiBhYnNvbHV0ZTsKICByaWdodDogLjRlbTsKICB0b3A6IC4zNWVtOwogIGhlaWdodDogMWVtOwogIHdpZHRoOiAxZW07CiAgbGluZS1oZWlnaHQ6IDE7Cn0KCmNsb3VkZmxhcmUtYXBwW2FwcC1pZD0iYS1iZXR0ZXItYnJvd3NlciJdIGNsb3VkZmxhcmUtYXBwLWNsb3NlOmFjdGl2ZSB7CiAgLXdlYmtpdC10cmFuc2Zvcm06IHRyYW5zbGF0ZVkoMXB4KTsKICAgICAgICAgIHRyYW5zZm9ybTogdHJhbnNsYXRlWSgxcHgpOwp9CgpjbG91ZGZsYXJlLWFwcFthcHAtaWQ9ImEtYmV0dGVyLWJyb3dzZXIiXSBjbG91ZGZsYXJlLWFwcC1jbG9zZTpob3ZlciB7CiAgb3BhY2l0eTogLjllbTsKICBjb2xvcjogI2ZmZjsKfQo=" />
</head>
<body class="">
    <div class="page">
        <!--==============================header=================================-->
        <header class="mb0">
            <div class="container_12">
                <div class="grid_12">

                    <h1><a href="\">
                         <img src="images/logo.png" alt="Convenção Baptista de Angola" /></a> </h1>
                    <div class="links">
                        <strong><a href="#">Rua Comandante Kwenha nº14,R/C, 925 205 495</a>      <a href="contacto.aspx">Contacte-nos</a>
                        </strong>
                    </div>


                    <div class="clear"></div>

                    <div class="menu_block">
                        <nav>
                           <ul class="sf-menu sf-js-enabled">
                                <%=sHTMLMenu %>
                            </ul>
                        </nav>

                        <div class="clear"></div>
                    </div>

                </div>

                <div class="clear"></div>
            </div>

        </header>
        <!--==============================content================================-->
        <div class="content">
            <div class="container_12">
                <div class="grid_9">
                    <div class="pad1">
                        <h2>Onde Estamos</h2>
                        <div class="map">
                            <figure class="img_inner">
                                <iframe src="https://snazzymaps.com/embed/23609" width="600px" height="450px" style="border:none;"></iframe>
                            </figure>
                            Temos o maior prazer em ajudá-lo.Contacte-nos através do formulário.
               
                            <address>
                                <dl>
                                    <dt>
                                        <p>
                                            <strong class="upp">Livraria Baptista<br />
                                            Rua Comandante Kwenha nº 14, R/C<br />
                                            Caixa Postal 5129<br />
                                            Luanda, Angola</strong>
                                        </p>
                                    </dt>
                                    <dd><span>Telefone:</span>+244  925 205 495</dd>
                                   
                                    <dd>E-mail: &nbsp;&nbsp; <strong class="col1"><a href="#" class="link-1">cba@cba-angola.org</a></strong></dd>
                                </dl>
                            </address>

                        </div>
                    </div>
                </div>
                <div class="grid_3">
                    <h2>Contacte-nos</h2>
                    <form id="form">
                        <div class="success_wrapper">
                            <div class="success" style="display: none;">
                                Formulário Submetido com sucesso<br />
                                <strong>Entraremos em contacto consigo em breve.</strong>
                            </div>
                        </div>
                        <fieldset>
                            <label class="name invalid">
                                <input value="Nome:" type="text">
                                <br class="clear">
                                <span class="error error-empty" style="display: none;">*Nome inválido.</span><span class="empty error-empty" style="display: block;">*Preenchimento obrigatório.</span>
                            </label>
                            <label class="email invalid">
                                <input value="E-mail:" type="text">
                                <br class="clear">
                                <span class="error error-empty" style="display: none;">*Endereço de e-mail inválido.</span><span class="empty error-empty" style="display: block;">*Preenchimento obrigatório.</span>
                            </label>
                            <label class="phone invalid">
                                <input value="Telefone:" type="tel">
                                <br class="clear">
                                <span class="error error-empty" style="display: none;">*Número de telefone inválido.</span><span class="empty error-empty" style="display: block;">*Preenchimento obrigatório.</span>
                            </label>
                            <label class="message invalid">
                                <textarea>Mensagem:</textarea>
                                <br class="clear">
                                <span class="error" style="display: none;">*Mensagem muito curta.</span> <span class="empty" style="display: block;">*Preenchimento obrigatório.</span>
                            </label>
                            <div class="clear"></div>
                            <div class="btns">
                                <a data-type="submit" class="btn">Enviar</a>
                                <div class="clear"></div>
                            </div>
                        </fieldset>
                    </form>
                </div>
            </div>
        </div>
        <!--==============================footer=================================-->
    </div>
    <footer>
        <div class="container_12">
            <div class="grid_12">
                <%=sHTMLFooter %> <%=DateTime.Now.Year.ToString() %> <%=sHTMLLinkArtigoPoliticaPrivacidade %>
                <!--{%FOOTER_LINK} -->
            </div>

        </div>
    </footer>
      <a href="#" id="toTop" style="margin-right: -564px; right: 50%; display: none;"><span id="toTopHover"></span></a>
</body>
</html>
