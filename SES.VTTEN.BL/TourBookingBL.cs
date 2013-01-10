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
/// Summary description for TourBookingBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourBookingBL 
    {
    	#region Private Variables
		TourBookingDAL objTourBookingDAL;
		#endregion
		
        #region Public Constructors
        public TourBookingBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourBookingDAL=new TourBookingDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourBookingDO objTourBookingDO)
        {
            return objTourBookingDAL.Insert(objTourBookingDO);
        }

        public int Update(TourBookingDO objTourBookingDO)
        {
             return objTourBookingDAL.Update(objTourBookingDO);

        }

        public int Delete(TourBookingDO objTourBookingDO)
        {
             return objTourBookingDAL.Delete(objTourBookingDO);

        }

         public int DeleteAll()
        {
             return objTourBookingDAL.DeleteAll();
        }

        public TourBookingDO Select(TourBookingDO objTourBookingDO)
        {
            return objTourBookingDAL.Select(objTourBookingDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourBookingDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourBookingDAL.SelectAll();
        }


     
#endregion          
    
    }

}
