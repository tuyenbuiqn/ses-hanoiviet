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
/// Summary description for cmsAlbumDetailDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class cmsAlbumDetailDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public cmsAlbumDetailDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDetailDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDetailDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Url", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDetailDO.Url;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OtherID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.OtherID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AlbumDetailID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.AlbumDetailID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDetailDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDetailDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Url", SqlDbType.NVarChar);
            Sqlparam.Value = objcmsAlbumDetailDO.Url;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OtherID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.OtherID;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumDetailID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.AlbumDetailID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public cmsAlbumDetailDO Select(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@AlbumDetailID", SqlDbType.Int);
            Sqlparam.Value = objcmsAlbumDetailDO.AlbumDetailID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["AlbumDetailID"]))
                    objcmsAlbumDetailDO.AlbumDetailID = Convert.ToInt32(dr["AlbumDetailID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objcmsAlbumDetailDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objcmsAlbumDetailDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["AlbumID"]))
                    objcmsAlbumDetailDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);
                if (!Convert.IsDBNull(dr["Url"]))
                    objcmsAlbumDetailDO.Url = Convert.ToString(dr["Url"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objcmsAlbumDetailDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["OtherID"]))
                    objcmsAlbumDetailDO.OtherID = Convert.ToInt32(dr["OtherID"]);

            }
            return objcmsAlbumDetailDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrcmsAlbumDetailDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    cmsAlbumDetailDO objcmsAlbumDetailDO = new cmsAlbumDetailDO();
                    if (!Convert.IsDBNull(dr["AlbumDetailID"]))
                        objcmsAlbumDetailDO.AlbumDetailID = Convert.ToInt32(dr["AlbumDetailID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objcmsAlbumDetailDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objcmsAlbumDetailDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["AlbumID"]))
                        objcmsAlbumDetailDO.AlbumID = Convert.ToInt32(dr["AlbumID"]);
                    if (!Convert.IsDBNull(dr["Url"]))
                        objcmsAlbumDetailDO.Url = Convert.ToString(dr["Url"]);
                    if (!Convert.IsDBNull(dr["OrderID"]))
                        objcmsAlbumDetailDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                    if (!Convert.IsDBNull(dr["OtherID"]))
                        objcmsAlbumDetailDO.OtherID = Convert.ToInt32(dr["OtherID"]);
                    arrcmsAlbumDetailDO.Add(objcmsAlbumDetailDO);
                }
            }
            return arrcmsAlbumDetailDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataTable SelectByAlbumID(int AlbumID)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_GetByAlbumID";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@AlbumID", SqlDbType.Int);
            Sqlparam.Value = AlbumID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        #endregion


        public DataTable SelectAllByType(int type)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsAlbumDetail_SelectAllByType";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@type", SqlDbType.Int);
            Sqlparam.Value = type;
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
