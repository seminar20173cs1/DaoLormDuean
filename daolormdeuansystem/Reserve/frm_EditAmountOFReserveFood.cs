
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
    public partial class frm_EditAmountOFReserveFood
	{
		public frm_EditAmountOFReserveFood()
		{
			InitializeComponent();
		}
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			string update = "update tb_reserveFood Set foodAmount = '" + txtFoodAmount.Text + "' where reserveFoodID='" + System.Convert.ToString(frm_ReserveFood1.Default.dgvReserveFood.Rows[frm_ReserveFood1.Default.dgvReserveFood.CurrentRow.Index].Cells[0].Value) + "'";
			ConstVar.upd.Update(update, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			ConstVar.sh.ShowData("select * from v_ReserveFood1 where reserveID='" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_ReserveFood1.Default.dgvReserveFood);
			Dispose();
		}
		
		public void frm_EditAmountOFReserveFood_Load(object sender, EventArgs e)
		{
			txtFoodName.Text = System.Convert.ToString(frm_ReserveFood1.Default.dgvReserveFood.Rows[frm_ReserveFood1.Default.dgvReserveFood.CurrentRow.Index].Cells[1].Value);
			txtFoodAmount.Text = System.Convert.ToString(frm_ReserveFood1.Default.dgvReserveFood.Rows[frm_ReserveFood1.Default.dgvReserveFood.CurrentRow.Index].Cells[2].Value);
		}
	}
}
