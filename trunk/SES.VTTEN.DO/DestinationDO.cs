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
   public class DestinationDO
    {

        /// <summary>
        /// Summary description for DestinationDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string DESTINATIONID_FIELD ="DestinationID";
		public const string TITLE_FIELD ="Title";
		public const string ALIAS_FIELD ="Alias";
		public const string DESCRIPTION_FIELD ="Description";
		public const string DETAIL_FIELD ="Detail";
		public const string DESTINATIONIMAGE_FIELD ="DestinationImage";
		public const string TIMETOGO_FIELD ="TimeToGo";
		public const string DESTINATIONMAP_FIELD ="DestinationMap";
		public const string PARENTID_FIELD ="ParentID";
		public const string METATAG_FIELD ="MetaTag";
		public const string METADES_FIELD ="MetaDes";
		public const string ORDERID_FIELD ="OrderID";
		public const string PUBLISHED_FIELD ="Published";
		public const string MODULEID_FIELD ="ModuleID";
        public const string ISFRONTPAGE_FIELD = "IsFrontPage";
        public const string REGIONS_FIELD = "OrderID";

		#endregion
		
		#region Private Variables
					private Int32 _DestinationID;
		private String _Title;
		private String _Alias;
		private String _Description;
		private String _Detail;
		private String _DestinationImage;
		private String _TimeToGo;
		private String _DestinationMap;
		private Int32 _ParentID;
		private String _MetaTag;
		private String _MetaDes;
		private Int32 _OrderID;
		private Boolean _Published;
		private Int32 _ModuleID;
        private Boolean _IsFrontPage;
        private Int32 _Regions;

		#endregion

		#region Public Properties
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
		public String DestinationImage
		{
			get
			{
				return _DestinationImage;
			}
			set
			{
				_DestinationImage = value;
			}
		}
		public String TimeToGo
		{
			get
			{
				return _TimeToGo;
			}
			set
			{
				_TimeToGo = value;
			}
		}
		public String DestinationMap
		{
			get
			{
				return _DestinationMap;
			}
			set
			{
				_DestinationMap = value;
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
        public Int32 Regions
        {
            get
            {
                return _Regions;
            }
            set
            {
                _Regions = value;
            }
        }
        #endregion

	}
}
