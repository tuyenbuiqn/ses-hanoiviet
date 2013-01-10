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
/// Summary description for CustomerReviewDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class CustomerReviewDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public CustomerReviewDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(CustomerReviewDO objCustomerReviewDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objCustomerReviewDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
            Sqlparam.Value = objCustomerReviewDO.Detail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ReviewImg", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.ReviewImg;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TripAdvisor", SqlDbType.Bit);
            Sqlparam.Value = objCustomerReviewDO.TripAdvisor;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objCustomerReviewDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TripAdvisorLink", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.TripAdvisorLink;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(CustomerReviewDO objCustomerReviewDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomerReviewID", SqlDbType.Int);
            Sqlparam.Value = objCustomerReviewDO.CustomerReviewID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objCustomerReviewDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
            Sqlparam.Value = objCustomerReviewDO.Detail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ReviewImg", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.ReviewImg;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TripAdvisor", SqlDbType.Bit);
            Sqlparam.Value = objCustomerReviewDO.TripAdvisor;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objCustomerReviewDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TripAdvisorLink", SqlDbType.NVarChar);
            Sqlparam.Value = objCustomerReviewDO.TripAdvisorLink;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(CustomerReviewDO objCustomerReviewDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CustomerReviewID", SqlDbType.Int);
            Sqlparam.Value = objCustomerReviewDO.CustomerReviewID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public CustomerReviewDO Select(CustomerReviewDO objCustomerReviewDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CustomerReviewID", SqlDbType.Int);
            Sqlparam.Value = objCustomerReviewDO.CustomerReviewID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["CustomerReviewID"]))
                    objCustomerReviewDO.CustomerReviewID = Convert.ToInt32(dr["CustomerReviewID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objCustomerReviewDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objCustomerReviewDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["Detail"]))
                    objCustomerReviewDO.Detail = Convert.ToString(dr["Detail"]);
                if (!Convert.IsDBNull(dr["ReviewImg"]))
                    objCustomerReviewDO.ReviewImg = Convert.ToString(dr["ReviewImg"]);
                if (!Convert.IsDBNull(dr["TripAdvisor"]))
                    objCustomerReviewDO.TripAdvisor = Convert.ToBoolean(dr["TripAdvisor"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objCustomerReviewDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["IsFrontPage"]))
                    objCustomerReviewDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
                if (!Convert.IsDBNull(dr["TripAdvisorLink"]))
                    objCustomerReviewDO.TripAdvisorLink = Convert.ToString(dr["TripAdvisorLink"]);

            }
            return objCustomerReviewDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrCustomerReviewDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    CustomerReviewDO objCustomerReviewDO = new CustomerReviewDO();
                    if (!Convert.IsDBNull(dr["CustomerReviewID"]))
                        objCustomerReviewDO.CustomerReviewID = Convert.ToInt32(dr["CustomerReviewID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objCustomerReviewDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objCustomerReviewDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["Detail"]))
                        objCustomerReviewDO.Detail = Convert.ToString(dr["Detail"]);
                    if (!Convert.IsDBNull(dr["ReviewImg"]))
                        objCustomerReviewDO.ReviewImg = Convert.ToString(dr["ReviewImg"]);
                    if (!Convert.IsDBNull(dr["TripAdvisor"]))
                        objCustomerReviewDO.TripAdvisor = Convert.ToBoolean(dr["TripAdvisor"]);
                    if (!Convert.IsDBNull(dr["Alias"]))
                        objCustomerReviewDO.Alias = Convert.ToString(dr["Alias"]);
                    if (!Convert.IsDBNull(dr["IsFrontPage"]))
                        objCustomerReviewDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
                    if (!Convert.IsDBNull(dr["TripAdvisorLink"]))
                        objCustomerReviewDO.TripAdvisorLink = Convert.ToString(dr["TripAdvisorLink"]);
                    arrCustomerReviewDO.Add(objCustomerReviewDO);
                }
            }
            return arrCustomerReviewDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        #endregion


        public DataTable SelectHome(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomerReview_GetHome";
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
    }

}
