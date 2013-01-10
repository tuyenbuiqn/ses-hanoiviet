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
/// Summary description for NationBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class NationBL 
    {
    	#region Private Variables
		NationDAL objNationDAL;
		#endregion
		
        #region Public Constructors
        public NationBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objNationDAL=new NationDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(NationDO objNationDO)
        {
            return objNationDAL.Insert(objNationDO);
        }

        public int Update(NationDO objNationDO)
        {
             return objNationDAL.Update(objNationDO);

        }

        public int Delete(NationDO objNationDO)
        {
             return objNationDAL.Delete(objNationDO);

        }

         public int DeleteAll()
        {
             return objNationDAL.DeleteAll();
        }

        public NationDO Select(NationDO objNationDO)
        {
            return objNationDAL.Select(objNationDO);
        }

        public ArrayList SelectAll1( )
        {
         return objNationDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objNationDAL.SelectAll();
        }


     
#endregion          
    
    }

}
