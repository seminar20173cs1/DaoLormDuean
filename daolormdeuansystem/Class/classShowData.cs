
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
	public class classShowData
	{
		public dynamic ShowData(string sqlSelectCommand, SqlConnection connection, DataGridView dataGridViewName)
		{
			DataSet ds = new DataSet();
			SqlCommand cm = new SqlCommand(sqlSelectCommand, connection);
			SqlDataAdapter da = new SqlDataAdapter(cm);
			ds.Clear();
			da.Fill(ds);
			DataGridView with_1 = dataGridViewName;
			with_1.DataSource = ds.Tables[0];
			return 0;
		}
		public dynamic ShowDataInCombobox(string sqlSelectCommand, SqlConnection connection, ComboBox cb, string colValue, string colMember)
		{
			DataSet ds = new DataSet();
			SqlCommand cm = new SqlCommand(sqlSelectCommand, connection);
			SqlDataAdapter da = new SqlDataAdapter(cm);
			da.Fill(ds);
			ComboBox with_1 = cb;
			with_1.DisplayMember = colMember;
			with_1.ValueMember = colValue;
			with_1.DataSource = ds.Tables[0];
			return 0;
		}
	}
	
}
