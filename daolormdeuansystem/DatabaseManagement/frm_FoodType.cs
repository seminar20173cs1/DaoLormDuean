
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
	public partial class frm_FoodType
	{
		public frm_FoodType()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_FoodType defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_FoodType Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_FoodType();
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
		SQLControl SQL = new SQLControl();
		AutoID autoID = new AutoID();
		classShowData show = new classShowData();
		string constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True";
		classDatabaseConnection connect = new classDatabaseConnection();
		string sqlInsert;
		string sqlshow = "SELECT * FROM v_FoodType";
		public void btExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void frm_FoodType_Load(object sender, EventArgs e)
		{
			// TabControl1.BackColor = Color.FromArgb(70, Color.Black)
			//  TabPage1.BackColor = Color.FromArgb(70, Color.Black)
			//TabPage2.BackColor = Color.FromArgb(70, Color.Black)
			show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
			//    txtID.Text = autoID.SetID(constr, "FoodtypeID", "tb_FoodType", "FT00", 2, 3)
			txtID.Text = autoID.SetID(constr, "foodTypeID", "tb_foodType", "FT", 2, 3, 3, "000");
		}
		
		public void btSave_Click(object sender, EventArgs e)
		{
			var sqlScript = "select FoodTypeID from tb_FoodType where FoodTypeID = '" + txtID.Text + "'";
			//SQL.SQLCm = New SqlCommand(sqlScript, db.DatabaseConnection(constr))
			//db.SQLDr = db.SQLCm.ExecuteReader()
			// Timer1.Enabled = True
			SQL.SQLCmd = new System.Data.SqlClient.SqlCommand(sqlScript, SQL.SQLCon);
			SQL.SQLCon.Open();
			SQL.SQLDr = SQL.SQLCmd.ExecuteReader();
			if (SQL.SQLDr.HasRows)
			{
				MessageBox.Show("ລະຫັດນີ້ມີຢູ່ໃນຖານຂໍ້ມູນແລ້ວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				
				ClassInsert save1 = new ClassInsert();
				save1.Insert("INSERT INTO  tb_FoodType VALUES('" + txtID.Text + "',N'" + txtName.Text + "',N'" + txtDEs.Text + "')", connect.DatabaseConnection(constr), "ຂໍ້ມູນປະເພດອາຫານລະຫັດ " + txtID.Text + " ໄດ້ຖືກບັນທຶກລົງໃນຖານຂໍ້ມູນແລ້ວ");
				show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
				txtID.Text = autoID.SetID(constr, "foodTypeID", "tb_foodType", "FT", 2, 3, 3, "000");
			}
			SQL.SQLCon.Close();
		}
		
		public void btEdit_Click(object sender, EventArgs e)
		{
			classUpdate update = new classUpdate();
			update.Update("UPDATE tb_FoodType SET FoodTypeName=N'" + txtName.Text + "', FoodTypeDescription=N'" + txtDEs.Text + "' WHERE FoodTypeID = '" + txtID.Text + "'", connect.DatabaseConnection(constr), "ຂໍ້ມູນປະເພດອາຫານໄດ້ຖືກແກ້ໄຂແລ້ວ");
			show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
			txtID.Text = autoID.SetID(constr, "foodTypeID", "tb_foodType", "FT", 2, 3, 3, "000");
		}
		public void cleartxt()
		{
			txtName.Clear();
			txtDEs.Clear();
			txtName.Focus();
			txtID.Text = autoID.SetID(constr, "foodTypeID", "tb_foodType", "FT", 2, 3, 3, "000");
		}
		
		public void dgvFoodType_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvFoodType.Rows[dgvFoodType.CurrentRow.Index];
			txtID.Text = System.Convert.ToString(with_1.Cells[0].Value);
			txtName.Text = System.Convert.ToString(with_1.Cells[1].Value);
			txtDEs.Text = System.Convert.ToString(with_1.Cells[2].Value);
		}
		
		public void btClear_Click(object sender, EventArgs e)
		{
			cleartxt();
			txtID.Text = autoID.SetID(constr, "foodTypeID", "tb_foodType", "FT", 2, 3, 3, "000");
			
		}
		
		public void btDelete_Click(object sender, EventArgs e)
		{
			classDelete del = new classDelete();
			DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການທີ່ຈະລົບ " + txtID.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				del.Delete("DELETE FROM tb_FoodType WHERE foodTypeID = '" + txtID.Text + "'", connect.DatabaseConnection(constr));
				show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
			}
			txtID.Text = autoID.SetID(constr, "FoodtypeID", "tb_FoodType", "FT00", 2, 3);
			cleartxt();
		}
	}
}
