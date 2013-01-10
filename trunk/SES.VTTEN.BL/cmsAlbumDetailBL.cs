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
/// Summary description for cmsAlbumDetailBL
/// </summary>
namespace SES.VTTEN.BL
{
    public class cmsAlbumDetailBL
    {
        #region Private Variables
        cmsAlbumDetailDAL objcmsAlbumDetailDAL;
        #endregion

        #region Public Constructors
        public cmsAlbumDetailBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objcmsAlbumDetailDAL = new cmsAlbumDetailDAL();
        }
        #endregion

        #region Public Methods
        public int Insert(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {
            return objcmsAlbumDetailDAL.Insert(objcmsAlbumDetailDO);
        }

        public int Update(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {
            return objcmsAlbumDetailDAL.Update(objcmsAlbumDetailDO);

        }

        public int Delete(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {
            return objcmsAlbumDetailDAL.Delete(objcmsAlbumDetailDO);

        }

        public int DeleteAll()
        {
            return objcmsAlbumDetailDAL.DeleteAll();
        }

        public cmsAlbumDetailDO Select(cmsAlbumDetailDO objcmsAlbumDetailDO)
        {
            return objcmsAlbumDetailDAL.Select(objcmsAlbumDetailDO);
        }

        public ArrayList SelectAll1()
        {
            return objcmsAlbumDetailDAL.SelectAll1();
        }

        public DataTable SelectAll()
        {
            return objcmsAlbumDetailDAL.SelectAll();
        }
        public DataTable SelectByAlbumID(int AlbumID)
        {
            return objcmsAlbumDetailDAL.SelectByAlbumID(AlbumID);
        }



        #endregion


        public DataTable SelectAllByType(int type)
        {
            return objcmsAlbumDetailDAL.SelectAllByType(type);
        }
    }

}
