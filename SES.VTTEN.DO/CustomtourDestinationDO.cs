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
   public class CustomtourDestinationDO
    {

        /// <summary>
        /// Summary description for CustomtourDestinationDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string CUSTOMTOURDESTINATIONID_FIELD ="CustomtourDestinationID";
		public const string DESTINATIONID_FIELD ="DestinationID";
		public const string CUSTOMTOURID_FIELD ="CustomTourID";

		#endregion
		
		#region Private Variables
					private Int32 _CustomtourDestinationID;
		private Int32 _DestinationID;
		private Int32 _CustomTourID;

		#endregion

		#region Public Properties
					public Int32 CustomtourDestinationID
		{
			get
			{
				return _CustomtourDestinationID;
			}
			set
			{
				_CustomtourDestinationID = value;
			}
		}
		public Int32 DestinationID
		{
			get
			{
				return _DestinationID;
			}
			set
			{
				_DestinationID = value;
			}
		}
		public Int32 CustomTourID
		{
			get
			{
				return _CustomTourID;
			}
			set
			{
				_CustomTourID = value;
			}
		}

        #endregion

	}
}
