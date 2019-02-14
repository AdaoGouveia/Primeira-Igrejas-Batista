using CMSCK.WEB.Comum;
using System.Data;
using System.Text;

namespace PIBLUANDA
{
    public partial class WebSite
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sClassifier"></param>
        /// <param name="Lingua"></param>
        /// <returns></returns>
        public string GetHTMLMenu(int sClassifier, int Lingua, string pageName)
        {
            StringBuilder sMenu = new StringBuilder();

            Service oService = new Service();
            DataTable dTableMenu = new DataTable();
            DataTable dTableSubMenu = new DataTable();


            dTableMenu = oService.FEGetClassificadorByPaiIDLingua(sClassifier, Lingua);
            for (int i = 0; i < dTableMenu.Rows.Count; i++)
            {
                dTableSubMenu = oService.FEGetClassificadorByPaiIDLingua((int)dTableMenu.Rows[i]["ClassificadorID"], Lingua);



                if (dTableMenu.Rows[i]["UrlTemplate"].ToString().ToLower() == pageName)
                    sMenu.Append("<li class=\"current\"><a " + (dTableSubMenu.Rows.Count > 0 ? "class=\"dropdown\"" : "") + " href=\"" + dTableMenu.Rows[i]["UrlTemplate"] + "\">" + dTableMenu.Rows[i]["Nome"] + (dTableSubMenu.Rows.Count > 0 ? " <span class=\"menu-arrow\"></span>" : "") + "</a></li>");
                else
                    sMenu.Append("<li " + (dTableSubMenu.Rows.Count > 0 ? "class=\"dropdown\"" : "") + "><a " + (dTableSubMenu.Rows.Count > 0 ? "class=\"dropdown-toggle\" data-toggle=\"dropdown\" role=\"button\" aria-haspopup=\"true\" aria-expanded=\"false\"" : "") + " href=\"" + dTableMenu.Rows[i]["UrlTemplate"] + "\">" + dTableMenu.Rows[i]["Nome"] + (dTableSubMenu.Rows.Count > 0 ? " <span class=\"menu-arrow\"></span>" : "") + "</a>");

                sMenu.Append((dTableSubMenu.Rows.Count > 0 ? "" : "</li>"));

                if (dTableSubMenu.Rows.Count > 0)
                {
                    sMenu.Append("<ul class=\"dropdown-menu\">");
                }

                for (int j = 0; j < dTableSubMenu.Rows.Count; j++)
                {
                    sMenu.Append("<li><a href=\"" + dTableSubMenu.Rows[j]["UrlTemplate"] + "\"><i " + (dTableSubMenu.Rows[j]["Descricao"].ToString() != string.Empty ? "class=\"" + dTableSubMenu.Rows[j]["Descricao"] + "\"" : "class=\"icon-list icons\"") + " ></i>" + dTableSubMenu.Rows[j]["Nome"] + "</a></li>");

                }

                if (dTableSubMenu.Rows.Count > 0)
                {
                    sMenu.Append("</ul>");
                }

                sMenu.Append((dTableSubMenu.Rows.Count > 0 ? "</li>" : ""));

            }

            return sMenu.ToString();
        }


        //HOMEPAGE
        public string GetHTMLBanner(int sClassifier, int Lingua)
        {
            StringBuilder sBanner = new StringBuilder();
            Service oService = new Service();
            DataTable dTableBanner = new DataTable();

            dTableBanner = oService.FEGetListConteudoClassificador((int)CMSCK.WEB.Comum.ContentType.Banner, sClassifier, Lingua);

            for (int i = 0; i < dTableBanner.Rows.Count; i++)
            {


                //***************************************


                sBanner.Append("<img src =\"uploads/" + dTableBanner.Rows[i]["Media"] + "\" alt=\"\" class=\"slide-image\">");
                sBanner.Append(" !--<div class=\"bs-slider-overlay\"></div> -->");
                sBanner.Append("<div class=\"container\">");
                sBanner.Append("<div class=\"row\">");
                sBanner.Append("<!-- Slide Text Layer --> ");
                sBanner.Append("<div class=\"slide-text slide_style_left slide_style_top15\">");
                sBanner.Append("<div class=\"col-md-6\">");
                sBanner.Append("<h1 data-animation=\"animated fadeIn\" class=\"\">" + dTableBanner.Rows[i]["Titulo"] + "</h1>");
                sBanner.Append("<p data-animation=\"animated fadeIn\" class=\"\">" + dTableBanner.Rows[i]["SubTitulo"] + " </p>");
                sBanner.Append("</div>");
                sBanner.Append("</div>");
                sBanner.Append("</div>");
                sBanner.Append("</div>");


                //*********************************************





            }

            return sBanner.ToString();
        }
        public string GetHTMLBanner2(int sClassifier, int Lingua)
        {
            StringBuilder sBanner = new StringBuilder();
            Service oService = new Service();
            DataTable dTableBanner = new DataTable();

            dTableBanner = oService.FEGetListConteudoClassificador((int)CMSCK.WEB.Comum.ContentType.Banner, sClassifier, Lingua);

            for (int i = 0; i < dTableBanner.Rows.Count; i++)
            {


                //***************************************


                sBanner.Append("<img src =\"uploads/" + dTableBanner.Rows[i]["Media"] + "\" alt=\"\" class=\"slide-image\">");
                sBanner.Append("<!-- <div class=\"bs-slider-overlay\"></div> -->");
                sBanner.Append("<div class=\"slide-text slide_style_right slide_style_top15\">");
                sBanner.Append("<div class=\"col-md-6 col-md-offset-6\">");
                sBanner.Append("<h1 data-animation=\"animated fadeIn\">" + dTableBanner.Rows[i]["Titulo"] + "</h1><br>");              
                sBanner.Append("<p data-animation= \"animated fadeIn\" > " + dTableBanner.Rows[i]["SubTitulo"] + "<br>");
                sBanner.Append("</div>");
                sBanner.Append("</div>");




                //*********************************************





            }

            return sBanner.ToString();
        }
        public string GetHTMLBanner3(int sClassifier, int Lingua)
        {
            StringBuilder sBanner = new StringBuilder();
            Service oService = new Service();
            DataTable dTableBanner = new DataTable();

            dTableBanner = oService.FEGetListConteudoClassificador((int)CMSCK.WEB.Comum.ContentType.Banner, sClassifier, Lingua);

            for (int i = 0; i < dTableBanner.Rows.Count; i++)
            {


                //***************************************
                sBanner.Append("<img src =\"uploads/" + dTableBanner.Rows[i]["Media"] + "\" alt=\"\" class=\"slide-image\">");
                sBanner.Append("<!-- <div class=\"bs-slider-overlay\"></div> -->");

                sBanner.Append("<div class=\"container\">");
                sBanner.Append("<div class=\"row\">");
                sBanner.Append("<!-- Slide Text Layer -->");
                sBanner.Append("<div class=\"slide-text slide_style_left slide_style_top15\">");
                sBanner.Append("<div class=\"col-md-6\">");
                sBanner.Append("<h1 data-animation=\"animated fadeIn\">" + dTableBanner.Rows[i]["Titulo"] + "</h1><br>");
                sBanner.Append("<p data-animation= \"animated fadeIn\">" + dTableBanner.Rows[i]["SubTitulo"] + "<br>");
                sBanner.Append("</div>");
                sBanner.Append("</div>");
                sBanner.Append("</div>");
                sBanner.Append("</div>");





                //*********************************************





            }

            return sBanner.ToString();
        }
        public string GetHTMLDestaques(int sClassifier, int Lingua, string pageName)
        {
            StringBuilder sDestaque = new StringBuilder();

            Service oService = new Service();
            DataTable dTableDestaque = new DataTable();
            DataTable dTableArtigoTemp = new DataTable();
            string sArtigoIDTemp = string.Empty;

            dTableDestaque = oService.FEGetClassificadorByPaiIDLingua(sClassifier, Lingua);
            for (int i = 0; i < dTableDestaque.Rows.Count; i++)
            {


                dTableArtigoTemp = oService.FEGetListConteudoClassificador((int)CMSCK.WEB.Comum.ContentType.Artigo, int.Parse(dTableDestaque.Rows[i]["ClassificadorID"].ToString()), Lingua);
                sArtigoIDTemp = (dTableArtigoTemp.Rows.Count > 0 ? dTableArtigoTemp.Rows[0]["ArtigoID"].ToString() : "");

                sDestaque.Append("<div class=\"grid_3\">");
                sDestaque.Append("<div class=\"pad1\">");
                sDestaque.Append("<h2>" + dTableDestaque.Rows[i]["Nome"] + "</h2>");
                sDestaque.Append(dTableDestaque.Rows[i]["Descricao"] + "<br>");
                sDestaque.Append("<a href=\"detalheartigo.aspx?aid=" + sArtigoIDTemp + "\" class=\"btn\">Mais</a>");
                sDestaque.Append("</div>");
                sDestaque.Append("</div>");
            }
            return sDestaque.ToString();
        }

        public string GetHTMLDestaques1(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Link, sClassifier, Lingua);


            dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {

                sDestaques.Append("<div class=\"relative section-header\"> ");
                sDestaques.Append(" <h2 class=\"section-title\">" + dTable2.Rows[0]["Nome"] + "</h2>");
                sDestaques.Append("<p>" + dTable2.Rows[0]["Descricao"] + " </p>");
                sDestaques.Append("</div>");

                //sDestaques.Append("<div class=\"relative section-header animateIn\" data-animate=\"fadeIn\" style=\"opacity: 0; \">");
                //sDestaques.Append("<h2 class=\"section-title\">" + dTable2.Rows[0]["Nome"] + "</h2>");
                //sDestaques.Append("<p>" + dTable2.Rows[0]["Descricao"] + "</p>");
                //sDestaques.Append("</div>");

                //sDestaques.Append("<div class=\"items-wrap blog_posts_list blog-posts-shortcode\">");
                //sDestaques.Append("<div class=\"posts-list grid\">");
                //sDestaques.Append("<div class=\"row\">");




                //sDestaques.Append("<div class=\"shell\">");
                //sDestaques.Append("<h3 class=\" text-gray-base text-center\">" + dTable2.Rows[0]["Descricao"] + "</h3>");

                //sDestaques1.Append("<div class=\"cell-sm-4 cell-md-4\">");
                //sDestaques1.Append("<h6 class=\"text-white\">" + dTable2.Rows[0]["Descricao"] + "</h6>");
            }




            for (int i = 0; i < dTable.Rows.Count; i++)
            {


                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"col-md-6 text-center\">");
                sDestaques.Append("<div class=\"spacer_10\"></div>");
                sDestaques.Append("<h2>" + dTable.Rows[i]["Titulo"] + "</h2>");

                sDestaques.Append("<p>" + dTable.Rows[i]["SubTitulo"] + "</p> ");
                sDestaques.Append("</div>");
                sDestaques.Append("<div class=\"col-md-6\">");
                sDestaques.Append("<div class=\"embed-responsive embed-responsive-16by9\">");

                sDestaques.Append("<iframe class=\"embed-responsive-item\" src=\"" + dTable.Rows[i]["url"] + "\" ></iframe>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");



                //sDestaques.Append("<div class=\"col-md-3 text-center\">");
                //sDestaques.Append("<div class=\"row\">");
                //sDestaques.Append("<img src = \"uploads/" + dTable.Rows[i]["Media"] + "\" class=\"img-circle width_80\" alt=\"\">");
                //sDestaques.Append("<div class=\"team-member-text text-center width_90\">");
                //sDestaques.Append("<h3 class=\"team-member-title\">" + dTable.Rows[i]["Titulo"] + "</h3>");
                //sDestaques.Append("<div class=\"team-member-position\"></div>");
                //sDestaques.Append("<p class=\"team-member-details\">" + dTable.Rows[i]["SubTitulo"] + "</p>");
                //sDestaques.Append("</div>");
                //sDestaques.Append("</div>");
                //sDestaques.Append("</div> ");





            }



            return sDestaques.ToString();
        }
        public string GetHTMLDestaques2(int sClassifier, int Lingua)
        {
            StringBuilder sDestaque = new StringBuilder();

            Service oService = new Service();
            DataTable dTableDestaque = new DataTable();
            DataTable dTableArtigoTemp = new DataTable();
            string sArtigoIDTemp = string.Empty;

            dTableDestaque = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);
            for (int i = 0; i < dTableDestaque.Rows.Count; i++)
            {

                sDestaque.Append("<section class=\"section-bg\"data-image-src=\"uploads/" + dTableDestaque.Rows[i]["Media"] + "\" style=\"background-image: url(&quot;uploads/" + dTableDestaque.Rows[i]["Media"] + "&quot;);\">");
                sDestaque.Append("<div class=\"amaezi_header_content light-texts\">");
                sDestaque.Append("<h3 class=\"amaezi_header_title\">" + dTableDestaque.Rows[i]["Titulo"] + "</h3>");
                sDestaque.Append("<div class=\"spacer_30\"></div>");
                sDestaque.Append("<p class=\"amaezi_header_subtitle\">" + dTableDestaque.Rows[i]["SubTitulo"] + " </p>");

            }
            return sDestaque.ToString();
        }

        public string GetHTMLDestaques3(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);


            //dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            //for (int i = 0; i < dTable2.Rows.Count; i++)
            //{

            //    sDestaques.Append("<div class=\"col-md-8\">");
            //    sDestaques.Append("<div class=\"row\">");
            //    sDestaques.Append("<div class=\"col-md-12 text-center\">");
            //    sDestaques.Append("<img src=\"uploads/" + dTable2.Rows[i]["Media"] + "\" alt=\"\" class=\"img-rounded\">");
            //    sDestaques.Append("</div>");
            //    sDestaques.Append("</div>");
            //    sDestaques.Append("</div>");

            //    //sDestaques.Append("<div class=\"shell\">");
            //    //sDestaques.Append("<h3 class=\" text-gray-base text-center\">" + dTable2.Rows[0]["Descricao"] + "</h3>");

            //    //sDestaques1.Append("<div class=\"cell-sm-4 cell-md-4\">");
            //    //sDestaques1.Append("<h6 class=\"text-white\">" + dTable2.Rows[0]["Descricao"] + "</h6>");
            //}




            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                sDestaques.Append("<div class=\"col-md-8\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"col-md-12 text-center\">");
                sDestaques.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\" alt=\"\" class=\"img-rounded\">");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");

                sDestaques.Append("<div class=\"col-md-4\">");
                //sDestaques.Append("<div class=\"spacer_20\"></div>");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"col-md-12\">");
                sDestaques.Append("<h3 class=\"text-left\"><strong>" + dTable.Rows[i]["Titulo"] + "</strong></h3>");
                sDestaques.Append("<p class=\"text-left\">" + dTable.Rows[i]["SubTitulo"] + "</p>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");


            }



            return sDestaques.ToString();
        }

        public string GetHTMLDestaques4(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);


            dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {
                sDestaques.Append("<div class=\"relative section-header animateIn\" data-animate=\"fadeIn\" style=\"opacity: 0; \">");
                sDestaques.Append("<h2 class=\"section-title\">" + dTable2.Rows[0]["Nome"] + "</h2>");
                sDestaques.Append("<p>" + dTable2.Rows[0]["Descricao"] + "</p>");
                sDestaques.Append("</div>");

                sDestaques.Append("<div class=\"items-wrap blog_posts_list blog-posts-shortcode\">");
                sDestaques.Append("<div class=\"posts-list grid\">");
                sDestaques.Append("<div class=\"row\">");




                //sDestaques.Append("<div class=\"shell\">");
                //sDestaques.Append("<h3 class=\" text-gray-base text-center\">" + dTable2.Rows[0]["Descricao"] + "</h3>");

                //sDestaques1.Append("<div class=\"cell-sm-4 cell-md-4\">");
                //sDestaques1.Append("<h6 class=\"text-white\">" + dTable2.Rows[0]["Descricao"] + "</h6>");
            }




            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                sDestaques.Append("<div class=\"col-md-3 text-center\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<img src =\"uploads/" + dTable.Rows[i]["Media"] + "\" class=\"img-circle width_80\" alt=\"\">");
                sDestaques.Append("<div class=\"team-member-text text-center width_90\">");
                sDestaques.Append("<h3 class=\"team-member-title\">" + dTable.Rows[i]["Titulo"] + "</h3>");
                sDestaques.Append("<div class=\"team-member-position\"></div>");
                sDestaques.Append("<p class=\"team-member-details\">" + dTable.Rows[i]["SubTitulo"] + "</p>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div> ");


                //sDestaques.Append("<div class=\"spacer_20\"></div>");
                //sDestaques.Append("<div class=\"row\">");
                //sDestaques.Append("<div class=\"col-md-12\">");
                //sDestaques.Append("<h3 class=\"text-left\"><strong>" + dTable.Rows[0]["Titulo"] + "</strong></h3>");
                //sDestaques.Append("<p class=\"text-left\">" + dTable.Rows[0]["SubTitulo"] + "</p>");
                //sDestaques.Append("</div>");
                //sDestaques.Append("</div>");
                //sDestaques.Append("</div>");


            }



            return sDestaques.ToString();
        }
        public string GetHTMLDestaques5(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();

            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Media, sClassifier, Lingua);


            for (int i = 0; i < dTable.Rows.Count; i++)
            {



                sDestaques.Append("<figure class=\"lift-thumbnail blog_post col-md-3\">");
                sDestaques.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\" alt=\"\">");
                sDestaques.Append("<figcaption>");
                sDestaques.Append("<p>" + dTable.Rows[i]["Titulo"] + "<i class=\"icon-size-fullscreen\"></i></p>");
                sDestaques.Append("<a class=\"swipebox\" href=\"uploads/" + dTable.Rows[i]["Media"] + "\"></a>");
                sDestaques.Append("<div class=\"\">");
                sDestaques.Append("</div>");
                sDestaques.Append("</figcaption>");
                sDestaques.Append("</figure>");



            }



            return sDestaques.ToString();
        }
        public string GetHTMLDestaques6(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Link, sClassifier, Lingua);


            dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {




                sDestaques.Append("<div class=\"high-padding row\">");
                sDestaques.Append("<div class=\"widget widget_text col-md-6\">");
                sDestaques.Append("<a href =\"#\" class=\"footer-logo\">");
                sDestaques.Append("<img src=\"uploads/" + dTable2.Rows[i]["Media"] + "\" alt =\"\">");
                sDestaques.Append("</a>");
                sDestaques.Append("<div class=\"spacer_10\"></div>");
                sDestaques.Append("<p>" + dTable2.Rows[0]["Descricao"] + "</p>");
                sDestaques.Append("<div class=\"spacer_15\"></div>");

                sDestaques.Append("<!-- SOCIAL LINKS -->");
                sDestaques.Append("<aside class=\"widget widget_social_links\">");



            }




            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                sDestaques.Append("<div class=\"social_links\">");
                sDestaques.Append("<a href =\"" + dTable.Rows[0]["Url"] + "\">");
                sDestaques.Append("<i class=\"fa fa-facebook\"></i>");
                sDestaques.Append("</a>");


                sDestaques.Append("</div>");
                sDestaques.Append("</aside>");
                sDestaques.Append("</div>");

            }



            return sDestaques.ToString();
        }


        public string GetHTMLNoticiasRecentes(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);


            for (int i = 0; i < dTable.Rows.Count; i++)
            {



                sDestaques.Append("<li>");
                sDestaques.Append("<div class=\"col-md-3 no_gap post-thumbnail relative\">");
                sDestaques.Append("<a href=\"detalheartigo.aspx?aid=" + dTable.Rows[i]["ArtigoID"] + "\">");
                sDestaques.Append("<img alt=\"\" class=\"img-rounded\" src=\"uploads/" + dTable.Rows[i]["Media"] + "\">");
                sDestaques.Append("</a>");
                sDestaques.Append("</div>");
                sDestaques.Append("<div class=\"col-md-9 post-details\">");
                sDestaques.Append("<a href=\"detalheartigo.aspx?aid=" + dTable.Rows[i]["ArtigoID"] + "\">" + dTable.Rows[i]["Titulo"] + "</a>");
                sDestaques.Append("<div class=\"clearfix\"></div>");
                //sDestaques.Append("<span class=\"post-date\">July 18, 2017</span>");
                //sDestaques.Append("<span class=\"post-date\">" + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()));
                sDestaques.Append("<span class=\"post-date\">" + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Day.ToString("00") + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).ToString("MMMM").Substring(0, 3) + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Year + "</span>");
                sDestaques.Append("</div>");
                sDestaques.Append("</li>");


            }



            return sDestaques.ToString();
        }
        public string GetHTMLSitesrelacionados(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Link, sClassifier, Lingua);


            for (int i = 0; i < dTable.Rows.Count; i++)
            {



                sDestaques.Append("<li>");
                sDestaques.Append("<div class=\"col-md-15 no_gap post-thumbnail relative\">");

                sDestaques.Append("<div class=\"col-md-15 post-details\">");
                sDestaques.Append("<a target=\"_new\" href=" + dTable.Rows[i]["url"] + ">" + dTable.Rows[i]["Titulo"] + "</a>");
                sDestaques.Append("<div class=\"clearfix\"></div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</li>");


            }



            return sDestaques.ToString();
        }



        public string GetHTMLFooter(int sClassifier, int Lingua)
        {
            StringBuilder sValue = new StringBuilder();

            Service oService = new Service();
            DataTable dTable = new DataTable();

            dTable = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {


                sValue.Append("<div class=\"copyright-informations text -left col-md-6\">");
                sValue.Append("</i> " + dTable.Rows[i]["Descricao"].ToString() + "");
                sValue.Append(" </div>");

            }
            return sValue.ToString();
        }

        public string GetHTMLContacte_nos(int sClassifier, int Lingua)
        {
            StringBuilder sValue = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Contactos, sClassifier, Lingua);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                sValue.Append("<header class=\"amaezi-fullscreen-header section-bg\" data-image-src=\"img/gallery/6.jpg\" style=\"background-image: url(&quot;img/gallery/6.jpg&quot;);\">");


                sValue.Append("<div class=\"amaezi-header-overlay\"></div>");

                sValue.Append("<div class=\"amaezi_header_content\">");
                sValue.Append("<h1 class=\"amaezi_header_title\">" + dTable.Rows[i]["Nome"].ToString() + "</h1>");
                sValue.Append("<h3 class=\"amaezi_header_subtitle\">" + dTable.Rows[i]["Morada"].ToString() + "</h3>");
                sValue.Append("</div>");
                sValue.Append("</header>");


                sValue.Append("<!--MAIN CONTAINER-->");
                sValue.Append("<div id = \"container\" class=\"main-content\">");
                sValue.Append("<!-- Page content -->");
                sValue.Append("<div class=\"container high-padding\">");
                sValue.Append(" <div class=\"row\">");
                sValue.Append("<div class=\"col-md-12 main-container\">");
                sValue.Append(" <!-- Post content -->");
                sValue.Append("<div class=\"post-content animateIn animated fadeIn\" data-animate=\"fadeIn\" style=\"opacity:100; \">");

                sValue.Append("<!-- TITLE + SUBTITLE section -->");
                sValue.Append("<div class=\"relative section-header\">");
                sValue.Append("<h2 class=\"section-title\">Entre em contacto conosco</h2>");
                sValue.Append("<p>Preencha os campo abaixo e envie-nos a sua dúvida, sugestão ou opinião, teremos todo o gosto receber.</p>");
                sValue.Append("</div>");


                //sValue.Append("<div class=\"wrapper\">");
                //sValue.Append("<div class=\"col5\">" + dTable.Rows[i]["Morada"].ToString());
                //sValue.Append("<span>Telemóvel:</span>" + dTable.Rows[i]["Telefone"].ToString() + "<br>");
                //sValue.Append("E-mail: <a href=\"mailto:" + dTable.Rows[i]["Email"].ToString() + "\">" + dTable.Rows[i]["Email"].ToString() + "</a></p></div><div>");


            }
            return sValue.ToString();

        }

        public string GetHTMLDetalheartigo(int artigoID, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTableSeccoes = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable2 = oService.FEGetArticleByIDLingua(artigoID, Lingua);


            dTableSeccoes = oService.FEGetListSeccoesArtigoByIDLingua(artigoID, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {

                sDestaques.Append("<header class=\"amaezi-fullscreen-header section-bg\"data-image-src=\"uploads/" + dTable2.Rows[i]["Media"] + "\"style=\"background-image:url(&quot;uploads/" + dTable2.Rows[i]["Media"] + "&quot;);\">");

                sDestaques.Append("<!-- HEADER OVERLAY -->");
                sDestaques.Append("<div class=\"amaezi-header-overlay\"></div>");



                sDestaques.Append(" <!-- HEADER CONTENT -->");
                sDestaques.Append("<div class=\"amaezi_header_content\">");
                sDestaques.Append("<h1 class=\"amaezi_header_title\">" + dTable2.Rows[i]["Titulo"] + "</h1>");
                sDestaques.Append("<div class=\"post-details-list text-center\">");
                sDestaques.Append("<span class=\"post-author post-date\">Publicado por<a href=\"#\">" + dTable2.Rows[i]["Autor"] + "</a> aos " + System.DateTime.Parse(dTable2.Rows[i]["DataEntrada"].ToString()).Day.ToString("00") + " " + System.DateTime.Parse(dTable2.Rows[i]["DataEntrada"].ToString()).ToString("MMMM").Substring(0, 3) + " " + System.DateTime.Parse(dTable2.Rows[i]["DataEntrada"].ToString()).Year + "</span>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</header>");



                sDestaques.Append("<div id =\"container\" class=\"main-content\">");

                sDestaques.Append("<div class=\"container high-padding\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"col-md-11 main-container\">");

                sDestaques.Append("<div class=\"post-content animateIn animated fadeIn\" data-animate=\"fadeIn\" style=\"opacity:100;\">");
                sDestaques.Append("<p>" + dTable2.Rows[i]["Subtitulo"] + "</p>");
                sDestaques.Append("<img src=\"uploads/" + dTable2.Rows[i]["Mediapreview"] + "\" alt = \"\" >");
                //--------------------------


            }




            for (int j = 0; j < dTableSeccoes.Rows.Count; j++)
            {



                sDestaques.Append("<p>" + dTableSeccoes.Rows[j]["Texto"].ToString() + "</ p>");

                sDestaques.Append("</div>");


            }



            return sDestaques.ToString();
        }

        public string GetHTMLNoticias(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);


            dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {
                //sDestaques.Append("<div class=\"relative section-header animateIn\" data-animate=\"fadeIn\" style=\"opacity: 0; \">");
                //sDestaques.Append("<h2 class=\"section-title\">" + dTable2.Rows[0]["Nome"] + "</h2>");
                //sDestaques.Append("<p>" + dTable2.Rows[0]["Descricao"] + "</p>");
                //sDestaques.Append("</div>");

                //sDestaques.Append("<div class=\"items-wrap blog_posts_list blog-posts-shortcode\">");
                //sDestaques.Append("<div class=\"posts-list grid\">");
                //sDestaques.Append("<div class=\"row\">");


                sDestaques.Append("<header class=\"amaezi-fullscreen-header breadcrumbs section-bg\" data-image-src=\"img/gallery/6.jpg\" style=\"background-image: url(&quot;img/gallery/6.jpg&quot;); \">");
                sDestaques.Append("<!-- HEADER OVERLAY -->");
                sDestaques.Append("<div class=\"amaezi-header-overlay\"></div>");
                sDestaques.Append("<!-- HEADER CONTENT -->");
                sDestaques.Append("<div class=\"amaezi_header_content\">");
                sDestaques.Append("<h1 class=\"amaezi_header_title\">" + dTable2.Rows[0]["Nome"] + "</h1>");
                sDestaques.Append("</div>");
                sDestaques.Append("</header>");
                sDestaques.Append("<div id = \"container\" class=\"main-content\">");
                sDestaques.Append("<!-- SECTION: CAUSES -->");
                sDestaques.Append("<section class=\"high-padding white-section\">");
                sDestaques.Append("<div class=\"container\">");
                sDestaques.Append("<!-- Blog posts section -->");
                sDestaques.Append("<div class=\"items-wrap blog_posts_list blog-posts-shortcode\">");
                sDestaques.Append("<div class=\"posts-list grid\">");
                sDestaques.Append("<div class=\"row\">");
            }




            for (int i = 0; i < dTable.Rows.Count; i++)
            {


                sDestaques.Append("<div class=\"col-md-4\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"single-post clearfix animateIn animated fadeIn\" data-animate=\"fadeIn\" style=\"opacity:100; \">");
                sDestaques.Append("<div class=\"col-md-12 post-thumbnail\">");
                sDestaques.Append("<figure class=\"effect-lexi\">");
                sDestaques.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\" alt=\"\">");
                sDestaques.Append("<figcaption>");
                sDestaques.Append("<i class=\"icon-arrow-right-circle\"></i>");
                sDestaques.Append("</figcaption>");
                sDestaques.Append("</figure>");
                sDestaques.Append("</div>");
                sDestaques.Append("<div class=\"col-md-12 post-details\">");
                sDestaques.Append("<div class=\"post-details-holder\">");
                sDestaques.Append("<h3 class=\"post-title text-center\"><a href =\"detalheartigo.aspx?aid=" + dTable.Rows[i]["ArtigoID"] + "\">" + dTable.Rows[i]["Titulo"] + "</a></h3>");
                sDestaques.Append("<div class=\"more-post-details text-center\">");
                sDestaques.Append("<a class=\"more-link\" href=\"blog-article.html\"><i class=\"icon-user\"></i> " + dTable.Rows[i]["Autor"] + "</a>");
                sDestaques.Append("<a class=\"more-link\" href=\"blog-article.html\"><i class=\"icon-clock\"></i> " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Day.ToString("00") + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).ToString("MMMM").Substring(0, 3) + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Year + "</a>");
                sDestaques.Append("</div>");
                sDestaques.Append("<p class=\"post-excerpt text-center\">" + dTable.Rows[i]["SubTitulo"] + "</p>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");

                //sDestaques.Append("</div>");
                //sDestaques.Append("</div>");
                //sDestaques.Append("</div>");
                //sDestaques.Append("</div>");
                //sDestaques.Append("</section>");




            }



            return sDestaques.ToString();
        }

        public string GetHTMLProjetos(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);


            dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {



                sDestaques.Append("<header class=\"amaezi-fullscreen-header breadcrumbs section-bg\" data-image-src=\"img/gallery/6.jpg\" style=\"background-image: url(&quot;img/gallery/6.jpg&quot;); \">");
                sDestaques.Append("<!-- HEADER OVERLAY -->");
                sDestaques.Append("<div class=\"amaezi-header-overlay\"></div>");
                sDestaques.Append("<!-- HEADER CONTENT -->");
                sDestaques.Append("<div class=\"amaezi_header_content\">");
                sDestaques.Append("<h1 class=\"amaezi_header_title\">" + dTable2.Rows[0]["Nome"] + "</h1>");
                sDestaques.Append("</div>");
                sDestaques.Append("</header>");


                sDestaques.Append("<div id =\"container\" class=\"main-content\">");
                sDestaques.Append("<div class=\"container high-padding\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"col-md-12 main-container\">");
                sDestaques.Append("<div class=\"post-content\">");
                sDestaques.Append("<div class=\"items-wrap blog_posts_list blog-posts-shortcode\">");
                sDestaques.Append("<div class=\"posts-list grid\">");
                sDestaques.Append("<div class=\"row\">");
            }




            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                sDestaques.Append("<div class=\"col-md-12\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"single-post clearfix animateIn animated fadeIn\" data-animate=\"fadeIn\" style=\"opacity:100; \">");
                sDestaques.Append("<div class=\"col-md-12 post-details\">");
                sDestaques.Append("<div class=\"post-details-holder\">");
                sDestaques.Append("<h3 class=\"post-title text-center\"><a href=\"detalheartigo.aspx?aid=" + dTable.Rows[i]["ArtigoID"] + "\">" + dTable.Rows[i]["Titulo"] + "</a></h3>");
                sDestaques.Append("<div class=\"more-post-details text-center\">");
                sDestaques.Append("<a class=\"more-link\" href=\"\"><i class=\"icon-user\"></i> " + dTable.Rows[i]["Autor"] + "</a>");
                sDestaques.Append("<a class=\"more-link\" href=\"\"><i class=\"icon-clock\"></i> " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Day.ToString("00") + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).ToString("MMMM").Substring(0, 3) + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Year + "</a>");
                sDestaques.Append("</div>");
                sDestaques.Append("<p class=\"post-excerpt text-center\">" + dTable.Rows[i]["SubTitulo"] + "</p>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");

                sDestaques.Append("<div class=\"spacer_30\"></div>");


            }



            return sDestaques.ToString();
        }

        public string GetHTMLMissoes(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);


            dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {



                sDestaques.Append("<header class=\"amaezi-fullscreen-header breadcrumbs section-bg\" data-image-src=\"img/gallery/6.jpg\" style=\"background-image: url(&quot;img/gallery/6.jpg&quot;); \">");
                sDestaques.Append("<!-- HEADER OVERLAY -->");
                sDestaques.Append("<div class=\"amaezi-header-overlay\"></div>");
                sDestaques.Append("<!-- HEADER CONTENT -->");
                sDestaques.Append("<div class=\"amaezi_header_content\">");
                sDestaques.Append("<h1 class=\"amaezi_header_title\">" + dTable2.Rows[0]["Nome"] + "</h1>");
                sDestaques.Append("</div>");
                sDestaques.Append("</header>");


                sDestaques.Append("<div id =\"container\" class=\"main-content\">");
                sDestaques.Append("<div class=\"container high-padding\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"col-md-12 main-container\">");
                sDestaques.Append("<div class=\"post-content\">");
                sDestaques.Append("<div class=\"items-wrap blog_posts_list blog-posts-shortcode\">");
                sDestaques.Append("<div class=\"posts-list grid\">");
                sDestaques.Append("<div class=\"row\">");
            }




            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                sDestaques.Append("<div class=\"col-md-12\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"single-post clearfix animateIn animated fadeIn\" data-animate=\"fadeIn\" style=\"opacity:100; \">");
                sDestaques.Append("<div class=\"col-md-12 post-details\">");
                sDestaques.Append("<div class=\"post-details-holder\">");
                sDestaques.Append("<h3 class=\"post-title text-center\"><a href=\"detalheartigo.aspx?aid=" + dTable.Rows[i]["ArtigoID"] + "\">" + dTable.Rows[i]["Titulo"] + "</a></h3>");
                sDestaques.Append("<div class=\"more-post-details text-center\">");
                sDestaques.Append("<a class=\"more-link\" href=\"\"><i class=\"icon-user\"></i> " + dTable.Rows[i]["Autor"] + "</a>");
                sDestaques.Append("<a class=\"more-link\" href=\"\"><i class=\"icon-clock\"></i> " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Day.ToString("00") + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).ToString("MMMM").Substring(0, 3) + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Year + "</a>");
                sDestaques.Append("</div>");
                sDestaques.Append("<p class=\"post-excerpt text-center\">" + dTable.Rows[i]["SubTitulo"] + "</p>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");

                sDestaques.Append("<div class=\"spacer_30\"></div>");


            }



            return sDestaques.ToString();
        }

        public string GetHTMLGruposcorais(int sClassifier, int Lingua)
        {
            StringBuilder sDestaques = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTable2 = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);


            dTable2 = oService.FEGetClassificadorByIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable2.Rows.Count; i++)
            {



                sDestaques.Append("<header class=\"amaezi-fullscreen-header breadcrumbs section-bg\" data-image-src=\"img/gallery/6.jpg\" style=\"background-image: url(&quot;img/gallery/6.jpg&quot;); \">");
                sDestaques.Append("<!-- HEADER OVERLAY -->");
                sDestaques.Append("<div class=\"amaezi-header-overlay\"></div>");
                sDestaques.Append("<!-- HEADER CONTENT -->");
                sDestaques.Append("<div class=\"amaezi_header_content\">");
                sDestaques.Append("<h1 class=\"amaezi_header_title\">" + dTable2.Rows[0]["Nome"] + "</h1>");
                sDestaques.Append("</div>");
                sDestaques.Append("</header>");


                sDestaques.Append("<div id =\"container\" class=\"main-content\">");
                sDestaques.Append("<div class=\"container high-padding\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"col-md-12 main-container\">");
                sDestaques.Append("<div class=\"post-content\">");
                sDestaques.Append("<div class=\"items-wrap blog_posts_list blog-posts-shortcode\">");
                sDestaques.Append("<div class=\"posts-list grid\">");
                sDestaques.Append("<div class=\"row\">");
            }




            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                sDestaques.Append("<div class=\"col-md-12\">");
                sDestaques.Append("<div class=\"row\">");
                sDestaques.Append("<div class=\"single-post clearfix animateIn animated fadeIn\" data-animate=\"fadeIn\" style=\"opacity:100; \">");
                sDestaques.Append("<div class=\"col-md-12 post-details\">");
                sDestaques.Append("<div class=\"post-details-holder\">");
                sDestaques.Append("<h3 class=\"post-title text-center\"><a href=\"detalheartigo.aspx?aid=" + dTable.Rows[i]["ArtigoID"] + "\">" + dTable.Rows[i]["Titulo"] + "</a></h3>");
                sDestaques.Append("<div class=\"more-post-details text-center\">");
                sDestaques.Append("<a class=\"more-link\" href=\"\"><i class=\"icon-user\"></i> " + dTable.Rows[i]["Autor"] + "</a>");
                sDestaques.Append("<a class=\"more-link\" href=\"\"><i class=\"icon-clock\"></i> " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Day.ToString("00") + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).ToString("MMMM").Substring(0, 3) + " " + System.DateTime.Parse(dTable.Rows[i]["DataEntrada"].ToString()).Year + "</a>");
                sDestaques.Append("</div>");
                sDestaques.Append("<p class=\"post-excerpt text-center\">" + dTable.Rows[i]["SubTitulo"] + "</p>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");
                sDestaques.Append("</div>");

                sDestaques.Append("<div class=\"spacer_30\"></div>");


            }



            return sDestaques.ToString();
        }






        public string GetHTMLLinksUteis(int sClassifier, int Lingua)
        {
            StringBuilder sLinks = new StringBuilder();
            Service oService = new Service();
            DataTable dTableLinks = new DataTable();

            dTableLinks = oService.FEGetListConteudoClassificador((int)CMSCK.WEB.Comum.ContentType.Link, sClassifier, Lingua);

            if (dTableLinks.Rows.Count > 0)
            {
                sLinks.Append("<div class=\"grid_3\">");
                sLinks.Append("<h2>" + dTableLinks.Rows[0]["Nome"] + "</h2>");
                sLinks.Append("<ul class=\"list\">");
            }

            for (int i = 0; i < dTableLinks.Rows.Count; i++)
            {

                sLinks.Append("<li><a target=\"_new\"  href=\"" + dTableLinks.Rows[i]["url"] + "\">" + dTableLinks.Rows[i]["Titulo"] + "</a></li>");
            }

            if (dTableLinks.Rows.Count > 0)
            {
                sLinks.Append("</ul>");
                sLinks.Append("</div>");
            }
            return sLinks.ToString();
        }

        public string GetHTMLBemVindo(int sClassifier, int Lingua)
        {
            StringBuilder sArtigo = new StringBuilder();
            Service oService = new Service();
            DataTable dTableArtigo = new DataTable();

            dTableArtigo = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);
            for (int i = 0; i < dTableArtigo.Rows.Count; i++)
            {
                sArtigo.Append(" <div class=\"pad1\">");
                sArtigo.Append("<h2>" + dTableArtigo.Rows[0]["Nome"] + "</h2>");
                sArtigo.Append("<div class=\"text1\"><strong><a href=\"detalheartigo.aspx?aid=" + dTableArtigo.Rows[i]["ArtigoID"] + "\">" + dTableArtigo.Rows[i]["Titulo"] + "</a></strong></div>");
                sArtigo.Append("<img src=\"uploads/" + dTableArtigo.Rows[i]["Media"] + "\" alt =\"\" class=\"img_inner\"/>");
                sArtigo.Append((dTableArtigo.Rows[i]["SubTitulo"].ToString().Length > 610 ? dTableArtigo.Rows[i]["SubTitulo"].ToString().Substring(0, 609) + "..." : dTableArtigo.Rows[i]["SubTitulo"]));
                sArtigo.Append("</div>");

                return sArtigo.ToString();
            }
            return sArtigo.ToString();
        }



        //FOOTER


        //LINK TO ARTICLE
        public string GetHTMLLinkArtigoClassificado(int sClassifier, int Lingua)
        {
            StringBuilder sArtigo = new StringBuilder();
            Service oService = new Service();
            DataTable dTableArtigo = new DataTable();

            dTableArtigo = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);

            if (dTableArtigo.Rows.Count > 0)
            {
                sArtigo.Append("<a href=\"detalheartigo.aspx?aid=" + dTableArtigo.Rows[0]["ArtigoID"] + "\">" + dTableArtigo.Rows[0]["Titulo"] + "</a>");
            }
            //<a href="index-6.html">Política de Privacidade</a>
            return sArtigo.ToString();
        }

        //GET ARTICLE AND SECTIONS GetHTMLArtigo 
        public string GetHTMLArtigo(int artigoID, int Lingua)
        {
            StringBuilder sValue = new StringBuilder();

            Service oService = new Service();
            DataTable dTable = new DataTable();
            DataTable dTableSeccoes = new DataTable();

            dTable = oService.FEGetArticleByIDLingua(artigoID, Lingua);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                sValue.Append("<h2>" + dTable.Rows[i]["Titulo"].ToString() + "</h2>");

                if (dTable.Rows[i]["Media"].ToString() != string.Empty)
                    sValue.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\" class=\"img_inner fleft\" />");

                sValue.Append("<div class=\"extra_wrapper\">");
                //sValue.Append("<p class=\"text1\"><strong><a href=\"#\">" + dTable.Rows[i]["Titulo"].ToString()  + "</a></strong></p>");
                sValue.Append(dTable.Rows[i]["SubTitulo"].ToString());
                sValue.Append("</div>");
            }

            dTableSeccoes = oService.FEGetListSeccoesArtigoByIDLingua(artigoID, Lingua);

            for (int j = 0; j < dTableSeccoes.Rows.Count; j++)
            {
                sValue.Append("<p class=\"text1\"><strong><a href=\"#\">" + dTableSeccoes.Rows[j]["Cabecalho"].ToString() + "</a></strong></p>");
                sValue.Append(dTableSeccoes.Rows[j]["Texto"].ToString());
                sValue.Append("<p class=\"text1\"><strong><a href=\"#\">" + dTableSeccoes.Rows[j]["Rodape"].ToString() + "</a></strong></p>");
            }

            return sValue.ToString();
        }

        //LISTA DE ARTIGOS - ÙLTIMAS 10 NOTÍCIAS
        public string GetHTMLListaArtigo(int sClassifier, int Lingua)
        {
            StringBuilder sListaArtigos = new StringBuilder();
            Service oService = new Service();
            DataTable dListaArtigos = new DataTable();

            dListaArtigos = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);

            if (dListaArtigos.Rows.Count > 0)
            {
                sListaArtigos.Append("<h2>" + dListaArtigos.Rows[0]["Nome"] + "</h2>");
            }

            for (int i = 0; i < dListaArtigos.Rows.Count; i++)
            {
                sListaArtigos.Append("<div class=\"blog\">");
                //sListaArtigos.Append("<time datetime=\"2013-01- 01\">29<span>june</span></time>");
                sListaArtigos.Append("<time datetime=\"2013-01-01\">" + System.DateTime.Parse(dListaArtigos.Rows[i]["DataEntrada"].ToString()).Day.ToString("00") + "<span>" + System.DateTime.Parse(dListaArtigos.Rows[i]["DataEntrada"].ToString()).ToString("MMMM").Substring(0, 3) + "." + "</span></time>");
                sListaArtigos.Append("<div class=\"extra_wrapper\"><strong class=\"upp\">" + dListaArtigos.Rows[i]["Titulo"] + "</strong></div>");
                sListaArtigos.Append("<div class=\"clear\"></div>");
                if (dListaArtigos.Rows[i]["MediaPreview"].ToString() != string.Empty)
                    sListaArtigos.Append("<img src=\"uploads/" + dListaArtigos.Rows[i]["MediaPreview"] + "\" class=\"img_inner fleft\" />");

                sListaArtigos.Append("<div class=\"extra_wrapper\">" + (dListaArtigos.Rows[i]["SubTitulo"].ToString().Length > 520 ? dListaArtigos.Rows[i]["SubTitulo"].ToString().Substring(0, 519) + "..." : dListaArtigos.Rows[i]["SubTitulo"]) + "</div>");
                sListaArtigos.Append("<a href =\"detalheartigo.aspx?aid=" + dListaArtigos.Rows[0]["ArtigoID"] + "\" class=\"btn\">Mais</a>");
                sListaArtigos.Append("</div>");

                if (i == 9)
                    return sListaArtigos.ToString();

            }

            return sListaArtigos.ToString();
        }



        //LISTA DE MEDIAS -
        public string GetHTMLListaMedias(int sClassifier, int Lingua)
        {
            StringBuilder sListaMedias = new StringBuilder();
            Service oService = new Service();
            DataTable dListaMedias = new DataTable();

            dListaMedias = oService.FEGetListConteudoClassificador((int)ContentType.Media, sClassifier, Lingua);

            if (dListaMedias.Rows.Count > 0)
            {
                sListaMedias.Append("<div class=\"grid_12\">");
                sListaMedias.Append("<h2>" + dListaMedias.Rows[0]["Nome"] + "</h2>");
                sListaMedias.Append("</div>");
                sListaMedias.Append(" <div class=\"clear\"></div>");
            }


            /*
           <div class="grid_4">
              <div class="text1"><strong><a href="#">about science &amp; research</a></strong></div>

              <p class="p2">Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Praesent vestibulum molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta. Fusce suscipit varius mi. Cum sociis natoque penatibus magnis dis parturient montes.</p>

        </div>
             * */
            /*
             *<div class="grid_12">
        <div class="hor_separator hor1"></div>
        </div>
             * */


            for (int i = 0; i < dListaMedias.Rows.Count; i++)
            {
                sListaMedias.Append("<div class=\"grid_4\">");
                sListaMedias.Append("<div class=\"text1\"><strong><a target=\"_new\" href=\"uploads/" + dListaMedias.Rows[i]["Media"] + "\">" + dListaMedias.Rows[i]["Titulo"] + "</a></strong></div>");
                sListaMedias.Append("<p class=\"p2\">" + dListaMedias.Rows[i]["SubTitulo"] + "</p>");
                sListaMedias.Append("</div>");

                if ((((i + 1) % 3) == 0) && ((i + 1) < dListaMedias.Rows.Count))
                {
                    sListaMedias.Append("<div class=\"grid_12\">");
                    sListaMedias.Append("<div class=\"hor_separator hor1\"></div>");
                    sListaMedias.Append("</div>");
                    sListaMedias.Append("<div></div>");
                }


            }

            return sListaMedias.ToString();
        }

        //LISTA DE ARTIGOSCOLUMNS -
        public string GetHTMLListaArtigoColumn(int sClassifier, int Lingua)
        {
            StringBuilder sListaArtigos = new StringBuilder();
            Service oService = new Service();
            DataTable dListaArtigos = new DataTable();

            dListaArtigos = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);

            if (dListaArtigos.Rows.Count > 0)
            {
                sListaArtigos.Append("<div class=\"grid_12\">");
                sListaArtigos.Append("<h2>" + dListaArtigos.Rows[0]["Nome"] + "</h2>");
                sListaArtigos.Append("</div>");
                sListaArtigos.Append(" <div class=\"clear\"></div>");
            }


            for (int i = 0; i < dListaArtigos.Rows.Count; i++)
            {
                sListaArtigos.Append("<div class=\"grid_4\">");
                sListaArtigos.Append("<div class=\"text1\"><strong><a href =\"detalheartigo.aspx?aid=" + dListaArtigos.Rows[0]["ArtigoID"] + "\">" + dListaArtigos.Rows[i]["Titulo"] + "</a></strong></div>");
                sListaArtigos.Append("<p class=\"p2\">" + dListaArtigos.Rows[i]["SubTitulo"] + "</p>");
                sListaArtigos.Append("</div>");

                if ((((i + 1) % 3) == 0) && ((i + 1) < dListaArtigos.Rows.Count))
                {
                    sListaArtigos.Append("<div class=\"grid_12\">");
                    sListaArtigos.Append("<div class=\"hor_separator hor1\"></div>");
                    sListaArtigos.Append("</div>");
                    sListaArtigos.Append("<div></div>");
                }


            }

            return sListaArtigos.ToString();
        }

        public string GetMedia(int mediaID, int Lingua)
        {

            Service oService = new Service();
            DataTable dMedia = new DataTable();
            StringBuilder sMedia = new StringBuilder();

            dMedia = oService.FEGetMediaByIDLingua(mediaID, Lingua);

            if (dMedia.Rows.Count > 0)
            {
                sMedia.Append("uploads/" + dMedia.Rows[0]["Media"]);
                return sMedia.ToString();
            }

            return sMedia.ToString();

        }




        //public string GetHTMLDestaques2(int sClassifier, int Lingua)
        //{
        //    StringBuilder sDestaque2 = new StringBuilder();
        //    Service oService = new Service();
        //    DataTable dTableDestaque2 = new DataTable();

        //    dTableDestaque2 = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);

        //    for (int i = 0; i < dTableDestaque2.Rows.Count; i++)
        //    {
        //        sDestaque2.Append("<h6>" + dTableDestaque2.Rows[i]["Titulo"] + "</h6>");
        //        sDestaque2.Append("<p class=\"padbot2\">" + dTableDestaque2.Rows[i]["SubTitulo"] + "</p>");
        //    }

        //    return sDestaque2.ToString();
        //}

        public string GetHTMLDestaques33(int sClassifier, int Lingua)
        {
            StringBuilder sDestaque3 = new StringBuilder();
            Service oService = new Service();
            DataTable dTableDestaque3 = new DataTable();

            dTableDestaque3 = oService.FEGetListConteudoClassificador((int)ContentType.Link, sClassifier, Lingua);

            if (dTableDestaque3.Rows.Count > 0)
            {
                sDestaque3.Append("<h6 class=\"padbot\">" + dTableDestaque3.Rows[0]["Nome"].ToString() + "</h6>");
                sDestaque3.Append("<div class=\"title2\">" + "</div>");
                sDestaque3.Append("<ul class=\"list1 padbot3\">");
            }

            for (int i = 0; i < dTableDestaque3.Rows.Count; i++)
            {
                if (dTableDestaque3.Rows[i]["MediaPreview"].ToString() != string.Empty)
                    sDestaque3.Append("<li><a target=\"_blank\" href=\"uploads/" + dTableDestaque3.Rows[i]["MediaPreview"] + "\">" + dTableDestaque3.Rows[i]["Titulo"] + "</a></li>");
                else
                    sDestaque3.Append("<li><a rel=\"leanModal\" target=\"_blank\" href=\"" + dTableDestaque3.Rows[i]["url"] + "\">" + dTableDestaque3.Rows[i]["Titulo"] + "</a></li>");

            }
            //dTableDestaque3 = oService.FEGetListConteudoClassificador((int)ContentType.Link, sClassifier, Lingua);

            //for (int i = 0; i < dTableDestaque3.Rows.Count; i++)
            //    {
            //    sDestaque3.Append("<h6 class=\"padbot\">" + dTableDestaque3.Rows[i]["Titulo"] + "</h6>");
            //    sDestaque3.Append("<div class=\"title2\">" + dTableDestaque3.Rows[i]["autor"] + "</div>");
            //    sDestaque3.Append( dTableDestaque3.Rows[i]["subtitulo"]);
            //}

            if (dTableDestaque3.Rows.Count >= 0)
            {
                sDestaque3.Append("</ul>");
            }
            return sDestaque3.ToString();
        }

        public string GetHTMLNovidades(int sClassifier, int Lingua)
        {
            StringBuilder sNovidades = new StringBuilder();
            Service oService = new Service();
            DataTable dTableNovidades = new DataTable();

            dTableNovidades = oService.FEGetListConteudoClassificador((int)ContentType.Link, sClassifier, Lingua);

            if (dTableNovidades.Rows.Count >= 0)
            {
                sNovidades.Append("<h6 class=\"padbot\">" + dTableNovidades.Rows[0]["Nome"].ToString() + "</h6>");
                sNovidades.Append("<div class=\"title2\">" + "</div>");
                sNovidades.Append("<ul class=\"list1 padbot3\">");
            }

            for (int i = 0; i < dTableNovidades.Rows.Count; i++)
            {
                if (dTableNovidades.Rows[i]["MediaPreview"].ToString() != string.Empty)
                    sNovidades.Append("<li><a target=\"_blank\" href=\"uploads/" + dTableNovidades.Rows[i]["MediaPreview"] + "\">" + dTableNovidades.Rows[i]["Titulo"] + "</a></li>");
                else
                    sNovidades.Append("<li><a rel=\"leanModal\" target=\"_blank\" href=\"" + dTableNovidades.Rows[i]["url"] + "\">" + dTableNovidades.Rows[i]["Titulo"] + "</a></li>");

            }

            if (dTableNovidades.Rows.Count >= 0)
            {
                sNovidades.Append("</ul>");
            }
            return sNovidades.ToString();
        }

        /// <summary>
        /// Oferta de Estágios - Classificado no Classificador "Procura de Estágios"
        /// </summary>
        /// <param name="sClassifier"></param>
        /// <param name="Lingua"></param>
        /// <returns></returns>
        public string GetHTMLOfertaEstagios(int sClassifier, int Lingua)
        {
            StringBuilder sOfertaEstagios = new StringBuilder();
            Service oService = new Service();
            DataTable dTableOfertaEstagios = new DataTable();

            dTableOfertaEstagios = oService.FEGetListConteudoClassificador((int)ContentType.Contactos, sClassifier, Lingua);

            for (int i = 0; i < dTableOfertaEstagios.Rows.Count; i++)
            {
                sOfertaEstagios.Append("<tr id=\"" + (i + 1).ToString() + "\" class=\"grid-row-style1\">");
                sOfertaEstagios.Append("<td style=\"width: 210px; \">");
                sOfertaEstagios.Append("<div style=\"overflow: hidden; \">" + dTableOfertaEstagios.Rows[i]["Nome"].ToString() + "</div>");
                sOfertaEstagios.Append("</td>");

                sOfertaEstagios.Append("<td style=\"width:145px; \">");
                sOfertaEstagios.Append("<div style=\"overflow: hidden; \">" + dTableOfertaEstagios.Rows[i]["Localidade"].ToString() + "</div>");
                sOfertaEstagios.Append("</td>");

                sOfertaEstagios.Append("<td style=\"width: 145px; \">");
                sOfertaEstagios.Append("<div style=\"overflow: hidden; \">" + dTableOfertaEstagios.Rows[i]["Morada"].ToString() + "</div>");
                sOfertaEstagios.Append("</td>");

                sOfertaEstagios.Append("<td style=\"width: 80px; \">");
                sOfertaEstagios.Append("<div style=\"overflow: hidden; \">" + (dTableOfertaEstagios.Rows[i]["DataSaida"].ToString() != string.Empty ? dTableOfertaEstagios.Rows[i]["DataSaida"].ToString().Substring(0, 10) : "Por definir") + "</div>");
                sOfertaEstagios.Append("</td>");
                sOfertaEstagios.Append("</tr>");
            }

            return sOfertaEstagios.ToString();
        }

        /// <summary>
        /// Procura de Estágios - Classificado no Classificador "Procura de Estágios"
        /// </summary>
        /// <param name="sClassifier"></param>
        /// <param name="Lingua"></param>
        /// <returns></returns>
        public string GetHTMLProcuraEstagios(int sClassifier, int Lingua)
        {
            StringBuilder sProcuraEstagios = new StringBuilder();
            Service oService = new Service();
            DataTable dTableProcuraEstagios = new DataTable();

            dTableProcuraEstagios = oService.FEGetListConteudoClassificador((int)ContentType.Contactos, sClassifier, Lingua);
            /*
         <tr id="475" class="grid-row-style1">
                    <td style="width: 210px;">
                        <div style="overflow: hidden;">Emanuel Rocha</div>
                    </td>
                    <td style="width: 145px;">
                        <div style="overflow: hidden;">Luanda</div>
                    </td>
                    <td style="width: 145px;">
                        <div style="overflow: hidden;">Informática</div>
                    </td>
                    <td style="width: 80px;">
                        <div style="overflow: hidden;">Total</div>
                    </td>
                </tr>
        */
            for (int i = 0; i < dTableProcuraEstagios.Rows.Count; i++)
            {
                sProcuraEstagios.Append("<tr id=\"" + (i + 1).ToString() + "\" class=\"grid-row-style1\">");
                sProcuraEstagios.Append("<td style=\"width: 210px; \">");
                sProcuraEstagios.Append("<div style=\"overflow: hidden; \">" + dTableProcuraEstagios.Rows[i]["Nome"].ToString() + "</div>");
                sProcuraEstagios.Append("</td>");

                sProcuraEstagios.Append("<td style=\"width:145px; \">");
                sProcuraEstagios.Append("<div style=\"overflow: hidden; \">" + dTableProcuraEstagios.Rows[i]["Localidade"].ToString() + "</div>");
                sProcuraEstagios.Append("</td>");

                sProcuraEstagios.Append("<td style=\"width: 145px; \">");
                sProcuraEstagios.Append("<div style=\"overflow: hidden; \">" + dTableProcuraEstagios.Rows[i]["Morada"].ToString() + "</div>");
                sProcuraEstagios.Append("</td>");

                sProcuraEstagios.Append("<td style=\"width: 80px; \">");
                sProcuraEstagios.Append("<div style=\"overflow: hidden; \">" + (dTableProcuraEstagios.Rows[i]["DataSaida"].ToString() != string.Empty ? dTableProcuraEstagios.Rows[i]["DataSaida"].ToString().Substring(0, 10) : "Por definir") + "</div>");
                sProcuraEstagios.Append("</td>");
                sProcuraEstagios.Append("</tr>");
            }

            return sProcuraEstagios.ToString();
        }

        //SOBRE NÓS    
        public string GetHTMLSobreNosEsquerda(int sClassifier, int Lingua)
        {
            StringBuilder sSobre = new StringBuilder();
            Service oService = new Service();
            DataTable dTableSobre = new DataTable();

            dTableSobre = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);

            for (int i = 0; i < dTableSobre.Rows.Count; i++)
            {
                sSobre.Append("<h6>" + dTableSobre.Rows[0]["titulo"] + "</h6>");
                sSobre.Append(dTableSobre.Rows[0]["subtitulo"]);
                return sSobre.ToString();
            }

            return sSobre.ToString();
        }

        public string GetHTMLSobreNosDireita(int sClassifier, int Lingua)
        {
            StringBuilder sSobre = new StringBuilder();
            Service oService = new Service();
            DataTable dTableSobre = new DataTable();

            dTableSobre = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);

            for (int i = 0; i < dTableSobre.Rows.Count; i++)
            {
                if (i == 1)
                {
                    sSobre.Append("<h6 class=\"padbot\">" + dTableSobre.Rows[i]["titulo"] + "</h6>");
                    sSobre.Append(dTableSobre.Rows[i]["subtitulo"]);
                    return sSobre.ToString();
                }
            }

            return sSobre.ToString();
        }

        //SERVIÇOS
        public void GetHTMLServicos(out string sHTMLServicosEstudos, out string sHTMLServicosAvaliacao, out string sHTMLServicosFormacao, out string sHTMLServicosConsultoria, int sClassifier, int Lingua)
        {
            StringBuilder sEstudos = new StringBuilder();
            StringBuilder sAvaliacao = new StringBuilder();
            StringBuilder sFormacao = new StringBuilder();
            StringBuilder sConsultoria = new StringBuilder();

            Service oService = new Service();
            DataTable dTable = new DataTable();

            dTable = oService.FEGetClassificadorByPaiIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                if (i == 0)
                {

                    sEstudos.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\"  alt=\"\">");
                    sEstudos.Append(" <div class=\"extra - wrap\">");
                    sEstudos.Append("<a rel = \"leanModal\" href=\"#" + dTable.Rows[i]["UrlTemplate"].ToString() + "\" class=\"button1\">" + dTable.Rows[i]["Nome"].ToString() + "</a>");
                    sEstudos.Append("<p>" + dTable.Rows[i]["Descricao"].ToString() + "</p>");
                    sEstudos.Append("</div>");
                }

                if (i == 1)
                {
                    sAvaliacao.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\"  alt=\"\">");
                    sAvaliacao.Append(" <div class=\"extra - wrap\">");
                    sAvaliacao.Append("<a rel = \"leanModal\" href=\"#" + dTable.Rows[i]["UrlTemplate"].ToString() + "\" class=\"button1\">" + dTable.Rows[i]["Nome"].ToString() + "</a>");
                    sAvaliacao.Append("<p>" + dTable.Rows[i]["Descricao"].ToString() + "</p>");
                    sAvaliacao.Append("</div>");
                }

                if (i == 2)
                {
                    sFormacao.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\"  alt=\"\">");
                    sFormacao.Append(" <div class=\"extra - wrap\">");
                    sFormacao.Append("<a rel = \"leanModal\" href=\"#" + dTable.Rows[i]["UrlTemplate"].ToString() + "\" class=\"button1\">" + dTable.Rows[i]["Nome"].ToString() + "</a>");
                    sFormacao.Append("<p>" + dTable.Rows[i]["Descricao"].ToString() + "</p>");
                    sFormacao.Append("</div>");
                }

                if (i == 3)
                {
                    sConsultoria.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\"  alt=\"\">");
                    sConsultoria.Append(" <div class=\"extra - wrap\">");
                    sConsultoria.Append("<a rel = \"leanModal\" href=\"#" + dTable.Rows[i]["UrlTemplate"].ToString() + "\" class=\"button1\">" + dTable.Rows[i]["Nome"].ToString() + "</a>");
                    sConsultoria.Append("<p>" + dTable.Rows[i]["Descricao"].ToString() + "</p>");
                    sConsultoria.Append("</div>");
                }
            }

            sHTMLServicosEstudos = sEstudos.ToString();
            sHTMLServicosAvaliacao = sAvaliacao.ToString();
            sHTMLServicosFormacao = sFormacao.ToString();
            sHTMLServicosConsultoria = sConsultoria.ToString();

        }

        public string GetHTMLDetalheServico(int sClassifier, string sServ, string sLabel, int Lingua)
        {
            StringBuilder sServico = new StringBuilder();
            Service oService = new Service();
            DataTable dTableSobre = new DataTable();

            sServico.Append("<div id = \"" + sServ + "\" class=\"ModalServicos\" style=\"top: 10px;\">");

            dTableSobre = oService.FEGetListConteudoClassificador((int)ContentType.Artigo, sClassifier, Lingua);

            sServico.Append(dTableSobre.Rows[0]["subtitulo"]);

            sServico.Append("<a rel=\"leanModal\" href=\"#SolicitarServico\"" + " onclick =\"document.all('FormModalServicos').innerHTML='" + sLabel + "'; \"" + " class=\"button\">" + sLabel + "</a>");

            sServico.Append("<a class=\"button\" onclick=\"$('#lean_overlay').click(); \" href =\"#\" style=\"margin-left:20px\" rel=\"leanModal\">Fechar</a>");

            sServico.Append("</div>");

            return sServico.ToString();
        }

        public string GetHTMLDetalheLinkPrincipaisAreas(int sClassifier, int Lingua)
        {
            StringBuilder sDetalhe = new StringBuilder();
            Service oService = new Service();
            DataTable dTableDetalhe = new DataTable();

            dTableDetalhe = oService.FEGetListConteudoClassificador((int)ContentType.Link, sClassifier, Lingua);

            for (int i = 0; i < dTableDetalhe.Rows.Count; i++)
            {
                sDetalhe.Append("<div id = \"" + dTableDetalhe.Rows[i]["url"] + "\" class=\"ModalServicos\">");
                sDetalhe.Append("<p><strong>" + dTableDetalhe.Rows[i]["Titulo"] + "</strong></p>	");
                sDetalhe.Append("<p>" + dTableDetalhe.Rows[i]["SubTitulo"] + " </p>	");
                sDetalhe.Append(" <a rel=\"leanModal\"  href=\"#SolicitarServico\" class=\"button\">Solicite o Serviço</a>");
                sDetalhe.Append("<a class=\"button\" onclick=\"$('#lean_overlay').click(); \" href =\"#\" style=\"margin-left:20px\" rel=\"leanModal\">Fechar</a>");

                sDetalhe.Append("</div>");
            }

            return sDetalhe.ToString();
        }

        public void GetHTMLPrincipaisAreas(out string sHTMLAreaA, out string sHTMLAreaB, out string sHTMLAreaC, out string sHTMLAreaD, int sClassifier, int Lingua)
        {
            StringBuilder sAreaA = new StringBuilder();
            StringBuilder sAreaB = new StringBuilder();
            StringBuilder sAreaC = new StringBuilder();
            StringBuilder sAreaD = new StringBuilder();

            Service oService = new Service();
            DataTable dTable = new DataTable();

            dTable = oService.FEGetClassificadorByPaiIDLingua(sClassifier, Lingua);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                if (i == 0)
                {

                    sAreaA.Append("<div class=\"wrapper\">");
                    sAreaA.Append("<div class=\"dropcap bgcolor2-" + (i + 1).ToString() + "\"><span>a</span></div>");
                    sAreaA.Append("<div class=\"extra-wrap title-2\">");
                    sAreaA.Append("<a><span>" + dTable.Rows[i]["Nome"] + "</a>");
                    sAreaA.Append("</div>");
                    sAreaA.Append("</div>");
                    sAreaA.Append(dTable.Rows[i]["Descricao"]);
                    sAreaA.Replace("href", "rel=\"leanModal\" href");

                }

                if (i == 1)
                {
                    sAreaB.Append("<div class=\"wrapper\">");
                    sAreaB.Append("<div class=\"dropcap bgcolor2-" + (i + 1).ToString() + "\"><span>b</span></div>");
                    sAreaB.Append("<div class=\"extra-wrap title-2\">");
                    sAreaB.Append("<a><span>" + dTable.Rows[i]["Nome"] + "</a>");
                    sAreaB.Append("</div>");
                    sAreaB.Append("</div>");
                    sAreaB.Append(dTable.Rows[i]["Descricao"]);
                    sAreaB.Replace("href", "rel=\"leanModal\" href");
                }

                if (i == 2)
                {
                    sAreaC.Append("<div class=\"wrapper\">");
                    sAreaC.Append("<div class=\"dropcap bgcolor2-" + (i + 1).ToString() + "\"><span>c</span></div>");
                    sAreaC.Append("<div class=\"extra-wrap title-2\">");
                    sAreaC.Append("<a><span>" + dTable.Rows[i]["Nome"] + "</a>");
                    sAreaC.Append("</div>");
                    sAreaC.Append("</div>");
                    sAreaC.Append(dTable.Rows[i]["Descricao"]);
                    sAreaC.Replace("href", "rel=\"leanModal\" href");
                }

                if (i == 3)
                {
                    sAreaD.Append("<div class=\"wrapper\">");
                    sAreaD.Append("<div class=\"dropcap bgcolor2-" + (i + 1).ToString() + "\"><span>d</span></div>");
                    sAreaD.Append("<div class=\"extra-wrap title-2\">");
                    sAreaD.Append("<a><span>" + dTable.Rows[i]["Nome"] + "</a>");
                    sAreaD.Append("</div>");
                    sAreaD.Append("</div>");
                    sAreaD.Append(dTable.Rows[i]["Descricao"]);
                    sAreaD.Replace("href", "rel=\"leanModal\" href");
                }
            }

            sHTMLAreaA = sAreaA.ToString();
            sHTMLAreaB = sAreaB.ToString();
            sHTMLAreaC = sAreaC.ToString();
            sHTMLAreaD = sAreaD.ToString();

        }

        public string GetHTMLParceiros(int sClassifier, int Lingua)
        {
            StringBuilder sParceiros = new StringBuilder();
            Service oService = new Service();
            DataTable dTable = new DataTable();
            string sClass = string.Empty;

            dTable = oService.FEGetListConteudoClassificador((int)ContentType.Media, sClassifier, Lingua);

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                sClass = string.Empty;

                if (i == 0 || i == 3 || i == 6)
                    sClass = "alpha";
                if (i == 2 || i == 5 || i == 8)
                    sClass = "omega";

                if (i == 0 || i == 3 || i == 6)
                    sParceiros.Append("<div class=\"wrapper\">");

                sParceiros.Append("<div class=\"grid_4 " + sClass + " padtop52\">");
                sParceiros.Append("<div class=\"box-product\">");
                sParceiros.Append("<img src=\"uploads/" + dTable.Rows[i]["Media"] + "\"  alt=\"\">");
                sParceiros.Append("<div class=\"title-2\"><a href = \"#\" >" + dTable.Rows[i]["titulo"] + "</a></div>");
                sParceiros.Append("<span>" + dTable.Rows[i]["subtitulo"] + "</span>");
                sParceiros.Append("</div>");
                sParceiros.Append("</div>");

                if (i == 2 || i == 5 || i == 8)
                    sParceiros.Append("</div>");

            }

            return sParceiros.ToString();
        }






    }
}