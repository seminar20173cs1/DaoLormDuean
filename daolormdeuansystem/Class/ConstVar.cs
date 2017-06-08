
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



namespace daolormdeuansystem
{
	sealed class ConstVar
	{
		public static string constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True";
		public static classDatabaseConnection connect = new classDatabaseConnection();
		public static string emID;
		
		public static classShowData sh = new classShowData();
		public static ClassInsert sav = new ClassInsert();
		public static classUpdate upd = new classUpdate();
		public static classDelete dell = new classDelete();
		public static AutoID au = new AutoID();
	}
	
}
