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
   public class TourPaxPackageDO
    {

        /// <summary>
        /// Summary description for TourPaxPackageDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string PAXPACKAGEID_FIELD ="PaxPackageID";
		public const string PAXCODE_FIELD ="PaxCode";
		public const string ORDERID_FIELD ="OrderID";

		#endregion
		
		#region Private Variables
					private Int32 _PaxPackageID;
		private String _PaxCode;
		private Int32 _OrderID;

		#endregion

		#region Public Properties
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
		public String PaxCode
		{
			get
			{
				return _PaxCode;
			}
			set
			{
				_PaxCode = value;
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
