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
/// Summary description for NewsBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class NewsBL 
    {
    	#region Private Variables
		NewsDAL objNewsDAL;
		#endregion
		
        #region Public Constructors
        public NewsBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objNewsDAL=new NewsDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(NewsDO objNewsDO)
        {
            return objNewsDAL.Insert(objNewsDO);
        }

        public int Update(NewsDO objNewsDO)
        {
             return objNewsDAL.Update(objNewsDO);

        }

        public int Delete(NewsDO objNewsDO)
        {
             return objNewsDAL.Delete(objNewsDO);

        }

         public int DeleteAll()
        {
             return objNewsDAL.DeleteAll();
        }

        public NewsDO Select(NewsDO objNewsDO)
        {
            return objNewsDAL.Select(objNewsDO);
        }

        public ArrayList SelectAll1( )
        {
         return objNewsDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objNewsDAL.SelectAll();
        }


     
#endregion          
    
    
        public NewsDO SelectFirst()
        {
            return objNewsDAL.SelectFirst();
        }

        public DataTable SelectbyNumber()
        {
            return objNewsDAL.SelectbyNumber();
        }
        public DataTable SelectTopNews(int top)
        {
            return objNewsDAL.SelectTopNews(top);
        }

        public DataTable SelectNewsIsFrontPage(int top)
        {
            return objNewsDAL.SelectNewsIsFrontPage(top);
        }

        public DataTable SelectNewsByModulID(int ModulID)
        {
            return objNewsDAL.SelectNewsByModulID(ModulID);
        }
    }

}
