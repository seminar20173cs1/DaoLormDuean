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
	
	partial class ChooseReportByDate : System.Windows.Forms.Form
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
			this.dtp = new System.Windows.Forms.DateTimePicker();
			this.btReportDate = new DevComponents.DotNetBar.ButtonX();
			this.btReportDate.Click += new System.EventHandler(this.btReportDate_Click);
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			//
			//dtp
			//
			this.dtp.Location = new System.Drawing.Point(76, 27);
			this.dtp.Name = "dtp";
			this.dtp.Size = new System.Drawing.Size(200, 31);
			this.dtp.TabIndex = 0;
			//
			//btReportDate
			//
			this.btReportDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btReportDate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btReportDate.Location = new System.Drawing.Point(76, 128);
			this.btReportDate.Name = "btReportDate";
			this.btReportDate.Size = new System.Drawing.Size(200, 43);
			this.btReportDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btReportDate.TabIndex = 1;
			this.btReportDate.Text = "ເບິ່ງລາຍງານ";
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(76, 75);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(200, 31);
			this.DateTimePicker1.TabIndex = 2;
			//
			//ChooseReportByDate
			//
			this.AcceptButton = this.btReportDate;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 183);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.btReportDate);
			this.Controls.Add(this.dtp);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ChooseReportByDate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ChooseReportByDate";
			this.ResumeLayout(false);
			
		}
		
		internal DateTimePicker dtp;
		internal DevComponents.DotNetBar.ButtonX btReportDate;
		internal DateTimePicker DateTimePicker1;
	}
	
}
