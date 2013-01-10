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
   public class VideoDO
    {

        /// <summary>
        /// Summary description for VideoDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string VIDEOID_FIELD ="VideoID";
		public const string TITLE_FIELD ="Title";
		public const string LINK_FIELD ="Link";
		public const string DESCRIPTION_FIELD ="Description";
        public const string ISFRONTPAGE_FIELD = "isFrontPage";
        public const string ODERID_FIELD = "OderID";

		#endregion
		
		#region Private Variables
					private Int32 _VideoID;
		private String _Title;
		private String _Link;
		private String _Description;
        private Boolean _isFrontPage;
        private Int32 _OderID;
		#endregion

		#region Public Properties
					public Int32 VideoID
		{
			get
			{
				return _VideoID;
			}
			set
			{
				_VideoID = value;
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
		public String Link
		{
			get
			{
				return _Link;
			}
			set
			{
				_Link = value;
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
        public Boolean isFrontPage
        {
            get
            {
                return _isFrontPage;
            }
            set
            {
                _isFrontPage = value;
            }
        }
        public Int32 OderID
        {
            get
            {
                return _OderID;
            }
            set
            {
                _OderID = value;
            }
        }

        #endregion

	}
}
