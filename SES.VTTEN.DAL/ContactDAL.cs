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
/// Summary description for ContactDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class ContactDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public ContactDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(ContactDO objContactDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContact_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objContactDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objContactDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(ContactDO objContactDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContact_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@ContactID", SqlDbType.Int);
Sqlparam.Value = objContactDO.ContactID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomerID", SqlDbType.Int);
Sqlparam.Value = objContactDO.CustomerID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objContactDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(ContactDO objContactDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContact_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@ContactID", SqlDbType.Int);
Sqlparam.Value = objContactDO.ContactID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContact_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public ContactDO Select(ContactDO objContactDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContact_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@ContactID", SqlDbType.Int);
Sqlparam.Value = objContactDO.ContactID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["ContactID"]))
objContactDO.ContactID=Convert.ToInt32(dr["ContactID"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objContactDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["Detail"]))
objContactDO.Detail=Convert.ToString(dr["Detail"]);

            }
             return objContactDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContact_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrContactDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
ContactDO objContactDO= new ContactDO();
if(!Convert.IsDBNull(dr["ContactID"]))
objContactDO.ContactID=Convert.ToInt32(dr["ContactID"]);
if(!Convert.IsDBNull(dr["CustomerID"]))
objContactDO.CustomerID=Convert.ToInt32(dr["CustomerID"]);
if(!Convert.IsDBNull(dr["Detail"]))
objContactDO.Detail=Convert.ToString(dr["Detail"]);
arrContactDO.Add(objContactDO);
}
            }
               return arrContactDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spContact_GetAll";
            
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
