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
   public class RoomTypeDO
    {

        /// <summary>
        /// Summary description for RoomTypeDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string ROOMTYPEID_FIELD ="RoomTypeID";
		public const string TITLE_FIELD ="Title";

		#endregion
		
		#region Private Variables
					private Int32 _RoomTypeID;
		private String _Title;

		#endregion

		#region Public Properties
					public Int32 RoomTypeID
		{
			get
			{
				return _RoomTypeID;
			}
			set
			{
				_RoomTypeID = value;
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
