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
/// Summary description for SessionChatDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class SessionChatDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public SessionChatDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(SessionChatDO objSessionChatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spSessionChat_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@SessionHash", SqlDbType.NVarChar);
Sqlparam.Value = objSessionChatDO.SessionHash;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
Sqlparam.Value = objSessionChatDO.UserID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(SessionChatDO objSessionChatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spSessionChat_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@SessionID", SqlDbType.Int);
Sqlparam.Value = objSessionChatDO.SessionID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@SessionHash", SqlDbType.NVarChar);
Sqlparam.Value = objSessionChatDO.SessionHash;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
Sqlparam.Value = objSessionChatDO.UserID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(SessionChatDO objSessionChatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spSessionChat_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@SessionID", SqlDbType.Int);
Sqlparam.Value = objSessionChatDO.SessionID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spSessionChat_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public SessionChatDO Select(SessionChatDO objSessionChatDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spSessionChat_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@SessionID", SqlDbType.Int);
Sqlparam.Value = objSessionChatDO.SessionID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["SessionID"]))
objSessionChatDO.SessionID=Convert.ToInt32(dr["SessionID"]);
if(!Convert.IsDBNull(dr["SessionHash"]))
objSessionChatDO.SessionHash=Convert.ToString(dr["SessionHash"]);
if(!Convert.IsDBNull(dr["UserID"]))
objSessionChatDO.UserID=Convert.ToInt32(dr["UserID"]);

            }
             return objSessionChatDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spSessionChat_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrSessionChatDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
SessionChatDO objSessionChatDO= new SessionChatDO();
if(!Convert.IsDBNull(dr["SessionID"]))
objSessionChatDO.SessionID=Convert.ToInt32(dr["SessionID"]);
if(!Convert.IsDBNull(dr["SessionHash"]))
objSessionChatDO.SessionHash=Convert.ToString(dr["SessionHash"]);
if(!Convert.IsDBNull(dr["UserID"]))
objSessionChatDO.UserID=Convert.ToInt32(dr["UserID"]);
arrSessionChatDO.Add(objSessionChatDO);
}
            }
               return arrSessionChatDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spSessionChat_GetAll";
            
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
