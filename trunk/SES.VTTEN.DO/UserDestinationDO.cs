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
   public class UserDestinationDO
    {

        /// <summary>
        /// Summary description for UserDestinationDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string USERDESTINATIONID_FIELD ="UserDestinationID";
		public const string USERID_FIELD ="UserID";
		public const string DESTINATIONID_FIELD ="DestinationID";

		#endregion
		
		#region Private Variables
					private Int32 _UserDestinationID;
		private Int32 _UserID;
		private Int32 _DestinationID;

		#endregion

		#region Public Properties
					public Int32 UserDestinationID
		{
			get
			{
				return _UserDestinationID;
			}
			set
			{
				_UserDestinationID = value;
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
		public Int32 DestinationID
		{
			get
			{
				return _DestinationID;
			}
			set
			{
				_DestinationID = value;
			}
		}

        #endregion

	}
}
