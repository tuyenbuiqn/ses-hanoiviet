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
   public class UsersDO
    {

        /// <summary>
        /// Summary description for UsersDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string USERID_FIELD ="UserID";
		public const string USERNAME_FIELD ="Username";
		public const string PASWORD_FIELD ="Pasword";
		public const string EMAIL_FIELD ="Email";
		public const string ISADMIN_FIELD ="IsAdmin";
		public const string ISACTIVE_FIELD ="IsActive";
		public const string ISSUPORTONLINE_FIELD ="IsSuportOnline";
        public const string GROUPID_FIELD = "GroupID";

		#endregion
		
		#region Private Variables
					private Int32 _UserID;
		private String _Username;
		private String _Pasword;
		private String _Email;
		private Boolean _IsAdmin;
		private Boolean _IsActive;
		private Boolean _IsSuportOnline;
        private int _GroupID;

		#endregion

		#region Public Properties
					public Int32 UserID
		{
			get
			{
				return _UserID;
			}
			set
			{
				_UserID = value;
			}
		}
		public String Username
		{
			get
			{
				return _Username;
			}
			set
			{
				_Username = value;
			}
		}
		public String Pasword
		{
			get
			{
				return _Pasword;
			}
			set
			{
				_Pasword = value;
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
		public Boolean IsAdmin
		{
			get
			{
				return _IsAdmin;
			}
			set
			{
				_IsAdmin = value;
			}
		}
		public Boolean IsActive
		{
			get
			{
				return _IsActive;
			}
			set
			{
				_IsActive = value;
			}
		}
		public Boolean IsSuportOnline
		{
			get
			{
				return _IsSuportOnline;
			}
			set
			{
				_IsSuportOnline = value;
			}
		}

       public Int32 GroupID
       {
           get { return _GroupID;}
           set { _GroupID = value;}
       }

        #endregion

	}
}
