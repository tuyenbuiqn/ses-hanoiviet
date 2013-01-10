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
/// Summary description for CustomizeTourBL
/// </summary>
namespace SES.VTTEN.BL 
{
    public class CustomizeTourBL 
    {
    	#region Private Variables
		CustomizeTourDAL objCustomizeTourDAL;
		#endregion
		
        #region Public Constructors
        public CustomizeTourBL()
        {
            //
            // TODO: Add constructor logic here
            //
            objCustomizeTourDAL=new CustomizeTourDAL();
        }
        #endregion       

        #region Public Methods
        public int Insert(CustomizeTourDO objCustomizeTourDO)
        {
            return objCustomizeTourDAL.Insert(objCustomizeTourDO);
        }

        public int Update(CustomizeTourDO objCustomizeTourDO)
        {
             return objCustomizeTourDAL.Update(objCustomizeTourDO);

        }

        public int Delete(CustomizeTourDO objCustomizeTourDO)
        {
             return objCustomizeTourDAL.Delete(objCustomizeTourDO);

        }

         public int DeleteAll()
        {
             return objCustomizeTourDAL.DeleteAll();
        }

        public CustomizeTourDO Select(CustomizeTourDO objCustomizeTourDO)
        {
            return objCustomizeTourDAL.Select(objCustomizeTourDO);
        }

        public ArrayList SelectAll1( )
        {
         return objCustomizeTourDAL.SelectAll1();
        }
        
        public DataTable SelectAll( )
        {
         return objCustomizeTourDAL.SelectAll();
        }


     
#endregion          
    
    }

}
