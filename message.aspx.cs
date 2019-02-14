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
    public partial class message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = @"c:\temp\MyTest.txt";
            string xx = "";

            string[] keys = Request.Form.AllKeys;
            int i;
            for (i = 0; i < keys.Length; i++)
            {
                xx += keys[i] + "<br>";
            }



            string name = Request.Params["nome"];
            string email = Request.Params["email"];
            string telemovel = Request.Params["telemovel"];
            string mensagem = Request.Params["mensagem"];
            //string message = Request.Params["message"];
            //string owner_email = Request.Params["owner_email"];

            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to. 
                using (System.IO.StreamWriter sw = System.IO.File.CreateText(path))
                {
                    //   sw.WriteLine(xx);
                    sw.WriteLine(email);
                    sw.WriteLine(telemovel);
                    sw.WriteLine(mensagem);
                    sw.WriteLine(name);
                    //sw.WriteLine(owner_email);
                }
            }

            // Open the file to read from. 
            using (System.IO.StreamReader sr = System.IO.File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }


            //string name = Request.Params["nome"];
            //string email = Request.Params["email"];
            //string telemovel = Request.Params["telemovel"];
            //string mensagem = Request.Params["mensagem"];

            string sPasswordMail = string.Empty;

            sPasswordMail = ConfigurationManager.AppSettings["PWD_CONTACTO"].ToString();

            MailMessage MailMessage = new MailMessage();

            MailMessage.Subject = "Mensagem de PIB";
            MailMessage.Body = "Nome:" + name + "\n" + "Contactos:" + telemovel + "\n" + "Email:" + email + "   \n\n\n" + mensagem;

            //  MailMessage.Body = lario.Email + "\n" + "Título: " + formulario.Titulo;

            MailMessage.From = new System.Net.Mail.MailAddress(ConfigurationManager.AppSettings["EMAIL_TO_CONTACTO"].ToString());

            MailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings["EMAIL_TO_CONTACTO"].ToString()));

            SmtpClient Smtp = new SmtpClient();

            Smtp.Host = ConfigurationManager.AppSettings["SMTP"].ToString();

            Smtp.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["EMAIL_TO_CONTACTO"].ToString(), sPasswordMail);

            Smtp.Send(MailMessage);

           Response.Redirect("Contacte_nos.aspx");
        }

        [System.Web.Services.WebMethod]
        public static Formulario SendMail(Formulario formulario)
        {


            string sPasswordMail = string.Empty;

            sPasswordMail = ConfigurationManager.AppSettings["PWD_CONTACTO"].ToString();

            MailMessage MailMessage = new MailMessage();

            MailMessage.Subject = "Mensagem de PIB";

            //  MailMessage.Body = "Empresa: " + formulario.Empresa + "\n" + "E-mail: " + formulario.Email + "\n" + "Título: " + formulario.Titulo;

            MailMessage.From = new System.Net.Mail.MailAddress(ConfigurationManager.AppSettings["EMAIL_TO_CONTACTO"].ToString());

            MailMessage.To.Add(new MailAddress(ConfigurationManager.AppSettings["EMAIL_TO_CONTACTO"].ToString()));

            SmtpClient Smtp = new SmtpClient();

            Smtp.Host = ConfigurationManager.AppSettings["SMTP"].ToString();

            Smtp.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["EMAIL_TO_CONTACTO"].ToString(), sPasswordMail);

            Smtp.Send(MailMessage);

            return formulario;

        }


    }
    public class Formulario
    {
        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        private string telefone;
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }
}