
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
	public partial class frm_RateExchange
	{
		public frm_RateExchange()
		{
			InitializeComponent();
			
			
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_RateExchange defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_RateExchange Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_RateExchange();
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
		public void frm_RateExchange_Load(object sender, EventArgs e)
		{
			txtRateID.Text = idauto.SetID(constr, "RateID", "tb_RateExchange", "R000", 1, 4);
			Panel1.BackColor = Color.FromArgb(80, Color.Black);
			show.ShowData("SELECT * FROM v_RateExchange", connect.DatabaseConnection(constr), dgvRate);
		}
		public void btExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void btSave_Click(object sender, EventArgs e)
		{
			string sqlSave = "INSERT INTO tb_RateExchange VALUES('" + txtRateID.Text + "','" + txtCurrency.Text + "','" + txtRate.Text + "')";
			ClassInsert save = new ClassInsert();
			save.Insert(sqlSave, connect.DatabaseConnection(constr), "ຂໍ້ມູນອັດຕາແລກປ່ຽນລະຫັດ " + txtRateID.Text + " ໄດ້ຖືກບັນທຶກລົງໃນຖານຂໍ້ມູນແລ້ວ");
			txtRateID.Text = idauto.SetID(constr, "RateID", "tb_RateExchange", "R000", 1, 4);
			show.ShowData("SELECT * FROM v_RateExchange", connect.DatabaseConnection(constr), dgvRate);
			txtCurrency.Text = "";
			txtRate.Clear();
			txtCurrency.Focus();
		}
		public void btEdit_Click(object sender, EventArgs e)
		{
			string sqlUpdate = "UPDATE tb_RateExchange SET Currency= '" + txtCurrency.Text + "', Rate = '" + txtRate.Text + "' WHERE RateID = '" + txtRateID.Text + "'";
		}
		public void dgvRate_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvRate.Rows[dgvRate.CurrentRow.Index];
			txtRateID.Text = System.Convert.ToString(with_1.Cells[0].Value);
			txtCurrency.Text = System.Convert.ToString(with_1.Cells[1].Value);
			txtRate.Text = System.Convert.ToString(with_1.Cells[2].Value);
		}
		public void btDelete_Click(object sender, EventArgs e)
		{
			string sqlDelete = "DELETE FROM tb_RateExchange WHERE RateID = '" + txtRateID.Text + "'";
			classDelete del = new classDelete();
			DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການລົບຫົວໜ່ວຍລະຫັນ " + txtRateID.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				del.Delete(sqlDelete, connect.DatabaseConnection(constr));
				txtRateID.Text = idauto.SetID(constr, "RateID", "tb_RateExchange", "R000", 1, 4);
				show.ShowData("SELECT * FROM v_RateExchange", connect.DatabaseConnection(constr), dgvRate);
			}
		}
	}
}
