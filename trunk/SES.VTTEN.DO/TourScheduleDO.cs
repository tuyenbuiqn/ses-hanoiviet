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
   public class TourScheduleDO
    {

        /// <summary>
        /// Summary description for TourScheduleDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
		public const string TOURSCHEDULEID_FIELD ="TourScheduleID";
		public const string TOURID_FIELD ="TourID";
		public const string TITLE_FIELD ="Title";
		public const string DAYNO_FIELD ="DayNo";
		public const string DESCRIPTION_FIELD ="Description";

		#endregion
		
		#region Private Variables
		private Int32 _TourScheduleID;
		private Int32 _TourID;
		private String _Title;
		private Int32 _DayNo;
        private String _Description;

		#endregion

		#region Public Properties
		public Int32 TourScheduleID
		{
			get
			{
				return _TourScheduleID;
			}
			set
			{
				_TourScheduleID = value;
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
		public Int32 DayNo
		{
			get
			{
				return _DayNo;
			}
			set
			{
				_DayNo = value;
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

        #endregion

	}
}
