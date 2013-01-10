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
   public class TourHotelPackageDO
    {

        /// <summary>
        /// Summary description for TourHotelPackageDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string HOTELPACKAGEID_FIELD ="HotelPackageID";
		public const string PACKAGENAME_FIELD ="PackageName";
		public const string ORDERID_FIELD ="OrderID";

		#endregion
		
		#region Private Variables
					private Int32 _HotelPackageID;
		private String _PackageName;
		private Int32 _OrderID;

		#endregion

		#region Public Properties
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
		public String PackageName
		{
			get
			{
				return _PackageName;
			}
			set
			{
				_PackageName = value;
			}
		}
		public Int32 OrderID
		{
			get
			{
				return _OrderID;
			}
			set
			{
				_OrderID = value;
			}
		}

        #endregion

	}
}
