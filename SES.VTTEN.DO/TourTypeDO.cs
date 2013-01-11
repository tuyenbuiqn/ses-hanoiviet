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
   public class TourTypeDO
    {

        /// <summary>
        /// Summary description for TourTypeDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string TOURTYPEID_FIELD ="TourTypeID";
		public const string TITLE_FIELD ="Title";
		public const string DESCRIPTION_FIELD ="Description";
		public const string ALIAS_FIELD ="Alias";
		public const string PUBLISHED_FIELD ="Published";
		public const string PARENTID_FIELD ="ParentID";
		public const string ORDERID_FIELD ="OrderID";
        public const string ISHOMEPAGE_FIELD = "IsHomepage";

		#endregion
		
		#region Private Variables
					private Int32 _TourTypeID;
		private String _Title;
		private String _Description;
		private String _Alias;
		private Boolean _Published;
		private Int32 _ParentID;
		private Int32 _OrderID;
        private Boolean _IsHomepage;

		#endregion
        public Boolean IsInboundTour { get; set; }
		#region Public Properties
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
        public Boolean IsHomepage
        {
            get
            {
                return _IsHomepage;
            }
            set
            {
                _IsHomepage = value;
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
		public Int32 ParentID
		{
			get
			{
				return _ParentID;
			}
			set
			{
				_ParentID = value;
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

        #endregion

	}
}
