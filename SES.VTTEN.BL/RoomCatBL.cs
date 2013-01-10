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
/// Summary description for RoomCatBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class RoomCatBL 
    {
    	#region Private Variables
		RoomCatDAL objRoomCatDAL;
		#endregion
		
        #region Public Constructors
        public RoomCatBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objRoomCatDAL=new RoomCatDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(RoomCatDO objRoomCatDO)
        {
            return objRoomCatDAL.Insert(objRoomCatDO);
        }

        public int Update(RoomCatDO objRoomCatDO)
        {
             return objRoomCatDAL.Update(objRoomCatDO);

        }

        public int Delete(RoomCatDO objRoomCatDO)
        {
             return objRoomCatDAL.Delete(objRoomCatDO);

        }

         public int DeleteAll()
        {
             return objRoomCatDAL.DeleteAll();
        }

        public RoomCatDO Select(RoomCatDO objRoomCatDO)
        {
            return objRoomCatDAL.Select(objRoomCatDO);
        }

        public ArrayList SelectAll1( )
        {
         return objRoomCatDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objRoomCatDAL.SelectAll();
        }


     
#endregion          
    
    }

}
