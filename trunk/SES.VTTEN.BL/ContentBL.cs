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
/// Summary description for ContentBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class ContentBL 
    {
    	#region Private Variables
		ContentDAL objContentDAL;
		#endregion
		
        #region Public Constructors
        public ContentBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objContentDAL=new ContentDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ContentDO objContentDO)
        {
            return objContentDAL.Insert(objContentDO);
        }

        public int Update(ContentDO objContentDO)
        {
             return objContentDAL.Update(objContentDO);

        }

        public int Delete(ContentDO objContentDO)
        {
             return objContentDAL.Delete(objContentDO);

        }

         public int DeleteAll()
        {
             return objContentDAL.DeleteAll();
        }

        public ContentDO Select(ContentDO objContentDO)
        {
            return objContentDAL.Select(objContentDO);
        }

        public ArrayList SelectAll1( )
        {
         return objContentDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objContentDAL.SelectAll();
        }


     
#endregion          
    
    
     
        public DataTable SelectNumberType(int number, int type)
        {
            return objContentDAL.SelectNumberType(number, type);
        }
    }

}
