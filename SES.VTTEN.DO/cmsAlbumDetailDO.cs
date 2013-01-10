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
   public class cmsAlbumDetailDO
    {

        /// <summary>
        /// Summary description for cmsAlbumDetailDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ALBUMDETAILID_FIELD ="AlbumDetailID";
		public const string TITLE_FIELD ="Title";
		public const string DESCRIPTION_FIELD ="Description";
		public const string ALBUMID_FIELD ="AlbumID";
		public const string URL_FIELD ="Url";
		public const string ORDERID_FIELD ="OrderID";
		public const string OTHERID_FIELD ="OtherID";

		#endregion
		
		#region Private Variables
					private Int32 _AlbumDetailID;
		private String _Title;
		private String _Description;
		private Int32 _AlbumID;
		private String _Url;
		private Int32 _OrderID;
		private Int32 _OtherID;

		#endregion

		#region Public Properties
					public Int32 AlbumDetailID
		{
			get
			{
				return _AlbumDetailID;
			}
			set
			{
				_AlbumDetailID = value;
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
		public Int32 AlbumID
		{
			get
			{
				return _AlbumID;
			}
			set
			{
				_AlbumID = value;
			}
		}
		public String Url
		{
			get
			{
				return _Url;
			}
			set
			{
				_Url = value;
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
		public Int32 OtherID
		{
			get
			{
				return _OtherID;
			}
			set
			{
				_OtherID = value;
			}
		}

        #endregion

	}
}
