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
   public class PhotoAlbumDO
    {

        /// <summary>
        /// Summary description for PhotoAlbumDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ALBUMID_FIELD ="AlbumID";
		public const string TITLE_FIELD ="Title";
		public const string ALBUMCOVER_FIELD ="AlbumCover";
		public const string PUBLISHED_FIELD ="Published";
        public const string ALIAS_FIELD = "Alias";

		#endregion
		
		#region Private Variables
					private Int32 _AlbumID;
		private String _Title;
		private Int32 _AlbumCover;
		private Boolean _Published;
        private String _Alias;

		#endregion

		#region Public Properties
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
		public Int32 AlbumCover
		{
			get
			{
				return _AlbumCover;
			}
			set
			{
				_AlbumCover = value;
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
        #endregion

	}
}
