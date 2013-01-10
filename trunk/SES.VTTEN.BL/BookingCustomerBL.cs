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
/// Summary description for BookingCustomerBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class BookingCustomerBL 
    {
    	#region Private Variables
		BookingCustomerDAL objBookingCustomerDAL;
		#endregion
		
        #region Public Constructors
        public BookingCustomerBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objBookingCustomerDAL=new BookingCustomerDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(BookingCustomerDO objBookingCustomerDO)
        {
            return objBookingCustomerDAL.Insert(objBookingCustomerDO);
        }

        public int Update(BookingCustomerDO objBookingCustomerDO)
        {
             return objBookingCustomerDAL.Update(objBookingCustomerDO);

        }

        public int Delete(BookingCustomerDO objBookingCustomerDO)
        {
             return objBookingCustomerDAL.Delete(objBookingCustomerDO);

        }

         public int DeleteAll()
        {
             return objBookingCustomerDAL.DeleteAll();
        }

        public BookingCustomerDO Select(BookingCustomerDO objBookingCustomerDO)
        {
            return objBookingCustomerDAL.Select(objBookingCustomerDO);
        }

        public ArrayList SelectAll1( )
        {
         return objBookingCustomerDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objBookingCustomerDAL.SelectAll();
        }


     
#endregion          
    
    }

}
