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
/// Summary description for CustomtourDestinationDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class CustomtourDestinationDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public CustomtourDestinationDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(CustomtourDestinationDO objCustomtourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomtourDestination_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objCustomtourDestinationDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomTourID", SqlDbType.Int);
Sqlparam.Value = objCustomtourDestinationDO.CustomTourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(CustomtourDestinationDO objCustomtourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomtourDestination_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@CustomtourDestinationID", SqlDbType.Int);
Sqlparam.Value = objCustomtourDestinationDO.CustomtourDestinationID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objCustomtourDestinationDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@CustomTourID", SqlDbType.Int);
Sqlparam.Value = objCustomtourDestinationDO.CustomTourID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(CustomtourDestinationDO objCustomtourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomtourDestination_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CustomtourDestinationID", SqlDbType.Int);
Sqlparam.Value = objCustomtourDestinationDO.CustomtourDestinationID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomtourDestination_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public CustomtourDestinationDO Select(CustomtourDestinationDO objCustomtourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomtourDestination_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@CustomtourDestinationID", SqlDbType.Int);
Sqlparam.Value = objCustomtourDestinationDO.CustomtourDestinationID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["CustomtourDestinationID"]))
objCustomtourDestinationDO.CustomtourDestinationID=Convert.ToInt32(dr["CustomtourDestinationID"]);
if(!Convert.IsDBNull(dr["DestinationID"]))
objCustomtourDestinationDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);
if(!Convert.IsDBNull(dr["CustomTourID"]))
objCustomtourDestinationDO.CustomTourID=Convert.ToInt32(dr["CustomTourID"]);

            }
             return objCustomtourDestinationDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomtourDestination_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrCustomtourDestinationDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
CustomtourDestinationDO objCustomtourDestinationDO= new CustomtourDestinationDO();
if(!Convert.IsDBNull(dr["CustomtourDestinationID"]))
objCustomtourDestinationDO.CustomtourDestinationID=Convert.ToInt32(dr["CustomtourDestinationID"]);
if(!Convert.IsDBNull(dr["DestinationID"]))
objCustomtourDestinationDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);
if(!Convert.IsDBNull(dr["CustomTourID"]))
objCustomtourDestinationDO.CustomTourID=Convert.ToInt32(dr["CustomTourID"]);
arrCustomtourDestinationDO.Add(objCustomtourDestinationDO);
}
            }
               return arrCustomtourDestinationDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spCustomtourDestination_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public bool Select1(int CustomTourID, int DestinationID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spCustomtourDestination_GetbyPro";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@CustomTourID", SqlDbType.Int);
            Sqlparam.Value = CustomTourID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
            Sqlparam.Value = DestinationID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
           
        }
    }

}
