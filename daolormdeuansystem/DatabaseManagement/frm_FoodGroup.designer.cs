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
	
	partial class frm_FoodGroup : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_FoodGroup_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FoodGroup));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.btClear = new System.Windows.Forms.Button();
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btExit = new System.Windows.Forms.Button();
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			this.btDelete = new System.Windows.Forms.Button();
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			this.btEdit = new System.Windows.Forms.Button();
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
			this.btSave = new System.Windows.Forms.Button();
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtDEs = new System.Windows.Forms.RichTextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.dgvFoodType = new DevComponents.DotNetBar.Controls.DataGridViewX();
			this.dgvFoodType.Click += new System.EventHandler(this.dgvFoodType_Click);
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvFoodType).BeginInit();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(49, 47);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(560, 369);
			this.TabControl1.TabIndex = 6;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.btClear);
			this.TabPage1.Controls.Add(this.btExit);
			this.TabPage1.Controls.Add(this.btDelete);
			this.TabPage1.Controls.Add(this.btEdit);
			this.TabPage1.Controls.Add(this.btSave);
			this.TabPage1.Controls.Add(this.GroupBox1);
			this.TabPage1.Location = new System.Drawing.Point(4, 32);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(552, 333);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "ຈັດການຂໍ້ມູນກຸ່ມອາຫານ";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//btClear
			//
			this.btClear.ImageKey = "Broom-100 (1).png";
			this.btClear.ImageList = this.ImageList1;
			this.btClear.Location = new System.Drawing.Point(332, 279);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(97, 36);
			this.btClear.TabIndex = 5;
			this.btClear.Text = "ລ້າງ";
			this.btClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btClear.UseVisualStyleBackColor = true;
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
			//btExit
			//
			this.btExit.ImageKey = "Exit-100.png";
			this.btExit.ImageList = this.ImageList1;
			this.btExit.Location = new System.Drawing.Point(443, 279);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(89, 36);
			this.btExit.TabIndex = 5;
			this.btExit.Text = "ອອກ";
			this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btExit.UseVisualStyleBackColor = true;
			//
			//btDelete
			//
			this.btDelete.ImageKey = "Delete-100.png";
			this.btDelete.ImageList = this.ImageList1;
			this.btDelete.Location = new System.Drawing.Point(234, 279);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(84, 36);
			this.btDelete.TabIndex = 5;
			this.btDelete.Text = "ລົບ";
			this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btDelete.UseVisualStyleBackColor = true;
			//
			//btEdit
			//
			this.btEdit.ImageKey = "Save as-100.png";
			this.btEdit.ImageList = this.ImageList1;
			this.btEdit.Location = new System.Drawing.Point(125, 279);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(95, 36);
			this.btEdit.TabIndex = 5;
			this.btEdit.Text = "ແກ້ໃຂ";
			this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btEdit.UseVisualStyleBackColor = true;
			//
			//btSave
			//
			this.btSave.ImageKey = "Save-100 (1).png";
			this.btSave.ImageList = this.ImageList1;
			this.btSave.Location = new System.Drawing.Point(21, 279);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(90, 36);
			this.btSave.TabIndex = 5;
			this.btSave.Text = "ບັນທຶກ";
			this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btSave.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtDEs);
			this.GroupBox1.Controls.Add(this.txtID);
			this.GroupBox1.Controls.Add(this.txtName);
			this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.GroupBox1.Location = new System.Drawing.Point(97, 19);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(369, 240);
			this.GroupBox1.TabIndex = 4;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "ກຸ່ມອາຫານ";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(55, 126);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(81, 23);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "ຄໍາອະທິບາຍ:";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(92, 89);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(44, 23);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "ຊື່ກຸ່ມ:";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(23, 52);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(113, 23);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "ລະຫັດກຸ່ມອາຫານ:";
			//
			//txtDEs
			//
			this.txtDEs.Location = new System.Drawing.Point(147, 123);
			this.txtDEs.Name = "txtDEs";
			this.txtDEs.Size = new System.Drawing.Size(199, 96);
			this.txtDEs.TabIndex = 5;
			this.txtDEs.Text = "";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(147, 49);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(199, 31);
			this.txtID.TabIndex = 3;
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(147, 86);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(199, 31);
			this.txtName.TabIndex = 4;
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.dgvFoodType);
			this.TabPage2.Location = new System.Drawing.Point(4, 32);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(552, 333);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "ເບິ່ງຂໍ້ມູນ";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//dgvFoodType
			//
			this.dgvFoodType.AllowUserToAddRows = false;
			this.dgvFoodType.AllowUserToDeleteRows = false;
			this.dgvFoodType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvFoodType.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFoodType.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvFoodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvFoodType.DefaultCellStyle = DataGridViewCellStyle2;
			this.dgvFoodType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFoodType.EnableHeadersVisualStyles = false;
			this.dgvFoodType.GridColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)), System.Convert.ToInt32(System.Convert.ToByte(170)));
			this.dgvFoodType.Location = new System.Drawing.Point(3, 3);
			this.dgvFoodType.Name = "dgvFoodType";
			this.dgvFoodType.ReadOnly = true;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvFoodType.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
			this.dgvFoodType.Size = new System.Drawing.Size(546, 327);
			this.dgvFoodType.TabIndex = 5;
			//
			//frm_FoodGroup
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(672, 449);
			this.Controls.Add(this.TabControl1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_FoodGroup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_FoodGroup";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvFoodType).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal TabControl TabControl1;
		internal TabPage TabPage1;
		internal Button btClear;
		internal Button btExit;
		internal Button btDelete;
		internal Button btEdit;
		internal Button btSave;
		internal GroupBox GroupBox1;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal RichTextBox txtDEs;
		internal TextBox txtID;
		internal TextBox txtName;
		internal TabPage TabPage2;
		internal DevComponents.DotNetBar.Controls.DataGridViewX dgvFoodType;
		internal ImageList ImageList1;
	}
	
}
