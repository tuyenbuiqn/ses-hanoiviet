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
   public class FooterTagDO
    {

        /// <summary>
        /// Summary description for FooterTagDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string TAGID_FIELD ="TagID";
		public const string TAG_FIELD ="Tag";

		#endregion
		
		#region Private Variables
					private Int32 _TagID;
		private String _Tag;

		#endregion

		#region Public Properties
					public Int32 TagID
		{
			get
			{
				return _TagID;
			}
			set
			{
				_TagID = value;
			}
		}
		public String Tag
		{
			get
			{
				return _Tag;
			}
			set
			{
				_Tag = value;
			}
		}

        #endregion

	}
}
