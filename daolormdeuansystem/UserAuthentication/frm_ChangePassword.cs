
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
    public partial class frm_ChangePassword
	{
		public frm_ChangePassword()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_ChangePassword defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_ChangePassword Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_ChangePassword();
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
		public void CheckBoxX1_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBoxX1.Checked == true)
			{
				txtOldPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtOldPassword.UseSystemPasswordChar = true;
			}
		}
		
		public void frm_ChangePassword_Load(object sender, EventArgs e)
		{
			lbUserName.Text = Frm_Main.Default.btUser.Text;
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			SqlDataReader dr = default(SqlDataReader);
			string sql = "select UserPassword from tb_user where UserName = '" + lbUserName.Text + "'";
			
			SqlCommand cm = new SqlCommand(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			dr = cm.ExecuteReader();
			dr.Read();
			string pass = System.Convert.ToString(dr[0]);
			if (pass == txtOldPassword.Text)
			{
				if (txtNewPassword.Text == txtConfirmPassword.Text)
				{
					ConstVar.upd.Update("Update tb_User Set UserPassword = '" + txtNewPassword.Text + "' where UserName ='" + lbUserName.Text + "'", ConstVar.connect.DatabaseConnection(ConstVar.constr));
					DialogResult o = MessageBox.Show("ປ່ຽນລະຫັດຜ່ານສໍາເລັດ", "ຂໍສະແດງຄວາມຍິນດີ", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (o == DialogResult.OK)
					{
						Dispose();
						Frm_Main.Default.Hide();
						frm_Login.Default.Show();
					}
					
				}
				else
				{
					DialogResult cc = MessageBox.Show("ລະຫັດຜ່ານໃໝ່ບໍ່ຕົງກັນ!!!", "ຄໍາເຕືອນ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
					if (cc == DialogResult.Retry)
					{
						txtNewPassword.Clear();
						txtConfirmPassword.Clear();
						txtNewPassword.Focus();
					}
				}
			}
			else
			{
				DialogResult c = MessageBox.Show("ລະຫັດຜູ້ໃຊ້ຂອງ " + lbUserName.Text + " ບໍ່ຖືກຕ້ອງ, ກະລຸນາປ້ອນໃໝ່", "ຄໍາເຕືອນ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				if (c == DialogResult.Retry)
				{
					txtOldPassword.Clear();
					txtOldPassword.Focus();
				}
			}
			//Dim pass As String = dr(0)
			
		}
		
		public void CheckBoxX2_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBoxX2.Checked == true)
			{
				txtNewPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtNewPassword.UseSystemPasswordChar = true;
			}
		}
		
		public void CheckBoxX3_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBoxX3.Checked == true)
			{
				txtConfirmPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtConfirmPassword.UseSystemPasswordChar = true;
			}
		}
	}
	//'ຂຽນ 20 ນາທີ
}
