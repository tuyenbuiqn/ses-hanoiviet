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
/// Summary description for AdvertBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class AdvertBL 
    {
    	#region Private Variables
		AdvertDAL objAdvertDAL;
		#endregion
		
        #region Public Constructors
        public AdvertBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objAdvertDAL=new AdvertDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(AdvertDO objAdvertDO)
        {
            return objAdvertDAL.Insert(objAdvertDO);
        }

        public int Update(AdvertDO objAdvertDO)
        {
             return objAdvertDAL.Update(objAdvertDO);

        }

        public int Delete(AdvertDO objAdvertDO)
        {
             return objAdvertDAL.Delete(objAdvertDO);

        }

         public int DeleteAll()
        {
             return objAdvertDAL.DeleteAll();
        }

        public AdvertDO Select(AdvertDO objAdvertDO)
        {
            return objAdvertDAL.Select(objAdvertDO);
        }

        public ArrayList SelectAll1( )
        {
         return objAdvertDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objAdvertDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable Selectleft()
        {
            return objAdvertDAL.Selectleft();
        }

        public DataTable Selectright()
        {
            return objAdvertDAL.Selectright();
        }
    }

}
