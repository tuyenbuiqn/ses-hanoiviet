/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Collections;

namespace SES.VTTEN.DO
{
    [Serializable]
    public class HotelDO
    {

        /// <summary>
        /// Summary description for HotelDO
        /// </summary>


        #region Public Constants (Fields name)
        public const string HOTELID_FIELD = "HotelID";
        public const string TITLE_FIELD = "Title";
        public const string ALIAS_FIELD = "Alias";
        public const string DESCRIPTION_FIELD = "Description";
        public const string DETAIL_FIELD = "Detail";
        public const string HOTELIMAGE_FIELD = "HotelImage";
        public const string STARRATES_FIELD = "StarRates";
        public const string CONTACTINFO_FIELD = "ContactInfo";
        public const string DESTINATIONID_FIELD = "DestinationID";
        public const string METATAG_FIELD = "MetaTag";
        public const string METADES_FIELD = "MetaDes";
        public const string ORDERID_FIELD = "OrderID";
        public const string PUBLISHED_FIELD = "Published";
        public const string MODULEID_FIELD = "ModuleID";
        public const string ISFRONTPAGE_FIELD = "IsFrontPage";
        public const string HOTELSTARTPRICE_FIELD = "HotelStartPrice";
        public const string ISMENU = "IsMenu";

        #endregion

        #region Private Variables
        private Int32 _HotelID;
        private String _Title;
        private String _Alias;
        private String _Description;
        private String _Detail;
        private String _HotelImage;
        private Int32 _StarRates;
        private String _ContactInfo;
        private Int32 _DestinationID;
        private String _MetaTag;
        private String _MetaDes;
        private Int32 _OrderID;
        private Boolean _Published;
        private Int32 _ModuleID;
        private Boolean _IsFrontPage;
        private Int32 _HotelStartPrice;
        private Boolean _IsMenu;

        #endregion

        #region Public Properties
        public Int32 HotelID
        {
            get
            {
                return _HotelID;
            }
            set
            {
                _HotelID = value;
            }
        }
        public Int32 HotelStartPrice
        {
            get
            {
                return _HotelStartPrice;
            }
            set
            {
                _HotelStartPrice = value;
            }
        }
        public String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        public String Alias
        {
            get
            {
                return _Alias;
            }
            set
            {
                _Alias = value;
            }
        }
        public String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
        public String Detail
        {
            get
            {
                return _Detail;
            }
            set
            {
                _Detail = value;
            }
        }
        public String HotelImage
        {
            get
            {
                return _HotelImage;
            }
            set
            {
                _HotelImage = value;
            }
        }
        public Int32 StarRates
        {
            get
            {
                return _StarRates;
            }
            set
            {
                _StarRates = value;
            }
        }
        public String ContactInfo
        {
            get
            {
                return _ContactInfo;
            }
            set
            {
                _ContactInfo = value;
            }
        }
        public Int32 DestinationID
        {
            get
            {
                return _DestinationID;
            }
            set
            {
                _DestinationID = value;
            }
        }
        public String MetaTag
        {
            get
            {
                return _MetaTag;
            }
            set
            {
                _MetaTag = value;
            }
        }
        public String MetaDes
        {
            get
            {
                return _MetaDes;
            }
            set
            {
                _MetaDes = value;
            }
        }
        public Int32 OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                _OrderID = value;
            }
        }
        public Boolean Published
        {
            get
            {
                return _Published;
            }
            set
            {
                _Published = value;
            }
        }
        public Int32 ModuleID
        {
            get
            {
                return _ModuleID;
            }
            set
            {
                _ModuleID = value;
            }
        }
        public Boolean IsFrontPage
        {
            get
            {
                return _IsFrontPage;
            }
            set
            {
                _IsFrontPage = value;
            }
        }
        public Boolean IsMenu
        {
            get
            {
                return _IsMenu;
            }
            set
            {
                _IsMenu = value;
            }
        }
        #endregion

    }
}
