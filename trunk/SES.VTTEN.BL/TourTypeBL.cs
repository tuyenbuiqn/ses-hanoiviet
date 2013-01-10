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
/// Summary description for TourTypeBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourTypeBL 
    {
    	#region Private Variables
		TourTypeDAL objTourTypeDAL;
		#endregion
		
        #region Public Constructors
        public TourTypeBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourTypeDAL=new TourTypeDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourTypeDO objTourTypeDO)
        {
            return objTourTypeDAL.Insert(objTourTypeDO);
        }

        public int Update(TourTypeDO objTourTypeDO)
        {
             return objTourTypeDAL.Update(objTourTypeDO);

        }

        public int Delete(TourTypeDO objTourTypeDO)
        {
             return objTourTypeDAL.Delete(objTourTypeDO);

        }

         public int DeleteAll()
        {
             return objTourTypeDAL.DeleteAll();
        }

        public TourTypeDO Select(TourTypeDO objTourTypeDO)
        {
            return objTourTypeDAL.Select(objTourTypeDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourTypeDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourTypeDAL.SelectAll();
        }


        public DataTable SelectHomePublish(bool IsHomepage, bool Published)
        {
            return objTourTypeDAL.SelectHomePublish(IsHomepage,Published);
        }
        public TourTypeDO Selectby(int id, int p)
        {
            return objTourTypeDAL.Selectby(id, p);
        }
#endregion          
       
    
        public DataTable SelectByTopID(int ParentID)
        {
            return objTourTypeDAL.SelectByTopID(ParentID);
        }

        public DataTable SelectByTopIDOnlyChild(int ParentID)
        {
            return objTourTypeDAL.SelectByTopIDOnlyChild(ParentID);
        }
        public DataTable SelectByTopIDOnlyChildHomepage(int ParentID)
        {
            return objTourTypeDAL.SelectByTopIDOnlyChildHomepage(ParentID);
        }

        public DataTable SelectOne(int ParentID)
        {
            return objTourTypeDAL.SelectOne(ParentID);
        }
        public DataTable SelectAllParentHomePublish(bool IsHomepage, bool Published)
        {
            return objTourTypeDAL.SelectAllParentHomePublish(IsHomepage, Published);
        }
    }

}
