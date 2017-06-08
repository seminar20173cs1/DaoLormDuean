
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
	public partial class frm_User
	{
		public frm_User()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_User defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_User Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_User();
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
		public void Button1_Click(object sender, EventArgs e)
		{
			var sql = "insert into tb_user values('" + txtUserID.Text + "','" + txtUSername.Text + "','" + txtPassword.Text + "','" + txtStatus.SelectedItem.ToString() + "','" + System.Convert.ToString(txtEmployeeID.SelectedValue) + "')";
			if (txtPassword.Text == txtconfirm.Text)
			{
				ConstVar.sav.Insert(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				txtUserID.Text = ConstVar.au.SetID(ConstVar.constr, "UserID", "tb_User", "US", 2, 3, 3, "000");
				txtUSername.Clear();
				txtPassword.Clear();
				txtconfirm.Clear();
				txtEmployeeID.Text = "";
				txtStatus.Text = "";
				
				ConstVar.sh.ShowData("select * from tb_User", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvBoat);
			}
			else
			{
				MessageBox.Show("ລະຫັດຜ່ານບໍ່ກົງກັນ!!!");
				//txtEmployeeID.Clear()
				txtPassword.Clear();
				txtconfirm.Clear();
				txtPassword.Focus();
			}
		}
		
		public void btEdit_Click(object sender, EventArgs e)
		{
			string update = "update tb_user set Username='" + txtUSername.Text + "', userpassword = '" + txtPassword.Text + "', userstate='" + txtStatus.SelectedItem.ToString() + "', employeeID = '" + System.Convert.ToString(txtEmployeeID.SelectedValue) + "' ";
			if (txtPassword.Text == txtconfirm.Text)
			{
				ConstVar.upd.Update(update, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				txtUserID.Text = ConstVar.au.SetID(ConstVar.constr, "UserID", "tb_User", "US", 2, 3, 3, "000");
				txtUSername.Clear();
				txtPassword.Clear();
				txtconfirm.Clear();
				txtEmployeeID.Text = "";
				txtStatus.Text = "";
				
				ConstVar.sh.ShowData("select * from tb_User", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvBoat);
			}
			else
			{
				MessageBox.Show("ລະຫັດຜ່ານບໍ່ກົງກັນ!!!");
				//txtEmployeeID.Clear()
				txtPassword.Clear();
				txtconfirm.Clear();
				txtPassword.Focus();
			}
			
		}
		
		public void frm_User_Load(object sender, EventArgs e)
		{ 
			txtUserID.Text = ConstVar.au.SetID(ConstVar.constr, "UserID", "tb_User", "US", 2, 3, 3, "000");
			ConstVar.sh.ShowData("select * from tb_User", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvBoat);
			ConstVar.sh.ShowDataInCombobox("Select EmployeeID, EmployeeName from tb_employee", ConstVar.connect.DatabaseConnection(ConstVar.constr), txtEmployeeID, "EmployeeID", "EmployeeName");
		}
		
		public void dgvBoat_Click(object sender, EventArgs e)
		{
			txtUserID.Text = System.Convert.ToString(dgvBoat.Rows[dgvBoat.CurrentRow.Index].Cells[0].Value);
			txtUSername.Text = System.Convert.ToString(dgvBoat.Rows[dgvBoat.CurrentRow.Index].Cells[1].Value);
			txtPassword.Text = System.Convert.ToString(dgvBoat.Rows[dgvBoat.CurrentRow.Index].Cells[2].Value);
			txtStatus.Text = System.Convert.ToString(dgvBoat.Rows[dgvBoat.CurrentRow.Index].Cells[3].Value);
			txtEmployeeID.Text = System.Convert.ToString(dgvBoat.Rows[dgvBoat.CurrentRow.Index].Cells[4].Value);
			
		}
		
		public void btDelete_Click(object sender, EventArgs e)
		{
			ConstVar.dell.Delete("delete from tb_user wher userid = '" + txtUserID.Text + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
			ConstVar.sh.ShowData("select * from tb_User", ConstVar.connect.DatabaseConnection(ConstVar.constr), dgvBoat);
			txtUserID.Text = ConstVar.au.SetID(ConstVar.constr, "UserID", "tb_User", "US", 2, 3, 3, "000");
			txtUSername.Clear();
			txtPassword.Clear();
			txtconfirm.Clear();
			txtEmployeeID.Text = "";
			txtStatus.Text = "";
		}
		
		public void btClear_Click(object sender, EventArgs e)
		{
			txtUserID.Text = ConstVar.au.SetID(ConstVar.constr, "UserID", "tb_User", "US", 2, 3, 3, "000");
			txtUSername.Clear();
			txtPassword.Clear();
			txtconfirm.Clear();
			txtEmployeeID.Text = "";
			txtStatus.Text = "";
		}
		
		public void btClose_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
