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
   public class ContentDO
    {

        /// <summary>
        /// Summary description for ContentDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CONTENTID_FIELD ="ContentID";
		public const string TITLE_FIELD ="Title";
		public const string ALIAS_FIELD ="Alias";
		public const string DESCRIPTION_FIELD ="Description";
		public const string CONTENTDETAIL_FIELD ="ContentDetail";
		public const string CONTENTTYPEID_FIELD ="ContentTypeID";
		public const string METATAG_FIELD ="MetaTag";
		public const string METADES_FIELD ="MetaDes";
		public const string ORDERID_FIELD ="OrderID";
		public const string PUBLISHED_FIELD ="Published";
		public const string MODULEID_FIELD ="ModuleID";
        public const string ISFRONTPAGE_FIELD = "IsFrontPage";
        public const string CONTENTIMAGE_FIELD = "ContentImage";

		#endregion
		
		#region Private Variables
					private Int32 _ContentID;
		private String _Title;
		private String _Alias;
		private String _Description;
		private String _ContentDetail;
		private Int32 _ContentTypeID;
		private String _MetaTag;
		private String _MetaDes;
		private Int32 _OrderID;
		private Boolean _Published;
		private Int32 _ModuleID;
        private Boolean _IsFrontPage;
        private String _ContentImage;

		#endregion

		#region Public Properties
					public Int32 ContentID
		{
			get
			{
				return _ContentID;
			}
			set
			{
				_ContentID = value;
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
		public String ContentDetail
		{
			get
			{
				return _ContentDetail;
			}
			set
			{
				_ContentDetail = value;
			}
		}
		public Int32 ContentTypeID
		{
			get
			{
				return _ContentTypeID;
			}
			set
			{
				_ContentTypeID = value;
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
        public String ContentImage
        {
            get
            {
                return _ContentImage;
            }
            set
            {
                _ContentImage = value;
            }
        }
        #endregion

	}
}
