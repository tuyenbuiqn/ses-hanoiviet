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
        WUserBL.PublicAccountSoapClient UBL = new WUserBL.PublicAccountSoapClient();



        WUserBL.UsersDO objUserDO = new WUserBL.UsersDO();

		#endregion
		
        #region Public Constructors
        public UsersBL()
        {
            //
            // TODO: Add constructor logic here
            //
            UBL = new WUserBL.PublicAccountSoapClient();
        }
        #endregion       

        #region Public Methods
        public int Insert(WUserBL.UsersDO objUsersDO)
        {
            return UBL.Insert(objUsersDO);
        }

        public int Update(WUserBL.UsersDO objUsersDO)
        {
            return UBL.Update(objUsersDO);

        }

        public int Delete(WUserBL.UsersDO objUsersDO)
        {
            return UBL.Delete(objUsersDO);

        }

         public int DeleteAll()
        {
            return UBL.DeleteAll();
        }

         public WUserBL.UsersDO Select(WUserBL.UsersDO objUsersDO)
        {
            return UBL.Select(objUsersDO);
        }

       
        
        public DataTable SelectAll( )
        {
            return UBL.SelectAll();
        }


     
#endregion          
    
    
        public WUserBL.UsersDO SelectLogin(WUserBL.UsersDO objUsersDO)
        {
            return UBL.SelectLogin(objUsersDO);
        }
    }

}
