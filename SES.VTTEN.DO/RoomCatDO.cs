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
   public class RoomCatDO
    {

        /// <summary>
        /// Summary description for RoomCatDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ROOMCATID_FIELD ="RoomCatID";
		public const string TITLE_FIELD ="Title";

		#endregion
		
		#region Private Variables
					private Int32 _RoomCatID;
		private String _Title;

		#endregion

		#region Public Properties
					public Int32 RoomCatID
		{
			get
			{
				return _RoomCatID;
			}
			set
			{
				_RoomCatID = value;
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

        #endregion

	}
}
