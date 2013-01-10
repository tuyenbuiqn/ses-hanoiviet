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
   public class SessionChatDO
    {

        /// <summary>
        /// Summary description for SessionChatDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string SESSIONID_FIELD ="SessionID";
		public const string SESSIONHASH_FIELD ="SessionHash";
		public const string USERID_FIELD ="UserID";

		#endregion
		
		#region Private Variables
					private Int32 _SessionID;
		private String _SessionHash;
		private Int32 _UserID;

		#endregion

		#region Public Properties
					public Int32 SessionID
		{
			get
			{
				return _SessionID;
			}
			set
			{
				_SessionID = value;
			}
		}
		public String SessionHash
		{
			get
			{
				return _SessionHash;
			}
			set
			{
				_SessionHash = value;
			}
		}
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

        #endregion

	}
}
