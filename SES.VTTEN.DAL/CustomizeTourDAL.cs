/*
  Copyright 2009 Smart Enterprise Solution Corp.
  Email: contact@ses.vn - Website: http://www.ses.vn
  KimNgan Project.
*/
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using SES.VTTEN.DO;
/// <summary>
/// Summary description for CustomizeTourDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class CustomizeTourDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public CustomizeTourDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(CustomizeTourDO objCustomizeTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomizeTour_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CusDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.CusDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@FullName", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.FullName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Gender", SqlDbType.Bit);
Sqlparam.Value = objCustomizeTourDO.Gender;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateOfBirth", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.DateOfBirth;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Email;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Country", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Country;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Address", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Address;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PhoneNo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.PhoneNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@FaxNo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.FaxNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArrivalDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.ArrivalDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DepartureDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.DepartureDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultNo", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.AdultNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildNo", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.ChildNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelCat", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.HotelCat;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Transport", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Transport;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourProgramme", SqlDbType.NText);
Sqlparam.Value = objCustomizeTourDO.TourProgramme;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Accommodation", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Accommodation;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Meals", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Meals;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Food", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Food;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@BillingOption", SqlDbType.Bit);
Sqlparam.Value = objCustomizeTourDO.BillingOption;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherRequest", SqlDbType.NText);
Sqlparam.Value = objCustomizeTourDO.OtherRequest;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@InformationSource", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.InformationSource;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PlaceToVisit", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.PlaceToVisit;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(CustomizeTourDO objCustomizeTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomizeTour_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomizeTourID", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.CustomizeTourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CusDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.CusDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@FullName", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.FullName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Gender", SqlDbType.Bit);
Sqlparam.Value = objCustomizeTourDO.Gender;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DateOfBirth", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.DateOfBirth;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Email;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Country", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Country;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Address", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Address;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PhoneNo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.PhoneNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@FaxNo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.FaxNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ArrivalDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.ArrivalDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DepartureDate", SqlDbType.DateTime);
Sqlparam.Value = objCustomizeTourDO.DepartureDate;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AdultNo", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.AdultNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ChildNo", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.ChildNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelCat", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.HotelCat;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Transport", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Transport;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourProgramme", SqlDbType.NText);
Sqlparam.Value = objCustomizeTourDO.TourProgramme;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Accommodation", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Accommodation;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Meals", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Meals;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Food", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.Food;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@BillingOption", SqlDbType.Bit);
Sqlparam.Value = objCustomizeTourDO.BillingOption;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherRequest", SqlDbType.NText);
Sqlparam.Value = objCustomizeTourDO.OtherRequest;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@InformationSource", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.InformationSource;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@PlaceToVisit", SqlDbType.NVarChar);
Sqlparam.Value = objCustomizeTourDO.PlaceToVisit;
Sqlcomm.Parameters.Add(Sqlparam);



            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(CustomizeTourDO objCustomizeTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomizeTour_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CustomizeTourID", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.CustomizeTourID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomizeTour_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public CustomizeTourDO Select(CustomizeTourDO objCustomizeTourDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomizeTour_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@CustomizeTourID", SqlDbType.Int);
Sqlparam.Value = objCustomizeTourDO.CustomizeTourID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["CustomizeTourID"]))
objCustomizeTourDO.CustomizeTourID=Convert.ToInt32(dr["CustomizeTourID"]);
if(!Convert.IsDBNull(dr["CusDate"]))
objCustomizeTourDO.CusDate=Convert.ToDateTime(dr["CusDate"]);
if(!Convert.IsDBNull(dr["FullName"]))
objCustomizeTourDO.FullName=Convert.ToString(dr["FullName"]);
if(!Convert.IsDBNull(dr["Gender"]))
objCustomizeTourDO.Gender=Convert.ToBoolean(dr["Gender"]);
if(!Convert.IsDBNull(dr["DateOfBirth"]))
objCustomizeTourDO.DateOfBirth=Convert.ToDateTime(dr["DateOfBirth"]);
if(!Convert.IsDBNull(dr["Email"]))
objCustomizeTourDO.Email=Convert.ToString(dr["Email"]);
if(!Convert.IsDBNull(dr["Country"]))
objCustomizeTourDO.Country=Convert.ToString(dr["Country"]);
if(!Convert.IsDBNull(dr["Address"]))
objCustomizeTourDO.Address=Convert.ToString(dr["Address"]);
if(!Convert.IsDBNull(dr["PhoneNo"]))
objCustomizeTourDO.PhoneNo=Convert.ToString(dr["PhoneNo"]);
if(!Convert.IsDBNull(dr["FaxNo"]))
objCustomizeTourDO.FaxNo=Convert.ToString(dr["FaxNo"]);
if(!Convert.IsDBNull(dr["ArrivalDate"]))
objCustomizeTourDO.ArrivalDate=Convert.ToDateTime(dr["ArrivalDate"]);
if(!Convert.IsDBNull(dr["DepartureDate"]))
objCustomizeTourDO.DepartureDate=Convert.ToDateTime(dr["DepartureDate"]);
if(!Convert.IsDBNull(dr["AdultNo"]))
objCustomizeTourDO.AdultNo=Convert.ToInt32(dr["AdultNo"]);
if(!Convert.IsDBNull(dr["ChildNo"]))
objCustomizeTourDO.ChildNo=Convert.ToInt32(dr["ChildNo"]);
if(!Convert.IsDBNull(dr["HotelCat"]))
objCustomizeTourDO.HotelCat=Convert.ToInt32(dr["HotelCat"]);
if(!Convert.IsDBNull(dr["Transport"]))
objCustomizeTourDO.Transport=Convert.ToString(dr["Transport"]);
if(!Convert.IsDBNull(dr["TourProgramme"]))
objCustomizeTourDO.TourProgramme=Convert.ToString(dr["TourProgramme"]);
if(!Convert.IsDBNull(dr["Accommodation"]))
objCustomizeTourDO.Accommodation=Convert.ToString(dr["Accommodation"]);
if(!Convert.IsDBNull(dr["Meals"]))
objCustomizeTourDO.Meals=Convert.ToString(dr["Meals"]);
if(!Convert.IsDBNull(dr["Food"]))
objCustomizeTourDO.Food=Convert.ToString(dr["Food"]);
if(!Convert.IsDBNull(dr["BillingOption"]))
objCustomizeTourDO.BillingOption=Convert.ToBoolean(dr["BillingOption"]);
if(!Convert.IsDBNull(dr["OtherRequest"]))
objCustomizeTourDO.OtherRequest=Convert.ToString(dr["OtherRequest"]);
if(!Convert.IsDBNull(dr["InformationSource"]))
objCustomizeTourDO.InformationSource=Convert.ToString(dr["InformationSource"]);
if (!Convert.IsDBNull(dr["PlaceToVisit"]))
    objCustomizeTourDO.PlaceToVisit = Convert.ToString(dr["PlaceToVisit"]);
            }
             return objCustomizeTourDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomizeTour_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrCustomizeTourDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
CustomizeTourDO objCustomizeTourDO= new CustomizeTourDO();
if(!Convert.IsDBNull(dr["CustomizeTourID"]))
objCustomizeTourDO.CustomizeTourID=Convert.ToInt32(dr["CustomizeTourID"]);
if(!Convert.IsDBNull(dr["CusDate"]))
objCustomizeTourDO.CusDate=Convert.ToDateTime(dr["CusDate"]);
if(!Convert.IsDBNull(dr["FullName"]))
objCustomizeTourDO.FullName=Convert.ToString(dr["FullName"]);
if(!Convert.IsDBNull(dr["Gender"]))
objCustomizeTourDO.Gender=Convert.ToBoolean(dr["Gender"]);
if(!Convert.IsDBNull(dr["DateOfBirth"]))
objCustomizeTourDO.DateOfBirth=Convert.ToDateTime(dr["DateOfBirth"]);
if(!Convert.IsDBNull(dr["Email"]))
objCustomizeTourDO.Email=Convert.ToString(dr["Email"]);
if(!Convert.IsDBNull(dr["Country"]))
objCustomizeTourDO.Country=Convert.ToString(dr["Country"]);
if(!Convert.IsDBNull(dr["Address"]))
objCustomizeTourDO.Address=Convert.ToString(dr["Address"]);
if(!Convert.IsDBNull(dr["PhoneNo"]))
objCustomizeTourDO.PhoneNo=Convert.ToString(dr["PhoneNo"]);
if(!Convert.IsDBNull(dr["FaxNo"]))
objCustomizeTourDO.FaxNo=Convert.ToString(dr["FaxNo"]);
if(!Convert.IsDBNull(dr["ArrivalDate"]))
objCustomizeTourDO.ArrivalDate=Convert.ToDateTime(dr["ArrivalDate"]);
if(!Convert.IsDBNull(dr["DepartureDate"]))
objCustomizeTourDO.DepartureDate=Convert.ToDateTime(dr["DepartureDate"]);
if(!Convert.IsDBNull(dr["AdultNo"]))
objCustomizeTourDO.AdultNo=Convert.ToInt32(dr["AdultNo"]);
if(!Convert.IsDBNull(dr["ChildNo"]))
objCustomizeTourDO.ChildNo=Convert.ToInt32(dr["ChildNo"]);
if(!Convert.IsDBNull(dr["HotelCat"]))
objCustomizeTourDO.HotelCat=Convert.ToInt32(dr["HotelCat"]);
if(!Convert.IsDBNull(dr["Transport"]))
objCustomizeTourDO.Transport=Convert.ToString(dr["Transport"]);
if(!Convert.IsDBNull(dr["TourProgramme"]))
objCustomizeTourDO.TourProgramme=Convert.ToString(dr["TourProgramme"]);
if(!Convert.IsDBNull(dr["Accommodation"]))
objCustomizeTourDO.Accommodation=Convert.ToString(dr["Accommodation"]);
if(!Convert.IsDBNull(dr["Meals"]))
objCustomizeTourDO.Meals=Convert.ToString(dr["Meals"]);
if(!Convert.IsDBNull(dr["Food"]))
objCustomizeTourDO.Food=Convert.ToString(dr["Food"]);
if(!Convert.IsDBNull(dr["BillingOption"]))
objCustomizeTourDO.BillingOption=Convert.ToBoolean(dr["BillingOption"]);
if(!Convert.IsDBNull(dr["OtherRequest"]))
objCustomizeTourDO.OtherRequest=Convert.ToString(dr["OtherRequest"]);
if(!Convert.IsDBNull(dr["InformationSource"]))
objCustomizeTourDO.InformationSource=Convert.ToString(dr["InformationSource"]);
if (!Convert.IsDBNull(dr["PlaceToVisit"]))
    objCustomizeTourDO.PlaceToVisit = Convert.ToString(dr["PlaceToVisit"]);
arrCustomizeTourDO.Add(objCustomizeTourDO);
}
            }
               return arrCustomizeTourDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomizeTour_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    }

}
