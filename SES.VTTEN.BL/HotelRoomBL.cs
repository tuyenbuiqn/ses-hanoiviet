/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;

using SES.VTTEN.DAL;
using SES.VTTEN.DO;
/// <summary>
/// Summary description for HotelRoomBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class HotelRoomBL 
    {
    	#region Private Variables
		HotelRoomDAL objHotelRoomDAL;
		#endregion
		
        #region Public Constructors
        public HotelRoomBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objHotelRoomDAL=new HotelRoomDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(HotelRoomDO objHotelRoomDO)
        {
            return objHotelRoomDAL.Insert(objHotelRoomDO);
        }

        public int Update(HotelRoomDO objHotelRoomDO)
        {
             return objHotelRoomDAL.Update(objHotelRoomDO);

        }

        public int Delete(HotelRoomDO objHotelRoomDO)
        {
             return objHotelRoomDAL.Delete(objHotelRoomDO);

        }

         public int DeleteAll()
        {
             return objHotelRoomDAL.DeleteAll();
        }

        public HotelRoomDO Select(HotelRoomDO objHotelRoomDO)
        {
            return objHotelRoomDAL.Select(objHotelRoomDO);
        }

        public ArrayList SelectAll1( )
        {
         return objHotelRoomDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objHotelRoomDAL.SelectAll();
        }


     
#endregion          
    
    
        public HotelRoomDO SelectbyPro(int RoomType, int RoomCat, int HotelID)
        {
            return objHotelRoomDAL.SelectbyPro(RoomType, RoomCat, HotelID);
        }

        public DataTable SelectbyFK(int HotelID)
        {
            return objHotelRoomDAL.SelectbyFK(HotelID);
        }
    }

}
