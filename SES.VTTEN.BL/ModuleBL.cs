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
/// Summary description for ModuleBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class ModuleBL 
    {
    	#region Private Variables
		ModuleDAL objModuleDAL;
		#endregion
		
        #region Public Constructors
        public ModuleBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objModuleDAL=new ModuleDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ModuleDO objModuleDO)
        {
            return objModuleDAL.Insert(objModuleDO);
        }

        public int Update(ModuleDO objModuleDO)
        {
             return objModuleDAL.Update(objModuleDO);

        }

        public int Delete(ModuleDO objModuleDO)
        {
             return objModuleDAL.Delete(objModuleDO);

        }

         public int DeleteAll()
        {
             return objModuleDAL.DeleteAll();
        }

        public ModuleDO Select(ModuleDO objModuleDO)
        {
            return objModuleDAL.Select(objModuleDO);
        }

        public ArrayList SelectAll1( )
        {
         return objModuleDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objModuleDAL.SelectAll();
        }


     
#endregion          
    
    }

}
