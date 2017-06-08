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

		public partial class frm_MakeReserve1 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_MakeReserve1_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX5.Click += new System.EventHandler(this.ButtonX5_Click);
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtTel2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
			this.Label9 = new System.Windows.Forms.Label();
			this.dtvReserve = new System.Windows.Forms.DateTimePicker();
			this.dtpDatecome = new System.Windows.Forms.DateTimePicker();
			this.dtpDatecome.ValueChanged += new System.EventHandler(this.dtpDatecome_ValueChanged);
			this.txtReservID = new System.Windows.Forms.TextBox();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
			this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
			this.Panel3 = new System.Windows.Forms.Panel();
			this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.ptbBoat = new System.Windows.Forms.PictureBox();
			this.txtHour = new System.Windows.Forms.TextBox();
			this.txtBoatName = new System.Windows.Forms.TextBox();
			this.txtBoatID = new System.Windows.Forms.TextBox();
			this.dgvReserve = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvService = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.btRefresh = new DevComponents.DotNetBar.ButtonX();
			this.btRefresh.Click += new System.EventHandler(this.ButtonX6_Click);
			this.btView = new DevComponents.DotNetBar.ButtonX();
			this.btView.Click += new System.EventHandler(this.btView_Click);
			this.tmService = new System.Windows.Forms.Timer(this.components);
			this.tmService.Tick += new System.EventHandler(this.tmService_Tick);
			this.tmReserve = new System.Windows.Forms.Timer(this.components);
			this.tmReserve.Tick += new System.EventHandler(this.tmReserve_Tick);
			this.ButtonX6 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX6.Click += new System.EventHandler(this.ButtonX6_Click_1);
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.Panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbBoat).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvService).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Panel1.Controls.Add(this.ButtonX5);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.txtID);
			this.Panel1.Controls.Add(this.txtName);
			this.Panel1.Controls.Add(this.txtLastName);
			this.Panel1.Controls.Add(this.txtTel);
			this.Panel1.Controls.Add(this.txtTel2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(36, 13);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(304, 258);
			this.Panel1.TabIndex = 0;
			//
			//ButtonX5
			//
			this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX5.Location = new System.Drawing.Point(109, 208);
			this.ButtonX5.Name = "ButtonX5";
			this.ButtonX5.Size = new System.Drawing.Size(167, 31);
			this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX5.TabIndex = 62;
			this.ButtonX5.Text = ".....";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(18, 175);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(95, 23);
			this.Label5.TabIndex = 59;
			this.Label5.Text = "ເບີໂທສຳຮອງ:";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(57, 135);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(51, 23);
			this.Label4.TabIndex = 58;
			this.Label4.Text = "ເບີໂທ:";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(27, 95);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(84, 23);
			this.Label3.TabIndex = 57;
			this.Label3.Text = "ນາມສະກຸນ:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(80, 55);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 23);
			this.Label2.TabIndex = 56;
			this.Label2.Text = "ຊື່:";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(109, 12);
			this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(167, 31);
			this.txtID.TabIndex = 55;
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(109, 52);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(167, 31);
			this.txtName.TabIndex = 50;
			//
			//txtLastName
			//
			this.txtLastName.Location = new System.Drawing.Point(109, 92);
			this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(167, 31);
			this.txtLastName.TabIndex = 51;
			//
			//txtTel
			//
			this.txtTel.Location = new System.Drawing.Point(109, 132);
			this.txtTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(167, 31);
			this.txtTel.TabIndex = 52;
			//
			//txtTel2
			//
			this.txtTel2.Location = new System.Drawing.Point(109, 172);
			this.txtTel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTel2.Name = "txtTel2";
			this.txtTel2.Size = new System.Drawing.Size(167, 31);
			this.txtTel2.TabIndex = 53;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(18, 15);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(94, 23);
			this.Label1.TabIndex = 54;
			this.Label1.Text = "ລະຫັດລູກຄ້າ:";
			//
			//Panel2
			//
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Panel2.Controls.Add(this.Label9);
			this.Panel2.Controls.Add(this.dtvReserve);
			this.Panel2.Controls.Add(this.dtpDatecome);
			this.Panel2.Controls.Add(this.txtReservID);
			this.Panel2.Controls.Add(this.txtTime);
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Location = new System.Drawing.Point(346, 13);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(283, 258);
			this.Panel2.TabIndex = 1;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.Color.Transparent;
			this.Label9.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.ForeColor = System.Drawing.Color.White;
			this.Label9.Location = new System.Drawing.Point(22, 61);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(74, 23);
			this.Label9.TabIndex = 57;
			this.Label9.Text = "ວັນທີຈອງ:";
			//
			//dtvReserve
			//
			this.dtvReserve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtvReserve.Location = new System.Drawing.Point(102, 55);
			this.dtvReserve.Name = "dtvReserve";
			this.dtvReserve.Size = new System.Drawing.Size(174, 31);
			this.dtvReserve.TabIndex = 56;
			//
			//dtpDatecome
			//
			this.dtpDatecome.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDatecome.Location = new System.Drawing.Point(103, 93);
			this.dtpDatecome.Name = "dtpDatecome";
			this.dtpDatecome.Size = new System.Drawing.Size(174, 31);
			this.dtpDatecome.TabIndex = 56;
			//
			//txtReservID
			//
			this.txtReservID.Location = new System.Drawing.Point(103, 13);
			this.txtReservID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtReservID.Name = "txtReservID";
			this.txtReservID.Size = new System.Drawing.Size(175, 31);
			this.txtReservID.TabIndex = 45;
			//
			//txtTime
			//
			this.txtTime.Location = new System.Drawing.Point(102, 135);
			this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(175, 31);
			this.txtTime.TabIndex = 46;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.White;
			this.Label7.Location = new System.Drawing.Point(22, 21);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(83, 23);
			this.Label7.TabIndex = 47;
			this.Label7.Text = "ລະຫັດຈອງ:";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.Color.White;
			this.Label6.Location = new System.Drawing.Point(20, 101);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(85, 23);
			this.Label6.TabIndex = 48;
			this.Label6.Text = "ວັນທີ່ຈະມາ:";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.Color.White;
			this.Label8.Location = new System.Drawing.Point(9, 140);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(98, 23);
			this.Label8.TabIndex = 51;
			this.Label8.Text = "ເວລາທີ່ຈະມາ:";
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(582, 397);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(79, 46);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.Symbol = "";
			this.ButtonX1.TabIndex = 2;
			this.ButtonX1.Text = "ບັກທຶກ";
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(667, 397);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(75, 46);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.Symbol = "";
			this.ButtonX2.TabIndex = 2;
			this.ButtonX2.Text = "ແກ້ໃຂ";
			//
			//ButtonX3
			//
			this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX3.Location = new System.Drawing.Point(748, 397);
			this.ButtonX3.Name = "ButtonX3";
			this.ButtonX3.Size = new System.Drawing.Size(75, 46);
			this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX3.Symbol = "";
			this.ButtonX3.TabIndex = 2;
			this.ButtonX3.Text = "ຍົກເລີກ";
			//
			//ButtonX4
			//
			this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX4.Location = new System.Drawing.Point(829, 397);
			this.ButtonX4.Name = "ButtonX4";
			this.ButtonX4.Size = new System.Drawing.Size(75, 46);
			this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX4.Symbol = "58901";
			this.ButtonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.ButtonX4.TabIndex = 2;
			this.ButtonX4.Text = "ລ້າງ";
			//
			//Panel3
			//
			this.Panel3.Controls.Add(this.FlowLayoutPanel1);
			this.Panel3.Location = new System.Drawing.Point(36, 277);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(868, 114);
			this.Panel3.TabIndex = 3;
			//
			//FlowLayoutPanel1
			//
			this.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.FlowLayoutPanel1.AutoScroll = true;
			this.FlowLayoutPanel1.Location = new System.Drawing.Point(-14, 0);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Size = new System.Drawing.Size(879, 114);
			this.FlowLayoutPanel1.TabIndex = 70;
			//
			//Panel4
			//
			this.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel4.Controls.Add(this.Label10);
			this.Panel4.Controls.Add(this.Label11);
			this.Panel4.Controls.Add(this.Label12);
			this.Panel4.Controls.Add(this.ptbBoat);
			this.Panel4.Controls.Add(this.txtHour);
			this.Panel4.Controls.Add(this.txtBoatName);
			this.Panel4.Controls.Add(this.txtBoatID);
			this.Panel4.Location = new System.Drawing.Point(640, 13);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(264, 258);
			this.Panel4.TabIndex = 4;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.Transparent;
			this.Label10.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10.ForeColor = System.Drawing.Color.White;
			this.Label10.Location = new System.Drawing.Point(2, 219);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(109, 23);
			this.Label10.TabIndex = 68;
			this.Label10.Text = "ຈໍານວນຊົ່ວໂມງ:";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.Color.Transparent;
			this.Label11.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11.ForeColor = System.Drawing.Color.White;
			this.Label11.Location = new System.Drawing.Point(58, 185);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(25, 23);
			this.Label11.TabIndex = 69;
			this.Label11.Text = "ຊື່:";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.BackColor = System.Drawing.Color.Transparent;
			this.Label12.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label12.ForeColor = System.Drawing.Color.White;
			this.Label12.Location = new System.Drawing.Point(26, 152);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(82, 23);
			this.Label12.TabIndex = 67;
			this.Label12.Text = "ລະຫັດເຮືອ:";
			//
			//ptbBoat
			//
			this.ptbBoat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ptbBoat.Location = new System.Drawing.Point(24, 3);
			this.ptbBoat.Name = "ptbBoat";
			this.ptbBoat.Size = new System.Drawing.Size(221, 143);
			this.ptbBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbBoat.TabIndex = 66;
			this.ptbBoat.TabStop = false;
			//
			//txtHour
			//
			this.txtHour.Location = new System.Drawing.Point(106, 219);
			this.txtHour.Name = "txtHour";
			this.txtHour.Size = new System.Drawing.Size(139, 31);
			this.txtHour.TabIndex = 64;
			//
			//txtBoatName
			//
			this.txtBoatName.Location = new System.Drawing.Point(106, 185);
			this.txtBoatName.Name = "txtBoatName";
			this.txtBoatName.Size = new System.Drawing.Size(139, 31);
			this.txtBoatName.TabIndex = 65;
			//
			//txtBoatID
			//
			this.txtBoatID.Location = new System.Drawing.Point(106, 152);
			this.txtBoatID.Name = "txtBoatID";
			this.txtBoatID.Size = new System.Drawing.Size(139, 31);
			this.txtBoatID.TabIndex = 63;
			//
			//dgvReserve
			//
			this.dgvReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserve.DefaultCellStyle = DataGridViewCellStyle1;
			this.dgvReserve.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvReserve.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(208)), System.Convert.ToInt32(System.Convert.ToByte(215)), System.Convert.ToInt32(System.Convert.ToByte(229)));
			this.dgvReserve.Location = new System.Drawing.Point(0, 10);
			this.dgvReserve.Name = "dgvReserve";
			this.dgvReserve.Size = new System.Drawing.Size(933, 10);
			this.dgvReserve.TabIndex = 76;
			//
			//dgvService
			//
			this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvService.DefaultCellStyle = DataGridViewCellStyle2;
			this.dgvService.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvService.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(208)), System.Convert.ToInt32(System.Convert.ToByte(215)), System.Convert.ToInt32(System.Convert.ToByte(229)));
			this.dgvService.Location = new System.Drawing.Point(0, 0);
			this.dgvService.Name = "dgvService";
			this.dgvService.Size = new System.Drawing.Size(933, 10);
			this.dgvService.TabIndex = 75;
			//
			//btRefresh
			//
			this.btRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btRefresh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btRefresh.Location = new System.Drawing.Point(59, 397);
			this.btRefresh.Name = "btRefresh";
			this.btRefresh.Size = new System.Drawing.Size(75, 23);
			this.btRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btRefresh.TabIndex = 77;
			this.btRefresh.Text = "refresh";
			//
			//btView
			//
			this.btView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btView.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btView.Location = new System.Drawing.Point(141, 397);
			this.btView.Name = "btView";
			this.btView.Size = new System.Drawing.Size(136, 23);
			this.btView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btView.TabIndex = 78;
			this.btView.Text = "View Service";
			//
			//tmService
			//
			this.tmService.Interval = 10;
			//
			//tmReserve
			//
			this.tmReserve.Interval = 10;
			//
			//ButtonX6
			//
			this.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX6.Location = new System.Drawing.Point(501, 396);
			this.ButtonX6.Name = "ButtonX6";
			this.ButtonX6.Size = new System.Drawing.Size(75, 46);
			this.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX6.Symbol = "";
			this.ButtonX6.TabIndex = 80;
			this.ButtonX6.Text = "ສໍາເລັດ";
			//
			//frm_MakeReserve1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(933, 479);
			this.Controls.Add(this.ButtonX6);
			this.Controls.Add(this.btView);
			this.Controls.Add(this.btRefresh);
			this.Controls.Add(this.dgvReserve);
			this.Controls.Add(this.dgvService);
			this.Controls.Add(this.Panel4);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.ButtonX4);
			this.Controls.Add(this.ButtonX3);
			this.Controls.Add(this.ButtonX2);
			this.Controls.Add(this.ButtonX1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_MakeReserve1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_MakeReserve1";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbBoat).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvService).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal Panel Panel1;
		internal Label Label5;
		internal Label Label4;
		internal Label Label3;
		internal Label Label2;
		internal TextBox txtID;
		internal TextBox txtName;
		internal TextBox txtLastName;
		internal TextBox txtTel;
		internal TextBox txtTel2;
		internal Label Label1;
		internal Panel Panel2;
		internal DateTimePicker dtpDatecome;
		internal TextBox txtReservID;
		internal TextBox txtTime;
		internal Label Label7;
		internal Label Label6;
		internal Label Label8;
		internal DevComponents.DotNetBar.ButtonX ButtonX5;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal DevComponents.DotNetBar.ButtonX ButtonX3;
		internal DevComponents.DotNetBar.ButtonX ButtonX4;
		internal Label Label9;
		internal DateTimePicker dtvReserve;
		internal Panel Panel3;
		internal FlowLayoutPanel FlowLayoutPanel1;
		internal Panel Panel4;
		internal Label Label10;
		internal Label Label11;
		internal Label Label12;
		internal PictureBox ptbBoat;
		internal TextBox txtHour;
		internal TextBox txtBoatName;
		internal TextBox txtBoatID;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserve;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvService;
		internal DevComponents.DotNetBar.ButtonX btRefresh;
		internal DevComponents.DotNetBar.ButtonX btView;
		internal Timer tmService;
		internal Timer tmReserve;
		internal DevComponents.DotNetBar.ButtonX ButtonX6;
	}
	
}
