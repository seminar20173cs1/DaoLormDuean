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
	
	partial class frm_BoatType : System.Windows.Forms.Form
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtDEs = new System.Windows.Forms.RichTextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btClear = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.btEdit = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GroupBox1.Controls.Add(this.btClear);
			this.GroupBox1.Controls.Add(this.btExit);
			this.GroupBox1.Controls.Add(this.btDelete);
			this.GroupBox1.Controls.Add(this.btEdit);
			this.GroupBox1.Controls.Add(this.btSave);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtDEs);
			this.GroupBox1.Controls.Add(this.txtID);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.GroupBox1.Location = new System.Drawing.Point(42, 39);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new System.Drawing.Size(554, 349);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "ປະເພດອາຫານ";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(131, 128);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(81, 23);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "ຄໍາອະທິບາຍ:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(148, 89);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(64, 23);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "ຊື່ປະເພດ:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(97, 43);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(115, 23);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "ລະຫັດປະເພດເຮືອ:";
			//
			//txtDEs
			//
			this.txtDEs.Location = new System.Drawing.Point(220, 127);
			this.txtDEs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDEs.Name = "txtDEs";
			this.txtDEs.Size = new System.Drawing.Size(296, 167);
			this.txtDEs.TabIndex = 5;
			this.txtDEs.Text = "";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(220, 45);
			this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(296, 31);
			this.txtID.TabIndex = 3;
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(220, 86);
			this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(296, 31);
			this.txtName.TabIndex = 4;
			//
			//btClear
			//
			this.btClear.ImageKey = "Broom-100 (1).png";
			this.btClear.Location = new System.Drawing.Point(342, 302);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(97, 36);
			this.btClear.TabIndex = 9;
			this.btClear.Text = "ລ້າງ";
			this.btClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btClear.UseVisualStyleBackColor = true;
			//
			//btExit
			//
			this.btExit.ImageKey = "Exit-100.png";
			this.btExit.Location = new System.Drawing.Point(453, 302);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(89, 36);
			this.btExit.TabIndex = 10;
			this.btExit.Text = "ອອກ";
			this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btExit.UseVisualStyleBackColor = true;
			//
			//btDelete
			//
			this.btDelete.ImageKey = "Delete-100.png";
			this.btDelete.Location = new System.Drawing.Point(244, 302);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(84, 36);
			this.btDelete.TabIndex = 11;
			this.btDelete.Text = "ລົບ";
			this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btDelete.UseVisualStyleBackColor = true;
			//
			//btEdit
			//
			this.btEdit.ImageKey = "Save as-100.png";
			this.btEdit.Location = new System.Drawing.Point(135, 302);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(95, 36);
			this.btEdit.TabIndex = 12;
			this.btEdit.Text = "ແກ້ໃຂ";
			this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btEdit.UseVisualStyleBackColor = true;
			//
			//btSave
			//
			this.btSave.ImageKey = "Save-100 (1).png";
			this.btSave.Location = new System.Drawing.Point(31, 302);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(90, 36);
			this.btSave.TabIndex = 13;
			this.btSave.Text = "ບັນທຶກ";
			this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btSave.UseVisualStyleBackColor = true;
			//
			//frm_BoatType
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0006;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(644, 435);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_BoatType";
			this.Text = "frm_BoatType";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox1;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal RichTextBox txtDEs;
		internal TextBox txtID;
		internal TextBox txtName;
		internal Button btClear;
		internal Button btExit;
		internal Button btDelete;
		internal Button btEdit;
		internal Button btSave;
	}
	
}
