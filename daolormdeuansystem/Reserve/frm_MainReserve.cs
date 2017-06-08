
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
	public partial class frm_MainReserve
	{
		public frm_MainReserve()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_MainReserve defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_MainReserve Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_MainReserve();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		public void frm_MainReserve_Load(object sender, EventArgs e)
		{
			//dgvReserveFood.Rows(dgvReserveFood.CurrentRow.Index).Cells(6)
			
			//  dgvReserve.Columns.
			ButtonX2.Visible = false;
			dgvReserveBoat.Visible = false;
			this.ContextMenuStrip = ContextMenuStrip1;
			ConstVar.sh.ShowData("select * from v_Reserve3 where [ສະຖານະ] != N'ມາໃຊ້ບໍລິການແລ້ວ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
			//   ButtonX2.Visible = False
			//  sh.ShowData("select * from v_ReserveBoat", connect.DatabaseConnection(constr), dgvReserveBoat)
			ConstVar.sh.ShowData("select * from v_ReserveFoodperfect", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveFood);
			
			
			//  dgvReserveFood.Columns(6).Width = 0
			Panel1.BackColor = Color.FromArgb(70, Color.Black);
			FlowLayoutPanel1.BackColor = Color.FromArgb(70, Color.Black);
			setRowColor();
			//  dgvReserveFood.DefaultCellStyle.BackColor = Color.LightBlue
			// dgvReserveFood.AlternatingRowsDefaultCellStyle.BackColor = Color.DodgerBlue
			//dgvReserveFood.BackgroundColor = Color.FromArgb(70, Color.Black)
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			frm_MakeReserve1.Default.ShowDialog();
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			frm_ReserveBoat1.Default.Show();
		}
		
		public void dgvReserve_Click(object sender, EventArgs e)
		{
			if ((string) (dgvReserve.Rows[dgvReserve.CurrentRow.Index].Cells[8].Value) == "ຍັງບໍ່ມາ")
			{
				btReserveFood.Visible = true;
				btConfirm.Visible = true;
			}
			else if ((string) (dgvReserve.Rows[dgvReserve.CurrentRow.Index].Cells[8].Value) == "ຢືນຢັນແລ້ວ")
			{
				btReserveFood.Visible = false;
				btConfirm.Visible = false;
			}
			
			
			
			
			
			ConstVar.sh.ShowData("select * from v_ReserveBoat where reserveID = '" + System.Convert.ToString(dgvReserve.Rows[dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveBoat);
			
			ConstVar.sh.ShowData("select * from v_ReserveFoodperfect where reserveID = '" + System.Convert.ToString(dgvReserve.Rows[dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveFood);
			Label3.Text = System.Convert.ToString(dgvReserve.Rows[dgvReserve.CurrentRow.Index].Cells[0].Value);
		}
		
		public void ButtonX3_Click(object sender, EventArgs e)
		{
			frm_ReserveFood1.Default.ShowDialog();
		}
		
		public void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConstVar.sh.ShowData("select * from v_Reserve3", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
			//   ButtonX2.Visible = False
			ConstVar.sh.ShowData("select * from v_ReserveBoat", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveBoat);
			ConstVar.sh.ShowData("select * from v_ReserveFoodperfect", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveFood);
			setRowColor();
		}
		
		public void ButtonX5_Click(object sender, EventArgs e)
		{
			string sql = "update tb_reserveBoat set reserveStatus=N'ຢືນຢັນແລ້ວ' where reserveID = '" + System.Convert.ToString(dgvReserve.Rows[dgvReserve.CurrentRow.Index].Cells[0].Value) + "'";
			ConstVar.upd.Update(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			ConstVar.sh.ShowData("select * from v_Reserve3", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
			cbConfirm.Checked = true;
			
		}
		
		public void btBill_Click(object sender, EventArgs e)
		{
			DSReserveBill ds = new DSReserveBill();
			ReserveBill rpt = new ReserveBill();
			string sql = "select reserveID, employeeName, customerName, reserveDate, reserveComedate, convert(varchar(8),reservecometime, 108) as reserveCometime, boatHOur, foodname, foodamount, unitName, foodPrice, Total from v_reserveBill where reserveID = '" + System.Convert.ToString(dgvReserve.Rows[dgvReserve.CurrentRow.Index].Cells[0].Value) + "'";
			
			SqlCommand cm = default(SqlCommand);
			SqlDataAdapter da = default(SqlDataAdapter);
			
			cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da = new SqlDataAdapter(cm);
			da.Fill(ds, "DTReserveBill");
			
			rpt.SetDataSource(ds);
			frm_ReserveBill.Default.CrystalReportViewer1.ReportSource = rpt;
			frm_ReserveBill.Default.Show();
			
			//frm_Bill.rp_Bill.ReportSource = rpt
			//frm_Bill.Show()
		}
		
		private void setRowColor()
		{
			for (int i = 0; i <= dgvReserve.RowCount - 1; i++)
			{
				if ((string) (dgvReserve.Rows[i].Cells[8].Value) == "ຢືນຢັນແລ້ວ")
				{
					dgvReserve.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
				}
				else if ((string) (dgvReserve.Rows[i].Cells[8].Value) == "ມາໃຊ້ບໍລິການແລ້ວ")
				{
					dgvReserve.Rows[i].DefaultCellStyle.BackColor = Color.Green;
				}
				else if ((string) (dgvReserve.Rows[i].Cells[8].Value) == "ຍັງບໍ່ມາ")
				{
					dgvReserve.Rows[i].DefaultCellStyle.BackColor = Color.DodgerBlue;
				}
				else if ((string) (dgvReserve.Rows[i].Cells[8].Value) == "ຕຽມການ")
				{
					dgvReserve.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
				}
				
			}
		}
		
		public void cbAll_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAll.Checked == true)
			{
				ConstVar.sh.ShowData("select * from v_Reserve3 ", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				setRowColor();
			}
		}
		
		public void cbConfirm_CheckedChanged(object sender, EventArgs e)
		{
			if (cbConfirm.Checked == true)
			{
				ConstVar.sh.ShowData("select * from v_Reserve3 where [ສະຖານະ] = N'ຢືນຢັນແລ້ວ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				setRowColor();
			}
		}
		
		public void cbCame_CheckedChanged(object sender, EventArgs e)
		{
			if (cbCame.Checked == true)
			{
				ConstVar.sh.ShowData("select * from v_Reserve3 where [ສະຖານະ] = N'ມາໃຊ້ບໍລິການແລ້ວ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				setRowColor();
			}
		}
		
		public void cbYet_CheckedChanged(object sender, EventArgs e)
		{
			if (cbYet.Checked == true)
			{
				ConstVar.sh.ShowData("select * from v_Reserve3 where [ສະຖານະ] = N'ຍັງບໍ່ມາ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				setRowColor();
			}
		}
	}
}
