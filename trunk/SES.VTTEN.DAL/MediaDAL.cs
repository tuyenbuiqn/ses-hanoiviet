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
/// Summary description for MediaDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class MediaDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public MediaDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(MediaDO objMediaDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spMedia_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@MediaType", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.MediaType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MediaFile", SqlDbType.NVarChar);
Sqlparam.Value = objMediaDO.MediaFile;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objMediaDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objMediaDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateUpload", SqlDbType.DateTime);
Sqlparam.Value = objMediaDO.DateUpload;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MediaUrl", SqlDbType.NVarChar);
Sqlparam.Value = objMediaDO.MediaUrl;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objMediaDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.HotelID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isRight", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.isRight;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isLeft", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.isLeft;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isFooter", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.isFooter;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.AlbumID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(MediaDO objMediaDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spMedia_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@MediaID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.MediaID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MediaType", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.MediaType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MediaFile", SqlDbType.NVarChar);
Sqlparam.Value = objMediaDO.MediaFile;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objMediaDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objMediaDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateUpload", SqlDbType.DateTime);
Sqlparam.Value = objMediaDO.DateUpload;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MediaUrl", SqlDbType.NVarChar);
Sqlparam.Value = objMediaDO.MediaUrl;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.OrderID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
Sqlparam.Value = objMediaDO.MetaTag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.HotelID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isRight", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.isRight;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isLeft", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.isLeft;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@isFooter", SqlDbType.Bit);
Sqlparam.Value = objMediaDO.isFooter;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.AlbumID;
Sqlcomm.Parameters.Add(Sqlparam);

            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(MediaDO objMediaDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spMedia_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@MediaID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.MediaID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spMedia_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public MediaDO Select(MediaDO objMediaDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spMedia_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@MediaID", SqlDbType.Int);
Sqlparam.Value = objMediaDO.MediaID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["MediaID"]))
objMediaDO.MediaID=Convert.ToInt32(dr["MediaID"]);
if(!Convert.IsDBNull(dr["MediaType"]))
objMediaDO.MediaType=Convert.ToBoolean(dr["MediaType"]);
if(!Convert.IsDBNull(dr["MediaFile"]))
objMediaDO.MediaFile=Convert.ToString(dr["MediaFile"]);
if(!Convert.IsDBNull(dr["Description"]))
objMediaDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Title"]))
objMediaDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["DateUpload"]))
objMediaDO.DateUpload=Convert.ToDateTime(dr["DateUpload"]);
if(!Convert.IsDBNull(dr["MediaUrl"]))
objMediaDO.MediaUrl=Convert.ToString(dr["MediaUrl"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objMediaDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objMediaDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objMediaDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["HotelID"]))
objMediaDO.HotelID=Convert.ToInt32(dr["HotelID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objMediaDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["DestinationID"]))
objMediaDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);
if (!Convert.IsDBNull(dr["isRight"]))
    objMediaDO.isRight = Convert.ToBoolean(dr["isRight"]);
if (!Convert.IsDBNull(dr["isLeft"]))
    objMediaDO.isLeft = Convert.ToBoolean(dr["isLeft"]);
if (!Convert.IsDBNull(dr["isFooter"]))
    objMediaDO.isFooter = Convert.ToBoolean(dr["isFooter"]);
if (!Convert.IsDBNull(dr["AlbumID"]))
    objMediaDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);

            }
             return objMediaDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spMedia_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrMediaDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
MediaDO objMediaDO= new MediaDO();
if(!Convert.IsDBNull(dr["MediaID"]))
objMediaDO.MediaID=Convert.ToInt32(dr["MediaID"]);
if(!Convert.IsDBNull(dr["MediaType"]))
objMediaDO.MediaType=Convert.ToBoolean(dr["MediaType"]);
if(!Convert.IsDBNull(dr["MediaFile"]))
objMediaDO.MediaFile=Convert.ToString(dr["MediaFile"]);
if(!Convert.IsDBNull(dr["Description"]))
objMediaDO.Description=Convert.ToString(dr["Description"]);
if(!Convert.IsDBNull(dr["Title"]))
objMediaDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["DateUpload"]))
objMediaDO.DateUpload=Convert.ToDateTime(dr["DateUpload"]);
if(!Convert.IsDBNull(dr["MediaUrl"]))
objMediaDO.MediaUrl=Convert.ToString(dr["MediaUrl"]);
if(!Convert.IsDBNull(dr["OrderID"]))
objMediaDO.OrderID=Convert.ToInt32(dr["OrderID"]);
if(!Convert.IsDBNull(dr["Published"]))
objMediaDO.Published=Convert.ToBoolean(dr["Published"]);
if(!Convert.IsDBNull(dr["MetaTag"]))
objMediaDO.MetaTag=Convert.ToString(dr["MetaTag"]);
if(!Convert.IsDBNull(dr["HotelID"]))
objMediaDO.HotelID=Convert.ToInt32(dr["HotelID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objMediaDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["DestinationID"]))
objMediaDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);
if (!Convert.IsDBNull(dr["isRight"]))
    objMediaDO.isRight = Convert.ToBoolean(dr["isRight"]);
if (!Convert.IsDBNull(dr["isLeft"]))
    objMediaDO.isLeft = Convert.ToBoolean(dr["isLeft"]);
if (!Convert.IsDBNull(dr["isFooter"]))
    objMediaDO.isFooter = Convert.ToBoolean(dr["isFooter"]);
if (!Convert.IsDBNull(dr["AlbumID"]))
    objMediaDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);
arrMediaDO.Add(objMediaDO);
}
            }
               return arrMediaDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spMedia_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectbyDestination(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetbyDestination";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
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
        public DataTable SelectByTourID(int tourID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetByTour";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = tourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectFooter()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetFooter";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectRight()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetRight";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectLeft()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetLeft";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectByObject(string Object, int ID,int Record)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetbyObject";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Object", SqlDbType.NVarChar);
            Sqlparam.Value = Object;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = ID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Record", SqlDbType.Int);
            Sqlparam.Value = Record;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectbyType()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetImage";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public bool SelectbyAlbum(int AlbumID, int MediaID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetByAlbum";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@MediaID", SqlDbType.Int);
            Sqlparam.Value = MediaID;
            Sqlcomm.Parameters.Add(Sqlparam);
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public DataTable SelectAlbum(int ID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spMedia_GetAlbum";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = ID;
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
