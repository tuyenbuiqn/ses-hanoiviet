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
   public class ContentTypeDO
    {

        /// <summary>
        /// Summary description for ContentTypeDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CONTENTTYPEID_FIELD ="ContentTypeID";
		public const string TITLE_FIELD ="Title";

		#endregion
		
		#region Private Variables
					private Int32 _ContentTypeID;
		private String _Title;

		#endregion

		#region Public Properties
					public Int32 ContentTypeID
		{
			get
			{
				return _ContentTypeID;
			}
			set
			{
				_ContentTypeID = value;
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
