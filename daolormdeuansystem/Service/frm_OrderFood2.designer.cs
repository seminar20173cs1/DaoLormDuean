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
	
		public partial class frm_OrderFood2 : DevComponents.DotNetBar.Metro.MetroForm
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.DataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.DataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.RadioButton4 = new System.Windows.Forms.RadioButton();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton3 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.Label1 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label2.Click += new System.EventHandler(this.Label2_Click);
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox4 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.Label5 = new System.Windows.Forms.Label();
			this.ButtonX3 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX4 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX5 = new DevComponents.DotNetBar.ButtonX();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.DataGridViewX1).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridViewX2).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//DataGridViewX1
			//
			this.DataGridViewX1.AllowUserToAddRows = false;
			this.DataGridViewX1.AllowUserToDeleteRows = false;
			this.DataGridViewX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1;
			this.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.DataGridViewX1.Location = new System.Drawing.Point(14, 106);
			this.DataGridViewX1.Name = "DataGridViewX1";
			this.DataGridViewX1.ReadOnly = true;
			this.DataGridViewX1.Size = new System.Drawing.Size(324, 287);
			this.DataGridViewX1.TabIndex = 0;
			//
			//Panel2
			//
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel2.Controls.Add(this.Label7);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.ButtonX5);
			this.Panel2.Controls.Add(this.ButtonX4);
			this.Panel2.Controls.Add(this.ButtonX3);
			this.Panel2.Controls.Add(this.DataGridViewX2);
			this.Panel2.Location = new System.Drawing.Point(659, 49);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(283, 409);
			this.Panel2.TabIndex = 5;
			//
			//DataGridViewX2
			//
			this.DataGridViewX2.AllowUserToAddRows = false;
			this.DataGridViewX2.AllowUserToDeleteRows = false;
			this.DataGridViewX2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle2;
			this.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.DataGridViewX2.Location = new System.Drawing.Point(22, 66);
			this.DataGridViewX2.Name = "DataGridViewX2";
			this.DataGridViewX2.ReadOnly = true;
			this.DataGridViewX2.Size = new System.Drawing.Size(237, 251);
			this.DataGridViewX2.TabIndex = 0;
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.RadioButton4);
			this.Panel1.Controls.Add(this.RadioButton2);
			this.Panel1.Controls.Add(this.RadioButton3);
			this.Panel1.Controls.Add(this.RadioButton1);
			this.Panel1.Controls.Add(this.ButtonX1);
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Controls.Add(this.DataGridViewX1);
			this.Panel1.Location = new System.Drawing.Point(35, 49);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(359, 409);
			this.Panel1.TabIndex = 4;
			//
			//TextBox1
			//
			this.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBox1.Location = new System.Drawing.Point(14, 66);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(185, 31);
			this.TextBox1.TabIndex = 1;
			//
			//Panel3
			//
			this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel3.Controls.Add(this.ButtonX2);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.TextBox4);
			this.Panel3.Controls.Add(this.TextBox3);
			this.Panel3.Controls.Add(this.Label3);
			this.Panel3.Controls.Add(this.TextBox2);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Controls.Add(this.PictureBox1);
			this.Panel3.Location = new System.Drawing.Point(410, 49);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(236, 408);
			this.Panel3.TabIndex = 6;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Location = new System.Drawing.Point(206, 66);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(132, 31);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 2;
			this.ButtonX1.Text = "ButtonX1";
			//
			//RadioButton4
			//
			this.RadioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton4.AutoSize = true;
			this.RadioButton4.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton4.ForeColor = System.Drawing.Color.White;
			this.RadioButton4.Location = new System.Drawing.Point(218, 33);
			this.RadioButton4.Name = "RadioButton4";
			this.RadioButton4.Size = new System.Drawing.Size(57, 31);
			this.RadioButton4.TabIndex = 4;
			this.RadioButton4.TabStop = true;
			this.RadioButton4.Text = "ກຸ່ມ";
			this.RadioButton4.UseVisualStyleBackColor = true;
			//
			//RadioButton2
			//
			this.RadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton2.ForeColor = System.Drawing.Color.White;
			this.RadioButton2.Location = new System.Drawing.Point(104, 33);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(42, 31);
			this.RadioButton2.TabIndex = 5;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "ຊື່";
			this.RadioButton2.UseVisualStyleBackColor = true;
			//
			//RadioButton3
			//
			this.RadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton3.AutoSize = true;
			this.RadioButton3.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton3.ForeColor = System.Drawing.Color.White;
			this.RadioButton3.Location = new System.Drawing.Point(273, 33);
			this.RadioButton3.Name = "RadioButton3";
			this.RadioButton3.Size = new System.Drawing.Size(84, 31);
			this.RadioButton3.TabIndex = 6;
			this.RadioButton3.TabStop = true;
			this.RadioButton3.Text = "ປະເພດ";
			this.RadioButton3.UseVisualStyleBackColor = true;
			//
			//RadioButton1
			//
			this.RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RadioButton1.ForeColor = System.Drawing.Color.White;
			this.RadioButton1.Location = new System.Drawing.Point(147, 33);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(79, 31);
			this.RadioButton1.TabIndex = 7;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "ລະຫັດ";
			this.RadioButton1.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(14, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(97, 27);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "ຄົ້ນຫາໂດຍ:";
			//
			//PictureBox1
			//
			this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PictureBox1.Location = new System.Drawing.Point(4, 4);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(229, 166);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(17, 173);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(97, 27);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "ຄົ້ນຫາໂດຍ:";
			//
			//TextBox2
			//
			this.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBox2.Location = new System.Drawing.Point(17, 199);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(202, 31);
			this.TextBox2.TabIndex = 9;
			//
			//TextBox3
			//
			this.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBox3.Location = new System.Drawing.Point(17, 260);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.Size = new System.Drawing.Size(202, 31);
			this.TextBox3.TabIndex = 10;
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(17, 233);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(97, 27);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "ຄົ້ນຫາໂດຍ:";
			//
			//TextBox4
			//
			this.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TextBox4.Location = new System.Drawing.Point(17, 320);
			this.TextBox4.Name = "TextBox4";
			this.TextBox4.Size = new System.Drawing.Size(202, 31);
			this.TextBox4.TabIndex = 12;
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(17, 294);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(97, 27);
			this.Label4.TabIndex = 13;
			this.Label4.Text = "ຄົ້ນຫາໂດຍ:";
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Location = new System.Drawing.Point(7, 358);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(226, 47);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.TabIndex = 14;
			this.ButtonX2.Text = "ຕົກລົງ";
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(659, 24);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(283, 23);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "ລາຍການທີ່ເລືອກ";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ButtonX3
			//
			this.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX3.Location = new System.Drawing.Point(7, 358);
			this.ButtonX3.Name = "ButtonX3";
			this.ButtonX3.Size = new System.Drawing.Size(83, 47);
			this.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX3.TabIndex = 15;
			this.ButtonX3.Text = "ຕົກລົງ";
			//
			//ButtonX4
			//
			this.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX4.Location = new System.Drawing.Point(100, 358);
			this.ButtonX4.Name = "ButtonX4";
			this.ButtonX4.Size = new System.Drawing.Size(83, 47);
			this.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX4.TabIndex = 16;
			this.ButtonX4.Text = "ຕົກລົງ";
			//
			//ButtonX5
			//
			this.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX5.Location = new System.Drawing.Point(189, 358);
			this.ButtonX5.Name = "ButtonX5";
			this.ButtonX5.Size = new System.Drawing.Size(83, 47);
			this.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX5.TabIndex = 17;
			this.ButtonX5.Text = "ຕົກລົງ";
			//
			//Label6
			//
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.Color.White;
			this.Label6.Location = new System.Drawing.Point(124, 320);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(56, 27);
			this.Label6.TabIndex = 18;
			this.Label6.Text = "ລວມ:";
			//
			//Label7
			//
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.White;
			this.Label7.Location = new System.Drawing.Point(186, 320);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(56, 27);
			this.Label7.TabIndex = 18;
			this.Label7.Text = "ລວມ:";
			//
			//Label8
			//
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label8.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label8.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.Color.White;
			this.Label8.Location = new System.Drawing.Point(409, 24);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(237, 23);
			this.Label8.TabIndex = 10;
			this.Label8.Text = "ຂໍ້ມູນ";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label9
			//
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label9.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label9.Font = new System.Drawing.Font("Phetsarath OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.ForeColor = System.Drawing.Color.White;
			this.Label9.Location = new System.Drawing.Point(35, 24);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(359, 23);
			this.Label9.TabIndex = 11;
			this.Label9.Text = "ເມນູອາຫານແລະເຄື່ອງດື່ມ";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//frm_OrderFood2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(983, 507);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Label5);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_OrderFood2";
			this.Text = "MetroForm";
			((System.ComponentModel.ISupportInitialize) this.DataGridViewX1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridViewX2).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal DevComponents.DotNetBar.Controls.DataGridViewX DataGridViewX1;
		internal Panel Panel2;
		internal DevComponents.DotNetBar.Controls.DataGridViewX DataGridViewX2;
		internal Panel Panel1;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal TextBox TextBox1;
		internal Panel Panel3;
		internal Label Label1;
		internal RadioButton RadioButton4;
		internal RadioButton RadioButton2;
		internal RadioButton RadioButton3;
		internal RadioButton RadioButton1;
		internal TextBox TextBox3;
		internal Label Label3;
		internal TextBox TextBox2;
		internal Label Label2;
		internal PictureBox PictureBox1;
		internal Label Label7;
		internal Label Label6;
		internal DevComponents.DotNetBar.ButtonX ButtonX5;
		internal DevComponents.DotNetBar.ButtonX ButtonX4;
		internal DevComponents.DotNetBar.ButtonX ButtonX3;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal Label Label4;
		internal TextBox TextBox4;
		internal Label Label5;
		internal Label Label8;
		internal Label Label9;
	}
	
}
