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
/// Summary description for LinkDAL
/// </summary>
namespace SES.VTTEN.DAL 
{
    
    public class LinkDAL  : BaseDAL
    {
    	#region Private Variables
			
		#endregion
		
		#region Public Constructors
				public LinkDAL()
				{
					//
					// TODO: Add constructor logic here
					//
					
				}
		#endregion       

	
		
		#region Public Methods
        public int Insert(LinkDO objLinkDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spLink_Insert";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@LinkID", SqlDbType.Int);
Sqlparam.Value = objLinkDO.LinkID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objLinkDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objLinkDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@ID", SqlDbType.Int);
Sqlparam.Direction = ParameterDirection.ReturnValue;
Sqlcomm.Parameters.Add(Sqlparam);

           
            int result =base.ExecuteNoneQuery(Sqlcomm);
            
            if(!Convert.IsDBNull(Sqlcomm.Parameters["@ID"]))
				result = Convert.ToInt32(Sqlcomm.Parameters["@ID"].Value);

            return result;
        }

        public int Update(LinkDO objLinkDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spLink_UpdateByPK";
            SqlParameter Sqlparam;

            Sqlparam = new SqlParameter("@LinkID", SqlDbType.Int);
Sqlparam.Value = objLinkDO.LinkID;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Detail", SqlDbType.NText);
Sqlparam.Value = objLinkDO.Detail;
Sqlcomm.Parameters.Add(Sqlparam);

Sqlparam = new SqlParameter("@Published", SqlDbType.Bit);
Sqlparam.Value = objLinkDO.Published;
Sqlcomm.Parameters.Add(Sqlparam);


            
            Sqlparam = new SqlParameter("@ErrorCode", SqlDbType.Int);
            Sqlparam.Direction = ParameterDirection.ReturnValue;
            Sqlcomm.Parameters.Add(Sqlparam);
            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            
             if (!Convert.IsDBNull(Sqlcomm.Parameters["@ErrorCode"]))
                result = Convert.ToInt32(Sqlcomm.Parameters["@ErrorCode"].Value);
                
            return result;

           
        }

        public int Delete(LinkDO objLinkDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spLink_DeleteByPK";
            SqlParameter Sqlparam;


            Sqlparam = new SqlParameter("@LinkID", SqlDbType.Int);
Sqlparam.Value = objLinkDO.LinkID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

         public int DeleteAll()
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spLink_DeleteAll";

            int result=base.ExecuteNoneQuery(Sqlcomm);
            return result;
        }

        public LinkDO Select(LinkDO objLinkDO)
        {
            
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spLink_GetByPK";
            SqlParameter Sqlparam;
  

            Sqlparam = new SqlParameter("@LinkID", SqlDbType.Int);
Sqlparam.Value = objLinkDO.LinkID;
Sqlcomm.Parameters.Add(Sqlparam);


            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataRow dr = null;
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dr = ds.Tables[0].Rows[0];
                if(!Convert.IsDBNull(dr["LinkID"]))
objLinkDO.LinkID=Convert.ToInt32(dr["LinkID"]);
if(!Convert.IsDBNull(dr["Detail"]))
objLinkDO.Detail=Convert.ToString(dr["Detail"]);
if(!Convert.IsDBNull(dr["Published"]))
objLinkDO.Published=Convert.ToBoolean(dr["Published"]);

            }
             return objLinkDO;
        }

        public ArrayList SelectAll1( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spLink_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
            ArrayList arrLinkDO = new ArrayList();
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
{
LinkDO objLinkDO= new LinkDO();
if(!Convert.IsDBNull(dr["LinkID"]))
objLinkDO.LinkID=Convert.ToInt32(dr["LinkID"]);
if(!Convert.IsDBNull(dr["Detail"]))
objLinkDO.Detail=Convert.ToString(dr["Detail"]);
if(!Convert.IsDBNull(dr["Published"]))
objLinkDO.Published=Convert.ToBoolean(dr["Published"]);
arrLinkDO.Add(objLinkDO);
}
            }
               return arrLinkDO;
        }
        
        public DataTable SelectAll( )
        {
			
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType =  CommandType.StoredProcedure;
            Sqlcomm.CommandText =  "spLink_GetAll";
            
            DataSet ds = base.GetDataSet(Sqlcomm);
            DataTable dt = null;
          
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                
            }
               return dt;
        }

     
		#endregion          
    
    
        public DataTable Select1()
        {
            SqlCommand Sqlcomm = new SqlCommand();
            Sqlcomm.CommandType = CommandType.StoredProcedure;
            Sqlcomm.CommandText = "spLink_GetAll1";

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
