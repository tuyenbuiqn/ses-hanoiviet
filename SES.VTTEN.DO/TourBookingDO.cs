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
   public class TourBookingDO
    {

        /// <summary>
        /// Summary description for TourBookingDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string TOURBOOKINGID_FIELD ="TourBookingID";
		public const string TOURDEPARTUREID_FIELD ="TourDepartureID";
		public const string COMPANYNAME_FIELD ="CompanyName";
		public const string CUSTOMERID_FIELD ="CustomerID";
		public const string PAYMENTTYPE_FIELD ="PaymentType";
		public const string TOTALPAX_FIELD ="TotalPax";
		public const string OTHERREQUEST_FIELD ="OtherRequest";
		public const string ADULTNO_FIELD ="AdultNo";
		public const string CHILDNO_FIELD ="ChildNo";
		public const string BOOKINGDATE_FIELD ="BookingDate";
		public const string MODULEID_FIELD ="ModuleID";

		#endregion
		
		#region Private Variables
					private Int32 _TourBookingID;
		private Int32 _TourDepartureID;
        private String _CompanyName;
		private Int32 _CustomerID;
        private String _PaymentType;
		private Int32 _TotalPax;
		private String _OtherRequest;
		private Int32 _AdultNo;
		private Int32 _ChildNo;
		private DateTime _BookingDate;
		private Int32 _ModuleID;

		#endregion

		#region Public Properties
					public Int32 TourBookingID
		{
			get
			{
				return _TourBookingID;
			}
			set
			{
				_TourBookingID = value;
			}
		}
		public Int32 TourDepartureID
		{
			get
			{
				return _TourDepartureID;
			}
			set
			{
				_TourDepartureID = value;
			}
		}
		public String CompanyName
		{
			get
			{
				return _CompanyName;
			}
			set
			{
				_CompanyName = value;
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
		public String PaymentType
		{
			get
			{
				return _PaymentType;
			}
			set
			{
				_PaymentType = value;
			}
		}
		public Int32 TotalPax
		{
			get
			{
				return _TotalPax;
			}
			set
			{
				_TotalPax = value;
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

        #endregion

	}
}
