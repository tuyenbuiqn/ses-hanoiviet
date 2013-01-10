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
/// Summary description for ContentTypeBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class ContentTypeBL 
    {
    	#region Private Variables
		ContentTypeDAL objContentTypeDAL;
		#endregion
		
        #region Public Constructors
        public ContentTypeBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objContentTypeDAL=new ContentTypeDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ContentTypeDO objContentTypeDO)
        {
            return objContentTypeDAL.Insert(objContentTypeDO);
        }

        public int Update(ContentTypeDO objContentTypeDO)
        {
             return objContentTypeDAL.Update(objContentTypeDO);

        }

        public int Delete(ContentTypeDO objContentTypeDO)
        {
             return objContentTypeDAL.Delete(objContentTypeDO);

        }

         public int DeleteAll()
        {
             return objContentTypeDAL.DeleteAll();
        }

        public ContentTypeDO Select(ContentTypeDO objContentTypeDO)
        {
            return objContentTypeDAL.Select(objContentTypeDO);
        }

        public ArrayList SelectAll1( )
        {
         return objContentTypeDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objContentTypeDAL.SelectAll();
        }


     
#endregion          
    
    }

}
