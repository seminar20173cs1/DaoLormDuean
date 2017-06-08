
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
    public partial class frm_MakeReserve1
	{
		public frm_MakeReserve1()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_MakeReserve1 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_MakeReserve1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_MakeReserve1();
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
		classDatabaseConnection db = new classDatabaseConnection();
		private void btnChoose_Click(object sender, EventArgs e)
		{
			
		}
		
		public void Panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		public void ButtonX5_Click(object sender, EventArgs e)
		{
			frm_Customer frm = new frm_Customer();
			frm.ShowDialog();
		}
		
		public void frm_MakeReserve1_Load(object sender, EventArgs e)
		{
			//  '  dtpDatecome.Format = Format(dtpDatecome, "MM/dd/yyyy")
			dtpDatecome.Format = DateTimePickerFormat.Custom;
			dtpDatecome.CustomFormat = "MM/dd/yyyy";
			LoadBaat();
			dgvReserve.Height = 0;
			dgvService.Height = 0;
			btView.Visible = false;
			
			
			txtID.Text = ConstVar.au.SetID(ConstVar.constr, "CustomerID", "tb_Customer", "C", 1, 4, 4, "0000");
			txtReservID.Text = ConstVar.au.SetID(ConstVar.constr, "reserveID", "tb_ReserveBoat", "RSB", 3, 5, 5, "00000");
			Panel4.BackColor = Color.FromArgb(70, Color.Black);
			Panel3.BackColor = Color.FromArgb(70, Color.Black);
			Panel2.BackColor = Color.FromArgb(70, Color.Black);
			Panel1.BackColor = Color.FromArgb(70, Color.Black);
			FlowLayoutPanel1.BackColor = Color.FromArgb(70, Color.Black);
			//Dim date1 As Integer
			//cbTime.Items.Clear()
			//cbminute.Items.Clear()
			//For date1 = 7 To 20
			//    cbTime.Items.Add(date1)
			//Next
			//Dim mn As Integer
			//For mn = 0 To 59
			//    cbminute.Items.Add(mn.ToString("##"))
			//Next
		}
		
		public void Panel2_Paint(object sender, PaintEventArgs e)
		{
			
		}
		string serveStyle;
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			
			if ((string) btRefresh.Tag == "ວ່າງ")
			{
				serveStyle = System.Convert.ToString(0);
			}
			else if ((string) btRefresh.Tag == "ບໍ່ວ່າງ")
			{
				serveStyle = System.Convert.ToString(1);
			}
			else if ((string) btRefresh.Tag == "ຈອງແລ້ວ")
			{
				serveStyle = System.Convert.ToString(0);
			}
			
			
			
			
			
			
			
			
			DateTime tt = DateTime.Parse(txtTime.Text);
			string tt2 = tt.ToShortTimeString();
			SqlCommand cm3 = new SqlCommand("select convert(varchar(8),reserveComeTime, 108) from tb_reserveBoat where reserveComeTime ='" + tt2 + "' and reserveComeDate = '" + dtpDatecome.Text + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
			SqlDataReader dr = default(SqlDataReader);
			dr = cm3.ExecuteReader();
			//  dr.Read()
			if (dr.HasRows)
			{
				MessageBox.Show("ເວລານີ້ຖືກຈອງແລ້ວ!!!" + Constants.vbNewLine + "ແນະນໍາ: ກະລຸນາປ້ອນເວລາໃໝ່", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtTime.Clear();
				txtTime.Focus();
				return;
			}
			else
			{
				SqlCommand cm1 = new SqlCommand("select employeeID from tb_employee where employeeName = '" + frm_Login.Default.txtUsername.Text + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr)); //''Problem
				SqlDataReader dr1 = default(SqlDataReader);
				dr1 = cm1.ExecuteReader();
				dr1.Read();
				ConstVar.emID = dr1[0].ToString();
				
				var sqlScript = "select CustomerID from tb_customer where customerID = '" + txtID.Text + "'";
				db.SQLCm = new SqlCommand(sqlScript, db.DatabaseConnection(ConstVar.constr));
				db.SQLDr = db.SQLCm.ExecuteReader();
				if (db.SQLDr.HasRows)
				{
					//Dim sql = "insert into tb_Reserveboat(reserveID, reserveDate, reserveComeDate, reserveComeTime, reserveStatus, customerID, employeeID) VALUES('" & txtReservID.Text & "','" & dtvReserve.Value.ToString("MM/dd/yyyy") & "','" & dtpDatecome.Value.ToString("MM/dd/yyyy") & "','" & txtTimecome.Text & "',N'ຍັງບໍ່ມາ','" & txtID.Text & "','" & emID & "')"
					var sql = "insert into tb_ReserveBoat VALUES('" + txtReservID.Text + "','" + ConstVar.emID + "','" + txtBoatID.Text + "','" + txtID.Text + "','" + dtvReserve.Value.ToString("MM/dd/yyyy") + "','" + dtpDatecome.Value.ToString("MM/dd/yyyy") + "','" + txtTime.Text + "','" + txtHour.Text + "',N'ຍັງບໍ່ມາ','" + serveStyle + "')";
					ConstVar.sav.Insert(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
					txtID.Text = ConstVar.au.SetID(ConstVar.constr, "CustomerID", "tb_Customer", "C", 1, 4, 4, "0000");
					txtReservID.Text = ConstVar.au.SetID(ConstVar.constr, "reserveID", "tb_ReserveBoat", "RSB", 3, 5, 5, "00000");
					txtName.Text = "";
					txtLastName.Text = "";
					txtTel.Text = "";
					txtTel2.Text = "";
					txtTime.Text = "";
					// Dispose()
					
					string sqlboat = "";
					string sqlinsert;
					sqlboat = "update tb_boat set boatStatus = N'ຈອງແລ້ວ' where boatID='" + txtBoatID.Text + "'";
					ConstVar.upd.Update(sqlboat, ConstVar.connect.DatabaseConnection(ConstVar.constr));
					ConstVar.sh.ShowData("select * from v_ReserveBoat", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_MainReserve.Default.dgvReserveBoat);
					frm_MainReserve.Default.cbYet.Checked = true;
				}
				else
				{
					string sqlCustomer = "Insert into tb_customer values('" + txtID.Text + "',N'" + txtName.Text + "',N'" + txtLastName.Text + "','" + txtTel.Text + "','" + txtTel2.Text + "')";
					//   Dim sql = "insert into tb_Reserveboat(reserveID, reserveDate, reserveComeDate, reserveComeTime, reserveStatus, customerID, employeeID) VALUES('" & txtReservID.Text & "','" & dtvReserve.Value.ToString("MM/dd/yyyy") & "','" & dtpDatecome.Value.ToString("MM/dd/yyyy") & "','" & txtTime.Text & "',N'ຍັງບໍ່ມາ','" & txtID.Text & "','" & emID & "')"
					var sql = "insert into tb_ReserveBoat VALUES('" + txtReservID.Text + "','" + ConstVar.emID + "','" + txtBoatID.Text + "','" + txtID.Text + "','" + dtvReserve.Value.ToString("MM/dd/yyyy") + "','" + dtpDatecome.Value.ToString("MM/dd/yyyy") + "','" + txtTime.Text + "','" + txtHour.Text + "',N'ຍັງບໍ່ມາ','" + serveStyle + "')";
					ConstVar.sav.Insert(sqlCustomer, ConstVar.connect.DatabaseConnection(ConstVar.constr));
					ConstVar.sav.Insert(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
					txtID.Text = ConstVar.au.SetID(ConstVar.constr, "CustomerID", "tb_Customer", "C", 1, 4, 4, "0000");
					txtReservID.Text = ConstVar.au.SetID(ConstVar.constr, "reserveID", "tb_ReserveBoat", "RSB", 3, 5, 5, "00000");
					txtName.Text = "";
					txtLastName.Text = "";
					txtTel.Text = "";
					txtTel2.Text = "";
					txtTime.Text = "";
					//   Dispose()
					string sqlboat = "";
					string sqlinsert;
					sqlboat = "update tb_boat set boatStatus = N'ຈອງແລ້ວ' where boatID='" + txtBoatID.Text + "'";
					ConstVar.upd.Update(sqlboat, ConstVar.connect.DatabaseConnection(ConstVar.constr));
					ConstVar.sh.ShowData("select * from v_ReserveBoat", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_MainReserve.Default.dgvReserveBoat);
					frm_MainReserve.Default.cbYet.Checked = true;
				}
			}
			
			
			
			
			
			
			
		}
		
		public void ButtonX4_Click(object sender, EventArgs e)
		{
			txtID.Text = ConstVar.au.SetID(ConstVar.constr, "CustomerID", "tb_Customer", "C", 1, 4, 4, "0000");
			txtReservID.Text = ConstVar.au.SetID(ConstVar.constr, "reserveID", "tb_ReserveBoat", "RSB", 3, 5, 5, "00000");
			txtName.Text = "";
			txtLastName.Text = "";
			txtTel.Text = "";
			txtTel2.Text = "";
			txtTime.Text = "";
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			string sql = "update tb_ReserveBoat set reserveComeDate = '" + dtpDatecome.Value.ToString("MM/dd/yyyy") + "', reserveComeTime = '" + txtTime.Text + "' WHERE reserveID = '" + txtReservID.Text + "'";
			ConstVar.upd.Update(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			txtName.Text = "";
			txtLastName.Text = "";
			txtTel.Text = "";
			txtTel2.Text = "";
			txtTime.Text = "";
		}
		
		public void ButtonX3_Click(object sender, EventArgs e)
		{
			Dispose();
			//MsgBox(btRefresh.Tag)
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
					//  btChooseBoat.Enabled = False
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
			string boatstatus = "";
			string boatpath = "";
			dr = cm.ExecuteReader();
			dr.Read();
			//Asign Value
			boatID = dr[0].ToString();
			boatName = dr[1].ToString();
			boatstatus = dr[2].ToString();
			boatpath = dr[3].ToString();
			txtBoatID.Text = boatID;
			btRefresh.Tag = boatstatus;
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
				// btChooseBoat.Enabled = True
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
		
		public void ButtonX6_Click(object sender, EventArgs e)
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
				sqlviewSell = "select * from v_Selling2 where [ລະຫັດເຮືອ] = '" + txtBoatID.Text + "' and [ສະຖານະ] != N'ຈ່າຍແລ້ວ' ";
				sqlReserve = "select * from v_Reserve3 where [ເຮືອ]='" + txtBoatID.Text + "' and [ສະຖານະ] != N'ມາໃຊ້ບໍລິການແລ້ວ'";
				ConstVar.sh.ShowData(sqlviewSell, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvService);
				ConstVar.sh.ShowData(sqlReserve, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				tmService.Start();
				btView.Text = "Collapse";
			}
			else if (btView.Text == "View Reserve")
			{
				sqlviewSell = "select * from v_Selling2 where [ລະຫັດເຮືອ] = '" + txtBoatID.Text + "' and [ສະຖານະ] != N'ຈ່າຍແລ້ວ' ";
				sqlReserve = "select * from v_Reserve3 where [ເຮືອ]='" + txtBoatID.Text + "'  and [ສະຖານະ] != N'ມາໃຊ້ບໍລິການແລ້ວ'";
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
		
		private void btChooseBoat_Click(object sender, EventArgs e)
		{
			
		}
		
		public void ButtonX6_Click_1(object sender, EventArgs e)
		{
			Dispose();
			
		}
		
		public void dtpDatecome_ValueChanged(object sender, EventArgs e)
		{
			//   Dim dr As SqlDataReader
			//    Dim cm As New SqlCommand()
			
			
			SqlDataReader dr = default(SqlDataReader);
			SqlDataReader dr1;
			SqlCommand cm = new SqlCommand("select  reserveComedate from tb_reserveBoat where reserveComeDate ='" + dtpDatecome.Text + "' and reserveStatus=N'ຍັງບໍ່ມາ'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
			// Dim cm2 As New SqlCommand("select boathour from tb_reserveBoat where reserveComeDate ='01/21/2017'", connect.DatabaseConnection(constr))
			dr = cm.ExecuteReader();
			
			
			
			if (dr.HasRows)
			{
				// dr.Read()
				//Dim time1 As String = dr(0).ToString
				//If time1 = dtpDatecome.Value Then
				MessageBox.Show("ສາມາດຈອງວັນທີນີ້ໃດ້, ແຕ່ຕ້ອງໃຫ້ເວລາບໍ່ຊໍ້າກັນກັບໃບບິນທີ່ຈອງກ່ອນໜ້ານີ້");
				// End If
			}
			else if (dr.HasRows)
			{
				MessageBox.Show("OK");
			}
			//
			//  dr1 = cm2.ExecuteReader()
			// dr1.Read()
		}
		
		public void txtTime_TextChanged(object sender, EventArgs e)
		{
			//If Not IsNumeric(txtTime.Text) Then
			//    txtTime.ResetText()
			//ElseIf txtTime.Text.Length > 5 Then
			//    txtTime.ResetText()
			//    ' If txtTime.Text.Substring(2, 1) = ":" Then
			//    ' MsgBox("OK")
			//    ' txtTime.Text = txtTime.Text
			
			//    ' If
			//    '  Else
			//End If
			
		}
	}
}
