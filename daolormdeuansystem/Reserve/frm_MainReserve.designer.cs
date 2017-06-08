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
	
	partial class frm_MainReserve : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_MainReserve_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainReserve));
			this.Panel1 = new System.Windows.Forms.Panel();
			this.dgvReserveFood = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvReserve = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvReserve.Click += new System.EventHandler(this.dgvReserve_Click);
			this.dgvReserveBoat = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.btReserveFood = new DevComponents.DotNetBar.ButtonX();
			this.btReserveFood.Click += new System.EventHandler(this.ButtonX3_Click);
			this.btBill = new DevComponents.DotNetBar.ButtonX();
			this.btBill.Click += new System.EventHandler(this.btBill_Click);
			this.btConfirm = new DevComponents.DotNetBar.ButtonX();
			this.btConfirm.Click += new System.EventHandler(this.ButtonX5_Click);
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbAll = new System.Windows.Forms.RadioButton();
			this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
			this.Label4 = new System.Windows.Forms.Label();
			this.cbCame = new System.Windows.Forms.RadioButton();
			this.cbCame.CheckedChanged += new System.EventHandler(this.cbCame_CheckedChanged);
			this.cbConfirm = new System.Windows.Forms.RadioButton();
			this.cbConfirm.CheckedChanged += new System.EventHandler(this.cbConfirm_CheckedChanged);
			this.cbYet = new System.Windows.Forms.RadioButton();
			this.cbYet.CheckedChanged += new System.EventHandler(this.cbYet_CheckedChanged);
			this.Label2 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvReserveFood).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserveBoat).BeginInit();
			this.FlowLayoutPanel1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.BackColor = System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.cbYet);
			this.Panel1.Controls.Add(this.cbAll);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.cbCame);
			this.Panel1.Controls.Add(this.cbConfirm);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.dgvReserveFood);
			this.Panel1.Controls.Add(this.dgvReserve);
			this.Panel1.Location = new System.Drawing.Point(12, 171);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(903, 454);
			this.Panel1.TabIndex = 0;
			//
			//dgvReserveFood
			//
			this.dgvReserveFood.AllowUserToAddRows = false;
			this.dgvReserveFood.AllowUserToDeleteRows = false;
			this.dgvReserveFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReserveFood.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserveFood.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvReserveFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserveFood.DefaultCellStyle = DataGridViewCellStyle2;
			this.dgvReserveFood.EnableHeadersVisualStyles = false;
			this.dgvReserveFood.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(208)), System.Convert.ToInt32(System.Convert.ToByte(215)), System.Convert.ToInt32(System.Convert.ToByte(229)));
			this.dgvReserveFood.Location = new System.Drawing.Point(6, 242);
			this.dgvReserveFood.Name = "dgvReserveFood";
			this.dgvReserveFood.ReadOnly = true;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserveFood.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
			this.dgvReserveFood.Size = new System.Drawing.Size(880, 198);
			this.dgvReserveFood.TabIndex = 2;
			//
			//dgvReserve
			//
			this.dgvReserve.AllowUserToAddRows = false;
			this.dgvReserve.AllowUserToDeleteRows = false;
			this.dgvReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReserve.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
			this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle5.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserve.DefaultCellStyle = DataGridViewCellStyle5;
			this.dgvReserve.EnableHeadersVisualStyles = false;
			this.dgvReserve.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(208)), System.Convert.ToInt32(System.Convert.ToByte(215)), System.Convert.ToInt32(System.Convert.ToByte(229)));
			this.dgvReserve.Location = new System.Drawing.Point(6, 42);
			this.dgvReserve.Name = "dgvReserve";
			this.dgvReserve.ReadOnly = true;
			DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle6.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserve.RowHeadersDefaultCellStyle = DataGridViewCellStyle6;
			this.dgvReserve.RowTemplate.Height = 60;
			this.dgvReserve.Size = new System.Drawing.Size(880, 149);
			this.dgvReserve.TabIndex = 0;
			//
			//dgvReserveBoat
			//
			this.dgvReserveBoat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReserveBoat.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle7.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserveBoat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
			this.dgvReserveBoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle8.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserveBoat.DefaultCellStyle = DataGridViewCellStyle8;
			this.dgvReserveBoat.EnableHeadersVisualStyles = false;
			this.dgvReserveBoat.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(208)), System.Convert.ToInt32(System.Convert.ToByte(215)), System.Convert.ToInt32(System.Convert.ToByte(229)));
			this.dgvReserveBoat.Location = new System.Drawing.Point(21, -1);
			this.dgvReserveBoat.Name = "dgvReserveBoat";
			DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle9.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserveBoat.RowHeadersDefaultCellStyle = DataGridViewCellStyle9;
			this.dgvReserveBoat.Size = new System.Drawing.Size(880, 10);
			this.dgvReserveBoat.TabIndex = 1;
			//
			//FlowLayoutPanel1
			//
			this.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black;
			this.FlowLayoutPanel1.Controls.Add(this.ButtonX2);
			this.FlowLayoutPanel1.Controls.Add(this.ButtonX1);
			this.FlowLayoutPanel1.Controls.Add(this.btReserveFood);
			this.FlowLayoutPanel1.Controls.Add(this.btBill);
			this.FlowLayoutPanel1.Controls.Add(this.btConfirm);
			this.FlowLayoutPanel1.Location = new System.Drawing.Point(12, 65);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Size = new System.Drawing.Size(903, 100);
			this.FlowLayoutPanel1.TabIndex = 1;
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(3, 3);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(23, 97);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.TabIndex = 1;
			this.ButtonX2.Text = "ຈອງເຮືອ";
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(32, 3);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(157, 97);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.Symbol = "";
			this.ButtonX1.SymbolSize = (float) (32.0F);
			this.ButtonX1.TabIndex = 0;
			this.ButtonX1.Text = "ເປີດຈອງ";
			//
			//btReserveFood
			//
			this.btReserveFood.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btReserveFood.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btReserveFood.Location = new System.Drawing.Point(195, 3);
			this.btReserveFood.Name = "btReserveFood";
			this.btReserveFood.Size = new System.Drawing.Size(157, 97);
			this.btReserveFood.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btReserveFood.Symbol = "58710";
			this.btReserveFood.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btReserveFood.SymbolSize = (float) (32.0F);
			this.btReserveFood.TabIndex = 2;
			this.btReserveFood.Text = "ຈອງອາຫານ";
			//
			//btBill
			//
			this.btBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btBill.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btBill.Location = new System.Drawing.Point(358, 3);
			this.btBill.Name = "btBill";
			this.btBill.Size = new System.Drawing.Size(157, 97);
			this.btBill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btBill.Symbol = "";
			this.btBill.SymbolSize = (float) (32.0F);
			this.btBill.TabIndex = 3;
			this.btBill.Text = "ພິມບິນ";
			//
			//btConfirm
			//
			this.btConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btConfirm.Location = new System.Drawing.Point(521, 3);
			this.btConfirm.Name = "btConfirm";
			this.btConfirm.Size = new System.Drawing.Size(157, 97);
			this.btConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btConfirm.Symbol = "58048";
			this.btConfirm.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.btConfirm.SymbolSize = (float) (32.0F);
			this.btConfirm.TabIndex = 4;
			this.btConfirm.Text = "ຢືນຢັນການຈອງ";
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.RefreshToolStripMenuItem});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(111, 26);
			//
			//RefreshToolStripMenuItem
			//
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.RefreshToolStripMenuItem.Text = "refresh";
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(771, 195);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(0, 35);
			this.Label3.TabIndex = 12;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(470, 197);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(275, 35);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "ລາຍການອາຫານສໍາລັບໃບບິນທີ:";
			//
			//cbAll
			//
			this.cbAll.AutoSize = true;
			this.cbAll.BackColor = System.Drawing.Color.Transparent;
			this.cbAll.ForeColor = System.Drawing.Color.White;
			this.cbAll.Location = new System.Drawing.Point(462, 5);
			this.cbAll.Name = "cbAll";
			this.cbAll.Size = new System.Drawing.Size(68, 27);
			this.cbAll.TabIndex = 20;
			this.cbAll.TabStop = true;
			this.cbAll.Text = "ທັງໝົດ";
			this.cbAll.UseVisualStyleBackColor = false;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(358, -2);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(98, 35);
			this.Label4.TabIndex = 19;
			this.Label4.Text = "ສະຖານະ:";
			//
			//cbCame
			//
			this.cbCame.AutoSize = true;
			this.cbCame.BackColor = System.Drawing.Color.Transparent;
			this.cbCame.ForeColor = System.Drawing.Color.White;
			this.cbCame.Location = new System.Drawing.Point(633, 5);
			this.cbCame.Name = "cbCame";
			this.cbCame.Size = new System.Drawing.Size(132, 27);
			this.cbCame.TabIndex = 18;
			this.cbCame.TabStop = true;
			this.cbCame.Text = "ມາໃຊ້ບໍລິການແລ້ວ";
			this.cbCame.UseVisualStyleBackColor = false;
			//
			//cbConfirm
			//
			this.cbConfirm.AutoSize = true;
			this.cbConfirm.BackColor = System.Drawing.Color.Transparent;
			this.cbConfirm.ForeColor = System.Drawing.Color.White;
			this.cbConfirm.Location = new System.Drawing.Point(536, 5);
			this.cbConfirm.Name = "cbConfirm";
			this.cbConfirm.Size = new System.Drawing.Size(91, 27);
			this.cbConfirm.TabIndex = 17;
			this.cbConfirm.TabStop = true;
			this.cbConfirm.Text = "ຢືນຢັນແລ້ວ";
			this.cbConfirm.UseVisualStyleBackColor = false;
			//
			//cbYet
			//
			this.cbYet.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbYet.AutoSize = true;
			this.cbYet.BackColor = System.Drawing.Color.Transparent;
			this.cbYet.ForeColor = System.Drawing.Color.White;
			this.cbYet.Location = new System.Drawing.Point(771, 5);
			this.cbYet.Name = "cbYet";
			this.cbYet.Size = new System.Drawing.Size(69, 27);
			this.cbYet.TabIndex = 21;
			this.cbYet.TabStop = true;
			this.cbYet.Text = "ຍັງບໍ່ມາ";
			this.cbYet.UseVisualStyleBackColor = false;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Hongkad Handwriting1", (float) (27.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(286, -5);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(354, 70);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "laj'9v'ginvc]tvksko";
			//
			//frm_MainReserve
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(927, 631);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.dgvReserveBoat);
			this.Controls.Add(this.FlowLayoutPanel1);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_MainReserve";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_MainReserve";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvReserveFood).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserveBoat).EndInit();
			this.FlowLayoutPanel1.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Panel Panel1;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserveFood;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserveBoat;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserve;
		internal FlowLayoutPanel FlowLayoutPanel1;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal DevComponents.DotNetBar.ButtonX btReserveFood;
		internal DevComponents.DotNetBar.ButtonX btBill;
		internal DevComponents.DotNetBar.ButtonX btConfirm;
		internal ContextMenuStrip ContextMenuStrip1;
		internal ToolStripMenuItem RefreshToolStripMenuItem;
		internal Label Label3;
		internal Label Label1;
		internal RadioButton cbYet;
		internal RadioButton cbAll;
		internal Label Label4;
		internal RadioButton cbCame;
		internal RadioButton cbConfirm;
		internal Label Label2;
	}
	
}
