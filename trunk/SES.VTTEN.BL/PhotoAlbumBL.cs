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
/// Summary description for PhotoAlbumBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class PhotoAlbumBL 
    {
    	#region Private Variables
		PhotoAlbumDAL objPhotoAlbumDAL;
		#endregion
		
        #region Public Constructors
        public PhotoAlbumBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objPhotoAlbumDAL=new PhotoAlbumDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(PhotoAlbumDO objPhotoAlbumDO)
        {
            return objPhotoAlbumDAL.Insert(objPhotoAlbumDO);
        }

        public int Update(PhotoAlbumDO objPhotoAlbumDO)
        {
             return objPhotoAlbumDAL.Update(objPhotoAlbumDO);

        }

        public int Delete(PhotoAlbumDO objPhotoAlbumDO)
        {
             return objPhotoAlbumDAL.Delete(objPhotoAlbumDO);

        }

         public int DeleteAll()
        {
             return objPhotoAlbumDAL.DeleteAll();
        }

        public PhotoAlbumDO Select(PhotoAlbumDO objPhotoAlbumDO)
        {
            return objPhotoAlbumDAL.Select(objPhotoAlbumDO);
        }

        public ArrayList SelectAll1( )
        {
         return objPhotoAlbumDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objPhotoAlbumDAL.SelectAll();
        }


     
#endregion          
    
    }

}
