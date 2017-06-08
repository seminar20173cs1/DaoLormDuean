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
	
	partial class frm_ChangeAmountFood : System.Windows.Forms.Form
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
			this.txtFoodName = new DevComponents.DotNetBar.Controls.TextBoxX();
			base.Load += new System.EventHandler(frm_ChangeAmountFood_Load);
			this.txtFoodAmount = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.btClose = new DevComponents.DotNetBar.ButtonX();
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			this.SuspendLayout();
			//
			//txtFoodName
			//
			this.txtFoodName.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtFoodName.Border.Class = "TextBoxBorder";
			this.txtFoodName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtFoodName.DisabledBackColor = System.Drawing.Color.White;
			this.txtFoodName.ForeColor = System.Drawing.Color.Black;
			this.txtFoodName.Location = new System.Drawing.Point(66, 86);
			this.txtFoodName.Name = "txtFoodName";
			this.txtFoodName.PreventEnterBeep = true;
			this.txtFoodName.Size = new System.Drawing.Size(167, 31);
			this.txtFoodName.TabIndex = 0;
			//
			//txtFoodAmount
			//
			this.txtFoodAmount.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtFoodAmount.Border.Class = "TextBoxBorder";
			this.txtFoodAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtFoodAmount.DisabledBackColor = System.Drawing.Color.White;
			this.txtFoodAmount.ForeColor = System.Drawing.Color.Black;
			this.txtFoodAmount.Location = new System.Drawing.Point(66, 123);
			this.txtFoodAmount.Name = "txtFoodAmount";
			this.txtFoodAmount.PreventEnterBeep = true;
			this.txtFoodAmount.Size = new System.Drawing.Size(167, 31);
			this.txtFoodAmount.TabIndex = 0;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(53, 229);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(92, 70);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 1;
			this.ButtonX1.Text = "ສໍາເລັດ";
			//
			//btClose
			//
			this.btClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btClose.Location = new System.Drawing.Point(151, 229);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(92, 70);
			this.btClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btClose.TabIndex = 1;
			this.btClose.Text = "ຍົກເລີກ";
			//
			//frm_ChangeAmountFood
			//
			this.AcceptButton = this.ButtonX1;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(297, 376);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.ButtonX1);
			this.Controls.Add(this.txtFoodAmount);
			this.Controls.Add(this.txtFoodName);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_ChangeAmountFood";
			this.Opacity = 0.8D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_ChangeAmountFood";
			this.ResumeLayout(false);
			
		}
		
		internal DevComponents.DotNetBar.Controls.TextBoxX txtFoodName;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtFoodAmount;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.ButtonX btClose;
	}
	
}
