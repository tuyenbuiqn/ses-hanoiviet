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
/// Summary description for GroupsBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class GroupsBL 
    {
    	#region Private Variables
		GroupsDAL objGroupsDAL;
		#endregion
		
        #region Public Constructors
        public GroupsBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objGroupsDAL=new GroupsDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(GroupsDO objGroupsDO)
        {
            return objGroupsDAL.Insert(objGroupsDO);
        }

        public int Update(GroupsDO objGroupsDO)
        {
             return objGroupsDAL.Update(objGroupsDO);

        }

        public int Delete(GroupsDO objGroupsDO)
        {
             return objGroupsDAL.Delete(objGroupsDO);

        }

         public int DeleteAll()
        {
             return objGroupsDAL.DeleteAll();
        }

        public GroupsDO Select(GroupsDO objGroupsDO)
        {
            return objGroupsDAL.Select(objGroupsDO);
        }

        public ArrayList SelectAll1( )
        {
         return objGroupsDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objGroupsDAL.SelectAll();
        }


     
#endregion          
    
    }

}
