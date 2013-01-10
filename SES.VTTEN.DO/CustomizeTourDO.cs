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
   public class CustomizeTourDO
    {

        /// <summary>
        /// Summary description for CustomizeTourDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CUSTOMIZETOURID_FIELD ="CustomizeTourID";
		public const string CUSDATE_FIELD ="CusDate";
		public const string FULLNAME_FIELD ="FullName";
		public const string GENDER_FIELD ="Gender";
		public const string DATEOFBIRTH_FIELD ="DateOfBirth";
		public const string EMAIL_FIELD ="Email";
		public const string COUNTRY_FIELD ="Country";
		public const string ADDRESS_FIELD ="Address";
		public const string PHONENO_FIELD ="PhoneNo";
		public const string FAXNO_FIELD ="FaxNo";
		public const string ARRIVALDATE_FIELD ="ArrivalDate";
		public const string DEPARTUREDATE_FIELD ="DepartureDate";
		public const string ADULTNO_FIELD ="AdultNo";
		public const string CHILDNO_FIELD ="ChildNo";
		public const string HOTELCAT_FIELD ="HotelCat";
		public const string TRANSPORT_FIELD ="Transport";
		public const string TOURPROGRAMME_FIELD ="TourProgramme";
		public const string ACCOMMODATION_FIELD ="Accommodation";
		public const string MEALS_FIELD ="Meals";
		public const string FOOD_FIELD ="Food";
		public const string BILLINGOPTION_FIELD ="BillingOption";
		public const string OTHERREQUEST_FIELD ="OtherRequest";
		public const string INFORMATIONSOURCE_FIELD ="InformationSource";
        public const string PLACETOVIST_FIELD = "PlaceToVist";

		#endregion
		
		#region Private Variables
					private Int32 _CustomizeTourID;
		private DateTime _CusDate;
		private String _FullName;
		private Boolean _Gender;
		private DateTime _DateOfBirth;
		private String _Email;
		private String _Country;
		private String _Address;
		private String _PhoneNo;
		private String _FaxNo;
		private DateTime _ArrivalDate;
		private DateTime _DepartureDate;
		private Int32 _AdultNo;
		private Int32 _ChildNo;
		private Int32 _HotelCat;
		private String _Transport;
		private String _TourProgramme;
		private String _Accommodation;
		private String _Meals;
		private String _Food;
		private Boolean _BillingOption;
		private String _OtherRequest;
		private String _InformationSource;
        private String _PlaceToVisit;

		#endregion

		#region Public Properties
					public Int32 CustomizeTourID
		{
			get
			{
				return _CustomizeTourID;
			}
			set
			{
				_CustomizeTourID = value;
			}
		}
		public DateTime CusDate
		{
			get
			{
				return _CusDate;
			}
			set
			{
				_CusDate = value;
			}
		}
		public String FullName
		{
			get
			{
				return _FullName;
			}
			set
			{
				_FullName = value;
			}
		}
		public Boolean Gender
		{
			get
			{
				return _Gender;
			}
			set
			{
				_Gender = value;
			}
		}
		public DateTime DateOfBirth
		{
			get
			{
				return _DateOfBirth;
			}
			set
			{
				_DateOfBirth = value;
			}
		}
		public String Email
		{
			get
			{
				return _Email;
			}
			set
			{
				_Email = value;
			}
		}
		public String Country
		{
			get
			{
				return _Country;
			}
			set
			{
				_Country = value;
			}
		}
		public String Address
		{
			get
			{
				return _Address;
			}
			set
			{
				_Address = value;
			}
		}
		public String PhoneNo
		{
			get
			{
				return _PhoneNo;
			}
			set
			{
				_PhoneNo = value;
			}
		}
		public String FaxNo
		{
			get
			{
				return _FaxNo;
			}
			set
			{
				_FaxNo = value;
			}
		}
		public DateTime ArrivalDate
		{
			get
			{
				return _ArrivalDate;
			}
			set
			{
				_ArrivalDate = value;
			}
		}
		public DateTime DepartureDate
		{
			get
			{
				return _DepartureDate;
			}
			set
			{
				_DepartureDate = value;
			}
		}
		public Int32 AdultNo
		{
			get
			{
				return _AdultNo;
			}
			set
			{
				_AdultNo = value;
			}
		}
		public Int32 ChildNo
		{
			get
			{
				return _ChildNo;
			}
			set
			{
				_ChildNo = value;
			}
		}
		public Int32 HotelCat
		{
			get
			{
				return _HotelCat;
			}
			set
			{
				_HotelCat = value;
			}
		}
		public String Transport
		{
			get
			{
				return _Transport;
			}
			set
			{
				_Transport = value;
			}
		}
		public String TourProgramme
		{
			get
			{
				return _TourProgramme;
			}
			set
			{
				_TourProgramme = value;
			}
		}
		public String Accommodation
		{
			get
			{
				return _Accommodation;
			}
			set
			{
				_Accommodation = value;
			}
		}
		public String Meals
		{
			get
			{
				return _Meals;
			}
			set
			{
				_Meals = value;
			}
		}
		public String Food
		{
			get
			{
				return _Food;
			}
			set
			{
				_Food = value;
			}
		}
		public Boolean BillingOption
		{
			get
			{
				return _BillingOption;
			}
			set
			{
				_BillingOption = value;
			}
		}
		public String OtherRequest
		{
			get
			{
				return _OtherRequest;
			}
			set
			{
				_OtherRequest = value;
			}
		}
		public String InformationSource
		{
			get
			{
				return _InformationSource;
			}
			set
			{
				_InformationSource = value;
			}
		}
        public String PlaceToVisit
        {
            get
            {
                return _PlaceToVisit;
            }
            set
            {
                _PlaceToVisit = value;
            }
        }
        #endregion

	}
}
