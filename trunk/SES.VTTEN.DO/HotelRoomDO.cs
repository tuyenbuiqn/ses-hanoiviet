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
   public class HotelRoomDO
    {

        /// <summary>
        /// Summary description for HotelRoomDO
        /// </summary>
		
		
		#region Public Constants (Fields name)
					public const string HOTELROOMID_FIELD ="HotelRoomID";
		public const string ROOMTYPE_FIELD ="RoomType";
		public const string ROOMCAT_FIELD ="RoomCat";
		public const string ROOMPRICE_FIELD ="RoomPrice";
		public const string HOTELID_FIELD ="HotelID";

		#endregion
		
		#region Private Variables
					private Int32 _HotelRoomID;
		private Int32 _RoomType;
		private Int32 _RoomCat;
		private Double _RoomPrice;
		private Int32 _HotelID;

		#endregion

		#region Public Properties
					public Int32 HotelRoomID
		{
			get
			{
				return _HotelRoomID;
			}
			set
			{
				_HotelRoomID = value;
			}
		}
		public Int32 RoomType
		{
			get
			{
				return _RoomType;
			}
			set
			{
				_RoomType = value;
			}
		}
		public Int32 RoomCat
		{
			get
			{
				return _RoomCat;
			}
			set
			{
				_RoomCat = value;
			}
		}
		public Double RoomPrice
		{
			get
			{
				return _RoomPrice;
			}
			set
			{
				_RoomPrice = value;
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

        #endregion

	}
}
