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
   public class ServiceDO
    {

        /// <summary>
        /// Summary description for ServiceDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string SERVICEID_FIELD ="ServiceID";
		public const string TITLE_FIELD ="Title";
		public const string ALIAS_FIELD ="Alias";
		public const string DESCRIPTION_FIELD ="Description";
		public const string DETAIL_FIELD ="Detail";
		public const string SERVICEIMAGE_FIELD ="ServiceImage";
		public const string METATAG_FIELD ="MetaTag";
		public const string METADES_FIELD ="MetaDes";
		public const string ORDERID_FIELD ="OrderID";
		public const string PUBLISHED_FIELD ="Published";
		public const string MODULEID_FIELD ="ModuleID";

		#endregion
		
		#region Private Variables
					private Int32 _ServiceID;
                    private String _Title;
		private String _Alias;
		private String _Description;
		private String _Detail;
		private String _ServiceImage;
		private String _MetaTag;
		private String _MetaDes;
		private Int32 _OrderID;
		private Boolean _Published;
		private Int32 _ModuleID;

		#endregion

		#region Public Properties
					public Int32 ServiceID
		{
			get
			{
				return _ServiceID;
			}
			set
			{
				_ServiceID = value;
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
		public String ServiceImage
		{
			get
			{
				return _ServiceImage;
			}
			set
			{
				_ServiceImage = value;
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

        #endregion

	}
}
