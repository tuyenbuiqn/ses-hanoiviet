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
/// Summary description for CustomerReviewBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class CustomerReviewBL 
    {
    	#region Private Variables
		CustomerReviewDAL objCustomerReviewDAL;
		#endregion
		
        #region Public Constructors
        public CustomerReviewBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objCustomerReviewDAL=new CustomerReviewDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(CustomerReviewDO objCustomerReviewDO)
        {
            return objCustomerReviewDAL.Insert(objCustomerReviewDO);
        }

        public int Update(CustomerReviewDO objCustomerReviewDO)
        {
             return objCustomerReviewDAL.Update(objCustomerReviewDO);

        }

        public int Delete(CustomerReviewDO objCustomerReviewDO)
        {
             return objCustomerReviewDAL.Delete(objCustomerReviewDO);

        }

         public int DeleteAll()
        {
             return objCustomerReviewDAL.DeleteAll();
        }

        public CustomerReviewDO Select(CustomerReviewDO objCustomerReviewDO)
        {
            return objCustomerReviewDAL.Select(objCustomerReviewDO);
        }

        public ArrayList SelectAll1( )
        {
         return objCustomerReviewDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objCustomerReviewDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectHome(int p)
        {
            return objCustomerReviewDAL.SelectHome(p);
        }
    }

}
