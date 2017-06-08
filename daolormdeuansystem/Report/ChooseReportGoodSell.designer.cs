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
	
	partial class ChooseReportGoodSell : System.Windows.Forms.Form
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
			this.btReportDate = new DevComponents.DotNetBar.ButtonX();
			base.Load += new System.EventHandler(ChooseReportGoodSell_Load);
			this.btReportDate.Click += new System.EventHandler(this.btReportDate_Click);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			this.Label3 = new System.Windows.Forms.Label();
			this.Label3.Click += new System.EventHandler(this.Label3_Click);
			this.Label2 = new System.Windows.Forms.Label();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			//
			//btReportDate
			//
			this.btReportDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btReportDate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btReportDate.Location = new System.Drawing.Point(77, 140);
			this.btReportDate.Name = "btReportDate";
			this.btReportDate.Size = new System.Drawing.Size(200, 43);
			this.btReportDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btReportDate.TabIndex = 6;
			this.btReportDate.Text = "ເບິ່ງລາຍງານ";
			//
			//TextBox1
			//
			this.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.TextBox1.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.TextBox1.Location = new System.Drawing.Point(140, 78);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(117, 34);
			this.TextBox1.TabIndex = 18;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label3.Location = new System.Drawing.Point(85, 79);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(55, 34);
			this.Label3.TabIndex = 17;
			this.Label3.Text = "TOP";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.Label2.Location = new System.Drawing.Point(104, 31);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(27, 34);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "ປີ";
			//
			//cbYear
			//
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Saysettha OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(222));
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Items.AddRange(new object[] {"2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"});
			this.cbYear.Location = new System.Drawing.Point(140, 30);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(117, 35);
			this.cbYear.TabIndex = 15;
			//
			//ChooseReportGoodSell
			//
			this.AcceptButton = this.btReportDate;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 211);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.btReportDate);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ChooseReportGoodSell";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChooseReportGoodSell";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevComponents.DotNetBar.ButtonX btReportDate;
		internal TextBox TextBox1;
		internal Label Label3;
		internal Label Label2;
		internal ComboBox cbYear;
	}
	
}
