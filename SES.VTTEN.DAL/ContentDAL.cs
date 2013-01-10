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
/// Summary description for ContentDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class ContentDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public ContentDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(ContentDO objContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContent_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objContentDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objContentDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objContentDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ContentDetail", SqlDbType.NText);
Sqlparam.Value = objContentDO.ContentDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ContentTypeID", SqlDbType.Int);
Sqlparam.Value = objContentDO.ContentTypeID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objContentDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objContentDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objContentDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objContentDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objContentDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
Sqlparam.Value = objContentDO.IsFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@ContentImage", SqlDbType.NVarChar);
Sqlparam.Value = objContentDO.ContentImage;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ContentDO objContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContent_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ContentID", SqlDbType.Int);
Sqlparam.Value = objContentDO.ContentID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objContentDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objContentDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objContentDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ContentDetail", SqlDbType.NText);
Sqlparam.Value = objContentDO.ContentDetail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ContentTypeID", SqlDbType.Int);
Sqlparam.Value = objContentDO.ContentTypeID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objContentDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objContentDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objContentDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objContentDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objContentDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
Sqlparam.Value = objContentDO.IsFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@ContentImage", SqlDbType.NVarChar);
Sqlparam.Value = objContentDO.ContentImage;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(ContentDO objContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContent_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ContentID", SqlDbType.Int);
Sqlparam.Value = objContentDO.ContentID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContent_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ContentDO Select(ContentDO objContentDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContent_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ContentID", SqlDbType.Int);
Sqlparam.Value = objContentDO.ContentID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ContentID"]))
objContentDO.ContentID=Convert.ToInt32(dr["ContentID"]);
if(!Convert.IsDBNull(dr["Title"]))
objContentDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objContentDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objContentDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ContentDetail"]))
objContentDO.ContentDetail=Convert.ToString(dr["ContentDetail"]);
if(!Convert.IsDBNull(dr["ContentTypeID"]))
objContentDO.ContentTypeID=Convert.ToInt32(dr["ContentTypeID"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objContentDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objContentDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objContentDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objContentDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objContentDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if (!Convert.IsDBNull(dr["IsFrontPage"]))
    objContentDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
if (!Convert.IsDBNull(dr["ContentImage"]))
    objContentDO.ContentImage = Convert.ToString(dr["ContentImage"]);

            }
             return objContentDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContent_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrContentDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
ContentDO objContentDO= new ContentDO();
if(!Convert.IsDBNull(dr["ContentID"]))
objContentDO.ContentID=Convert.ToInt32(dr["ContentID"]);
if(!Convert.IsDBNull(dr["Title"]))
objContentDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objContentDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objContentDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["ContentDetail"]))
objContentDO.ContentDetail=Convert.ToString(dr["ContentDetail"]);
if(!Convert.IsDBNull(dr["ContentTypeID"]))
objContentDO.ContentTypeID=Convert.ToInt32(dr["ContentTypeID"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objContentDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objContentDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objContentDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objContentDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objContentDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if (!Convert.IsDBNull(dr["IsFrontPage"]))
    objContentDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
if (!Convert.IsDBNull(dr["ContentImage"]))
    objContentDO.ContentImage = Convert.ToString(dr["ContentImage"]);
arrContentDO.Add(objContentDO);
}
            }
               return arrContentDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContent_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectNumberType(int number, int type)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spContent_GetbyNumberType";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ContentTypeID", SqlDbType.Int);
            Sqlparam.Value = type;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@RecordNumber", SqlDbType.Int);
            Sqlparam.Value = number;
            Sqlcomm.Parameters.Add(Sqlparam);


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
