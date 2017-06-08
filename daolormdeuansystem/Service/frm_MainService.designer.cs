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

		public partial class frm_MainService : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_MainService_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainService));
			this.lbSellID = new System.Windows.Forms.Panel();
			this.RadioButton5 = new System.Windows.Forms.RadioButton();
			this.RadioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
			this.Label4 = new System.Windows.Forms.Label();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.RadioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
			this.dgvOrderDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvOrderDetail.Click += new System.EventHandler(this.dgvOrderDetail_Click);
			this.dgvOrder = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvOrder.Click += new System.EventHandler(this.dgvOrder_Click);
			this.Panel4 = new System.Windows.Forms.Panel();
			this.btPaid = new DevComponents.DotNetBar.ButtonX();
			this.btPaid.Click += new System.EventHandler(this.ButtonX2_Click_1);
			this.btCalculate = new DevComponents.DotNetBar.ButtonX();
			this.btCalculate.Click += new System.EventHandler(this.ButtonX1_Click_2);
			this.btCheckBill = new DevComponents.DotNetBar.ButtonX();
			this.btCheckBill.Click += new System.EventHandler(this.btCheckBill_Click);
			this.btStart = new DevComponents.DotNetBar.ButtonX();
			this.btStart.Click += new System.EventHandler(this.btStart_Click);
			this.btOrder = new DevComponents.DotNetBar.ButtonX();
			this.btOrder.Click += new System.EventHandler(this.ButtonX2_Click);
			this.btChooseBoat = new DevComponents.DotNetBar.ButtonX();
			this.btChooseBoat.Click += new System.EventHandler(this.ButtonX1_Click_1);
			this.ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem2.Click += new System.EventHandler(this.ButtonItem2_Click);
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
			this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
			this.ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.ButtonItem1.Click += new System.EventHandler(this.ButtonItem1_Click);
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ເມນToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnService = new System.Windows.Forms.ToolStripMenuItem();
			this.ໃໝToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ໃໝToolStripMenuItem.Click += new System.EventHandler(this.ໃໝToolStripMenuItem_Click);
			this.ເລອກຈາກການຈອງToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ເລອກຈາກການຈອງToolStripMenuItem.Click += new System.EventHandler(this.ເລອກຈາກການຈອງToolStripMenuItem_Click);
			this.mnorder = new System.Windows.Forms.ToolStripMenuItem();
			this.mnorder.Click += new System.EventHandler(this.ສງອາຫານToolStripMenuItem_Click);
			this.mnStart = new System.Windows.Forms.ToolStripMenuItem();
			this.mnStart.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
			this.mnCal = new System.Windows.Forms.ToolStripMenuItem();
			this.mnCal.Click += new System.EventHandler(this.ຄດໄລຄາລອງເຮອToolStripMenuItem_Click);
			this.mnPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.mnPrint.Click += new System.EventHandler(this.ພມບນToolStripMenuItem_Click);
			this.mnPaid = new System.Windows.Forms.ToolStripMenuItem();
			this.mnPaid.Click += new System.EventHandler(this.ໄດຮບເງນແລວToolStripMenuItem_Click);
			this.ອອຫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ອອຫToolStripMenuItem.Click += new System.EventHandler(this.ອອຫToolStripMenuItem_Click);
			this.Label5 = new System.Windows.Forms.Label();
			this.lbSellID.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvOrderDetail).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvOrder).BeginInit();
			this.Panel4.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//lbSellID
			//
			this.lbSellID.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.lbSellID.BackColor = System.Drawing.SystemColors.ControlDark;
			this.lbSellID.Controls.Add(this.RadioButton5);
			this.lbSellID.Controls.Add(this.Label4);
			this.lbSellID.Controls.Add(this.RadioButton4);
			this.lbSellID.Controls.Add(this.RadioButton3);
			this.lbSellID.Controls.Add(this.RadioButton2);
			this.lbSellID.Controls.Add(this.RadioButton1);
			this.lbSellID.Controls.Add(this.Label3);
			this.lbSellID.Controls.Add(this.Label1);
			this.lbSellID.Controls.Add(this.Label2);
			this.lbSellID.Controls.Add(this.txtTotal);
			this.lbSellID.Controls.Add(this.dgvOrderDetail);
			this.lbSellID.Controls.Add(this.dgvOrder);
			this.lbSellID.Location = new System.Drawing.Point(22, 239);
			this.lbSellID.Name = "lbSellID";
			this.lbSellID.Size = new System.Drawing.Size(1027, 472);
			this.lbSellID.TabIndex = 2;
			//
			//RadioButton5
			//
			this.RadioButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton5.AutoSize = true;
			this.RadioButton5.BackColor = System.Drawing.Color.Transparent;
			this.RadioButton5.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton5.Location = new System.Drawing.Point(559, 9);
			this.RadioButton5.Name = "RadioButton5";
			this.RadioButton5.Size = new System.Drawing.Size(72, 27);
			this.RadioButton5.TabIndex = 16;
			this.RadioButton5.TabStop = true;
			this.RadioButton5.Text = "ທັງໝົດ";
			this.RadioButton5.UseVisualStyleBackColor = false;
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(450, 1);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(98, 35);
			this.Label4.TabIndex = 15;
			this.Label4.Text = "ສະຖານະ:";
			//
			//RadioButton4
			//
			this.RadioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.BackColor = System.Drawing.Color.Transparent;
			this.RadioButton4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton4.Location = new System.Drawing.Point(731, 8);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new System.Drawing.Size(95, 27);
			this.RadioButton4.TabIndex = 14;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "ອອກເຮືອຢູ່";
			this.RadioButton4.UseVisualStyleBackColor = false;
			//
			//RadioButton3
			//
			this.RadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.BackColor = System.Drawing.Color.Transparent;
			this.RadioButton3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton3.Location = new System.Drawing.Point(646, 8);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(87, 27);
			this.RadioButton3.TabIndex = 13;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "ຕຽມການ";
			this.RadioButton3.UseVisualStyleBackColor = false;
			//
			//RadioButton2
			//
			this.RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.BackColor = System.Drawing.Color.Transparent;
			this.RadioButton2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton2.Location = new System.Drawing.Point(924, 8);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(82, 27);
			this.RadioButton2.TabIndex = 12;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "ຍັງບໍ່ຈ່າຍ";
			this.RadioButton2.UseVisualStyleBackColor = false;
			//
			//RadioButton1
			//
			this.RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.BackColor = System.Drawing.Color.Transparent;
			this.RadioButton1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton1.Location = new System.Drawing.Point(825, 8);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(85, 27);
			this.RadioButton1.TabIndex = 11;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "ຈ່າຍແລ້ວ";
			this.RadioButton1.UseVisualStyleBackColor = false;
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(321, 196);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(0, 35);
			this.Label3.TabIndex = 10;
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(20, 196);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(275, 35);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "ລາຍການອາຫານສໍາລັບໃບບິນທີ:";
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(450, 417);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(307, 35);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "ລວມເງິນຄ່າອາຫານ ແລະ ເຄື່່ອງດື່ມ:";
			//
			//txtTotal
			//
			this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTotal.BackColor = System.Drawing.Color.Black;
			this.txtTotal.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtTotal.ForeColor = System.Drawing.Color.Lime;
			this.txtTotal.Location = new System.Drawing.Point(763, 414);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(238, 43);
			this.txtTotal.TabIndex = 7;
			//
			//dgvOrderDetail
			//
			this.dgvOrderDetail.AllowUserToAddRows = false;
			this.dgvOrderDetail.AllowUserToDeleteRows = false;
			this.dgvOrderDetail.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.White;
			this.dgvOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvOrderDetail.ColumnHeadersHeight = 40;
			this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderDetail.DefaultCellStyle = DataGridViewCellStyle2;
			this.dgvOrderDetail.EnableHeadersVisualStyles = false;
			this.dgvOrderDetail.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvOrderDetail.Location = new System.Drawing.Point(23, 234);
			this.dgvOrderDetail.Name = "dgvOrderDetail";
			this.dgvOrderDetail.ReadOnly = true;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderDetail.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
			this.dgvOrderDetail.Size = new System.Drawing.Size(975, 174);
			this.dgvOrderDetail.TabIndex = 2;
			//
			//dgvOrder
			//
			this.dgvOrder.AllowUserToAddRows = false;
			this.dgvOrder.AllowUserToDeleteRows = false;
			DataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.dgvOrder.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4;
			this.dgvOrder.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
			this.dgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle5.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
			this.dgvOrder.ColumnHeadersHeight = 40;
			this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle6.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrder.DefaultCellStyle = DataGridViewCellStyle6;
			this.dgvOrder.EnableHeadersVisualStyles = false;
			this.dgvOrder.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvOrder.Location = new System.Drawing.Point(26, 41);
			this.dgvOrder.Name = "dgvOrder";
			this.dgvOrder.ReadOnly = true;
			DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle7.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrder.RowHeadersDefaultCellStyle = DataGridViewCellStyle7;
			this.dgvOrder.RowTemplate.Height = 60;
			this.dgvOrder.Size = new System.Drawing.Size(975, 153);
			this.dgvOrder.TabIndex = 3;
			//
			//Panel4
			//
			this.Panel4.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.Panel4.Controls.Add(this.btPaid);
			this.Panel4.Controls.Add(this.btCalculate);
			this.Panel4.Controls.Add(this.btCheckBill);
			this.Panel4.Controls.Add(this.btStart);
			this.Panel4.Controls.Add(this.btOrder);
			this.Panel4.Controls.Add(this.btChooseBoat);
			this.Panel4.Location = new System.Drawing.Point(18, 129);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(1031, 107);
			this.Panel4.TabIndex = 3;
			//
			//btPaid
			//
			this.btPaid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btPaid.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btPaid.Location = new System.Drawing.Point(836, 17);
			this.btPaid.Name = "btPaid";
			this.btPaid.Size = new System.Drawing.Size(166, 71);
			this.btPaid.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btPaid.Symbol = "";
			this.btPaid.SymbolSize = (float) (32.0F);
			this.btPaid.TabIndex = 8;
			this.btPaid.Text = "ໄດ້ຮັບເງິນແລ້ວ";
			//
			//btCalculate
			//
			this.btCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btCalculate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btCalculate.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btCalculate.Location = new System.Drawing.Point(521, 17);
			this.btCalculate.Name = "btCalculate";
			this.btCalculate.Size = new System.Drawing.Size(150, 71);
			this.btCalculate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btCalculate.Symbol = "57371";
			this.btCalculate.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btCalculate.SymbolSize = (float) (30.0F);
			this.btCalculate.TabIndex = 0;
			this.btCalculate.Text = "ຄິດໄລລາຄາລ່ອງເຮືອ";
			//
			//btCheckBill
			//
			this.btCheckBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btCheckBill.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btCheckBill.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btCheckBill.Location = new System.Drawing.Point(680, 17);
			this.btCheckBill.Name = "btCheckBill";
			this.btCheckBill.Size = new System.Drawing.Size(147, 71);
			this.btCheckBill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btCheckBill.Symbol = "";
			this.btCheckBill.SymbolSize = (float) (32.0F);
			this.btCheckBill.TabIndex = 7;
			this.btCheckBill.Text = "ພິມບິນ";
			//
			//btStart
			//
			this.btStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btStart.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btStart.Location = new System.Drawing.Point(365, 17);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(147, 71);
			this.btStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btStart.Symbol = "58674";
			this.btStart.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btStart.SymbolSize = (float) (32.0F);
			this.btStart.TabIndex = 6;
			this.btStart.Text = "ເລີ່ມອອກເຮືອ";
			//
			//btOrder
			//
			this.btOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btOrder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btOrder.Location = new System.Drawing.Point(184, 17);
			this.btOrder.Name = "btOrder";
			this.btOrder.Size = new System.Drawing.Size(172, 71);
			this.btOrder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btOrder.Symbol = "58721";
			this.btOrder.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btOrder.SymbolSize = (float) (32.0F);
			this.btOrder.TabIndex = 5;
			this.btOrder.Text = "ສັ່ງອາຫານ";
			//
			//btChooseBoat
			//
			this.btChooseBoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btChooseBoat.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btChooseBoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btChooseBoat.Location = new System.Drawing.Point(28, 17);
			this.btChooseBoat.Name = "btChooseBoat";
			this.btChooseBoat.Size = new System.Drawing.Size(147, 71);
			this.btChooseBoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btChooseBoat.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {this.ButtonItem2});
			this.btChooseBoat.Symbol = "";
			this.btChooseBoat.SymbolSize = (float) (32.0F);
			this.btChooseBoat.TabIndex = 4;
			this.btChooseBoat.Text = "ເລືອກເຮືອ";
			//
			//ButtonItem2
			//
			this.ButtonItem2.GlobalItem = false;
			this.ButtonItem2.Name = "ButtonItem2";
			this.ButtonItem2.Symbol = "";
			this.ButtonItem2.Text = "ເລືອກຈາກຂໍ້ມູນການຈອງ";
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.RefreshToolStripMenuItem});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(114, 26);
			//
			//RefreshToolStripMenuItem
			//
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.RefreshToolStripMenuItem.Text = "Refresh";
			//
			//ButtonItem1
			//
			this.ButtonItem1.GlobalItem = false;
			this.ButtonItem1.Name = "ButtonItem1";
			this.ButtonItem1.Symbol = "";
			this.ButtonItem1.Text = "ເລືອກຈາກຂໍ້ມູນການຈອງ";
			//
			//MenuStrip1
			//
			this.MenuStrip1.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ເມນToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(1074, 35);
			this.MenuStrip1.TabIndex = 4;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//ເມນToolStripMenuItem
			//
			this.ເມນToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnService, this.mnorder, this.mnStart, this.mnCal, this.mnPrint, this.mnPaid, this.ອອຫToolStripMenuItem});
			this.ເມນToolStripMenuItem.Name = "ເມນToolStripMenuItem";
			this.ເມນToolStripMenuItem.Size = new System.Drawing.Size(54, 31);
			this.ເມນToolStripMenuItem.Text = "ເມນູ";
			//
			//mnService
			//
			this.mnService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ໃໝToolStripMenuItem, this.ເລອກຈາກການຈອງToolStripMenuItem});
			this.mnService.Name = "mnService";
			this.mnService.Size = new System.Drawing.Size(277, 32);
			this.mnService.Text = "ບໍລິການ";
			//
			//ໃໝToolStripMenuItem
			//
			this.ໃໝToolStripMenuItem.Name = "ໃໝToolStripMenuItem";
			this.ໃໝToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N);
			this.ໃໝToolStripMenuItem.Size = new System.Drawing.Size(342, 32);
			this.ໃໝToolStripMenuItem.Text = "ໃໝ່";
			//
			//ເລອກຈາກການຈອງToolStripMenuItem
			//
			this.ເລອກຈາກການຈອງToolStripMenuItem.Name = "ເລອກຈາກການຈອງToolStripMenuItem";
			this.ເລອກຈາກການຈອງToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
				| System.Windows.Forms.Keys.N);
			this.ເລອກຈາກການຈອງToolStripMenuItem.Size = new System.Drawing.Size(342, 32);
			this.ເລອກຈາກການຈອງToolStripMenuItem.Text = "ເລືອກຈາກການຈອງ";
			//
			//mnorder
			//
			this.mnorder.Name = "mnorder";
			this.mnorder.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F);
			this.mnorder.Size = new System.Drawing.Size(277, 32);
			this.mnorder.Text = "ສັ່ງອາຫານ";
			//
			//mnStart
			//
			this.mnStart.Name = "mnStart";
			this.mnStart.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S);
			this.mnStart.Size = new System.Drawing.Size(277, 32);
			this.mnStart.Text = "Start";
			//
			//mnCal
			//
			this.mnCal.Name = "mnCal";
			this.mnCal.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C);
			this.mnCal.Size = new System.Drawing.Size(277, 32);
			this.mnCal.Text = "ຄິດໄລ່ຄ່າລ່ອງເຮືອ";
			//
			//mnPrint
			//
			this.mnPrint.Name = "mnPrint";
			this.mnPrint.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P);
			this.mnPrint.Size = new System.Drawing.Size(277, 32);
			this.mnPrint.Text = "ພິມບິນ";
			//
			//mnPaid
			//
			this.mnPaid.Name = "mnPaid";
			this.mnPaid.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E);
			this.mnPaid.Size = new System.Drawing.Size(277, 32);
			this.mnPaid.Text = "ໄດ້ຮັບເງິນແລ້ວ";
			//
			//ອອຫToolStripMenuItem
			//
			this.ອອຫToolStripMenuItem.Name = "ອອຫToolStripMenuItem";
			this.ອອຫToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys) (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X);
			this.ອອຫToolStripMenuItem.Size = new System.Drawing.Size(277, 32);
			this.ອອຫToolStripMenuItem.Text = "ອອກ";
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Font = new System.Drawing.Font("Hongkad Handwriting1", (float) (27.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(465, 42);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(145, 70);
			this.Label5.TabIndex = 5;
			this.Label5.Text = "[=]ydko";
			//
			//frm_MainService
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1074, 716);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.MenuStrip1);
			this.Controls.Add(this.Panel4);
			this.Controls.Add(this.lbSellID);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MainMenuStrip = this.MenuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_MainService";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_MainService";
			this.lbSellID.ResumeLayout(false);
			this.lbSellID.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvOrderDetail).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvOrder).EndInit();
			this.Panel4.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Panel lbSellID;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvOrderDetail;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvOrder;
		internal Panel Panel4;
		internal Label Label2;
		internal TextBox txtTotal;
		internal ContextMenuStrip ContextMenuStrip1;
		internal ToolStripMenuItem RefreshToolStripMenuItem;
		internal DevComponents.DotNetBar.ButtonX btPaid;
		internal DevComponents.DotNetBar.ButtonX btCalculate;
		internal DevComponents.DotNetBar.ButtonX btCheckBill;
		internal DevComponents.DotNetBar.ButtonX btStart;
		internal DevComponents.DotNetBar.ButtonX btOrder;
		internal DevComponents.DotNetBar.ButtonX btChooseBoat;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem1;
		internal DevComponents.DotNetBar.ButtonItem ButtonItem2;
		internal MenuStrip MenuStrip1;
		internal ToolStripMenuItem ເມນToolStripMenuItem;
		internal ToolStripMenuItem mnService;
		internal ToolStripMenuItem ໃໝToolStripMenuItem;
		internal ToolStripMenuItem ເລອກຈາກການຈອງToolStripMenuItem;
		internal ToolStripMenuItem mnorder;
		internal ToolStripMenuItem mnStart;
		internal ToolStripMenuItem mnCal;
		internal ToolStripMenuItem mnPrint;
		internal ToolStripMenuItem mnPaid;
		internal ToolStripMenuItem ອອຫToolStripMenuItem;
		internal Label Label3;
		internal Label Label1;
		internal RadioButton RadioButton4;
		internal RadioButton RadioButton3;
		internal RadioButton RadioButton2;
		internal RadioButton RadioButton1;
		internal Label Label4;
		internal RadioButton RadioButton5;
		internal Label Label5;
	}
	
}
