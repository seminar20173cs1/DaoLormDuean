// VBConversions Note: VB project level imports
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
// End of VB project level imports


namespace daolormdeuansystem
{
	
	partial class frm_User : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.btClose = new System.Windows.Forms.Button();
			base.Load += new System.EventHandler(frm_User_Load);
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			this.btClear = new System.Windows.Forms.Button();
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			this.btDelete = new System.Windows.Forms.Button();
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			this.btEdit = new System.Windows.Forms.Button();
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.txtStatus = new System.Windows.Forms.ComboBox();
			this.txtconfirm = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtUSername = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtUserID = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.dgvBoat = new System.Windows.Forms.DataGridView();
			this.dgvBoat.Click += new System.EventHandler(this.dgvBoat_Click);
			this.txtEmployeeID = new System.Windows.Forms.ComboBox();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvBoat).BeginInit();
			this.SuspendLayout();
			//
			//btClose
			//
			this.btClose.Location = new System.Drawing.Point(420, 348);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(91, 31);
			this.btClose.TabIndex = 34;
			this.btClose.Text = "ອອກ";
			this.btClose.UseVisualStyleBackColor = true;
			//
			//btClear
			//
			this.btClear.Location = new System.Drawing.Point(323, 348);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(91, 31);
			this.btClear.TabIndex = 35;
			this.btClear.Text = "ລ້າງ";
			this.btClear.UseVisualStyleBackColor = true;
			//
			//btDelete
			//
			this.btDelete.Location = new System.Drawing.Point(226, 348);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(91, 31);
			this.btDelete.TabIndex = 36;
			this.btDelete.Text = "ລົບ";
			this.btDelete.UseVisualStyleBackColor = true;
			//
			//btEdit
			//
			this.btEdit.Location = new System.Drawing.Point(129, 348);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(91, 31);
			this.btEdit.TabIndex = 37;
			this.btEdit.Text = "ແກ້ໃຂ";
			this.btEdit.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(32, 348);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(91, 31);
			this.Button1.TabIndex = 38;
			this.Button1.Text = "ບັນທຶກ";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(12, 12);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(524, 330);
			this.TabControl1.TabIndex = 41;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.Panel1);
			this.TabPage1.Location = new System.Drawing.Point(4, 32);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(516, 294);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "ປ້ອນຂໍ້ມູນ";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//Panel1
			//
			this.Panel1.Controls.Add(this.txtEmployeeID);
			this.Panel1.Controls.Add(this.txtStatus);
			this.Panel1.Controls.Add(this.txtconfirm);
			this.Panel1.Controls.Add(this.txtPassword);
			this.Panel1.Controls.Add(this.txtUSername);
			this.Panel1.Controls.Add(this.txtUserID);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(-4, 27);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(524, 249);
			this.Panel1.TabIndex = 41;
			//
			//txtStatus
			//
			this.txtStatus.FormattingEnabled = true;
			this.txtStatus.Items.AddRange(new object[] {"admin", "staff"});
			this.txtStatus.Location = new System.Drawing.Point(199, 165);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(243, 31);
			this.txtStatus.TabIndex = 58;
			//
			//txtconfirm
			//
			//
			//
			//
			this.txtconfirm.Border.Class = "TextBoxBorder";
			this.txtconfirm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtconfirm.Location = new System.Drawing.Point(199, 127);
			this.txtconfirm.Name = "txtconfirm";
			this.txtconfirm.PreventEnterBeep = true;
			this.txtconfirm.Size = new System.Drawing.Size(243, 31);
			this.txtconfirm.TabIndex = 55;
			this.txtconfirm.UseSystemPasswordChar = true;
			this.txtconfirm.WatermarkText = "Confirm Password";
			//
			//txtPassword
			//
			//
			//
			//
			this.txtPassword.Border.Class = "TextBoxBorder";
			this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtPassword.Location = new System.Drawing.Point(199, 90);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PreventEnterBeep = true;
			this.txtPassword.Size = new System.Drawing.Size(243, 31);
			this.txtPassword.TabIndex = 54;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.WatermarkText = "Password";
			//
			//txtUSername
			//
			//
			//
			//
			this.txtUSername.Border.Class = "TextBoxBorder";
			this.txtUSername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtUSername.Location = new System.Drawing.Point(199, 53);
			this.txtUSername.Name = "txtUSername";
			this.txtUSername.PreventEnterBeep = true;
			this.txtUSername.Size = new System.Drawing.Size(243, 31);
			this.txtUSername.TabIndex = 53;
			this.txtUSername.WatermarkText = "UserName";
			//
			//txtUserID
			//
			//
			//
			//
			this.txtUserID.Border.Class = "TextBoxBorder";
			this.txtUserID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtUserID.Location = new System.Drawing.Point(199, 16);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.PreventEnterBeep = true;
			this.txtUserID.Size = new System.Drawing.Size(243, 31);
			this.txtUserID.TabIndex = 52;
			this.txtUserID.WatermarkText = "ID";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(82, 204);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(109, 23);
			this.Label5.TabIndex = 46;
			this.Label5.Text = "ລະຫັດພະນັກງານ:";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(82, 133);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(112, 23);
			this.Label6.TabIndex = 47;
			this.Label6.Text = "ຢືນຢັນລະຫັດຜ່ານ:";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(82, 98);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 23);
			this.Label3.TabIndex = 48;
			this.Label3.Text = "ລະຫັດຜ່ານ:";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(82, 167);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(65, 23);
			this.Label4.TabIndex = 49;
			this.Label4.Text = "ສະຖານະ:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(82, 61);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(50, 23);
			this.Label2.TabIndex = 50;
			this.Label2.Text = "ຊື່ຜູ້ໃຊ້:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(82, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(78, 23);
			this.Label1.TabIndex = 51;
			this.Label1.Text = "ລະຫັດຜູ້ໃຊ້:";
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.dgvBoat);
			this.TabPage2.Location = new System.Drawing.Point(4, 32);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(516, 294);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "ເບິ່ງຂໍ້ມູນ";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//dgvBoat
			//
			this.dgvBoat.AllowUserToAddRows = false;
			this.dgvBoat.AllowUserToDeleteRows = false;
			this.dgvBoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBoat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBoat.Location = new System.Drawing.Point(3, 3);
			this.dgvBoat.Name = "dgvBoat";
			this.dgvBoat.ReadOnly = true;
			this.dgvBoat.Size = new System.Drawing.Size(510, 288);
			this.dgvBoat.TabIndex = 40;
			//
			//txtEmployeeID
			//
			this.txtEmployeeID.FormattingEnabled = true;
			this.txtEmployeeID.Location = new System.Drawing.Point(199, 201);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(243, 31);
			this.txtEmployeeID.TabIndex = 59;
			//
			//frm_User
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 389);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btEdit);
			this.Controls.Add(this.Button1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_User";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_User";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvBoat).EndInit();
			this.ResumeLayout(false);
			
		}
		internal Button btClose;
		internal Button btClear;
		internal Button btDelete;
		internal Button btEdit;
		internal Button Button1;
		internal TabControl TabControl1;
		internal TabPage TabPage1;
		internal Panel Panel1;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtconfirm;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtUSername;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtUserID;
		internal Label Label5;
		internal Label Label6;
		internal Label Label3;
		internal Label Label4;
		internal Label Label2;
		internal Label Label1;
		internal TabPage TabPage2;
		internal DataGridView dgvBoat;
		internal ComboBox txtStatus;
		internal ComboBox txtEmployeeID;
	}
	
}
