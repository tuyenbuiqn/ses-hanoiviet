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
/// Summary description for CustomtourDestinationBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class CustomtourDestinationBL 
    {
    	#region Private Variables
		CustomtourDestinationDAL objCustomtourDestinationDAL;
		#endregion
		
        #region Public Constructors
        public CustomtourDestinationBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objCustomtourDestinationDAL=new CustomtourDestinationDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(CustomtourDestinationDO objCustomtourDestinationDO)
        {
            return objCustomtourDestinationDAL.Insert(objCustomtourDestinationDO);
        }

        public int Update(CustomtourDestinationDO objCustomtourDestinationDO)
        {
             return objCustomtourDestinationDAL.Update(objCustomtourDestinationDO);

        }

        public int Delete(CustomtourDestinationDO objCustomtourDestinationDO)
        {
             return objCustomtourDestinationDAL.Delete(objCustomtourDestinationDO);

        }

         public int DeleteAll()
        {
             return objCustomtourDestinationDAL.DeleteAll();
        }

        public CustomtourDestinationDO Select(CustomtourDestinationDO objCustomtourDestinationDO)
        {
            return objCustomtourDestinationDAL.Select(objCustomtourDestinationDO);
        }

        public ArrayList SelectAll1( )
        {
         return objCustomtourDestinationDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objCustomtourDestinationDAL.SelectAll();
        }


     
#endregion          
    
    
        public bool Select1(int CustomTourID, int DestinationID)
        {
            return objCustomtourDestinationDAL.Select1(CustomTourID, DestinationID);
        }
    }

}
