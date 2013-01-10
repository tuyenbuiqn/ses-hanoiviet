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
/// Summary description for CustomTourDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class CustomTourDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public CustomTourDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(CustomTourDO objCustomTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomTour_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ETD", SqlDbType.DateTime);
Sqlparam.Value = objCustomTourDO.ETD;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@EstimatedDay", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.EstimatedDay;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelRates", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.HotelRates;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Breakfast", SqlDbType.Bit);
Sqlparam.Value = objCustomTourDO.Breakfast;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Lunch", SqlDbType.Bit);
Sqlparam.Value = objCustomTourDO.Lunch;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Dinner", SqlDbType.Bit);
Sqlparam.Value = objCustomTourDO.Dinner;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@InfomationSource", SqlDbType.NVarChar);
Sqlparam.Value = objCustomTourDO.InfomationSource;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdditionalComment", SqlDbType.NText);
Sqlparam.Value = objCustomTourDO.AdditionalComment;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@SentDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomTourDO.SentDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PaxNo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomTourDO.PaxNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Company", SqlDbType.NVarChar);
Sqlparam.Value = objCustomTourDO.Company;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(CustomTourDO objCustomTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomTour_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomTourID", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.CustomTourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ETD", SqlDbType.DateTime);
Sqlparam.Value = objCustomTourDO.ETD;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@EstimatedDay", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.EstimatedDay;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelRates", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.HotelRates;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Breakfast", SqlDbType.Bit);
Sqlparam.Value = objCustomTourDO.Breakfast;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Lunch", SqlDbType.Bit);
Sqlparam.Value = objCustomTourDO.Lunch;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Dinner", SqlDbType.Bit);
Sqlparam.Value = objCustomTourDO.Dinner;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@InfomationSource", SqlDbType.NVarChar);
Sqlparam.Value = objCustomTourDO.InfomationSource;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdditionalComment", SqlDbType.NText);
Sqlparam.Value = objCustomTourDO.AdditionalComment;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@SentDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomTourDO.SentDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PaxNo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomTourDO.PaxNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Company", SqlDbType.NVarChar);
Sqlparam.Value = objCustomTourDO.Company;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(CustomTourDO objCustomTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomTour_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CustomTourID", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.CustomTourID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomTour_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public CustomTourDO Select(CustomTourDO objCustomTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomTour_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@CustomTourID", SqlDbType.Int);
Sqlparam.Value = objCustomTourDO.CustomTourID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["CustomTourID"]))
objCustomTourDO.CustomTourID=Convert.ToInt32(dr["CustomTourID"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objCustomTourDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["ETD"]))
objCustomTourDO.ETD=Convert.ToDateTime(dr["ETD"]);
if(!Convert.IsDBNull(dr["EstimatedDay"]))
objCustomTourDO.EstimatedDay=Convert.ToInt32(dr["EstimatedDay"]);
if(!Convert.IsDBNull(dr["HotelRates"]))
objCustomTourDO.HotelRates=Convert.ToInt32(dr["HotelRates"]);
if(!Convert.IsDBNull(dr["Breakfast"]))
objCustomTourDO.Breakfast=Convert.ToBoolean(dr["Breakfast"]);
if(!Convert.IsDBNull(dr["Lunch"]))
objCustomTourDO.Lunch=Convert.ToBoolean(dr["Lunch"]);
if(!Convert.IsDBNull(dr["Dinner"]))
objCustomTourDO.Dinner=Convert.ToBoolean(dr["Dinner"]);
if(!Convert.IsDBNull(dr["InfomationSource"]))
objCustomTourDO.InfomationSource=Convert.ToString(dr["InfomationSource"]);
if(!Convert.IsDBNull(dr["AdditionalComment"]))
objCustomTourDO.AdditionalComment=Convert.ToString(dr["AdditionalComment"]);
if(!Convert.IsDBNull(dr["SentDate"]))
objCustomTourDO.SentDate=Convert.ToDateTime(dr["SentDate"]);
if(!Convert.IsDBNull(dr["PaxNo"]))
    objCustomTourDO.PaxNo = Convert.ToString(dr["PaxNo"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objCustomTourDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if (!Convert.IsDBNull(dr["Company"]))
    objCustomTourDO.Company = Convert.ToString(dr["Company"]);

            }
             return objCustomTourDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomTour_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrCustomTourDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
CustomTourDO objCustomTourDO= new CustomTourDO();
if(!Convert.IsDBNull(dr["CustomTourID"]))
objCustomTourDO.CustomTourID=Convert.ToInt32(dr["CustomTourID"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objCustomTourDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["ETD"]))
objCustomTourDO.ETD=Convert.ToDateTime(dr["ETD"]);
if(!Convert.IsDBNull(dr["EstimatedDay"]))
objCustomTourDO.EstimatedDay=Convert.ToInt32(dr["EstimatedDay"]);
if(!Convert.IsDBNull(dr["HotelRates"]))
objCustomTourDO.HotelRates=Convert.ToInt32(dr["HotelRates"]);
if(!Convert.IsDBNull(dr["Breakfast"]))
objCustomTourDO.Breakfast=Convert.ToBoolean(dr["Breakfast"]);
if(!Convert.IsDBNull(dr["Lunch"]))
objCustomTourDO.Lunch=Convert.ToBoolean(dr["Lunch"]);
if(!Convert.IsDBNull(dr["Dinner"]))
objCustomTourDO.Dinner=Convert.ToBoolean(dr["Dinner"]);
if(!Convert.IsDBNull(dr["InfomationSource"]))
objCustomTourDO.InfomationSource=Convert.ToString(dr["InfomationSource"]);
if(!Convert.IsDBNull(dr["AdditionalComment"]))
objCustomTourDO.AdditionalComment=Convert.ToString(dr["AdditionalComment"]);
if(!Convert.IsDBNull(dr["SentDate"]))
objCustomTourDO.SentDate=Convert.ToDateTime(dr["SentDate"]);
if(!Convert.IsDBNull(dr["PaxNo"]))
    objCustomTourDO.PaxNo = Convert.ToString(dr["PaxNo"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objCustomTourDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if (!Convert.IsDBNull(dr["Company"]))
    objCustomTourDO.Company = Convert.ToString(dr["Company"]);
arrCustomTourDO.Add(objCustomTourDO);
}
            }
               return arrCustomTourDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomTour_GetAll";
            
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
