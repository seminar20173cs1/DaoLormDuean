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
	
	partial class frm_Unit : System.Windows.Forms.Form
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
			this.dgvUnit = new System.Windows.Forms.DataGridView();
			base.Load += new System.EventHandler(frm_Unit_Load);
			this.dgvUnit.Click += new System.EventHandler(this.dgvUnit_Click);
			this.btExit = new System.Windows.Forms.Button();
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			this.btClear = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			this.btEdit = new System.Windows.Forms.Button();
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
			this.btSAve = new System.Windows.Forms.Button();
			this.btSAve.Click += new System.EventHandler(this.btSAve_Click);
			this.txtUnitName = new System.Windows.Forms.TextBox();
			this.txtUnitID = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.dgvUnit).BeginInit();
			this.SuspendLayout();
			//
			//dgvUnit
			//
			this.dgvUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvUnit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUnit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUnit.Location = new System.Drawing.Point(30, 214);
			this.dgvUnit.Name = "dgvUnit";
			this.dgvUnit.Size = new System.Drawing.Size(454, 154);
			this.dgvUnit.TabIndex = 17;
			//
			//btExit
			//
			this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btExit.Location = new System.Drawing.Point(403, 163);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(91, 31);
			this.btExit.TabIndex = 12;
			this.btExit.Text = "ອອກ";
			this.btExit.UseVisualStyleBackColor = true;
			//
			//btClear
			//
			this.btClear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btClear.Location = new System.Drawing.Point(306, 163);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(91, 31);
			this.btClear.TabIndex = 13;
			this.btClear.Text = "ລ້າງ";
			this.btClear.UseVisualStyleBackColor = true;
			//
			//btDelete
			//
			this.btDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btDelete.Location = new System.Drawing.Point(209, 163);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(91, 31);
			this.btDelete.TabIndex = 14;
			this.btDelete.Text = "ລົບ";
			this.btDelete.UseVisualStyleBackColor = true;
			//
			//btEdit
			//
			this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btEdit.Location = new System.Drawing.Point(112, 163);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(91, 31);
			this.btEdit.TabIndex = 15;
			this.btEdit.Text = "ແກ້ໄຂ";
			this.btEdit.UseVisualStyleBackColor = true;
			//
			//btSAve
			//
			this.btSAve.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btSAve.Location = new System.Drawing.Point(15, 163);
			this.btSAve.Name = "btSAve";
			this.btSAve.Size = new System.Drawing.Size(91, 31);
			this.btSAve.TabIndex = 16;
			this.btSAve.Text = "ບັນທຶກ";
			this.btSAve.UseVisualStyleBackColor = true;
			//
			//txtUnitName
			//
			this.txtUnitName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUnitName.Location = new System.Drawing.Point(168, 85);
			this.txtUnitName.Name = "txtUnitName";
			this.txtUnitName.Size = new System.Drawing.Size(219, 31);
			this.txtUnitName.TabIndex = 10;
			//
			//txtUnitID
			//
			this.txtUnitID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtUnitID.Location = new System.Drawing.Point(168, 45);
			this.txtUnitID.Name = "txtUnitID";
			this.txtUnitID.Size = new System.Drawing.Size(219, 31);
			this.txtUnitID.TabIndex = 11;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(84, 88);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(75, 23);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "ຊື່່ຫົວໜ່ວຍ:";
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(99, 53);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(51, 23);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "ລະຫັດ:";
			//
			//frm_Unit
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 380);
			this.Controls.Add(this.dgvUnit);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btEdit);
			this.Controls.Add(this.btSAve);
			this.Controls.Add(this.txtUnitName);
			this.Controls.Add(this.txtUnitID);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Unit";
			this.Text = "frm_Unit";
			((System.ComponentModel.ISupportInitialize) this.dgvUnit).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DataGridView dgvUnit;
		internal Button btExit;
		internal Button btClear;
		internal Button btDelete;
		internal Button btEdit;
		internal Button btSAve;
		internal TextBox txtUnitName;
		internal TextBox txtUnitID;
		internal Label Label2;
		internal Label Label1;
	}
	
}
