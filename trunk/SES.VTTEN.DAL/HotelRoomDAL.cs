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
/// Summary description for HotelRoomDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class HotelRoomDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public HotelRoomDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(HotelRoomDO objHotelRoomDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotelRoom_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@RoomType", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.RoomType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@RoomCat", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.RoomCat;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@RoomPrice", SqlDbType.Float);
Sqlparam.Value = objHotelRoomDO.RoomPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.HotelID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(HotelRoomDO objHotelRoomDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotelRoom_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@HotelRoomID", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.HotelRoomID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@RoomType", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.RoomType;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@RoomCat", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.RoomCat;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@RoomPrice", SqlDbType.Float);
Sqlparam.Value = objHotelRoomDO.RoomPrice;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.HotelID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(HotelRoomDO objHotelRoomDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotelRoom_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@HotelRoomID", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.HotelRoomID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotelRoom_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public HotelRoomDO Select(HotelRoomDO objHotelRoomDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotelRoom_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@HotelRoomID", SqlDbType.Int);
Sqlparam.Value = objHotelRoomDO.HotelRoomID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["HotelRoomID"]))
objHotelRoomDO.HotelRoomID=Convert.ToInt32(dr["HotelRoomID"]);
if(!Convert.IsDBNull(dr["RoomType"]))
objHotelRoomDO.RoomType=Convert.ToInt32(dr["RoomType"]);
if(!Convert.IsDBNull(dr["RoomCat"]))
objHotelRoomDO.RoomCat=Convert.ToInt32(dr["RoomCat"]);
if(!Convert.IsDBNull(dr["RoomPrice"]))
objHotelRoomDO.RoomPrice=Convert.ToDouble(dr["RoomPrice"]);
if(!Convert.IsDBNull(dr["HotelID"]))
objHotelRoomDO.HotelID=Convert.ToInt32(dr["HotelID"]);

            }
             return objHotelRoomDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotelRoom_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrHotelRoomDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
HotelRoomDO objHotelRoomDO= new HotelRoomDO();
if(!Convert.IsDBNull(dr["HotelRoomID"]))
objHotelRoomDO.HotelRoomID=Convert.ToInt32(dr["HotelRoomID"]);
if(!Convert.IsDBNull(dr["RoomType"]))
objHotelRoomDO.RoomType=Convert.ToInt32(dr["RoomType"]);
if(!Convert.IsDBNull(dr["RoomCat"]))
objHotelRoomDO.RoomCat=Convert.ToInt32(dr["RoomCat"]);
if(!Convert.IsDBNull(dr["RoomPrice"]))
objHotelRoomDO.RoomPrice=Convert.ToDouble(dr["RoomPrice"]);
if(!Convert.IsDBNull(dr["HotelID"]))
objHotelRoomDO.HotelID=Convert.ToInt32(dr["HotelID"]);
arrHotelRoomDO.Add(objHotelRoomDO);
}
            }
               return arrHotelRoomDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spHotelRoom_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public HotelRoomDO SelectbyPro(int RoomType, int RoomCat, int HotelID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotelRoom_GetByPro";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@RoomType", SqlDbType.Int);
            Sqlparam.Value = RoomType;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@RoomCat", SqlDbType.Int);
            Sqlparam.Value = RoomCat;
            Sqlcomm.Parameters.Add(Sqlparam);

            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
            Sqlparam.Value = HotelID;
            Sqlcomm.Parameters.Add(Sqlparam);

            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            HotelRoomDO objHotelRoomDO = new HotelRoomDO();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["HotelRoomID"]))
                    objHotelRoomDO.HotelRoomID = Convert.ToInt32(dr["HotelRoomID"]);
                if (!Convert.IsDBNull(dr["RoomType"]))
                    objHotelRoomDO.RoomType = Convert.ToInt32(dr["RoomType"]);
                if (!Convert.IsDBNull(dr["RoomCat"]))
                    objHotelRoomDO.RoomCat = Convert.ToInt32(dr["RoomCat"]);
                if (!Convert.IsDBNull(dr["RoomPrice"]))
                    objHotelRoomDO.RoomPrice = Convert.ToDouble(dr["RoomPrice"]);
                if (!Convert.IsDBNull(dr["HotelID"]))
                    objHotelRoomDO.HotelID = Convert.ToInt32(dr["HotelID"]);

            }
            return objHotelRoomDO;
        }

        public DataTable SelectbyFK(int HotelID)
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spHotelRoom_GetByFK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@HotelID", SqlDbType.Int);
            Sqlparam.Value = HotelID;
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
