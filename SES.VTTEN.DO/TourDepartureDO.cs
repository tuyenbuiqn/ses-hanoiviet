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
   public class TourDepartureDO
    {

        /// <summary>
        /// Summary description for TourDepartureDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string TOURDEPARTUREID_FIELD ="TourDepartureID";
		public const string TOURID_FIELD ="TourID";
		public const string DEPARTURECODE_FIELD ="DepartureCode";
		public const string DEPARTUREDATE_FIELD ="DepartureDate";
		public const string TOTALPAX_FIELD ="TotalPax";
		public const string AVAILABLEPAX_FIELD ="AvailablePax";
		public const string ADULTPRICE_FIELD ="AdultPrice";
		public const string CHILDPRICE_FIELD ="ChildPrice";
		public const string CHILDSALEOFFPRICE_FIELD ="ChildSaleOffPrice";
		public const string ADULTSALEOFFPRICE_FIELD ="AdultSaleOffPrice";
		public const string RETURNDATE_FIELD ="ReturnDate";
		public const string DESCRIPTION_FIELD ="Description";
		public const string MODULEID_FIELD ="ModuleID";

		#endregion
		
		#region Private Variables
					private Int32 _TourDepartureID;
		private Int32 _TourID;
		private String _DepartureCode;
		private DateTime _DepartureDate;
		private Int32 _TotalPax;
		private Int32 _AvailablePax;
		private Double _AdultPrice;
		private Double _ChildPrice;
		private Double _ChildSaleOffPrice;
		private Double _AdultSaleOffPrice;
		private DateTime _ReturnDate;
		private String _Description;
		private Int32 _ModuleID;

		#endregion

		#region Public Properties
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
		public String DepartureCode
		{
			get
			{
				return _DepartureCode;
			}
			set
			{
				_DepartureCode = value;
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
		public Int32 AvailablePax
		{
			get
			{
				return _AvailablePax;
			}
			set
			{
				_AvailablePax = value;
			}
		}
		public Double AdultPrice
		{
			get
			{
				return _AdultPrice;
			}
			set
			{
				_AdultPrice = value;
			}
		}
		public Double ChildPrice
		{
			get
			{
				return _ChildPrice;
			}
			set
			{
				_ChildPrice = value;
			}
		}
		public Double ChildSaleOffPrice
		{
			get
			{
				return _ChildSaleOffPrice;
			}
			set
			{
				_ChildSaleOffPrice = value;
			}
		}
		public Double AdultSaleOffPrice
		{
			get
			{
				return _AdultSaleOffPrice;
			}
			set
			{
				_AdultSaleOffPrice = value;
			}
		}
		public DateTime ReturnDate
		{
			get
			{
				return _ReturnDate;
			}
			set
			{
				_ReturnDate = value;
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
