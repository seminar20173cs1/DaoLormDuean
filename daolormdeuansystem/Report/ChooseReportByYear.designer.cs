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
	
	partial class ChooseReportByYear : System.Windows.Forms.Form
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
			this.btReportYear = new DevComponents.DotNetBar.ButtonX();
			this.btReportYear.Click += new System.EventHandler(this.btReportYear_Click);
			base.Load += new System.EventHandler(ChooseReportByYear_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			//
			//btReportYear
			//
			this.btReportYear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btReportYear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btReportYear.Location = new System.Drawing.Point(71, 76);
			this.btReportYear.Name = "btReportYear";
			this.btReportYear.Size = new System.Drawing.Size(200, 43);
			this.btReportYear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btReportYear.TabIndex = 5;
			this.btReportYear.Text = "ເບິ່ງລາຍງານ";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label2.Location = new System.Drawing.Point(89, 23);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(27, 34);
			this.Label2.TabIndex = 18;
			this.Label2.Text = "ປີ";
			//
			//cbYear
			//
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Items.AddRange(new object[] {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
			this.cbYear.Location = new System.Drawing.Point(123, 23);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(117, 35);
			this.cbYear.TabIndex = 17;
			//
			//ChooseReportByYear
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 142);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.btReportYear);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ChooseReportByYear";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChooseReportByYear";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevComponents.DotNetBar.ButtonX btReportYear;
		internal Label Label2;
		internal ComboBox cbYear;
	}
	
}
