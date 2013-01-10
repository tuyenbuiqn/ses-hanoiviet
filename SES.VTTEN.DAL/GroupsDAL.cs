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
/// Summary description for GroupsDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class GroupsDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public GroupsDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(GroupsDO objGroupsDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spGroups_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@GroupName", SqlDbType.NVarChar);
Sqlparam.Value = objGroupsDO.GroupName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Permission", SqlDbType.NVarChar);
Sqlparam.Value = objGroupsDO.Permission;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Note", SqlDbType.NVarChar);
Sqlparam.Value = objGroupsDO.Note;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(GroupsDO objGroupsDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spGroups_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@GroupID", SqlDbType.Int);
Sqlparam.Value = objGroupsDO.GroupID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@GroupName", SqlDbType.NVarChar);
Sqlparam.Value = objGroupsDO.GroupName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Permission", SqlDbType.NVarChar);
Sqlparam.Value = objGroupsDO.Permission;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Note", SqlDbType.NVarChar);
Sqlparam.Value = objGroupsDO.Note;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(GroupsDO objGroupsDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spGroups_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@GroupID", SqlDbType.Int);
Sqlparam.Value = objGroupsDO.GroupID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spGroups_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public GroupsDO Select(GroupsDO objGroupsDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spGroups_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@GroupID", SqlDbType.Int);
Sqlparam.Value = objGroupsDO.GroupID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["GroupID"]))
objGroupsDO.GroupID=Convert.ToInt32(dr["GroupID"]);
if(!Convert.IsDBNull(dr["GroupName"]))
objGroupsDO.GroupName=Convert.ToString(dr["GroupName"]);
if(!Convert.IsDBNull(dr["Permission"]))
objGroupsDO.Permission=Convert.ToString(dr["Permission"]);
if(!Convert.IsDBNull(dr["Note"]))
objGroupsDO.Note=Convert.ToString(dr["Note"]);

            }
             return objGroupsDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spGroups_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrGroupsDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
GroupsDO objGroupsDO= new GroupsDO();
if(!Convert.IsDBNull(dr["GroupID"]))
objGroupsDO.GroupID=Convert.ToInt32(dr["GroupID"]);
if(!Convert.IsDBNull(dr["GroupName"]))
objGroupsDO.GroupName=Convert.ToString(dr["GroupName"]);
if(!Convert.IsDBNull(dr["Permission"]))
objGroupsDO.Permission=Convert.ToString(dr["Permission"]);
if(!Convert.IsDBNull(dr["Note"]))
objGroupsDO.Note=Convert.ToString(dr["Note"]);
arrGroupsDO.Add(objGroupsDO);
}
            }
               return arrGroupsDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spGroups_GetAll";
            
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
