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
   public class CustomerDO
    {

        /// <summary>
        /// Summary description for CustomerDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CUSTOMERID_FIELD ="CustomerID";
		public const string CUSTOMERNAME_FIELD ="CustomerName";
		public const string PHONE_FIELD ="Phone";
		public const string ADDRESS_FIELD ="Address";
		public const string PASSPORT_FIELD ="Passport";
		public const string IDCARD_FIELD ="IDCard";
		public const string EMAIL_FIELD ="Email";
		public const string YAHOO_FIELD ="Yahoo";
		public const string SKYPE_FIELD ="Skype";
		public const string GENDER_FIELD ="Gender";
		public const string JOBS_FIELD ="Jobs";
		public const string BIRTHDAY_FIELD ="BirthDay";
		public const string MOBILE_FIELD ="Mobile";
		public const string NATIONALID_FIELD ="NationalID";
		public const string CUSTOMERTYPE_FIELD ="CustomerType";
		public const string ISADULT_FIELD ="IsAdult";
		public const string OTHERINFO_FIELD ="OtherInfo";
		public const string OTHERANNIVERSARY_FIELD ="OtherAnniversary";
		public const string ANNIVERSARYINFO_FIELD ="AnniversaryInfo";
		public const string CUSTOMERCATEGORYID_FIELD ="CustomerCategoryID";
        public const string TITLE_FIELD = "Title";
        public const string FAX_FIELD = "Fax";

		#endregion
		
		#region Private Variables
					private Int32 _CustomerID;
		private String _CustomerName;
		private String _Phone;
		private String _Address;
		private String _Passport;
		private String _IDCard;
		private String _Email;
		private String _Yahoo;
		private String _Skype;
		private Boolean _Gender;
		private String _Jobs;
		private DateTime _BirthDay;
		private String _Mobile;
		private Int32 _NationalID;
		private Boolean _CustomerType;
		private Boolean _IsAdult;
		private String _OtherInfo;
		private DateTime _OtherAnniversary;
		private String _AnniversaryInfo;
		private Int32 _CustomerCategoryID;
        private String _Title;
        private String _Fax;

		#endregion

		#region Public Properties
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
		public String CustomerName
		{
			get
			{
				return _CustomerName;
			}
			set
			{
				_CustomerName = value;
			}
		}
		public String Phone
		{
			get
			{
				return _Phone;
			}
			set
			{
				_Phone = value;
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
		public String Passport
		{
			get
			{
				return _Passport;
			}
			set
			{
				_Passport = value;
			}
		}
		public String IDCard
		{
			get
			{
				return _IDCard;
			}
			set
			{
				_IDCard = value;
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
		public String Yahoo
		{
			get
			{
				return _Yahoo;
			}
			set
			{
				_Yahoo = value;
			}
		}
		public String Skype
		{
			get
			{
				return _Skype;
			}
			set
			{
				_Skype = value;
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
		public String Jobs
		{
			get
			{
				return _Jobs;
			}
			set
			{
				_Jobs = value;
			}
		}
		public DateTime BirthDay
		{
			get
			{
				return _BirthDay;
			}
			set
			{
				_BirthDay = value;
			}
		}
		public String Mobile
		{
			get
			{
				return _Mobile;
			}
			set
			{
				_Mobile = value;
			}
		}
		public Int32 NationalID
		{
			get
			{
				return _NationalID;
			}
			set
			{
				_NationalID = value;
			}
		}
		public Boolean CustomerType
		{
			get
			{
				return _CustomerType;
			}
			set
			{
				_CustomerType = value;
			}
		}
		public Boolean IsAdult
		{
			get
			{
				return _IsAdult;
			}
			set
			{
				_IsAdult = value;
			}
		}
		public String OtherInfo
		{
			get
			{
				return _OtherInfo;
			}
			set
			{
				_OtherInfo = value;
			}
		}
		public DateTime OtherAnniversary
		{
			get
			{
				return _OtherAnniversary;
			}
			set
			{
				_OtherAnniversary = value;
			}
		}
		public String AnniversaryInfo
		{
			get
			{
				return _AnniversaryInfo;
			}
			set
			{
				_AnniversaryInfo = value;
			}
		}
		public Int32 CustomerCategoryID
		{
			get
			{
				return _CustomerCategoryID;
			}
			set
			{
				_CustomerCategoryID = value;
			}
		}
        public String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        public String Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                _Fax = value;
            }
        }
        #endregion

	}
}
