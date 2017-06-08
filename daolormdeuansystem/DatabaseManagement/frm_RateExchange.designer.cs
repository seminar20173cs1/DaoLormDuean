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
	
	partial class frm_RateExchange : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frm_RateExchange_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RateExchange));
			this.dgvRate = new System.Windows.Forms.DataGridView();
			this.dgvRate.Click += new System.EventHandler(this.dgvRate_Click);
			this.btExit = new System.Windows.Forms.Button();
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			this.btClear = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			this.btEdit = new System.Windows.Forms.Button();
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
			this.btSave = new System.Windows.Forms.Button();
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			this.txtCurrency = new System.Windows.Forms.TextBox();
			this.txtRateID = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtRate = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label4 = new System.Windows.Forms.Label();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize) this.dgvRate).BeginInit();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//dgvRate
			//
			this.dgvRate.AllowUserToAddRows = false;
			this.dgvRate.AllowUserToDeleteRows = false;
			this.dgvRate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvRate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRate.Location = new System.Drawing.Point(53, 193);
			this.dgvRate.Name = "dgvRate";
			this.dgvRate.ReadOnly = true;
			this.dgvRate.Size = new System.Drawing.Size(454, 168);
			this.dgvRate.TabIndex = 27;
			//
			//btExit
			//
			this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btExit.ImageKey = "Exit-100.png";
			this.btExit.ImageList = this.ImageList1;
			this.btExit.Location = new System.Drawing.Point(421, 150);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(91, 37);
			this.btExit.TabIndex = 22;
			this.btExit.Text = "ອອກ";
			this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btExit.UseVisualStyleBackColor = true;
			//
			//btClear
			//
			this.btClear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btClear.ImageKey = "Broom-100 (1).png";
			this.btClear.ImageList = this.ImageList1;
			this.btClear.Location = new System.Drawing.Point(324, 150);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(91, 37);
			this.btClear.TabIndex = 23;
			this.btClear.Text = "ລ້າງ";
			this.btClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btClear.UseVisualStyleBackColor = true;
			//
			//btDelete
			//
			this.btDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btDelete.ImageKey = "Delete-100.png";
			this.btDelete.ImageList = this.ImageList1;
			this.btDelete.Location = new System.Drawing.Point(227, 150);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(91, 37);
			this.btDelete.TabIndex = 24;
			this.btDelete.Text = "ລົບ";
			this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btDelete.UseVisualStyleBackColor = true;
			//
			//btEdit
			//
			this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btEdit.ImageKey = "Save as-100.png";
			this.btEdit.ImageList = this.ImageList1;
			this.btEdit.Location = new System.Drawing.Point(130, 150);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(91, 37);
			this.btEdit.TabIndex = 25;
			this.btEdit.Text = "ແກ້ໄຂ";
			this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btEdit.UseVisualStyleBackColor = true;
			//
			//btSave
			//
			this.btSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btSave.ImageKey = "Save-100 (1).png";
			this.btSave.ImageList = this.ImageList1;
			this.btSave.Location = new System.Drawing.Point(33, 150);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(91, 37);
			this.btSave.TabIndex = 26;
			this.btSave.Text = "ບັນທືກ";
			this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btSave.UseVisualStyleBackColor = true;
			//
			//txtCurrency
			//
			this.txtCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCurrency.Location = new System.Drawing.Point(209, 67);
			this.txtCurrency.Name = "txtCurrency";
			this.txtCurrency.Size = new System.Drawing.Size(219, 31);
			this.txtCurrency.TabIndex = 20;
			//
			//txtRateID
			//
			this.txtRateID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtRateID.Location = new System.Drawing.Point(209, 27);
			this.txtRateID.Name = "txtRateID";
			this.txtRateID.Size = new System.Drawing.Size(219, 31);
			this.txtRateID.TabIndex = 21;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(143, 70);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(55, 23);
			this.Label2.TabIndex = 18;
			this.Label2.Text = "ເງິນຕາ:";
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(49, 30);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(153, 23);
			this.Label1.TabIndex = 19;
			this.Label1.Text = "ລະຫັດອັດຕາແລກປ່ຽນ:";
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(91, 107);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(112, 23);
			this.Label3.TabIndex = 18;
			this.Label3.Text = "ອັດຕາແລກປ່ຽນ:";
			//
			//txtRate
			//
			this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtRate.Location = new System.Drawing.Point(209, 104);
			this.txtRate.Name = "txtRate";
			this.txtRate.Size = new System.Drawing.Size(219, 31);
			this.txtRate.TabIndex = 20;
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.Controls.Add(this.dgvRate);
			this.Panel1.Controls.Add(this.btExit);
			this.Panel1.Controls.Add(this.btClear);
			this.Panel1.Controls.Add(this.btDelete);
			this.Panel1.Controls.Add(this.btEdit);
			this.Panel1.Controls.Add(this.btSave);
			this.Panel1.Controls.Add(this.txtRate);
			this.Panel1.Controls.Add(this.txtCurrency);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.txtRateID);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Location = new System.Drawing.Point(85, 55);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(545, 416);
			this.Panel1.TabIndex = 28;
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.BackColor = System.Drawing.Color.Black;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(85, 9);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(545, 45);
			this.Label4.TabIndex = 28;
			this.Label4.Text = "ຈັດການຂໍ້ມູນອັດຕາແລກປ່ຽນ";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ImageList1
			//
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "Add Image-100.png");
			this.ImageList1.Images.SetKeyName(1, "Broom-100 (1).png");
			this.ImageList1.Images.SetKeyName(2, "Delete-100.png");
			this.ImageList1.Images.SetKeyName(3, "Exit-100.png");
			this.ImageList1.Images.SetKeyName(4, "Save as-100.png");
			this.ImageList1.Images.SetKeyName(5, "Save-100 (1).png");
			//
			//frm_RateExchange
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.FB_IMG_1477753237752;
			this.ClientSize = new System.Drawing.Size(739, 482);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_RateExchange";
			this.Text = "frm_RateExchange";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize) this.dgvRate).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		internal DataGridView dgvRate;
		internal Button btExit;
		internal Button btClear;
		internal Button btDelete;
		internal Button btEdit;
		internal Button btSave;
		internal TextBox txtCurrency;
		internal TextBox txtRateID;
		internal Label Label2;
		internal Label Label1;
		internal Label Label3;
		internal TextBox txtRate;
		internal Panel Panel1;
		internal Label Label4;
		internal ImageList ImageList1;
	}
	
}
