/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;

using  SES.VTTEN.DAL;
using SES.VTTEN.DO;
/// <summary>
/// Summary description for FooterTagBL
/// </summary>
namespace  SES.VTTEN.BL 
{
    public class FooterTagBL 
    {
    	#region Private Variables
		FooterTagDAL objFooterTagDAL;
		#endregion
		
        #region Public Constructors
        public FooterTagBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objFooterTagDAL=new FooterTagDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(FooterTagDO objFooterTagDO)
        {
            return objFooterTagDAL.Insert(objFooterTagDO);
        }

        public int Update(FooterTagDO objFooterTagDO)
        {
             return objFooterTagDAL.Update(objFooterTagDO);

        }

        public int Delete(FooterTagDO objFooterTagDO)
        {
             return objFooterTagDAL.Delete(objFooterTagDO);

        }

         public int DeleteAll()
        {
             return objFooterTagDAL.DeleteAll();
        }

        public FooterTagDO Select(FooterTagDO objFooterTagDO)
        {
            return objFooterTagDAL.Select(objFooterTagDO);
        }

        public ArrayList SelectAll1( )
        {
         return objFooterTagDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objFooterTagDAL.SelectAll();
        }


     
#endregion          
    
    
        public FooterTagDO SelectTop()
        {
            return objFooterTagDAL.SelectTop();
        }
    }

}
