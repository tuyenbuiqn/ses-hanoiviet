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
   public class BookingDO
    {

        /// <summary>
        /// Summary description for BookingDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string BOOKINGID_FIELD ="BookingID";
		public const string TOURID_FIELD ="TourID";
		public const string BOOKINGDATE_FIELD ="BookingDate";
		public const string DEPARTUREDATE_FIELD ="DepartureDate";
		public const string ADULTNO_FIELD ="AdultNo";
		public const string CHILDNO_FIELD ="ChildNo";
		public const string HOTELCAT_FIELD ="HotelCat";
		public const string OTHERREQUEST_FIELD ="OtherRequest";
		public const string FULLNAME_FIELD ="FullName";
		public const string GENDER_FIELD ="Gender";
		public const string DAYOFBIRTH_FIELD ="DayOfBirth";
		public const string EMAIL_FIELD ="Email";
		public const string COUNTRY_FIELD ="Country";
		public const string ADDRESS_FIELD ="Address";
		public const string PHONENO_FIELD ="PhoneNo";
		public const string FAXNO_FIELD ="FaxNo";
		public const string ARRIVALDATE_FIELD ="ArrivalDate";
		public const string AIRCORP_FIELD ="AirCorp";
		public const string FLIGHTNO_FIELD ="FlightNo";
		public const string ARRIVALCIY_FIELD ="ArrivalCiy";
		public const string TIMELOCAL_FIELD ="TimeLocal";
		public const string BILLINGOPTION_FIELD ="BillingOption";
		public const string TYPEOFROOM_FIELD ="TypeOfRoom";
		public const string NUMBERROOM_FIELD ="NumberRoom";
		public const string NUMBERPERSON_FIELD ="NumberPerson";
		public const string CHECKIN_FIELD ="Checkin";
		public const string CHECKOUT_FIELD ="Checkout";
		public const string INFORMATIONSOURCE_FIELD ="InformationSource";
		public const string HOTELID_FIELD ="HotelID";

		#endregion
		
		#region Private Variables
					private Int32 _BookingID;
		private Int32 _TourID;
		private DateTime _BookingDate;
		private DateTime _DepartureDate;
		private Int32 _AdultNo;
		private Int32 _ChildNo;
		private Int32 _HotelCat;
		private String _OtherRequest;
		private String _FullName;
		private Boolean _Gender;
		private DateTime _DayOfBirth;
		private String _Email;
		private Int32 _Country;
		private String _Address;
		private String _PhoneNo;
		private String _FaxNo;
		private DateTime _ArrivalDate;
		private String _AirCorp;
		private String _FlightNo;
		private String _ArrivalCiy;
		private String _TimeLocal;
		private Boolean _BillingOption;
		private Int32 _TypeOfRoom;
		private Int32 _NumberRoom;
		private Int32 _NumberPerson;
		private DateTime _Checkin;
		private DateTime _Checkout;
		private String _InformationSource;
		private Int32 _HotelID;

		#endregion

		#region Public Properties
					public Int32 BookingID
		{
			get
			{
				return _BookingID;
			}
			set
			{
				_BookingID = value;
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
		public DateTime BookingDate
		{
			get
			{
				return _BookingDate;
			}
			set
			{
				_BookingDate = value;
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
		public DateTime DayOfBirth
		{
			get
			{
				return _DayOfBirth;
			}
			set
			{
				_DayOfBirth = value;
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
		public Int32 Country
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
		public String AirCorp
		{
			get
			{
				return _AirCorp;
			}
			set
			{
				_AirCorp = value;
			}
		}
		public String FlightNo
		{
			get
			{
				return _FlightNo;
			}
			set
			{
				_FlightNo = value;
			}
		}
		public String ArrivalCiy
		{
			get
			{
				return _ArrivalCiy;
			}
			set
			{
				_ArrivalCiy = value;
			}
		}
		public String TimeLocal
		{
			get
			{
				return _TimeLocal;
			}
			set
			{
				_TimeLocal = value;
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
		public Int32 TypeOfRoom
		{
			get
			{
				return _TypeOfRoom;
			}
			set
			{
				_TypeOfRoom = value;
			}
		}
		public Int32 NumberRoom
		{
			get
			{
				return _NumberRoom;
			}
			set
			{
				_NumberRoom = value;
			}
		}
		public Int32 NumberPerson
		{
			get
			{
				return _NumberPerson;
			}
			set
			{
				_NumberPerson = value;
			}
		}
		public DateTime Checkin
		{
			get
			{
				return _Checkin;
			}
			set
			{
				_Checkin = value;
			}
		}
		public DateTime Checkout
		{
			get
			{
				return _Checkout;
			}
			set
			{
				_Checkout = value;
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

        #endregion

	}
}
