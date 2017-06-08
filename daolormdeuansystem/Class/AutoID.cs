
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace daolormdeuansystem
{
	public class AutoID
	{
		public dynamic getAutoID()
		{
			
			
			return 0;
		}
		
		
		public string SetID(string constr, string colummID, string TableName, string style, int startIndex, int length)
		{
			SqlConnection CN = new SqlConnection(constr);
			SqlDataReader dr = default(SqlDataReader);
			string autoSql = "";
			string id = "";
			string subid = "";
			autoSql = "SELECT " + colummID + " FROM " + TableName + " ORDER BY " + colummID + " DESC ";
			CN.Open();
			SqlCommand CMAuto = new SqlCommand(autoSql, CN);
			dr = CMAuto.ExecuteReader();
			dr.Read();
			id = dr[0].ToString();
			subid = id.Substring(startIndex, length);
			return style + System.Convert.ToString(double.Parse(subid) + 1);
//			CN.Close();
		}




        //string id = ConstVar.au.SetID(ConstVar.constr, "reserveFoodID", "tb_ReserveFood", "RSF", 3, 7, 7, "0000000");
        public string SetID(string constr, string colummID, string TableName, string style, int startIndex, int length, int padwidth, string pad)
		{
			SqlConnection CN = new SqlConnection(constr);
			SqlDataReader dr = default(SqlDataReader);
			string autoSql = "";
			string id = "";
			string subid = "";
			autoSql = "SELECT " + colummID + " FROM " + TableName + " ORDER BY " + colummID + " DESC ";
			CN.Open();
			SqlCommand CMAuto = new SqlCommand(autoSql, CN);
			dr = CMAuto.ExecuteReader();
			dr.Read();
			id = dr[0].ToString();
			subid = id.Substring(startIndex, length);
            return style + System.Convert.ToString((double.Parse(subid) + 1).ToString(pad));
                //.PadLeft(padwidth, pad));
//			CN.Close();
		}
        //private void AutoCustomerID()
        //{
        //    SqlDataAdapter daID = new SqlDataAdapter("Select Max(CustomerID) from tb_Customer", cd.ConnectDatabase(cnstr));
        //    DataSet dsID = new DataSet();
        //    daID.Fill(dsID, "ID");
        //    dsID.Tables[0].Clear();
        //    daID.Fill(dsID, "ID");
        //    int CustID = int.Parse(dsID.Tables[0].Rows[0].ItemArray[0].ToString()) + 1;
        //    txtID.Text = CustID.ToString("00000000");
        //}
    }
	
}
