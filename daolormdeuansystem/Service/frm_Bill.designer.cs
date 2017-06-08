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
	
	partial class frm_Bill : System.Windows.Forms.Form
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
			this.rp_Bill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			//
			//rp_Bill
			//
			this.rp_Bill.ActiveViewIndex = -1;
			this.rp_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rp_Bill.Cursor = System.Windows.Forms.Cursors.Default;
			this.rp_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rp_Bill.Location = new System.Drawing.Point(0, 0);
			this.rp_Bill.Name = "rp_Bill";
			this.rp_Bill.Size = new System.Drawing.Size(717, 548);
			this.rp_Bill.TabIndex = 0;
			//
			//frm_Bill
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 548);
			this.Controls.Add(this.rp_Bill);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Bill";
			this.Text = "frm_Bill";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			
		}
		
		internal CrystalDecisions.Windows.Forms.CrystalReportViewer rp_Bill;
	}
	
}
