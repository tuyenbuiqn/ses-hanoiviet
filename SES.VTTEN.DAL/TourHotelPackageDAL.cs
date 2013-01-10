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
/// Summary description for TourHotelPackageDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourHotelPackageDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourHotelPackageDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourHotelPackageDO objTourHotelPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourHotelPackage_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@PackageName", SqlDbType.NVarChar);
Sqlparam.Value = objTourHotelPackageDO.PackageName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objTourHotelPackageDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourHotelPackageDO objTourHotelPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourHotelPackage_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@HotelPackageID", SqlDbType.Int);
Sqlparam.Value = objTourHotelPackageDO.HotelPackageID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PackageName", SqlDbType.NVarChar);
Sqlparam.Value = objTourHotelPackageDO.PackageName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objTourHotelPackageDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourHotelPackageDO objTourHotelPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourHotelPackage_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@HotelPackageID", SqlDbType.Int);
Sqlparam.Value = objTourHotelPackageDO.HotelPackageID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourHotelPackage_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourHotelPackageDO Select(TourHotelPackageDO objTourHotelPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourHotelPackage_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@HotelPackageID", SqlDbType.Int);
Sqlparam.Value = objTourHotelPackageDO.HotelPackageID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["HotelPackageID"]))
objTourHotelPackageDO.HotelPackageID=Convert.ToInt32(dr["HotelPackageID"]);
if(!Convert.IsDBNull(dr["PackageName"]))
objTourHotelPackageDO.PackageName=Convert.ToString(dr["PackageName"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objTourHotelPackageDO.OrderID=Convert.ToInt32(dr["OrderID"]);

            }
             return objTourHotelPackageDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourHotelPackage_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourHotelPackageDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourHotelPackageDO objTourHotelPackageDO= new TourHotelPackageDO();
if(!Convert.IsDBNull(dr["HotelPackageID"]))
objTourHotelPackageDO.HotelPackageID=Convert.ToInt32(dr["HotelPackageID"]);
if(!Convert.IsDBNull(dr["PackageName"]))
objTourHotelPackageDO.PackageName=Convert.ToString(dr["PackageName"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objTourHotelPackageDO.OrderID=Convert.ToInt32(dr["OrderID"]);
arrTourHotelPackageDO.Add(objTourHotelPackageDO);
}
            }
               return arrTourHotelPackageDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourHotelPackage_GetAll";
            
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
