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
/// Summary description for TourPaxPackageDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourPaxPackageDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourPaxPackageDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourPaxPackageDO objTourPaxPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPaxPackage_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@PaxCode", SqlDbType.NVarChar);
Sqlparam.Value = objTourPaxPackageDO.PaxCode;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objTourPaxPackageDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourPaxPackageDO objTourPaxPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPaxPackage_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@PaxPackageID", SqlDbType.Int);
Sqlparam.Value = objTourPaxPackageDO.PaxPackageID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PaxCode", SqlDbType.NVarChar);
Sqlparam.Value = objTourPaxPackageDO.PaxCode;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objTourPaxPackageDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourPaxPackageDO objTourPaxPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPaxPackage_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@PaxPackageID", SqlDbType.Int);
Sqlparam.Value = objTourPaxPackageDO.PaxPackageID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPaxPackage_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourPaxPackageDO Select(TourPaxPackageDO objTourPaxPackageDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPaxPackage_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@PaxPackageID", SqlDbType.Int);
Sqlparam.Value = objTourPaxPackageDO.PaxPackageID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["PaxPackageID"]))
objTourPaxPackageDO.PaxPackageID=Convert.ToInt32(dr["PaxPackageID"]);
if(!Convert.IsDBNull(dr["PaxCode"]))
objTourPaxPackageDO.PaxCode=Convert.ToString(dr["PaxCode"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objTourPaxPackageDO.OrderID=Convert.ToInt32(dr["OrderID"]);

            }
             return objTourPaxPackageDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPaxPackage_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourPaxPackageDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourPaxPackageDO objTourPaxPackageDO= new TourPaxPackageDO();
if(!Convert.IsDBNull(dr["PaxPackageID"]))
objTourPaxPackageDO.PaxPackageID=Convert.ToInt32(dr["PaxPackageID"]);
if(!Convert.IsDBNull(dr["PaxCode"]))
objTourPaxPackageDO.PaxCode=Convert.ToString(dr["PaxCode"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objTourPaxPackageDO.OrderID=Convert.ToInt32(dr["OrderID"]);
arrTourPaxPackageDO.Add(objTourPaxPackageDO);
}
            }
               return arrTourPaxPackageDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourPaxPackage_GetAll";
            
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
