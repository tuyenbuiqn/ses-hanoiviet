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
   public class ConfigDO
    {

        /// <summary>
        /// Summary description for ConfigDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CONFIGID_FIELD ="ConfigID";
		public const string CONFIGCODE_FIELD ="ConfigCode";
		public const string CONFIGVALUE_FIELD ="ConfigValue";

		#endregion
		
		#region Private Variables
					private Int32 _ConfigID;
		private String _ConfigCode;
		private String _ConfigValue;

		#endregion

		#region Public Properties
					public Int32 ConfigID
		{
			get
			{
				return _ConfigID;
			}
			set
			{
				_ConfigID = value;
			}
		}
		public String ConfigCode
		{
			get
			{
				return _ConfigCode;
			}
			set
			{
				_ConfigCode = value;
			}
		}
		public String ConfigValue
		{
			get
			{
				return _ConfigValue;
			}
			set
			{
				_ConfigValue = value;
			}
		}

        #endregion

	}
}
