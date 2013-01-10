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
/// Summary description for ConfigDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class ConfigDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public ConfigDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(ConfigDO objConfigDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spConfig_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ConfigCode", SqlDbType.NVarChar);
Sqlparam.Value = objConfigDO.ConfigCode;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ConfigValue", SqlDbType.NText);
Sqlparam.Value = objConfigDO.ConfigValue;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ConfigDO objConfigDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spConfig_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ConfigID", SqlDbType.Int);
Sqlparam.Value = objConfigDO.ConfigID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ConfigCode", SqlDbType.NVarChar);
Sqlparam.Value = objConfigDO.ConfigCode;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ConfigValue", SqlDbType.NText);
Sqlparam.Value = objConfigDO.ConfigValue;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(ConfigDO objConfigDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spConfig_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ConfigID", SqlDbType.Int);
Sqlparam.Value = objConfigDO.ConfigID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spConfig_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ConfigDO Select(ConfigDO objConfigDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spConfig_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ConfigID", SqlDbType.Int);
Sqlparam.Value = objConfigDO.ConfigID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ConfigID"]))
objConfigDO.ConfigID=Convert.ToInt32(dr["ConfigID"]);
if(!Convert.IsDBNull(dr["ConfigCode"]))
objConfigDO.ConfigCode=Convert.ToString(dr["ConfigCode"]);
if(!Convert.IsDBNull(dr["ConfigValue"]))
objConfigDO.ConfigValue=Convert.ToString(dr["ConfigValue"]);

            }
             return objConfigDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spConfig_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrConfigDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
ConfigDO objConfigDO= new ConfigDO();
if(!Convert.IsDBNull(dr["ConfigID"]))
objConfigDO.ConfigID=Convert.ToInt32(dr["ConfigID"]);
if(!Convert.IsDBNull(dr["ConfigCode"]))
objConfigDO.ConfigCode=Convert.ToString(dr["ConfigCode"]);
if(!Convert.IsDBNull(dr["ConfigValue"]))
objConfigDO.ConfigValue=Convert.ToString(dr["ConfigValue"]);
arrConfigDO.Add(objConfigDO);
}
            }
               return arrConfigDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spConfig_GetAll";
            
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
