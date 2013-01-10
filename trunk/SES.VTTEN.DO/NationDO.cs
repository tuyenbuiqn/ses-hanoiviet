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
   public class NationDO
    {

        /// <summary>
        /// Summary description for NationDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string NATIONID_FIELD ="NationID";
		public const string NATIONNAME_FIELD ="NationName";

		#endregion
		
		#region Private Variables
					private Int32 _NationID;
		private String _NationName;

		#endregion

		#region Public Properties
					public Int32 NationID
		{
			get
			{
				return _NationID;
			}
			set
			{
				_NationID = value;
			}
		}
		public String NationName
		{
			get
			{
				return _NationName;
			}
			set
			{
				_NationName = value;
			}
		}

        #endregion

	}
}
