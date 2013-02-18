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
/// Summary description for HotelBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class HotelBL 
    {
    	#region Private Variables
		HotelDAL objHotelDAL;
		#endregion
		
        #region Public Constructors
        public HotelBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objHotelDAL=new HotelDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(HotelDO objHotelDO)
        {
            return objHotelDAL.Insert(objHotelDO);
        }

        public int Update(HotelDO objHotelDO)
        {
             return objHotelDAL.Update(objHotelDO);

        }

        public int Delete(HotelDO objHotelDO)
        {
             return objHotelDAL.Delete(objHotelDO);

        }

         public int DeleteAll()
        {
             return objHotelDAL.DeleteAll();
        }

        public HotelDO Select(HotelDO objHotelDO)
        {
            return objHotelDAL.Select(objHotelDO);
        }

        public ArrayList SelectAll1( )
        {
         return objHotelDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objHotelDAL.SelectAll();
        }

        public DataTable SelectByServices()
        {
            return objHotelDAL.SelectByServices();
        }
     
#endregion          
    
        public DataTable SelectHotelHasBooking()
        {
            return objHotelDAL.SelectHotelHasBooking();
        }
        public DataTable SelectbyNumber()
        {
            return objHotelDAL.SelectbyNumber();
        }

        public DataTable Search(int ID, int ID1, int ID2)
        {
            return objHotelDAL.Search(ID, ID1, ID2);
        }

        public DataTable SelectbyDestination(int p)
        {
            return objHotelDAL.SelectbyDestination(p);
        }

        public DataTable SelectbyRate(int p, int i)
        {
            return objHotelDAL.SelectbyRate(p, i);
        }

        public DataTable GetAllByDesID(int p)
        {
            return objHotelDAL.GetAllByDesID(p);
        }

        public DataTable SelectbyTourType(int p)
        {
            return objHotelDAL.SelectbyTourType(p);
        }
        public DataTable SelectTopStarRates(int top)
        {
         return    objHotelDAL.SelectTopStarRates(top);
        }

        public DataTable SelectbyDesHome(int p, int record)
        {
            return objHotelDAL.SelectbyDesHome(p, record);
        }
    }

}
