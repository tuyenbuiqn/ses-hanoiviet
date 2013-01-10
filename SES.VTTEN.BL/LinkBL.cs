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
/// Summary description for LinkBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class LinkBL 
    {
    	#region Private Variables
		LinkDAL objLinkDAL;
		#endregion
		
        #region Public Constructors
        public LinkBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objLinkDAL=new LinkDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(LinkDO objLinkDO)
        {
            return objLinkDAL.Insert(objLinkDO);
        }

        public int Update(LinkDO objLinkDO)
        {
             return objLinkDAL.Update(objLinkDO);

        }

        public int Delete(LinkDO objLinkDO)
        {
             return objLinkDAL.Delete(objLinkDO);

        }

         public int DeleteAll()
        {
             return objLinkDAL.DeleteAll();
        }

        public LinkDO Select(LinkDO objLinkDO)
        {
            return objLinkDAL.Select(objLinkDO);
        }

        public ArrayList SelectAll1( )
        {
         return objLinkDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objLinkDAL.SelectAll();
        }


     
#endregion          
    
    
        public DataTable Select1()
        {
            return objLinkDAL.Select1();
        }
    }

}
