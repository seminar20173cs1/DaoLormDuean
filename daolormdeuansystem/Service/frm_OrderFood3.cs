
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
	public partial class frm_OrderFood3
	{
		public frm_OrderFood3()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_OrderFood3 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_OrderFood3 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_OrderFood3();
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
		string selldetailID;
		AutoID auto1 = new AutoID();
		classShowData sh1 = new classShowData();
		classDatabaseConnection cn = new classDatabaseConnection();
		public void frm_OrderFood3_Load(object sender, EventArgs e)
		{
			//  sh1.ShowData("SELECT        dbo.tb_FoodAndDrink.foodName, dbo.tb_SellDetail.foodPrice, dbo.tb_SellDetail.foodAmount
			//        From            dbo.tb_FoodAndDrink INNER JOIN
			//   dbo.tb_SellDetail ON dbo.tb_FoodAndDrink.foodID = dbo.tb_SellDetail.foodID WHERE SellID = '" & frm_MainService.dgvOrder.Rows(frm_MainService.dgvOrder.CurrentRow.Index).Cells(0).Value & "'", cn.DatabaseConnection(constr), dgvOrderFood)
			//
			sh1.ShowData("select * from v_sellDetail1 where SellID ='" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderFood);
			
			ConstVar.sh.ShowData("select * from v_menu", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvFood);
			dgvFood.Columns[0].Width = 70;
			dgvFood.Columns[1].Width = 70 + 70;
			dgvFood.Columns[3].Width = 0;
			dgvFood.Columns[4].Width = 0;
			dgvFood.Columns[5].Width = 0;
			dgvOrderFood.Columns[4].Width = 0;
			dgvOrderFood.Columns[3].Width = 0;
		}
		
		public void dgvFood_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvFood.Rows[dgvFood.CurrentRow.Index];
			txtid.Text = System.Convert.ToString(with_1.Cells[0].Value);
			txtname.Text = System.Convert.ToString(with_1.Cells[1].Value);
			txtprice.Text = System.Convert.ToString(with_1.Cells[2].Value);
			ptbfood.Image = Image.FromFile(System.Convert.ToString(with_1.Cells[3].Value));
			txtamount.Focus();
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			//  sh.ShowData("select * from v_Selectedfood where sellid ='" & txtamount.Text & "'", connect.DatabaseConnection(constr), dgvOrderFood)
			
			string sql = "";
			//  sh.ShowData("select * from v_Menu where ")
			if (rbname1.Checked == true)
			{
				sql = "select * from v_Menu where [ລາຍການ] like (N'%" + txtSearch.Text + "%')";
				ConstVar.sh.ShowData(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvFood);
			}
			else if (rbID.Checked == true)
			{
				sql = "select * from v_Menu where [ລະຫັດ] ='" + txtSearch.Text + "'";
				ConstVar.sh.ShowData(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvFood);
			}
			else if (rbGroup.Checked == true)
			{
				sql = "select * from v_Menu where foodGroupName= N'" + txtSearch.Text + "'";
				ConstVar.sh.ShowData(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvFood);
			}
			else if (rbCategory.Checked == true)
			{
				sql = "select * from v_Menu where foodTypeName= N'" + txtSearch.Text + "'";
				ConstVar.sh.ShowData(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvFood);
			}
			
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			
			selldetailID = ConstVar.au.SetID(ConstVar.constr, "SellDetailID", "tb_SellDetail", "", 0, 10, 10, "0000000000");
			
			string sql = "select foodID from tb_Selldetail where foodID = '" + txtid.Text + "' and sellID = '" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
			SqlCommand cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			SqlDataReader dr = default(SqlDataReader);
			dr = cm.ExecuteReader();
			dr.Read();
			if (dr.HasRows)
			{
				// Dim sqlAdd As String = "Update tb_SellDetail Set foodAmount = "
				string sqladd = "update tb_SellDetail set foodAmount = foodAmount + '" + txtamount.Text + "'  where  foodID = '" + txtid.Text + "'  and SellID = '" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "'";
				ConstVar.upd.Update(sqladd, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				//sh1.ShowData("SELECT        dbo.tb_FoodAndDrink.foodName, dbo.tb_SellDetail.foodPrice, dbo.tb_SellDetail.foodAmount FROM dbo.tb_FoodAndDrink INNER JOIN dbo.tb_SellDetail ON dbo.tb_FoodAndDrink.foodID = dbo.tb_SellDetail.foodID WHERE SellID = '" & frm_MainService.dgvOrder.Rows(frm_MainService.dgvOrder.CurrentRow.Index).Cells(0).Value & "'", cn.DatabaseConnection(constr), dgvOrderFood)
				sh1.ShowData("select * from v_sellDetail1 where SellID ='" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderFood);
				txtamount.Clear();
				txtamount.Focus();
				//   MsgBox("Ok")
				
			}
			else
			{
				ConstVar.sav.Insert("insert into tb_SellDetail VALUES('" + selldetailID + "','" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "','" + txtid.Text + "','" + txtprice.Text + "','" + txtamount.Text + "')", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				//  MsgBox(selldetailID)
				//sh1.ShowData("SELECT        dbo.tb_FoodAndDrink.foodName, dbo.tb_SellDetail.foodPrice, dbo.tb_SellDetail.foodAmount FROM dbo.tb_FoodAndDrink INNER JOIN dbo.tb_SellDetail ON dbo.tb_FoodAndDrink.foodID = dbo.tb_SellDetail.foodID WHERE SellID = '" & frm_MainService.dgvOrder.Rows(frm_MainService.dgvOrder.CurrentRow.Index).Cells(0).Value & "'", cn.DatabaseConnection(constr), dgvOrderFood)
				sh1.ShowData("select * from v_sellDetail1 where SellID ='" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderFood);
				
				
				txtamount.Clear();
				txtamount.Focus();
				
			}
			
		}
		
		public void ButtonX3_Click(object sender, EventArgs e)
		{
			frm_ChangeAmountFood reorder = new frm_ChangeAmountFood();
			reorder.ShowDialog();
			int i = 0;
			int countrows = 0;
			int sum = 0;
			countrows = frm_MainService.Default.dgvOrderDetail.RowCount;
			for (i = 0; i <= countrows - 1; i++)
			{
				sum += System.Convert.ToInt32(frm_MainService.Default.dgvOrderDetail.Rows[i].Cells[5].Value);
			}
			frm_MainService.Default.txtTotal.Tag = sum;
			frm_MainService.Default.txtTotal.Text = Strings.Format(sum, "#,### ກີບ");
		}
		
		public void ButtonX4_Click(object sender, EventArgs e)
		{
			ConstVar.dell.Delete("delete from tb_SellDetail where SelldetailID = '" + System.Convert.ToString(dgvOrderFood.Rows[dgvOrderFood.CurrentRow.Index].Cells[4].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
			//   sh.ShowData("select * from v_SellDetail where SellID = '" & frm_MainService.dgvOrder.Rows(frm_MainService.dgvOrder.CurrentRow.Index).Cells(0).Value & "'", connect.DatabaseConnection(constr), frm_MainService.dgvOrderDetail)
			sh1.ShowData("select * from v_sellDetail1 where SellID ='" + System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvOrderFood);
			int i = 0;
			int countrows = 0;
			int sum = 0;
			countrows = frm_MainService.Default.dgvOrderDetail.RowCount;
			for (i = 0; i <= countrows - 1; i++)
			{
				sum += System.Convert.ToInt32(frm_MainService.Default.dgvOrderDetail.Rows[i].Cells[5].Value);
			}
			frm_MainService.Default.txtTotal.Tag = sum;
			frm_MainService.Default.txtTotal.Text = Strings.Format(sum, "#,### ກີບ");
		}
		
		public void ButtonX5_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
