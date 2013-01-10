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
/// Summary description for TourDestinationDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourDestinationDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourDestinationDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourDestinationDO objTourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDestination_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourDestinationDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objTourDestinationDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourDestinationDO objTourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDestination_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourDestinationID", SqlDbType.Int);
Sqlparam.Value = objTourDestinationDO.TourDestinationID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourDestinationDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
Sqlparam.Value = objTourDestinationDO.DestinationID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourDestinationDO objTourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDestination_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourDestinationID", SqlDbType.Int);
Sqlparam.Value = objTourDestinationDO.TourDestinationID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDestination_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourDestinationDO Select(TourDestinationDO objTourDestinationDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDestination_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@TourDestinationID", SqlDbType.Int);
Sqlparam.Value = objTourDestinationDO.TourDestinationID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["TourDestinationID"]))
objTourDestinationDO.TourDestinationID=Convert.ToInt32(dr["TourDestinationID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourDestinationDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["DestinationID"]))
objTourDestinationDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);

            }
             return objTourDestinationDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDestination_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourDestinationDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourDestinationDO objTourDestinationDO= new TourDestinationDO();
if(!Convert.IsDBNull(dr["TourDestinationID"]))
objTourDestinationDO.TourDestinationID=Convert.ToInt32(dr["TourDestinationID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourDestinationDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["DestinationID"]))
objTourDestinationDO.DestinationID=Convert.ToInt32(dr["DestinationID"]);
arrTourDestinationDO.Add(objTourDestinationDO);
}
            }
               return arrTourDestinationDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourDestination_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public int DeletebyFK(int TourID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourDestination_DeleteByFK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = TourID;
            Sqlcomm.Parameters.Add(Sqlparam);



            int result = base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public bool Select1(int TourID, int DestinationID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourDestination_GetByTourDestination";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = TourID;
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
            return false;
        }

        public DataTable SelectbyTour(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourDestination_GetbyTour";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
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

        public DataTable SelectbyDestination(int p)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourDestination_GetbyDestination";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@DestinationID", SqlDbType.Int);
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
    }

}
