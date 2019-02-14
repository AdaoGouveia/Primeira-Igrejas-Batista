using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace PIBLUANDA
{
    public partial class _default : System.Web.UI.Page
    {
        public string sHTMLMenu = string.Empty;
        public string sHTMLBanner = string.Empty;
        public string sHTMLBanner2 = string.Empty;
        public string sHTMLBanner3 = string.Empty;
        public string sHTMLDestaques1 = string.Empty;
        public string sHTMLDestaques2 = string.Empty;
        public string sHTMLDestaques3 = string.Empty;
        public string sHTMLDestaques4 = string.Empty;
        public string sHTMLDestaques5 = string.Empty;
        public string sHTMLDestaques6 = string.Empty;
        public string sHTMLFooter = string.Empty;
        public string sHTMLNoticiasRecentes = string.Empty;
        public string sHTMLsitesRelacionados = string.Empty;

        

        public string sHTMLLinkArtigoPoliticaPrivacidade = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {

            WebSite oSite = new WebSite();
            Service oService = new Service();

            sHTMLMenu = oSite.GetHTMLMenu(int.Parse(oService.getKeyFromConfigFile("MENU")), 1, this.Page.AppRelativeVirtualPath.Substring(2).ToLower());

            sHTMLBanner = oSite.GetHTMLBanner(int.Parse(oService.getKeyFromConfigFile("BANNERS")), 1);
            sHTMLBanner2 = oSite.GetHTMLBanner2(int.Parse(oService.getKeyFromConfigFile("BANNERS2")), 1);
            sHTMLBanner3 = oSite.GetHTMLBanner3(int.Parse(oService.getKeyFromConfigFile("BANNERS3")), 1);
            sHTMLDestaques1 = oSite.GetHTMLDestaques1(int.Parse(oService.getKeyFromConfigFile("DESTAQUES1")), 1);
            sHTMLDestaques2 = oSite.GetHTMLDestaques2(int.Parse(oService.getKeyFromConfigFile("DESTAQUES2")), 1);
            sHTMLDestaques3 = oSite.GetHTMLDestaques3(int.Parse(oService.getKeyFromConfigFile("DESTAQUES3")), 1);
            sHTMLDestaques4 = oSite.GetHTMLDestaques4(int.Parse(oService.getKeyFromConfigFile("DESTAQUES4")), 1);
            sHTMLDestaques5 = oSite.GetHTMLDestaques5(int.Parse(oService.getKeyFromConfigFile("DESTAQUES5")), 1);
            sHTMLDestaques6 = oSite.GetHTMLDestaques6(int.Parse(oService.getKeyFromConfigFile("DESTAQUES6")), 1);
            sHTMLNoticiasRecentes = oSite.GetHTMLNoticiasRecentes(int.Parse(oService.getKeyFromConfigFile("NOTICIASRECENTES")), 1);
            sHTMLsitesRelacionados = oSite.GetHTMLSitesrelacionados(int.Parse(oService.getKeyFromConfigFile("SITESRELACIONADOS")), 1);
            sHTMLFooter = oSite.GetHTMLFooter(int.Parse(oService.getKeyFromConfigFile("FOOTER")), 1);
           
        }
    }


}