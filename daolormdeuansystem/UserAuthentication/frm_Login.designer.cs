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
	
	partial class frm_Login : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frm_Login_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
			this.pgb = new System.Windows.Forms.ProgressBar();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.Label5 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.btLogin = new DevComponents.DotNetBar.ButtonX();
			this.btLogin.Click += new System.EventHandler(this.ButtonX1_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbkShowPassword = new System.Windows.Forms.CheckBox();
			this.cbkShowPassword.CheckedChanged += new System.EventHandler(this.cbkShowPassword_CheckedChanged);
			this.cbState = new System.Windows.Forms.ComboBox();
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			this.pn = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel1.SuspendLayout();
			this.pn.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//pgb
			//
			this.pgb.BackColor = System.Drawing.Color.DarkKhaki;
			this.pgb.Dock = System.Windows.Forms.DockStyle.Top;
			this.pgb.Location = new System.Drawing.Point(0, 0);
			this.pgb.Maximum = 1000;
			this.pgb.Name = "pgb";
			this.pgb.Size = new System.Drawing.Size(722, 10);
			this.pgb.Step = 1;
			this.pgb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.pgb.TabIndex = 4;
			//
			//Timer1
			//
			this.Timer1.Interval = 1;
			//
			//ImageList1
			//
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "Check-100.png");
			this.ImageList1.Images.SetKeyName(1, "Delete-100 (2).png");
			this.ImageList1.Images.SetKeyName(2, "Key-100.png");
			this.ImageList1.Images.SetKeyName(3, "Password-100.png");
			this.ImageList1.Images.SetKeyName(4, "User Shield-100.png");
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(261, 11);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(200, 39);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "ກະລຸນາເຂົ້າສູ່ລະບົບ";
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.Panel1.Controls.Add(this.txtPassword);
			this.Panel1.Controls.Add(this.txtUsername);
			this.Panel1.Controls.Add(this.btLogin);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.cbkShowPassword);
			this.Panel1.Controls.Add(this.cbState);
			this.Panel1.Location = new System.Drawing.Point(174, 121);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(371, 250);
			this.Panel1.TabIndex = 15;
			//
			//txtPassword
			//
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassword.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtPassword.Border.Class = "TextBoxBorder";
			this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtPassword.DisabledBackColor = System.Drawing.Color.White;
			this.txtPassword.Font = new System.Drawing.Font("Segoe Print", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.Location = new System.Drawing.Point(125, 130);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PreventEnterBeep = true;
			this.txtPassword.Size = new System.Drawing.Size(235, 36);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.WatermarkText = "Enter Password";
			//
			//txtUsername
			//
			this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUsername.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtUsername.Border.Class = "TextBoxBorder";
			this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtUsername.DisabledBackColor = System.Drawing.Color.White;
			this.txtUsername.Font = new System.Drawing.Font("Segoe Print", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtUsername.ForeColor = System.Drawing.Color.Black;
			this.txtUsername.Location = new System.Drawing.Point(125, 74);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PreventEnterBeep = true;
			this.txtUsername.Size = new System.Drawing.Size(235, 36);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.WatermarkText = "Enter Username";
			//
			//btLogin
			//
			this.btLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btLogin.BackColor = System.Drawing.Color.DarkOrchid;
			this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLogin.Location = new System.Drawing.Point(18, 200);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(335, 35);
			this.btLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
			this.btLogin.Symbol = "59544";
			this.btLogin.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btLogin.TabIndex = 4;
			this.btLogin.Text = "ເຂົ້າສູ່ລະບົບ";
			this.btLogin.Tooltip = "Login";
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(46, 29);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "ສະຖານະ:";
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(63, 80);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(55, 23);
			this.Label3.TabIndex = 19;
			this.Label3.Text = "ຊື່ຜູ້ໃຊ້:";
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), (System.Drawing.FontStyle) (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(34, 138);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(84, 23);
			this.Label2.TabIndex = 20;
			this.Label2.Text = "ລະຫັດຜ່ານ:";
			//
			//cbkShowPassword
			//
			this.cbkShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbkShowPassword.AutoSize = true;
			this.cbkShowPassword.BackColor = System.Drawing.Color.Transparent;
			this.cbkShowPassword.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cbkShowPassword.ForeColor = System.Drawing.Color.White;
			this.cbkShowPassword.Location = new System.Drawing.Point(125, 172);
			this.cbkShowPassword.Name = "cbkShowPassword";
			this.cbkShowPassword.Size = new System.Drawing.Size(144, 27);
			this.cbkShowPassword.TabIndex = 3;
			this.cbkShowPassword.Text = "ສະແດງລະຫັດຜ່ານ";
			this.cbkShowPassword.UseVisualStyleBackColor = false;
			//
			//cbState
			//
			this.cbState.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbState.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbState.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cbState.FormattingEnabled = true;
			this.cbState.Items.AddRange(new object[] {"admin", "staff"});
			this.cbState.Location = new System.Drawing.Point(125, 26);
			this.cbState.Name = "cbState";
			this.cbState.Size = new System.Drawing.Size(235, 31);
			this.cbState.TabIndex = 0;
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(635, 17);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(75, 26);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.TabIndex = 16;
			this.ButtonX2.Text = "ອອກ";
			//
			//Timer2
			//
			this.Timer2.Interval = 1;
			//
			//pn
			//
			this.pn.Controls.Add(this.Label5);
			this.pn.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn.Location = new System.Drawing.Point(0, 10);
			this.pn.Name = "pn";
			this.pn.Size = new System.Drawing.Size(722, 60);
			this.pn.TabIndex = 17;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.ButtonX2);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new System.Drawing.Point(0, 428);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(722, 60);
			this.Panel2.TabIndex = 18;
			//
			//frm_Login
			//
			this.AcceptButton = this.btLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(722, 488);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.pn);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.pgb);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ຍິນດີຕ້ອນຮັບເຂົ້າສູ່ລະບົບ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.pn.ResumeLayout(false);
			this.pn.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal ProgressBar pgb;
		internal Timer Timer1;
		internal Label Label5;
		internal ImageList ImageList1;
		internal Panel Panel1;
		internal DevComponents.DotNetBar.ButtonX btLogin;
		internal Label Label4;
		internal Label Label3;
		internal Label Label2;
		internal CheckBox cbkShowPassword;
		internal ComboBox cbState;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
		internal Timer Timer2;
		internal Panel pn;
		internal Panel Panel2;
	}
	
}
