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
/// Summary description for VideoDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class VideoDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public VideoDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(VideoDO objVideoDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spVideo_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objVideoDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Link", SqlDbType.NVarChar);
Sqlparam.Value = objVideoDO.Link;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objVideoDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isFrontPage", SqlDbType.Bit);
Sqlparam.Value = objVideoDO.isFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@OderID", SqlDbType.Int);
Sqlparam.Value = objVideoDO.OderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(VideoDO objVideoDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spVideo_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@VideoID", SqlDbType.Int);
Sqlparam.Value = objVideoDO.VideoID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objVideoDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Link", SqlDbType.NVarChar);
Sqlparam.Value = objVideoDO.Link;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objVideoDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isFrontPage", SqlDbType.Bit);
Sqlparam.Value = objVideoDO.isFrontPage;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@OderID", SqlDbType.Int);
Sqlparam.Value = objVideoDO.OderID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(VideoDO objVideoDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spVideo_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@VideoID", SqlDbType.Int);
Sqlparam.Value = objVideoDO.VideoID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spVideo_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public VideoDO Select(VideoDO objVideoDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spVideo_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@VideoID", SqlDbType.Int);
Sqlparam.Value = objVideoDO.VideoID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["VideoID"]))
objVideoDO.VideoID=Convert.ToInt32(dr["VideoID"]);
if(!Convert.IsDBNull(dr["Title"]))
objVideoDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Link"]))
objVideoDO.Link=Convert.ToString(dr["Link"]);
if(!Convert.IsDBNull(dr["Description"]))
objVideoDO.Description=Convert.ToString(dr["Description"]);
if (!Convert.IsDBNull(dr["isFrontPage"]))
    objVideoDO.isFrontPage = Convert.ToBoolean(dr["isFrontPage"]);
if (!Convert.IsDBNull(dr["OderID"]))
    objVideoDO.OderID = Convert.ToInt32(dr["OderID"]);

            }
             return objVideoDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spVideo_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrVideoDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
VideoDO objVideoDO= new VideoDO();
if(!Convert.IsDBNull(dr["VideoID"]))
objVideoDO.VideoID=Convert.ToInt32(dr["VideoID"]);
if(!Convert.IsDBNull(dr["Title"]))
objVideoDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["Link"]))
objVideoDO.Link=Convert.ToString(dr["Link"]);
if(!Convert.IsDBNull(dr["Description"]))
objVideoDO.Description=Convert.ToString(dr["Description"]);
if (!Convert.IsDBNull(dr["isFrontPage"]))
    objVideoDO.isFrontPage = Convert.ToBoolean(dr["isFrontPage"]);
if (!Convert.IsDBNull(dr["OderID"]))
    objVideoDO.OderID = Convert.ToInt32(dr["OderID"]);
arrVideoDO.Add(objVideoDO);
}
            }
               return arrVideoDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spVideo_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectFirst()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spVideo_GetFirst";
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
            Sqlcomm.CommandText = "spVideo_GetTop";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectbyModule(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spVideo_GetbyModule";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
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
    }

}
