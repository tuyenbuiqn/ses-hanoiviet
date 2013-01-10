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
/// Summary description for HotelDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class HotelDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public HotelDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(HotelDO objHotelDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.Detail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelImage", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.HotelImage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@StarRates", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.StarRates;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ContactInfo", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.ContactInfo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.DestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.MetaTag;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.MetaDes;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objHotelDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objHotelDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelStartPrice", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.HotelStartPrice;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsMenu", SqlDbType.Bit);
            Sqlparam.Value = objHotelDO.IsMenu;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(HotelDO objHotelDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.HotelID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.Title;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Alias", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.Alias;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.Description;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.Detail;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelImage", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.HotelImage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@StarRates", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.StarRates;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ContactInfo", SqlDbType.NVarChar);
            Sqlparam.Value = objHotelDO.ContactInfo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.DestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaTag", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.MetaTag;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@MetaDes", SqlDbType.NText);
            Sqlparam.Value = objHotelDO.MetaDes;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OrderID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.OrderID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
            Sqlparam.Value = objHotelDO.Published;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ModuleID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.ModuleID;
            Sqlcomm.Parameters.Add(Sqlparam);

             Sqlparam = new SqlParameter("@HotelStartPrice", SqlDbType.Int);
             Sqlparam.Value = objHotelDO.HotelStartPrice;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@IsFrontPage", SqlDbType.Bit);
            Sqlparam.Value = objHotelDO.IsFrontPage;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@IsMenu", SqlDbType.Bit);
            Sqlparam.Value = objHotelDO.IsMenu;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(HotelDO objHotelDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.HotelID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public HotelDO Select(HotelDO objHotelDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
            Sqlparam.Value = objHotelDO.HotelID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["HotelID"]))
                    objHotelDO.HotelID = Convert.ToInt32(dr["HotelID"]);
                if (!Convert.IsDBNull(dr["Title"]))
                    objHotelDO.Title = Convert.ToString(dr["Title"]);
                if (!Convert.IsDBNull(dr["Alias"]))
                    objHotelDO.Alias = Convert.ToString(dr["Alias"]);
                if (!Convert.IsDBNull(dr["Description"]))
                    objHotelDO.Description = Convert.ToString(dr["Description"]);
                if (!Convert.IsDBNull(dr["Detail"]))
                    objHotelDO.Detail = Convert.ToString(dr["Detail"]);
                if (!Convert.IsDBNull(dr["HotelImage"]))
                    objHotelDO.HotelImage = Convert.ToString(dr["HotelImage"]);
                if (!Convert.IsDBNull(dr["StarRates"]))
                    objHotelDO.StarRates = Convert.ToInt32(dr["StarRates"]);
                if (!Convert.IsDBNull(dr["ContactInfo"]))
                    objHotelDO.ContactInfo = Convert.ToString(dr["ContactInfo"]);
                if (!Convert.IsDBNull(dr["DestinationID"]))
                    objHotelDO.DestinationID = Convert.ToInt32(dr["DestinationID"]);
                if (!Convert.IsDBNull(dr["MetaTag"]))
                    objHotelDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                if (!Convert.IsDBNull(dr["MetaDes"]))
                    objHotelDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                if (!Convert.IsDBNull(dr["OrderID"]))
                    objHotelDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                if (!Convert.IsDBNull(dr["Published"]))
                    objHotelDO.Published = Convert.ToBoolean(dr["Published"]);
                if (!Convert.IsDBNull(dr["ModuleID"]))
                    objHotelDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);

                if (!Convert.IsDBNull(dr["HotelStartPrice"]))
                    objHotelDO.HotelStartPrice = Convert.ToInt32(dr["HotelStartPrice"]);

                if (!Convert.IsDBNull(dr["IsFrontPage"]))
                    objHotelDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);

                if (!Convert.IsDBNull(dr["IsMenu"]))
                    objHotelDO.IsMenu = Convert.ToBoolean(dr["IsMenu"]);

            }
            return objHotelDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrHotelDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    HotelDO objHotelDO = new HotelDO();
                    if (!Convert.IsDBNull(dr["HotelID"]))
                        objHotelDO.HotelID = Convert.ToInt32(dr["HotelID"]);
                    if (!Convert.IsDBNull(dr["Title"]))
                        objHotelDO.Title = Convert.ToString(dr["Title"]);
                    if (!Convert.IsDBNull(dr["Alias"]))
                        objHotelDO.Alias = Convert.ToString(dr["Alias"]);
                    if (!Convert.IsDBNull(dr["Description"]))
                        objHotelDO.Description = Convert.ToString(dr["Description"]);
                    if (!Convert.IsDBNull(dr["Detail"]))
                        objHotelDO.Detail = Convert.ToString(dr["Detail"]);
                    if (!Convert.IsDBNull(dr["HotelImage"]))
                        objHotelDO.HotelImage = Convert.ToString(dr["HotelImage"]);
                    if (!Convert.IsDBNull(dr["StarRates"]))
                        objHotelDO.StarRates = Convert.ToInt32(dr["StarRates"]);
                    if (!Convert.IsDBNull(dr["ContactInfo"]))
                        objHotelDO.ContactInfo = Convert.ToString(dr["ContactInfo"]);
                    if (!Convert.IsDBNull(dr["DestinationID"]))
                        objHotelDO.DestinationID = Convert.ToInt32(dr["DestinationID"]);
                    if (!Convert.IsDBNull(dr["MetaTag"]))
                        objHotelDO.MetaTag = Convert.ToString(dr["MetaTag"]);
                    if (!Convert.IsDBNull(dr["MetaDes"]))
                        objHotelDO.MetaDes = Convert.ToString(dr["MetaDes"]);
                    if (!Convert.IsDBNull(dr["OrderID"]))
                        objHotelDO.OrderID = Convert.ToInt32(dr["OrderID"]);
                    if (!Convert.IsDBNull(dr["Published"]))
                        objHotelDO.Published = Convert.ToBoolean(dr["Published"]);
                    if (!Convert.IsDBNull(dr["ModuleID"]))
                        objHotelDO.ModuleID = Convert.ToInt32(dr["ModuleID"]);
                    if (!Convert.IsDBNull(dr["HotelStartPrice"]))
                        objHotelDO.HotelStartPrice = Convert.ToInt32(dr["HotelStartPrice"]);
                    if (!Convert.IsDBNull(dr["IsFrontPage"]))
                        objHotelDO.IsFrontPage = Convert.ToBoolean(dr["IsFrontPage"]);

                    if (!Convert.IsDBNull(dr["IsMenu"]))
                        objHotelDO.IsMenu = Convert.ToBoolean(dr["IsMenu"]);
                    arrHotelDO.Add(objHotelDO);
                }
            }
            return arrHotelDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_GetAll";

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
            Sqlcomm.CommandText = "spHotel_GetbyNumber";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable Search(int ID, int ID1, int ID2)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_Search";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@StarRates", SqlDbType.Int);
            Sqlparam.Value = ID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@Price", SqlDbType.Int);
            Sqlparam.Value = ID1;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = ID2;
            Sqlcomm.Parameters.Add(Sqlparam);
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectbyDestination(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_GetByDestination";
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

        public DataTable SelectbyRate(int p, int i)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_GetByRate";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@StarRates", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = i;
            Sqlcomm.Parameters.Add(Sqlparam);
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataTable SelectTopStarRates(int top)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spcmsHotel_GetTopRate";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@Top", SqlDbType.Int);
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

        public DataTable GetAllByDesID(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_GetAllDesID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
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

        public DataTable SelectbyTourType(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_GetByTourTypeID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ParentID", SqlDbType.Int);
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

        public DataTable SelectbyDesHome(int p, int record)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_SelectbyDesHome";
            SqlParameter Sqlparam;

            
            Sqlparam = new SqlParameter("@RecordNum", SqlDbType.Int);
            Sqlparam.Value = record;
            Sqlcomm.Parameters.Add(Sqlparam);
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
        public DataTable SelectHotelHasBooking()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotel_SelectBookingHotel";

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
