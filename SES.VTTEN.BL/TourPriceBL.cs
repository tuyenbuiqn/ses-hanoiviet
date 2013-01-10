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
/// Summary description for TourPriceBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourPriceBL 
    {
    	#region Private Variables
		TourPriceDAL objTourPriceDAL;
		#endregion
		
        #region Public Constructors
        public TourPriceBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourPriceDAL=new TourPriceDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourPriceDO objTourPriceDO)
        {
            return objTourPriceDAL.Insert(objTourPriceDO);
        }

        public int Update(TourPriceDO objTourPriceDO)
        {
             return objTourPriceDAL.Update(objTourPriceDO);

        }

        public int Delete(TourPriceDO objTourPriceDO)
        {
             return objTourPriceDAL.Delete(objTourPriceDO);

        }

         public int DeleteAll()
        {
             return objTourPriceDAL.DeleteAll();
        }

        public TourPriceDO Select(TourPriceDO objTourPriceDO)
        {
            return objTourPriceDAL.Select(objTourPriceDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourPriceDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourPriceDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectbyTour(int p)
        {
            return objTourPriceDAL.SelectbyTour(p);
        }

        public object SelectbyTourNonPivot(int p)
        {
            return objTourPriceDAL.SelectbyTourNonPivot(p);
        }

        public DataTable SelectByTourHotelPax(int TourID, int HotelID, int PaxID)
        {
            return objTourPriceDAL.SelectByTourHotelPax(TourID,HotelID,PaxID);
        }
    }

}
