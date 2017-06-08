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
	
	partial class ChooseReportGoodSellbyMonth : System.Windows.Forms.Form
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
			this.txtTop = new System.Windows.Forms.TextBox();
			base.Load += new System.EventHandler(ChooseReportGoodSellbyMonth_Load);
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.btReportDate = new DevComponents.DotNetBar.ButtonX();
			this.btReportDate.Click += new System.EventHandler(this.btReportDate_Click);
			this.SuspendLayout();
			//
			//txtTop
			//
			this.txtTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtTop.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.txtTop.Location = new System.Drawing.Point(160, 104);
			this.txtTop.Name = "txtTop";
			this.txtTop.Size = new System.Drawing.Size(117, 34);
			this.txtTop.TabIndex = 13;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label3.Location = new System.Drawing.Point(105, 105);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(55, 34);
			this.Label3.TabIndex = 12;
			this.Label3.Text = "TOP";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label2.Location = new System.Drawing.Point(124, 57);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(27, 34);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "ປີ";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label1.Location = new System.Drawing.Point(100, 11);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(58, 34);
			this.Label1.TabIndex = 10;
			this.Label1.Text = "ເດືອນ";
			//
			//cbYear
			//
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Items.AddRange(new object[] {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
			this.cbYear.Location = new System.Drawing.Point(160, 56);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(117, 35);
			this.cbYear.TabIndex = 9;
			//
			//cbMonth
			//
			this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMonth.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.cbMonth.FormattingEnabled = true;
			this.cbMonth.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"});
			this.cbMonth.Location = new System.Drawing.Point(162, 12);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(117, 35);
			this.cbMonth.TabIndex = 8;
			//
			//btReportDate
			//
			this.btReportDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btReportDate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btReportDate.Location = new System.Drawing.Point(12, 152);
			this.btReportDate.Name = "btReportDate";
			this.btReportDate.Size = new System.Drawing.Size(358, 43);
			this.btReportDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btReportDate.TabIndex = 14;
			this.btReportDate.Text = "ເບິ່ງລາຍງານ";
			//
			//ChooseReportGoodSellbyMonth
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 207);
			this.Controls.Add(this.btReportDate);
			this.Controls.Add(this.txtTop);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.cbMonth);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ChooseReportGoodSellbyMonth";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChooseReportGoodSellbyMonth";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal TextBox txtTop;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal ComboBox cbYear;
		internal ComboBox cbMonth;
		internal DevComponents.DotNetBar.ButtonX btReportDate;
	}
	
}
