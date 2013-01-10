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
/// Summary description for TourBookingDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourBookingDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourBookingDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourBookingDO objTourBookingDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourBooking_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourDepartureID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.TourDepartureID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
Sqlparam.Value = objTourBookingDO.CompanyName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PaymentType", SqlDbType.NVarChar);
Sqlparam.Value = objTourBookingDO.PaymentType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TotalPax", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.TotalPax;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherRequest", SqlDbType.NText);
Sqlparam.Value = objTourBookingDO.OtherRequest;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultNo", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.AdultNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildNo", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.ChildNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@BookingDate", SqlDbType.DateTime);
Sqlparam.Value = objTourBookingDO.BookingDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourBookingDO objTourBookingDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourBooking_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourBookingID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.TourBookingID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourDepartureID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.TourDepartureID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CompanyName", SqlDbType.NVarChar);
Sqlparam.Value = objTourBookingDO.CompanyName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PaymentType", SqlDbType.NVarChar);
Sqlparam.Value = objTourBookingDO.PaymentType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TotalPax", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.TotalPax;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherRequest", SqlDbType.NText);
Sqlparam.Value = objTourBookingDO.OtherRequest;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultNo", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.AdultNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildNo", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.ChildNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@BookingDate", SqlDbType.DateTime);
Sqlparam.Value = objTourBookingDO.BookingDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourBookingDO objTourBookingDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourBooking_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourBookingID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.TourBookingID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourBooking_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourBookingDO Select(TourBookingDO objTourBookingDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourBooking_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@TourBookingID", SqlDbType.Int);
Sqlparam.Value = objTourBookingDO.TourBookingID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["TourBookingID"]))
objTourBookingDO.TourBookingID=Convert.ToInt32(dr["TourBookingID"]);
if(!Convert.IsDBNull(dr["TourDepartureID"]))
objTourBookingDO.TourDepartureID=Convert.ToInt32(dr["TourDepartureID"]);
if(!Convert.IsDBNull(dr["CompanyName"]))
objTourBookingDO.CompanyName=Convert.ToString(dr["CompanyName"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objTourBookingDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["PaymentType"]))
    objTourBookingDO.PaymentType = Convert.ToString(dr["PaymentType"]);
if(!Convert.IsDBNull(dr["TotalPax"]))
objTourBookingDO.TotalPax=Convert.ToInt32(dr["TotalPax"]);
if(!Convert.IsDBNull(dr["OtherRequest"]))
objTourBookingDO.OtherRequest=Convert.ToString(dr["OtherRequest"]);
if(!Convert.IsDBNull(dr["AdultNo"]))
objTourBookingDO.AdultNo=Convert.ToInt32(dr["AdultNo"]);
if(!Convert.IsDBNull(dr["ChildNo"]))
objTourBookingDO.ChildNo=Convert.ToInt32(dr["ChildNo"]);
if(!Convert.IsDBNull(dr["BookingDate"]))
objTourBookingDO.BookingDate=Convert.ToDateTime(dr["BookingDate"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objTourBookingDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);

            }
             return objTourBookingDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourBooking_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourBookingDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourBookingDO objTourBookingDO= new TourBookingDO();
if(!Convert.IsDBNull(dr["TourBookingID"]))
objTourBookingDO.TourBookingID=Convert.ToInt32(dr["TourBookingID"]);
if(!Convert.IsDBNull(dr["TourDepartureID"]))
objTourBookingDO.TourDepartureID=Convert.ToInt32(dr["TourDepartureID"]);
if(!Convert.IsDBNull(dr["CompanyName"]))
    objTourBookingDO.CompanyName = Convert.ToString(dr["CompanyName"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objTourBookingDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["PaymentType"]))
    objTourBookingDO.PaymentType = Convert.ToString(dr["PaymentType"]);
if(!Convert.IsDBNull(dr["TotalPax"]))
objTourBookingDO.TotalPax=Convert.ToInt32(dr["TotalPax"]);
if(!Convert.IsDBNull(dr["OtherRequest"]))
objTourBookingDO.OtherRequest=Convert.ToString(dr["OtherRequest"]);
if(!Convert.IsDBNull(dr["AdultNo"]))
objTourBookingDO.AdultNo=Convert.ToInt32(dr["AdultNo"]);
if(!Convert.IsDBNull(dr["ChildNo"]))
objTourBookingDO.ChildNo=Convert.ToInt32(dr["ChildNo"]);
if(!Convert.IsDBNull(dr["BookingDate"]))
objTourBookingDO.BookingDate=Convert.ToDateTime(dr["BookingDate"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objTourBookingDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
arrTourBookingDO.Add(objTourBookingDO);
}
            }
               return arrTourBookingDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourBooking_GetAll";
            
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
