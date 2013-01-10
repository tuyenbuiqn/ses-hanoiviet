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
/// Summary description for UserDestinationDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class UserDestinationDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public UserDestinationDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(UserDestinationDO objUserDestinationDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.UserID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.DestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(UserDestinationDO objUserDestinationDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@UserDestinationID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.UserDestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.UserID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.DestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);



            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;
        }
        public int UpdateByUserID(UserDestinationDO objUserDestinationDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_UpdateByUserID";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.UserID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.DestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);


            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;
        }



        public int Delete(UserDestinationDO objUserDestinationDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@UserDestinationID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.UserDestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteByUserID(int userID)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_DeleteByUserID";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
            Sqlparam.Value = userID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public UserDestinationDO Select(UserDestinationDO objUserDestinationDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@UserDestinationID", SqlDbType.Int);
            Sqlparam.Value = objUserDestinationDO.UserDestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["UserDestinationID"]))
                    objUserDestinationDO.UserDestinationID = Convert.ToInt32(dr["UserDestinationID"]);
                if (!Convert.IsDBNull(dr["UserID"]))
                    objUserDestinationDO.UserID = Convert.ToInt32(dr["UserID"]);
                if (!Convert.IsDBNull(dr["DestinationID"]))
                    objUserDestinationDO.DestinationID = Convert.ToInt32(dr["DestinationID"]);

            }
            return objUserDestinationDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrUserDestinationDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    UserDestinationDO objUserDestinationDO = new UserDestinationDO();
                    if (!Convert.IsDBNull(dr["UserDestinationID"]))
                        objUserDestinationDO.UserDestinationID = Convert.ToInt32(dr["UserDestinationID"]);
                    if (!Convert.IsDBNull(dr["UserID"]))
                        objUserDestinationDO.UserID = Convert.ToInt32(dr["UserID"]);
                    if (!Convert.IsDBNull(dr["DestinationID"]))
                        objUserDestinationDO.DestinationID = Convert.ToInt32(dr["DestinationID"]);
                    arrUserDestinationDO.Add(objUserDestinationDO);
                }
            }
            return arrUserDestinationDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable GetEmailOfDestination(int type, int id)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_GetALlMail";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Type", SqlDbType.Int);
            Sqlparam.Value = type;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Value = id;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable  SelectByUserID(int userID)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUserDestination_SelectByUserID";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
            Sqlparam.Value = userID;
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

    }

}
