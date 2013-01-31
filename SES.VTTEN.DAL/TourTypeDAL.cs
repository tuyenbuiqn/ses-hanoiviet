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
/// Summary description for TourTypeDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class TourTypeDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public TourTypeDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(TourTypeDO objTourTypeDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objTourTypeDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objTourTypeDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objTourTypeDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objTourTypeDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
            Sqlparam.Value = objTourTypeDO.ParentID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objTourTypeDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsHomepage", SqlDbType.Bit);
            Sqlparam.Value = objTourTypeDO.IsHomepage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsInboundTour", SqlDbType.Bit);
            Sqlparam.Value = objTourTypeDO.IsInboundTour;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourTypeDO objTourTypeDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
            Sqlparam.Value = objTourTypeDO.TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objTourTypeDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objTourTypeDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objTourTypeDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objTourTypeDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
            Sqlparam.Value = objTourTypeDO.ParentID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objTourTypeDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsHomepage", SqlDbType.Bit);
            Sqlparam.Value = objTourTypeDO.IsHomepage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsInboundTour", SqlDbType.Bit);
            Sqlparam.Value = objTourTypeDO.IsInboundTour;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(TourTypeDO objTourTypeDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
            Sqlparam.Value = objTourTypeDO.TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourTypeDO Select(TourTypeDO objTourTypeDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
            Sqlparam.Value = objTourTypeDO.TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["TourTypeID"]))
                    objTourTypeDO.TourTypeID = Convert.ToInt32(dr["TourTypeID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objTourTypeDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objTourTypeDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objTourTypeDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["Published"]))
                    objTourTypeDO.Published = Convert.ToBoolean(dr["Published"]);
                if (!Convert.IsDBNull(dr["ParentID"]))
                    objTourTypeDO.ParentID = Convert.ToInt32(dr["ParentID"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objTourTypeDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["IsHomepage"]))
                    objTourTypeDO.IsHomepage = Convert.ToBoolean(dr["IsHomepage"]);
                if (!Convert.IsDBNull(dr["IsInboundTour"]))
                    objTourTypeDO.IsInboundTour = Convert.ToBoolean(dr["IsInboundTour"]);

            }
            return objTourTypeDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourTypeDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    TourTypeDO objTourTypeDO = new TourTypeDO();
                    if (!Convert.IsDBNull(dr["TourTypeID"]))
                        objTourTypeDO.TourTypeID = Convert.ToInt32(dr["TourTypeID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objTourTypeDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objTourTypeDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["Alias"]))
                        objTourTypeDO.Alias = Convert.ToString(dr["Alias"]);
                    if (!Convert.IsDBNull(dr["Published"]))
                        objTourTypeDO.Published = Convert.ToBoolean(dr["Published"]);
                    if (!Convert.IsDBNull(dr["ParentID"]))
                        objTourTypeDO.ParentID = Convert.ToInt32(dr["ParentID"]);
                    if (!Convert.IsDBNull(dr["OrderID"]))
                        objTourTypeDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                    if (!Convert.IsDBNull(dr["IsHomepage"]))
                        objTourTypeDO.IsHomepage = Convert.ToBoolean(dr["IsHomepage"]);
                    if (!Convert.IsDBNull(dr["IsInboundTour"]))
                        objTourTypeDO.IsInboundTour = Convert.ToBoolean(dr["IsInboundTour"]);
                    arrTourTypeDO.Add(objTourTypeDO);
                }
            }
            return arrTourTypeDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectHomePublish(bool IsHomepage, bool Published)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetByHomePublish";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@IsHomepage", SqlDbType.Bit);
            Sqlparam.Value = IsHomepage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = Published;
            Sqlcomm.Parameters.Add(Sqlparam);


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataTable SelectAllParentHomePublish(bool IsHomepage, bool Published)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetAllParentByHomePublish";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@IsHomepage", SqlDbType.Bit);
            Sqlparam.Value = IsHomepage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = Published;
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


        public TourTypeDO Selectby(int id, int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetByFK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = id;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);

            TourTypeDO objTourTypeDO = new TourTypeDO();
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["TourTypeID"]))
                    objTourTypeDO.TourTypeID = Convert.ToInt32(dr["TourTypeID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objTourTypeDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objTourTypeDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objTourTypeDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["ParentID"]))
                    objTourTypeDO.ParentID = Convert.ToInt32(dr["ParentID"]);

                if (!Convert.IsDBNull(dr["OrderID"]))
                    objTourTypeDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["Published"]))
                    objTourTypeDO.Published = Convert.ToBoolean(dr["Published"]);
                if (!Convert.IsDBNull(dr["IsHomepage"]))
                    objTourTypeDO.IsHomepage = Convert.ToBoolean(dr["IsHomepage"]);
                if (!Convert.IsDBNull(dr["IsInboundTour"]))
                    objTourTypeDO.IsInboundTour = Convert.ToBoolean(dr["IsInboundTour"]);

            }
            return objTourTypeDO;
        }

        public DataTable SelectByTopID(int ParentID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetAllByParentID";
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

        public DataTable SelectByTopIDOnlyChild(int ParentID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetAllByParentIDOnlyChild";
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
        public DataTable SelectByTopIDOnlyChildHomepage(int ParentID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetAllByParentIDOnlyChildHomepage";
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
        public DataTable GetTourCateHomepage(bool isInboundTour)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetHomeTour";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@IsInboundTour", SqlDbType.Bit);
            Sqlparam.Value = isInboundTour;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataTable SelectOne(int ParentID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourType_GetByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
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
    }

}
