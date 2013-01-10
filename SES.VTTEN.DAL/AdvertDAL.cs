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
/// Summary description for AdvertDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class AdvertDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public AdvertDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(AdvertDO objAdvertDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spAdvert_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objAdvertDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MediaID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.MediaID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HTMLContent", SqlDbType.NText);
Sqlparam.Value = objAdvertDO.HTMLContent;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objAdvertDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeStart", SqlDbType.DateTime);
Sqlparam.Value = objAdvertDO.TimeStart;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeExpire", SqlDbType.DateTime);
Sqlparam.Value = objAdvertDO.TimeExpire;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isLeft", SqlDbType.Bit);
Sqlparam.Value = objAdvertDO.isLeft;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Location", SqlDbType.NVarChar);
Sqlparam.Value = objAdvertDO.Location;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(AdvertDO objAdvertDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spAdvert_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AdvertID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.AdvertID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objAdvertDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MediaID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.MediaID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HTMLContent", SqlDbType.NText);
Sqlparam.Value = objAdvertDO.HTMLContent;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objAdvertDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeStart", SqlDbType.DateTime);
Sqlparam.Value = objAdvertDO.TimeStart;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeExpire", SqlDbType.DateTime);
Sqlparam.Value = objAdvertDO.TimeExpire;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isLeft", SqlDbType.Bit);
Sqlparam.Value = objAdvertDO.isLeft;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Location", SqlDbType.NVarChar);
Sqlparam.Value = objAdvertDO.Location;
Sqlcomm.Parameters.Add(Sqlparam);

            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(AdvertDO objAdvertDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spAdvert_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AdvertID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.AdvertID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spAdvert_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public AdvertDO Select(AdvertDO objAdvertDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spAdvert_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@AdvertID", SqlDbType.Int);
Sqlparam.Value = objAdvertDO.AdvertID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["AdvertID"]))
objAdvertDO.AdvertID=Convert.ToInt32(dr["AdvertID"]);
if(!Convert.IsDBNull(dr["Title"]))
objAdvertDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["MediaID"]))
objAdvertDO.MediaID=Convert.ToInt32(dr["MediaID"]);
if(!Convert.IsDBNull(dr["HTMLContent"]))
objAdvertDO.HTMLContent=Convert.ToString(dr["HTMLContent"]);
if(!Convert.IsDBNull(dr["Published"]))
objAdvertDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objAdvertDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["TimeStart"]))
objAdvertDO.TimeStart=Convert.ToDateTime(dr["TimeStart"]);
if(!Convert.IsDBNull(dr["TimeExpire"]))
objAdvertDO.TimeExpire=Convert.ToDateTime(dr["TimeExpire"]);
if (!Convert.IsDBNull(dr["OrderID"]))
    objAdvertDO.OrderID = Convert.ToInt32(dr["OrderID"]);
if (!Convert.IsDBNull(dr["isLeft"]))
    objAdvertDO.isLeft = Convert.ToBoolean(dr["isLeft"]);
if (!Convert.IsDBNull(dr["Location"]))
    objAdvertDO.Location = Convert.ToString(dr["Location"]);

            }
             return objAdvertDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spAdvert_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrAdvertDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
AdvertDO objAdvertDO= new AdvertDO();
if(!Convert.IsDBNull(dr["AdvertID"]))
objAdvertDO.AdvertID=Convert.ToInt32(dr["AdvertID"]);
if(!Convert.IsDBNull(dr["Title"]))
objAdvertDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["MediaID"]))
objAdvertDO.MediaID=Convert.ToInt32(dr["MediaID"]);
if(!Convert.IsDBNull(dr["HTMLContent"]))
objAdvertDO.HTMLContent=Convert.ToString(dr["HTMLContent"]);
if(!Convert.IsDBNull(dr["Published"]))
objAdvertDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objAdvertDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["TimeStart"]))
objAdvertDO.TimeStart=Convert.ToDateTime(dr["TimeStart"]);
if(!Convert.IsDBNull(dr["TimeExpire"]))
objAdvertDO.TimeExpire=Convert.ToDateTime(dr["TimeExpire"]);
if (!Convert.IsDBNull(dr["OrderID"]))
    objAdvertDO.OrderID = Convert.ToInt32(dr["OrderID"]);
if (!Convert.IsDBNull(dr["isLeft"]))
    objAdvertDO.isLeft = Convert.ToBoolean(dr["isLeft"]);
if (!Convert.IsDBNull(dr["Location"]))
    objAdvertDO.Location = Convert.ToString(dr["Location"]);
arrAdvertDO.Add(objAdvertDO);
}
            }
               return arrAdvertDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spAdvert_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable Selectleft()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spAdvert_GetLeft";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable Selectright()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spAdvert_GetRight";

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
