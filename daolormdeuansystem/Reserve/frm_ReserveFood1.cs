
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
	public partial class frm_ReserveFood1
	{
		public frm_ReserveFood1()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_ReserveFood1 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_ReserveFood1 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_ReserveFood1();
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
		public void frm_ReserveFood1_Load(object sender, EventArgs e)
		{
			ConstVar.sh.ShowData("select * from v_menu", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgv_Menu);
			//  sh.ShowData("select * from v_ReserveFood1 where reserveID = '" & frm_MainReserve.dgvReserve.Rows(frm_MainReserve.dgvReserve.CurrentRow.Index).Cells(0).Value & "'", connect.DatabaseConnection(constr), dgvReserveFood)
			txtID.Enabled = false;
			txtName.Enabled = false;
			//   TextBoxX1.Enabled = False
			
			ConstVar.sh.ShowData("select * from v_ReserveFoodperfect where reserveID = '" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveFood);
			
			
			
			dgv_Menu.Columns[0].Width = 60;
			dgv_Menu.Columns[3].Width = 0;
			dgv_Menu.Columns[4].Width = 0;
			dgv_Menu.Columns[5].Width = 0;
			
			dgvReserveFood.Columns[0].Width = 0;
			Panel1.BackColor = Color.FromArgb(70, Color.Black);
		}
		
		public void dgv_Menu_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgv_Menu.Rows[dgv_Menu.CurrentRow.Index];
			txtID.Text = System.Convert.ToString(with_1.Cells[0].Value);
			txtName.Text = System.Convert.ToString(with_1.Cells[1].Value);
			txtPrice.Text = System.Convert.ToString(with_1.Cells[2].Value);
			pgv.Image = Image.FromFile(System.Convert.ToString(with_1.Cells[3].Value));
			txtAmount.Focus();
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			if (txtAmount.Text == "")
			{
				MessageBox.Show("ກະລຸນາປ້ອນຈໍານວນອາຫານ");
				return;
			}
			string id = ConstVar.au.SetID(ConstVar.constr, "reserveFoodID", "tb_ReserveFood", "RSF", 3, 7, 7, "0000000");
			string sql = "insert into tb_ReserveFood values('" + id + "','" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "','" + txtID.Text + "','" + txtAmount.Text + "','" + txtPrice.Text + "')";
			ConstVar.sav.Insert(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			ConstVar.sh.ShowData("select * from v_ReserveFood1 where reserveID='" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveFood);
			txtAmount.ResetText();
			txtAmount.Focus();
		}
		
		private void ButtonX5_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			
			frm_EditAmountOFReserveFood ee = new frm_EditAmountOFReserveFood();
			ee.ShowDialog();
		}
		
		public void ButtonX3_Click(object sender, EventArgs e)
		{
			string sql = "delete from tb_reserveFood where reservefoodID = '" + System.Convert.ToString(dgvReserveFood.Rows[dgvReserveFood.CurrentRow.Index].Cells[0].Value) + "'";
			
			ConstVar.dell.Delete(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			
			ConstVar.sh.ShowData("select * from v_ReserveFood1 where reserveID='" + System.Convert.ToString(frm_MainReserve.Default.dgvReserve.Rows[frm_MainReserve.Default.dgvReserve.CurrentRow.Index].Cells[0].Value) + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvReserveFood);
		}
		
		public void ButtonX4_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
