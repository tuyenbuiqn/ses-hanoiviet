using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using SES.VTTEN.BL;
using SES.VTTEN.DO;
using System.Net.Configuration;
using System.Net.Mail;
using System.Configuration;

namespace SES.VTTEN.WEB
{
    public class Ultility
    {
        public static string Webtile()
        {
            return " - " + new ConfigBL().Select(new ConfigDO { ConfigID = 1 }).ConfigValue.ToString();

        }
        public static void Alert(string msg, string url)
        {
            // Cleans the message to allow single quotation marks
            string cleanMessage = msg.Replace("'", "\\'");
            string script = "<script type=\"text/javascript\">alert('" + cleanMessage + "');location='" + url + "';</script>";

            // Gets the executing web page
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("Ultility"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(Ultility), "Ultility", script);
            }
        }
        public static void Alert(string msg)
        {
            // Cleans the message to allow single quotation marks
            string cleanMessage = msg.Replace("'", "\\'");
            string script = "<script type=\"text/javascript\">alert('" + cleanMessage + "');</script>";

            // Gets the executing web page
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("Ultility"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(Ultility), "Ultility", script);
            }
        }
        public static void RedirectPage(string url)
        {
            // Cleans the message to allow single quotation marks
            string script = "<script type=\"text/javascript\">location='" + url + "';</script>";

            // Gets the executing web page
            Page page = HttpContext.Current.CurrentHandler as Page;

            // Checks if the handler is a Page and that the script isn't allready on the Page
            if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("Ultility"))
            {
                page.ClientScript.RegisterClientScriptBlock(typeof(Ultility), "Ultility", script);
            }
        }
        public static string EncryptMd5(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] b1 = UTF8Encoding.UTF8.GetBytes(str);
            byte[] b2 = md5.ComputeHash(b1);
            string encrypted = BitConverter.ToString(b2).Replace("-", "");
            return encrypted;
        }
        public static void GvDatabinder(DevExpress.Web.ASPxGridView.ASPxGridView gv, object obDataSource)
        {
            gv.DataSource = obDataSource;
            gv.DataBind();
        }


        public static void DevCboDatabinder(DevExpress.Web.ASPxEditors.ASPxComboBox cbo,string dtField, string TxtField, object obDataSource)
        {
            cbo.DataSource = obDataSource;
            cbo.TextField = TxtField;
            cbo.ValueField = dtField;  
            cbo.DataBind();
            cbo.Items.Insert(0,cbo.Items.Add("---Select All---", "All"));
            cbo.SelectedIndex = 0;

        }
        public static bool Email(string Email)
        {
            return Regex.IsMatch(Email, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");
        }

        public static void ddlDatabinder(DropDownList ddl, string DataField, string TextField, object obDataSource)
        {
            ddl.DataSource = obDataSource;
            ddl.DataValueField = DataField;
            ddl.DataTextField = TextField;
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("", null));
        }
        public static void ddlDatabinder(DropDownList ddl, string DataField, string TextField, object obDataSource, string labels)
        {
            ddl.DataSource = obDataSource;
            ddl.DataValueField = DataField;
            ddl.DataTextField = TextField;
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem(labels, null));
        }
        public static string Change_AV(string ip_str_change)
        {
            Regex v_reg_regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string v_str_FormD = ip_str_change.Normalize(NormalizationForm.FormD);
            string rt = v_reg_regex.Replace(v_str_FormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').Replace(" ", "-").Replace("/", "-");
            rt = rt.Replace("\\", "-").Replace("'", "-").Replace(":", "-").Replace("%", "phan-tram").Replace("?", "-").Replace("&", "-");
            rt = rt.Replace("--", "-") + ".aspx";
            return rt;

        }


        public static string TagDataBindding(string tag, string aclass)
        {
            string urltag = "/Tags/1/";
            string TotalTag = "";
            TotalTag = tag;
            DataTable dt = new DataTable();
            dt.Columns.Add("TagItem");
            string tagItem = "";
            DataRow row;
            string fulltag = "";
            if (String.IsNullOrEmpty(TotalTag))
                return null;
            for (int i = 0; i < TotalTag.Length; i++)
            {
                if (TotalTag[i] != ',')
                {
                    tagItem += TotalTag[i];
                }
                else
                {
                    row = dt.NewRow();
                    row[0] = CreateTagURL(tagItem, urltag, aclass);
                    dt.Rows.Add(row);
                    tagItem = "";
                }
                if (tagItem.Length > 0)
                    if (i == TotalTag.Length - 1 && TotalTag[i] != ',')
                    {
                        row = dt.NewRow();
                        row[0] = CreateTagURL(tagItem, urltag, aclass);
                        dt.Rows.Add(row);
                        tagItem = "";
                    }
            }
            foreach(DataRow dr in dt.Rows)
            {
                fulltag = fulltag + dr["TagItem"].ToString();
            }
            return fulltag;
        }

        public static string CreateTagURL(string tag, string urltag, string aclass)
        {
            tag = tag.Replace(".", "");
            return "<a href='" + urltag + tag + ".html'>" + tag + "</a>,&nbsp;";
        }

        public static void bindatalist(DataTable dt, Repeater rpt, ImageButton cmdPrev, ImageButton cmdNext, int CurrentPage)
        {
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dt.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 10;
            objPds.CurrentPageIndex = CurrentPage;
            cmdPrev.Visible = !objPds.IsFirstPage;
            cmdNext.Visible = !objPds.IsLastPage;
            rpt.DataSource = objPds;
            rpt.DataBind();
        }

        public static string WordCut(string text, int cutOffLength, char[] separators)
        {
            cutOffLength = cutOffLength > text.Length ? text.Length : cutOffLength;
            int separatorIndex = text.Substring(0, cutOffLength).LastIndexOfAny(separators);
            if (separatorIndex > 0)
                return text.Substring(0, separatorIndex);
            return text.Substring(0, cutOffLength);
        }
        public static string StarRate(int k)
        {
            string sao = "";
            for (int i = 1; i <= k; i++)
            {
                sao = sao + "<img alt='" + k.ToString() + " Star Hotel' title='" + k.ToString() + " Star Hotel' src='/images/star-blue.png' />";

            }
            return sao;
        }

        public static string StarRateHome(int k)
        {
            string sao = "";
            for (int i = 1; i <= k; i++)
            {
                sao = sao + "<img width='15px' alt='" + k.ToString() + " Star Hotel' title='" + k.ToString() + " Star Hotel' src='/images/star-blue.png' />";

            }
            return sao;
        }
        //Send mail
        public static String Address
        {
            get
            {
                SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                return cfg.Network.UserName;
            }
        }
        public static String Pass
        {
            get
            {
                SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                return cfg.Network.Password;
            }
        }
        public static void sendsMail(String name, String bd, string title)
        {
            string i = DateTime.Now.ToString();

            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential(Address, Pass);
            SmtpServer.Port = 587;
            SmtpServer.Host = "Smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            String addr = new ConfigBL().Select(new ConfigDO { ConfigID = 2 }).ConfigValue.ToString();

            try
            {
                mail.From = new MailAddress(addr, name, System.Text.Encoding.UTF8);
                mail.To.Add(addr);
                //Lấy danh sách gửi kèm ở đây....
                mail.Subject = title;
                mail.Body = bd;
                mail.IsBodyHtml = true;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
            }
        }
        public static void sendsMails(String name, String bd, string title,int type,int id)
        {
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential(Address, Pass);
            SmtpServer.Port = 587;
            SmtpServer.Host = "Smtp.gmail.com";
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage();
            String addr = new ConfigBL().Select(new ConfigDO { ConfigID = 2 }).ConfigValue.ToString();
            DataTable dtEmailAccouts = new UserDestinationBL().GetEmailOfDestination(type,id);
            string sEmailAddress = "";
            if (dtEmailAccouts.Rows.Count > 0)
            {
                for (int i = 0; i < dtEmailAccouts.Rows.Count; i++)
                {
                    sEmailAddress += dtEmailAccouts.Rows[i]["Email"].ToString() + ",";
                }
            }
            else sEmailAddress = "";
            try
            {
                mail.From = new MailAddress(addr, name, System.Text.Encoding.UTF8);
                mail.To.Add(addr);
                //Lấy danh sách gửi kèm ở đây....
                if (sEmailAddress != "")
                {
                    mail.CC.Add(sEmailAddress);
                }
                mail.Subject = title;
                mail.Body = bd;
                mail.IsBodyHtml = true;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
            }
        }
    }

}
