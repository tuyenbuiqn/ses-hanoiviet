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
/// Summary description for ChatContentDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class ChatContentDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public ChatContentDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(ChatContentDO objChatContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spChatContent_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
Sqlparam.Value = objChatContentDO.UserID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeStart", SqlDbType.DateTime);
Sqlparam.Value = objChatContentDO.TimeStart;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeEnd", SqlDbType.DateTime);
Sqlparam.Value = objChatContentDO.TimeEnd;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
Sqlparam.Value = objChatContentDO.CustomerName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChatContent", SqlDbType.NText);
Sqlparam.Value = objChatContentDO.ChatContent;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ChatContentDO objChatContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spChatContent_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ChatContentID", SqlDbType.Int);
Sqlparam.Value = objChatContentDO.ChatContentID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
Sqlparam.Value = objChatContentDO.UserID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeStart", SqlDbType.DateTime);
Sqlparam.Value = objChatContentDO.TimeStart;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeEnd", SqlDbType.DateTime);
Sqlparam.Value = objChatContentDO.TimeEnd;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
Sqlparam.Value = objChatContentDO.CustomerName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChatContent", SqlDbType.NText);
Sqlparam.Value = objChatContentDO.ChatContent;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(ChatContentDO objChatContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spChatContent_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ChatContentID", SqlDbType.Int);
Sqlparam.Value = objChatContentDO.ChatContentID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spChatContent_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ChatContentDO Select(ChatContentDO objChatContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spChatContent_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ChatContentID", SqlDbType.Int);
Sqlparam.Value = objChatContentDO.ChatContentID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ChatContentID"]))
objChatContentDO.ChatContentID=Convert.ToInt32(dr["ChatContentID"]);
if(!Convert.IsDBNull(dr["UserID"]))
objChatContentDO.UserID=Convert.ToInt32(dr["UserID"]);
if(!Convert.IsDBNull(dr["TimeStart"]))
objChatContentDO.TimeStart=Convert.ToDateTime(dr["TimeStart"]);
if(!Convert.IsDBNull(dr["TimeEnd"]))
objChatContentDO.TimeEnd=Convert.ToDateTime(dr["TimeEnd"]);
if(!Convert.IsDBNull(dr["CustomerName"]))
objChatContentDO.CustomerName=Convert.ToString(dr["CustomerName"]);
if(!Convert.IsDBNull(dr["ChatContent"]))
objChatContentDO.ChatContent=Convert.ToString(dr["ChatContent"]);

            }
             return objChatContentDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spChatContent_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrChatContentDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
ChatContentDO objChatContentDO= new ChatContentDO();
if(!Convert.IsDBNull(dr["ChatContentID"]))
objChatContentDO.ChatContentID=Convert.ToInt32(dr["ChatContentID"]);
if(!Convert.IsDBNull(dr["UserID"]))
objChatContentDO.UserID=Convert.ToInt32(dr["UserID"]);
if(!Convert.IsDBNull(dr["TimeStart"]))
objChatContentDO.TimeStart=Convert.ToDateTime(dr["TimeStart"]);
if(!Convert.IsDBNull(dr["TimeEnd"]))
objChatContentDO.TimeEnd=Convert.ToDateTime(dr["TimeEnd"]);
if(!Convert.IsDBNull(dr["CustomerName"]))
objChatContentDO.CustomerName=Convert.ToString(dr["CustomerName"]);
if(!Convert.IsDBNull(dr["ChatContent"]))
objChatContentDO.ChatContent=Convert.ToString(dr["ChatContent"]);
arrChatContentDO.Add(objChatContentDO);
}
            }
               return arrChatContentDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spChatContent_GetAll";
            
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
