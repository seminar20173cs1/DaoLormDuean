
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
	public class ClassInsert
	{
		public string Insert(string sqlInsertCommand, SqlConnection Connection, string msg)
		{
			SqlCommand cm = new SqlCommand(sqlInsertCommand, Connection);
			if (cm.ExecuteNonQuery() == 1)
			{
				MessageBox.Show(msg, "ຂໍສະແດງຄວາມຍິນດີ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			return System.Convert.ToString( 0);
		}
		
		
		public string Insert(string sqlInsertCommand, SqlConnection Connection)
		{
			SqlCommand cm = new SqlCommand(sqlInsertCommand, Connection);
			cm.ExecuteNonQuery();
			return System.Convert.ToString( 0);
		}
	}
	
}
