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
   public class GroupsDO
    {

        /// <summary>
        /// Summary description for GroupsDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string GROUPID_FIELD ="GroupID";
		public const string GROUPNAME_FIELD ="GroupName";
		public const string PERMISSION_FIELD ="Permission";
		public const string NOTE_FIELD ="Note";

		#endregion
		
		#region Private Variables
					private Int32 _GroupID;
		private String _GroupName;
		private String _Permission;
		private String _Note;

		#endregion

		#region Public Properties
					public Int32 GroupID
		{
			get
			{
				return _GroupID;
			}
			set
			{
				_GroupID = value;
			}
		}
		public String GroupName
		{
			get
			{
				return _GroupName;
			}
			set
			{
				_GroupName = value;
			}
		}
		public String Permission
		{
			get
			{
				return _Permission;
			}
			set
			{
				_Permission = value;
			}
		}
		public String Note
		{
			get
			{
				return _Note;
			}
			set
			{
				_Note = value;
			}
		}

        #endregion

	}
}
