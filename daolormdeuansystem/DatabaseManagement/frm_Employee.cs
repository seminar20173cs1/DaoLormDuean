
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
	public partial class frm_Employee
	{
		public frm_Employee()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_Employee defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_Employee Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_Employee();
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
		public void frm_Employee_Load(object sender, EventArgs e)
		{
			show.ShowDataInCombobox("SELECT ProvinceID, Province FROM tb_Province", SQL.SQLCon, cbProvince, "ProvinceID", "Province");
			show.ShowData("SELECT * FROM v_Employee", SQL.SQLCon, dgvEmployee);
			//txtEmployeeID.Text = idauto.SetID(constr, "EmployeeID", "tb_Employee", "EP00", 2, 3)
		}
		
		private void ptbProfile_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog1.ShowDialog();
				txtPicturePath.Text = OpenFileDialog1.FileName;
				ptbProfile.Image = Image.FromFile(txtPicturePath.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btChoosePhoto_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog1.ShowDialog();
				txtPicturePath.Text = OpenFileDialog1.FileName;
				ptbProfile.Image = Image.FromFile(txtPicturePath.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btSave_Click(object sender, EventArgs e)
		{
			string sqlInsert = "";
			var sqlscript = "SELECT EmployeeID FROM tb_Employee WHERE EmployeeID = '" + txtEmployeeID.Text + "'";
			SQL.SQLCmd = new System.Data.SqlClient.SqlCommand(sqlscript, SQL.SQLCon);
			SQL.SQLCon.Open();
			SQL.SQLDr = SQL.SQLCmd.ExecuteReader();
			if (SQL.SQLDr.HasRows)
			{
				MessageBox.Show("ລະຫັດນີ້ມີຢູ່ໃນຖານຂໍ້ມູນແລ້ວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				SQL.SQLDr.Close();
			}
			else
			{
				sqlInsert = "INSERT INTO tb_Employee VALUES('" + txtEmployeeID.Text + "','" + txtEmployeeName.Text + "','" + txtEmployeeLastName.Text + "','" + dtbDob.Text + "','" + txtEmployeePosition.Text + "','" + txtEmployeeTel.Text + "','" + txtEmployeeParentTel.Text + "','" + txtEmployeeEmail.Text + "','" + txtEmployeeVillage.Text + "','" + txtEmployeeDistrict.Text + "','" + cbProvince.SelectedValue.ToString() + "','" + txtEmployeeSalary.Text + "','" + txtPicturePath.Text + "')";
				ClassInsert save = new ClassInsert();
				save.Insert(sqlInsert, connect.DatabaseConnection(constr), "ຂໍ້ມູນຂອງພະນັກງານລະຫັດ " + txtEmployeeID.Text + " ໄດ້ຖືກບັນທຶກລົງໃນຖານຂໍ້ມູນແລ້ວ");
				txtEmployeeID.Text = idauto.SetID(constr, "EmployeeID", "tb_Employee", "EP00", 2, 3);
				show.ShowData("SELECT * FROM v_Employee", connect.DatabaseConnection(constr), dgvEmployee);
			}
			SQL.SQLCon.Close();
		}
		
		
		public void ptbProfile_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				OpenFileDialog1.ShowDialog();
				txtPicturePath.Text = OpenFileDialog1.FileName;
				ptbProfile.Image = Image.FromFile(txtPicturePath.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		public void btEdit_Click(object sender, EventArgs e)
		{
			//Dim sqlUpdate As String = "UPDATE tb_Employee SET employeeName = '" & txtEmployeeName.Text & "',employeeLastName='" & txtEmployeeLastName.Text & "',employeeDateOfBirth='" & dtbDob.Text & "',employeePosition='" & txtEmployeePosition.Text & "',employeePhoneNumber = '" & txtEmployeeTel.Text & "', employeeParentPhoneNumber='" & txtEmployeeParentTel.Text & "', employeeEmail='" & txtEmployeeEmail.Text & "',employeeVillage='" & txtEmployeeVillage.Text & "', employeeDistrict='" & txtEmployeeDistrict.Text & "', employeeProvince='" & cbProvince.SelectedValue.ToString & "', employeeSalary='" & txtEmployeeSalary.Text & "', employeePicture='" & txtPicturePath.Text & "' WHERE employeeID = '" & txtEmployeeID.Text & "'"
			//Dim up As New classUpdate
			//up.Update(sqlUpdate, connect.DatabaseConnection(constr), "ພະນັກງານລະຫັດ " & txtEmployeeID.Text & " ໄດ້ຮັບການແກ້ໄຂແລ້ວ")
			//show.ShowData("SELECT * FROM v_Employee", connect.DatabaseConnection(constr), dgvEmployee)
			
			if (btEdit.Text == "ສໍາເລັດ")
			{
				string sqlUpdate1 = "UPDATE tb_Employee SET employeeName = '" + txtEmployeeName.Text + "',employeeLastName='" + txtEmployeeLastName.Text + "',employeeDateOfBirth='" + dtbDob.Text + "',employeePosition='" + txtEmployeePosition.Text + "',employeePhoneNumber = '" + txtEmployeeTel.Text + "', employeeParentPhoneNumber='" + txtEmployeeParentTel.Text + "', employeeEmail='" + txtEmployeeEmail.Text + "',employeeVillage='" + txtEmployeeVillage.Text + "', employeeDistrict='" + txtEmployeeDistrict.Text + "', employeeProvince='" + cbProvince.SelectedValue.ToString() + "', employeeSalary='" + txtEmployeeSalary.Text + "', employeePicture='" + txtPicturePath.Text + "' WHERE employeeID = '" + txtEmployeeID.Text + "'";
				classUpdate up1 = new classUpdate();
				up1.Update(sqlUpdate1, connect.DatabaseConnection(constr), "ພະນັກງານລະຫັດ " + txtEmployeeID.Text + " ໄດ້ຮັບການແກ້ໄຂແລ້ວ");
				show.ShowData("SELECT * FROM v_Employee", connect.DatabaseConnection(constr), dgvEmployee);
				Dispose();
			}
			else
			{
				string sqlUpdate2 = "UPDATE tb_Employee SET employeeName = '" + txtEmployeeName.Text + "',employeeLastName='" + txtEmployeeLastName.Text + "',employeeDateOfBirth='" + dtbDob.Text + "',employeePosition='" + txtEmployeePosition.Text + "',employeePhoneNumber = '" + txtEmployeeTel.Text + "', employeeParentPhoneNumber='" + txtEmployeeParentTel.Text + "', employeeEmail='" + txtEmployeeEmail.Text + "',employeeVillage='" + txtEmployeeVillage.Text + "', employeeDistrict='" + txtEmployeeDistrict.Text + "', employeeProvince='" + cbProvince.SelectedValue.ToString() + "', employeeSalary='" + txtEmployeeSalary.Text + "', employeePicture='" + txtPicturePath.Text + "' WHERE employeeID = '" + txtEmployeeID.Text + "'";
				classUpdate up2 = new classUpdate();
				up2.Update(sqlUpdate2, connect.DatabaseConnection(constr), "ພະນັກງານລະຫັດ " + txtEmployeeID.Text + " ໄດ້ຮັບການແກ້ໄຂແລ້ວ");
				show.ShowData("SELECT * FROM v_Employee", connect.DatabaseConnection(constr), dgvEmployee);
			}
		}
		
		public void dgvEmployee_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DataGridViewRow with_1 = dgvEmployee.Rows[dgvEmployee.CurrentRow.Index];
			txtEmployeeID.Text = System.Convert.ToString(with_1.Cells[0].Value);
			txtEmployeeName.Text = System.Convert.ToString(with_1.Cells[1].Value);
			txtEmployeeLastName.Text = System.Convert.ToString(with_1.Cells[2].Value);
			dtbDob.Text = System.Convert.ToString(with_1.Cells[3].Value);
			txtEmployeePosition.Text = System.Convert.ToString(with_1.Cells[4].Value);
			txtEmployeeTel.Text = System.Convert.ToString(with_1.Cells[5].Value);
			txtEmployeeParentTel.Text = System.Convert.ToString(with_1.Cells[6].Value);
			txtEmployeeEmail.Text = System.Convert.ToString(with_1.Cells[7].Value);
			txtEmployeeVillage.Text = System.Convert.ToString(with_1.Cells[8].Value);
			txtEmployeeDistrict.Text = System.Convert.ToString(with_1.Cells[9].Value);
			cbProvince.Text = System.Convert.ToString(with_1.Cells[10].Value);
			txtEmployeeSalary.Text = System.Convert.ToString(with_1.Cells[11].Value);
			txtPicturePath.Text = System.Convert.ToString(with_1.Cells[12].Value);
			ptbProfile.ImageLocation = txtPicturePath.Text;
		}
		
		public void btDelete_Click(object sender, EventArgs e)
		{
			string sqldeletescript = "Delete from tb_Employee where employeeID = '" + txtEmployeeID.Text + "'";
			classDelete del = new classDelete();
			DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການທີ່ຈະລົບ " + txtEmployeeID.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				del.Delete(sqldeletescript, connect.DatabaseConnection(constr));
				show.ShowData("SELECT * FROM v_Employee", connect.DatabaseConnection(constr), dgvEmployee);
			}
			txtEmployeeID.Text = idauto.SetID(constr, "EmployeeID", "tb_Employee", "EP00", 2, 3);
			
		}
		
		public void btClear_Click(object sender, EventArgs e)
		{
			
			ClearTextBox();
			
			
		}
		
		
		
		public void ClearTextBox()
		{
			Control a = default(Control);
			foreach (Control tempLoopVar_a in TabControl1.Controls)
			{
				a = tempLoopVar_a;
				if (a is TextBox)
				{
					a.Text = "";
				}
			}
		}
		
		public void ptbProfile_Click_1(object sender, EventArgs e)
		{
			
		}
		
		public void frm_Employee_FormClosing(object sender, FormClosingEventArgs e)
		{
			Frm_Main.Default.pnMenu.Show();
		}
		
		public void btExit_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
