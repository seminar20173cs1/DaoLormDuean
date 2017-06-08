
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
	//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class Frm_Main : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
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
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Frm_Main_Load);
			base.MdiChildActivate += new System.EventHandler(Frm_Main_MdiChildActivate);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ViewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
			this.tmIn = new System.Windows.Forms.Timer(this.components);
			this.tmIn.Tick += new System.EventHandler(this.tmIn_Tick);
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Timer3 = new System.Windows.Forms.Timer(this.components);
			this.Timer4 = new System.Windows.Forms.Timer(this.components);
			this.tmMenu = new System.Windows.Forms.Timer(this.components);
			this.tmMenu.Tick += new System.EventHandler(this.tmMenu_Tick);
			this.tmMenuOut = new System.Windows.Forms.Timer(this.components);
			this.tmMenuOut.Tick += new System.EventHandler(this.tmMenuOut_Tick);
			this.btMenu = new DevComponents.DotNetBar.ButtonX();
			this.btMenu.Click += new System.EventHandler(this.ButtonX7_Click);
			this.btUser = new DevComponents.DotNetBar.ButtonX();
			this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2.Click += new System.EventHandler(this.ButtonItem2_Click);
			this.ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem3.Click += new System.EventHandler(this.ButtonItem3_Click);
			this.pnMenu = new System.Windows.Forms.Panel();
			this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ReflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.ReflectionLabel2.Click += new System.EventHandler(this.ReflectionLabel2_Click);
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.ReflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
			this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX6 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX6.Click += new System.EventHandler(this.ButtonX6_Click_1);
			this.ButtonX7 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonItem12 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem13 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem13.Click += new System.EventHandler(this.ButtonItem7_Click);
			this.ButtonItem14 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem14.Click += new System.EventHandler(this.ButtonItem8_Click);
			this.ButtonItem15 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem15.Click += new System.EventHandler(this.ButtonItem9_Click);
			this.ButtonItem16 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem16.Click += new System.EventHandler(this.ButtonItem5_Click);
			this.ButtonItem17 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem17.Click += new System.EventHandler(this.ButtonItem6_Click);
			this.ButtonItem18 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem18.Click += new System.EventHandler(this.ButtonItem4_Click);
			this.ButtonItem19 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem19.Click += new System.EventHandler(this.ButtonItem19_Click);
			this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
			this.ລາຍງານຂໍ້ມູນການຂາຍ = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem7.Click += new System.EventHandler(this.ButtonItem7_Click);
			this.ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem8.Click += new System.EventHandler(this.ButtonItem8_Click);
			this.ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem9.Click += new System.EventHandler(this.ButtonItem9_Click);
			this.ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem5.Click += new System.EventHandler(this.ButtonItem5_Click);
			this.ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem6.Click += new System.EventHandler(this.ButtonItem6_Click);
			this.ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem4.Click += new System.EventHandler(this.ButtonItem4_Click);
			this.ButtonItem10 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem11 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.ContextMenuStrip1.SuspendLayout();
			this.pnMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ViewProfileToolStripMenuItem, this.ChangePasswordToolStripMenuItem, this.LogOutToolStripMenuItem});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(169, 70);
			//
			//ViewProfileToolStripMenuItem
			//
			this.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem";
			this.ViewProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.ViewProfileToolStripMenuItem.Text = "View Profile";
			//
			//ChangePasswordToolStripMenuItem
			//
			this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
			this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.ChangePasswordToolStripMenuItem.Text = "Change Password";
			//
			//LogOutToolStripMenuItem
			//
			this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
			this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.LogOutToolStripMenuItem.Text = "Log Out";
			//
			//tmIn
			//
			this.tmIn.Interval = 10;
			//
			//tmMenu
			//
			this.tmMenu.Interval = 1;
			//
			//tmMenuOut
			//
			//
			//btMenu
			//
			this.btMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
			this.btMenu.Location = new System.Drawing.Point(23, 11);
			this.btMenu.Name = "btMenu";
			this.btMenu.Size = new System.Drawing.Size(38, 35);
			this.btMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btMenu.Symbol = "58410";
			this.btMenu.SymbolColor = System.Drawing.Color.Black;
			this.btMenu.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btMenu.TabIndex = 3;
			this.btMenu.Text = ".";
			//
			//btUser
			//
			this.btUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btUser.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.btUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btUser.Location = new System.Drawing.Point(123, 402);
			this.btUser.Name = "btUser";
			this.btUser.Size = new System.Drawing.Size(166, 28);
			this.btUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btUser.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ButtonItem2, this.ButtonItem3});
			this.btUser.TabIndex = 19;
			//
			//ButtonItem2
			//
			this.ButtonItem2.GlobalItem = false;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Symbol = "";
			this.ButtonItem2.Text = "Change Password";
			//
			//ButtonItem3
			//
			this.ButtonItem3.GlobalItem = false;
			this.ButtonItem3.Name = "ButtonItem3";
			this.ButtonItem3.Symbol = "";
			this.ButtonItem3.Text = "Log Out";
			//
			//pnMenu
			//
			this.pnMenu.BackColor = System.Drawing.Color.RoyalBlue;
			this.pnMenu.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnMenu.Controls.Add(this.Label2);
			this.pnMenu.Controls.Add(this.Label1);
			this.pnMenu.Controls.Add(this.ReflectionLabel2);
			this.pnMenu.Controls.Add(this.btUser);
			this.pnMenu.Controls.Add(this.PictureBox1);
			this.pnMenu.Controls.Add(this.Panel2);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMenu.Location = new System.Drawing.Point(0, 0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(802, 444);
			this.pnMenu.TabIndex = 15;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(219, 50);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(211, 39);
			this.Label2.TabIndex = 22;
			this.Label2.Text = "=datetime.now";
			//
			//Label1
			//
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(18, 404);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(99, 27);
			this.Label1.TabIndex = 21;
			this.Label1.Text = "ຜູ້ໃຊ້ລະບົບ:";
			//
			//ReflectionLabel2
			//
			this.ReflectionLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ReflectionLabel2.BackColor = System.Drawing.Color.Transparent;
			//
			//
			//
			this.ReflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ReflectionLabel2.Font = new System.Drawing.Font("Hongkad Handwriting1", (float) (24.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ReflectionLabel2.ForeColor = System.Drawing.Color.White;
			this.ReflectionLabel2.Location = new System.Drawing.Point(214, 10);
			this.ReflectionLabel2.Name = "ReflectionLabel2";
			this.ReflectionLabel2.Size = new System.Drawing.Size(581, 78);
			this.ReflectionLabel2.TabIndex = 20;
			this.ReflectionLabel2.Text = "]t[q[[=]ydkoihkovkskofk;]hv,gfnvo";
			//
			//PictureBox1
			//
			this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PictureBox1.Image = Properties.Resources.IMG_20161227_WA0000;
			this.PictureBox1.Location = new System.Drawing.Point(94, 11);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(119, 91);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			//
			//Panel2
			//
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel2.Controls.Add(this.ReflectionLabel1);
			this.Panel2.Controls.Add(this.btMenu);
			this.Panel2.Controls.Add(this.ButtonX4);
			this.Panel2.Controls.Add(this.ButtonX5);
			this.Panel2.Controls.Add(this.ButtonX6);
			this.Panel2.Controls.Add(this.ButtonX7);
			this.Panel2.Controls.Add(this.ButtonX3);
			this.Panel2.Controls.Add(this.ButtonX2);
			this.Panel2.Controls.Add(this.ButtonX1);
			this.Panel2.ForeColor = System.Drawing.Color.White;
			this.Panel2.Location = new System.Drawing.Point(94, 108);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(619, 288);
			this.Panel2.TabIndex = 0;
			//
			//ReflectionLabel1
			//
			this.ReflectionLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ReflectionLabel1.BackColor = System.Drawing.Color.Transparent;
			//
			//
			//
			this.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ReflectionLabel1.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ReflectionLabel1.Location = new System.Drawing.Point(280, 2);
			this.ReflectionLabel1.Name = "ReflectionLabel1";
			this.ReflectionLabel1.Size = new System.Drawing.Size(81, 57);
			this.ReflectionLabel1.TabIndex = 12;
			this.ReflectionLabel1.Text = "ໜ້າຫຼັກ";
			//
			//ButtonX4
			//
			this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX4.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX4.Location = new System.Drawing.Point(409, 170);
			this.ButtonX4.Name = "ButtonX4";
			this.ButtonX4.Size = new System.Drawing.Size(187, 102);
			this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX4.Symbol = "";
			this.ButtonX4.SymbolColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ButtonX4.SymbolSize = (float) (50.0F);
			this.ButtonX4.TabIndex = 11;
			this.ButtonX4.Text = "ອອກຈາກລະບົບ";
			//
			//ButtonX5
			//
			this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX5.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX5.Location = new System.Drawing.Point(216, 170);
			this.ButtonX5.Name = "ButtonX5";
			this.ButtonX5.Size = new System.Drawing.Size(187, 102);
			this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX5.Symbol = "";
			this.ButtonX5.SymbolColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ButtonX5.SymbolSize = (float) (50.0F);
			this.ButtonX5.TabIndex = 10;
			this.ButtonX5.Text = "ຄົ້ນຫາ";
			//
			//ButtonX6
			//
			this.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX6.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX6.Location = new System.Drawing.Point(23, 170);
			this.ButtonX6.Name = "ButtonX6";
			this.ButtonX6.Size = new System.Drawing.Size(187, 102);
			this.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX6.Symbol = "";
			this.ButtonX6.SymbolColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ButtonX6.SymbolSize = (float) (50.0F);
			this.ButtonX6.TabIndex = 9;
			this.ButtonX6.Text = "ຈັດການຂໍ້ມູນ";
			//
			//ButtonX7
			//
			this.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX7.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX7.Location = new System.Drawing.Point(409, 62);
			this.ButtonX7.Name = "ButtonX7";
			this.ButtonX7.Size = new System.Drawing.Size(187, 102);
			this.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ButtonItem12, this.ButtonItem16, this.ButtonItem17});
			this.ButtonX7.Symbol = "";
			this.ButtonX7.SymbolColor = System.Drawing.Color.Blue;
			this.ButtonX7.SymbolSize = (float) (50.0F);
			this.ButtonX7.TabIndex = 8;
			this.ButtonX7.Text = "ລາຍງານ";
			//
			//ButtonItem12
			//
			this.ButtonItem12.GlobalItem = false;
			this.ButtonItem12.Name = "ButtonItem12";
			this.ButtonItem12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ButtonItem13, this.ButtonItem14, this.ButtonItem15});
			this.ButtonItem12.Symbol = "57373";
			this.ButtonItem12.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.ButtonItem12.Text = "ລາຍງານຂໍ້ມູນການຂາຍ";
			//
			//ButtonItem13
			//
			this.ButtonItem13.Name = "ButtonItem13";
			this.ButtonItem13.Symbol = "";
			this.ButtonItem13.Text = "ປະຈໍາວັນ";
			//
			//ButtonItem14
			//
			this.ButtonItem14.Name = "ButtonItem14";
			this.ButtonItem14.Symbol = "";
			this.ButtonItem14.Text = "ປະຈໍາເດືອນ";
			//
			//ButtonItem15
			//
			this.ButtonItem15.Name = "ButtonItem15";
			this.ButtonItem15.Symbol = "";
			this.ButtonItem15.Text = "ປະຈໍາປີ";
			//
			//ButtonItem16
			//
			this.ButtonItem16.GlobalItem = false;
			this.ButtonItem16.Name = "ButtonItem16";
			this.ButtonItem16.Symbol = "";
			this.ButtonItem16.Text = "ລາຍງານຂໍ້ມູນການຈອງ";
			//
			//ButtonItem17
			//
			this.ButtonItem17.GlobalItem = false;
			this.ButtonItem17.Name = "ButtonItem17";
			this.ButtonItem17.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ButtonItem18, this.ButtonItem19});
			this.ButtonItem17.Symbol = "";
			this.ButtonItem17.Text = "ລາຍງານຂໍ້ມູນອາຫານຂາຍດີ";
			//
			//ButtonItem18
			//
			this.ButtonItem18.Name = "ButtonItem18";
			this.ButtonItem18.Symbol = "";
			this.ButtonItem18.Text = "ລາຍປີ";
			//
			//ButtonItem19
			//
			this.ButtonItem19.Name = "ButtonItem19";
			this.ButtonItem19.Symbol = "";
			this.ButtonItem19.Text = "ລາຍເດືອນ";
			//
			//ButtonX3
			//
			this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX3.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX3.Location = new System.Drawing.Point(409, 62);
			this.ButtonX3.Name = "ButtonX3";
			this.ButtonX3.Size = new System.Drawing.Size(187, 102);
			this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ລາຍງານຂໍ້ມູນການຂາຍ, this.ButtonItem5, this.ButtonItem6});
			this.ButtonX3.Symbol = "";
			this.ButtonX3.SymbolColor = System.Drawing.Color.Blue;
			this.ButtonX3.SymbolSize = (float) (50.0F);
			this.ButtonX3.TabIndex = 8;
			this.ButtonX3.Text = "ລາຍງານ";
			//
			//ລາຍງານຂໍ້ມູນການຂາຍ
			//
			this.ລາຍງານຂໍ້ມູນການຂາຍ.GlobalItem = false;
			this.ລາຍງານຂໍ້ມູນການຂາຍ.Name = "ລາຍງານຂໍ້ມູນການຂາຍ";
			this.ລາຍງານຂໍ້ມູນການຂາຍ.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ButtonItem7, this.ButtonItem8, this.ButtonItem9});
			this.ລາຍງານຂໍ້ມູນການຂາຍ.Text = "ລາຍງານຂໍ້ມູນການຂາຍ";
			//
			//ButtonItem7
			//
			this.ButtonItem7.Name = "ButtonItem7";
			this.ButtonItem7.Text = "ປະຈໍາວັນ";
			//
			//ButtonItem8
			//
			this.ButtonItem8.Name = "ButtonItem8";
			this.ButtonItem8.Text = "ປະຈໍາເດືອນ";
			//
			//ButtonItem9
			//
			this.ButtonItem9.Name = "ButtonItem9";
			this.ButtonItem9.Text = "ປະຈໍາປີ";
			//
			//ButtonItem5
			//
			this.ButtonItem5.GlobalItem = false;
			this.ButtonItem5.Name = "ButtonItem5";
			this.ButtonItem5.Text = "ລາຍງານຂໍ້ມູນການຈອງ";
			//
			//ButtonItem6
			//
			this.ButtonItem6.GlobalItem = false;
			this.ButtonItem6.Name = "ButtonItem6";
			this.ButtonItem6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ButtonItem4, this.ButtonItem10, this.ButtonItem11});
			this.ButtonItem6.Text = "ລາຍງານຂໍ້ມູນອາຫານຂາຍດີ";
			//
			//ButtonItem4
			//
			this.ButtonItem4.Name = "ButtonItem4";
			this.ButtonItem4.Text = "ລາຍປີ";
			//
			//ButtonItem10
			//
			this.ButtonItem10.Name = "ButtonItem10";
			this.ButtonItem10.Text = "ລາຍເດື່ອນ";
			//
			//ButtonItem11
			//
			this.ButtonItem11.Name = "ButtonItem11";
			this.ButtonItem11.Text = "ລາຍວັນ";
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX2.Location = new System.Drawing.Point(216, 62);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(187, 102);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.Symbol = "59489";
			this.ButtonX2.SymbolColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ButtonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.ButtonX2.SymbolSize = (float) (50.0F);
			this.ButtonX2.TabIndex = 7;
			this.ButtonX2.Text = "ສັ່ງຈອງ";
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX1.Location = new System.Drawing.Point(23, 62);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(187, 102);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.Symbol = "";
			this.ButtonX1.SymbolColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)));
			this.ButtonX1.SymbolSize = (float) (40.0F);
			this.ButtonX1.TabIndex = 6;
			this.ButtonX1.Text = "ບໍລິການ";
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			//
			//Frm_Main
			//
			this.AcceptButton = this.btMenu;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(802, 444);
			this.Controls.Add(this.pnMenu);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Frm_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_Main";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.pnMenu.ResumeLayout(false);
			this.pnMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal ContextMenuStrip ContextMenuStrip1;
		internal ToolStripMenuItem ViewProfileToolStripMenuItem;
		internal ToolStripMenuItem ChangePasswordToolStripMenuItem;
		internal ToolStripMenuItem LogOutToolStripMenuItem;
		internal Timer tmIn;
		internal Timer Timer2;
		internal Timer Timer3;
		internal Timer Timer4;
		internal Panel pnMenu;
		internal Timer tmMenu;
		internal Timer tmMenuOut;
		internal Panel Panel2;
		internal DevComponents.DotNetBar.ButtonX ButtonX4;
		internal DevComponents.DotNetBar.ButtonX ButtonX5;
		internal DevComponents.DotNetBar.ButtonX ButtonX6;
		internal DevComponents.DotNetBar.ButtonX ButtonX3;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.Controls.ReflectionLabel ReflectionLabel1;
		internal DevComponents.DotNetBar.ButtonX btMenu;
		internal DevComponents.DotNetBar.ButtonX btUser;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem2;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem3;
		internal PictureBox PictureBox1;
		internal DevComponents.DotNetBar.Controls.ReflectionLabel ReflectionLabel2;
		internal DevComponents.DotNetBar.ButtonItem ລາຍງານຂໍ້ມູນການຂາຍ;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem7;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem8;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem9;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem5;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem6;
		internal Label Label2;
		internal Label Label1;
		internal Timer Timer1;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem4;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem10;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem11;
		internal DevComponents.DotNetBar.ButtonX ButtonX7;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem12;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem13;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem14;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem15;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem16;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem17;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem18;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem19;
	}
	
}
