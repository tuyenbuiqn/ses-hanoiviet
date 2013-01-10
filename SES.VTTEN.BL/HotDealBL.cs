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
/// Summary description for HotDealBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class HotDealBL 
    {
    	#region Private Variables
		HotDealDAL objHotDealDAL;
		#endregion
		
        #region Public Constructors
        public HotDealBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objHotDealDAL=new HotDealDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(HotDealDO objHotDealDO)
        {
            return objHotDealDAL.Insert(objHotDealDO);
        }

        public int Update(HotDealDO objHotDealDO)
        {
             return objHotDealDAL.Update(objHotDealDO);

        }

        public int Delete(HotDealDO objHotDealDO)
        {
             return objHotDealDAL.Delete(objHotDealDO);

        }

         public int DeleteAll()
        {
             return objHotDealDAL.DeleteAll();
        }

        public HotDealDO Select(HotDealDO objHotDealDO)
        {
            return objHotDealDAL.Select(objHotDealDO);
        }

        public ArrayList SelectAll1( )
        {
         return objHotDealDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
            return objHotDealDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectActive()
        {
            return objHotDealDAL.SelectActive();
        }
    }

}
