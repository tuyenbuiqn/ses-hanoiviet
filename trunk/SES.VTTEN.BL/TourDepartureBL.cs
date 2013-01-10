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
/// Summary description for TourDepartureBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourDepartureBL 
    {
    	#region Private Variables
		TourDepartureDAL objTourDepartureDAL;
		#endregion
		
        #region Public Constructors
        public TourDepartureBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourDepartureDAL=new TourDepartureDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourDepartureDO objTourDepartureDO)
        {
            return objTourDepartureDAL.Insert(objTourDepartureDO);
        }

        public int Update(TourDepartureDO objTourDepartureDO)
        {
             return objTourDepartureDAL.Update(objTourDepartureDO);

        }

        public int Delete(TourDepartureDO objTourDepartureDO)
        {
             return objTourDepartureDAL.Delete(objTourDepartureDO);

        }

         public int DeleteAll()
        {
             return objTourDepartureDAL.DeleteAll();
        }

        public TourDepartureDO Select(TourDepartureDO objTourDepartureDO)
        {
            return objTourDepartureDAL.Select(objTourDepartureDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourDepartureDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourDepartureDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectbyFK(int TourID)
        {
            return objTourDepartureDAL.SelectbyFK(TourID);
        }

        public object SelectbyFK1(int TourID)
        {
            return objTourDepartureDAL.SelectbyFK1(TourID);
        }
    }

}
