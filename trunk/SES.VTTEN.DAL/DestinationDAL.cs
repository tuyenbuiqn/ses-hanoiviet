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
/// Summary description for DestinationDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class DestinationDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public DestinationDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(DestinationDO objDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spDestination_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objDestinationDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objDestinationDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationImage", SqlDbType.NVarChar);
Sqlparam.Value = objDestinationDO.DestinationImage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeToGo", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.TimeToGo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationMap", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.DestinationMap;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.ParentID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objDestinationDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
Sqlparam.Value = objDestinationDO.IsFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Regions", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.Regions;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);


           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(DestinationDO objDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spDestination_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objDestinationDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objDestinationDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationImage", SqlDbType.NVarChar);
Sqlparam.Value = objDestinationDO.DestinationImage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TimeToGo", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.TimeToGo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationMap", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.DestinationMap;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.ParentID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
Sqlparam.Value = objDestinationDO.MetaDes;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objDestinationDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.ModuleID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
Sqlparam.Value = objDestinationDO.IsFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Regions", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.Regions;
Sqlcomm.Parameters.Add(Sqlparam);



            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(DestinationDO objDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spDestination_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spDestination_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public DestinationDO Select(DestinationDO objDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spDestination_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objDestinationDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["DestinationID"]))
objDestinationDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);
if(!Convert.IsDBNull(dr["Title"]))
objDestinationDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objDestinationDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objDestinationDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Detail"]))
objDestinationDO.Detail=Convert.ToString(dr["Detail"]);
if(!Convert.IsDBNull(dr["DestinationImage"]))
objDestinationDO.DestinationImage=Convert.ToString(dr["DestinationImage"]);
if(!Convert.IsDBNull(dr["TimeToGo"]))
objDestinationDO.TimeToGo=Convert.ToString(dr["TimeToGo"]);
if(!Convert.IsDBNull(dr["DestinationMap"]))
objDestinationDO.DestinationMap=Convert.ToString(dr["DestinationMap"]);
if(!Convert.IsDBNull(dr["ParentID"]))
objDestinationDO.ParentID=Convert.ToInt32(dr["ParentID"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objDestinationDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objDestinationDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objDestinationDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objDestinationDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objDestinationDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if (!Convert.IsDBNull(dr["IsFrontPage"]))
    objDestinationDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
if (!Convert.IsDBNull(dr["Regions"]))
    objDestinationDO.Regions = Convert.ToInt32(dr["Regions"]);

            }
             return objDestinationDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spDestination_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrDestinationDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
DestinationDO objDestinationDO= new DestinationDO();
if(!Convert.IsDBNull(dr["DestinationID"]))
objDestinationDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);
if(!Convert.IsDBNull(dr["Title"]))
objDestinationDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Alias"]))
objDestinationDO.Alias=Convert.ToString(dr["Alias"]);
if(!Convert.IsDBNull(dr["Description"]))
objDestinationDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Detail"]))
objDestinationDO.Detail=Convert.ToString(dr["Detail"]);
if(!Convert.IsDBNull(dr["DestinationImage"]))
objDestinationDO.DestinationImage=Convert.ToString(dr["DestinationImage"]);
if(!Convert.IsDBNull(dr["TimeToGo"]))
objDestinationDO.TimeToGo=Convert.ToString(dr["TimeToGo"]);
if(!Convert.IsDBNull(dr["DestinationMap"]))
objDestinationDO.DestinationMap=Convert.ToString(dr["DestinationMap"]);
if(!Convert.IsDBNull(dr["ParentID"]))
objDestinationDO.ParentID=Convert.ToInt32(dr["ParentID"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objDestinationDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["MetaDes"]))
objDestinationDO.MetaDes=Convert.ToString(dr["MetaDes"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objDestinationDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objDestinationDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["ModuleID"]))
objDestinationDO.ModuleID=Convert.ToInt32(dr["ModuleID"]);
if (!Convert.IsDBNull(dr["IsFrontPage"]))
    objDestinationDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
if (!Convert.IsDBNull(dr["Regions"]))
    objDestinationDO.Regions = Convert.ToInt32(dr["Regions"]);
arrDestinationDO.Add(objDestinationDO);
}
            }
               return arrDestinationDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spDestination_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DestinationDO Selectby(int id, int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetByFK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = id;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DestinationDO objDestinationDO = new DestinationDO();
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["DestinationID"]))
                    objDestinationDO.DestinationID = Convert.ToInt32(dr["DestinationID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objDestinationDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objDestinationDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objDestinationDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["Detail"]))
                    objDestinationDO.Detail = Convert.ToString(dr["Detail"]);
                if (!Convert.IsDBNull(dr["DestinationImage"]))
                    objDestinationDO.DestinationImage = Convert.ToString(dr["DestinationImage"]);
                if (!Convert.IsDBNull(dr["TimeToGo"]))
                    objDestinationDO.TimeToGo = Convert.ToString(dr["TimeToGo"]);
                if (!Convert.IsDBNull(dr["DestinationMap"]))
                    objDestinationDO.DestinationMap = Convert.ToString(dr["DestinationMap"]);
                if (!Convert.IsDBNull(dr["ParentID"]))
                    objDestinationDO.ParentID = Convert.ToInt32(dr["ParentID"]);
                if (!Convert.IsDBNull(dr["MetaTag"]))
                    objDestinationDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                if (!Convert.IsDBNull(dr["MetaDes"]))
                    objDestinationDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objDestinationDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["Published"]))
                    objDestinationDO.Published = Convert.ToBoolean(dr["Published"]);
                if (!Convert.IsDBNull(dr["ModuleID"]))
                    objDestinationDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                if (!Convert.IsDBNull(dr["IsFrontPage"]))
                    objDestinationDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);

            }
            return objDestinationDO;
        }

        public DataTable SelectByParentID(int ParentID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetByParentID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
            Sqlparam.Value = ParentID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataTable SelectByRegions(int Regions)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetByRegions";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@Regions", SqlDbType.Int);
            Sqlparam.Value = @Regions;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }



        public DataTable SelectTop()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetTop";
            

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectRoot()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetRoot";


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectTop1()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetTop1";


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectByParentIDNoZero()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetByParentIDNoZero";
            

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectHome(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetByHome";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@RecordNum", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectHotelCat()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spDestination_GetHotelCat";
            
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
