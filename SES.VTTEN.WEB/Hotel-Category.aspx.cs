﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB
{
    public partial class Hotel_Category : System.Web.UI.Page
    {
        DestinationDO objHT = new DestinationDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int DestinationID = int.Parse(Request.QueryString["ID"].ToString());
                try
                {
                    objHT = new DestinationBL().Select(new DestinationDO { DestinationID = DestinationID });
                }
                catch (Exception)
                {
                    
                    throw;
                }
                if (objHT != null)
                {
                    lblTitle.Text = objHT.Title;
                    if (DestinationID == 0)
                    {
                        lblTitle.Text = " Danh sách toàn bộ khách sạn";
                    }

                    HtmlMeta metaDesc = new HtmlMeta();
                    metaDesc.Name = "description";
                    if ((objHT.MetaDes == "")||(objHT.MetaDes == null))
                    {
                        metaDesc.Content = "Danh sách khách sạn - hanoiviettravel";
                    }
                    else
                    {
                        metaDesc.Content = objHT.MetaDes;
                    }
                    Page.Header.Controls.Add(metaDesc);

                    HtmlMeta metaKey = new HtmlMeta();
                    metaKey.Name = "keywords";
                    if ((objHT.MetaTag == "")||(objHT.MetaTag == null))
                    {
                        metaKey.Content = "Danh sách khách sạn - hanoiviettravel";
                    }
                    else
                    {
                        metaKey.Content = objHT.MetaTag;
                    }
                    Page.Header.Controls.Add(metaKey);

                    if ((objHT.Title == "")||(objHT.Title == null))
                    {
                        Page.Title = "Danh sách khách sạn - hanoiviettravel";
                    }
                    else
                    {
                        Page.Title = objHT.Title;
                    }
                }
            }
        }
    }
}
