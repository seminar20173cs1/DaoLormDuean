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
using CrystalDecisions.CrystalReports;

namespace daolormdeuansystem
{
	
	partial class frm_MainReportChoosing : System.Windows.Forms.Form
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
			this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			//
			//CrystalReportViewer1
			//
			this.CrystalReportViewer1.ActiveViewIndex = -1;
			this.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.Size = new System.Drawing.Size(488, 462);
			this.CrystalReportViewer1.TabIndex = 0;
			//
			//frm_MainReportChoosing
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 462);
			this.Controls.Add(this.CrystalReportViewer1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_MainReportChoosing";
			this.Text = "frm_MainReportChoosing";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			
		}
		
		internal CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;
	}
	
}
