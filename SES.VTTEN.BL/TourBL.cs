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
/// Summary description for TourBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class TourBL 
    {
    	#region Private Variables
		TourDAL objTourDAL;
		#endregion
		
        #region Public Constructors
        public TourBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objTourDAL=new TourDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(TourDO objTourDO)
        {
            return objTourDAL.Insert(objTourDO);
        }

        public int Update(TourDO objTourDO)
        {
             return objTourDAL.Update(objTourDO);

        }

        public int Delete(TourDO objTourDO)
        {
             return objTourDAL.Delete(objTourDO);

        }

         public int DeleteAll()
        {
             return objTourDAL.DeleteAll();
        }

        public TourDO Select(TourDO objTourDO)
        {
            return objTourDAL.Select(objTourDO);
        }

        public ArrayList SelectAll1( )
        {
         return objTourDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objTourDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectbyNumber()
        {
            return objTourDAL.SelectbyNumber();
        }

        public DataTable SelectbyTourTypeIDParent(int ParentID, int IsFrontPage)
        {
            return objTourDAL.SelectbyTourTypeIDParent(ParentID, IsFrontPage);
        }
        public DataTable SelectbyTourCat(int p)
        {
            return objTourDAL.SelectbyTourCat(p);
        }

        public DataTable Search(int ID, int ID1, int ID2, DateTime ID3)
        {
            return objTourDAL.Search(ID, ID1, ID2, ID3);
        }

        public DataTable SelectbyDes(int ID)
        {
            return objTourDAL.SelectbyDes(ID);
        }

        public DataTable SelectbyTag(string Tag)
        {
            return objTourDAL.SelectbyTag(Tag);
        }

        public DataTable SelectbyTourType(int TourTypeID)
        {
            return objTourDAL.SelectbyTourType(TourTypeID);
        }
        public DataTable SelectTourByParentAndRecordNumber(int TourTypeID, int RecordNumber)
        {
            return objTourDAL.SelectTourByParentAndRecordNumber(TourTypeID, RecordNumber);
        }
        public DataTable SelectTourByParentAndRecordNumberHomepage(int TourTypeID, int RecordNumber)
        {
            return objTourDAL.SelectTourByParentAndRecordNumberHomepage(TourTypeID, RecordNumber);
        }
        public DataTable SelectSaleOff(int p)
        {
            return objTourDAL.SelectSaleOff(p);
        }

        public DataTable SelectOutPromotion()
        {
            return objTourDAL.SelectOutPromotion();
        }

        public DataTable Search(int DesID, int TourTypeID, int TourCatID, int DurationID)
        {
            return objTourDAL.Search(DesID, TourTypeID, TourCatID, DurationID);
        }
    }

}
