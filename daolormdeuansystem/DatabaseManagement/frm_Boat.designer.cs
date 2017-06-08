
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


namespace daolormdeuansystem
{
	
	partial class frm_Boat : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_Boat_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Boat));
			this.Label1 = new System.Windows.Forms.Label();
			this.txtBoatID = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtBoatName = new System.Windows.Forms.TextBox();
			this.btSave = new System.Windows.Forms.Button();
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			this.btEdit = new System.Windows.Forms.Button();
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
			this.btDelete = new System.Windows.Forms.Button();
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			this.btClear = new System.Windows.Forms.Button();
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			this.dgvboat = new System.Windows.Forms.DataGridView();
			this.dgvboat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoat_CellContentClick);
			this.dgvboat.Click += new System.EventHandler(this.dgvBoat_Click);
			this.btClose = new System.Windows.Forms.Button();
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Label5 = new System.Windows.Forms.Label();
			this.cbBoatType = new System.Windows.Forms.ComboBox();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.txtpicture = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.dgvboat).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(47, 17);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(82, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "ລະຫັດເຮືອ:";
			//
			//txtBoatID
			//
			this.txtBoatID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtBoatID.Location = new System.Drawing.Point(126, 14);
			this.txtBoatID.Name = "txtBoatID";
			this.txtBoatID.Size = new System.Drawing.Size(219, 31);
			this.txtBoatID.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(66, 57);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(61, 23);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "ປະເພດ:";
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(98, 96);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 23);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "ຊື່:";
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(56, 136);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(72, 23);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "ສະຖານະ:";
			//
			//txtBoatName
			//
			this.txtBoatName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtBoatName.Location = new System.Drawing.Point(126, 96);
			this.txtBoatName.Name = "txtBoatName";
			this.txtBoatName.Size = new System.Drawing.Size(219, 31);
			this.txtBoatName.TabIndex = 1;
			//
			//btSave
			//
			this.btSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btSave.ImageIndex = 5;
			this.btSave.ImageList = this.ImageList1;
			this.btSave.Location = new System.Drawing.Point(40, 212);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(91, 38);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "ບັນທຶກ";
			this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btSave.UseVisualStyleBackColor = true;
			//
			//btEdit
			//
			this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btEdit.ImageKey = "Save as-100.png";
			this.btEdit.ImageList = this.ImageList1;
			this.btEdit.Location = new System.Drawing.Point(137, 212);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(91, 38);
			this.btEdit.TabIndex = 2;
			this.btEdit.Text = "ແກ້ໃຂ";
			this.btEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btEdit.UseVisualStyleBackColor = true;
			//
			//btDelete
			//
			this.btDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btDelete.ImageKey = "Delete-100.png";
			this.btDelete.ImageList = this.ImageList1;
			this.btDelete.Location = new System.Drawing.Point(234, 212);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(91, 38);
			this.btDelete.TabIndex = 2;
			this.btDelete.Text = "ລົບ";
			this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btDelete.UseVisualStyleBackColor = true;
			//
			//btClear
			//
			this.btClear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btClear.ImageKey = "Broom-100 (1).png";
			this.btClear.ImageList = this.ImageList1;
			this.btClear.Location = new System.Drawing.Point(331, 212);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(91, 38);
			this.btClear.TabIndex = 2;
			this.btClear.Text = "ລ້າງ";
			this.btClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btClear.UseVisualStyleBackColor = true;
			//
			//dgvboat
			//
			this.dgvboat.AllowUserToAddRows = false;
			this.dgvboat.AllowUserToDeleteRows = false;
			DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(255)));
			this.dgvboat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvboat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvboat.BackgroundColor = System.Drawing.Color.Brown;
			this.dgvboat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvboat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvboat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvboat.Location = new System.Drawing.Point(0, 0);
			this.dgvboat.Name = "dgvboat";
			this.dgvboat.ReadOnly = true;
			this.dgvboat.RowHeadersWidth = 40;
			this.dgvboat.RowTemplate.Height = 50;
			this.dgvboat.Size = new System.Drawing.Size(603, 142);
			this.dgvboat.TabIndex = 3;
			//
			//btClose
			//
			this.btClose.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btClose.ImageKey = "Exit-100.png";
			this.btClose.ImageList = this.ImageList1;
			this.btClose.Location = new System.Drawing.Point(428, 212);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(91, 38);
			this.btClose.TabIndex = 2;
			this.btClose.Text = "ອອກ";
			this.btClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btClose.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Button1.ImageKey = "Add Image-100.png";
			this.Button1.ImageList = this.ImageList1;
			this.Button1.Location = new System.Drawing.Point(525, 212);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(118, 38);
			this.Button1.TabIndex = 5;
			this.Button1.Text = "ເລືອກຮູບ";
			this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(145, 7);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(676, 35);
			this.Label5.TabIndex = 6;
			this.Label5.Text = "ຈັດການຂໍ້ມູນເຮືອ";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//cbBoatType
			//
			this.cbBoatType.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbBoatType.FormattingEnabled = true;
			this.cbBoatType.Location = new System.Drawing.Point(126, 57);
			this.cbBoatType.Name = "cbBoatType";
			this.cbBoatType.Size = new System.Drawing.Size(219, 31);
			this.cbBoatType.TabIndex = 7;
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			//
			//txtpicture
			//
			this.txtpicture.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtpicture.Location = new System.Drawing.Point(126, 174);
			this.txtpicture.Name = "txtpicture";
			this.txtpicture.Size = new System.Drawing.Size(219, 31);
			this.txtpicture.TabIndex = 8;
			//
			//ComboBox1
			//
			this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {"ວ່າງ", "ບໍ່ວ່າງ", "ຈອງແລ້ວ"});
			this.ComboBox1.Location = new System.Drawing.Point(126, 136);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(219, 31);
			this.ComboBox1.TabIndex = 9;
			//
			//PictureBox1
			//
			this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBox1.InitialImage = Properties.Resources.IMG_20161210_WA0006;
			this.PictureBox1.Location = new System.Drawing.Point(359, 26);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(274, 166);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 4;
			this.PictureBox1.TabStop = false;
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
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel1.Controls.Add(this.dgvboat);
			this.Panel1.Location = new System.Drawing.Point(40, 256);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(603, 142);
			this.Panel1.TabIndex = 10;
			//
			//Panel2
			//
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel2.Controls.Add(this.Panel1);
			this.Panel2.Controls.Add(this.ComboBox1);
			this.Panel2.Controls.Add(this.txtpicture);
			this.Panel2.Controls.Add(this.cbBoatType);
			this.Panel2.Controls.Add(this.Button1);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Controls.Add(this.btClose);
			this.Panel2.Controls.Add(this.btClear);
			this.Panel2.Controls.Add(this.btDelete);
			this.Panel2.Controls.Add(this.btEdit);
			this.Panel2.Controls.Add(this.btSave);
			this.Panel2.Controls.Add(this.txtBoatName);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.txtBoatID);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Location = new System.Drawing.Point(145, 43);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(676, 414);
			this.Panel2.TabIndex = 11;
			//
			//Label6
			//
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.Color.White;
			this.Label6.Location = new System.Drawing.Point(43, 177);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(87, 23);
			this.Label6.TabIndex = 0;
			this.Label6.Text = "ເສັ້ນທາງຮູບ:";
			//
			//frm_Boat
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0006;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(966, 465);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Boat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ເພີ່ມຮູບ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize) this.dgvboat).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		internal Label Label1;
		internal TextBox txtBoatID;
		internal Label Label2;
		internal Label Label3;
		internal Label Label4;
		internal TextBox txtBoatName;
		internal Button btSave;
		internal Button btEdit;
		internal Button btDelete;
		internal Button btClear;
		internal DataGridView dgvboat;
		internal Button btClose;
		internal PictureBox PictureBox1;
		internal Button Button1;
		internal Label Label5;
		internal ComboBox cbBoatType;
		internal OpenFileDialog OpenFileDialog1;
		internal TextBox txtpicture;
		internal ComboBox ComboBox1;
		internal ImageList ImageList1;
		internal Panel Panel1;
		internal Panel Panel2;
		internal Label Label6;
	}
	
}
