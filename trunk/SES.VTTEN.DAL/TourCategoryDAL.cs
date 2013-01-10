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
/// Summary description for TourCategoryDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourCategoryDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourCategoryDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourCategoryDO objTourCategoryDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourCategory_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objTourCategoryDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objTourCategoryDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objTourCategoryDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objTourCategoryDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objTourCategoryDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objTourCategoryDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objTourCategoryDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objTourCategoryDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourCatImage", SqlDbType.NVarChar);
Sqlparam.Value = objTourCategoryDO.TourCatImage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
Sqlparam.Value = objTourCategoryDO.IsFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourCategoryDO objTourCategoryDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourCategory_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourCategoryID", SqlDbType.Int);
Sqlparam.Value = objTourCategoryDO.TourCategoryID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objTourCategoryDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objTourCategoryDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objTourCategoryDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objTourCategoryDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objTourCategoryDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objTourCategoryDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objTourCategoryDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objTourCategoryDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourCatImage", SqlDbType.NVarChar);
Sqlparam.Value = objTourCategoryDO.TourCatImage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
Sqlparam.Value = objTourCategoryDO.IsFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);

            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourCategoryDO objTourCategoryDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourCategory_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourCategoryID", SqlDbType.Int);
Sqlparam.Value = objTourCategoryDO.TourCategoryID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourCategory_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourCategoryDO Select(TourCategoryDO objTourCategoryDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourCategory_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@TourCategoryID", SqlDbType.Int);
Sqlparam.Value = objTourCategoryDO.TourCategoryID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["TourCategoryID"]))
objTourCategoryDO.TourCategoryID=Convert.ToInt32(dr["TourCategoryID"]);
if(!Convert.IsDBNull(dr["Title"]))
objTourCategoryDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objTourCategoryDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objTourCategoryDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objTourCategoryDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objTourCategoryDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objTourCategoryDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objTourCategoryDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objTourCategoryDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["TourCatImage"]))
objTourCategoryDO.TourCatImage=Convert.ToString(dr["TourCatImage"]);
if (!Convert.IsDBNull(dr["ParentID"]))
    objTourCategoryDO.ModuleID = Convert.ToInt32(dr["ParentID"]);
if (!Convert.IsDBNull(dr["IsFrontPage"]))
    objTourCategoryDO.Published = Convert.ToBoolean(dr["IsFrontPage"]);

            }
             return objTourCategoryDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourCategory_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourCategoryDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourCategoryDO objTourCategoryDO= new TourCategoryDO();
if(!Convert.IsDBNull(dr["TourCategoryID"]))
objTourCategoryDO.TourCategoryID=Convert.ToInt32(dr["TourCategoryID"]);
if(!Convert.IsDBNull(dr["Title"]))
objTourCategoryDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objTourCategoryDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objTourCategoryDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objTourCategoryDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objTourCategoryDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objTourCategoryDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objTourCategoryDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objTourCategoryDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if(!Convert.IsDBNull(dr["TourCatImage"]))
objTourCategoryDO.TourCatImage=Convert.ToString(dr["TourCatImage"]);
if (!Convert.IsDBNull(dr["ParentID"]))
    objTourCategoryDO.ModuleID = Convert.ToInt32(dr["ParentID"]);
if (!Convert.IsDBNull(dr["IsFrontPage"]))
    objTourCategoryDO.Published = Convert.ToBoolean(dr["IsFrontPage"]);
arrTourCategoryDO.Add(objTourCategoryDO);
}
            }
               return arrTourCategoryDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourCategory_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectbyNumber()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourCategory_GetbyNumber";

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
