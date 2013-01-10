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
/// Summary description for CustomerDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class CustomerDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public CustomerDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(CustomerDO objCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomer_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.CustomerName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Phone", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Phone;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Address", SqlDbType.NText);
Sqlparam.Value = objCustomerDO.Address;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Passport", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Passport;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IDCard", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.IDCard;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Email;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Yahoo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Yahoo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Skype", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Skype;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Gender", SqlDbType.Bit);
Sqlparam.Value = objCustomerDO.Gender;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Jobs", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Jobs;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@BirthDay", SqlDbType.DateTime);
if (objCustomerDO.BirthDay <= DateTime.MinValue)
    Sqlparam.Value = null;
            else
Sqlparam.Value = objCustomerDO.BirthDay;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Mobile", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Mobile;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@NationalID", SqlDbType.Int);
Sqlparam.Value = objCustomerDO.NationalID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerType", SqlDbType.Bit);
Sqlparam.Value = objCustomerDO.CustomerType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsAdult", SqlDbType.Bit);
Sqlparam.Value = objCustomerDO.IsAdult;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherInfo", SqlDbType.NText);
Sqlparam.Value = objCustomerDO.OtherInfo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherAnniversary", SqlDbType.DateTime);
if (objCustomerDO.OtherAnniversary <= DateTime.MinValue)
    Sqlparam.Value = null;
            else
Sqlparam.Value = objCustomerDO.OtherAnniversary;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AnniversaryInfo", SqlDbType.NText);
Sqlparam.Value = objCustomerDO.AnniversaryInfo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerCategoryID", SqlDbType.Int);
Sqlparam.Value = objCustomerDO.CustomerCategoryID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Fax", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Fax;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(CustomerDO objCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomer_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objCustomerDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.CustomerName;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Phone", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Phone;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Address", SqlDbType.NText);
Sqlparam.Value = objCustomerDO.Address;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Passport", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Passport;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IDCard", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.IDCard;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Email;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Yahoo", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Yahoo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Skype", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Skype;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Gender", SqlDbType.Bit);
Sqlparam.Value = objCustomerDO.Gender;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Jobs", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Jobs;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@BirthDay", SqlDbType.DateTime);
Sqlparam.Value = objCustomerDO.BirthDay;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Mobile", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Mobile;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@NationalID", SqlDbType.Int);
Sqlparam.Value = objCustomerDO.NationalID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerType", SqlDbType.Bit);
Sqlparam.Value = objCustomerDO.CustomerType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsAdult", SqlDbType.Bit);
Sqlparam.Value = objCustomerDO.IsAdult;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherInfo", SqlDbType.NText);
Sqlparam.Value = objCustomerDO.OtherInfo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@OtherAnniversary", SqlDbType.DateTime);
Sqlparam.Value = objCustomerDO.OtherAnniversary;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@AnniversaryInfo", SqlDbType.NText);
Sqlparam.Value = objCustomerDO.AnniversaryInfo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerCategoryID", SqlDbType.Int);
Sqlparam.Value = objCustomerDO.CustomerCategoryID;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@Fax", SqlDbType.NVarChar);
Sqlparam.Value = objCustomerDO.Fax;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(CustomerDO objCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomer_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objCustomerDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomer_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public CustomerDO Select(CustomerDO objCustomerDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomer_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objCustomerDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["CustomerID"]))
objCustomerDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["CustomerName"]))
objCustomerDO.CustomerName=Convert.ToString(dr["CustomerName"]);
if(!Convert.IsDBNull(dr["Phone"]))
objCustomerDO.Phone=Convert.ToString(dr["Phone"]);
if(!Convert.IsDBNull(dr["Address"]))
objCustomerDO.Address=Convert.ToString(dr["Address"]);
if(!Convert.IsDBNull(dr["Passport"]))
objCustomerDO.Passport=Convert.ToString(dr["Passport"]);
if(!Convert.IsDBNull(dr["IDCard"]))
objCustomerDO.IDCard=Convert.ToString(dr["IDCard"]);
if(!Convert.IsDBNull(dr["Email"]))
objCustomerDO.Email=Convert.ToString(dr["Email"]);
if(!Convert.IsDBNull(dr["Yahoo"]))
objCustomerDO.Yahoo=Convert.ToString(dr["Yahoo"]);
if(!Convert.IsDBNull(dr["Skype"]))
objCustomerDO.Skype=Convert.ToString(dr["Skype"]);
if(!Convert.IsDBNull(dr["Gender"]))
objCustomerDO.Gender=Convert.ToBoolean(dr["Gender"]);
if(!Convert.IsDBNull(dr["Jobs"]))
objCustomerDO.Jobs=Convert.ToString(dr["Jobs"]);
if(!Convert.IsDBNull(dr["BirthDay"]))
objCustomerDO.BirthDay=Convert.ToDateTime(dr["BirthDay"]);
if(!Convert.IsDBNull(dr["Mobile"]))
objCustomerDO.Mobile=Convert.ToString(dr["Mobile"]);
if(!Convert.IsDBNull(dr["NationalID"]))
objCustomerDO.NationalID=Convert.ToInt32(dr["NationalID"]);
if(!Convert.IsDBNull(dr["CustomerType"]))
objCustomerDO.CustomerType=Convert.ToBoolean(dr["CustomerType"]);
if(!Convert.IsDBNull(dr["IsAdult"]))
objCustomerDO.IsAdult=Convert.ToBoolean(dr["IsAdult"]);
if(!Convert.IsDBNull(dr["OtherInfo"]))
objCustomerDO.OtherInfo=Convert.ToString(dr["OtherInfo"]);
if(!Convert.IsDBNull(dr["OtherAnniversary"]))
objCustomerDO.OtherAnniversary=Convert.ToDateTime(dr["OtherAnniversary"]);
if(!Convert.IsDBNull(dr["AnniversaryInfo"]))
objCustomerDO.AnniversaryInfo=Convert.ToString(dr["AnniversaryInfo"]);
if(!Convert.IsDBNull(dr["CustomerCategoryID"]))
objCustomerDO.CustomerCategoryID=Convert.ToInt32(dr["CustomerCategoryID"]);
if (!Convert.IsDBNull(dr["Title"]))
    objCustomerDO.Title = Convert.ToString(dr["Title"]);
if (!Convert.IsDBNull(dr["Fax"]))
    objCustomerDO.Fax = Convert.ToString(dr["Fax"]);

            }
             return objCustomerDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomer_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrCustomerDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
CustomerDO objCustomerDO= new CustomerDO();
if(!Convert.IsDBNull(dr["CustomerID"]))
objCustomerDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["CustomerName"]))
objCustomerDO.CustomerName=Convert.ToString(dr["CustomerName"]);
if(!Convert.IsDBNull(dr["Phone"]))
objCustomerDO.Phone=Convert.ToString(dr["Phone"]);
if(!Convert.IsDBNull(dr["Address"]))
objCustomerDO.Address=Convert.ToString(dr["Address"]);
if(!Convert.IsDBNull(dr["Passport"]))
objCustomerDO.Passport=Convert.ToString(dr["Passport"]);
if(!Convert.IsDBNull(dr["IDCard"]))
objCustomerDO.IDCard=Convert.ToString(dr["IDCard"]);
if(!Convert.IsDBNull(dr["Email"]))
objCustomerDO.Email=Convert.ToString(dr["Email"]);
if(!Convert.IsDBNull(dr["Yahoo"]))
objCustomerDO.Yahoo=Convert.ToString(dr["Yahoo"]);
if(!Convert.IsDBNull(dr["Skype"]))
objCustomerDO.Skype=Convert.ToString(dr["Skype"]);
if(!Convert.IsDBNull(dr["Gender"]))
objCustomerDO.Gender=Convert.ToBoolean(dr["Gender"]);
if(!Convert.IsDBNull(dr["Jobs"]))
objCustomerDO.Jobs=Convert.ToString(dr["Jobs"]);
if(!Convert.IsDBNull(dr["BirthDay"]))
objCustomerDO.BirthDay=Convert.ToDateTime(dr["BirthDay"]);
if(!Convert.IsDBNull(dr["Mobile"]))
objCustomerDO.Mobile=Convert.ToString(dr["Mobile"]);
if(!Convert.IsDBNull(dr["NationalID"]))
objCustomerDO.NationalID=Convert.ToInt32(dr["NationalID"]);
if(!Convert.IsDBNull(dr["CustomerType"]))
objCustomerDO.CustomerType=Convert.ToBoolean(dr["CustomerType"]);
if(!Convert.IsDBNull(dr["IsAdult"]))
objCustomerDO.IsAdult=Convert.ToBoolean(dr["IsAdult"]);
if(!Convert.IsDBNull(dr["OtherInfo"]))
objCustomerDO.OtherInfo=Convert.ToString(dr["OtherInfo"]);
if(!Convert.IsDBNull(dr["OtherAnniversary"]))
objCustomerDO.OtherAnniversary=Convert.ToDateTime(dr["OtherAnniversary"]);
if(!Convert.IsDBNull(dr["AnniversaryInfo"]))
objCustomerDO.AnniversaryInfo=Convert.ToString(dr["AnniversaryInfo"]);
if(!Convert.IsDBNull(dr["CustomerCategoryID"]))
objCustomerDO.CustomerCategoryID=Convert.ToInt32(dr["CustomerCategoryID"]);
if (!Convert.IsDBNull(dr["Title"]))
    objCustomerDO.AnniversaryInfo = Convert.ToString(dr["Title"]);
if (!Convert.IsDBNull(dr["Fax"]))
    objCustomerDO.Fax = Convert.ToString(dr["Fax"]);
arrCustomerDO.Add(objCustomerDO);
}
            }
               return arrCustomerDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomer_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectbyBooking(int p)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomer_GetbyBooking";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourBookingID", SqlDbType.Int);
            Sqlparam.Value = p;
            Sqlcomm.Parameters.Add(Sqlparam);
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public DataTable SelectBooking(int TourBookingID, int CustomerID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomer_GetBooking";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourBookingID", SqlDbType.Int);
            Sqlparam.Value = TourBookingID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
            Sqlparam.Value = CustomerID;
            Sqlcomm.Parameters.Add(Sqlparam);
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }
    }

}
