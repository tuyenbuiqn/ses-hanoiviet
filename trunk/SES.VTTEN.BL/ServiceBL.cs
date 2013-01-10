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
/// Summary description for ServiceBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class ServiceBL 
    {
    	#region Private Variables
		ServiceDAL objServiceDAL;
		#endregion
		
        #region Public Constructors
        public ServiceBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objServiceDAL=new ServiceDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ServiceDO objServiceDO)
        {
            return objServiceDAL.Insert(objServiceDO);
        }

        public int Update(ServiceDO objServiceDO)
        {
             return objServiceDAL.Update(objServiceDO);

        }

        public int Delete(ServiceDO objServiceDO)
        {
             return objServiceDAL.Delete(objServiceDO);

        }

         public int DeleteAll()
        {
             return objServiceDAL.DeleteAll();
        }

        public ServiceDO Select(ServiceDO objServiceDO)
        {
            return objServiceDAL.Select(objServiceDO);
        }

        public ArrayList SelectAll1( )
        {
         return objServiceDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objServiceDAL.SelectAll();
        }


     
#endregion          
    
    }

}
