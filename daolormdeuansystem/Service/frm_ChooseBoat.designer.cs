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
	
	partial class frm_ChooseBoat : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_ChooseBoat_Load);
			base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(btChoose_FormClosed);
			base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(frm_ChooseBoat_KeyPress);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frm_ChooseBoat_KeyDown);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtBoatID = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ptbboat = new System.Windows.Forms.PictureBox();
			this.btCancel = new DevComponents.DotNetBar.ButtonX();
			this.btCancel.Click += new System.EventHandler(this.ButtonX2_Click);
			this.btChooseBoat = new DevComponents.DotNetBar.ButtonX();
			this.btChooseBoat.Click += new System.EventHandler(this.ButtonX1_Click);
			this.txtHour = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtBoatName = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.btRefresh = new System.Windows.Forms.Button();
			this.btRefresh.Click += new System.EventHandler(this.Button1_Click);
			this.pnboat = new System.Windows.Forms.FlowLayoutPanel();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.btView = new DevComponents.DotNetBar.ButtonX();
			this.btView.Click += new System.EventHandler(this.btView_Click);
			this.tmViewSelling = new System.Windows.Forms.Timer(this.components);
			this.tmViewSelling.Tick += new System.EventHandler(this.tmViewSelling_Tick);
			this.tmViewReserve = new System.Windows.Forms.Timer(this.components);
			this.tmViewReserve.Tick += new System.EventHandler(this.tmViewReserve_Tick);
			this.dgvSelling = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvReserve = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbboat).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvSelling).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).BeginInit();
			this.SuspendLayout();
			//
			//txtBoatID
			//
			this.txtBoatID.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtBoatID.Border.Class = "TextBoxBorder";
			this.txtBoatID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtBoatID.DisabledBackColor = System.Drawing.Color.White;
			this.txtBoatID.Enabled = false;
			this.txtBoatID.ForeColor = System.Drawing.Color.Black;
			this.txtBoatID.Location = new System.Drawing.Point(144, 191);
			this.txtBoatID.Name = "txtBoatID";
			this.txtBoatID.PreventEnterBeep = true;
			this.txtBoatID.Size = new System.Drawing.Size(145, 31);
			this.txtBoatID.TabIndex = 0;
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.ptbboat);
			this.Panel1.Controls.Add(this.btCancel);
			this.Panel1.Controls.Add(this.btChooseBoat);
			this.Panel1.Controls.Add(this.txtHour);
			this.Panel1.Controls.Add(this.txtBoatName);
			this.Panel1.Controls.Add(this.txtBoatID);
			this.Panel1.Location = new System.Drawing.Point(404, 76);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(324, 367);
			this.Panel1.TabIndex = 1;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(113, 232);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 23);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "ຊື່:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(31, 269);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(109, 23);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "ຈໍານວນຊົ່ວໂມງ:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(62, 195);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(82, 23);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "ລະຫັດເຮືອ:";
			//
			//ptbboat
			//
			this.ptbboat.Location = new System.Drawing.Point(34, 16);
			this.ptbboat.Name = "ptbboat";
			this.ptbboat.Size = new System.Drawing.Size(256, 169);
			this.ptbboat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptbboat.TabIndex = 4;
			this.ptbboat.TabStop = false;
			//
			//btCancel
			//
			this.btCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btCancel.Location = new System.Drawing.Point(180, 307);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(108, 44);
			this.btCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btCancel.Symbol = "";
			this.btCancel.TabIndex = 3;
			this.btCancel.Text = "ຍົກເລີກ";
			//
			//btChooseBoat
			//
			this.btChooseBoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btChooseBoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btChooseBoat.Location = new System.Drawing.Point(41, 307);
			this.btChooseBoat.Name = "btChooseBoat";
			this.btChooseBoat.Size = new System.Drawing.Size(108, 44);
			this.btChooseBoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btChooseBoat.Symbol = "";
			this.btChooseBoat.TabIndex = 3;
			this.btChooseBoat.Text = "ຕົກລົງ";
			//
			//txtHour
			//
			this.txtHour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtHour.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtHour.Border.Class = "TextBoxBorder";
			this.txtHour.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtHour.DisabledBackColor = System.Drawing.Color.White;
			this.txtHour.ForeColor = System.Drawing.Color.Black;
			this.txtHour.Location = new System.Drawing.Point(144, 265);
			this.txtHour.Name = "txtHour";
			this.txtHour.PreventEnterBeep = true;
			this.txtHour.Size = new System.Drawing.Size(145, 31);
			this.txtHour.TabIndex = 2;
			//
			//txtBoatName
			//
			this.txtBoatName.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtBoatName.Border.Class = "TextBoxBorder";
			this.txtBoatName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtBoatName.DisabledBackColor = System.Drawing.Color.White;
			this.txtBoatName.Enabled = false;
			this.txtBoatName.ForeColor = System.Drawing.Color.Black;
			this.txtBoatName.Location = new System.Drawing.Point(144, 228);
			this.txtBoatName.Name = "txtBoatName";
			this.txtBoatName.PreventEnterBeep = true;
			this.txtBoatName.Size = new System.Drawing.Size(145, 31);
			this.txtBoatName.TabIndex = 1;
			//
			//btRefresh
			//
			this.btRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btRefresh.Location = new System.Drawing.Point(61, 447);
			this.btRefresh.Name = "btRefresh";
			this.btRefresh.Size = new System.Drawing.Size(75, 35);
			this.btRefresh.TabIndex = 3;
			this.btRefresh.Text = "ໂຫຼດຄືນ";
			this.btRefresh.UseVisualStyleBackColor = true;
			//
			//pnboat
			//
			this.pnboat.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnboat.AutoScroll = true;
			this.pnboat.Location = new System.Drawing.Point(61, 76);
			this.pnboat.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.pnboat.Name = "pnboat";
			this.pnboat.Size = new System.Drawing.Size(324, 365);
			this.pnboat.TabIndex = 4;
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(61, 43);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(324, 32);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "ເຮືອທັງໝົດ";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(404, 43);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(324, 32);
			this.Label5.TabIndex = 6;
			this.Label5.Text = "ຂໍ້ມູນເຮືອ";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//btView
			//
			this.btView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btView.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btView.Location = new System.Drawing.Point(143, 448);
			this.btView.Name = "btView";
			this.btView.Size = new System.Drawing.Size(164, 34);
			this.btView.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btView.TabIndex = 8;
			this.btView.Text = "View Service";
			//
			//tmViewSelling
			//
			this.tmViewSelling.Interval = 1;
			//
			//tmViewReserve
			//
			this.tmViewReserve.Interval = 10;
			//
			//dgvSelling
			//
			this.dgvSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSelling.DefaultCellStyle = DataGridViewCellStyle1;
			this.dgvSelling.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvSelling.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvSelling.Location = new System.Drawing.Point(0, 0);
			this.dgvSelling.Name = "dgvSelling";
			this.dgvSelling.Size = new System.Drawing.Size(786, 40);
			this.dgvSelling.TabIndex = 0;
			//
			//dgvReserve
			//
			this.dgvReserve.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReserve.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvReserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserve.DefaultCellStyle = DataGridViewCellStyle3;
			this.dgvReserve.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvReserve.EnableHeadersVisualStyles = false;
			this.dgvReserve.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvReserve.Location = new System.Drawing.Point(0, 40);
			this.dgvReserve.Name = "dgvReserve";
			DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvReserve.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
			this.dgvReserve.Size = new System.Drawing.Size(786, 10);
			this.dgvReserve.TabIndex = 75;
			//
			//frm_ChooseBoat
			//
			this.AcceptButton = this.btChooseBoat;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(786, 494);
			this.Controls.Add(this.dgvReserve);
			this.Controls.Add(this.dgvSelling);
			this.Controls.Add(this.btView);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.btRefresh);
			this.Controls.Add(this.pnboat);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_ChooseBoat";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_ChooseBoat";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbboat).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvSelling).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgvReserve).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal DevComponents.DotNetBar.Controls.TextBoxX txtBoatID;
		internal Panel Panel1;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal PictureBox ptbboat;
		internal DevComponents.DotNetBar.ButtonX btCancel;
		internal DevComponents.DotNetBar.ButtonX btChooseBoat;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtHour;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtBoatName;
		internal Button btRefresh;
		internal FlowLayoutPanel pnboat;
		internal Label Label4;
		internal Label Label5;
		internal DevComponents.DotNetBar.ButtonX btView;
		internal Timer tmViewSelling;
		internal Timer tmViewReserve;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvSelling;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserve;
	}
	
}
