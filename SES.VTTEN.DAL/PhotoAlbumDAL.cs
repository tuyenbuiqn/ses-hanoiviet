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
/// Summary description for PhotoAlbumDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class PhotoAlbumDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public PhotoAlbumDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(PhotoAlbumDO objPhotoAlbumDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spPhotoAlbum_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objPhotoAlbumDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AlbumCover", SqlDbType.Int);
Sqlparam.Value = objPhotoAlbumDO.AlbumCover;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objPhotoAlbumDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objPhotoAlbumDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(PhotoAlbumDO objPhotoAlbumDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spPhotoAlbum_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
Sqlparam.Value = objPhotoAlbumDO.AlbumID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objPhotoAlbumDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
Sqlparam.Value = objPhotoAlbumDO.Alias;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@AlbumCover", SqlDbType.Int);
Sqlparam.Value = objPhotoAlbumDO.AlbumCover;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objPhotoAlbumDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(PhotoAlbumDO objPhotoAlbumDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spPhotoAlbum_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
Sqlparam.Value = objPhotoAlbumDO.AlbumID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spPhotoAlbum_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public PhotoAlbumDO Select(PhotoAlbumDO objPhotoAlbumDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spPhotoAlbum_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
Sqlparam.Value = objPhotoAlbumDO.AlbumID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["AlbumID"]))
objPhotoAlbumDO.AlbumID=Convert.ToInt32(dr["AlbumID"]);
if(!Convert.IsDBNull(dr["Title"]))
objPhotoAlbumDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["AlbumCover"]))
objPhotoAlbumDO.AlbumCover=Convert.ToInt32(dr["AlbumCover"]);
if(!Convert.IsDBNull(dr["Published"]))
objPhotoAlbumDO.Published=Convert.ToBoolean(dr["Published"]);
if (!Convert.IsDBNull(dr["Alias"]))
    objPhotoAlbumDO.Alias = Convert.ToString(dr["Alias"]);

            }
             return objPhotoAlbumDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spPhotoAlbum_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrPhotoAlbumDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
PhotoAlbumDO objPhotoAlbumDO= new PhotoAlbumDO();
if(!Convert.IsDBNull(dr["AlbumID"]))
objPhotoAlbumDO.AlbumID=Convert.ToInt32(dr["AlbumID"]);
if(!Convert.IsDBNull(dr["Title"]))
objPhotoAlbumDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["AlbumCover"]))
objPhotoAlbumDO.AlbumCover=Convert.ToInt32(dr["AlbumCover"]);
if(!Convert.IsDBNull(dr["Published"]))
objPhotoAlbumDO.Published=Convert.ToBoolean(dr["Published"]);
if (!Convert.IsDBNull(dr["Alias"]))
    objPhotoAlbumDO.Alias = Convert.ToString(dr["Alias"]);
arrPhotoAlbumDO.Add(objPhotoAlbumDO);
}
            }
               return arrPhotoAlbumDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spPhotoAlbum_GetAll";
            
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
