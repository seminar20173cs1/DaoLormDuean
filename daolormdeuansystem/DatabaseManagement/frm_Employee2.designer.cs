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
	
	partial class frm_Employee2 : System.Windows.Forms.Form
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
			this.Panel1 = new System.Windows.Forms.Panel();
			base.Load += new System.EventHandler(frm_Employee2_Load);
			this.Panel7 = new System.Windows.Forms.Panel();
			this.lbDob = new System.Windows.Forms.Label();
			this.lbID = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbLastName = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
			this.Panel6 = new System.Windows.Forms.Panel();
			this.lbSalary = new System.Windows.Forms.Label();
			this.lbPosition = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.lbTel = new System.Windows.Forms.Label();
			this.lbParentTel = new System.Windows.Forms.Label();
			this.lbEmail = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.lbVillag = new System.Windows.Forms.Label();
			this.lbDistrict = new System.Windows.Forms.Label();
			this.lbProvince = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.pgb = new System.Windows.Forms.PictureBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Line3 = new DevComponents.DotNetBar.Controls.Line();
			this.Label3 = new System.Windows.Forms.Label();
			this.pnEmployee = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Label1 = new System.Windows.Forms.Label();
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ຈດການToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ເພມພະນກງານToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ເພມພະນກງານToolStripMenuItem.Click += new System.EventHandler(this.ເພມພະນກງານToolStripMenuItem_Click);
			this.ແກໃຂToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ລບToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ອອກToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.Panel7.SuspendLayout();
			this.FlowLayoutPanel1.SuspendLayout();
			this.Panel6.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.pgb).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.Panel1.Controls.Add(this.Panel7);
			this.Panel1.Controls.Add(this.FlowLayoutPanel1);
			this.Panel1.Controls.Add(this.Panel6);
			this.Panel1.Controls.Add(this.Panel5);
			this.Panel1.Controls.Add(this.Panel4);
			this.Panel1.Controls.Add(this.pgb);
			this.Panel1.Location = new System.Drawing.Point(272, 108);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(485, 543);
			this.Panel1.TabIndex = 0;
			//
			//Panel7
			//
			this.Panel7.BackColor = System.Drawing.SystemColors.ControlText;
			this.Panel7.Controls.Add(this.Label18);
			this.Panel7.Controls.Add(this.lbDob);
			this.Panel7.Controls.Add(this.lbID);
			this.Panel7.Controls.Add(this.lbName);
			this.Panel7.Controls.Add(this.lbLastName);
			this.Panel7.Controls.Add(this.Label7);
			this.Panel7.Controls.Add(this.Label4);
			this.Panel7.Controls.Add(this.Label5);
			this.Panel7.Controls.Add(this.Label6);
			this.Panel7.Location = new System.Drawing.Point(5, 4);
			this.Panel7.Name = "Panel7";
			this.Panel7.Size = new System.Drawing.Size(308, 197);
			this.Panel7.TabIndex = 16;
			//
			//lbDob
			//
			this.lbDob.AutoSize = true;
			this.lbDob.BackColor = System.Drawing.Color.Transparent;
			this.lbDob.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbDob.ForeColor = System.Drawing.Color.White;
			this.lbDob.Location = new System.Drawing.Point(171, 145);
			this.lbDob.Name = "lbDob";
			this.lbDob.Size = new System.Drawing.Size(152, 31);
			this.lbDob.TabIndex = 14;
			this.lbDob.Text = "ວັນເດືອນປະເກີດ:";
			//
			//lbID
			//
			this.lbID.AutoSize = true;
			this.lbID.BackColor = System.Drawing.Color.Transparent;
			this.lbID.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbID.ForeColor = System.Drawing.Color.White;
			this.lbID.Location = new System.Drawing.Point(171, 52);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(157, 31);
			this.lbID.TabIndex = 11;
			this.lbID.Text = "ລະຫັດພະນັກງານ:";
			//
			//lbName
			//
			this.lbName.AutoSize = true;
			this.lbName.BackColor = System.Drawing.Color.Transparent;
			this.lbName.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbName.ForeColor = System.Drawing.Color.White;
			this.lbName.Location = new System.Drawing.Point(171, 83);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(34, 31);
			this.lbName.TabIndex = 12;
			this.lbName.Text = "ຊື່:";
			//
			//lbLastName
			//
			this.lbLastName.AutoSize = true;
			this.lbLastName.BackColor = System.Drawing.Color.Transparent;
			this.lbLastName.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbLastName.ForeColor = System.Drawing.Color.White;
			this.lbLastName.Location = new System.Drawing.Point(171, 114);
			this.lbLastName.Name = "lbLastName";
			this.lbLastName.Size = new System.Drawing.Size(109, 31);
			this.lbLastName.TabIndex = 13;
			this.lbLastName.Text = "ນາມສະກຸນ:";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.White;
			this.Label7.Location = new System.Drawing.Point(8, 145);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(152, 31);
			this.Label7.TabIndex = 10;
			this.Label7.Text = "ວັນເດືອນປະເກີດ:";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(8, 52);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(157, 31);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "ລະຫັດພະນັກງານ:";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(8, 83);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(34, 31);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "ຊື່:";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.Color.White;
			this.Label6.Location = new System.Drawing.Point(8, 114);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(109, 31);
			this.Label6.TabIndex = 9;
			this.Label6.Text = "ນາມສະກຸນ:";
			//
			//FlowLayoutPanel1
			//
			this.FlowLayoutPanel1.Controls.Add(this.ButtonX1);
			this.FlowLayoutPanel1.Controls.Add(this.ButtonX2);
			this.FlowLayoutPanel1.Controls.Add(this.ButtonX3);
			this.FlowLayoutPanel1.Location = new System.Drawing.Point(2, 488);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Size = new System.Drawing.Size(479, 53);
			this.FlowLayoutPanel1.TabIndex = 17;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(3, 3);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(153, 41);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.Symbol = "";
			this.ButtonX1.TabIndex = 0;
			this.ButtonX1.Text = "ເພີ່ມພະນັກງານ";
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(162, 3);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(153, 41);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.Symbol = "";
			this.ButtonX2.TabIndex = 1;
			this.ButtonX2.Text = "ແກ້ໃຂ";
			//
			//ButtonX3
			//
			this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX3.Location = new System.Drawing.Point(321, 3);
			this.ButtonX3.Name = "ButtonX3";
			this.ButtonX3.Size = new System.Drawing.Size(153, 41);
			this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX3.Symbol = "";
			this.ButtonX3.TabIndex = 2;
			this.ButtonX3.Text = "ລົບ";
			//
			//Panel6
			//
			this.Panel6.Controls.Add(this.Label17);
			this.Panel6.Controls.Add(this.lbSalary);
			this.Panel6.Controls.Add(this.lbPosition);
			this.Panel6.Controls.Add(this.Label12);
			this.Panel6.Controls.Add(this.Label11);
			this.Panel6.Location = new System.Drawing.Point(2, 407);
			this.Panel6.Name = "Panel6";
			this.Panel6.Size = new System.Drawing.Size(479, 75);
			this.Panel6.TabIndex = 16;
			//
			//lbSalary
			//
			this.lbSalary.AutoSize = true;
			this.lbSalary.BackColor = System.Drawing.Color.Transparent;
			this.lbSalary.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbSalary.ForeColor = System.Drawing.Color.White;
			this.lbSalary.Location = new System.Drawing.Point(132, 51);
			this.lbSalary.Name = "lbSalary";
			this.lbSalary.Size = new System.Drawing.Size(65, 18);
			this.lbSalary.TabIndex = 15;
			this.lbSalary.Text = "ເງິນເດືອນ:";
			//
			//lbPosition
			//
			this.lbPosition.AutoSize = true;
			this.lbPosition.BackColor = System.Drawing.Color.Transparent;
			this.lbPosition.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbPosition.ForeColor = System.Drawing.Color.White;
			this.lbPosition.Location = new System.Drawing.Point(132, 36);
			this.lbPosition.Name = "lbPosition";
			this.lbPosition.Size = new System.Drawing.Size(55, 18);
			this.lbPosition.TabIndex = 14;
			this.lbPosition.Text = "ຕໍາແໜ່ງ:";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.BackColor = System.Drawing.Color.Transparent;
			this.Label12.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label12.ForeColor = System.Drawing.Color.White;
			this.Label12.Location = new System.Drawing.Point(24, 51);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(65, 18);
			this.Label12.TabIndex = 13;
			this.Label12.Text = "ເງິນເດືອນ:";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.Color.Transparent;
			this.Label11.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11.ForeColor = System.Drawing.Color.White;
			this.Label11.Location = new System.Drawing.Point(24, 35);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(55, 18);
			this.Label11.TabIndex = 6;
			this.Label11.Text = "ຕໍາແໜ່ງ:";
			//
			//Panel5
			//
			this.Panel5.BackColor = System.Drawing.Color.Chocolate;
			this.Panel5.Controls.Add(this.Label2);
			this.Panel5.Controls.Add(this.lbTel);
			this.Panel5.Controls.Add(this.lbParentTel);
			this.Panel5.Controls.Add(this.lbEmail);
			this.Panel5.Controls.Add(this.Label10);
			this.Panel5.Controls.Add(this.Label9);
			this.Panel5.Controls.Add(this.Label8);
			this.Panel5.Location = new System.Drawing.Point(2, 208);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(482, 100);
			this.Panel5.TabIndex = 15;
			//
			//lbTel
			//
			this.lbTel.AutoSize = true;
			this.lbTel.BackColor = System.Drawing.Color.Transparent;
			this.lbTel.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbTel.ForeColor = System.Drawing.Color.White;
			this.lbTel.Location = new System.Drawing.Point(116, 50);
			this.lbTel.Name = "lbTel";
			this.lbTel.Size = new System.Drawing.Size(44, 18);
			this.lbTel.TabIndex = 10;
			this.lbTel.Text = "ເບີໂທ:";
			//
			//lbParentTel
			//
			this.lbParentTel.AutoSize = true;
			this.lbParentTel.BackColor = System.Drawing.Color.Transparent;
			this.lbParentTel.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbParentTel.ForeColor = System.Drawing.Color.White;
			this.lbParentTel.Location = new System.Drawing.Point(116, 67);
			this.lbParentTel.Name = "lbParentTel";
			this.lbParentTel.Size = new System.Drawing.Size(78, 18);
			this.lbParentTel.TabIndex = 11;
			this.lbParentTel.Text = "ເບີຜູ້ປົກຄອງ:";
			//
			//lbEmail
			//
			this.lbEmail.AutoSize = true;
			this.lbEmail.BackColor = System.Drawing.Color.Transparent;
			this.lbEmail.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbEmail.ForeColor = System.Drawing.Color.White;
			this.lbEmail.Location = new System.Drawing.Point(116, 82);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(46, 18);
			this.lbEmail.TabIndex = 12;
			this.lbEmail.Text = "ອີເມລ:";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.Transparent;
			this.Label10.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10.ForeColor = System.Drawing.Color.White;
			this.Label10.Location = new System.Drawing.Point(12, 50);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(44, 18);
			this.Label10.TabIndex = 7;
			this.Label10.Text = "ເບີໂທ:";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.Color.Transparent;
			this.Label9.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.ForeColor = System.Drawing.Color.White;
			this.Label9.Location = new System.Drawing.Point(12, 67);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(78, 18);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "ເບີຜູ້ປົກຄອງ:";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.Color.White;
			this.Label8.Location = new System.Drawing.Point(12, 82);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(46, 18);
			this.Label8.TabIndex = 9;
			this.Label8.Text = "ອີເມລ:";
			//
			//Panel4
			//
			this.Panel4.Controls.Add(this.Label16);
			this.Panel4.Controls.Add(this.lbVillag);
			this.Panel4.Controls.Add(this.lbDistrict);
			this.Panel4.Controls.Add(this.lbProvince);
			this.Panel4.Controls.Add(this.Label15);
			this.Panel4.Controls.Add(this.Label14);
			this.Panel4.Controls.Add(this.Label13);
			this.Panel4.Location = new System.Drawing.Point(2, 314);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(479, 100);
			this.Panel4.TabIndex = 14;
			//
			//lbVillag
			//
			this.lbVillag.AutoSize = true;
			this.lbVillag.BackColor = System.Drawing.Color.Transparent;
			this.lbVillag.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbVillag.ForeColor = System.Drawing.Color.White;
			this.lbVillag.Location = new System.Drawing.Point(129, 39);
			this.lbVillag.Name = "lbVillag";
			this.lbVillag.Size = new System.Drawing.Size(37, 18);
			this.lbVillag.TabIndex = 13;
			this.lbVillag.Text = "ບ້ານ:";
			//
			//lbDistrict
			//
			this.lbDistrict.AutoSize = true;
			this.lbDistrict.BackColor = System.Drawing.Color.Transparent;
			this.lbDistrict.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbDistrict.ForeColor = System.Drawing.Color.White;
			this.lbDistrict.Location = new System.Drawing.Point(129, 56);
			this.lbDistrict.Name = "lbDistrict";
			this.lbDistrict.Size = new System.Drawing.Size(43, 18);
			this.lbDistrict.TabIndex = 14;
			this.lbDistrict.Text = "ເມືອງ:";
			//
			//lbProvince
			//
			this.lbProvince.AutoSize = true;
			this.lbProvince.BackColor = System.Drawing.Color.Transparent;
			this.lbProvince.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbProvince.ForeColor = System.Drawing.Color.White;
			this.lbProvince.Location = new System.Drawing.Point(129, 72);
			this.lbProvince.Name = "lbProvince";
			this.lbProvince.Size = new System.Drawing.Size(45, 18);
			this.lbProvince.TabIndex = 15;
			this.lbProvince.Text = "ແຂວງ:";
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.BackColor = System.Drawing.Color.Transparent;
			this.Label15.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label15.ForeColor = System.Drawing.Color.White;
			this.Label15.Location = new System.Drawing.Point(21, 39);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(37, 18);
			this.Label15.TabIndex = 10;
			this.Label15.Text = "ບ້ານ:";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.BackColor = System.Drawing.Color.Transparent;
			this.Label14.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label14.ForeColor = System.Drawing.Color.White;
			this.Label14.Location = new System.Drawing.Point(21, 56);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(43, 18);
			this.Label14.TabIndex = 11;
			this.Label14.Text = "ເມືອງ:";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.BackColor = System.Drawing.Color.Transparent;
			this.Label13.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label13.ForeColor = System.Drawing.Color.White;
			this.Label13.Location = new System.Drawing.Point(21, 72);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(45, 18);
			this.Label13.TabIndex = 12;
			this.Label13.Text = "ແຂວງ:";
			//
			//pgb
			//
			this.pgb.InitialImage = Properties.Resources.compose;
			this.pgb.Location = new System.Drawing.Point(319, 4);
			this.pgb.Name = "pgb";
			this.pgb.Size = new System.Drawing.Size(162, 197);
			this.pgb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pgb.TabIndex = 1;
			this.pgb.TabStop = false;
			//
			//Panel2
			//
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel2.BackColor = System.Drawing.Color.DodgerBlue;
			this.Panel2.Controls.Add(this.ButtonX4);
			this.Panel2.Controls.Add(this.Line3);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.ForeColor = System.Drawing.Color.White;
			this.Panel2.Location = new System.Drawing.Point(14, 29);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(254, 74);
			this.Panel2.TabIndex = 1;
			//
			//Line3
			//
			this.Line3.BackColor = System.Drawing.Color.Transparent;
			this.Line3.Location = new System.Drawing.Point(19, 54);
			this.Line3.Name = "Line3";
			this.Line3.Size = new System.Drawing.Size(222, 17);
			this.Line3.TabIndex = 5;
			this.Line3.Text = "Line3";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(15, 26);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(172, 35);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "ພະນັກງານທັງໝົດ";
			//
			//pnEmployee
			//
			this.pnEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnEmployee.AutoScroll = true;
			this.pnEmployee.BackColor = System.Drawing.Color.Transparent;
			this.pnEmployee.Location = new System.Drawing.Point(13, 108);
			this.pnEmployee.Name = "pnEmployee";
			this.pnEmployee.Size = new System.Drawing.Size(255, 543);
			this.pnEmployee.TabIndex = 2;
			//
			//ButtonX4
			//
			this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX4.Location = new System.Drawing.Point(194, 17);
			this.ButtonX4.Name = "ButtonX4";
			this.ButtonX4.Size = new System.Drawing.Size(47, 41);
			this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX4.Symbol = "";
			this.ButtonX4.TabIndex = 6;
			//
			//Panel3
			//
			this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel3.BackColor = System.Drawing.Color.DodgerBlue;
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.ForeColor = System.Drawing.Color.White;
			this.Panel3.Location = new System.Drawing.Point(277, 29);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(480, 74);
			this.Panel3.TabIndex = 7;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(171, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(137, 35);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "ຂໍ້ມູນສ່ວນຕົວ";
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ຈດການToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(770, 24);
			this.MenuStrip1.TabIndex = 8;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//ຈດການToolStripMenuItem
			//
			this.ຈດການToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ເພມພະນກງານToolStripMenuItem, this.ແກໃຂToolStripMenuItem, this.ລບToolStripMenuItem, this.ອອກToolStripMenuItem});
			this.ຈດການToolStripMenuItem.Name = "ຈດການToolStripMenuItem";
			this.ຈດການToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.ຈດການToolStripMenuItem.Text = "ຈັດການ";
			//
			//ເພມພະນກງານToolStripMenuItem
			//
			this.ເພມພະນກງານToolStripMenuItem.Name = "ເພມພະນກງານToolStripMenuItem";
			this.ເພມພະນກງານToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N);
			this.ເພມພະນກງານToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.ເພມພະນກງານToolStripMenuItem.Text = "ເພີ່ມພະນັກງານ";
			//
			//ແກໃຂToolStripMenuItem
			//
			this.ແກໃຂToolStripMenuItem.Name = "ແກໃຂToolStripMenuItem";
			this.ແກໃຂToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E);
			this.ແກໃຂToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.ແກໃຂToolStripMenuItem.Text = "ແກ້ໃຂ";
			//
			//ລບToolStripMenuItem
			//
			this.ລບToolStripMenuItem.Name = "ລບToolStripMenuItem";
			this.ລບToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D);
			this.ລບToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.ລບToolStripMenuItem.Text = "ລົບ";
			//
			//ອອກToolStripMenuItem
			//
			this.ອອກToolStripMenuItem.Name = "ອອກToolStripMenuItem";
			this.ອອກToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q);
			this.ອອກToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
			this.ອອກToolStripMenuItem.Text = "ອອກ";
			//
			//Label2
			//
			this.Label2.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(0, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(482, 34);
			this.Label2.TabIndex = 13;
			this.Label2.Text = "ຂໍ້ມູນຕິດຕໍ່";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label16
			//
			this.Label16.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label16.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label16.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label16.ForeColor = System.Drawing.Color.White;
			this.Label16.Location = new System.Drawing.Point(0, 0);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(479, 34);
			this.Label16.TabIndex = 16;
			this.Label16.Text = "ທີ່ຢູ່";
			this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label17
			//
			this.Label17.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label17.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label17.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label17.ForeColor = System.Drawing.Color.White;
			this.Label17.Location = new System.Drawing.Point(0, 0);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(479, 34);
			this.Label17.TabIndex = 16;
			this.Label17.Text = "ໜ້າທີ່ ແລະ ເງິນເດືອນ";
			this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label18
			//
			this.Label18.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label18.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label18.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label18.ForeColor = System.Drawing.Color.White;
			this.Label18.Location = new System.Drawing.Point(0, 0);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(308, 34);
			this.Label18.TabIndex = 15;
			this.Label18.Text = "ຂໍ້ມູນພື້ນຖານ";
			this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//frm_Employee2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(770, 659);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.pnEmployee);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.MenuStrip1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.MainMenuStrip = this.MenuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Employee2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_Employee2";
			this.Panel1.ResumeLayout(false);
			this.Panel7.ResumeLayout(false);
			this.Panel7.PerformLayout();
			this.FlowLayoutPanel1.ResumeLayout(false);
			this.Panel6.ResumeLayout(false);
			this.Panel6.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.pgb).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Panel Panel1;
		internal FlowLayoutPanel FlowLayoutPanel1;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal DevComponents.DotNetBar.ButtonX ButtonX3;
		internal Panel Panel6;
		internal Label Label12;
		internal Label Label11;
		internal Panel Panel5;
		internal Label Label10;
		internal Label Label9;
		internal Label Label8;
		internal Panel Panel4;
		internal Label Label15;
		internal Label Label14;
		internal Label Label13;
		internal PictureBox pgb;
		internal Panel Panel2;
		internal DevComponents.DotNetBar.Controls.Line Line3;
		internal Label Label3;
		internal Panel Panel7;
		internal Label lbDob;
		internal Label lbID;
		internal Label lbName;
		internal Label lbLastName;
		internal Label Label7;
		internal Label Label4;
		internal Label Label5;
		internal Label Label6;
		internal Label lbSalary;
		internal Label lbPosition;
		internal Label lbTel;
		internal Label lbParentTel;
		internal Label lbEmail;
		internal Label lbVillag;
		internal Label lbDistrict;
		internal Label lbProvince;
		internal FlowLayoutPanel pnEmployee;
		internal DevComponents.DotNetBar.ButtonX ButtonX4;
		internal Panel Panel3;
		internal Label Label1;
		internal MenuStrip MenuStrip1;
		internal ToolStripMenuItem ຈດການToolStripMenuItem;
		internal ToolStripMenuItem ເພມພະນກງານToolStripMenuItem;
		internal ToolStripMenuItem ແກໃຂToolStripMenuItem;
		internal ToolStripMenuItem ລບToolStripMenuItem;
		internal ToolStripMenuItem ອອກToolStripMenuItem;
		internal Label Label18;
		internal Label Label17;
		internal Label Label2;
		internal Label Label16;
	}
	
}
