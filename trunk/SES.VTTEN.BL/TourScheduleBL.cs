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
/// Summary description for TourScheduleBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourScheduleBL 
    {
    	#region Private Variables
		TourScheduleDAL objTourScheduleDAL;
		#endregion
		
        #region Public Constructors
        public TourScheduleBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourScheduleDAL=new TourScheduleDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourScheduleDO objTourScheduleDO)
        {
            return objTourScheduleDAL.Insert(objTourScheduleDO);
        }

        public int Update(TourScheduleDO objTourScheduleDO)
        {
             return objTourScheduleDAL.Update(objTourScheduleDO);

        }

        public int Delete(TourScheduleDO objTourScheduleDO)
        {
             return objTourScheduleDAL.Delete(objTourScheduleDO);

        }

         public int DeleteAll()
        {
             return objTourScheduleDAL.DeleteAll();
        }

        public TourScheduleDO Select(TourScheduleDO objTourScheduleDO)
        {
            return objTourScheduleDAL.Select(objTourScheduleDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourScheduleDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourScheduleDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectbyFK(int TourID)
        {
            return objTourScheduleDAL.SelectbyFK(TourID);
        }

        public bool Select2(int DayNo, int TourID)
        {
            return objTourScheduleDAL.Selectby2(DayNo, TourID);
        }
    }

}
