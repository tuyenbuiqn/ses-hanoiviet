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
/// Summary description for ModuleDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class ModuleDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public ModuleDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(ModuleDO objModuleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spModule_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objModuleDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleName", SqlDbType.NVarChar);
Sqlparam.Value = objModuleDO.ModuleName;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@VideoID", SqlDbType.Int);
Sqlparam.Value = objModuleDO.VideoID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ModuleDO objModuleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spModule_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objModuleDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleName", SqlDbType.NVarChar);
Sqlparam.Value = objModuleDO.ModuleName;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@VideoID", SqlDbType.Int);
Sqlparam.Value = objModuleDO.VideoID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(ModuleDO objModuleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spModule_DeleteByPK";
            SqlParameter Sqlparam;
            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objModuleDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);

            
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spModule_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ModuleDO Select(ModuleDO objModuleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spModule_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objModuleDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ModuleID"]))
objModuleDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["ModuleName"]))
objModuleDO.ModuleName=Convert.ToString(dr["ModuleName"]);
if (!Convert.IsDBNull(dr["VideoID"]))
    objModuleDO.VideoID = Convert.ToInt32(dr["VideoID"]);

            }
             return objModuleDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spModule_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrModuleDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
ModuleDO objModuleDO= new ModuleDO();
if(!Convert.IsDBNull(dr["ModuleID"]))
objModuleDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["ModuleName"]))
objModuleDO.ModuleName=Convert.ToString(dr["ModuleName"]);
arrModuleDO.Add(objModuleDO);
if (!Convert.IsDBNull(dr["VideoID"]))
    objModuleDO.VideoID = Convert.ToInt32(dr["VideoID"]);
}
            }
               return arrModuleDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spModule_GetAll";
            
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
