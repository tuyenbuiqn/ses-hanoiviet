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
/// Summary description for ChatContentBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class ChatContentBL 
    {
    	#region Private Variables
		ChatContentDAL objChatContentDAL;
		#endregion
		
        #region Public Constructors
        public ChatContentBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objChatContentDAL=new ChatContentDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(ChatContentDO objChatContentDO)
        {
            return objChatContentDAL.Insert(objChatContentDO);
        }

        public int Update(ChatContentDO objChatContentDO)
        {
             return objChatContentDAL.Update(objChatContentDO);

        }

        public int Delete(ChatContentDO objChatContentDO)
        {
             return objChatContentDAL.Delete(objChatContentDO);

        }

         public int DeleteAll()
        {
             return objChatContentDAL.DeleteAll();
        }

        public ChatContentDO Select(ChatContentDO objChatContentDO)
        {
            return objChatContentDAL.Select(objChatContentDO);
        }

        public ArrayList SelectAll1( )
        {
         return objChatContentDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objChatContentDAL.SelectAll();
        }


     
#endregion          
    
    }

}
