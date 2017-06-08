
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
	public partial class frm_Login
	{
		public frm_Login()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_Login defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_Login Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_Login();
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
		classDatabaseConnection db = new classDatabaseConnection();
		System.String constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True";
		private void txtUserName_TextChanged(object sender, EventArgs e)
		{
			
		}
		public void frm_Login_Load(object sender, EventArgs e)
		{
			cbState.Text = "----ເລືອກສະຖານະ-----";
			Panel1.Width = 0;
			pgb.Value = 0;
			pgb.Visible = false;
			Panel1.BackColor = Color.FromArgb(70, Color.Black);
			Panel2.BackColor = Color.FromArgb(70, Color.Black);
			pn.BackColor = Color.FromArgb(70, Color.Black);
			Timer2.Start();
		}
		
		private void txtCancel_Click(object sender, EventArgs e)
		{
			int confirm = (int) (MessageBox.Show("ຕ້ອງການທີ່ຈະຍົກເລີກແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
			if (confirm == (int) Constants.vbYes)
			{
				this.Close();
			}
			
		}
		int p = 0;
		public void Timer1_Tick(object sender, EventArgs e)
		{
			
			if (pgb.Value >= pgb.Maximum - 1)
			{
				Timer1.Stop();
				// Frm_Main.Show()
				
				if (txtUsername.Text == "")
				{
					MessageBox.Show("Enter Username Please", "Username Require");
					pgb.Visible = false;
					btLogin.Text = "ເຂົ້າສູ່ລະບົບ";
					return;
				}
				if (txtPassword.Text == "")
				{
					MessageBox.Show("Enter Passwore Please", "Password Require");
					pgb.Visible = false;
					btLogin.Text = "ເຂົ້າສູ່ລະບົບ";
					return;
				}
				if (txtUsername.Text == "" && txtPassword.Text == "")
				{
					MessageBox.Show("Enter User and Password Please", "User Info Require");
					pgb.Visible = false;
					btLogin.Text = "ເຂົ້າສູ່ລະບົບ";
					return;
				}
				if (cbState.Text == "----ເລືອກສະຖານະ-----")
				{
					MessageBox.Show("Select State Please", "State Require");
					pgb.Visible = false;
					btLogin.Text = "ເຂົ້າສູ່ລະບົບ";
					return;
				}
				var sqlScript = "select Username,userpassword, userState from tb_user where username = '" + txtUsername.Text.Trim() + "'  and Userpassword = '" + txtPassword.Text + "' and userstate = '" + cbState.SelectedItem.ToString() + "'";
				db.SQLCm = new SqlCommand(sqlScript, db.DatabaseConnection(constr));
				db.SQLDr = db.SQLCm.ExecuteReader();
				if (db.SQLDr.HasRows)
				{
					db.SQLDr.Close();
					Frm_Main.Default.Show();
					if (cbState.Text == "staff")
					{
						Frm_Main.Default.ButtonX6.Enabled = false;
						frm_OrderFood3.Default.txtprice.Enabled = false;
					}
					else if (cbState.Text == "admin")
					{
						Frm_Main.Default.ButtonX6.Enabled = true;
						frm_OrderFood3.Default.txtprice.Enabled = true;
					}
					//  Frm_Main.lbUsername.Text = Me.txtUsername.Text
					this.Hide();
					this.Hide();
				}
				else
				{
					db.SQLDr.Close();
					MessageBox.Show("ຊື່ ແລະລະຫັດຜູ້ໃຊ້ບໍຖຶກຕ້ອງ");
					cbState.Text = "-----ເລືອກສະຖານະ-----";
					txtUsername.Clear();
					txtPassword.Clear();
					txtUsername.Focus();
				}
				
				
				
				btLogin.Text = "ເຂົ້າສູ່ລະບົບ";
				pgb.Visible = false;
			}
			else
			{
				pgb.Value = pgb.Value + 5;
				
			}
		}
		
		
		
		private void txtCancel_Click_1(object sender, EventArgs e)
		{
			int confirm = (int) (MessageBox.Show("ຕ້ອງການທີ່ຈະຍົກເລີກແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
			if (confirm == (int) Constants.vbYes)
			{
				this.Close();
			}
		}
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			pgb.Value = 0;
			pgb.Visible = true;
			btLogin.Text = "Loading...";
			Timer1.Start();
			Frm_Main.Default.btUser.Text = txtUsername.Text;
			
			
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			int confirm = (int) (MessageBox.Show("ຕ້ອງການທີ່ຈະຍົກເລີກແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
			if (confirm == (int) Constants.vbYes)
			{
				this.Close();
			}
		}
		
		public void cbkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (cbkShowPassword.Checked == true)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else if (cbkShowPassword.Checked == false)
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}
		
		public void Timer2_Tick(object sender, EventArgs e)
		{
			if (Panel1.Width < 371)
			{
				Panel1.Width = Panel1.Width + 20;
			}
			else
			{
				Timer2.Stop();
			}
		}
	}
}
