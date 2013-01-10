/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using SES.VTTEN.DO;
/// <summary>
/// Summary description for BookingCustomerDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class BookingCustomerDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public BookingCustomerDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(BookingCustomerDO objBookingCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spBookingCustomer_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourBookingID", SqlDbType.Int);
Sqlparam.Value = objBookingCustomerDO.TourBookingID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objBookingCustomerDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(BookingCustomerDO objBookingCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spBookingCustomer_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@BookingCustomerID", SqlDbType.Int);
Sqlparam.Value = objBookingCustomerDO.BookingCustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourBookingID", SqlDbType.Int);
Sqlparam.Value = objBookingCustomerDO.TourBookingID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objBookingCustomerDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(BookingCustomerDO objBookingCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spBookingCustomer_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@BookingCustomerID", SqlDbType.Int);
Sqlparam.Value = objBookingCustomerDO.BookingCustomerID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spBookingCustomer_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public BookingCustomerDO Select(BookingCustomerDO objBookingCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spBookingCustomer_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@BookingCustomerID", SqlDbType.Int);
Sqlparam.Value = objBookingCustomerDO.BookingCustomerID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["BookingCustomerID"]))
objBookingCustomerDO.BookingCustomerID=Convert.ToInt32(dr["BookingCustomerID"]);
if(!Convert.IsDBNull(dr["TourBookingID"]))
objBookingCustomerDO.TourBookingID=Convert.ToInt32(dr["TourBookingID"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objBookingCustomerDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);

            }
             return objBookingCustomerDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spBookingCustomer_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrBookingCustomerDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
BookingCustomerDO objBookingCustomerDO= new BookingCustomerDO();
if(!Convert.IsDBNull(dr["BookingCustomerID"]))
objBookingCustomerDO.BookingCustomerID=Convert.ToInt32(dr["BookingCustomerID"]);
if(!Convert.IsDBNull(dr["TourBookingID"]))
objBookingCustomerDO.TourBookingID=Convert.ToInt32(dr["TourBookingID"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objBookingCustomerDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
arrBookingCustomerDO.Add(objBookingCustomerDO);
}
            }
               return arrBookingCustomerDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spBookingCustomer_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    }

}
