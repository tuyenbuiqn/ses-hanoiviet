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
   public class ContactDO
    {

        /// <summary>
        /// Summary description for ContactDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CONTACTID_FIELD ="ContactID";
		public const string CUSTOMERID_FIELD ="CustomerID";
		public const string DETAIL_FIELD ="Detail";
        public const string COMPANY_FIELD = "Company";

		#endregion
		
		#region Private Variables
					private Int32 _ContactID;
		private Int32 _CustomerID;
		private String _Detail;
        private String _Company;

		#endregion

		#region Public Properties
					public Int32 ContactID
		{
			get
			{
				return _ContactID;
			}
			set
			{
				_ContactID = value;
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
		public String Detail
		{
			get
			{
				return _Detail;
			}
			set
			{
				_Detail = value;
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
