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
/// Summary description for ContactBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class ContactBL 
    {
    	#region Private Variables
		ContactDAL objContactDAL;
		#endregion
		
        #region Public Constructors
        public ContactBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objContactDAL=new ContactDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ContactDO objContactDO)
        {
            return objContactDAL.Insert(objContactDO);
        }

        public int Update(ContactDO objContactDO)
        {
             return objContactDAL.Update(objContactDO);

        }

        public int Delete(ContactDO objContactDO)
        {
             return objContactDAL.Delete(objContactDO);

        }

         public int DeleteAll()
        {
             return objContactDAL.DeleteAll();
        }

        public ContactDO Select(ContactDO objContactDO)
        {
            return objContactDAL.Select(objContactDO);
        }

        public ArrayList SelectAll1( )
        {
         return objContactDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objContactDAL.SelectAll();
        }


     
#endregion          
    
    }

}
