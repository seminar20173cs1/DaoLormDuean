
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
	public class classUpdate
	{
		public dynamic Update(string sqlUpdateCommand, SqlConnection connection, string msg)
		{
			SqlCommand cm = new SqlCommand(sqlUpdateCommand, connection);
			if (cm.ExecuteNonQuery() == 1)
			{
				MessageBox.Show(msg, "ຂໍສະແດງຄວາມຍິນດີ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			return 0;
		}
		public dynamic Update(string sqlUpdateCommand, SqlConnection connection)
		{
			SqlCommand cm = new SqlCommand(sqlUpdateCommand, connection);
			cm.ExecuteNonQuery();
			return 0;
		}
	}
	
}
