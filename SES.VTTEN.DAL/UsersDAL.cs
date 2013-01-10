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
/// Summary description for UsersDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class UsersDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public UsersDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(UsersDO objUsersDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spUsers_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Username", SqlDbType.NVarChar);
Sqlparam.Value = objUsersDO.Username;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Pasword", SqlDbType.NVarChar);
Sqlparam.Value = objUsersDO.Pasword;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
Sqlparam.Value = objUsersDO.Email;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsAdmin", SqlDbType.Bit);
Sqlparam.Value = objUsersDO.IsAdmin;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsActive", SqlDbType.Bit);
Sqlparam.Value = objUsersDO.IsActive;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsSuportOnline", SqlDbType.Bit);
Sqlparam.Value = objUsersDO.IsSuportOnline;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@GroupID", SqlDbType.Int);
Sqlparam.Value = objUsersDO.GroupID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(UsersDO objUsersDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spUsers_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
Sqlparam.Value = objUsersDO.UserID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Username", SqlDbType.NVarChar);
Sqlparam.Value = objUsersDO.Username;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Pasword", SqlDbType.NVarChar);
Sqlparam.Value = objUsersDO.Pasword;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Email", SqlDbType.NVarChar);
Sqlparam.Value = objUsersDO.Email;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsAdmin", SqlDbType.Bit);
Sqlparam.Value = objUsersDO.IsAdmin;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsActive", SqlDbType.Bit);
Sqlparam.Value = objUsersDO.IsActive;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@IsSuportOnline", SqlDbType.Bit);
Sqlparam.Value = objUsersDO.IsSuportOnline;
Sqlcomm.Parameters.Add(Sqlparam);
Sqlparam = new SqlParameter("@GroupID", SqlDbType.Int);
Sqlparam.Value = objUsersDO.GroupID;
Sqlcomm.Parameters.Add(Sqlparam);



            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(UsersDO objUsersDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spUsers_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
Sqlparam.Value = objUsersDO.UserID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spUsers_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public UsersDO Select(UsersDO objUsersDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spUsers_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@UserID", SqlDbType.Int);
Sqlparam.Value = objUsersDO.UserID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["UserID"]))
objUsersDO.UserID=Convert.ToInt32(dr["UserID"]);
if(!Convert.IsDBNull(dr["Username"]))
objUsersDO.Username=Convert.ToString(dr["Username"]);
if(!Convert.IsDBNull(dr["Pasword"]))
objUsersDO.Pasword=Convert.ToString(dr["Pasword"]);
if(!Convert.IsDBNull(dr["Email"]))
objUsersDO.Email=Convert.ToString(dr["Email"]);
if(!Convert.IsDBNull(dr["IsAdmin"]))
objUsersDO.IsAdmin=Convert.ToBoolean(dr["IsAdmin"]);
if(!Convert.IsDBNull(dr["IsActive"]))
objUsersDO.IsActive=Convert.ToBoolean(dr["IsActive"]);
if(!Convert.IsDBNull(dr["IsSuportOnline"]))
objUsersDO.IsSuportOnline=Convert.ToBoolean(dr["IsSuportOnline"]);
if (!Convert.IsDBNull(dr["GroupID"]))
    objUsersDO.GroupID = Convert.ToInt32(dr["GroupID"]);

            }
             return objUsersDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spUsers_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrUsersDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
UsersDO objUsersDO= new UsersDO();
if(!Convert.IsDBNull(dr["UserID"]))
objUsersDO.UserID=Convert.ToInt32(dr["UserID"]);
if(!Convert.IsDBNull(dr["Username"]))
objUsersDO.Username=Convert.ToString(dr["Username"]);
if(!Convert.IsDBNull(dr["Pasword"]))
objUsersDO.Pasword=Convert.ToString(dr["Pasword"]);
if(!Convert.IsDBNull(dr["Email"]))
objUsersDO.Email=Convert.ToString(dr["Email"]);
if(!Convert.IsDBNull(dr["IsAdmin"]))
objUsersDO.IsAdmin=Convert.ToBoolean(dr["IsAdmin"]);
if(!Convert.IsDBNull(dr["IsActive"]))
objUsersDO.IsActive=Convert.ToBoolean(dr["IsActive"]);
if(!Convert.IsDBNull(dr["IsSuportOnline"]))
objUsersDO.IsSuportOnline=Convert.ToBoolean(dr["IsSuportOnline"]);
if (!Convert.IsDBNull(dr["GroupID"]))
    objUsersDO.GroupID = Convert.ToInt32(dr["GroupID"]);
arrUsersDO.Add(objUsersDO);
}
            }
               return arrUsersDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spUsers_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public UsersDO SelectLogin(UsersDO objUser)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spUsers_GetByUser";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@Username", SqlDbType.NVarChar);
            Sqlparam.Value = objUser.Username;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@Pasword", SqlDbType.NVarChar);
            Sqlparam.Value = objUser.Pasword;
            Sqlcomm.Parameters.Add(Sqlparam);


            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["UserID"]))
                    objUser.UserID = Convert.ToInt32(dr["UserID"]);
                if (!Convert.IsDBNull(dr["Username"]))
                    objUser.Username = Convert.ToString(dr["Username"]);
                if (!Convert.IsDBNull(dr["Pasword"]))
                    objUser.Pasword = Convert.ToString(dr["Pasword"]);
                if (!Convert.IsDBNull(dr["Email"]))
                    objUser.Email = Convert.ToString(dr["Email"]);
                if (!Convert.IsDBNull(dr["IsAdmin"]))
                    objUser.IsAdmin = Convert.ToBoolean(dr["IsAdmin"]);
                if (!Convert.IsDBNull(dr["IsActive"]))
                    objUser.IsActive = Convert.ToBoolean(dr["IsActive"]);
                if (!Convert.IsDBNull(dr["IsSuportOnline"]))
                    objUser.IsSuportOnline = Convert.ToBoolean(dr["IsSuportOnline"]);
                if (!Convert.IsDBNull(dr["GroupID"]))
                    objUser.GroupID = Convert.ToInt32(dr["GroupID"]);

            }
            return objUser;
        }
    }

}
