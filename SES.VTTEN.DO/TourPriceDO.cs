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
   public class TourPriceDO
    {

        /// <summary>
        /// Summary description for TourPriceDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string TOURPRICEID_FIELD ="TourPriceID";
		public const string TOURID_FIELD ="TourID";
		public const string PAXPACKAGEID_FIELD ="PaxPackageID";
		public const string HOTELPACKAGEID_FIELD ="HotelPackageID";
		public const string PRICE_FIELD ="Price";
		public const string PRICEVISIBLE_FIELD ="PriceVisible";

		#endregion
		
		#region Private Variables
					private Int32 _TourPriceID;
		private Int32 _TourID;
		private Int32 _PaxPackageID;
		private Int32 _HotelPackageID;
		private Int32 _Price;
		private Boolean _PriceVisible;

		#endregion

		#region Public Properties
					public Int32 TourPriceID
		{
			get
			{
				return _TourPriceID;
			}
			set
			{
				_TourPriceID = value;
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
		public Int32 PaxPackageID
		{
			get
			{
				return _PaxPackageID;
			}
			set
			{
				_PaxPackageID = value;
			}
		}
		public Int32 HotelPackageID
		{
			get
			{
				return _HotelPackageID;
			}
			set
			{
				_HotelPackageID = value;
			}
		}
		public Int32 Price
		{
			get
			{
				return _Price;
			}
			set
			{
				_Price = value;
			}
		}
		public Boolean PriceVisible
		{
			get
			{
				return _PriceVisible;
			}
			set
			{
				_PriceVisible = value;
			}
		}

        #endregion

	}
}
