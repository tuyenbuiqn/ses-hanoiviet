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
/// Summary description for CustomTourBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class CustomTourBL 
    {
    	#region Private Variables
		CustomTourDAL objCustomTourDAL;
		#endregion
		
        #region Public Constructors
        public CustomTourBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objCustomTourDAL=new CustomTourDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(CustomTourDO objCustomTourDO)
        {
            return objCustomTourDAL.Insert(objCustomTourDO);
        }

        public int Update(CustomTourDO objCustomTourDO)
        {
             return objCustomTourDAL.Update(objCustomTourDO);

        }

        public int Delete(CustomTourDO objCustomTourDO)
        {
             return objCustomTourDAL.Delete(objCustomTourDO);

        }

         public int DeleteAll()
        {
             return objCustomTourDAL.DeleteAll();
        }

        public CustomTourDO Select(CustomTourDO objCustomTourDO)
        {
            return objCustomTourDAL.Select(objCustomTourDO);
        }

        public ArrayList SelectAll1( )
        {
         return objCustomTourDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objCustomTourDAL.SelectAll();
        }


     
#endregion          
    
    }

}
