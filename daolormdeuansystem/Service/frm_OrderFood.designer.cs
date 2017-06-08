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
	
	partial class frm_OrderFood : System.Windows.Forms.Form
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
			this.TextBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			base.Load += new System.EventHandler(frm_OrderFood_Load);
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.foodMenu = new System.Windows.Forms.FlowLayoutPanel();
			this.pnOrderList = new System.Windows.Forms.FlowLayoutPanel();
			this.pnOrderList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlowLayoutPanel1_DragEnter);
			this.pnOrderList.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnOrderList_DragDrop);
			this.SuspendLayout();
			//
			//TextBoxX1
			//
			this.TextBoxX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBoxX1.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.TextBoxX1.Border.Class = "TextBoxBorder";
			this.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.TextBoxX1.DisabledBackColor = System.Drawing.Color.White;
			this.TextBoxX1.ForeColor = System.Drawing.Color.Black;
			this.TextBoxX1.Location = new System.Drawing.Point(26, 55);
			this.TextBoxX1.Name = "TextBoxX1";
			this.TextBoxX1.PreventEnterBeep = true;
			this.TextBoxX1.Size = new System.Drawing.Size(215, 31);
			this.TextBoxX1.TabIndex = 1;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(247, 55);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(116, 31);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 2;
			this.ButtonX1.Text = "ຊອກຫາ";
			//
			//RadioButton1
			//
			this.RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new System.Drawing.Point(69, 22);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(65, 27);
			this.RadioButton1.TabIndex = 3;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "ລະຫັດ";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//RadioButton2
			//
			this.RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(26, 22);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(37, 27);
			this.RadioButton2.TabIndex = 3;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "ຊື່";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton3
			//
			this.RadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Location = new System.Drawing.Point(195, 22);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(69, 27);
			this.RadioButton3.TabIndex = 3;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "ປະເພດ";
			this.RadioButton3.UseVisualStyleBackColor = true;
			//
			//RadioButton4
			//
			this.RadioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Location = new System.Drawing.Point(140, 22);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new System.Drawing.Size(49, 27);
			this.RadioButton4.TabIndex = 3;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "ກຸ່ມ";
			this.RadioButton4.UseVisualStyleBackColor = true;
			//
			//foodMenu
			//
			this.foodMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.foodMenu.AutoScroll = true;
			this.foodMenu.Location = new System.Drawing.Point(26, 92);
			this.foodMenu.Name = "foodMenu";
			this.foodMenu.Size = new System.Drawing.Size(337, 384);
			this.foodMenu.TabIndex = 4;
			//
			//pnOrderList
			//
			this.pnOrderList.AllowDrop = true;
			this.pnOrderList.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnOrderList.AutoScroll = true;
			this.pnOrderList.Location = new System.Drawing.Point(397, 92);
			this.pnOrderList.Name = "pnOrderList";
			this.pnOrderList.Size = new System.Drawing.Size(338, 384);
			this.pnOrderList.TabIndex = 5;
			//
			//frm_OrderFood
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 509);
			this.Controls.Add(this.pnOrderList);
			this.Controls.Add(this.foodMenu);
			this.Controls.Add(this.RadioButton4);
			this.Controls.Add(this.RadioButton2);
			this.Controls.Add(this.RadioButton3);
			this.Controls.Add(this.RadioButton1);
			this.Controls.Add(this.ButtonX1);
			this.Controls.Add(this.TextBoxX1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_OrderFood";
			this.Text = "frm_OrderFood";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevComponents.DotNetBar.Controls.TextBoxX TextBoxX1;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal RadioButton RadioButton1;
		internal RadioButton RadioButton2;
		internal RadioButton RadioButton3;
		internal RadioButton RadioButton4;
		internal FlowLayoutPanel foodMenu;
		internal FlowLayoutPanel pnOrderList;
	}
	
}
