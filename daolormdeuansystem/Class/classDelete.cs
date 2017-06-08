
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
	public class classDelete
	{
		public string Delete(string sqlDeleteCommand, SqlConnection Connection)
		{
			SqlCommand cm = new SqlCommand(sqlDeleteCommand, Connection);
			if (cm.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("ລົບສໍາເລັດ", "ສະແດງຄວາມຍິນດີ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			return System.Convert.ToString( 0);
		}
	}
	
}
