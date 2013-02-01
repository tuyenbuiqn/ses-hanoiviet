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
/// Summary description for NewsDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class NewsDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public NewsDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(NewsDO objNewsDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objNewsDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objNewsDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.Detail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NewsImage", SqlDbType.NVarChar);
            Sqlparam.Value = objNewsDO.NewsImage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.MetaTag;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.MetaDes;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objNewsDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objNewsDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objNewsDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objNewsDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(NewsDO objNewsDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@NewsID", SqlDbType.Int);
            Sqlparam.Value = objNewsDO.NewsID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objNewsDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objNewsDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.Detail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NewsImage", SqlDbType.NVarChar);
            Sqlparam.Value = objNewsDO.NewsImage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.MetaTag;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
            Sqlparam.Value = objNewsDO.MetaDes;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objNewsDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objNewsDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objNewsDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objNewsDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(NewsDO objNewsDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@NewsID", SqlDbType.Int);
            Sqlparam.Value = objNewsDO.NewsID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public NewsDO Select(NewsDO objNewsDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@NewsID", SqlDbType.Int);
            Sqlparam.Value = objNewsDO.NewsID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["NewsID"]))
                    objNewsDO.NewsID = Convert.ToInt32(dr["NewsID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objNewsDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objNewsDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objNewsDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["Detail"]))
                    objNewsDO.Detail = Convert.ToString(dr["Detail"]);
                if (!Convert.IsDBNull(dr["NewsImage"]))
                    objNewsDO.NewsImage = Convert.ToString(dr["NewsImage"]);
                if (!Convert.IsDBNull(dr["MetaTag"]))
                    objNewsDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                if (!Convert.IsDBNull(dr["MetaDes"]))
                    objNewsDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objNewsDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["Published"]))
                    objNewsDO.Published = Convert.ToBoolean(dr["Published"]);
                if (!Convert.IsDBNull(dr["ModuleID"]))
                    objNewsDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                if (!Convert.IsDBNull(dr["IsFrontPage"]))
                    objNewsDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);

            }
            return objNewsDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrNewsDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    NewsDO objNewsDO = new NewsDO();
                    if (!Convert.IsDBNull(dr["NewsID"]))
                        objNewsDO.NewsID = Convert.ToInt32(dr["NewsID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objNewsDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["Alias"]))
                        objNewsDO.Alias = Convert.ToString(dr["Alias"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objNewsDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["Detail"]))
                        objNewsDO.Detail = Convert.ToString(dr["Detail"]);
                    if (!Convert.IsDBNull(dr["NewsImage"]))
                        objNewsDO.NewsImage = Convert.ToString(dr["NewsImage"]);
                    if (!Convert.IsDBNull(dr["MetaTag"]))
                        objNewsDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                    if (!Convert.IsDBNull(dr["MetaDes"]))
                        objNewsDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                    if (!Convert.IsDBNull(dr["OrderID"]))
                        objNewsDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                    if (!Convert.IsDBNull(dr["Published"]))
                        objNewsDO.Published = Convert.ToBoolean(dr["Published"]);
                    if (!Convert.IsDBNull(dr["ModuleID"]))
                        objNewsDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                    if (!Convert.IsDBNull(dr["IsFrontPage"]))
                        objNewsDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
                    arrNewsDO.Add(objNewsDO);
                }
            }
            return arrNewsDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        #endregion


        public NewsDO SelectFirst()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetFirst";

            NewsDO objNewsDO = new NewsDO();

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["NewsID"]))
                    objNewsDO.NewsID = Convert.ToInt32(dr["NewsID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objNewsDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objNewsDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objNewsDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["Detail"]))
                    objNewsDO.Detail = Convert.ToString(dr["Detail"]);
                if (!Convert.IsDBNull(dr["NewsImage"]))
                    objNewsDO.NewsImage = Convert.ToString(dr["NewsImage"]);
                if (!Convert.IsDBNull(dr["MetaTag"]))
                    objNewsDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                if (!Convert.IsDBNull(dr["MetaDes"]))
                    objNewsDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objNewsDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["Published"]))
                    objNewsDO.Published = Convert.ToBoolean(dr["Published"]);
                if (!Convert.IsDBNull(dr["ModuleID"]))
                    objNewsDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                if (!Convert.IsDBNull(dr["IsFrontPage"]))
                    objNewsDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);

            }
            return objNewsDO;
        }

        public DataTable SelectbyNumber()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetbyNumber";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataTable SelectTopNews(int top)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetTopNews";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@top", SqlDbType.Int);
            Sqlparam.Value = top;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectNewsIsFrontPage(int top)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetNewsFrontPage";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@top", SqlDbType.Int);
            Sqlparam.Value = top;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectNewsByModulID(int ModulID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spNews_GetByModulId";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = ModulID;
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
