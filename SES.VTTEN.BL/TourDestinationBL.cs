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
/// Summary description for TourDestinationBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourDestinationBL 
    {
    	#region Private Variables
		TourDestinationDAL objTourDestinationDAL;
		#endregion
		
        #region Public Constructors
        public TourDestinationBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourDestinationDAL=new TourDestinationDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourDestinationDO objTourDestinationDO)
        {
            return objTourDestinationDAL.Insert(objTourDestinationDO);
        }

        public int Update(TourDestinationDO objTourDestinationDO)
        {
             return objTourDestinationDAL.Update(objTourDestinationDO);

        }

        public int Delete(TourDestinationDO objTourDestinationDO)
        {
             return objTourDestinationDAL.Delete(objTourDestinationDO);

        }

         public int DeleteAll()
        {
             return objTourDestinationDAL.DeleteAll();
        }

        public TourDestinationDO Select(TourDestinationDO objTourDestinationDO)
        {
            return objTourDestinationDAL.Select(objTourDestinationDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourDestinationDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourDestinationDAL.SelectAll();
        }


     
#endregion          
    
    
        public int DeletebyFK(int TourID)
        {
            return objTourDestinationDAL.DeletebyFK(TourID);
        }

        public bool Select1(int TourID, int DestinationID)
        {
            return objTourDestinationDAL.Select1(TourID, DestinationID);
        }

        public DataTable SelectbyTour(int p)
        {
            return objTourDestinationDAL.SelectbyTour(p);
        }

        public DataTable SelectbyDestination(int p)
        {
            return objTourDestinationDAL.SelectbyDestination(p);
        }
    }

}
