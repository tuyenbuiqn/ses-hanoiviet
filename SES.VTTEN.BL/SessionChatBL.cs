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
/// Summary description for SessionChatBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class SessionChatBL 
    {
    	#region Private Variables
		SessionChatDAL objSessionChatDAL;
		#endregion
		
        #region Public Constructors
        public SessionChatBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objSessionChatDAL=new SessionChatDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(SessionChatDO objSessionChatDO)
        {
            return objSessionChatDAL.Insert(objSessionChatDO);
        }

        public int Update(SessionChatDO objSessionChatDO)
        {
             return objSessionChatDAL.Update(objSessionChatDO);

        }

        public int Delete(SessionChatDO objSessionChatDO)
        {
             return objSessionChatDAL.Delete(objSessionChatDO);

        }

         public int DeleteAll()
        {
             return objSessionChatDAL.DeleteAll();
        }

        public SessionChatDO Select(SessionChatDO objSessionChatDO)
        {
            return objSessionChatDAL.Select(objSessionChatDO);
        }

        public ArrayList SelectAll1( )
        {
         return objSessionChatDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objSessionChatDAL.SelectAll();
        }


     
#endregion          
    
    }

}
