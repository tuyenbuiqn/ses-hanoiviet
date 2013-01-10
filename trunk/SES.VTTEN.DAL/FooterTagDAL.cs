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
/// Summary description for FooterTagDAL
/// </summary>
namespace  SES.VTTEN.DAL 
{
    
    public class FooterTagDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public FooterTagDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(FooterTagDO objFooterTagDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spFooterTag_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@Tag", SqlDbType.NText);
Sqlparam.Value = objFooterTagDO.Tag;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(FooterTagDO objFooterTagDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spFooterTag_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@TagID", SqlDbType.Int);
Sqlparam.Value = objFooterTagDO.TagID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Tag", SqlDbType.NText);
Sqlparam.Value = objFooterTagDO.Tag;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(FooterTagDO objFooterTagDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spFooterTag_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@TagID", SqlDbType.Int);
Sqlparam.Value = objFooterTagDO.TagID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spFooterTag_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public FooterTagDO Select(FooterTagDO objFooterTagDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spFooterTag_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@TagID", SqlDbType.Int);
Sqlparam.Value = objFooterTagDO.TagID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["TagID"]))
objFooterTagDO.TagID=Convert.ToInt32(dr["TagID"]);
if(!Convert.IsDBNull(dr["Tag"]))
objFooterTagDO.Tag=Convert.ToString(dr["Tag"]);

            }
             return objFooterTagDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spFooterTag_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrFooterTagDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
FooterTagDO objFooterTagDO= new FooterTagDO();
if(!Convert.IsDBNull(dr["TagID"]))
objFooterTagDO.TagID=Convert.ToInt32(dr["TagID"]);
if(!Convert.IsDBNull(dr["Tag"]))
objFooterTagDO.Tag=Convert.ToString(dr["Tag"]);
arrFooterTagDO.Add(objFooterTagDO);
}
            }
               return arrFooterTagDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spFooterTag_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public FooterTagDO SelectTop()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spFooterTag_Gettop";


            FooterTagDO objFooterTagDO = new FooterTagDO();
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if (!Convert.IsDBNull(dr["TagID"]))
                    objFooterTagDO.TagID = Convert.ToInt32(dr["TagID"]);
                if (!Convert.IsDBNull(dr["Tag"]))
                    objFooterTagDO.Tag = Convert.ToString(dr["Tag"]);

            }
            return objFooterTagDO;
        }
    }

}
