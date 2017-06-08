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
	
	partial class Onloading : System.Windows.Forms.Form
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
		internal System.Windows.Forms.Label ApplicationTitle;
		internal System.Windows.Forms.Label Version;
		internal System.Windows.Forms.Label Copyright;
		internal System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
		internal System.Windows.Forms.TableLayoutPanel DetailsLayoutPanel;
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.Load += new System.EventHandler(SplashScreen1_Load);
			this.MainLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainLayoutPanel_Paint);
			this.DetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.DetailsLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DetailsLayoutPanel_Paint);
			this.Version = new System.Windows.Forms.Label();
			this.Copyright = new System.Windows.Forms.Label();
			this.ApplicationTitle = new System.Windows.Forms.Label();
			this.ApplicationTitle.Click += new System.EventHandler(this.ApplicationTitle_Click);
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.MainLayoutPanel.SuspendLayout();
			this.DetailsLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//MainLayoutPanel
			//
			this.MainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MainLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.MainLayoutPanel.BackgroundImage = Properties.Resources._47f3f260e4441eb63a1dea83072648cf;
			this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MainLayoutPanel.ColumnCount = 2;
			this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (243.0F)));
			this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (100.0F)));
			this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
			this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 1, 0);
			this.MainLayoutPanel.Controls.Add(this.PictureBox1, 0, 0);
			this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainLayoutPanel.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.MainLayoutPanel.Name = "MainLayoutPanel";
			this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float) (218.0F)));
			this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (float) (38.0F)));
			this.MainLayoutPanel.Size = new System.Drawing.Size(496, 303);
			this.MainLayoutPanel.TabIndex = 0;
			//
			//DetailsLayoutPanel
			//
			this.DetailsLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.DetailsLayoutPanel.BackColor = System.Drawing.Color.Transparent;
			this.DetailsLayoutPanel.ColumnCount = 1;
			this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (247.0F)));
			this.DetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (float) (142.0F)));
			this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 0);
			this.DetailsLayoutPanel.Controls.Add(this.Copyright, 0, 1);
			this.DetailsLayoutPanel.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.DetailsLayoutPanel.Location = new System.Drawing.Point(246, 221);
			this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
			this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float) (33.0F)));
			this.DetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float) (33.0F)));
			this.DetailsLayoutPanel.Size = new System.Drawing.Size(247, 79);
			this.DetailsLayoutPanel.TabIndex = 1;
			//
			//Version
			//
			this.Version.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Version.BackColor = System.Drawing.Color.Transparent;
			this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Version.Location = new System.Drawing.Point(3, 9);
			this.Version.Name = "Version";
			this.Version.Size = new System.Drawing.Size(241, 20);
			this.Version.TabIndex = 1;
			this.Version.Text = "Version {0}.{1:00}";
			//
			//Copyright
			//
			this.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Copyright.BackColor = System.Drawing.Color.Transparent;
			this.Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (9.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Copyright.Location = new System.Drawing.Point(3, 39);
			this.Copyright.Name = "Copyright";
			this.Copyright.Size = new System.Drawing.Size(241, 40);
			this.Copyright.TabIndex = 2;
			this.Copyright.Text = "Copyright";
			//
			//ApplicationTitle
			//
			this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
			this.ApplicationTitle.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ApplicationTitle.Location = new System.Drawing.Point(246, 3);
			this.ApplicationTitle.Name = "ApplicationTitle";
			this.ApplicationTitle.Size = new System.Drawing.Size(247, 212);
			this.ApplicationTitle.TabIndex = 0;
			this.ApplicationTitle.Text = "ລະບົບບໍລິການຮ້ານອາຫານດາວລ້ອມເດຶອນ";
			this.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			//
			//PictureBox1
			//
			this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.Image = Properties.Resources.IMG_20161227_WA0000;
			this.PictureBox1.Location = new System.Drawing.Point(3, 3);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(237, 212);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 2;
			this.PictureBox1.TabStop = false;
			//
			//Onloading
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 303);
			this.ControlBox = false;
			this.Controls.Add(this.MainLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Onloading";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MainLayoutPanel.ResumeLayout(false);
			this.DetailsLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal PictureBox PictureBox1;
	}
	
}
