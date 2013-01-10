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
   public class MediaDO
    {

        /// <summary>
        /// Summary description for MediaDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string MEDIAID_FIELD ="MediaID";
		public const string MEDIATYPE_FIELD ="MediaType";
		public const string MEDIAFILE_FIELD ="MediaFile";
		public const string DESCRIPTION_FIELD ="Description";
		public const string TITLE_FIELD ="Title";
		public const string DATEUPLOAD_FIELD ="DateUpload";
		public const string MEDIAURL_FIELD ="MediaUrl";
		public const string ORDERID_FIELD ="OrderID";
		public const string PUBLISHED_FIELD ="Published";
		public const string METATAG_FIELD ="MetaTag";
		public const string HOTELID_FIELD ="HotelID";
		public const string TOURID_FIELD ="TourID";
		public const string ISRIGHT_FIELD ="isRight";
        public const string ISLEFT_FIELD = "isLeft";
        public const string ISFOOTER_FIELD = "isFooter";
        public const string ALBUMID_FIELD = "AlbumID";
		#endregion
		
		#region Private Variables
					private Int32 _MediaID;
		private Boolean _MediaType;
		private String _MediaFile;
		private String _Description;
		private String _Title;
		private DateTime _DateUpload;
		private String _MediaUrl;
		private Int32 _OrderID;
		private Boolean _Published;
		private String _MetaTag;
		private Int32 _HotelID;
		private Int32 _TourID;
		private Int32 _DestinationID;
        private Boolean _isRight;
        private Boolean _isLeft;
        private Boolean _isFooter;
        private Int32 _AlbumID;

		#endregion

		#region Public Properties
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
		public Boolean MediaType
		{
			get
			{
				return _MediaType;
			}
			set
			{
				_MediaType = value;
			}
		}
		public String MediaFile
		{
			get
			{
				return _MediaFile;
			}
			set
			{
				_MediaFile = value;
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
		public DateTime DateUpload
		{
			get
			{
				return _DateUpload;
			}
			set
			{
				_DateUpload = value;
			}
		}
		public String MediaUrl
		{
			get
			{
				return _MediaUrl;
			}
			set
			{
				_MediaUrl = value;
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
        public Boolean isRight
        {
            get
            {
                return _isRight;
            }
            set
            {
                _isRight = value;
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
        public Boolean isFooter
        {
            get
            {
                return _isFooter;
            }
            set
            {
                _isFooter = value;
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
        #endregion

	}
}
