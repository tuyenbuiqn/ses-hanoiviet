/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Collections;

namespace SES.VTTEN.DO
{
   [Serializable ]
   public class TourDO
    {

        /// <summary>
        /// Summary description for TourDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
        public const string TOURID_FIELD ="TourID";
		public const string TOURCATEGORYID_FIELD ="TourCategoryID";
		public const string TITLE_FIELD ="Title";
		public const string ALIAS_FIELD ="Alias";
		public const string TOURCODE_FIELD ="TourCode";
		public const string TOURPRICE_FIELD ="TourPrice";
		public const string DESCRIPTION_FIELD ="Description";
		public const string DURATIONDAY_FIELD ="DurationDay";
		public const string IMAGEFULL_FIELD ="ImageFull";
		public const string NONINCLUDE_FIELD ="NonInclude";
		public const string TOURIMAGE_FIELD ="TourImage";
		public const string NOTES_FIELD ="Notes";
		public const string DURATIONNIGHT_FIELD ="DurationNight";
		public const string TODESTINATIONID_FIELD ="ToDestinationID";
		public const string METATAG_FIELD ="MetaTag";
		public const string METADES_FIELD ="MetaDes";
		public const string ORDERID_FIELD ="OrderID";
		public const string PUBLISHED_FIELD ="Published";
		public const string MODULEID_FIELD ="ModuleID";
        public const string ISFRONTPAGE_FIELD = "IsFrontPage";
        public const string TOURTYPEID_FIELD = "TourTypeID";
        public const string TOURALLPRICE_FIELD = "TourAllPrice";
        public const string ISSALEOFF = "IsSaleOff";
        public const string ISMENU = "IsMenu";
        public const string ISOUTPROMOTION = "IsOutPromotion";

		#endregion
		
		#region Private Variables
					private Int32 _TourID;
		private Int32 _TourCategoryID;
		private String _Title;
		private String _Alias;
		private String _TourCode;
		private Double _TourPrice;
		private String _Description;
		private Int32 _DurationDay;
        private String _ImageFull;
		private String _NonInclude;
		private String _TourImage;
		private String _Notes;
		private Int32 _DurationNight;
		private Int32 _ToDestinationID;
		private String _MetaTag;
		private String _MetaDes;
		private Int32 _OrderID;
		private Boolean _Published;
		private Int32 _ModuleID;
        private Boolean _IsFrontPage;
        private Int32 _TourTypeID;
        private String _TourAllPrice;
        private Boolean _IsSaleOff;
        private Boolean _IsMenu;
        private Boolean _IsOutPromotion;

		#endregion

		#region Public Properties
					public Int32 TourID
		{
			get
			{
				return _TourID;
			}
			set
			{
				_TourID = value;
			}
		}
                    public Int32 TourTypeID
                    {
                        get
                        {
                            return _TourTypeID;
                        }
                        set
                        {
                            _TourTypeID = value;
                        }
                    }
		public Int32 TourCategoryID
		{
			get
			{
				return _TourCategoryID;
			}
			set
			{
				_TourCategoryID = value;
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
        public String TourAllPrice
        {
            get
            {
                return _TourAllPrice;
            }
            set
            {
                _TourAllPrice = value;
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
		public String TourCode
		{
			get
			{
				return _TourCode;
			}
			set
			{
				_TourCode = value;
			}
		}
		public Double TourPrice
		{
			get
			{
				return _TourPrice;
			}
			set
			{
				_TourPrice = value;
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
		public Int32 DurationDay
		{
			get
			{
                return _DurationDay;
			}
			set
			{
                _DurationDay = value;
			}
		}
		public String ImageFull
		{
			get
			{
                return _ImageFull;
			}
			set
			{
                _ImageFull = value;
			}
		}
		public String NonInclude
		{
			get
			{
				return _NonInclude;
			}
			set
			{
				_NonInclude = value;
			}
		}
		public String TourImage
		{
			get
			{
				return _TourImage;
			}
			set
			{
				_TourImage = value;
			}
		}
		public String Notes
		{
			get
			{
				return _Notes;
			}
			set
			{
				_Notes = value;
			}
		}
		public Int32 DurationNight
		{
			get
			{
                return _DurationNight;
			}
			set
			{
                _DurationNight = value;
			}
		}
		public Int32 ToDestinationID
		{
			get
			{
				return _ToDestinationID;
			}
			set
			{
				_ToDestinationID = value;
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

        public Boolean IsSaleOff
        {
            get
            {
                return _IsSaleOff;
            }
            set
            {
                _IsSaleOff = value;
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

        public Boolean IsOutPromotion
        {
            get
            {
                return _IsOutPromotion;
            }
            set
            {
                _IsOutPromotion = value;
            }
        }
        #endregion

	}
}
