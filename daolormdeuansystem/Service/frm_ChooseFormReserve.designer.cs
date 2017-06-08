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
	
	partial class frm_ChoosFormReserve : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_ChooseFormReserve_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvReserve = new System.Windows.Forms.Panel();
			this.dgvReserveBoat = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.pgbLoadData = new System.Windows.Forms.ProgressBar();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.dgvReserve.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvReserveBoat).BeginInit();
			this.SuspendLayout();
			//
			//dgvReserve
			//
			this.dgvReserve.Controls.Add(this.pgbLoadData);
			this.dgvReserve.Controls.Add(this.ButtonX1);
			this.dgvReserve.Controls.Add(this.dgvReserveBoat);
			this.dgvReserve.Location = new System.Drawing.Point(12, 12);
			this.dgvReserve.Name = "dgvReserve";
			this.dgvReserve.Size = new System.Drawing.Size(781, 438);
			this.dgvReserve.TabIndex = 0;
			//
			//dgvReserveBoat
			//
			this.dgvReserveBoat.AllowUserToAddRows = false;
			this.dgvReserveBoat.AllowUserToDeleteRows = false;
			this.dgvReserveBoat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvReserveBoat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvReserveBoat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvReserveBoat.DefaultCellStyle = DataGridViewCellStyle3;
			this.dgvReserveBoat.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvReserveBoat.Location = new System.Drawing.Point(4, 4);
			this.dgvReserveBoat.Name = "dgvReserveBoat";
			this.dgvReserveBoat.ReadOnly = true;
			this.dgvReserveBoat.Size = new System.Drawing.Size(774, 244);
			this.dgvReserveBoat.TabIndex = 0;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(276, 258);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(211, 135);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 1;
			this.ButtonX1.Text = "ເປີດໃຊ້ບໍລິການ";
			//
			//pgbLoadData
			//
			this.pgbLoadData.Location = new System.Drawing.Point(14, 404);
			this.pgbLoadData.Name = "pgbLoadData";
			this.pgbLoadData.Size = new System.Drawing.Size(748, 23);
			this.pgbLoadData.TabIndex = 2;
			//
			//Timer1
			//
			//
			//frm_ChoosFormReserve
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 462);
			this.Controls.Add(this.dgvReserve);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_ChoosFormReserve";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_ChooseFormReserve";
			this.dgvReserve.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvReserveBoat).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal Panel dgvReserve;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvReserveBoat;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal ProgressBar pgbLoadData;
		internal Timer Timer1;
	}
	
}
