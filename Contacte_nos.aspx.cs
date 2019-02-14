using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Configuration;


namespace PIBLUANDA
{
    public partial class Contacte_nos : System.Web.UI.Page
    {
        public string sHTMLMenu = string.Empty;
        public string sHTMLBanner = string.Empty;
        public string sHTMLFooter = string.Empty;
        public string sHTMLContactos = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            WebSite oSite = new WebSite();
            Service oService = new Service();

            sHTMLMenu = oSite.GetHTMLMenu(int.Parse(oService.getKeyFromConfigFile("MENU")), 1, this.Page.AppRelativeVirtualPath.Substring(2).ToLower());
            sHTMLBanner = oSite.GetHTMLBanner(int.Parse(oService.getKeyFromConfigFile("BANNERS")), 1);
            sHTMLFooter = oSite.GetHTMLFooter(int.Parse(oService.getKeyFromConfigFile("FOOTER")), 1);
            sHTMLContactos = oSite.GetHTMLContacte_nos(int.Parse(oService.getKeyFromConfigFile("CONTACTO")), 1);
        }



        protected void btnenviar_Click(object sender, EventArgs e)
        {

        
           
        }

        protected void btnemail_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnenvio_Click(object sender, EventArgs e)
        {

        }

        protected void btnenviarmail_Click(object sender, EventArgs e)
        {
            

    
          
           
        }
    }
}