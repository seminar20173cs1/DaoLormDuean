
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
	public partial class frm_Unit
	{
		public frm_Unit()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_Unit defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_Unit Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_Unit();
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
		classShowData show = new classShowData();
		string constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True";
		SQLControl SQL = new SQLControl();
		AutoID idauto = new AutoID();
		classDatabaseConnection connect = new classDatabaseConnection();
		Cleartxt clr;
		public void btExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void frm_Unit_Load(object sender, EventArgs e)
		{
			txtUnitID.Text = idauto.SetID(constr, "UnitID", "tb_Unit", "UN00", 2, 3);
			show.ShowData("SELECT * FROM v_Unit", connect.DatabaseConnection(constr), dgvUnit);
		}
		
		public void btSAve_Click(object sender, EventArgs e)
		{
			string sqlInsert = "INSERT INTO tb_Unit values('" + txtUnitID.Text + "', N'" + txtUnitName.Text + "')";
			ClassInsert save = new ClassInsert();
			save.Insert(sqlInsert, connect.DatabaseConnection(constr), "ຂໍ້ມູນຫົວໜ່ວຍລະຫັດ " + txtUnitID.Text + " ໄດ້ຖືກບັນທຶກລົງໃນຖານຂໍ້ມູນແລ້ວ");
			txtUnitID.Text = idauto.SetID(constr, "UnitID", "tb_Unit", "UN00", 2, 3);
			show.ShowData("SELECT * FROM v_Unit", connect.DatabaseConnection(constr), dgvUnit);
		}
		
		public void dgvUnit_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvUnit.Rows[dgvUnit.CurrentRow.Index];
			txtUnitID.Text = System.Convert.ToString(with_1.Cells[0].Value);
			txtUnitName.Text = System.Convert.ToString(with_1.Cells[1].Value);
		}
		
		public void btEdit_Click(object sender, EventArgs e)
		{
			string sqlUpdate = "UPDATE tb_Unit SET UnitName=N'" + txtUnitName.Text + "'  WHERE UnitID = '" + txtUnitID.Text + "'";
			classUpdate up = new classUpdate();
			up.Update(sqlUpdate, connect.DatabaseConnection(constr), "ຫົວໜ່ວຍລະຫັດ " + txtUnitID.Text + " ໄດ້ຮັບການແກ້ໄຂແລ້ວ");
			show.ShowData("SELECT * FROM v_Unit", connect.DatabaseConnection(constr), dgvUnit);
		}
		
		public void btDelete_Click(object sender, EventArgs e)
		{
			string sqlDelete = "DELETE FROM tb_Unit WHERE UnitID='" + txtUnitID.Text + "'";
			classDelete de = new classDelete();
			
			DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການລົບຫົວໜ່ວຍລະຫັນ " + txtUnitID.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				de.Delete(sqlDelete, connect.DatabaseConnection(constr));
				show.ShowData("SELECT * FROM v_Unit", connect.DatabaseConnection(constr), dgvUnit);
			}
			txtUnitID.Text = idauto.SetID(constr, "UnitID", "tb_Unit", "UN00", 2, 3);
			
		}
	}
}
