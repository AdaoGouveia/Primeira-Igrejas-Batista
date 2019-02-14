using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIBLUANDA
{
    public partial class download : System.Web.UI.Page
    {
        public string sHTMLMenu = string.Empty;
        public string sHTMLListaMedia = string.Empty;
        public string sHTMLFooter = string.Empty;
        public string sHTMLLinkArtigoPoliticaPrivacidade = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            WebSite oSite = new WebSite();
            Service oService = new Service();

            string mid = Request.QueryString["mid"];
            int outmid;
            //Service oService = new Service();
            if (mid != null)
                if (int.TryParse(mid, out outmid))
                    sHTMLListaMedia = oSite.GetMedia(outmid, 1);

            //string filename = lnkfilepath.Text;
            //string Filpath = Server.MapPath("~/Attachments/" + filename);
            string Filpath = Server.MapPath(sHTMLListaMedia);
            DownLoad(Filpath);


        }

        //protected void lnkfilepath_Click(object sender, EventArgs e) // ur link button 
        //{
        //    string filename = lnkfilepath.Text;
        //    string Filpath = Server.MapPath("~/Attachments/" + filename);
        //    DownLoad(Filpath);
        //}
        public void DownLoad(string FName)
        {
            string path = FName;
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            if (file.Exists)
            {
                //Response.Clear();
                //Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name); Response.AddHeader("Content-Length", file.Length.ToString());
                //Response.ContentType = "application/pdf"; // download […]

                Response.ContentType = "application/pdf";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + file.Name);
                Response.TransmitFile(FName);
                Response.End();
            }


        }
    }
   

}