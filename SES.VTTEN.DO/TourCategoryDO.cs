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
   public class TourCategoryDO
    {

        /// <summary>
        /// Summary description for TourCategoryDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string TOURCATEGORYID_FIELD ="TourCategoryID";
		public const string TITLE_FIELD ="Title";
		public const string ALIAS_FIELD ="Alias";
		public const string DESCRIPTION_FIELD ="Description";
		public const string METATAG_FIELD ="MetaTag";
		public const string METADES_FIELD ="MetaDes";
		public const string ORDERID_FIELD ="OrderID";
		public const string PUBLISHED_FIELD ="Published";
		public const string MODULEID_FIELD ="ModuleID";
		public const string TOURCATIMAGE_FIELD ="TourCatImage";
        public const string PARENTID_FIELD = "ParentID";
        public const string ISFRONTPAGE_FIELD = "IsFrontPage";

		#endregion
		
		#region Private Variables
					private Int32 _TourCategoryID;
		private String _Title;
		private String _Alias;
		private String _Description;
		private String _MetaTag;
		private String _MetaDes;
		private Int32 _OrderID;
		private Boolean _Published;
		private Int32 _ModuleID;
		private String _TourCatImage;
        private Int32 _ParentID;
        private Boolean _IsFrontPage;

		#endregion

		#region Public Properties
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
		public String TourCatImage
		{
			get
			{
				return _TourCatImage;
			}
			set
			{
				_TourCatImage = value;
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
        #endregion

	}
}
