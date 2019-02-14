using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PIBLUANDA
{
    public partial class Service
    {
        public string getConnection()
        {
            return ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        }

        public string getKeyFromConfigFile(string sKey)
        {
            return ConfigurationManager.AppSettings[sKey].ToString();
        }

        public string getContent(string iContentType, string IDContent, string LinguaContent)
        {
            //switch (iContentType)
            //{
            //    case "1":
            //        return FEGetFAQByIDLingua(int.Parse(IDContent), int.Parse(LinguaContent));
            //    case "2":
            //        return FEGetLinkByIDLingua(int.Parse(IDContent), int.Parse(LinguaContent));
            //    case "4":
            //        return FEGetArticleByIDLingua(int.Parse(IDContent), int.Parse(LinguaContent));
            //    case "8":
            //        return FEGetMediaByIDLingua(int.Parse(IDContent), int.Parse(LinguaContent));
            //    case "9":
            //        return FEGetContactoByIDLingua(int.Parse(IDContent), int.Parse(LinguaContent));
            //    case "25":
            //        return FEGetBannerByIDLingua(int.Parse(IDContent), int.Parse(LinguaContent));
            //    default:
            //        return "";
            //}
            return "";
        }

        public DataTable FEGetClassificadorByIDLingua(int ClassificadorID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {

                con.Open();
                SqlCommand sqlCommand = new SqlCommand("spFEGetClassificador", con);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramClassificadorID = sqlCommand.Parameters.Add("@ClassificadorID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramClassificadorID.Value = ClassificadorID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }
            return dtable;
        }

        public DataTable FEGetFAQByIDLingua(int FAQID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetFAQ", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramFAQID = sqlCommand.Parameters.Add("@FAQID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramFAQID.Value = FAQID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;

        }

        public DataTable FEGetArticleByIDLingua(int ArtigoID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetArtigo", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramArtigoID = sqlCommand.Parameters.Add("@ArtigoID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramArtigoID.Value = ArtigoID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;
        }

        public DataTable FEGetMediaByIDLingua(int MediaID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetMedia", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramMediaID = sqlCommand.Parameters.Add("@MediaID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramMediaID.Value = MediaID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;
        }

        public DataTable FEGetLinkByIDLingua(int LinkID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spGetLink", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramLinkID = sqlCommand.Parameters.Add("@LinkID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramLinkID.Value = LinkID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;
        }

        public DataTable FEGetContactoByIDLingua(int ContactoID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetContacto", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramContactoID = sqlCommand.Parameters.Add("@ContactoID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramContactoID.Value = ContactoID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;

        }

        public DataTable FEGetBannerByIDLingua(int BannerID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetBanner", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramBannerID = sqlCommand.Parameters.Add("@BannerID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramBannerID.Value = BannerID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;

        }

        public DataTable FEGetClassificadorByPaiIDLingua(int ClassificadorPaiID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetClassificadoresByPai", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramClassificadorPaiID = sqlCommand.Parameters.Add("@ClassificadorPaiID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramClassificadorPaiID.Value = ClassificadorPaiID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;

        }

        public DataTable FEGetListConteudoClassificador(int TipoConteudo, int ClassificadorID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetListConteudoClassificador", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramTipoConteudo = sqlCommand.Parameters.Add("@TipoConteudo", SqlDbType.Int);
                SqlParameter paramClassificadorID = sqlCommand.Parameters.Add("@ClassificadorID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramTipoConteudo.Value = TipoConteudo;
                paramClassificadorID.Value = ClassificadorID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;

        }

        public DataTable FEGetListSeccoesArtigoByIDLingua(int ArtigoID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetListSeccoesArtigo", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramArtigoID = sqlCommand.Parameters.Add("@ArtigoID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramArtigoID.Value = ArtigoID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;
        }

        public DataTable FEGetGetListPerguntaRespostaByIDLingua(int FAQID, int Lingua)
        {
            DataTable dtable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnection()))
            {
                con.Open();
                //Actualizar o estado da marcação
                SqlCommand sqlCommand = new SqlCommand("spFEGetListPerguntaRespostaByFAQ", con);


                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramFAQID = sqlCommand.Parameters.Add("@FAQID", SqlDbType.Int);
                SqlParameter paramLingua = sqlCommand.Parameters.Add("@Lingua", SqlDbType.Int);

                paramFAQID.Value = FAQID;
                paramLingua.Value = Lingua;

                SqlDataAdapter adp = new SqlDataAdapter(sqlCommand);
                adp.Fill(dtable);
                con.Close();
            }

            return dtable;
        }

        public string ClientEncode(string html)
        {
            html = html.Replace("&quot;", "&quotx;");
            html = html.Replace("\"", "&quot;");
            html = html.Replace("&amp;", "&ampx;");
            html = html.Replace("&", "&amp;");
            html = html.Replace("&lt;", "&ltx;");
            html = html.Replace("<", "&lt;");
            html = html.Replace("&gt;", "&gtx;");
            html = html.Replace(">", "&gt;");

            return html;
        }
    }
}