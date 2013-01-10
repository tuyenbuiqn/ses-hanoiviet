/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;

using SES.VTTEN.DAL;
using SES.VTTEN.DO;
/// <summary>
/// Summary description for BookingBL
/// </summary>
namespace SES.VTTEN.BL
{
    public class BookingBL
    {
        #region Private Variables
        BookingDAL objBookingDAL;
        #endregion

        #region Public Constructors
        public BookingBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objBookingDAL = new BookingDAL();
        }
        #endregion

        #region Public Methods
        public int Insert(BookingDO objBookingDO)
        {
            return objBookingDAL.Insert(objBookingDO);
        }

        public int Update(BookingDO objBookingDO)
        {
            return objBookingDAL.Update(objBookingDO);

        }

        public int Delete(BookingDO objBookingDO)
        {
            return objBookingDAL.Delete(objBookingDO);

        }

        public int DeleteAll()
        {
            return objBookingDAL.DeleteAll();
        }

        public BookingDO Select(BookingDO objBookingDO)
        {
            return objBookingDAL.Select(objBookingDO);
        }

        public ArrayList SelectAll1()
        {
            return objBookingDAL.SelectAll1();
        }

        public DataTable SelectAll()
        {
            return objBookingDAL.SelectAll();
        }
        public DataTable SelectBookingByType(int type)
        { return objBookingDAL.SelectBookingByType(type); }

        public DataTable SelectBookingHotelByUserDestination(int userID)
        {
            return objBookingDAL.SelectBookingHotelByUserDestination(userID);
        }

        #endregion


        public object SelectTourUser(int p)
        {
            return objBookingDAL.SelectTourUser(p);
        }

        public object SelectByDes(int p)
        {
            return objBookingDAL.SelectByDes(p);
        }

        public DataTable SelectAll3()
        {
            return objBookingDAL.SelectAll3();
        }

        public object SelectByHotel(int p)
        {
            return objBookingDAL.SelectByHotel(p);
        }
        
    }

}
