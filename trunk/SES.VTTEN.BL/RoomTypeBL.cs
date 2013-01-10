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
/// Summary description for RoomTypeBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class RoomTypeBL 
    {
    	#region Private Variables
		RoomTypeDAL objRoomTypeDAL;
		#endregion
		
        #region Public Constructors
        public RoomTypeBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objRoomTypeDAL=new RoomTypeDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(RoomTypeDO objRoomTypeDO)
        {
            return objRoomTypeDAL.Insert(objRoomTypeDO);
        }

        public int Update(RoomTypeDO objRoomTypeDO)
        {
             return objRoomTypeDAL.Update(objRoomTypeDO);

        }

        public int Delete(RoomTypeDO objRoomTypeDO)
        {
             return objRoomTypeDAL.Delete(objRoomTypeDO);

        }

         public int DeleteAll()
        {
             return objRoomTypeDAL.DeleteAll();
        }

        public RoomTypeDO Select(RoomTypeDO objRoomTypeDO)
        {
            return objRoomTypeDAL.Select(objRoomTypeDO);
        }

        public ArrayList SelectAll1( )
        {
         return objRoomTypeDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objRoomTypeDAL.SelectAll();
        }


     
#endregion          
    
    }

}
