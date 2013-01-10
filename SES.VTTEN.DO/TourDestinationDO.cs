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
   public class TourDestinationDO
    {

        /// <summary>
        /// Summary description for TourDestinationDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string TOURDESTINATIONID_FIELD ="TourDestinationID";
		public const string TOURID_FIELD ="TourID";
		public const string DESTINATIONID_FIELD ="DestinationID";

		#endregion
		
		#region Private Variables
					private Int32 _TourDestinationID;
		private Int32 _TourID;
		private Int32 _DestinationID;

		#endregion

		#region Public Properties
					public Int32 TourDestinationID
		{
			get
			{
				return _TourDestinationID;
			}
			set
			{
				_TourDestinationID = value;
			}
		}
		public Int32 TourID
		{
			get
			{
				return _TourID;
			}
			set
			{
				_TourID = value;
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

        #endregion

	}
}
