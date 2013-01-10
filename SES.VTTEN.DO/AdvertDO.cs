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
   public class AdvertDO
    {

        /// <summary>
        /// Summary description for AdvertDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ADVERTID_FIELD ="AdvertID";
		public const string TITLE_FIELD ="Title";
		public const string MEDIAID_FIELD ="MediaID";
		public const string HTMLCONTENT_FIELD ="HTMLContent";
		public const string PUBLISHED_FIELD ="Published";
		public const string MODULEID_FIELD ="ModuleID";
		public const string TIMESTART_FIELD ="TimeStart";
		public const string TIMEEXPIRE_FIELD ="TimeExpire";
        public const string ISLEFT_FIELD = "isLeft";
        public const string ORDERID_FIELD = "OrderID";
        public const string LOCATION_FIELD = "Location";
		#endregion
		
		#region Private Variables
					private Int32 _AdvertID;
		private String _Title;
		private Int32 _MediaID;
		private String _HTMLContent;
		private Boolean _Published;
		private Int32 _ModuleID;
        private Nullable<DateTime> _TimeStart;
        private Nullable<DateTime> _TimeExpire;
        private Boolean _isLeft;
        private Int32 _OrderID;
        private String _Location;

		#endregion

		#region Public Properties
					public Int32 AdvertID
		{
			get
			{
				return _AdvertID;
			}
			set
			{
				_AdvertID = value;
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
		public Int32 MediaID
		{
			get
			{
				return _MediaID;
			}
			set
			{
				_MediaID = value;
			}
		}
		public String HTMLContent
		{
			get
			{
				return _HTMLContent;
			}
			set
			{
				_HTMLContent = value;
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
        public Nullable<DateTime> TimeStart
		{
			get
			{
				return _TimeStart;
			}
			set
			{
				_TimeStart = value;
			}
		}
        public Nullable<DateTime> TimeExpire
		{
			get
			{
				return _TimeExpire;
			}
			set
			{
				_TimeExpire = value;
			}
		}
        public Boolean isLeft
        {
            get
            {
                return _isLeft;
            }
            set
            {
                _isLeft = value;
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
        public String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                _Location = value;
            }
        }
        #endregion

	}
}
