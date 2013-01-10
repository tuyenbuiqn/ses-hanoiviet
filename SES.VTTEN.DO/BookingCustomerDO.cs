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
   public class BookingCustomerDO
    {

        /// <summary>
        /// Summary description for BookingCustomerDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string BOOKINGCUSTOMERID_FIELD ="BookingCustomerID";
		public const string TOURBOOKINGID_FIELD ="TourBookingID";
		public const string CUSTOMERID_FIELD ="CustomerID";

		#endregion
		
		#region Private Variables
					private Int32 _BookingCustomerID;
		private Int32 _TourBookingID;
		private Int32 _CustomerID;

		#endregion

		#region Public Properties
					public Int32 BookingCustomerID
		{
			get
			{
				return _BookingCustomerID;
			}
			set
			{
				_BookingCustomerID = value;
			}
		}
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

        #endregion

	}
}
