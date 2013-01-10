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
/// Summary description for TourHotelPackageBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourHotelPackageBL 
    {
    	#region Private Variables
		TourHotelPackageDAL objTourHotelPackageDAL;
		#endregion
		
        #region Public Constructors
        public TourHotelPackageBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourHotelPackageDAL=new TourHotelPackageDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourHotelPackageDO objTourHotelPackageDO)
        {
            return objTourHotelPackageDAL.Insert(objTourHotelPackageDO);
        }

        public int Update(TourHotelPackageDO objTourHotelPackageDO)
        {
             return objTourHotelPackageDAL.Update(objTourHotelPackageDO);

        }

        public int Delete(TourHotelPackageDO objTourHotelPackageDO)
        {
             return objTourHotelPackageDAL.Delete(objTourHotelPackageDO);

        }

         public int DeleteAll()
        {
             return objTourHotelPackageDAL.DeleteAll();
        }

        public TourHotelPackageDO Select(TourHotelPackageDO objTourHotelPackageDO)
        {
            return objTourHotelPackageDAL.Select(objTourHotelPackageDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourHotelPackageDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourHotelPackageDAL.SelectAll();
        }


     
#endregion          
    
    }

}
