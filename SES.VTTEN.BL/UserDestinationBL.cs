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
/// Summary description for UserDestinationBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class UserDestinationBL 
    {
    	#region Private Variables
		UserDestinationDAL objUserDestinationDAL;
		#endregion
		
        #region Public Constructors
        public UserDestinationBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objUserDestinationDAL=new UserDestinationDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(UserDestinationDO objUserDestinationDO)
        {
            return objUserDestinationDAL.Insert(objUserDestinationDO);
        }

        public int Update(UserDestinationDO objUserDestinationDO)
        {
             return objUserDestinationDAL.Update(objUserDestinationDO);

        }
        public int UpdateByUserID(UserDestinationDO objUserDestinationDO)
        {
            return objUserDestinationDAL.UpdateByUserID(objUserDestinationDO);
        }

        public int Delete(UserDestinationDO objUserDestinationDO)
        {
             return objUserDestinationDAL.Delete(objUserDestinationDO);

        }

         public int DeleteAll()
        {
             return objUserDestinationDAL.DeleteAll();
        }

        public UserDestinationDO Select(UserDestinationDO objUserDestinationDO)
        {
            return objUserDestinationDAL.Select(objUserDestinationDO);
        }

        public ArrayList SelectAll1( )
        {
         return objUserDestinationDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objUserDestinationDAL.SelectAll();
        }
        public DataTable GetEmailOfDestination(int type,int id)
        {
            return objUserDestinationDAL.GetEmailOfDestination(type,id);
        }

        public DataTable SelectByUserID(int userID)
        {
            return objUserDestinationDAL.SelectByUserID(userID);
        }
        public int DeleteByUserID(int userID)
        {
            return objUserDestinationDAL.DeleteByUserID(userID);
        }


     
#endregion          
    
    }

}
