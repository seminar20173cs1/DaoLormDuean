
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
	public partial class frm_MainService
	{
		public frm_MainService()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_MainService defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_MainService Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_MainService();
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
		
		private void ButtonX1_Click(object sender, EventArgs e)
		{
			
			
			
		}
		classShowData show = new classShowData();
		
		
		public void frm_MainService_Load(object sender, EventArgs e)
		{
			
			this.ContextMenuStrip = ContextMenuStrip1;
			btOrder.Enabled = false;
			btStart.Enabled = false;
			btCheckBill.Enabled = false;
			btCalculate.Enabled = false;
			btPaid.Enabled = false;
			
			
			mnPaid.Visible = false;
			mnorder.Visible = false;
			mnPrint.Visible = false;
			mnCal.Visible = false;
			mnPaid.Visible = false;
			mnStart.Visible = false;
			classDatabaseConnection connect = new classDatabaseConnection();
			show.ShowData("select * from v_Selling", connect.DatabaseConnection(ConstVar.constr), dgvOrder);
			show.ShowData("select * from v_SellDetail", connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
			
			
			lbSellID.BackColor = Color.FromArgb(70, Color.Black);
			Panel4.BackColor = Color.FromArgb(70, Color.Black);
			
			dgvOrder.Columns[8].DefaultCellStyle.Format = "HH:mm:ss";
			dgvOrder.Columns[9].DefaultCellStyle.Format = "HH:mm:ss";
			//  dgvOrder.Columns(0).Width = 150
			//  dgvOrderDetail.Columns(6).Width = 1
			setRowColor();
			dgvOrder.CurrentCell = dgvOrder.Rows[dgvOrder.RowCount - 1].Cells[0];
			
		}
		
		public void ButtonX1_Click_1(object sender, EventArgs e)
		{
			//   Dim frm As New frm_ChooseBoat
			//  frm.ShowDialog()
			//   frm_ChooseBoat.Show()
			frm_ChooseBoat.Default.ShowDialog();
			
		}
		
		private void Button1_Click(object sender, EventArgs e)
		{
			show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
			show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
			setRowColor();
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			frm_OrderFood3.Default.ShowDialog();
			
		}
		
		public void dgvOrder_Click(object sender, EventArgs e)
		{
			if (dgvOrder.RowCount == 0)
			{
				MessageBox.Show("ບໍ່ມີຂໍ້ມູນ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			show.ShowData("select * from v_SellDetail where SellID = '" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
			
			if ((string) (dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[7].Value) == "ຕຽມການ")
			{
				btStart.Text = "ເລີ່ມອອກເຮືອ";
				btOrder.Text = "ສັ່ງເພີ່ມ ຫຼື ແກ້ໃຂລາຍການ";
				btStart.Enabled = true;
				btOrder.Enabled = true;
				
				
				mnStart.Visible = true;
				mnorder.Visible = true;
				
			}
			else if ((string) (dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[7].Value) == "ອອກເຮືອຢູ່")
			{
				btOrder.Enabled = false;
				btStart.Text = "ສິນສຸດການເດີນເຮືອ";
				mnorder.Enabled = false;
				if (btStart.Text == "ເລີ່ມອອກເຮືອ")
				{
					btStart.Enabled = false;
				}
				else if (btStart.Text == "ສິນສຸດການເດີນເຮືອ")
				{
					btStart.Enabled = true;
				}
			}
			else if ((string) (dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[7].Value) == "ຍັງບໍ່ຈ່າຍ")
			{
				btOrder.Text = "ສັ່ງເພີ່ມ";
				btStart.Text = "ເລີ່ມອອກເຮືອ";
				btPaid.Enabled = true;
				btCheckBill.Enabled = true;
				btOrder.Enabled = false;
				btCalculate.Enabled = true;
				
				//mnPaid.Visible = False
				mnPaid.Visible = true;
				mnPrint.Visible = true;
				mnCal.Visible = true;
				
				
			}
			else if ((string) (dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[7].Value) == "ຈ່າຍແລ້ວ")
			{
				btStart.Enabled = false;
				btOrder.Enabled = false;
				btCalculate.Enabled = false;
				btCheckBill.Enabled = true;
				btPaid.Enabled = false;
				
				
				mnStart.Visible = false;
				mnorder.Visible = false;
				mnCal.Visible = false;
				mnPrint.Visible = false;
				mnPaid.Visible = false;
			}
			else if ((string) (dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[7].Value) == "")
			{
				
				
			}
			int i = 0;
			int countrows = 0;
			int sum = 0;
			countrows = dgvOrderDetail.RowCount;
			for (i = 0; i <= countrows - 1; i++)
			{
				sum += System.Convert.ToInt32(dgvOrderDetail.Rows[i].Cells[5].Value);
			}
			txtTotal.Tag = sum;
			txtTotal.Text = Strings.Format(sum, "#,### ກີບ");
			Label3.Text = System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value);
		}
		
		private void txtusername_Click(object sender, EventArgs e)
		{
			
		}
		
		private void ButtonX7_Click(object sender, EventArgs e)
		{
			
		}
		
		public void dgvOrderDetail_Click(object sender, EventArgs e)
		{
			
		}
		int timeSail;
		Timer tmBoat;
		int timeSailINSecond;
		ProgressBar pgb;
		Label lbProcess;
		public void btStart_Click(object sender, EventArgs e)
		{
			if (btStart.Text == "ເລີ່ມອອກເຮືອ")
			{
				var sqlStartTime = "update tb_Selling Set Time_Start =getdate(), sellStatus =N'ອອກເຮືອຢູ່' where SellID = '" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
				ConstVar.upd.Update(sqlStartTime, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				setRowColor();
				dgvOrder.CurrentCell = dgvOrder.Rows[dgvOrder.RowCount - 1].Cells[0];
				RadioButton4.Checked = true;
			}
			else if (btStart.Text == "ສິນສຸດການເດີນເຮືອ")
			{
				var sqlStopTime = "update tb_Selling Set Time_Stop =getdate(), sellStatus= N'ຍັງບໍ່ຈ່າຍ' where SellID = '" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
				ConstVar.upd.Update(sqlStopTime, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				setRowColor();
				dgvOrder.CurrentCell = dgvOrder.Rows[dgvOrder.RowCount - 1].Cells[0];
				RadioButton2.Checked = true;
			}
			
		}
		
		private void TmTick(object sender, EventArgs e)
		{
			ProgressBar pg = default(ProgressBar);
			Timer tm = default(Timer);
			//  pg = CType(sender, ProgressBar)
			tm = (Timer) sender;
			pg.Increment(1);
			if (pg.Value == 100)
			{
				tm.Stop();
			}
		}
		
		private void Button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(System.Convert.ToString(timeSailINSecond));
		}
		
		private void Timer1_Tick(object sender, EventArgs e)
		{
			
		}
		
		public void ButtonX1_Click_2(object sender, EventArgs e)
		{
			frm_TimeCalculation cal = new frm_TimeCalculation();
			cal.ShowDialog();
			setRowColor();
			dgvOrder.CurrentCell = dgvOrder.Rows[dgvOrder.RowCount - 1].Cells[0];
		}
		
		public void txtTotal_TextChanged(object sender, EventArgs e)
		{
			//If dgvOrder.Rows(dgvOrder.CurrentRow.Index).Cells(10).Value = "" Then
			//    MsgBox("ຍັງບໍ່ໄດ້ຄິດໄລຄ່າລ່ອງເຮືອເທຶ່ອ")
			//    Exit Sub
			//Else
			//    Dim sumMoney As Integer = Integer.Parse(txtTotal.Tag + dgvOrder.Rows(dgvOrder.CurrentRow.Index).Cells(10).Value)
			//    Dim sqlUpdateTotalPrice As String = "UPDATE tb_Selling SET TotalPrice = '" & sumMoney & "' WHERE SellID='" & dgvOrder.Rows(dgvOrder.CurrentRow.Index).Cells(0).Value & "'"
			//    upd.Update(sqlUpdateTotalPrice, connect.DatabaseConnection(constr))
			//    show.ShowData("select * from v_Selling", connect.DatabaseConnection(constr), dgvOrder)
			//End If
			
		}
		
		public void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}
		
		public void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
			show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
			setRowColor();
		}
		
		public void ButtonX2_Click_1(object sender, EventArgs e)
		{
			SqlDataReader dr = default(SqlDataReader);
			string sql = "Select ServeStyle from tb_Selling where SellID = '" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
			SqlCommand cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			dr = cm.ExecuteReader();
			dr.Read();
			string state = dr[0].ToString();
			//    MsgBox(state)
			if (state == "0")
			{
				ConstVar.upd.Update("UPDATE tb_boat SET boatStatus=N'ວ່າງ' WHERE boatID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[2].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				ConstVar.upd.Update("UPDATE tb_Selling SET sellStatus=N'ຈ່າຍແລ້ວ' WHERE SellID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
				RadioButton1.Checked = true;
				
				setRowColor();
				//setRowColor()
				dgvOrder.CurrentCell = dgvOrder.Rows[dgvOrder.RowCount - 1].Cells[0];
			}
			else if (state == "1")
			{
				ConstVar.upd.Update("UPDATE tb_boat SET boatStatus=N'ຈອງແລ້ວ' WHERE boatID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[2].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				ConstVar.upd.Update("UPDATE tb_Selling SET sellStatus=N'ຈ່າຍແລ້ວ' WHERE SellID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
				RadioButton1.Checked = true;
				setRowColor();
				// setRowColor()
				dgvOrder.CurrentCell = dgvOrder.Rows[dgvOrder.RowCount - 1].Cells[0];
			}
			
			
			
		}
		
		public void btCheckBill_Click(object sender, EventArgs e)
		{
			DSBill ds = new DSBill();
			Bill3 rpt = new Bill3();
			string sql = "Select * from v_Bill where SellID ='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
			SqlCommand cm = default(SqlCommand);
			SqlDataAdapter da = default(SqlDataAdapter);
			
			cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da = new SqlDataAdapter(cm);
			da.Fill(ds, "DTBill");
			
			rpt.SetDataSource(ds);
			
			frm_Bill.Default.rp_Bill.ReportSource = rpt;
			frm_Bill.Default.Show();
			setRowColor();
			dgvOrder.CurrentCell = dgvOrder.Rows[dgvOrder.RowCount - 1].Cells[0];
		}
		
		public void ButtonItem1_Click(object sender, EventArgs e)
		{
			frm_ChoosFormReserve a = new frm_ChoosFormReserve();
			a.ShowDialog();
		}
		
		private void setRowColor()
		{
			for (int i = 0; i <= dgvOrder.RowCount - 1; i++)
			{
				if ((string) (dgvOrder.Rows[i].Cells[7].Value) == "ຈ່າຍແລ້ວ")
				{
					dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
				}
				else if ((string) (dgvOrder.Rows[i].Cells[7].Value) == "ອອກເຮືອຢູ່")
				{
					dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
				}
				else if ((string) (dgvOrder.Rows[i].Cells[7].Value) == "ຍັງບໍ່ຈ່າຍ")
				{
					dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.Red;
				}
				else if ((string) (dgvOrder.Rows[i].Cells[7].Value) == "ຕຽມການ")
				{
					dgvOrder.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
				}
				
			}
		}
		
		public void ButtonItem2_Click(object sender, EventArgs e)
		{
			frm_ChoosFormReserve a = new frm_ChoosFormReserve();
			a.ShowDialog();
		}
		
		public void ໃໝToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_ChooseBoat.Default.ShowDialog();
		}
		
		public void ເລອກຈາກການຈອງToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_ChoosFormReserve a = new frm_ChoosFormReserve();
			a.ShowDialog();
		}
		
		public void ສງອາຫານToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_OrderFood3.Default.ShowDialog();
		}
		
		public void StartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btStart.Text == "ເລີ່ມອອກເຮືອ")
			{
				var sqlStartTime = "update tb_Selling Set Time_Start =getdate(), sellStatus =N'ອອກເຮືອຢູ່' where SellID = '" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
				ConstVar.upd.Update(sqlStartTime, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
			}
			else if (btStart.Text == "ສິນສຸດການເດີນເຮືອ")
			{
				var sqlStopTime = "update tb_Selling Set Time_Stop =getdate(), sellStatus= N'ຍັງບໍ່ຈ່າຍ' where SellID = '" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
				ConstVar.upd.Update(sqlStopTime, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
			}
		}
		
		public void ຄດໄລຄາລອງເຮອToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_TimeCalculation cal = new frm_TimeCalculation();
			cal.ShowDialog();
		}
		
		public void ພມບນToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DSBill ds = new DSBill();
			Bill3 rpt = new Bill3();
			string sql = "Select * from v_Bill where SellID ='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
			SqlCommand cm = default(SqlCommand);
			SqlDataAdapter da = default(SqlDataAdapter);
			
			cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da = new SqlDataAdapter(cm);
			da.Fill(ds, "DTBill");
			
			rpt.SetDataSource(ds);
			
			frm_Bill.Default.rp_Bill.ReportSource = rpt;
			frm_Bill.Default.Show();
		}
		
		public void ໄດຮບເງນແລວToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SqlDataReader dr = default(SqlDataReader);
			string sql = "Select ServeStyle from tb_Selling where SellID = '" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
			SqlCommand cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			dr = cm.ExecuteReader();
			dr.Read();
			string state = dr[0].ToString();
			MessageBox.Show(state);
			if (state == "0")
			{
				ConstVar.upd.Update("UPDATE tb_boat SET boatStatus=N'ວ່າງ' WHERE boatID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[2].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				ConstVar.upd.Update("UPDATE tb_Selling SET sellStatus=N'ຈ່າຍແລ້ວ' WHERE SellID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
				setRowColor();
			}
			else if (state == "1")
			{
				ConstVar.upd.Update("UPDATE tb_boat SET boatStatus=N'ຈອງແລ້ວ' WHERE boatID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[2].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				ConstVar.upd.Update("UPDATE tb_Selling SET sellStatus=N'ຈ່າຍແລ້ວ' WHERE SellID='" + System.Convert.ToString(dgvOrder.Rows[dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderDetail);
				setRowColor();
			}
			
			
		}
		
		public void ອອຫToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton1.Checked == true)
			{
				show.ShowData("Select * From v_Selling Where [ສະຖານະ] = N'ຈ່າຍແລ້ວ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				setRowColor();
			}
		}
		
		public void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton3.Checked == true)
			{
				show.ShowData("Select * From v_Selling Where [ສະຖານະ] = N'ຕຽມການ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				setRowColor();
			}
		}
		
		public void RadioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton4.Checked == true)
			{
				show.ShowData("Select * From v_Selling Where [ສະຖານະ] = N'ອອກເຮືອຢູ່'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				setRowColor();
			}
		}
		
		public void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton2.Checked == true)
			{
				show.ShowData("Select * From v_Selling Where [ສະຖານະ] = N'ຍັງບໍ່ຈ່າຍ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				setRowColor();
			}
		}
		
		public void RadioButton5_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioButton5.Checked == true)
			{
				show.ShowData("Select * From v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrder);
				setRowColor();
			}
		}
	}
	
	
	//Dim lbProcess = New Label
	//lbProcess.Width = 150
	//lbProcess.Text = dgvOrder.Rows(dgvOrder.CurrentRow.Index).Cells(0).Value
	//tmBoat = New Timer()
	//tmBoat.Interval = 10000
	
	//pgb = New ProgressBar()
	
	//pgb.Minimum = 0
	//pgb.Value = 50
	//'  pgb.Value = 50
	//pgb.Name = dgvOrder.Rows(dgvOrder.CurrentRow.Index).Cells(0).Value
	
	//tmBoat.Start()
	//AddHandler tmBoat.Tick, AddressOf TmTick
}
