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
   public class ModuleDO
    {

        /// <summary>
        /// Summary description for ModuleDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string MODULEID_FIELD ="ModuleID";
		public const string MODULENAME_FIELD ="ModuleName";
        public const string VIDEOID_FIELD = "VideoID";

		#endregion
		
		#region Private Variables
					private Int32 _ModuleID;
		private String _ModuleName;
        private Int32 _VideoID;

		#endregion

		#region Public Properties
					public Int32 ModuleID
		{
			get
			{
				return _ModuleID;
			}
			set
			{
				_ModuleID = value;
			}
		}
		public String ModuleName
		{
			get
			{
				return _ModuleName;
			}
			set
			{
				_ModuleName = value;
			}
		}
        public Int32 VideoID
        {
            get
            {
                return _VideoID;
            }
            set
            {
                _VideoID = value;
            }
        }
        #endregion

	}
}
