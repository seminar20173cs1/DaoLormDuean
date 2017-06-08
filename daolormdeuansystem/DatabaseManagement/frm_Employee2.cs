
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
	public partial class frm_Employee2
	{
		public frm_Employee2()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_Employee2 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_Employee2 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_Employee2();
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
		public void frm_Employee2_Load(object sender, EventArgs e)
		{
			LoadEmployee();
			//7546
			Panel7.BackColor = Color.FromArgb(70, Color.Black);
			Panel5.BackColor = Color.FromArgb(70, Color.Black);
			Panel4.BackColor = Color.FromArgb(70, Color.Black);
			Panel6.BackColor = Color.FromArgb(70, Color.Black);
			
			
		}
		public void LoadEmployee()
		{
			Label lb = default(Label);
			var sql = "select employeeID, employeeName, employeeLastName from tb_employee";
			DataTable dt = new DataTable();
			var da = new SqlDataAdapter(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				lb = new Label();
				lb.Text = row["employeeName"].ToString();
				lb.TextAlign = ContentAlignment.MiddleLeft;
				lb.Width = 250;
				lb.Height = 40;
				lb.Tag = row["employeeID"].ToString();
				lb.BackColor = Color.White;
				lb.MouseHover += MouseHoverlb;
				lb.MouseLeave += MouseLeavelb;
				pnEmployee.Controls.Add(lb);
			}
			
			//lb Properties
			//  lb.Text = "ID" & "     " & "Saiyavog" & "     " & "Mitthasone"
			//lb.TextAlign = ContentAlignment.MiddleCenter
			//lb.Width = 250
			//lb.Height = 40
			//lb.BackColor = Color.White
			//AddHandler lb.MouseHover, AddressOf MouseHoverlb
			//AddHandler lb.MouseLeave, AddressOf MouseLeavelb
			//pnEmployee.Controls.Add(lb)
		}
		string p;
		
		private void MouseHoverlb(object sender, EventArgs e)
		{
			Label lab = default(Label);
			lab = (Label) sender;
			lab.BackColor = Color.LightBlue;
			var sql = " select * from tb_employee where employeeID = '" + System.Convert.ToString(lab.Tag) + "'";
			SqlDataReader dr = default(SqlDataReader);
			SqlCommand cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			dr = cm.ExecuteReader();
			dr.Read();
			lbID.Text = dr[0].ToString();
			lbName.Text = dr[1].ToString();
			lbLastName.Text = dr[2].ToString();
			lbDob.Text = dr[3].ToString();
			lbTel.Text = dr[5].ToString();
			lbParentTel.Text = dr[6].ToString();
			lbEmail.Text = dr[7].ToString();
			lbVillag.Text = dr[8].ToString();
			lbDistrict.Text = dr[9].ToString();
			//  lbProvince.Text = dr(10).ToString
			
			string pro = dr[10].ToString();
			var sqlpro = "select province from tb_province where provinceID = '" + pro + "'";
			SqlDataReader dr1 = default(SqlDataReader);
			SqlCommand cm1 = new SqlCommand(sqlpro, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			dr1 = cm1.ExecuteReader();
			dr1.Read();
			lbProvince.Text = dr1[0].ToString();
			p = dr[12].ToString();
			lbPosition.Text = dr[4].ToString();
			lbSalary.Text = System.Convert.ToString(dr[11].ToString());
			pgb.Image = Image.FromFile(dr[12].ToString());
		}
		private void MouseLeavelb(object sender, EventArgs e)
		{
			Label lab;
			lab = (Label) sender;
			lab.BackColor = Color.White;
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			//  frm_Employee.ShowDialog(Me)
			var with_1 =new frm_Employee();
			with_1.txtEmployeeID.Text = ConstVar.au.SetID(ConstVar.constr, "EmployeeID", "tb_Employee", "EP00", 2, 3);
			with_1.txtEmployeeName.Clear();
			with_1.txtEmployeeLastName.Clear();
			with_1.dtbDob.Text = "";
			with_1.txtEmployeeTel.Clear();
			with_1.txtEmployeeParentTel.Clear();
			with_1.txtEmployeeEmail.Clear();
			with_1.txtEmployeeVillage.Clear();
			with_1.txtEmployeeDistrict.Clear();
			with_1.cbProvince.SelectedItem = lbProvince.Text;
			with_1.txtEmployeeSalary.Clear();
			with_1.txtEmployeePosition.Clear();
			with_1.ptbProfile.Image = null;
			with_1.txtPicturePath.Clear();
			with_1.ShowDialog(this);
		}
		
		public void ButtonX4_Click(object sender, EventArgs e)
		{
			pnEmployee.Controls.Clear();
			LoadEmployee();
		}
		
		public void ເພມພະນກງານToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Employee.Default.ShowDialog(this);
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			
			var with_1 =new frm_Employee();
			with_1.btSave.Visible = false;
			with_1.btEdit.Text = "ສໍາເລັດ";
			with_1.TabPage2.Visible = false;
			with_1.btDelete.Visible = false;
			
			with_1.txtEmployeeID.Text = lbID.Text;
			with_1.txtEmployeeName.Text = lbName.Text;
			with_1.txtEmployeeLastName.Text = lbLastName.Text;
			with_1.dtbDob.Text = lbDob.Text;
			with_1.txtEmployeeTel.Text = lbTel.Text;
			with_1.txtEmployeeParentTel.Text = lbParentTel.Text;
			with_1.txtEmployeeEmail.Text = lbEmail.Text;
			with_1.txtEmployeeVillage.Text = lbVillag.Text;
			with_1.txtEmployeeDistrict.Text = lbDistrict.Text;
			with_1.cbProvince.SelectedItem = lbProvince.Text;
			with_1.txtEmployeeSalary.Text = lbSalary.Text;
			with_1.txtEmployeePosition.Text = lbPosition.Text;
			with_1.ptbProfile.Image = Image.FromFile(p);
			with_1.txtPicturePath.Text = p;
			frm_Employee.Default.ShowDialog(this);
		}
		
		public void ButtonX3_Click(object sender, EventArgs e)
		{
			
			// Dim ms As String = MessageBox.Show()
			DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການທີ່ຈະລົບ " + lbID.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				ConstVar.dell.Delete("delete from tb_employee where employeeID ='" + lbID.Text + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
				
				pnEmployee.Controls.Clear();
				LoadEmployee();
			}
		}
	}
}
