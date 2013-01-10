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
   public class CustomerReviewDO
    {

        /// <summary>
        /// Summary description for CustomerReviewDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CUSTOMERREVIEWID_FIELD ="CustomerReviewID";
		public const string TITLE_FIELD ="Title";
		public const string DESCRIPTION_FIELD ="Description";
		public const string DETAIL_FIELD ="Detail";
		public const string REVIEWIMG_FIELD ="ReviewImg";
		public const string TRIPADVISOR_FIELD ="TripAdvisor";
		public const string ALIAS_FIELD ="Alias";
		public const string ISFRONTPAGE_FIELD ="IsFrontPage";
		public const string TRIPADVISORLINK_FIELD ="TripAdvisorLink";

		#endregion
		
		#region Private Variables
					private Int32 _CustomerReviewID;
		private String _Title;
		private String _Description;
		private String _Detail;
		private String _ReviewImg;
		private Boolean _TripAdvisor;
		private String _Alias;
		private Boolean _IsFrontPage;
		private String _TripAdvisorLink;

		#endregion

		#region Public Properties
					public Int32 CustomerReviewID
		{
			get
			{
				return _CustomerReviewID;
			}
			set
			{
				_CustomerReviewID = value;
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
		public String ReviewImg
		{
			get
			{
				return _ReviewImg;
			}
			set
			{
				_ReviewImg = value;
			}
		}
		public Boolean TripAdvisor
		{
			get
			{
				return _TripAdvisor;
			}
			set
			{
				_TripAdvisor = value;
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
		public String TripAdvisorLink
		{
			get
			{
				return _TripAdvisorLink;
			}
			set
			{
				_TripAdvisorLink = value;
			}
		}

        #endregion

	}
}
