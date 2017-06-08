
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
	public partial class frm_FoodGroup
	{
		public frm_FoodGroup()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_FoodGroup defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_FoodGroup Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_FoodGroup();
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
		string sqlshow = "SELECT * FROM v_FoodGroup";
		public void btSave_Click(object sender, EventArgs e)
		{
			var sqlScript = "select FoodGroupID from tb_FoodGroup where FoodgroupID = '" + txtID.Text + "'";
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
				save1.Insert("INSERT INTO  tb_FoodGroup VALUES('" + txtID.Text + "',N'" + txtName.Text + "',N'" + txtDEs.Text + "')", connect.DatabaseConnection(constr), "ຂໍ້ມູນກຸ່ມອາຫານລະຫັດ " + txtID.Text + " ໄດ້ຖືກບັນທຶກລົງໃນຖານຂໍ້ມູນແລ້ວ");
				show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
				txtID.Text = autoID.SetID(constr, "FoodGroupID", "tb_FoodGroup", "FG00", 2, 3);
				cleartxt();
			}
		}
		
		public void frm_FoodGroup_Load(object sender, EventArgs e)
		{
			show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
			txtID.Text = autoID.SetID(constr, "FoodGroupID", "tb_FoodGroup", "FG00", 2, 3);
		}
		
		public void btEdit_Click(object sender, EventArgs e)
		{
			classUpdate update = new classUpdate();
			update.Update("UPDATE tb_FoodGroup SET FoodGroupName=N'" + txtName.Text + "', FoodGroupDescription=N'" + txtDEs.Text + "' WHERE FoodGroupID = '" + txtID.Text + "'", connect.DatabaseConnection(constr), "ຂໍ້ມູນກຸ່ມອາຫານໄດ້ຖືກແກ້ໄຂແລ້ວ");
			show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
			txtID.Text = autoID.SetID(constr, "FoodGroupID", "tb_FoodGroup", "FG00", 2, 3);
			cleartxt();
		}
		
		public void dgvFoodType_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvFoodType.Rows[dgvFoodType.CurrentRow.Index];
			txtID.Text = System.Convert.ToString(with_1.Cells[0].Value);
			txtName.Text = System.Convert.ToString(with_1.Cells[1].Value);
			txtDEs.Text = System.Convert.ToString(with_1.Cells[2].Value);
		}
		public void cleartxt()
		{
			txtName.Clear();
			txtDEs.Clear();
			txtName.Focus();
			txtID.Text = autoID.SetID(constr, "FoodGroupID", "tb_FoodGroup", "FG00", 2, 3);
		}
		
		public void btClear_Click(object sender, EventArgs e)
		{
			cleartxt();
		}
		
		public void btDelete_Click(object sender, EventArgs e)
		{
			classDelete del = new classDelete();
			DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການທີ່ຈະລົບ " + txtID.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				del.Delete("DELETE FROM tb_FoodGroup WHERE foodGroupID = '" + txtID.Text + "'", connect.DatabaseConnection(constr));
				show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvFoodType);
			}
			txtID.Text = autoID.SetID(constr, "FoodGroupID", "tb_FoodGroup", "FG00", 2, 3);
			cleartxt();
		}
		
		public void btExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
