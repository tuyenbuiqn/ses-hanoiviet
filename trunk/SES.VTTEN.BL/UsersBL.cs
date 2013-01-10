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
/// Summary description for UsersBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class UsersBL 
    {
    	#region Private Variables
		UsersDAL objUsersDAL;
		#endregion
		
        #region Public Constructors
        public UsersBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objUsersDAL=new UsersDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(UsersDO objUsersDO)
        {
            return objUsersDAL.Insert(objUsersDO);
        }

        public int Update(UsersDO objUsersDO)
        {
             return objUsersDAL.Update(objUsersDO);

        }

        public int Delete(UsersDO objUsersDO)
        {
             return objUsersDAL.Delete(objUsersDO);

        }

         public int DeleteAll()
        {
             return objUsersDAL.DeleteAll();
        }

        public UsersDO Select(UsersDO objUsersDO)
        {
            return objUsersDAL.Select(objUsersDO);
        }

        public ArrayList SelectAll1( )
        {
         return objUsersDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objUsersDAL.SelectAll();
        }


     
#endregion          
    
    
        public UsersDO SelectLogin(UsersDO objUser)
        {
            return objUsersDAL.SelectLogin(objUser);
        }
    }

}
