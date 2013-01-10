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
/// Summary description for MediaBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class MediaBL 
    {
    	#region Private Variables
		MediaDAL objMediaDAL;
		#endregion
		
        #region Public Constructors
        public MediaBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objMediaDAL=new MediaDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(MediaDO objMediaDO)
        {
            return objMediaDAL.Insert(objMediaDO);
        }

        public int Update(MediaDO objMediaDO)
        {
             return objMediaDAL.Update(objMediaDO);

        }

        public int Delete(MediaDO objMediaDO)
        {
             return objMediaDAL.Delete(objMediaDO);

        }

         public int DeleteAll()
        {
             return objMediaDAL.DeleteAll();
        }

        public MediaDO Select(MediaDO objMediaDO)
        {
            return objMediaDAL.Select(objMediaDO);
        }

        public ArrayList SelectAll1( )
        {
         return objMediaDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objMediaDAL.SelectAll();
        }


     
#endregion          
    
    
    
        public object SelectbyDestination(int p)
        {
            return objMediaDAL.SelectbyDestination(p);
        }

        public DataTable SelectFooter()
        {
            return objMediaDAL.SelectFooter();
        }

        public DataTable SelectLeft()
        {
            return objMediaDAL.SelectLeft();
        }

        public DataTable SelectRight()
        {
            return objMediaDAL.SelectRight();
        }

        public DataTable SelectByObject(string Object, int ID, int record)
        {
            return objMediaDAL.SelectByObject(Object, ID, record);
        }

        public DataTable SelectbyType()
        {
            return objMediaDAL.SelectbyType();
        }

        public bool SelectbyAlbum(int AlbumID, int MediaID)
        {
            return objMediaDAL.SelectbyAlbum(AlbumID, MediaID);
        }

        public DataTable SelectAlbum(int ID)
        {
            return objMediaDAL.SelectAlbum(ID);
        }
        public DataTable SelectByTourID(int tourID)
        {
            return objMediaDAL.SelectByTourID(tourID);
        }

        
    }

}
