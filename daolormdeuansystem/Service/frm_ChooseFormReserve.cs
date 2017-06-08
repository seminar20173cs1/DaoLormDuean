
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
	public partial class frm_ChoosFormReserve
	{
		public frm_ChoosFormReserve()
		{
			InitializeComponent();
		}
		public void frm_ChooseFormReserve_Load(object sender, EventArgs e)
		{
			pgbLoadData.Value = 0;
			//   sh.ShowData("select * from v_ReserveBoat", connect.DatabaseConnection(constr), dgvReserveBoat)
			
			//sh.ShowData("select * from v_Reserve3 where [ສະຖານະ] =N'ຢືນຢັນແລ້ວ'", connect.DatabaseConnection(constr), dgvReserveBoat)
			ConstVar.sh.ShowData("select * from v_reserve3 where [ວັນທີ່ຈະມາ] = convert(varchar(10),getdate(), 101) and [ສະຖານະ] =N'ຢືນຢັນແລ້ວ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveBoat);
			
			
			if (dgvReserveBoat.RowCount == 0)
			{
				MessageBox.Show("ບໍ່ມີຂໍ້ມູນການຈອງໃນມື້ນີ້", "ແຈ້ງການ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		string tempID;
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			if (ButtonX1.Text == "ເປີດໃຊ້ບໍລິການ")
			{
				if (dgvReserveBoat.RowCount == 0)
				{
					MessageBox.Show("ບໍ່ມີຂໍ້ມູນການຈອງໃນມື້ນີ້", "ແຈ້ງການ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				ButtonX1.Text = "ກະລຸນາລໍຖ້າ";
				SqlCommand cm1 = new SqlCommand("select employeeID from tb_employee where employeeName = '" + Frm_Main.Default.btUser.Text + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				SqlDataReader dr1 = default(SqlDataReader);
				dr1 = cm1.ExecuteReader();
				dr1.Read();
				ConstVar.emID = dr1[0].ToString();
				string id = "";
				id = ConstVar.au.SetID(ConstVar.constr, "SellID", "tb_Selling", "DLD", 3, 11, 11, "00000000000");
				tempID = id;
				string sqlUpdateReserveStatus = "Update tb_ReserveBoat set reserveStatus=N'ມາໃຊ້ບໍລິການແລ້ວ' where reserveID = '" + System.Convert.ToString(dgvReserveBoat.Rows[dgvReserveBoat.CurrentRow.Index].Cells[0].Value) + "'";
				string sqlChangeFromReserveToSelling = "insert into tb_Selling(SellID, EmployeeID, BoatID, boatSailHourInit, dateCome, increase, discount, sellStatus, serveStyle) values('" + id + "','" + ConstVar.emID + "','" + System.Convert.ToString(dgvReserveBoat.Rows[dgvReserveBoat.CurrentRow.Index].Cells[2].Value) + "','" + System.Convert.ToString(dgvReserveBoat.Rows[dgvReserveBoat.CurrentRow.Index].Cells[7].Value) + "',getdate(),'0','0',N'ຕຽມການ','0')";
				string sqlSetBoatStatus = "Update tb_boat set boatStatus=N'ບໍ່ວ່າງ' where boatID = '" + System.Convert.ToString(dgvReserveBoat.Rows[dgvReserveBoat.CurrentRow.Index].Cells[2].Value) + "'";
				ConstVar.upd.Update(sqlUpdateReserveStatus, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				ConstVar.upd.Update(sqlSetBoatStatus, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				ConstVar.sav.Insert(sqlChangeFromReserveToSelling, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				Timer1.Start();
			}
			else if (ButtonX1.Text == "ສໍາເລັດ")
			{
				Dispose();
			}
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			pgbLoadData.Increment(1);
			if (pgbLoadData.Value == 50)
			{
				var sqlReserveFoodDetailData = "Select FoodID, foodAmount, foodPrice from tb_reserveFood where reserveID='" + System.Convert.ToString(dgvReserveBoat.Rows[dgvReserveBoat.CurrentRow.Index].Cells[0].Value) + "'";
				DataTable dt = new DataTable();
				string foodID = "";
				string foodAmount = "";
				string foodPrice = "";
				SqlDataAdapter da = new SqlDataAdapter(sqlReserveFoodDetailData, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				da.Fill(dt);
				foreach (DataRow row in dt.Rows)
				{
					foodID = System.Convert.ToString(row["foodID"]);
					foodAmount = System.Convert.ToString(row["foodAmount"]);
					foodPrice = System.Convert.ToString(row["foodPrice"]);
					string selldetailID = ConstVar.au.SetID(ConstVar.constr, "SellDetailID", "tb_SellDetail", "", 0, 10, 10, "0000000000");
					string sqlConverDataToSelling = "insert into tb_SellDetail values('" + selldetailID + "','" + tempID + "','" + foodID + "','" + foodPrice + "','" + foodAmount + "')";
					ConstVar.sav.Insert(sqlConverDataToSelling, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				}
			}
			else if (pgbLoadData.Value == 100)
			{
				Timer1.Stop();
				//  sh.ShowData("select * from v_Reserve3 where [ສະຖານະ] =N'ຢືນຢັນແລ້ວ'", connect.DatabaseConnection(constr), dgvReserveBoat)
				ConstVar.sh.ShowData("select * from v_reserve3 where [ວັນທີ່ຈະມາ] = convert(varchar(10),getdate(), 101) and [ສະຖານະ] =N'ຢືນຢັນແລ້ວ'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveBoat);
				pgbLoadData.Visible = false;
				ButtonX1.Text = "ສໍາເລັດ";
			}
		}
	}
}
