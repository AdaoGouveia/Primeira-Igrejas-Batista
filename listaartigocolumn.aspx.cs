using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIBLUANDA
{
    public partial class listaartigocolumn : System.Web.UI.Page
    {
        public string sHTMLMenu = string.Empty;
        public string sHTMLListaArtigoColumn = string.Empty;
        public string sHTMLFooter = string.Empty;
        public string sHTMLLinkArtigoPoliticaPrivacidade = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            WebSite oSite = new WebSite();
            Service oService = new Service();

            sHTMLMenu = oSite.GetHTMLMenu(int.Parse(oService.getKeyFromConfigFile("MENU")), 1, this.Page.AppRelativeVirtualPath.Substring(2).ToLower());

            sHTMLFooter = oSite.GetHTMLFooter(int.Parse(oService.getKeyFromConfigFile("FOOTER")), 1);

            sHTMLLinkArtigoPoliticaPrivacidade = oSite.GetHTMLLinkArtigoClassificado(int.Parse(oService.getKeyFromConfigFile("FOOTER")), 1);


            
            string cid = Request.QueryString["cid"];
            int outcid;
            //Service oService = new Service();
            if (cid != null)
                if (int.TryParse(cid, out outcid))
                    sHTMLListaArtigoColumn = oSite.GetHTMLListaArtigoColumn(outcid, 1);

        }
    }
}