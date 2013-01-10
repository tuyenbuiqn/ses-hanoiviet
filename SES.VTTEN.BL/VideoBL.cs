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
/// Summary description for VideoBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class VideoBL 
    {
    	#region Private Variables
		VideoDAL objVideoDAL;
		#endregion
		
        #region Public Constructors
        public VideoBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objVideoDAL=new VideoDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(VideoDO objVideoDO)
        {
            return objVideoDAL.Insert(objVideoDO);
        }

        public int Update(VideoDO objVideoDO)
        {
             return objVideoDAL.Update(objVideoDO);

        }

        public int Delete(VideoDO objVideoDO)
        {
             return objVideoDAL.Delete(objVideoDO);

        }

         public int DeleteAll()
        {
             return objVideoDAL.DeleteAll();
        }

        public VideoDO Select(VideoDO objVideoDO)
        {
            return objVideoDAL.Select(objVideoDO);
        }

        public ArrayList SelectAll1( )
        {
         return objVideoDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objVideoDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable SelectFirst()
        {
            return objVideoDAL.SelectFirst();
        }

        public DataTable SelectTop()
        {
            return objVideoDAL.SelectTop();
        }

        public DataTable SelectbyModule(int p)
        {
            return objVideoDAL.SelectbyModule(p);
        }
    }

}
