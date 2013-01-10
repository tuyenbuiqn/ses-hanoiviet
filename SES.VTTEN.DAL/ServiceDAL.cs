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
/// Summary description for ServiceDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class ServiceDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public ServiceDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(ServiceDO objServiceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spService_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objServiceDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objServiceDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objServiceDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objServiceDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ServiceImage", SqlDbType.NVarChar);
Sqlparam.Value = objServiceDO.ServiceImage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objServiceDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objServiceDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objServiceDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objServiceDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objServiceDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ServiceDO objServiceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spService_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ServiceID", SqlDbType.Int);
Sqlparam.Value = objServiceDO.ServiceID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objServiceDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objServiceDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objServiceDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objServiceDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ServiceImage", SqlDbType.NVarChar);
Sqlparam.Value = objServiceDO.ServiceImage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objServiceDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objServiceDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objServiceDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objServiceDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objServiceDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(ServiceDO objServiceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spService_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ServiceID", SqlDbType.Int);
Sqlparam.Value = objServiceDO.ServiceID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spService_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ServiceDO Select(ServiceDO objServiceDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spService_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ServiceID", SqlDbType.Int);
Sqlparam.Value = objServiceDO.ServiceID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ServiceID"]))
objServiceDO.ServiceID=Convert.ToInt32(dr["ServiceID"]);
if(!Convert.IsDBNull(dr["Title"]))
    objServiceDO.Title = Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objServiceDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objServiceDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Detail"]))
objServiceDO.Detail=Convert.ToString(dr["Detail"]);
if(!Convert.IsDBNull(dr["ServiceImage"]))
objServiceDO.ServiceImage=Convert.ToString(dr["ServiceImage"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objServiceDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objServiceDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objServiceDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objServiceDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objServiceDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);

            }
             return objServiceDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spService_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrServiceDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
ServiceDO objServiceDO= new ServiceDO();
if(!Convert.IsDBNull(dr["ServiceID"]))
objServiceDO.ServiceID=Convert.ToInt32(dr["ServiceID"]);
if(!Convert.IsDBNull(dr["Title"]))
    objServiceDO.Title = Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objServiceDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objServiceDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Detail"]))
objServiceDO.Detail=Convert.ToString(dr["Detail"]);
if(!Convert.IsDBNull(dr["ServiceImage"]))
objServiceDO.ServiceImage=Convert.ToString(dr["ServiceImage"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objServiceDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objServiceDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objServiceDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objServiceDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objServiceDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
arrServiceDO.Add(objServiceDO);
}
            }
               return arrServiceDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spService_GetAll";
            
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
