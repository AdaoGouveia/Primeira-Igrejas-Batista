using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIBLUANDA
{
    public partial class Gruposcorais : System.Web.UI.Page
    {
        public string sHTMLMenu = string.Empty;
        public string sHTMLFooter = string.Empty;
        public string sHTMLGruposcorais = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            WebSite oSite = new WebSite();
            Service oService = new Service();

            sHTMLMenu = oSite.GetHTMLMenu(int.Parse(oService.getKeyFromConfigFile("MENU")), 1, this.Page.AppRelativeVirtualPath.Substring(2).ToLower());
            sHTMLGruposcorais = oSite.GetHTMLGruposcorais(int.Parse(oService.getKeyFromConfigFile("GRUPOSCORAIS")), 1);
            sHTMLFooter = oSite.GetHTMLFooter(int.Parse(oService.getKeyFromConfigFile("FOOTER")), 1);
        }
    }
}