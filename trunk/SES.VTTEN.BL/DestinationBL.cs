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
/// Summary description for DestinationBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class DestinationBL 
    {
    	#region Private Variables
		DestinationDAL objDestinationDAL;
		#endregion
		
        #region Public Constructors
        public DestinationBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objDestinationDAL=new DestinationDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(DestinationDO objDestinationDO)
        {
            return objDestinationDAL.Insert(objDestinationDO);
        }

        public int Update(DestinationDO objDestinationDO)
        {
             return objDestinationDAL.Update(objDestinationDO);

        }

        public int Delete(DestinationDO objDestinationDO)
        {
             return objDestinationDAL.Delete(objDestinationDO);

        }

         public int DeleteAll()
        {
             return objDestinationDAL.DeleteAll();
        }

        public DestinationDO Select(DestinationDO objDestinationDO)
        {
            return objDestinationDAL.Select(objDestinationDO);
        }
        public DataTable SelectByRegions(int Regions)
        {
            return objDestinationDAL.SelectByRegions(Regions);
        }
        public ArrayList SelectAll1( )
        {
         return objDestinationDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objDestinationDAL.SelectAll();
        }


     
#endregion          
    
    
        public DestinationDO Selectby(int id, int p)
        {
            return objDestinationDAL.Selectby(id, p);
        }

        public DataTable SelectByParentID(int ParentID)
        {
            return objDestinationDAL.SelectByParentID(ParentID);
        }

        public DataTable SelectTop()
        {
            return objDestinationDAL.SelectTop();
        }

        public DataTable SelectRoot()
        {
            return objDestinationDAL.SelectRoot();
        }

        public DataTable SelectTop1()
        {
            return objDestinationDAL.SelectTop1();
        }

        public DataTable SelectByParentIDNoZero()
        {
            return objDestinationDAL.SelectByParentIDNoZero();
        }

        public DataTable SelectHome(int p)
        {
            return objDestinationDAL.SelectHome(p);
        }

        public DataTable SelectHotelCat()
        {
            return objDestinationDAL.SelectHotelCat();
        }
    }

}
