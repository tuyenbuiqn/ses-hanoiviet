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
/// Summary description for TourDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class TourDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public TourDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(TourDO objTourDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourCategoryID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.TourCategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourCode", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.TourCode;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourPrice", SqlDbType.Float);
            Sqlparam.Value = objTourDO.TourPrice;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objTourDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DurationDay", SqlDbType.Int);
            Sqlparam.Value = objTourDO.DurationDay;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@DurationNight", SqlDbType.Int);
            Sqlparam.Value = objTourDO.DurationNight;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@ImageFull", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.ImageFull;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NonInclude", SqlDbType.NText);
            Sqlparam.Value = objTourDO.NonInclude;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourImage", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.TourImage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Notes", SqlDbType.NText);
            Sqlparam.Value = objTourDO.Notes;
            Sqlcomm.Parameters.Add(Sqlparam);

          

            Sqlparam = new SqlParameter("@ToDestinationID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.ToDestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
            Sqlparam.Value = objTourDO.MetaTag;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
            Sqlparam.Value = objTourDO.MetaDes;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourAllPrice", SqlDbType.NText);
            Sqlparam.Value = objTourDO.TourAllPrice;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsSaleOff", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsSaleOff;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsMenu", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsMenu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsOutPromotion", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsOutPromotion;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourDO objTourDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.TourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourCategoryID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.TourCategoryID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourCode", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.TourCode;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourPrice", SqlDbType.Float);
            Sqlparam.Value = objTourDO.TourPrice;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objTourDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DurationDay", SqlDbType.Int);
            Sqlparam.Value = objTourDO.DurationDay;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@DurationNight", SqlDbType.Int);
            Sqlparam.Value = objTourDO.DurationNight;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ImageFull", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.ImageFull;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NonInclude", SqlDbType.NText);
            Sqlparam.Value = objTourDO.NonInclude;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourImage", SqlDbType.NVarChar);
            Sqlparam.Value = objTourDO.TourImage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Notes", SqlDbType.NText);
            Sqlparam.Value = objTourDO.Notes;
            Sqlcomm.Parameters.Add(Sqlparam);

          

            Sqlparam = new SqlParameter("@ToDestinationID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.ToDestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
            Sqlparam.Value = objTourDO.MetaTag;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
            Sqlparam.Value = objTourDO.MetaDes;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourAllPrice", SqlDbType.NText);
            Sqlparam.Value = objTourDO.TourAllPrice;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsSaleOff", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsSaleOff;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsMenu", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsMenu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsOutPromotion", SqlDbType.Bit);
            Sqlparam.Value = objTourDO.IsOutPromotion;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(TourDO objTourDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.TourID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourDO Select(TourDO objTourDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = objTourDO.TourID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["TourID"]))
                    objTourDO.TourID = Convert.ToInt32(dr["TourID"]);
                if (!Convert.IsDBNull(dr["TourCategoryID"]))
                    objTourDO.TourCategoryID = Convert.ToInt32(dr["TourCategoryID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objTourDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objTourDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["TourCode"]))
                    objTourDO.TourCode = Convert.ToString(dr["TourCode"]);
                if (!Convert.IsDBNull(dr["TourPrice"]))
                    objTourDO.TourPrice = Convert.ToDouble(dr["TourPrice"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objTourDO.Description = Convert.ToString(dr["Description"]);
              
                if (!Convert.IsDBNull(dr["ImageFull"]))
                    objTourDO.ImageFull = Convert.ToString(dr["ImageFull"]);
                if (!Convert.IsDBNull(dr["NonInclude"]))
                    objTourDO.NonInclude = Convert.ToString(dr["NonInclude"]);
                if (!Convert.IsDBNull(dr["TourImage"]))
                    objTourDO.TourImage = Convert.ToString(dr["TourImage"]);
                if (!Convert.IsDBNull(dr["Notes"]))
                    objTourDO.Notes = Convert.ToString(dr["Notes"]);
                if (!Convert.IsDBNull(dr["DurationNight"]))
                    objTourDO.DurationNight = Convert.ToInt32(dr["DurationNight"]);

                if (!Convert.IsDBNull(dr["DurationDay"]))
                    objTourDO.DurationDay = Convert.ToInt32(dr["DurationDay"]);


                if (!Convert.IsDBNull(dr["ToDestinationID"]))
                    objTourDO.ToDestinationID = Convert.ToInt32(dr["ToDestinationID"]);
                if (!Convert.IsDBNull(dr["MetaTag"]))
                    objTourDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                if (!Convert.IsDBNull(dr["MetaDes"]))
                    objTourDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objTourDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["Published"]))
                    objTourDO.Published = Convert.ToBoolean(dr["Published"]);
                if (!Convert.IsDBNull(dr["ModuleID"]))
                    objTourDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                if (!Convert.IsDBNull(dr["IsFrontPage"]))
                    objTourDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);

                if (!Convert.IsDBNull(dr["TourTypeID"]))
                    objTourDO.TourTypeID = Convert.ToInt32(dr["TourTypeID"]);

                if (!Convert.IsDBNull(dr["TourAllPrice"]))
                    objTourDO.TourAllPrice = Convert.ToString(dr["TourAllPrice"]);

                if (!Convert.IsDBNull(dr["IsSaleOff"]))
                    objTourDO.IsSaleOff = Convert.ToBoolean(dr["IsSaleOff"]);

                if (!Convert.IsDBNull(dr["IsMenu"]))
                    objTourDO.IsMenu = Convert.ToBoolean(dr["IsMenu"]);

                if (!Convert.IsDBNull(dr["IsOutPromotion"]))
                    objTourDO.IsMenu = Convert.ToBoolean(dr["IsOutPromotion"]);

            }
            return objTourDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    TourDO objTourDO = new TourDO();
                    if (!Convert.IsDBNull(dr["TourID"]))
                        objTourDO.TourID = Convert.ToInt32(dr["TourID"]);
                    if (!Convert.IsDBNull(dr["TourCategoryID"]))
                        objTourDO.TourCategoryID = Convert.ToInt32(dr["TourCategoryID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objTourDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["Alias"]))
                        objTourDO.Alias = Convert.ToString(dr["Alias"]);
                    if (!Convert.IsDBNull(dr["TourCode"]))
                        objTourDO.TourCode = Convert.ToString(dr["TourCode"]);
                    if (!Convert.IsDBNull(dr["TourPrice"]))
                        objTourDO.TourPrice = Convert.ToDouble(dr["TourPrice"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objTourDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["DurationNight"]))
                        objTourDO.DurationNight = Convert.ToInt32(dr["DurationNight"]);

                    if (!Convert.IsDBNull(dr["DurationDay"]))
                        objTourDO.DurationDay = Convert.ToInt32(dr["DurationDay"]);

                    if (!Convert.IsDBNull(dr["ImageFull"]))
                        objTourDO.ImageFull = Convert.ToString(dr["ImageFull"]);
                    if (!Convert.IsDBNull(dr["NonInclude"]))
                        objTourDO.NonInclude = Convert.ToString(dr["NonInclude"]);
                    if (!Convert.IsDBNull(dr["TourImage"]))
                        objTourDO.TourImage = Convert.ToString(dr["TourImage"]);
                    if (!Convert.IsDBNull(dr["Notes"]))
                        objTourDO.Notes = Convert.ToString(dr["Notes"]);
                 
                    if (!Convert.IsDBNull(dr["ToDestinationID"]))
                        objTourDO.ToDestinationID = Convert.ToInt32(dr["ToDestinationID"]);
                    if (!Convert.IsDBNull(dr["MetaTag"]))
                        objTourDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                    if (!Convert.IsDBNull(dr["MetaDes"]))
                        objTourDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                    if (!Convert.IsDBNull(dr["OrderID"]))
                        objTourDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                    if (!Convert.IsDBNull(dr["Published"]))
                        objTourDO.Published = Convert.ToBoolean(dr["Published"]);
                    if (!Convert.IsDBNull(dr["ModuleID"]))
                        objTourDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                    if (!Convert.IsDBNull(dr["IsFrontPage"]))
                        objTourDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);
                    if (!Convert.IsDBNull(dr["TourTypeID"]))
                        objTourDO.TourTypeID = Convert.ToInt32(dr["TourTypeID"]);

                    if (!Convert.IsDBNull(dr["TourAllPrice"]))
                        objTourDO.TourAllPrice = Convert.ToString(dr["TourAllPrice"]);

                    if (!Convert.IsDBNull(dr["IsSaleOff"]))
                        objTourDO.IsSaleOff = Convert.ToBoolean(dr["IsSaleOff"]);

                    if (!Convert.IsDBNull(dr["IsMenu"]))
                        objTourDO.IsMenu = Convert.ToBoolean(dr["IsMenu"]);

                    if (!Convert.IsDBNull(dr["IsOutPromotion"]))
                        objTourDO.IsMenu = Convert.ToBoolean(dr["IsOutPromotion"]);

                    arrTourDO.Add(objTourDO);
                }
            }
            return arrTourDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetAll";

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
            Sqlcomm.CommandText = "spTour_GetbyNumber";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectbyTourCat(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetbyTourCat";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourCategoryID", SqlDbType.Int);
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

        public DataTable SelectbyTourTypeIDParent(int ParentID, int IsFrontPage)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetAllParentIDHome";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
            Sqlparam.Value = ParentID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Int);
            Sqlparam.Value = IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable Search(int ID, int ID1, int ID2, DateTime ID3)
        {
           
            DataTable dt = null;

           
            return dt;
        }

        public DataTable SelectTourByParentAndRecordNumber(int TourTypeID, int RecordNumber)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsTour_SelectByCateAndRecordNumber";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
            Sqlparam.Value = TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@RecordNumber", SqlDbType.Int);
            Sqlparam.Value = RecordNumber;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }


        public DataTable SelectbyDes(int ID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetByDes";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
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

        public DataTable SelectbyTag(string Tag)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "sp_GetByTag";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TagItem", SqlDbType.NVarChar);
            Sqlparam.Value = Tag;
            Sqlcomm.Parameters.Add(Sqlparam);
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectbyTourType(int TourTypeID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetByTypeParentID";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
            Sqlparam.Value = TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectSaleOff(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetAllSaleOff";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@RecordNumber", SqlDbType.Int);
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

        public DataTable SelectOutPromotion()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_GetAllOutPromotion";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable Search(int DesID, int TourTypeID, int TourCatID, int DurationID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTour_Search";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = DesID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@TourTypeID", SqlDbType.Int);
            Sqlparam.Value = TourTypeID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@TourCategoryID", SqlDbType.Int);
            Sqlparam.Value = TourCatID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@DurationID", SqlDbType.Int);
            Sqlparam.Value = DurationID;

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
