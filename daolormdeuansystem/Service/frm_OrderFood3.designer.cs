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
	
	partial class frm_OrderFood3 : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Label9 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frm_OrderFood3_Load);
			this.Label8 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX5.Click += new System.EventHandler(this.ButtonX5_Click);
			this.btDel = new DevComponents.DotNetBar.ButtonX();
			this.btDel.Click += new System.EventHandler(this.ButtonX4_Click);
			this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
			this.dgvOrderFood = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label1 = new System.Windows.Forms.Label();
			this.rbGroup = new System.Windows.Forms.RadioButton();
			this.rbname1 = new System.Windows.Forms.RadioButton();
			this.rbCategory = new System.Windows.Forms.RadioButton();
			this.rbID = new System.Windows.Forms.RadioButton();
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvFood = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvFood.Click += new System.EventHandler(this.dgvFood_Click);
			this.Panel3 = new System.Windows.Forms.Panel();
			this.txtamount = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Label10 = new System.Windows.Forms.Label();
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.txtprice = new System.Windows.Forms.TextBox();
			this.txtname = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.ptbfood = new System.Windows.Forms.PictureBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvOrderFood).BeginInit();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvFood).BeginInit();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbfood).BeginInit();
			this.SuspendLayout();
			//
			//Label9
			//
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label9.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label9.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.ForeColor = System.Drawing.Color.White;
			this.Label9.Location = new System.Drawing.Point(18, 17);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(359, 23);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "ເມນູອາຫານແລະເຄື່ອງດື່ມ";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label8
			//
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label8.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label8.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.Color.White;
			this.Label8.Location = new System.Drawing.Point(392, 17);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(237, 23);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "ຂໍ້ມູນ";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Panel2
			//
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel2.Controls.Add(this.ButtonX5);
			this.Panel2.Controls.Add(this.btDel);
			this.Panel2.Controls.Add(this.ButtonX3);
			this.Panel2.Controls.Add(this.dgvOrderFood);
			this.Panel2.Location = new System.Drawing.Point(642, 42);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(392, 409);
			this.Panel2.TabIndex = 13;
			//
			//ButtonX5
			//
			this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX5.Location = new System.Drawing.Point(244, 346);
			this.ButtonX5.Name = "ButtonX5";
			this.ButtonX5.Size = new System.Drawing.Size(83, 47);
			this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX5.TabIndex = 17;
			this.ButtonX5.Text = "ສໍາເລັດ";
			//
			//btDel
			//
			this.btDel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btDel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btDel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btDel.Location = new System.Drawing.Point(155, 346);
			this.btDel.Name = "btDel";
			this.btDel.Size = new System.Drawing.Size(83, 47);
			this.btDel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btDel.TabIndex = 16;
			this.btDel.Text = "ຍົກເລີກ";
			//
			//ButtonX3
			//
			this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX3.Location = new System.Drawing.Point(62, 346);
			this.ButtonX3.Name = "ButtonX3";
			this.ButtonX3.Size = new System.Drawing.Size(83, 47);
			this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX3.TabIndex = 15;
			this.ButtonX3.Text = "ແກ້ໃຂ";
			//
			//dgvOrderFood
			//
			this.dgvOrderFood.AllowUserToAddRows = false;
			this.dgvOrderFood.AllowUserToDeleteRows = false;
			this.dgvOrderFood.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvOrderFood.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle7.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderFood.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
			this.dgvOrderFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle8.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderFood.DefaultCellStyle = DataGridViewCellStyle8;
			this.dgvOrderFood.EnableHeadersVisualStyles = false;
			this.dgvOrderFood.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvOrderFood.Location = new System.Drawing.Point(21, 20);
			this.dgvOrderFood.Name = "dgvOrderFood";
			this.dgvOrderFood.ReadOnly = true;
			DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle9.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvOrderFood.RowHeadersDefaultCellStyle = DataGridViewCellStyle9;
			this.dgvOrderFood.Size = new System.Drawing.Size(353, 297);
			this.dgvOrderFood.TabIndex = 0;
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.rbGroup);
			this.Panel1.Controls.Add(this.rbname1);
			this.Panel1.Controls.Add(this.rbCategory);
			this.Panel1.Controls.Add(this.rbID);
			this.Panel1.Controls.Add(this.ButtonX1);
			this.Panel1.Controls.Add(this.txtSearch);
			this.Panel1.Controls.Add(this.dgvFood);
			this.Panel1.Location = new System.Drawing.Point(18, 42);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(359, 409);
			this.Panel1.TabIndex = 12;
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(14, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(82, 23);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "ຄົ້ນຫາໂດຍ:";
			//
			//rbGroup
			//
			this.rbGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rbGroup.AutoSize = true;
			this.rbGroup.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.rbGroup.ForeColor = System.Drawing.Color.White;
			this.rbGroup.Location = new System.Drawing.Point(218, 33);
			this.rbGroup.Name = "rbGroup";
			this.rbGroup.Size = new System.Drawing.Size(51, 27);
			this.rbGroup.TabIndex = 4;
			this.rbGroup.TabStop = true;
			this.rbGroup.Text = "ກຸ່ມ";
			this.rbGroup.UseVisualStyleBackColor = true;
			//
			//rbname1
			//
			this.rbname1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rbname1.AutoSize = true;
			this.rbname1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.rbname1.ForeColor = System.Drawing.Color.White;
			this.rbname1.Location = new System.Drawing.Point(104, 33);
			this.rbname1.Name = "rbname1";
			this.rbname1.Size = new System.Drawing.Size(38, 27);
			this.rbname1.TabIndex = 5;
			this.rbname1.TabStop = true;
			this.rbname1.Text = "ຊື່";
			this.rbname1.UseVisualStyleBackColor = true;
			//
			//rbCategory
			//
			this.rbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rbCategory.AutoSize = true;
			this.rbCategory.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.rbCategory.ForeColor = System.Drawing.Color.White;
			this.rbCategory.Location = new System.Drawing.Point(273, 33);
			this.rbCategory.Name = "rbCategory";
			this.rbCategory.Size = new System.Drawing.Size(74, 27);
			this.rbCategory.TabIndex = 6;
			this.rbCategory.TabStop = true;
			this.rbCategory.Text = "ປະເພດ";
			this.rbCategory.UseVisualStyleBackColor = true;
			//
			//rbID
			//
			this.rbID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rbID.AutoSize = true;
			this.rbID.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.rbID.ForeColor = System.Drawing.Color.White;
			this.rbID.Location = new System.Drawing.Point(147, 33);
			this.rbID.Name = "rbID";
			this.rbID.Size = new System.Drawing.Size(69, 27);
			this.rbID.TabIndex = 7;
			this.rbID.TabStop = true;
			this.rbID.Text = "ລະຫັດ";
			this.rbID.UseVisualStyleBackColor = true;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(206, 66);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(132, 31);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 2;
			this.ButtonX1.Text = "ຄົ້ນຫາ";
			//
			//txtSearch
			//
			this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSearch.Location = new System.Drawing.Point(14, 66);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(185, 31);
			this.txtSearch.TabIndex = 1;
			//
			//dgvFood
			//
			this.dgvFood.AllowUserToAddRows = false;
			this.dgvFood.AllowUserToDeleteRows = false;
			this.dgvFood.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvFood.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle10.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFood.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10;
			this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle11.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFood.DefaultCellStyle = DataGridViewCellStyle11;
			this.dgvFood.EnableHeadersVisualStyles = false;
			this.dgvFood.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvFood.Location = new System.Drawing.Point(14, 106);
			this.dgvFood.Name = "dgvFood";
			this.dgvFood.ReadOnly = true;
			DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle12.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFood.RowHeadersDefaultCellStyle = DataGridViewCellStyle12;
			this.dgvFood.Size = new System.Drawing.Size(324, 287);
			this.dgvFood.TabIndex = 0;
			//
			//Panel3
			//
			this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel3.Controls.Add(this.txtamount);
			this.Panel3.Controls.Add(this.Label10);
			this.Panel3.Controls.Add(this.ButtonX2);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.txtprice);
			this.Panel3.Controls.Add(this.txtname);
			this.Panel3.Controls.Add(this.Label3);
			this.Panel3.Controls.Add(this.txtid);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Controls.Add(this.ptbfood);
			this.Panel3.Location = new System.Drawing.Point(393, 42);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(236, 408);
			this.Panel3.TabIndex = 14;
			//
			//txtamount
			//
			this.txtamount.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtamount.Border.Class = "TextBoxBorder";
			this.txtamount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtamount.DisabledBackColor = System.Drawing.Color.White;
			this.txtamount.ForeColor = System.Drawing.Color.Black;
			this.txtamount.Location = new System.Drawing.Point(95, 303);
			this.txtamount.Name = "txtamount";
			this.txtamount.PreventEnterBeep = true;
			this.txtamount.Size = new System.Drawing.Size(114, 31);
			this.txtamount.TabIndex = 17;
			this.txtamount.WatermarkText = "ປ້ອນຈໍານວນ";
			//
			//Label10
			//
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10.ForeColor = System.Drawing.Color.White;
			this.Label10.Location = new System.Drawing.Point(27, 305);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(62, 23);
			this.Label10.TabIndex = 16;
			this.Label10.Text = "ຈໍານວນ:";
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(11, 346);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(215, 47);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.TabIndex = 14;
			this.ButtonX2.Text = "ເລືອກ";
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(40, 268);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(49, 23);
			this.Label4.TabIndex = 13;
			this.Label4.Text = "ລາຄາ:";
			//
			//txtprice
			//
			this.txtprice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtprice.Location = new System.Drawing.Point(95, 265);
			this.txtprice.Name = "txtprice";
			this.txtprice.Size = new System.Drawing.Size(114, 31);
			this.txtprice.TabIndex = 12;
			//
			//txtname
			//
			this.txtname.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtname.Enabled = false;
			this.txtname.Location = new System.Drawing.Point(95, 228);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(114, 31);
			this.txtname.TabIndex = 10;
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(64, 231);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 23);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "ຊື່:";
			//
			//txtid
			//
			this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtid.Enabled = false;
			this.txtid.Location = new System.Drawing.Point(95, 191);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(114, 31);
			this.txtid.TabIndex = 9;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(33, 191);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 23);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "ລະຫັດ:";
			//
			//ptbfood
			//
			this.ptbfood.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ptbfood.Location = new System.Drawing.Point(4, 4);
			this.ptbfood.Name = "ptbfood";
			this.ptbfood.Size = new System.Drawing.Size(229, 166);
			this.ptbfood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbfood.TabIndex = 0;
			this.ptbfood.TabStop = false;
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(642, 17);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(283, 23);
			this.Label5.TabIndex = 15;
			this.Label5.Text = "ລາຍການທີ່ເລືອກ";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//frm_OrderFood3
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1046, 494);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Label5);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_OrderFood3";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_OrderFood3";
			this.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvOrderFood).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvFood).EndInit();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbfood).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal Label Label9;
		internal Label Label8;
		internal Panel Panel2;
		internal DevComponents.DotNetBar.ButtonX ButtonX5;
		internal DevComponents.DotNetBar.ButtonX btDel;
		internal DevComponents.DotNetBar.ButtonX ButtonX3;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvOrderFood;
		internal Panel Panel1;
		internal Label Label1;
		internal RadioButton rbGroup;
		internal RadioButton rbname1;
		internal RadioButton rbCategory;
		internal RadioButton rbID;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal TextBox txtSearch;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvFood;
		internal Panel Panel3;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal Label Label4;
		internal TextBox txtprice;
		internal TextBox txtname;
		internal Label Label3;
		internal TextBox txtid;
		internal Label Label2;
		internal PictureBox ptbfood;
		internal Label Label5;
		internal Label Label10;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtamount;
	}
	
}
