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
   public class LinkDO
    {

        /// <summary>
        /// Summary description for LinkDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string LINKID_FIELD ="LinkID";
		public const string DETAIL_FIELD ="Detail";
		public const string PUBLISHED_FIELD ="Published";

		#endregion
		
		#region Private Variables
					private Int32 _LinkID;
		private String _Detail;
		private Boolean _Published;

		#endregion

		#region Public Properties
					public Int32 LinkID
		{
			get
			{
				return _LinkID;
			}
			set
			{
				_LinkID = value;
			}
		}
		public String Detail
		{
			get
			{
				return _Detail;
			}
			set
			{
				_Detail = value;
			}
		}
		public Boolean Published
		{
			get
			{
				return _Published;
			}
			set
			{
				_Published = value;
			}
		}

        #endregion

	}
}
