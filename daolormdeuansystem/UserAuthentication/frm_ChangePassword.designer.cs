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

	partial class frm_ChangePassword : System.Windows.Forms.Form
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
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			base.Load += new System.EventHandler(frm_ChangePassword_Load);
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.txtConfirmPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtOldPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.CheckBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.CheckBoxX1.CheckedChanged += new System.EventHandler(this.CheckBoxX1_CheckedChanged);
			this.CheckBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.CheckBoxX2.CheckedChanged += new System.EventHandler(this.CheckBoxX2_CheckedChanged);
			this.CheckBoxX3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.CheckBoxX3.CheckedChanged += new System.EventHandler(this.CheckBoxX3_CheckedChanged);
			this.Label4 = new System.Windows.Forms.Label();
			this.lbUserName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(12, 166);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(378, 23);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 6;
			this.ButtonX1.Text = "Go!";
			//
			//txtConfirmPassword
			//
			this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtConfirmPassword.Border.Class = "TextBoxBorder";
			this.txtConfirmPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtConfirmPassword.DisabledBackColor = System.Drawing.Color.White;
			this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
			this.txtConfirmPassword.Location = new System.Drawing.Point(150, 129);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PreventEnterBeep = true;
			this.txtConfirmPassword.Size = new System.Drawing.Size(220, 31);
			this.txtConfirmPassword.TabIndex = 4;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			this.txtConfirmPassword.WatermarkText = "Confirm New Password";
			//
			//txtNewPassword
			//
			this.txtNewPassword.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtNewPassword.Border.Class = "TextBoxBorder";
			this.txtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtNewPassword.DisabledBackColor = System.Drawing.Color.White;
			this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
			this.txtNewPassword.Location = new System.Drawing.Point(150, 92);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PreventEnterBeep = true;
			this.txtNewPassword.Size = new System.Drawing.Size(220, 31);
			this.txtNewPassword.TabIndex = 2;
			this.txtNewPassword.UseSystemPasswordChar = true;
			this.txtNewPassword.WatermarkText = "Enter New Password";
			//
			//txtOldPassword
			//
			this.txtOldPassword.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtOldPassword.Border.Class = "TextBoxBorder";
			this.txtOldPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtOldPassword.DisabledBackColor = System.Drawing.Color.White;
			this.txtOldPassword.ForeColor = System.Drawing.Color.Black;
			this.txtOldPassword.Location = new System.Drawing.Point(150, 55);
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.PreventEnterBeep = true;
			this.txtOldPassword.Size = new System.Drawing.Size(220, 31);
			this.txtOldPassword.TabIndex = 0;
			this.txtOldPassword.UseSystemPasswordChar = true;
			this.txtOldPassword.WatermarkText = "Enter Old Password";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(34, 131);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(109, 23);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "ຢືນຢັນລະຫັດໃໝ່:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(70, 94);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(73, 23);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "ລະຫັດໃໝ່:";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(71, 57);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 23);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "ລະຫັດເກົ່າ:";
			//
			//CheckBoxX1
			//
			//
			//
			//
			this.CheckBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.CheckBoxX1.Location = new System.Drawing.Point(376, 60);
			this.CheckBoxX1.Name = "CheckBoxX1";
			this.CheckBoxX1.Size = new System.Drawing.Size(14, 23);
			this.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.CheckBoxX1.TabIndex = 1;
			//
			//CheckBoxX2
			//
			//
			//
			//
			this.CheckBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.CheckBoxX2.Location = new System.Drawing.Point(376, 98);
			this.CheckBoxX2.Name = "CheckBoxX2";
			this.CheckBoxX2.Size = new System.Drawing.Size(14, 23);
			this.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.CheckBoxX2.TabIndex = 3;
			//
			//CheckBoxX3
			//
			//
			//
			//
			this.CheckBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.CheckBoxX3.Location = new System.Drawing.Point(376, 132);
			this.CheckBoxX3.Name = "CheckBoxX3";
			this.CheckBoxX3.Size = new System.Drawing.Size(14, 23);
			this.CheckBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.CheckBoxX3.TabIndex = 5;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(93, 21);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(41, 23);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "ຜູ້ໃຊ້:";
			//
			//lbUserName
			//
			this.lbUserName.AutoSize = true;
			this.lbUserName.Location = new System.Drawing.Point(154, 21);
			this.lbUserName.Name = "lbUserName";
			this.lbUserName.Size = new System.Drawing.Size(0, 23);
			this.lbUserName.TabIndex = 12;
			//
			//frm_ChangePassword
			//
			this.AcceptButton = this.ButtonX1;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 197);
			this.Controls.Add(this.lbUserName);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.CheckBoxX3);
			this.Controls.Add(this.CheckBoxX2);
			this.Controls.Add(this.CheckBoxX1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ButtonX1);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.txtOldPassword);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_ChangePassword";
			this.Text = "frm_ChangePassword";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtConfirmPassword;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtNewPassword;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtOldPassword;
		internal Label Label1;
		internal Label Label2;
		internal Label Label3;
		internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX1;
		internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX2;
		internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX3;
		internal Label Label4;
		internal Label lbUserName;
	}
	
}
