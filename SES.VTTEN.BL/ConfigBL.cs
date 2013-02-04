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
/// Summary description for ConfigBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class ConfigBL 
    {
    	#region Private Variables
		ConfigDAL objConfigDAL;
		#endregion
		
        #region Public Constructors
        public ConfigBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objConfigDAL=new ConfigDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ConfigDO objConfigDO)
        {
            return objConfigDAL.Insert(objConfigDO);
        }

        public int Update(ConfigDO objConfigDO)
        {
             return objConfigDAL.Update(objConfigDO);

        }

        public int Delete(ConfigDO objConfigDO)
        {
             return objConfigDAL.Delete(objConfigDO);

        }

         public int DeleteAll()
        {
             return objConfigDAL.DeleteAll();
        }

        public ConfigDO Select(ConfigDO objConfigDO)
        {
            return objConfigDAL.Select(objConfigDO);
        }

        public ArrayList SelectAll1( )
        {
         return objConfigDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objConfigDAL.SelectAll();
        }

        public DataTable SelectByConfigID(int ConfigID)
        {
            return objConfigDAL.SelectByConfigID(ConfigID);
        }
     
#endregion          
    
    }

}
