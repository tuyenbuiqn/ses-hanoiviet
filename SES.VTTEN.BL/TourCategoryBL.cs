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
/// Summary description for TourCategoryBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourCategoryBL 
    {
    	#region Private Variables
		TourCategoryDAL objTourCategoryDAL;
		#endregion
		
        #region Public Constructors
        public TourCategoryBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourCategoryDAL=new TourCategoryDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourCategoryDO objTourCategoryDO)
        {
            return objTourCategoryDAL.Insert(objTourCategoryDO);
        }

        public int Update(TourCategoryDO objTourCategoryDO)
        {
             return objTourCategoryDAL.Update(objTourCategoryDO);

        }

        public int Delete(TourCategoryDO objTourCategoryDO)
        {
             return objTourCategoryDAL.Delete(objTourCategoryDO);

        }

         public int DeleteAll()
        {
             return objTourCategoryDAL.DeleteAll();
        }

        public TourCategoryDO Select(TourCategoryDO objTourCategoryDO)
        {
            return objTourCategoryDAL.Select(objTourCategoryDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourCategoryDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourCategoryDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectbyNumber()
        {
            return objTourCategoryDAL.SelectbyNumber();
        }
    }

}
