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
/// Summary description for TourDepartureDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourDepartureDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourDepartureDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourDepartureDO objTourDepartureDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDeparture_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DepartureCode", SqlDbType.NVarChar);
Sqlparam.Value = objTourDepartureDO.DepartureCode;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DepartureDate", SqlDbType.DateTime);
Sqlparam.Value = objTourDepartureDO.DepartureDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TotalPax", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.TotalPax;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AvailablePax", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.AvailablePax;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.AdultPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.ChildPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildSaleOffPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.ChildSaleOffPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultSaleOffPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.AdultSaleOffPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ReturnDate", SqlDbType.DateTime);
Sqlparam.Value = objTourDepartureDO.ReturnDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objTourDepartureDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourDepartureDO objTourDepartureDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDeparture_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourDepartureID", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.TourDepartureID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DepartureCode", SqlDbType.NVarChar);
Sqlparam.Value = objTourDepartureDO.DepartureCode;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DepartureDate", SqlDbType.DateTime);
Sqlparam.Value = objTourDepartureDO.DepartureDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TotalPax", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.TotalPax;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AvailablePax", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.AvailablePax;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.AdultPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.ChildPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildSaleOffPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.ChildSaleOffPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultSaleOffPrice", SqlDbType.Float);
Sqlparam.Value = objTourDepartureDO.AdultSaleOffPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ReturnDate", SqlDbType.DateTime);
Sqlparam.Value = objTourDepartureDO.ReturnDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objTourDepartureDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourDepartureDO objTourDepartureDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDeparture_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourDepartureID", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.TourDepartureID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDeparture_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourDepartureDO Select(TourDepartureDO objTourDepartureDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDeparture_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@TourDepartureID", SqlDbType.Int);
Sqlparam.Value = objTourDepartureDO.TourDepartureID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["TourDepartureID"]))
objTourDepartureDO.TourDepartureID=Convert.ToInt32(dr["TourDepartureID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourDepartureDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["DepartureCode"]))
    objTourDepartureDO.DepartureCode = Convert.ToString(dr["DepartureCode"]);
if(!Convert.IsDBNull(dr["DepartureDate"]))
objTourDepartureDO.DepartureDate=Convert.ToDateTime(dr["DepartureDate"]);
if(!Convert.IsDBNull(dr["TotalPax"]))
objTourDepartureDO.TotalPax=Convert.ToInt32(dr["TotalPax"]);
if(!Convert.IsDBNull(dr["AvailablePax"]))
objTourDepartureDO.AvailablePax=Convert.ToInt32(dr["AvailablePax"]);
if(!Convert.IsDBNull(dr["AdultPrice"]))
objTourDepartureDO.AdultPrice=Convert.ToDouble(dr["AdultPrice"]);
if(!Convert.IsDBNull(dr["ChildPrice"]))
objTourDepartureDO.ChildPrice=Convert.ToDouble(dr["ChildPrice"]);
if(!Convert.IsDBNull(dr["ChildSaleOffPrice"]))
objTourDepartureDO.ChildSaleOffPrice=Convert.ToDouble(dr["ChildSaleOffPrice"]);
if(!Convert.IsDBNull(dr["AdultSaleOffPrice"]))
objTourDepartureDO.AdultSaleOffPrice=Convert.ToDouble(dr["AdultSaleOffPrice"]);
if(!Convert.IsDBNull(dr["ReturnDate"]))
objTourDepartureDO.ReturnDate=Convert.ToDateTime(dr["ReturnDate"]);
if(!Convert.IsDBNull(dr["Description"]))
objTourDepartureDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objTourDepartureDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);

            }
             return objTourDepartureDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDeparture_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourDepartureDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourDepartureDO objTourDepartureDO= new TourDepartureDO();
if(!Convert.IsDBNull(dr["TourDepartureID"]))
objTourDepartureDO.TourDepartureID=Convert.ToInt32(dr["TourDepartureID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourDepartureDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["DepartureCode"]))
    objTourDepartureDO.DepartureCode = Convert.ToString(dr["DepartureCode"]);
if(!Convert.IsDBNull(dr["DepartureDate"]))
objTourDepartureDO.DepartureDate=Convert.ToDateTime(dr["DepartureDate"]);
if(!Convert.IsDBNull(dr["TotalPax"]))
objTourDepartureDO.TotalPax=Convert.ToInt32(dr["TotalPax"]);
if(!Convert.IsDBNull(dr["AvailablePax"]))
objTourDepartureDO.AvailablePax=Convert.ToInt32(dr["AvailablePax"]);
if(!Convert.IsDBNull(dr["AdultPrice"]))
objTourDepartureDO.AdultPrice=Convert.ToDouble(dr["AdultPrice"]);
if(!Convert.IsDBNull(dr["ChildPrice"]))
objTourDepartureDO.ChildPrice=Convert.ToDouble(dr["ChildPrice"]);
if(!Convert.IsDBNull(dr["ChildSaleOffPrice"]))
objTourDepartureDO.ChildSaleOffPrice=Convert.ToDouble(dr["ChildSaleOffPrice"]);
if(!Convert.IsDBNull(dr["AdultSaleOffPrice"]))
objTourDepartureDO.AdultSaleOffPrice=Convert.ToDouble(dr["AdultSaleOffPrice"]);
if(!Convert.IsDBNull(dr["ReturnDate"]))
objTourDepartureDO.ReturnDate=Convert.ToDateTime(dr["ReturnDate"]);
if(!Convert.IsDBNull(dr["Description"]))
objTourDepartureDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objTourDepartureDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
arrTourDepartureDO.Add(objTourDepartureDO);
}
            }
               return arrTourDepartureDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDeparture_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectbyFK(int TourID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourDeparture_GetbyFK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = TourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public object SelectbyFK1(int TourID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourDeparture_GetbyFK1";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = TourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
    }

}
