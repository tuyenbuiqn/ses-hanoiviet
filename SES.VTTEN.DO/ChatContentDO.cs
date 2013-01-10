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
   public class ChatContentDO
    {

        /// <summary>
        /// Summary description for ChatContentDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CHATCONTENTID_FIELD ="ChatContentID";
		public const string USERID_FIELD ="UserID";
		public const string TIMESTART_FIELD ="TimeStart";
		public const string TIMEEND_FIELD ="TimeEnd";
		public const string CUSTOMERNAME_FIELD ="CustomerName";
		public const string CHATCONTENT_FIELD ="ChatContent";

		#endregion
		
		#region Private Variables
					private Int32 _ChatContentID;
		private Int32 _UserID;
		private DateTime _TimeStart;
		private DateTime _TimeEnd;
		private String _CustomerName;
		private String _ChatContent;

		#endregion

		#region Public Properties
					public Int32 ChatContentID
		{
			get
			{
				return _ChatContentID;
			}
			set
			{
				_ChatContentID = value;
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
		public DateTime TimeStart
		{
			get
			{
				return _TimeStart;
			}
			set
			{
				_TimeStart = value;
			}
		}
		public DateTime TimeEnd
		{
			get
			{
				return _TimeEnd;
			}
			set
			{
				_TimeEnd = value;
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
		public String ChatContent
		{
			get
			{
				return _ChatContent;
			}
			set
			{
				_ChatContent = value;
			}
		}

        #endregion

	}
}
