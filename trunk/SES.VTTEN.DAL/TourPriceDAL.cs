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
/// Summary description for TourPriceDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourPriceDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourPriceDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourPriceDO objTourPriceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPrice_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PaxPackageID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.PaxPackageID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelPackageID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.HotelPackageID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Price", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.Price;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PriceVisible", SqlDbType.Bit);
Sqlparam.Value = objTourPriceDO.PriceVisible;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourPriceDO objTourPriceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPrice_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourPriceID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.TourPriceID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PaxPackageID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.PaxPackageID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelPackageID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.HotelPackageID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Price", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.Price;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PriceVisible", SqlDbType.Bit);
Sqlparam.Value = objTourPriceDO.PriceVisible;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourPriceDO objTourPriceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPrice_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourPriceID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.TourPriceID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPrice_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourPriceDO Select(TourPriceDO objTourPriceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPrice_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@TourPriceID", SqlDbType.Int);
Sqlparam.Value = objTourPriceDO.TourPriceID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["TourPriceID"]))
objTourPriceDO.TourPriceID=Convert.ToInt32(dr["TourPriceID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourPriceDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["PaxPackageID"]))
objTourPriceDO.PaxPackageID=Convert.ToInt32(dr["PaxPackageID"]);
if(!Convert.IsDBNull(dr["HotelPackageID"]))
objTourPriceDO.HotelPackageID=Convert.ToInt32(dr["HotelPackageID"]);
if(!Convert.IsDBNull(dr["Price"]))
objTourPriceDO.Price=Convert.ToInt32(dr["Price"]);
if(!Convert.IsDBNull(dr["PriceVisible"]))
objTourPriceDO.PriceVisible=Convert.ToBoolean(dr["PriceVisible"]);

            }
             return objTourPriceDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPrice_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourPriceDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourPriceDO objTourPriceDO= new TourPriceDO();
if(!Convert.IsDBNull(dr["TourPriceID"]))
objTourPriceDO.TourPriceID=Convert.ToInt32(dr["TourPriceID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourPriceDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["PaxPackageID"]))
objTourPriceDO.PaxPackageID=Convert.ToInt32(dr["PaxPackageID"]);
if(!Convert.IsDBNull(dr["HotelPackageID"]))
objTourPriceDO.HotelPackageID=Convert.ToInt32(dr["HotelPackageID"]);
if(!Convert.IsDBNull(dr["Price"]))
objTourPriceDO.Price=Convert.ToInt32(dr["Price"]);
if(!Convert.IsDBNull(dr["PriceVisible"]))
objTourPriceDO.PriceVisible=Convert.ToBoolean(dr["PriceVisible"]);
arrTourPriceDO.Add(objTourPriceDO);
}
            }
               return arrTourPriceDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPrice_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectbyTour(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourPrice_GetByTourID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectbyTourNonPivot(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourPrice_GetByTourIDNonPivot";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectByTourHotelPax(int TourID, int HotelPackageID, int PaxPackageID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourPrice_GetByTourHotelPax";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = TourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelPackageID", SqlDbType.Int);
            Sqlparam.Value = HotelPackageID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PaxPackageID", SqlDbType.Int);
            Sqlparam.Value = PaxPackageID;
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
