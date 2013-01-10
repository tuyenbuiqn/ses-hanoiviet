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
/// Summary description for HotDealDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class HotDealDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public HotDealDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(HotDealDO objHotDealDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotDeal_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objHotDealDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objHotDealDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objHotDealDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourDepartureID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.TourDepartureID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.HotelID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateStart", SqlDbType.DateTime);
Sqlparam.Value = objHotDealDO.DateStart;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateEnd", SqlDbType.DateTime);
Sqlparam.Value = objHotDealDO.DateEnd;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultPrice", SqlDbType.NVarChar);
Sqlparam.Value = objHotDealDO.AdultPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildPrice", SqlDbType.NVarChar);
Sqlparam.Value = objHotDealDO.ChildPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(HotDealDO objHotDealDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotDeal_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@HotDealID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.HotDealID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objHotDealDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objHotDealDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objHotDealDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourDepartureID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.TourDepartureID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.HotelID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateStart", SqlDbType.DateTime);
Sqlparam.Value = objHotDealDO.DateStart;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateEnd", SqlDbType.DateTime);
Sqlparam.Value = objHotDealDO.DateEnd;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultPrice", SqlDbType.NVarChar);
Sqlparam.Value = objHotDealDO.AdultPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildPrice", SqlDbType.NVarChar);
Sqlparam.Value = objHotDealDO.ChildPrice;
Sqlcomm.Parameters.Add(Sqlparam);

            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(HotDealDO objHotDealDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotDeal_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@HotDealID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.HotDealID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotDeal_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public HotDealDO Select(HotDealDO objHotDealDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotDeal_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@HotDealID", SqlDbType.Int);
Sqlparam.Value = objHotDealDO.HotDealID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["HotDealID"]))
objHotDealDO.HotDealID=Convert.ToInt32(dr["HotDealID"]);
if(!Convert.IsDBNull(dr["Title"]))
    objHotDealDO.Title = Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Description"]))
objHotDealDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Published"]))
objHotDealDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objHotDealDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["TourDepartureID"]))
objHotDealDO.TourDepartureID=Convert.ToInt32(dr["TourDepartureID"]);
if(!Convert.IsDBNull(dr["HotelID"]))
objHotDealDO.HotelID=Convert.ToInt32(dr["HotelID"]);
if(!Convert.IsDBNull(dr["DateStart"]))
objHotDealDO.DateStart=Convert.ToDateTime(dr["DateStart"]);
if(!Convert.IsDBNull(dr["DateEnd"]))
objHotDealDO.DateEnd=Convert.ToDateTime(dr["DateEnd"]);

if (!Convert.IsDBNull(dr["AdultPrice"]))
    objHotDealDO.AdultPrice = Convert.ToString(dr["AdultPrice"]);
if (!Convert.IsDBNull(dr["ChildPrice"]))
    objHotDealDO.ChildPrice = Convert.ToString(dr["ChildPrice"]);

            }
             return objHotDealDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotDeal_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrHotDealDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
HotDealDO objHotDealDO= new HotDealDO();
if(!Convert.IsDBNull(dr["HotDealID"]))
objHotDealDO.HotDealID=Convert.ToInt32(dr["HotDealID"]);
if(!Convert.IsDBNull(dr["Title"]))
    objHotDealDO.Title = Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Description"]))
objHotDealDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Published"]))
objHotDealDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objHotDealDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["TourDepartureID"]))
objHotDealDO.TourDepartureID=Convert.ToInt32(dr["TourDepartureID"]);
if(!Convert.IsDBNull(dr["HotelID"]))
objHotDealDO.HotelID=Convert.ToInt32(dr["HotelID"]);
if(!Convert.IsDBNull(dr["DateStart"]))
objHotDealDO.DateStart=Convert.ToDateTime(dr["DateStart"]);
if(!Convert.IsDBNull(dr["DateEnd"]))
objHotDealDO.DateEnd=Convert.ToDateTime(dr["DateEnd"]);
if (!Convert.IsDBNull(dr["AdultPrice"]))
    objHotDealDO.AdultPrice = Convert.ToString(dr["AdultPrice"]);
if (!Convert.IsDBNull(dr["ChildPrice"]))
    objHotDealDO.ChildPrice = Convert.ToString(dr["ChildPrice"]);
arrHotDealDO.Add(objHotDealDO);
}
            }
               return arrHotDealDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotDeal_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectActive()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotDeal_GetByActive";
         
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
