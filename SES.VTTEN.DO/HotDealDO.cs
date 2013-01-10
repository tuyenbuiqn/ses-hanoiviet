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
   public class HotDealDO
    {

        /// <summary>
        /// Summary description for HotDealDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string HOTDEALID_FIELD ="HotDealID";
		public const string TITLE_FIELD ="Title";
		public const string DESCRIPTION_FIELD ="Description";
		public const string PUBLISHED_FIELD ="Published";
		public const string MODULEID_FIELD ="ModuleID";
		public const string TOURDEPARTUREID_FIELD ="TourDepartureID";
		public const string HOTELID_FIELD ="HotelID";
		public const string DATESTART_FIELD ="DateStart";
		public const string DATEEND_FIELD ="DateEnd";

		#endregion
		
		#region Private Variables
					private Int32 _HotDealID;
		private String _Title;
		private String _Description;
		private Boolean _Published;
		private Int32 _ModuleID;
		private Int32 _TourDepartureID;
		private Int32 _HotelID;
        private DateTime _DateStart;
        private DateTime _DateEnd;
        private String _AdultPrice;
        private String _ChildPrice;

		#endregion

		#region Public Properties
					public Int32 HotDealID
		{
			get
			{
				return _HotDealID;
			}
			set
			{
				_HotDealID = value;
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
        public String AdultPrice
        {
            get
            {
                return _AdultPrice;
            }
            set
            {
                _AdultPrice = value;
            }
        }
        public String ChildPrice
        {
            get
            {
                return _ChildPrice;
            }
            set
            {
                _ChildPrice = value;
            }
        }
		public String Description
		{
			get
			{
				return _Description;
			}
			set
			{
				_Description = value;
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
		public Int32 TourDepartureID
		{
			get
			{
				return _TourDepartureID;
			}
			set
			{
				_TourDepartureID = value;
			}
		}
		public Int32 HotelID
		{
			get
			{
				return _HotelID;
			}
			set
			{
				_HotelID = value;
			}
		}
        public DateTime DateStart
		{
			get
			{
				return _DateStart;
			}
			set
			{
				_DateStart = value;
			}
		}
        public DateTime DateEnd
		{
			get
			{
				return _DateEnd;
			}
			set
			{
				_DateEnd = value;
			}
		}

        #endregion

	}
}
