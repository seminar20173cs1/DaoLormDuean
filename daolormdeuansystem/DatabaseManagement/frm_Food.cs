
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
	public partial class frm_food
	{
		public frm_food()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_food defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_food Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_food();
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
		classShowData show = new classShowData();
		AutoID autoID = new AutoID();
		string constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True";
		classDatabaseConnection connect = new classDatabaseConnection();
		string sqlInsert;
		string sqlshow = "SELECT * FROM v_FoodAndDrink";
		private void ptbProfile_Click(object sender, EventArgs e)
		{
			
		}
		
		private void ptbProfile_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			
		}
		
		public void frm_Food_Load(object sender, EventArgs e)
		{
			this.UseWaitCursor = true;
			show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvEmployee);
			Panel2.Height = 0;
			show.ShowDataInCombobox("Select FoodTypeID, FoodTypeName From tb_FoodType", connect.DatabaseConnection(constr), cbFoodType, "FoodTypeID", "FoodTypeName");
			show.ShowDataInCombobox("Select FoodGroupID, FoodGroupName From tb_FoodGroup", connect.DatabaseConnection(constr), cbfoodGroup, "FoodGroupID", "FoodGroupName");
			show.ShowDataInCombobox("Select UnitID, UnitName From tb_Unit", connect.DatabaseConnection(constr), cbUnit, "UnitID", "UnitName");
			txtID1.Text = autoID.SetID(constr, "FoodID", "tb_FoodAndDrink", "FD00", 2, 3);
			pnbt.BackColor = Color.FromArgb(70, Color.Black);
			//  pndata.BackColor = Color.FromArgb(70, Color.Black)
			Panel3.BackColor = Color.FromArgb(70, Color.Black);
		}
		
		private void dgvEmployee_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvEmployee.Rows[dgvEmployee.CurrentRow.Index];
			txtID1.Text = System.Convert.ToString(with_1.Cells[0].Value);
			cbfoodGroup.Text = System.Convert.ToString(with_1.Cells[1].Value);
			cbFoodType.Text = System.Convert.ToString(with_1.Cells[2].Value);
			txtName1.Text = System.Convert.ToString(with_1.Cells[3].Value);
			cbUnit.Text = System.Convert.ToString(with_1.Cells[4].Value);
			txtPrice1.Text = System.Convert.ToString(with_1.Cells[5].Value);
			txtPath1.Text = System.Convert.ToString(with_1.Cells[6].Value);
			ptbProfile.Image = Image.FromFile(txtPath1.Text);
			
		}
		
		private void btSave_Click(object sender, EventArgs e)
		{
			
			
		}
		public void cleartxt()
		{
			txtName1.Clear();
			txtPath1.Clear();
			txtPrice1.Clear();
			cbfoodGroup.SelectedIndex = 0;
			cbFoodType.SelectedIndex = 0;
			cbUnit.SelectedIndex = 0;
			ptbProfile.Image = null;
			txtID1.Text = autoID.SetID(constr, "FoodID", "tb_FoodAndDrink", "FD00", 2, 3);
			cbFoodType.Focus();
		}
		
		private void btClear_Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		
		
		public void dgvEmployee_Click_1(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvEmployee.Rows[dgvEmployee.CurrentRow.Index];
			txtID1.Text = System.Convert.ToString(with_1.Cells[0].Value);
			cbfoodGroup.Text = System.Convert.ToString(with_1.Cells[1].Value);
			cbFoodType.Text = System.Convert.ToString(with_1.Cells[2].Value);
			txtName1.Text = System.Convert.ToString(with_1.Cells[3].Value);
			cbUnit.Text = System.Convert.ToString(with_1.Cells[4].Value);
			txtPrice1.Text = System.Convert.ToString(with_1.Cells[5].Value);
			if ((string) (with_1.Cells[5].Value) == "")
			{
				txtPath1.Text = "";
				ptbProfile.Image = null;
			}
			else
			{
				txtPath1.Text = System.Convert.ToString(with_1.Cells[6].Value);
			ptbProfile.Image = Image.FromFile(txtPath1.Text);
			}
			
			
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			var sqlScript = "select FoodID from tb_FoodAndDrink where FoodID = '" + txtID1.Text + "'";
			SQL.SQLCmd = new System.Data.SqlClient.SqlCommand(sqlScript, SQL.SQLCon);
			SQL.SQLCon.Open();
			SQL.SQLDr = SQL.SQLCmd.ExecuteReader();
			if (SQL.SQLDr.HasRows)
			{
				MessageBox.Show("ລະຫັດນີ້ມີຢູ່ໃນຖານຂໍ້ມູນແລ້ວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				ClassInsert insert = new ClassInsert();
				insert.Insert("INSERT INTO tb_FoodAndDrink VALUES('" + txtID1.Text + "','" + System.Convert.ToString(cbfoodGroup.SelectedValue) + "','" + System.Convert.ToString(cbFoodType.SelectedValue) + "',N'" + txtName1.Text + "','" + System.Convert.ToString(cbUnit.SelectedValue) + "','" + txtPrice1.Text + "','" + txtPath1.Text + "')", connect.DatabaseConnection(constr), "ຂໍ້ມູນອາຫານລະຫັດ " + txtID1.Text + " ໄດ້ຖືກບັນທຶກລົງໃນຖານຂໍ້ມູນແລ້ວ");
				show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvEmployee);
				cleartxt();
			}
			SQL.SQLCon.Close();
		}
		
		public void btDelete1_Click(object sender, EventArgs e)
		{
			classDelete del = new classDelete();
			DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການທີ່ຈະລົບ " + txtID1.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				
				del.Delete("DELETE FROM  tb_FoodAndDrink WHERE FoodID='" + txtID1.Text + "'", connect.DatabaseConnection(constr));
				show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvEmployee);
				txtID1.Text = autoID.SetID(constr, "FoodID", "tb_FoodAndDrink", "FD00", 2, 3);
				cleartxt();
			}
		}
		
		public void btEdit1_Click(object sender, EventArgs e)
		{
			classUpdate update = new classUpdate();
			update.Update("UPDATE tb_FoodAndDrink SET FoodGroupID='" + System.Convert.ToString(cbfoodGroup.SelectedValue) + "', FoodTypeID='" + System.Convert.ToString(cbFoodType.SelectedValue) + "', FoodName=N'" + txtName1.Text + "', UnitID='" + System.Convert.ToString(cbUnit.SelectedValue) + "', FoodPrice = '" + txtPrice1.Text + "', foodPhotoPath='" + txtPath1.Text + "' WHERE FoodID='" + txtID1.Text + "'", connect.DatabaseConnection(constr), "ຂໍ້ມູນເຮືອໄດ້ຖືກແກ້ໄຂແລ້ວ");
			show.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvEmployee);
			txtID1.Text = autoID.SetID(constr, "FoodID", "tb_FoodAndDrink", "FD00", 2, 3);
			cleartxt();
		}
		
		public void btChoos1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog1.ShowDialog();
				txtPath1.Text = OpenFileDialog1.FileName;
				ptbProfile.Image = Image.FromFile(txtPath1.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("mun Error hu bor!!");
			}
		}
		
		public void btClear1_Click(object sender, EventArgs e)
		{
			cleartxt();
		}
		
		public void ptbProfile_Click_1(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog1.ShowDialog();
				txtPath1.Text = OpenFileDialog1.FileName;
				ptbProfile.Image = Image.FromFile(txtPath1.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Error!");
			}
		}
		
		public void btExit1_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			if (ButtonX2.Text == "ເບິ່ງຂໍ້ມູນ")
			{
				Panel2.Show();
				Timer1.Start();
				ButtonX2.Text = "ພັບໄວ້";
			}
			else if (ButtonX2.Text == "ພັບໄວ້")
			{
				Panel2.Hide();
				Panel2.Height = 0;
				ButtonX2.Text = "ເບິ່ງຂໍ້ມູນ";
			}
			
			
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			if (Panel2.Height <= 200)
			{
				Panel2.Height = Panel2.Height + 10;
			}
			else
			{
				Timer1.Stop();
			}
		}
		
		public void dgvEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Panel2.Hide();
			Panel2.Height = 0;
			ButtonX2.Text = "ເບິ່ງຂໍ້ມູນ";
		}
		
		public void btSave1_Click(object sender, EventArgs e)
		{
			this.UseWaitCursor = false;
		}
	}
}
