
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
	public partial class frm_ChangeAmountFood
	{
		public frm_ChangeAmountFood()
		{
			InitializeComponent();
		}
		public void btClose_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void frm_ChangeAmountFood_Load(object sender, EventArgs e)
		{
			txtFoodName.Text = System.Convert.ToString(frm_OrderFood3.Default.dgvOrderFood.Rows[frm_OrderFood3.Default.dgvOrderFood.CurrentRow.Index].Cells[0].Value);
			txtFoodAmount.Text = System.Convert.ToString(frm_OrderFood3.Default.dgvOrderFood.Rows[frm_OrderFood3.Default.dgvOrderFood.CurrentRow.Index].Cells[2].Value);
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			ConstVar.upd.Update("Update tb_SellDetail Set foodAmount= '" + txtFoodAmount.Text + "'where SelldetailID = '" + System.Convert.ToString(frm_OrderFood3.Default.dgvOrderFood.Rows[frm_OrderFood3.Default.dgvOrderFood.CurrentRow.Index].Cells[4].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
			// sh.ShowData("select * from v_SellDetail where SellID = '" & frm_MainService.dgvOrder.Rows(frm_MainService.dgvOrder.CurrentRow.Index).Cells(0).Value & "'", connect.DatabaseConnection(constr), frm_MainService.dgvOrderDetail)
			ConstVar.sh.ShowData("select * from v_sellDetail1 where SellID ='" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_OrderFood3.Default.dgvOrderFood);
			this.Dispose();
		}
	}
}
