
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
	public partial class frm_ChooseBoat
	{
		public frm_ChooseBoat()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_ChooseBoat defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_ChooseBoat Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_ChooseBoat();
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
		Button BoatMenu;
		public void Button1_Click(object sender, EventArgs e)
		{
			pnboat.Controls.Clear();
			loadBoat();
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
			txtBoatName.Text = boatName;
			btRefresh.Tag = boatstatus;
			//Check Value
			if (string.IsNullOrEmpty(boatpath))
			{
				ptbboat.Image = null;
			}
			else
			{
				ptbboat.Image = Image.FromFile(boatpath);
			}
			
			if (boatstatus == "ວ່າງ")
			{
				btChooseBoat.Enabled = true;
			}
			else if (boatstatus == "ບໍ່ວ່າງ")
			{
				btChooseBoat.Enabled = false;
			}
			else if (boatstatus == "ຈອງແລ້ວ")
			{
				btChooseBoat.Enabled = true;
			}
			if ((string) btRefresh.Tag == "ຈອງແລ້ວ")
			{
				btView.Text = "View Reserve";
				btView.Visible = true;
			}
			else if ((string) btRefresh.Tag == "ວ່າງ")
			{
				
				btView.Visible = false;
			}
			else if ((string) btRefresh.Tag == "ບໍ່ວ່າງ")
			{
				btView.Text = "View Service";
				btView.Visible = true;
			}
			
			
		}
		
		
		public void frm_ChooseBoat_Load(object sender, EventArgs e)
		{
			dgvSelling.Height = 0;
			loadBoat();
			pnboat.BackColor = Color.FromArgb(50, Color.Black);
			Panel1.BackColor = Color.FromArgb(50, Color.Black);
			btView.Visible = false;
		}
		public void loadBoat()
		{
			SqlCommand cm = new SqlCommand("select  count(boatID) from tb_boat", ConstVar.connect.DatabaseConnection(ConstVar.constr));
			SqlDataReader dr = default(SqlDataReader);
			SqlDataAdapter da = default(SqlDataAdapter);
			dr = cm.ExecuteReader();
			dr.Read();
			string boatAmount = dr[0].ToString();
			//  Button1.Text = boatAmount
			int boatno = 0;
			string sqlboatDetail = "Select boatID, boatStatus from tb_Boat";
			//__________________________________
			//Dim cm1 As New SqlCommand("select boatID from tb_boat", connect.DatabaseConnection(constr))
			//Dim cm2 As New SqlCommand("select boatstatus from tb_boat", connect.DatabaseConnection(constr))
			DataTable dt = new DataTable();
			//Dim dr2 As SqlDataReader
			//dr2 = cm2.ExecuteReader()
			//dr.Read()
			//dr2.Read()
			string id = "";
			string status = "";
			da = new SqlDataAdapter(sqlboatDetail, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da.Fill(dt);
			
			//__________________________________
			
			//    For i As Integer = 1 To CInt(boatAmount)
			
			foreach (DataRow row in dt.Rows)
			{
				BoatMenu = new Button();
				// Dim BoatMenu As New Button
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
				BoatMenu.Width = 150;
				BoatMenu.Height = 70;
				
				BoatMenu.Click += this.OnBoatMenuClick;
				pnboat.Controls.Add(BoatMenu);
			}
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			
			
			frm_MainService.Default.RadioButton5.Checked = true;
			Dispose();
		}
		AutoID Auto = new AutoID();
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			
			if (txtHour.Text == "")
			{
				MessageBox.Show("ກະລຸນາປ້ອນຊົ່ວໂມງ");
				return;
			}
			SqlCommand cm1 = new SqlCommand("select employeeID from tb_employee where employeeName = '" + Frm_Main.Default.btUser.Text + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
			SqlDataReader dr1 = default(SqlDataReader);
			dr1 = cm1.ExecuteReader();
			dr1.Read();
			ConstVar.emID = dr1[0].ToString();
			//   MsgBox(emID)
			
			string boatstate = "ບໍ່ວ່າງ";
			string id = "";
			//    id = auto.SetID(constr, "SellID", "tb_Selling", "DLD", 3, 11, 11, "00000000000")
			
			id = Auto.SetID(ConstVar.constr, "SellID", "tb_Selling", "DLD", 3, 11, 11, "00000000000");
			//MsgBox(id)
			string ServiceStyle = "";
			if ((string) btRefresh.Tag == "ຈອງແລ້ວ")
			{
				
				ServiceStyle = System.Convert.ToString(1);
			}
			else if ((string) btRefresh.Tag == "ວ່າງ")
			{
				ServiceStyle = System.Convert.ToString(0);
				
				
			}
			string sqlboatStatusUpdate = "Update tb_Boat SET boatStatus = N'" + boatstate + "' WHERE boatid = '" + txtBoatID.Text + "'";
			classUpdate up = new classUpdate();
			up.Update(sqlboatStatusUpdate, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			var sql = "insert into tb_Selling(SellID, employeeID,boatID,dateCome, sellStatus,BoatSailHourInit, increase, discount, serveStyle) VALUES('" + id + "','" + ConstVar.emID + "','" + txtBoatID.Text.Trim() + "',getdate(),N'ຕຽມການ', '" + txtHour.Text + "',0,0, '" + ServiceStyle + "')";
			ClassInsert save = new ClassInsert();
			save.Insert(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			this.Close();
			show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_MainService.Default.dgvOrder);
			show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_MainService.Default.dgvOrderDetail);
			frm_MainService.Default.RadioButton3.Checked = true;
		}
		classShowData show = new classShowData();
		public void btChoose_FormClosed(object sender, FormClosedEventArgs e)
		{
			frm_MainService.Default.dgvOrder.Refresh();
			show.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_MainService.Default.dgvOrder);
			show.ShowData("select * from v_SellDetail", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_MainService.Default.dgvOrderDetail);
		}
		
		private void Button2_Click(object sender, EventArgs e)
		{
			//  MsgBox(btRefresh.Tag)
			
		}
		
		public void btView_Click(object sender, EventArgs e)
		{
			var sql = "select * from v_Selling2 where [ລະຫັດເຮືອ] = '" + txtBoatID.Text + "' and [ສະຖານະ] != N'ຈ່າຍແລ້ວ'";
			ConstVar.sh.ShowData(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvSelling);
			string sqlReserve = "select * from v_Reserve3 where [ເຮືອ]='" + txtBoatID.Text + "'  and [ສະຖານະ] != N'ມາໃຊ້ບໍລິການແລ້ວ'";
			ConstVar.sh.ShowData(sqlReserve, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
			dgvReserve.Columns[3].DefaultCellStyle.Format = "HH:mm";
			if (btView.Text == "View Service")
			{
				//frm_ViewSelling.Show()
				tmViewSelling.Start();
				btView.Text = "ພັບໄວ້";
			}
			else if (btView.Text == "ພັບໄວ້")
			{
				btView.Text = "View Service";
				dgvSelling.Height = 0;
				
				dgvReserve.Height = 0;
			}
			else if (btView.Text == "View Reserve")
			{
				
				
				//  tmViewReserve.Start()
				// MsgBox("Hello")
				
				
				
				//      Dim sqlviewSell As String = "select * from v_Selling2 where [ລະຫັດເຮືອ] = '" & txtBoatID.Text & "' and [ສະຖານະ] != N'ຈ່າຍແລ້ວ'"
				sqlReserve = "select * from v_Reserve3 where [ເຮືອ]='" + txtBoatID.Text + "'  and [ສະຖານະ] != N'ມາໃຊ້ບໍລິການແລ້ວ'";
				//    sh.ShowData(sqlviewSell, connect.DatabaseConnection(constr), dgvSelling)
				ConstVar.sh.ShowData(sqlReserve, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserve);
				tmViewReserve.Start();
				btView.Text = "ພັບໄວ້";
			}
		}
		
		public void tmViewSelling_Tick(object sender, EventArgs e)
		{
			
			if (dgvSelling.Height <= 100)
			{
				dgvSelling.Height = dgvSelling.Height + 5;
			}
			else
			{
				tmViewSelling.Stop();
			}
		}
		
		public void tmViewReserve_Tick(object sender, EventArgs e)
		{
			if (dgvReserve.Height <= 100)
			{
				dgvReserve.Height = dgvReserve.Height + 5;
			}
			else
			{
				tmViewReserve.Stop();
			}
		}
		
		public void frm_ChooseBoat_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		
		public void frm_ChooseBoat_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				
				this.Close();
			}
		}
	}
	
	
	
}
