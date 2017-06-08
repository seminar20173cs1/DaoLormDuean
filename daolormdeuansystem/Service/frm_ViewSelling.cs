
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
	public partial class frm_ViewSelling
	{
		public frm_ViewSelling()
		{
			InitializeComponent();
		}
		public void dgvSelLing_Load(object sender, EventArgs e)
		{
			var sql = "select * from v_ViewSelling1 where [ເຮືອ] = '" + frm_ChooseBoat.Default.txtBoatID.Text + "'";
			ConstVar.sh.ShowData(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvSelling);
		}
	}
}
