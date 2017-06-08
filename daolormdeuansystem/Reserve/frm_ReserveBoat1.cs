
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
	public partial class frm_ReserveBoat1
	{
		public frm_ReserveBoat1()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_ReserveBoat1 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_ReserveBoat1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_ReserveBoat1();
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
		string sqlviewSell;
		string sqlReserve;
		public void frm_ReserveBoat1_Load(object sender, EventArgs e)
		{
			LoadBaat();
			dgvReserve.Height = 0;
			dgvService.Height = 0;
			btView.Visible = false;
			sqlviewSell = "select * from v_Selling2 where [ລະຫັດເຮືອ] = '" + txtBoatID.Text + "' and [ສະຖານະ] != N'ຈ່າຍແລ້ວ'";
			sqlReserve = "select * from v_Viewreserve where [ເຮືອ]='" + txtBoatID.Text + "' and [ສະຖານະ] = N'ຍັງບໍ່ມາ'";
			
			//    sh.ShowData(sqlviewSell, connect.DatabaseConnection(constr), dgvService)
			//  sh.ShowData(sqlReserve, connect.DatabaseConnection(constr), dgvReserve)
			
			//sh.ShowData("select * from v_reserveboat where reserveID = '" & dgvReserve.Rows(dgvReserve.CurrentRow.Index).Cells(0).Value & "'", connect.DatabaseConnection(constr), dgvBoat)
			ConstVar.sh.ShowData("select * from v_ReserveBoat where reserveID = '" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvBoat);
			
			
		}
		
		
		
		private void LoadBaat()
		{
			Button BoatMenu = default(Button);
			string sqlboatDetail = "Select boatID, boatStatus from tb_Boat";
			DataTable dt = new DataTable();
			SqlDataAdapter da = default(SqlDataAdapter);
			string id = "";
			string status = "";
			
			da = new SqlDataAdapter(sqlboatDetail, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			
			da.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				BoatMenu = new Button();
				id = System.Convert.ToString(row["BoatID"]);
				status = System.Convert.ToString(row["BoatStatus"]);
				if (status == "ວ່າງ")
				{
					BoatMenu.BackColor = Color.LightGreen;
				}
				else if (status == "ບໍ່ວ່າງ")
				{
					BoatMenu.BackColor = Color.Red;
					btChooseBoat.Enabled = false;
				}
				else if (status == "ຈອງແລ້ວ")
				{
					BoatMenu.BackColor = Color.Yellow;
				}
				BoatMenu.Tag = row["BoatID"];
				BoatMenu.Text = id.ToString() + " " + status.ToString();
				// BoatMenu.Name = id.ToString
				BoatMenu.Width = 120;
				BoatMenu.Height = 70;
				BoatMenu.Click += this.OnBoatMenuClick;
				// pnBoat.Controls.Add(BoatMenu)
				FlowLayoutPanel1.Controls.Add(BoatMenu);
			}
		}
		private void OnBoatMenuClick(object sender, EventArgs e)
		{
			Button btn = default(Button);
			SqlDataAdapter da;
			SqlDataReader dr = default(SqlDataReader);
			btn = (Button) sender;
			DataTable dtboat = new DataTable();
			
			string sqlboat = "Select boatID, boatName,boatStatus, boatPicture from tb_boat where boatID = '" + System.Convert.ToString(btn.Tag) + "'";
			SqlCommand cm = new SqlCommand(sqlboat, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			
			string boatID = "";
			string boatName = "";
			string boatstatus;
			string boatpath = "";
			dr = cm.ExecuteReader();
			dr.Read();
			//Asign Value
			boatID = dr[0].ToString();
			boatName = dr[1].ToString();
			boatstatus = dr[2].ToString();
			boatpath = dr[3].ToString();
			txtBoatID.Text = boatID;
			txtBoatName.Text = boatName;
			//MsgBox(boatID)
			//MsgBox(boatName)
			//MsgBox(boatstatus)
			//MsgBox(boatpath)
			//   Check Value
			if (string.IsNullOrEmpty(boatpath))
			{
				ptbBoat.Image = null;
			}
			else
			{
				ptbBoat.Image = Image.FromFile(boatpath);
			}
			
			if (boatstatus == "ວ່າງ")
			{
				btChooseBoat.Enabled = true;
				btView.Visible = false;
			}
			else if (boatstatus == "ບໍ່ວ່າງ")
			{
				btView.Visible = true;
				btView.Text = "View Service";
				// btChooseBoat.Enabled = False
			}
			else if (boatstatus == "ຈອງແລ້ວ")
			{
				//btChooseBoat.Enabled = False
				btView.Visible = true;
				btView.Text = "View Reserve";
			}
			FlowLayoutPanel1.Refresh();
		}
		
		public void btChooseBoat_Click(object sender, EventArgs e)
		{
			string sql = "";
			string sqlinsert = "";
			sql = "update tb_boat set boatStatus = N'ຈອງແລ້ວ' where boatID='" + txtBoatID.Text + "'";
			ConstVar.upd.Update(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			string id = ConstVar.au.SetID(ConstVar.constr, "reserveBoatID", "tb_ReserveBoatDetail", "RSB", 3, 8, 8, "00000000");
			sqlinsert = "insert into tb_ReserveboatDetail Values('" + id + "','" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "','" + txtBoatID.Text + "','" + txtHour.Text + "')";
			ConstVar.sav.Insert(sqlinsert, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			
			ConstVar.sh.ShowData("select * from v_ReserveBoat where reserveID = '" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvBoat);
			txtBoatID.Clear();
			txtBoatName.Clear();
			
			txtHour.Clear();
			FlowLayoutPanel1.Controls.Clear();
			LoadBaat();
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			FlowLayoutPanel1.Controls.Clear();
			LoadBaat();
		}
		
		public void tmService_Tick(object sender, EventArgs e)
		{
			if (dgvService.Height <= 100)
			{
				dgvService.Height = dgvService.Height + 5;
			}
			else
			{
				tmService.Stop();
			}
		}
		
		public void tmReserve_Tick(object sender, EventArgs e)
		{
			if (dgvReserve.Height <= 100)
			{
				dgvReserve.Height = dgvReserve.Height + 5;
			}
			else
			{
				tmService.Stop();
			}
		}
		
		public void btView_Click(object sender, EventArgs e)
		{
			if (btView.Text == "View Service")
			{
				sqlviewSell = "select * from v_Selling2 where [ລະຫັດເຮືອ] = '" + txtBoatID.Text + "' and [ສະຖານະ] != N'ຈ່າຍແລ້ວ'";
				sqlReserve = "select * from v_Viewreserve where [ເຮືອ]='" + txtBoatID.Text + "' and [ສະຖານະ] = N'ຍັງບໍ່ມາ'";
				ConstVar.sh.ShowData(sqlviewSell, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvService);
				ConstVar.sh.ShowData(sqlReserve, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				tmService.Start();
				btView.Text = "Collapse";
			}
			else if (btView.Text == "View Reserve")
			{
				sqlviewSell = "select * from v_Selling2 where [ລະຫັດເຮືອ] = '" + txtBoatID.Text + "' and [ສະຖານະ] != N'ຈ່າຍແລ້ວ'";
				sqlReserve = "select * from v_Viewreserve where [ເຮືອ]='" + txtBoatID.Text + "' and [ສະຖານະ] = N'ຍັງບໍ່ມາ'";
				ConstVar.sh.ShowData(sqlviewSell, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvService);
				ConstVar.sh.ShowData(sqlReserve, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				tmReserve.Start();
				btView.Text = "Collapse";
			}
			else if (btView.Text == "Collapse")
			{
				dgvReserve.Height = 0;
				dgvService.Height = 0;
				tmService.Stop();
				tmReserve.Stop();
			}
		}
	}
}
