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
	
		public partial class frm_TimeCalculation : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
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
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
			this.btClose = new DevComponents.DotNetBar.ButtonX();
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			base.Load += new System.EventHandler(frm_TimeCalculation_Load);
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.txtEndTime = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtStartTime = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.lbResultTime = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lbhour = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.lbminute = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.lbmoneybyHOur = new System.Windows.Forms.Label();
			this.lbmoneybyMinute = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtAllMoney = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.lbSellID = new System.Windows.Forms.Label();
			this.lbBoatID = new System.Windows.Forms.Label();
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.SuspendLayout();
			//
			//btClose
			//
			this.btClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btClose.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btClose.Location = new System.Drawing.Point(297, 401);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(92, 70);
			this.btClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btClose.TabIndex = 4;
			this.btClose.Text = "ຍົກເລີກ";
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(79, 401);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(92, 70);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 5;
			this.ButtonX1.Text = "ຄິດໄລ່";
			//
			//txtEndTime
			//
			this.txtEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEndTime.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtEndTime.Border.Class = "TextBoxBorder";
			this.txtEndTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtEndTime.DisabledBackColor = System.Drawing.Color.White;
			this.txtEndTime.ForeColor = System.Drawing.Color.Black;
			this.txtEndTime.Location = new System.Drawing.Point(127, 147);
			this.txtEndTime.Name = "txtEndTime";
			this.txtEndTime.PreventEnterBeep = true;
			this.txtEndTime.Size = new System.Drawing.Size(320, 31);
			this.txtEndTime.TabIndex = 2;
			//
			//txtStartTime
			//
			this.txtStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtStartTime.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtStartTime.Border.Class = "TextBoxBorder";
			this.txtStartTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtStartTime.DisabledBackColor = System.Drawing.Color.White;
			this.txtStartTime.ForeColor = System.Drawing.Color.Black;
			this.txtStartTime.Location = new System.Drawing.Point(127, 110);
			this.txtStartTime.Name = "txtStartTime";
			this.txtStartTime.PreventEnterBeep = true;
			this.txtStartTime.Size = new System.Drawing.Size(320, 31);
			this.txtStartTime.TabIndex = 3;
			//
			//lbResultTime
			//
			this.lbResultTime.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbResultTime.AutoSize = true;
			this.lbResultTime.BackColor = System.Drawing.Color.Transparent;
			this.lbResultTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbResultTime.Location = new System.Drawing.Point(49, 112);
			this.lbResultTime.Name = "lbResultTime";
			this.lbResultTime.Size = new System.Drawing.Size(76, 23);
			this.lbResultTime.TabIndex = 6;
			this.lbResultTime.Text = "ເວລາເລີ່ມ:";
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label1.Location = new System.Drawing.Point(37, 149);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(88, 23);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "ເວລາສີ້ນສຸດ:";
			//
			//lbhour
			//
			this.lbhour.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbhour.AutoSize = true;
			this.lbhour.BackColor = System.Drawing.Color.Transparent;
			this.lbhour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbhour.Location = new System.Drawing.Point(143, 193);
			this.lbhour.Name = "lbhour";
			this.lbhour.Size = new System.Drawing.Size(109, 23);
			this.lbhour.TabIndex = 7;
			this.lbhour.Text = "ຈໍານວນຊົ່ວໂມງ:";
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label2.Location = new System.Drawing.Point(21, 193);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(109, 23);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "ຈໍານວນຊົ່ວໂມງ:";
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label3.Location = new System.Drawing.Point(86, 232);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(44, 23);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "ນາທີ:";
			//
			//lbminute
			//
			this.lbminute.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbminute.AutoSize = true;
			this.lbminute.BackColor = System.Drawing.Color.Transparent;
			this.lbminute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbminute.Location = new System.Drawing.Point(143, 232);
			this.lbminute.Name = "lbminute";
			this.lbminute.Size = new System.Drawing.Size(44, 23);
			this.lbminute.TabIndex = 10;
			this.lbminute.Text = "ນາທີ:";
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label4.Location = new System.Drawing.Point(37, 312);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(93, 23);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "ເງິນເປັນນາທີ:";
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label5.Location = new System.Drawing.Point(21, 272);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(111, 23);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "ເງິນເປັນຊົ່ວໂມງ:";
			//
			//lbmoneybyHOur
			//
			this.lbmoneybyHOur.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbmoneybyHOur.AutoSize = true;
			this.lbmoneybyHOur.BackColor = System.Drawing.Color.Transparent;
			this.lbmoneybyHOur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbmoneybyHOur.Location = new System.Drawing.Point(145, 272);
			this.lbmoneybyHOur.Name = "lbmoneybyHOur";
			this.lbmoneybyHOur.Size = new System.Drawing.Size(93, 23);
			this.lbmoneybyHOur.TabIndex = 13;
			this.lbmoneybyHOur.Text = "ເງິນເປັນນາທີ:";
			//
			//lbmoneybyMinute
			//
			this.lbmoneybyMinute.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbmoneybyMinute.AutoSize = true;
			this.lbmoneybyMinute.BackColor = System.Drawing.Color.Transparent;
			this.lbmoneybyMinute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbmoneybyMinute.Location = new System.Drawing.Point(143, 312);
			this.lbmoneybyMinute.Name = "lbmoneybyMinute";
			this.lbmoneybyMinute.Size = new System.Drawing.Size(93, 23);
			this.lbmoneybyMinute.TabIndex = 14;
			this.lbmoneybyMinute.Text = "ເງິນເປັນນາທີ:";
			//
			//Label6
			//
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label6.Location = new System.Drawing.Point(37, 354);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(190, 23);
			this.Label6.TabIndex = 15;
			this.Label6.Text = " ລວມເງິນຄ່າລ່ອງເຮືອທັງໝົດ:";
			//
			//txtAllMoney
			//
			this.txtAllMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtAllMoney.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtAllMoney.Border.Class = "TextBoxBorder";
			this.txtAllMoney.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtAllMoney.DisabledBackColor = System.Drawing.Color.White;
			this.txtAllMoney.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtAllMoney.ForeColor = System.Drawing.Color.Black;
			this.txtAllMoney.Location = new System.Drawing.Point(233, 346);
			this.txtAllMoney.Name = "txtAllMoney";
			this.txtAllMoney.PreventEnterBeep = true;
			this.txtAllMoney.Size = new System.Drawing.Size(214, 38);
			this.txtAllMoney.TabIndex = 16;
			//
			//Label7
			//
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label7.Location = new System.Drawing.Point(30, 21);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(95, 23);
			this.Label7.TabIndex = 17;
			this.Label7.Text = "ລະຫັດໃບບິນ:";
			//
			//Label8
			//
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Label8.Location = new System.Drawing.Point(84, 59);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(41, 23);
			this.Label8.TabIndex = 18;
			this.Label8.Text = "ເຮືອ:";
			//
			//lbSellID
			//
			this.lbSellID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbSellID.AutoSize = true;
			this.lbSellID.BackColor = System.Drawing.Color.Transparent;
			this.lbSellID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbSellID.Location = new System.Drawing.Point(132, 21);
			this.lbSellID.Name = "lbSellID";
			this.lbSellID.Size = new System.Drawing.Size(95, 23);
			this.lbSellID.TabIndex = 19;
			this.lbSellID.Text = "ລະຫັດໃບບິນ:";
			//
			//lbBoatID
			//
			this.lbBoatID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lbBoatID.AutoSize = true;
			this.lbBoatID.BackColor = System.Drawing.Color.Transparent;
			this.lbBoatID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbBoatID.Location = new System.Drawing.Point(132, 59);
			this.lbBoatID.Name = "lbBoatID";
			this.lbBoatID.Size = new System.Drawing.Size(95, 23);
			this.lbBoatID.TabIndex = 20;
			this.lbBoatID.Text = "ລະຫັດໃບບິນ:";
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(188, 401);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(92, 70);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.TabIndex = 21;
			this.ButtonX2.Text = "ສໍາເລັດ";
			//
			//frm_TimeCalculation
			//
			this.AcceptButton = this.ButtonX2;
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (10.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0006;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(487, 483);
			this.Controls.Add(this.ButtonX2);
			this.Controls.Add(this.lbBoatID);
			this.Controls.Add(this.lbSellID);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.txtAllMoney);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.lbmoneybyMinute);
			this.Controls.Add(this.lbmoneybyHOur);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.lbminute);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.lbhour);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lbResultTime);
			this.Controls.Add(this.btClose);
			this.Controls.Add(this.ButtonX1);
			this.Controls.Add(this.txtEndTime);
			this.Controls.Add(this.txtStartTime);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frm_TimeCalculation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_TimeCalculation";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DevComponents.DotNetBar.ButtonX btClose;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtEndTime;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtStartTime;
		internal Label lbResultTime;
		internal Label Label1;
		internal Label lbhour;
		internal Label Label2;
		internal Label Label3;
		internal Label lbminute;
		internal Label Label4;
		internal Label Label5;
		internal Label lbmoneybyHOur;
		internal Label lbmoneybyMinute;
		internal Label Label6;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtAllMoney;
		internal Label Label7;
		internal Label Label8;
		internal Label lbSellID;
		internal Label lbBoatID;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
	}
	
}
