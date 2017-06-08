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
	
	partial class ChooseReportByMonth : System.Windows.Forms.Form
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
			this.btReportMonth = new DevComponents.DotNetBar.ButtonX();
			this.btReportMonth.Click += new System.EventHandler(this.btReportMonth_Click);
			base.Load += new System.EventHandler(ChooseReportByMonth_Load);
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.cbMonth = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			//
			//btReportMonth
			//
			this.btReportMonth.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btReportMonth.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btReportMonth.Location = new System.Drawing.Point(71, 135);
			this.btReportMonth.Name = "btReportMonth";
			this.btReportMonth.Size = new System.Drawing.Size(200, 43);
			this.btReportMonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btReportMonth.TabIndex = 3;
			this.btReportMonth.Text = "ເບິ່ງລາຍງານ";
			//
			//cbYear
			//
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Items.AddRange(new object[] {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
			this.cbYear.Location = new System.Drawing.Point(154, 94);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(117, 35);
			this.cbYear.TabIndex = 11;
			//
			//cbMonth
			//
			this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMonth.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.cbMonth.FormattingEnabled = true;
			this.cbMonth.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"});
			this.cbMonth.Location = new System.Drawing.Point(154, 12);
			this.cbMonth.Name = "cbMonth";
			this.cbMonth.Size = new System.Drawing.Size(117, 35);
			this.cbMonth.TabIndex = 10;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label2.Location = new System.Drawing.Point(116, 95);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(32, 34);
			this.Label2.TabIndex = 13;
			this.Label2.Text = "ປີ:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label1.Location = new System.Drawing.Point(53, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(95, 34);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "ຈາກເດືອນ:";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label3.Location = new System.Drawing.Point(56, 54);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(92, 34);
			this.Label3.TabIndex = 15;
			this.Label3.Text = "ເຖິງເດືອນ:";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"});
			this.ComboBox1.Location = new System.Drawing.Point(154, 53);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(117, 35);
			this.ComboBox1.TabIndex = 14;
			//
			//ChooseReportByMonth
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 190);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.cbMonth);
			this.Controls.Add(this.btReportMonth);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ChooseReportByMonth";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChooseReportByMonth";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevComponents.DotNetBar.ButtonX btReportMonth;
		internal ComboBox cbYear;
		internal ComboBox cbMonth;
		internal Label Label2;
		internal Label Label1;
		internal Label Label3;
		internal ComboBox ComboBox1;
	}
	
}
