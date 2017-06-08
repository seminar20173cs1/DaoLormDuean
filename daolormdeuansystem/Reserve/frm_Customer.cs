
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
	public partial class frm_Customer
	{
		public frm_Customer()
		{
			InitializeComponent();
		}
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void frm_Customer_Load(object sender, EventArgs e)
		{
			ConstVar.sh.ShowData("select * from v_Customer", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvCustomer);
		}
		
		public void dgvCustomer_Click(object sender, EventArgs e)
		{
			frm_MakeReserve1.Default.txtID.Text = System.Convert.ToString(dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[0].Value);
			frm_MakeReserve1.Default.txtName.Text = System.Convert.ToString(dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[1].Value);
			frm_MakeReserve1.Default.txtLastName.Text = System.Convert.ToString(dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[2].Value);
			frm_MakeReserve1.Default.txtTel.Text = System.Convert.ToString(dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[3].Value);
			frm_MakeReserve1.Default.txtTel2.Text = System.Convert.ToString(dgvCustomer.Rows[dgvCustomer.CurrentRow.Index].Cells[4].Value);
			this.Dispose();
		}
	}
}
