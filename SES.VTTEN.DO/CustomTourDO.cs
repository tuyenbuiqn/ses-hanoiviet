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
   public class CustomTourDO
    {

        /// <summary>
        /// Summary description for CustomTourDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CUSTOMTOURID_FIELD ="CustomTourID";
		public const string CUSTOMERID_FIELD ="CustomerID";
		public const string ETD_FIELD ="ETD";
		public const string ESTIMATEDDAY_FIELD ="EstimatedDay";
		public const string HOTELRATES_FIELD ="HotelRates";
		public const string BREAKFAST_FIELD ="Breakfast";
		public const string LUNCH_FIELD ="Lunch";
		public const string DINNER_FIELD ="Dinner";
		public const string INFOMATIONSOURCE_FIELD ="InfomationSource";
		public const string ADDITIONALCOMMENT_FIELD ="AdditionalComment";
		public const string SENTDATE_FIELD ="SentDate";
		public const string PAXNO_FIELD ="PaxNo";
		public const string MODULEID_FIELD ="ModuleID";
        public const string COMPANY_FIELD = "Company";

		#endregion
		
		#region Private Variables
					private Int32 _CustomTourID;
		private Int32 _CustomerID;
		private DateTime _ETD;
		private Int32 _EstimatedDay;
		private Int32 _HotelRates;
		private Boolean _Breakfast;
		private Boolean _Lunch;
		private Boolean _Dinner;
		private String _InfomationSource;
		private String _AdditionalComment;
		private DateTime _SentDate;
        private String _PaxNo;
		private Int32 _ModuleID;
        private String _Company;

		#endregion

		#region Public Properties
					public Int32 CustomTourID
		{
			get
			{
				return _CustomTourID;
			}
			set
			{
				_CustomTourID = value;
			}
		}
		public Int32 CustomerID
		{
			get
			{
				return _CustomerID;
			}
			set
			{
				_CustomerID = value;
			}
		}
		public DateTime ETD
		{
			get
			{
				return _ETD;
			}
			set
			{
				_ETD = value;
			}
		}
		public Int32 EstimatedDay
		{
			get
			{
				return _EstimatedDay;
			}
			set
			{
				_EstimatedDay = value;
			}
		}
		public Int32 HotelRates
		{
			get
			{
				return _HotelRates;
			}
			set
			{
				_HotelRates = value;
			}
		}
		public Boolean Breakfast
		{
			get
			{
				return _Breakfast;
			}
			set
			{
				_Breakfast = value;
			}
		}
		public Boolean Lunch
		{
			get
			{
				return _Lunch;
			}
			set
			{
				_Lunch = value;
			}
		}
		public Boolean Dinner
		{
			get
			{
				return _Dinner;
			}
			set
			{
				_Dinner = value;
			}
		}
		public String InfomationSource
		{
			get
			{
				return _InfomationSource;
			}
			set
			{
				_InfomationSource = value;
			}
		}
		public String AdditionalComment
		{
			get
			{
				return _AdditionalComment;
			}
			set
			{
				_AdditionalComment = value;
			}
		}
		public DateTime SentDate
		{
			get
			{
				return _SentDate;
			}
			set
			{
				_SentDate = value;
			}
		}
		public String PaxNo
		{
			get
			{
				return _PaxNo;
			}
			set
			{
				_PaxNo = value;
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
        public String Company
        {
            get
            {
                return _Company;
            }
            set
            {
                _Company = value;
            }
        }

        #endregion

	}
}
