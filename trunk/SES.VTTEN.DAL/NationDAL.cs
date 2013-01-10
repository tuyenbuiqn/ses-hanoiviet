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
/// Summary description for NationDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class NationDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public NationDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(NationDO objNationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNation_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@NationName", SqlDbType.NVarChar);
Sqlparam.Value = objNationDO.NationName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(NationDO objNationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNation_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@NationID", SqlDbType.Int);
Sqlparam.Value = objNationDO.NationID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@NationName", SqlDbType.NVarChar);
Sqlparam.Value = objNationDO.NationName;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(NationDO objNationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNation_DeleteByPK";
            SqlParameter Sqlparam;
            Sqlparam = new SqlParameter("@NationID", SqlDbType.Int);
            Sqlparam.Value = objNationDO.NationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNation_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public NationDO Select(NationDO objNationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNation_GetByPK";
            SqlParameter Sqlparam;
            Sqlparam = new SqlParameter("@NationID", SqlDbType.Int);
            Sqlparam.Value = objNationDO.NationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["NationID"]))
objNationDO.NationID=Convert.ToInt32(dr["NationID"]);
if(!Convert.IsDBNull(dr["NationName"]))
objNationDO.NationName=Convert.ToString(dr["NationName"]);

            }
             return objNationDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNation_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrNationDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
NationDO objNationDO= new NationDO();
if(!Convert.IsDBNull(dr["NationID"]))
objNationDO.NationID=Convert.ToInt32(dr["NationID"]);
if(!Convert.IsDBNull(dr["NationName"]))
objNationDO.NationName=Convert.ToString(dr["NationName"]);
arrNationDO.Add(objNationDO);
}
            }
               return arrNationDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spNation_GetAll";
            
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
