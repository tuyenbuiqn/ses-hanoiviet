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
/// Summary description for TourScheduleDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class TourScheduleDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public TourScheduleDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(TourScheduleDO objTourScheduleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourSchedule_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourScheduleDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objTourScheduleDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DayNo", SqlDbType.Int);
Sqlparam.Value = objTourScheduleDO.DayNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objTourScheduleDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(TourScheduleDO objTourScheduleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourSchedule_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TourScheduleID", SqlDbType.Int);
Sqlparam.Value = objTourScheduleDO.TourScheduleID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
Sqlparam.Value = objTourScheduleDO.TourID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Title", SqlDbType.NVarChar);
Sqlparam.Value = objTourScheduleDO.Title;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@DayNo", SqlDbType.Int);
Sqlparam.Value = objTourScheduleDO.DayNo;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Description", SqlDbType.NText);
Sqlparam.Value = objTourScheduleDO.Description;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(TourScheduleDO objTourScheduleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourSchedule_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourScheduleID", SqlDbType.Int);
Sqlparam.Value = objTourScheduleDO.TourScheduleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourSchedule_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public TourScheduleDO Select(TourScheduleDO objTourScheduleDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourSchedule_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@TourScheduleID", SqlDbType.Int);
Sqlparam.Value = objTourScheduleDO.TourScheduleID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["TourScheduleID"]))
objTourScheduleDO.TourScheduleID=Convert.ToInt32(dr["TourScheduleID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourScheduleDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["Title"]))
objTourScheduleDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["DayNo"]))
objTourScheduleDO.DayNo=Convert.ToInt32(dr["DayNo"]);
if(!Convert.IsDBNull(dr["Description"]))
    objTourScheduleDO.Description = Convert.ToString(dr["Description"]);

            }
             return objTourScheduleDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourSchedule_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrTourScheduleDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
TourScheduleDO objTourScheduleDO= new TourScheduleDO();
if(!Convert.IsDBNull(dr["TourScheduleID"]))
objTourScheduleDO.TourScheduleID=Convert.ToInt32(dr["TourScheduleID"]);
if(!Convert.IsDBNull(dr["TourID"]))
objTourScheduleDO.TourID=Convert.ToInt32(dr["TourID"]);
if(!Convert.IsDBNull(dr["Title"]))
objTourScheduleDO.Title=Convert.ToString(dr["Title"]);
if(!Convert.IsDBNull(dr["DayNo"]))
objTourScheduleDO.DayNo=Convert.ToInt32(dr["DayNo"]);
if(!Convert.IsDBNull(dr["Description"]))
    objTourScheduleDO.Description = Convert.ToString(dr["Description"]);
arrTourScheduleDO.Add(objTourScheduleDO);
}
            }
               return arrTourScheduleDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spTourSchedule_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable SelectbyFK(int TourID)
        {

            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourSchedule_GetByFK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = TourID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];

            }
            return dt;
        }

        public bool Selectby2(int DayNo, int TourID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spTourSchedule_GetByTourIDDayNo";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TourID", SqlDbType.Int);
            Sqlparam.Value = TourID;
            Sqlcomm.Parameters.Add(Sqlparam);
            Sqlparam = new SqlParameter("@DayNo", SqlDbType.Int);
            Sqlparam.Value = DayNo;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;

            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;

            }
            return false;
        }
    }

}
