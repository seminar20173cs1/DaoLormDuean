
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
	public class SQLControl
	{
		public SQLControl()
		{
			
			SQLCon = new SqlConnection() {ConnectionString = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True"};
			
		}
		public SqlConnection SQLCon; 
		public SqlCommand SQLCmd;
		public SqlDataAdapter SQLDa;
		public DataSet SQLDs;
		public SqlDataReader SQLDr;
		public string empName = "";
		public bool HasConnection()
		{
			try
			{
				SQLCon.Open();
				SQLCon.Close();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}
		public void RunQuery(string Query)
		{
			SQLCon.Open();
			SQLCmd = new SqlCommand(Query, SQLCon);
			SQLDa = new SqlDataAdapter(SQLCmd);
			SQLDs = new DataSet();
			SQLDa.Fill(SQLDs);
			SQLCon.Close();
		}
		public void ManageData(string consql)
		{
			try
			{
				SQLCon.Open();
				SQLCmd = new SqlCommand(consql, SQLCon);
				SQLCmd.ExecuteNonQuery();
				SQLCon.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
	
	
}
