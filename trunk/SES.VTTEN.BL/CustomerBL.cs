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
/// Summary description for CustomerBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class CustomerBL 
    {
    	#region Private Variables
		CustomerDAL objCustomerDAL;
		#endregion
		
        #region Public Constructors
        public CustomerBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objCustomerDAL=new CustomerDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(CustomerDO objCustomerDO)
        {
            return objCustomerDAL.Insert(objCustomerDO);
        }

        public int Update(CustomerDO objCustomerDO)
        {
             return objCustomerDAL.Update(objCustomerDO);

        }

        public int Delete(CustomerDO objCustomerDO)
        {
             return objCustomerDAL.Delete(objCustomerDO);

        }

         public int DeleteAll()
        {
             return objCustomerDAL.DeleteAll();
        }

        public CustomerDO Select(CustomerDO objCustomerDO)
        {
            return objCustomerDAL.Select(objCustomerDO);
        }

        public ArrayList SelectAll1( )
        {
         return objCustomerDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objCustomerDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectbyBooking(int p)
        {
            return objCustomerDAL.SelectbyBooking(p);
        }

        public DataTable SelectBooking(int TourBookingID, int CustomerID)
        {
            return objCustomerDAL.SelectBooking(TourBookingID, CustomerID);
        }

    }

}
