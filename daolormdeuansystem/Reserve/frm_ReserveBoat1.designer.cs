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
	
	partial class frm_ReserveBoat1 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_ReserveBoat1_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btView = new System.Windows.Forms.Button();
			this.btView.Click += new System.EventHandler(this.btView_Click);
			this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.dgvBoat = new System.Windows.Forms.DataGridView();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtBoatName = new System.Windows.Forms.TextBox();
			this.txtBoatID = new System.Windows.Forms.TextBox();
			this.btChooseBoat = new System.Windows.Forms.Button();
			this.btChooseBoat.Click += new System.EventHandler(this.btChooseBoat_Click);
			this.ptbBoat = new System.Windows.Forms.PictureBox();
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.dgvService = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvReserve = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.tmService = new System.Windows.Forms.Timer(this.components);
			this.tmService.Tick += new System.EventHandler(this.tmService_Tick);
			this.tmReserve = new System.Windows.Forms.Timer(this.components);
			this.tmReserve.Tick += new System.EventHandler(this.tmReserve_Tick);
			this.txtHour = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize) this.dgvBoat).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ptbBoat).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvService).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).BeginInit();
			this.SuspendLayout();
			//
			//btView
			//
			this.btView.Location = new System.Drawing.Point(125, 435);
			this.btView.Name = "btView";
			this.btView.Size = new System.Drawing.Size(128, 49);
			this.btView.TabIndex = 71;
			this.btView.Text = "View Service";
			this.btView.UseVisualStyleBackColor = true;
			//
			//FlowLayoutPanel1
			//
			this.FlowLayoutPanel1.AutoScroll = true;
			this.FlowLayoutPanel1.Location = new System.Drawing.Point(26, 60);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Size = new System.Drawing.Size(295, 364);
			this.FlowLayoutPanel1.TabIndex = 69;
			//
			//btn_Delete
			//
			this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Delete.Location = new System.Drawing.Point(673, 435);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(94, 50);
			this.btn_Delete.TabIndex = 65;
			this.btn_Delete.Text = "ລຶບ";
			this.btn_Delete.UseVisualStyleBackColor = true;
			//
			//btn_Edit
			//
			this.btn_Edit.Location = new System.Drawing.Point(579, 435);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(79, 50);
			this.btn_Edit.TabIndex = 64;
			this.btn_Edit.Text = "ແກ້ໄຂ";
			this.btn_Edit.UseVisualStyleBackColor = true;
			//
			//btn_Save
			//
			this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Save.Location = new System.Drawing.Point(773, 435);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(94, 50);
			this.btn_Save.TabIndex = 63;
			this.btn_Save.Text = "ຕົກລົງ";
			this.btn_Save.UseVisualStyleBackColor = true;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.Navy;
			this.Label4.Location = new System.Drawing.Point(390, -1);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(227, 39);
			this.Label4.TabIndex = 66;
			this.Label4.Text = "ເລືອກເຮືອສຳລັບຈອງ";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//dgvBoat
			//
			this.dgvBoat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBoat.Location = new System.Drawing.Point(576, 60);
			this.dgvBoat.Name = "dgvBoat";
			this.dgvBoat.RowTemplate.Height = 28;
			this.dgvBoat.Size = new System.Drawing.Size(291, 364);
			this.dgvBoat.TabIndex = 62;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(398, 258);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(23, 23);
			this.Label2.TabIndex = 61;
			this.Label2.Text = "ຊື່:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(347, 221);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(74, 23);
			this.Label1.TabIndex = 60;
			this.Label1.Text = "ລະຫັດເຮືອ:";
			//
			//txtBoatName
			//
			this.txtBoatName.Location = new System.Drawing.Point(427, 255);
			this.txtBoatName.Name = "txtBoatName";
			this.txtBoatName.Size = new System.Drawing.Size(139, 31);
			this.txtBoatName.TabIndex = 58;
			//
			//txtBoatID
			//
			this.txtBoatID.Location = new System.Drawing.Point(427, 218);
			this.txtBoatID.Name = "txtBoatID";
			this.txtBoatID.Size = new System.Drawing.Size(139, 31);
			this.txtBoatID.TabIndex = 57;
			//
			//btChooseBoat
			//
			this.btChooseBoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btChooseBoat.Location = new System.Drawing.Point(375, 354);
			this.btChooseBoat.Name = "btChooseBoat";
			this.btChooseBoat.Size = new System.Drawing.Size(138, 59);
			this.btChooseBoat.TabIndex = 56;
			this.btChooseBoat.Text = "ເລືອກ";
			this.btChooseBoat.UseVisualStyleBackColor = true;
			//
			//ptbBoat
			//
			this.ptbBoat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ptbBoat.Location = new System.Drawing.Point(336, 60);
			this.ptbBoat.Name = "ptbBoat";
			this.ptbBoat.Size = new System.Drawing.Size(221, 143);
			this.ptbBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbBoat.TabIndex = 59;
			this.ptbBoat.TabStop = false;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(28, 435);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(91, 48);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 72;
			this.ButtonX1.Text = "ໂຫຼດຄືນ";
			//
			//dgvService
			//
			this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvService.DefaultCellStyle = DataGridViewCellStyle1;
			this.dgvService.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvService.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvService.Location = new System.Drawing.Point(0, 0);
			this.dgvService.Name = "dgvService";
			this.dgvService.Size = new System.Drawing.Size(894, 10);
			this.dgvService.TabIndex = 73;
			//
			//dgvReserve
			//
			this.dgvReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserve.DefaultCellStyle = DataGridViewCellStyle2;
			this.dgvReserve.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvReserve.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvReserve.Location = new System.Drawing.Point(0, 10);
			this.dgvReserve.Name = "dgvReserve";
			this.dgvReserve.Size = new System.Drawing.Size(894, 10);
			this.dgvReserve.TabIndex = 74;
			//
			//tmService
			//
			this.tmService.Interval = 10;
			//
			//tmReserve
			//
			this.tmReserve.Interval = 10;
			//
			//txtHour
			//
			this.txtHour.Location = new System.Drawing.Point(427, 292);
			this.txtHour.Name = "txtHour";
			this.txtHour.Size = new System.Drawing.Size(139, 31);
			this.txtHour.TabIndex = 58;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(323, 300);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(98, 23);
			this.Label3.TabIndex = 61;
			this.Label3.Text = "ຈໍານວນຊົ່ວໂມງ:";
			//
			//frm_ReserveBoat1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 529);
			this.Controls.Add(this.dgvReserve);
			this.Controls.Add(this.dgvService);
			this.Controls.Add(this.ButtonX1);
			this.Controls.Add(this.btView);
			this.Controls.Add(this.FlowLayoutPanel1);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.dgvBoat);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ptbBoat);
			this.Controls.Add(this.txtHour);
			this.Controls.Add(this.txtBoatName);
			this.Controls.Add(this.txtBoatID);
			this.Controls.Add(this.btChooseBoat);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_ReserveBoat1";
			this.Text = "frm_ReserveBoat1";
			((System.ComponentModel.ISupportInitialize) this.dgvBoat).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ptbBoat).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvService).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Button btView;
		internal FlowLayoutPanel FlowLayoutPanel1;
		internal Button btn_Delete;
		internal Button btn_Edit;
		internal Button btn_Save;
		internal Label Label4;
		internal DataGridView dgvBoat;
		internal Label Label2;
		internal Label Label1;
		internal PictureBox ptbBoat;
		internal TextBox txtBoatName;
		internal TextBox txtBoatID;
		internal Button btChooseBoat;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvService;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserve;
		internal Timer tmService;
		internal Timer tmReserve;
		internal TextBox txtHour;
		internal Label Label3;
		internal Timer Timer1;
		internal Timer Timer2;
	}
	
}
