
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
	public class classDatabaseConnection
	{
		public SqlCommand SQLCm;
		public SqlDataAdapter SQLDa;
		public SqlDataReader SQLDr;
		public SqlConnection DatabaseConnection(string connectionString)
		{
			var constr = connectionString;
			var cn = new SqlConnection(constr);
			cn.Open();
			return cn;
		}
	}
}
