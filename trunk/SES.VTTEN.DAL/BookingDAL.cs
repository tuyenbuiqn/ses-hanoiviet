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
/// Summary description for BookingDAL
/// </summary>
namespace SES.VTTEN.DAL
{

    public class BookingDAL : BaseDAL
    {
        #region Private Variables

        #endregion

        #region Public Constructors
        public BookingDAL()
        {
            //
            // TODO: Add constructor logic here
            //

        }
        #endregion



        #region Public Methods
        public int Insert(BookingDO objBookingDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.TourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BookingDate", SqlDbType.DateTime);
            Sqlparam.Value = objBookingDO.BookingDate;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DepartureDate", SqlDbType.DateTime);
            if (objBookingDO.DepartureDate <= DateTime.MinValue)
                Sqlparam.Value = null;
            else
                Sqlparam.Value = objBookingDO.DepartureDate;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AdultNo", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.AdultNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ChildNo", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.ChildNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelCat", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.HotelCat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OtherRequest", SqlDbType.NText);
            Sqlparam.Value = objBookingDO.OtherRequest;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@FullName", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.FullName;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Gender", SqlDbType.Bit);
            Sqlparam.Value = objBookingDO.Gender;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DayOfBirth", SqlDbType.DateTime);
            Sqlparam.Value = objBookingDO.DayOfBirth;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.Email;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Country", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.Country;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Address", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.Address;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhoneNo", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.PhoneNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@FaxNo", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.FaxNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ArrivalDate", SqlDbType.DateTime);
            Sqlparam.Value = objBookingDO.ArrivalDate;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AirCorp", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.AirCorp;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@FlightNo", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.FlightNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ArrivalCiy", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.ArrivalCiy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TimeLocal", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.TimeLocal;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BillingOption", SqlDbType.Bit);
            Sqlparam.Value = objBookingDO.BillingOption;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TypeOfRoom", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.TypeOfRoom;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NumberRoom", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.NumberRoom;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NumberPerson", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.NumberPerson;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Checkin", SqlDbType.DateTime);
            if (objBookingDO.Checkin <= DateTime.MinValue)
                Sqlparam.Value = null;
            else
            Sqlparam.Value = objBookingDO.Checkin;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Checkout", SqlDbType.DateTime);
            if (objBookingDO.Checkout <= DateTime.MinValue)
                Sqlparam.Value = null;
            else
                Sqlparam.Value = objBookingDO.Checkout;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@InformationSource", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.InformationSource;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.HotelID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ServicesID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.ServicesID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);


            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(BookingDO objBookingDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@BookingID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.BookingID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.TourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BookingDate", SqlDbType.DateTime);
            Sqlparam.Value = objBookingDO.BookingDate;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DepartureDate", SqlDbType.DateTime);
            if (objBookingDO.DepartureDate <= DateTime.MinValue)
                Sqlparam.Value = null;
            else
                Sqlparam.Value = objBookingDO.DepartureDate;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AdultNo", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.AdultNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ChildNo", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.ChildNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelCat", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.HotelCat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@OtherRequest", SqlDbType.NText);
            Sqlparam.Value = objBookingDO.OtherRequest;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@FullName", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.FullName;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Gender", SqlDbType.Bit);
            Sqlparam.Value = objBookingDO.Gender;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@DayOfBirth", SqlDbType.DateTime);
            Sqlparam.Value = objBookingDO.DayOfBirth;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.Email;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Country", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.Country;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Address", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.Address;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@PhoneNo", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.PhoneNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@FaxNo", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.FaxNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ArrivalDate", SqlDbType.DateTime);
            Sqlparam.Value = objBookingDO.ArrivalDate;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@AirCorp", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.AirCorp;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@FlightNo", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.FlightNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ArrivalCiy", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.ArrivalCiy;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TimeLocal", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.TimeLocal;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@BillingOption", SqlDbType.Bit);
            Sqlparam.Value = objBookingDO.BillingOption;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@TypeOfRoom", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.TypeOfRoom;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NumberRoom", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.NumberRoom;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@NumberPerson", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.NumberPerson;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Checkin", SqlDbType.DateTime);
            if (objBookingDO.Checkin <= DateTime.MinValue)
                Sqlparam.Value = null;
            else
                Sqlparam.Value = objBookingDO.Checkin;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@Checkout", SqlDbType.DateTime);
            if (objBookingDO.Checkout <= DateTime.MinValue)
                Sqlparam.Value = null;
            else
                Sqlparam.Value = objBookingDO.Checkout;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@InformationSource", SqlDbType.NVarChar);
            Sqlparam.Value = objBookingDO.InformationSource;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.HotelID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ServicesID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.ServicesID;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);

            int result = base.ExecuteNoneQuery(Sqlcomm);

            if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);

            return result;


        }

        public int Delete(BookingDO objBookingDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@BookingID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.BookingID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public int DeleteAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_DeleteAll";

            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public BookingDO Select(BookingDO objBookingDO)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_GetByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@BookingID", SqlDbType.Int);
            Sqlparam.Value = objBookingDO.BookingID;
            Sqlcomm.Parameters.Add(Sqlparam);



            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["BookingID"]))
                    objBookingDO.BookingID = Convert.ToInt32(dr["BookingID"]);
                if (!Convert.IsDBNull(dr["TourID"]))
                    objBookingDO.TourID = Convert.ToInt32(dr["TourID"]);
                if (!Convert.IsDBNull(dr["BookingDate"]))
                    objBookingDO.BookingDate = Convert.ToDateTime(dr["BookingDate"]);
                if (!Convert.IsDBNull(dr["DepartureDate"]))
                    objBookingDO.DepartureDate = Convert.ToDateTime(dr["DepartureDate"]);
                if (!Convert.IsDBNull(dr["AdultNo"]))
                    objBookingDO.AdultNo = Convert.ToInt32(dr["AdultNo"]);
                if (!Convert.IsDBNull(dr["ChildNo"]))
                    objBookingDO.ChildNo = Convert.ToInt32(dr["ChildNo"]);
                if (!Convert.IsDBNull(dr["HotelCat"]))
                    objBookingDO.HotelCat = Convert.ToInt32(dr["HotelCat"]);
                if (!Convert.IsDBNull(dr["OtherRequest"]))
                    objBookingDO.OtherRequest = Convert.ToString(dr["OtherRequest"]);
                if (!Convert.IsDBNull(dr["FullName"]))
                    objBookingDO.FullName = Convert.ToString(dr["FullName"]);
                if (!Convert.IsDBNull(dr["Gender"]))
                    objBookingDO.Gender = Convert.ToBoolean(dr["Gender"]);
                if (!Convert.IsDBNull(dr["DayOfBirth"]))
                    objBookingDO.DayOfBirth = Convert.ToDateTime(dr["DayOfBirth"]);
                if (!Convert.IsDBNull(dr["Email"]))
                    objBookingDO.Email = Convert.ToString(dr["Email"]);
                if (!Convert.IsDBNull(dr["Country"]))
                    objBookingDO.Country = Convert.ToInt32(dr["Country"]);
                if (!Convert.IsDBNull(dr["Address"]))
                    objBookingDO.Address = Convert.ToString(dr["Address"]);
                if (!Convert.IsDBNull(dr["PhoneNo"]))
                    objBookingDO.PhoneNo = Convert.ToString(dr["PhoneNo"]);
                if (!Convert.IsDBNull(dr["FaxNo"]))
                    objBookingDO.FaxNo = Convert.ToString(dr["FaxNo"]);
                if (!Convert.IsDBNull(dr["ArrivalDate"]))
                    objBookingDO.ArrivalDate = Convert.ToDateTime(dr["ArrivalDate"]);
                if (!Convert.IsDBNull(dr["AirCorp"]))
                    objBookingDO.AirCorp = Convert.ToString(dr["AirCorp"]);
                if (!Convert.IsDBNull(dr["FlightNo"]))
                    objBookingDO.FlightNo = Convert.ToString(dr["FlightNo"]);
                if (!Convert.IsDBNull(dr["ArrivalCiy"]))
                    objBookingDO.ArrivalCiy = Convert.ToString(dr["ArrivalCiy"]);
                if (!Convert.IsDBNull(dr["TimeLocal"]))
                    objBookingDO.TimeLocal = Convert.ToString(dr["TimeLocal"]);
                if (!Convert.IsDBNull(dr["BillingOption"]))
                    objBookingDO.BillingOption = Convert.ToBoolean(dr["BillingOption"]);
                if (!Convert.IsDBNull(dr["TypeOfRoom"]))
                    objBookingDO.TypeOfRoom = Convert.ToInt32(dr["TypeOfRoom"]);
                if (!Convert.IsDBNull(dr["NumberRoom"]))
                    objBookingDO.NumberRoom = Convert.ToInt32(dr["NumberRoom"]);
                if (!Convert.IsDBNull(dr["NumberPerson"]))
                    objBookingDO.NumberPerson = Convert.ToInt32(dr["NumberPerson"]);
                if (!Convert.IsDBNull(dr["Checkin"]))
                    objBookingDO.Checkin = Convert.ToDateTime(dr["Checkin"]);
                if (!Convert.IsDBNull(dr["Checkout"]))
                    objBookingDO.Checkout = Convert.ToDateTime(dr["Checkout"]);
                if (!Convert.IsDBNull(dr["InformationSource"]))
                    objBookingDO.InformationSource = Convert.ToString(dr["InformationSource"]);
                if (!Convert.IsDBNull(dr["HotelID"]))
                    objBookingDO.HotelID = Convert.ToInt32(dr["HotelID"]);
                if (!Convert.IsDBNull(dr["ServicesID"]))
                    objBookingDO.ServicesID = Convert.ToInt32(dr["ServicesID"]);

            }
            return objBookingDO;
        }

        public ArrayList SelectAll1()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrBookingDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    BookingDO objBookingDO = new BookingDO();
                    if (!Convert.IsDBNull(dr["BookingID"]))
                        objBookingDO.BookingID = Convert.ToInt32(dr["BookingID"]);
                    if (!Convert.IsDBNull(dr["TourID"]))
                        objBookingDO.TourID = Convert.ToInt32(dr["TourID"]);
                    if (!Convert.IsDBNull(dr["BookingDate"]))
                        objBookingDO.BookingDate = Convert.ToDateTime(dr["BookingDate"]);
                    if (!Convert.IsDBNull(dr["DepartureDate"]))
                        objBookingDO.DepartureDate = Convert.ToDateTime(dr["DepartureDate"]);
                    if (!Convert.IsDBNull(dr["AdultNo"]))
                        objBookingDO.AdultNo = Convert.ToInt32(dr["AdultNo"]);
                    if (!Convert.IsDBNull(dr["ChildNo"]))
                        objBookingDO.ChildNo = Convert.ToInt32(dr["ChildNo"]);
                    if (!Convert.IsDBNull(dr["HotelCat"]))
                        objBookingDO.HotelCat = Convert.ToInt32(dr["HotelCat"]);
                    if (!Convert.IsDBNull(dr["OtherRequest"]))
                        objBookingDO.OtherRequest = Convert.ToString(dr["OtherRequest"]);
                    if (!Convert.IsDBNull(dr["FullName"]))
                        objBookingDO.FullName = Convert.ToString(dr["FullName"]);
                    if (!Convert.IsDBNull(dr["Gender"]))
                        objBookingDO.Gender = Convert.ToBoolean(dr["Gender"]);
                    if (!Convert.IsDBNull(dr["DayOfBirth"]))
                        objBookingDO.DayOfBirth = Convert.ToDateTime(dr["DayOfBirth"]);
                    if (!Convert.IsDBNull(dr["Email"]))
                        objBookingDO.Email = Convert.ToString(dr["Email"]);
                    if (!Convert.IsDBNull(dr["Country"]))
                        objBookingDO.Country = Convert.ToInt32(dr["Country"]);
                    if (!Convert.IsDBNull(dr["Address"]))
                        objBookingDO.Address = Convert.ToString(dr["Address"]);
                    if (!Convert.IsDBNull(dr["PhoneNo"]))
                        objBookingDO.PhoneNo = Convert.ToString(dr["PhoneNo"]);
                    if (!Convert.IsDBNull(dr["FaxNo"]))
                        objBookingDO.FaxNo = Convert.ToString(dr["FaxNo"]);
                    if (!Convert.IsDBNull(dr["ArrivalDate"]))
                        objBookingDO.ArrivalDate = Convert.ToDateTime(dr["ArrivalDate"]);
                    if (!Convert.IsDBNull(dr["AirCorp"]))
                        objBookingDO.AirCorp = Convert.ToString(dr["AirCorp"]);
                    if (!Convert.IsDBNull(dr["FlightNo"]))
                        objBookingDO.FlightNo = Convert.ToString(dr["FlightNo"]);
                    if (!Convert.IsDBNull(dr["ArrivalCiy"]))
                        objBookingDO.ArrivalCiy = Convert.ToString(dr["ArrivalCiy"]);
                    if (!Convert.IsDBNull(dr["TimeLocal"]))
                        objBookingDO.TimeLocal = Convert.ToString(dr["TimeLocal"]);
                    if (!Convert.IsDBNull(dr["BillingOption"]))
                        objBookingDO.BillingOption = Convert.ToBoolean(dr["BillingOption"]);
                    if (!Convert.IsDBNull(dr["TypeOfRoom"]))
                        objBookingDO.TypeOfRoom = Convert.ToInt32(dr["TypeOfRoom"]);
                    if (!Convert.IsDBNull(dr["NumberRoom"]))
                        objBookingDO.NumberRoom = Convert.ToInt32(dr["NumberRoom"]);
                    if (!Convert.IsDBNull(dr["NumberPerson"]))
                        objBookingDO.NumberPerson = Convert.ToInt32(dr["NumberPerson"]);
                    if (!Convert.IsDBNull(dr["Checkin"]))
                        objBookingDO.Checkin = Convert.ToDateTime(dr["Checkin"]);
                    if (!Convert.IsDBNull(dr["Checkout"]))
                        objBookingDO.Checkout = Convert.ToDateTime(dr["Checkout"]);
                    if (!Convert.IsDBNull(dr["InformationSource"]))
                        objBookingDO.InformationSource = Convert.ToString(dr["InformationSource"]);
                    if (!Convert.IsDBNull(dr["HotelID"]))
                        objBookingDO.HotelID = Convert.ToInt32(dr["HotelID"]);
                    arrBookingDO.Add(objBookingDO);
                }
            }
            return arrBookingDO;
        }

        public DataTable SelectAll()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_GetAll";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
        public DataTable SelectBookingByType(int type)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_SelectBookingType";

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
        public DataTable SelectBookingHotelByUserDestination(int userID)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_GetHotelBookingByUserDestination";

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


        public DataTable SelectTourUser(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_SelectTourUser";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
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

        public DataTable SelectByDes(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_SelectByDes";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@DesID", SqlDbType.Int);
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

        public DataTable SelectAll3()
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_GetAll3";

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectByHotel(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spBooking_GetByHotel";

            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
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
