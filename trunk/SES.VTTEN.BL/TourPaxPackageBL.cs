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
/// Summary description for TourPaxPackageBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourPaxPackageBL 
    {
    	#region Private Variables
		TourPaxPackageDAL objTourPaxPackageDAL;
		#endregion
		
        #region Public Constructors
        public TourPaxPackageBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourPaxPackageDAL=new TourPaxPackageDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourPaxPackageDO objTourPaxPackageDO)
        {
            return objTourPaxPackageDAL.Insert(objTourPaxPackageDO);
        }

        public int Update(TourPaxPackageDO objTourPaxPackageDO)
        {
             return objTourPaxPackageDAL.Update(objTourPaxPackageDO);

        }

        public int Delete(TourPaxPackageDO objTourPaxPackageDO)
        {
             return objTourPaxPackageDAL.Delete(objTourPaxPackageDO);

        }

         public int DeleteAll()
        {
             return objTourPaxPackageDAL.DeleteAll();
        }

        public TourPaxPackageDO Select(TourPaxPackageDO objTourPaxPackageDO)
        {
            return objTourPaxPackageDAL.Select(objTourPaxPackageDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourPaxPackageDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourPaxPackageDAL.SelectAll();
        }


     
#endregion          
    
    }

}
