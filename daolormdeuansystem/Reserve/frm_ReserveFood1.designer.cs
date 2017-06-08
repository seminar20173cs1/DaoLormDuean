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
	
	partial class frm_ReserveFood1 : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Panel1 = new System.Windows.Forms.Panel();
			base.Load += new System.EventHandler(frm_ReserveFood1_Load);
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.pgv = new System.Windows.Forms.PictureBox();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
			this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.dgvReserveFood = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgv_Menu = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgv_Menu.Click += new System.EventHandler(this.dgv_Menu_Click);
			this.Label5 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.pgv).BeginInit();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvReserveFood).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgv_Menu).BeginInit();
			this.SuspendLayout();
			//
			//Panel1
			//
			this.Panel1.BackColor = System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.ButtonX1);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.txtPrice);
			this.Panel1.Controls.Add(this.txtAmount);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.txtName);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.txtID);
			this.Panel1.Controls.Add(this.pgv);
			this.Panel1.Controls.Add(this.Panel3);
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Location = new System.Drawing.Point(12, 12);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(831, 486);
			this.Panel1.TabIndex = 0;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(292, 399);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(217, 58);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.Symbol = "58721";
			this.ButtonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.ButtonX1.TabIndex = 5;
			this.ButtonX1.Text = "ຈອງ";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(322, 327);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(49, 23);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "ລາຄາ:";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(310, 364);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(62, 23);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "ຈໍານວນ:";
			//
			//txtPrice
			//
			this.txtPrice.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtPrice.Border.Class = "TextBoxBorder";
			this.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtPrice.DisabledBackColor = System.Drawing.Color.White;
			this.txtPrice.ForeColor = System.Drawing.Color.Black;
			this.txtPrice.Location = new System.Drawing.Point(375, 325);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.PreventEnterBeep = true;
			this.txtPrice.Size = new System.Drawing.Size(134, 31);
			this.txtPrice.TabIndex = 3;
			//
			//txtAmount
			//
			this.txtAmount.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtAmount.Border.Class = "TextBoxBorder";
			this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtAmount.DisabledBackColor = System.Drawing.Color.White;
			this.txtAmount.ForeColor = System.Drawing.Color.Black;
			this.txtAmount.Location = new System.Drawing.Point(375, 362);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.PreventEnterBeep = true;
			this.txtAmount.Size = new System.Drawing.Size(134, 31);
			this.txtAmount.TabIndex = 3;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(343, 292);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 23);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "ຊື່:";
			//
			//txtName
			//
			this.txtName.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtName.Border.Class = "TextBoxBorder";
			this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtName.DisabledBackColor = System.Drawing.Color.White;
			this.txtName.ForeColor = System.Drawing.Color.Black;
			this.txtName.Location = new System.Drawing.Point(375, 290);
			this.txtName.Name = "txtName";
			this.txtName.PreventEnterBeep = true;
			this.txtName.Size = new System.Drawing.Size(134, 31);
			this.txtName.TabIndex = 3;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(315, 254);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(56, 23);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "ລະຫັດ:";
			//
			//txtID
			//
			this.txtID.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtID.Border.Class = "TextBoxBorder";
			this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtID.DisabledBackColor = System.Drawing.Color.White;
			this.txtID.ForeColor = System.Drawing.Color.Black;
			this.txtID.Location = new System.Drawing.Point(375, 252);
			this.txtID.Name = "txtID";
			this.txtID.PreventEnterBeep = true;
			this.txtID.Size = new System.Drawing.Size(134, 31);
			this.txtID.TabIndex = 3;
			//
			//pgv
			//
			this.pgv.Location = new System.Drawing.Point(292, 90);
			this.pgv.Name = "pgv";
			this.pgv.Size = new System.Drawing.Size(217, 155);
			this.pgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pgv.TabIndex = 2;
			this.pgv.TabStop = false;
			//
			//Panel3
			//
			this.Panel3.BackColor = System.Drawing.Color.Transparent;
			this.Panel3.Controls.Add(this.ButtonX4);
			this.Panel3.Controls.Add(this.ButtonX3);
			this.Panel3.Controls.Add(this.ButtonX2);
			this.Panel3.Controls.Add(this.dgvReserveFood);
			this.Panel3.Location = new System.Drawing.Point(515, 90);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(301, 382);
			this.Panel3.TabIndex = 1;
			//
			//ButtonX4
			//
			this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX4.Location = new System.Drawing.Point(195, 310);
			this.ButtonX4.Name = "ButtonX4";
			this.ButtonX4.Size = new System.Drawing.Size(78, 57);
			this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX4.Symbol = "";
			this.ButtonX4.TabIndex = 1;
			this.ButtonX4.Text = "ສໍາເລັດ";
			//
			//ButtonX3
			//
			this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX3.Location = new System.Drawing.Point(111, 309);
			this.ButtonX3.Name = "ButtonX3";
			this.ButtonX3.Size = new System.Drawing.Size(78, 57);
			this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX3.Symbol = "";
			this.ButtonX3.TabIndex = 1;
			this.ButtonX3.Text = "ຍົກເລີກ";
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(27, 310);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(78, 57);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.Symbol = "";
			this.ButtonX2.TabIndex = 1;
			this.ButtonX2.Text = "ແກ້ໄຂ";
			//
			//dgvReserveFood
			//
			this.dgvReserveFood.AllowUserToAddRows = false;
			this.dgvReserveFood.AllowUserToDeleteRows = false;
			this.dgvReserveFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserveFood.DefaultCellStyle = DataGridViewCellStyle1;
			this.dgvReserveFood.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvReserveFood.Location = new System.Drawing.Point(3, 5);
			this.dgvReserveFood.Name = "dgvReserveFood";
			this.dgvReserveFood.ReadOnly = true;
			this.dgvReserveFood.Size = new System.Drawing.Size(298, 298);
			this.dgvReserveFood.TabIndex = 0;
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.dgv_Menu);
			this.Panel2.Location = new System.Drawing.Point(19, 90);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(266, 382);
			this.Panel2.TabIndex = 0;
			//
			//dgv_Menu
			//
			this.dgv_Menu.AllowUserToAddRows = false;
			this.dgv_Menu.AllowUserToDeleteRows = false;
			this.dgv_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Menu.DefaultCellStyle = DataGridViewCellStyle2;
			this.dgv_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Menu.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgv_Menu.Location = new System.Drawing.Point(0, 0);
			this.dgv_Menu.Name = "dgv_Menu";
			this.dgv_Menu.ReadOnly = true;
			this.dgv_Menu.Size = new System.Drawing.Size(266, 382);
			this.dgv_Menu.TabIndex = 0;
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(0, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(831, 44);
			this.Label5.TabIndex = 6;
			this.Label5.Text = "ຈອງອາຫານ";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//frm_ReserveFood1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(855, 510);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_ReserveFood1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_ReserveFood1";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.pgv).EndInit();
			this.Panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvReserveFood).EndInit();
			this.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgv_Menu).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal Panel Panel1;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal Label Label3;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtAmount;
		internal Label Label2;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtName;
		internal Label Label1;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtID;
		internal PictureBox pgv;
		internal Panel Panel3;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserveFood;
		internal Panel Panel2;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgv_Menu;
		internal Label Label4;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
		internal DevComponents.DotNetBar.ButtonX ButtonX4;
		internal DevComponents.DotNetBar.ButtonX ButtonX3;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal Label Label5;
	}
	
}
