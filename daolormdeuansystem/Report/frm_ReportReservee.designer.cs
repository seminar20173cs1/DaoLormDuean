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
	
	partial class frm_ReportReservee : System.Windows.Forms.Form
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
			this.txtDay = new System.Windows.Forms.TextBox();
			base.Load += new System.EventHandler(frm_ReportReservee_Load);
			this.Label3 = new System.Windows.Forms.Label();
			this.btReportReserve = new DevComponents.DotNetBar.ButtonX();
			this.btReportReserve.Click += new System.EventHandler(this.btReportReserve_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//txtDay
			//
			this.txtDay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtDay.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.txtDay.Location = new System.Drawing.Point(337, 25);
			this.txtDay.Name = "txtDay";
			this.txtDay.Size = new System.Drawing.Size(45, 34);
			this.txtDay.TabIndex = 21;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label3.Location = new System.Drawing.Point(30, 25);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(301, 34);
			this.Label3.TabIndex = 20;
			this.Label3.Text = "ລາຍງານລູກຄ້າທີ່ຈະມາໃຊ້ບໍລິການໃນອີກ";
			//
			//btReportReserve
			//
			this.btReportReserve.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btReportReserve.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btReportReserve.Location = new System.Drawing.Point(12, 65);
			this.btReportReserve.Name = "btReportReserve";
			this.btReportReserve.Size = new System.Drawing.Size(494, 43);
			this.btReportReserve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btReportReserve.TabIndex = 19;
			this.btReportReserve.Text = "ເບິ່ງລາຍງານ";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label1.Location = new System.Drawing.Point(388, 25);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(83, 34);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "ມືຂ້າງໜ້າ";
			//
			//frm_ReportReservee
			//
			this.AcceptButton = this.btReportReserve;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 120);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtDay);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.btReportReserve);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_ReportReservee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_ReportReservee";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal TextBox txtDay;
		internal Label Label3;
		internal DevComponents.DotNetBar.ButtonX btReportReserve;
		internal Label Label1;
	}
	
}
