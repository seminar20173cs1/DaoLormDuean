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
	
		public partial class frm_food : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frm_Food_Load);
			base.Click += new System.EventHandler(btSave1_Click);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_food));
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.dgvEmployee = new System.Windows.Forms.DataGridView();
			this.dgvEmployee.Click += new System.EventHandler(this.dgvEmployee_Click_1);
			this.dgvEmployee.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_CellMouseDoubleClick);
			this.cbUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.ComboItem1 = new DevComponents.Editors.ComboItem();
			this.ComboItem2 = new DevComponents.Editors.ComboItem();
			this.ComboItem3 = new DevComponents.Editors.ComboItem();
			this.ComboItem4 = new DevComponents.Editors.ComboItem();
			this.ComboItem5 = new DevComponents.Editors.ComboItem();
			this.cbfoodGroup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.ComboItem11 = new DevComponents.Editors.ComboItem();
			this.ComboItem12 = new DevComponents.Editors.ComboItem();
			this.ComboItem13 = new DevComponents.Editors.ComboItem();
			this.ComboItem14 = new DevComponents.Editors.ComboItem();
			this.ComboItem15 = new DevComponents.Editors.ComboItem();
			this.cbFoodType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.ComboItem6 = new DevComponents.Editors.ComboItem();
			this.ComboItem7 = new DevComponents.Editors.ComboItem();
			this.ComboItem8 = new DevComponents.Editors.ComboItem();
			this.ComboItem9 = new DevComponents.Editors.ComboItem();
			this.ComboItem10 = new DevComponents.Editors.ComboItem();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ptbProfile = new System.Windows.Forms.PictureBox();
			this.ptbProfile.Click += new System.EventHandler(this.ptbProfile_Click_1);
			this.ButtonX1 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
			this.btEdit1 = new DevComponents.DotNetBar.ButtonX();
			this.btEdit1.Click += new System.EventHandler(this.btEdit1_Click);
			this.btClear1 = new DevComponents.DotNetBar.ButtonX();
			this.btClear1.Click += new System.EventHandler(this.btClear1_Click);
			this.btDelete1 = new DevComponents.DotNetBar.ButtonX();
			this.btDelete1.Click += new System.EventHandler(this.btDelete1_Click);
			this.btExit1 = new DevComponents.DotNetBar.ButtonX();
			this.btExit1.Click += new System.EventHandler(this.btExit1_Click);
			this.btChoos1 = new DevComponents.DotNetBar.ButtonX();
			this.btChoos1.Click += new System.EventHandler(this.btChoos1_Click);
			this.pnbt = new System.Windows.Forms.Panel();
			this.ButtonX2 = new DevComponents.DotNetBar.ButtonX();
			this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
			this.txtPath1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtPrice1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtID1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtName1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.TabControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvEmployee).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ptbProfile).BeginInit();
			this.pnbt.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			//
			//TabControl1
			//
			this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(936, 464);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(10, 10);
			this.TabControl1.TabIndex = 22;
			//
			//TabPage1
			//
			this.TabPage1.Location = new System.Drawing.Point(4, 32);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(2, 0);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "ຈັດການຂໍ້ມູອາຫານ";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//TabPage2
			//
			this.TabPage2.Location = new System.Drawing.Point(4, 32);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(2, 0);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "ເບິ່ງຂໍ້ມູນ";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			//
			//dgvEmployee
			//
			this.dgvEmployee.AllowUserToAddRows = false;
			this.dgvEmployee.AllowUserToDeleteRows = false;
			DataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.dgvEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEmployee.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEmployee.GridColor = System.Drawing.Color.Blue;
			this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
			this.dgvEmployee.Name = "dgvEmployee";
			this.dgvEmployee.ReadOnly = true;
			this.dgvEmployee.RowTemplate.Height = 30;
			this.dgvEmployee.Size = new System.Drawing.Size(947, 19);
			this.dgvEmployee.TabIndex = 19;
			//
			//cbUnit
			//
			this.cbUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbUnit.DisplayMember = "Text";
			this.cbUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbUnit.ForeColor = System.Drawing.Color.Black;
			this.cbUnit.FormattingEnabled = true;
			this.cbUnit.ItemHeight = 26;
			this.cbUnit.Items.AddRange(new object[] {this.ComboItem1, this.ComboItem2, this.ComboItem3, this.ComboItem4, this.ComboItem5});
			this.cbUnit.Location = new System.Drawing.Point(271, 236);
			this.cbUnit.Name = "cbUnit";
			this.cbUnit.Size = new System.Drawing.Size(219, 32);
			this.cbUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbUnit.TabIndex = 95;
			//
			//ComboItem1
			//
			this.ComboItem1.Text = "ComboItem1";
			//
			//ComboItem2
			//
			this.ComboItem2.Text = "ComboItem2";
			//
			//ComboItem3
			//
			this.ComboItem3.Text = "ComboItem3";
			//
			//ComboItem4
			//
			this.ComboItem4.Text = "ComboItem4";
			//
			//ComboItem5
			//
			this.ComboItem5.Text = "ComboItem5";
			//
			//cbfoodGroup
			//
			this.cbfoodGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbfoodGroup.DisplayMember = "Text";
			this.cbfoodGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbfoodGroup.ForeColor = System.Drawing.Color.Black;
			this.cbfoodGroup.FormattingEnabled = true;
			this.cbfoodGroup.ItemHeight = 26;
			this.cbfoodGroup.Items.AddRange(new object[] {this.ComboItem11, this.ComboItem12, this.ComboItem13, this.ComboItem14, this.ComboItem15});
			this.cbfoodGroup.Location = new System.Drawing.Point(271, 161);
			this.cbfoodGroup.Name = "cbfoodGroup";
			this.cbfoodGroup.Size = new System.Drawing.Size(219, 32);
			this.cbfoodGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbfoodGroup.TabIndex = 77;
			//
			//ComboItem11
			//
			this.ComboItem11.Text = "ComboItem1";
			//
			//ComboItem12
			//
			this.ComboItem12.Text = "ComboItem2";
			//
			//ComboItem13
			//
			this.ComboItem13.Text = "ComboItem3";
			//
			//ComboItem14
			//
			this.ComboItem14.Text = "ComboItem4";
			//
			//ComboItem15
			//
			this.ComboItem15.Text = "ComboItem5";
			//
			//cbFoodType
			//
			this.cbFoodType.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbFoodType.DisplayMember = "Text";
			this.cbFoodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbFoodType.ForeColor = System.Drawing.Color.Black;
			this.cbFoodType.FormattingEnabled = true;
			this.cbFoodType.ItemHeight = 26;
			this.cbFoodType.Items.AddRange(new object[] {this.ComboItem6, this.ComboItem7, this.ComboItem8, this.ComboItem9, this.ComboItem10});
			this.cbFoodType.Location = new System.Drawing.Point(271, 119);
			this.cbFoodType.Name = "cbFoodType";
			this.cbFoodType.Size = new System.Drawing.Size(219, 32);
			this.cbFoodType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbFoodType.TabIndex = 76;
			//
			//ComboItem6
			//
			this.ComboItem6.Text = "ComboItem1";
			//
			//ComboItem7
			//
			this.ComboItem7.Text = "ComboItem2";
			//
			//ComboItem8
			//
			this.ComboItem8.Text = "ComboItem3";
			//
			//ComboItem9
			//
			this.ComboItem9.Text = "ComboItem4";
			//
			//ComboItem10
			//
			this.ComboItem10.Text = "ComboItem5";
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.White;
			this.Label5.Location = new System.Drawing.Point(5, 252);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(160, 23);
			this.Label5.TabIndex = 87;
			this.Label5.Text = "ເສັ້ນທາງຂອງຮູບອາຫານ:";
			//
			//Label11
			//
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label11.AutoSize = true;
			this.Label11.BackColor = System.Drawing.Color.Transparent;
			this.Label11.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11.ForeColor = System.Drawing.Color.White;
			this.Label11.Location = new System.Drawing.Point(82, 173);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(72, 23);
			this.Label11.TabIndex = 88;
			this.Label11.Text = "ຫົວໜ່ວຍ:";
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.Location = new System.Drawing.Point(84, 138);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(71, 23);
			this.Label4.TabIndex = 86;
			this.Label4.Text = "ຊື່ອາຫານ:";
			//
			//Label9
			//
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.Color.Transparent;
			this.Label9.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.ForeColor = System.Drawing.Color.White;
			this.Label9.Location = new System.Drawing.Point(104, 214);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(49, 23);
			this.Label9.TabIndex = 90;
			this.Label9.Text = "ລາຄາ:";
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.Location = new System.Drawing.Point(72, 98);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(84, 23);
			this.Label3.TabIndex = 89;
			this.Label3.Text = "ກຸ່ມອາຫານ:";
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(52, 59);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(107, 23);
			this.Label2.TabIndex = 91;
			this.Label2.Text = "ປະເພດອາຫານ:";
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(56, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(102, 23);
			this.Label1.TabIndex = 92;
			this.Label1.Text = "ລະຫັດອາຫານ:";
			//
			//ptbProfile
			//
			this.ptbProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ptbProfile.BackColor = System.Drawing.Color.Transparent;
			this.ptbProfile.Location = new System.Drawing.Point(528, 64);
			this.ptbProfile.Name = "ptbProfile";
			this.ptbProfile.Size = new System.Drawing.Size(304, 313);
			this.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbProfile.TabIndex = 94;
			this.ptbProfile.TabStop = false;
			//
			//ButtonX1
			//
			this.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX1.Image = Properties.Resources.Save_100__1_;
			this.ButtonX1.ImageFixedSize = new System.Drawing.Size(32, 32);
			this.ButtonX1.Location = new System.Drawing.Point(42, 11);
			this.ButtonX1.Name = "ButtonX1";
			this.ButtonX1.Size = new System.Drawing.Size(85, 35);
			this.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX1.TabIndex = 96;
			this.ButtonX1.Text = "ບັນທຶກ";
			//
			//btEdit1
			//
			this.btEdit1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btEdit1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btEdit1.Image = Properties.Resources.Save_as_100;
			this.btEdit1.ImageFixedSize = new System.Drawing.Size(32, 32);
			this.btEdit1.Location = new System.Drawing.Point(133, 11);
			this.btEdit1.Name = "btEdit1";
			this.btEdit1.Size = new System.Drawing.Size(85, 35);
			this.btEdit1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btEdit1.TabIndex = 96;
			this.btEdit1.Text = "ແກ້ໃຂ";
			//
			//btClear1
			//
			this.btClear1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btClear1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btClear1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btClear1.Image = Properties.Resources.Broom_100__1_;
			this.btClear1.ImageFixedSize = new System.Drawing.Size(32, 32);
			this.btClear1.Location = new System.Drawing.Point(315, 11);
			this.btClear1.Name = "btClear1";
			this.btClear1.Size = new System.Drawing.Size(85, 35);
			this.btClear1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btClear1.TabIndex = 96;
			this.btClear1.Text = "ລ້າງ";
			//
			//btDelete1
			//
			this.btDelete1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btDelete1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btDelete1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btDelete1.Image = Properties.Resources.Delete_100;
			this.btDelete1.ImageFixedSize = new System.Drawing.Size(32, 32);
			this.btDelete1.Location = new System.Drawing.Point(224, 11);
			this.btDelete1.Name = "btDelete1";
			this.btDelete1.Size = new System.Drawing.Size(85, 35);
			this.btDelete1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btDelete1.TabIndex = 96;
			this.btDelete1.Text = "ລົບ";
			//
			//btExit1
			//
			this.btExit1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btExit1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btExit1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btExit1.Image = Properties.Resources.Exit_100;
			this.btExit1.ImageFixedSize = new System.Drawing.Size(32, 32);
			this.btExit1.Location = new System.Drawing.Point(406, 11);
			this.btExit1.Name = "btExit1";
			this.btExit1.Size = new System.Drawing.Size(85, 35);
			this.btExit1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btExit1.TabIndex = 96;
			this.btExit1.Text = "ອອກ";
			//
			//btChoos1
			//
			this.btChoos1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btChoos1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btChoos1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btChoos1.Font = new System.Drawing.Font("Phetsarath OT", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btChoos1.Image = Properties.Resources.Add_Image_100;
			this.btChoos1.ImageFixedSize = new System.Drawing.Size(32, 32);
			this.btChoos1.Location = new System.Drawing.Point(497, 11);
			this.btChoos1.Name = "btChoos1";
			this.btChoos1.Size = new System.Drawing.Size(85, 35);
			this.btChoos1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btChoos1.TabIndex = 96;
			this.btChoos1.Text = "ເລືອກຮູບ";
			//
			//pnbt
			//
			this.pnbt.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pnbt.Controls.Add(this.ButtonX2);
			this.pnbt.Controls.Add(this.btDelete1);
			this.pnbt.Controls.Add(this.btChoos1);
			this.pnbt.Controls.Add(this.btExit1);
			this.pnbt.Controls.Add(this.btClear1);
			this.pnbt.Controls.Add(this.btEdit1);
			this.pnbt.Controls.Add(this.ButtonX1);
			this.pnbt.Location = new System.Drawing.Point(118, 428);
			this.pnbt.Name = "pnbt";
			this.pnbt.Size = new System.Drawing.Size(714, 57);
			this.pnbt.TabIndex = 97;
			//
			//ButtonX2
			//
			this.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.ButtonX2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.ButtonX2.Font = new System.Drawing.Font("Phetsarath OT", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ButtonX2.Image = Properties.Resources.Day_View_100;
			this.ButtonX2.ImageFixedSize = new System.Drawing.Size(32, 32);
			this.ButtonX2.Location = new System.Drawing.Point(588, 11);
			this.ButtonX2.Name = "ButtonX2";
			this.ButtonX2.Size = new System.Drawing.Size(85, 35);
			this.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ButtonX2.TabIndex = 97;
			this.ButtonX2.Text = "ເບິ່ງຂໍ້ມູນ";
			//
			//txtPath1
			//
			this.txtPath1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPath1.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtPath1.Border.Class = "TextBoxBorder";
			this.txtPath1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtPath1.DisabledBackColor = System.Drawing.Color.White;
			this.txtPath1.ForeColor = System.Drawing.Color.Black;
			this.txtPath1.Location = new System.Drawing.Point(271, 313);
			this.txtPath1.Name = "txtPath1";
			this.txtPath1.PreventEnterBeep = true;
			this.txtPath1.Size = new System.Drawing.Size(219, 31);
			this.txtPath1.TabIndex = 98;
			this.txtPath1.WatermarkText = "ເສັ້ນທາງພາບ";
			//
			//txtPrice1
			//
			this.txtPrice1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrice1.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtPrice1.Border.Class = "TextBoxBorder";
			this.txtPrice1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtPrice1.DisabledBackColor = System.Drawing.Color.White;
			this.txtPrice1.ForeColor = System.Drawing.Color.Black;
			this.txtPrice1.Location = new System.Drawing.Point(271, 275);
			this.txtPrice1.Name = "txtPrice1";
			this.txtPrice1.PreventEnterBeep = true;
			this.txtPrice1.Size = new System.Drawing.Size(219, 31);
			this.txtPrice1.TabIndex = 98;
			this.txtPrice1.WatermarkText = "ປ້ອນລາຄາ";
			//
			//txtID1
			//
			this.txtID1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtID1.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtID1.Border.Class = "TextBoxBorder";
			this.txtID1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtID1.DisabledBackColor = System.Drawing.Color.White;
			this.txtID1.ForeColor = System.Drawing.Color.Black;
			this.txtID1.Location = new System.Drawing.Point(271, 80);
			this.txtID1.Name = "txtID1";
			this.txtID1.PreventEnterBeep = true;
			this.txtID1.Size = new System.Drawing.Size(219, 31);
			this.txtID1.TabIndex = 98;
			//
			//txtName1
			//
			this.txtName1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtName1.BackColor = System.Drawing.Color.White;
			//
			//
			//
			this.txtName1.Border.Class = "TextBoxBorder";
			this.txtName1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtName1.DisabledBackColor = System.Drawing.Color.White;
			this.txtName1.ForeColor = System.Drawing.Color.Black;
			this.txtName1.Location = new System.Drawing.Point(271, 199);
			this.txtName1.Name = "txtName1";
			this.txtName1.PreventEnterBeep = true;
			this.txtName1.Size = new System.Drawing.Size(219, 31);
			this.txtName1.TabIndex = 98;
			this.txtName1.WatermarkText = "ປ້ອນຊື່ອາຫານ";
			//
			//Panel2
			//
			this.Panel2.Controls.Add(this.dgvEmployee);
			this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(947, 19);
			this.Panel2.TabIndex = 99;
			//
			//Panel3
			//
			this.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Panel3.Controls.Add(this.Label5);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Controls.Add(this.Label11);
			this.Panel3.Controls.Add(this.Label9);
			this.Panel3.Controls.Add(this.Label4);
			this.Panel3.Controls.Add(this.Label2);
			this.Panel3.Controls.Add(this.Label3);
			this.Panel3.Location = new System.Drawing.Point(115, 64);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(389, 313);
			this.Panel3.TabIndex = 100;
			//
			//Label6
			//
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label6.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label6.ForeColor = System.Drawing.Color.White;
			this.Label6.Location = new System.Drawing.Point(118, 394);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(714, 33);
			this.Label6.TabIndex = 101;
			this.Label6.Text = "ຕົວເລືອກ:";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label7
			//
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label7.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label7.ForeColor = System.Drawing.Color.White;
			this.Label7.Location = new System.Drawing.Point(114, 31);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(390, 33);
			this.Label7.TabIndex = 102;
			this.Label7.Text = "ປ້ອນຂໍ້ມູນອາຫານແລະເຄື່ອງດື່ມ:";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label8
			//
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label8.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label8.ForeColor = System.Drawing.Color.White;
			this.Label8.Location = new System.Drawing.Point(528, 31);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(304, 33);
			this.Label8.TabIndex = 103;
			this.Label8.Text = "ຮູບອາຫານ:";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Timer1
			//
			this.Timer1.Interval = 1;
			//
			//ImageList1
			//
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "Add Image-100.png");
			this.ImageList1.Images.SetKeyName(1, "Broom-100 (1).png");
			this.ImageList1.Images.SetKeyName(2, "Day View-100.png");
			this.ImageList1.Images.SetKeyName(3, "Delete-100.png");
			this.ImageList1.Images.SetKeyName(4, "Exit-100.png");
			this.ImageList1.Images.SetKeyName(5, "Save as-100.png");
			this.ImageList1.Images.SetKeyName(6, "Save-100 (1).png");
			//
			//frm_food
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(947, 507);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.txtName1);
			this.Controls.Add(this.txtID1);
			this.Controls.Add(this.txtPrice1);
			this.Controls.Add(this.txtPath1);
			this.Controls.Add(this.cbUnit);
			this.Controls.Add(this.cbfoodGroup);
			this.Controls.Add(this.cbFoodType);
			this.Controls.Add(this.ptbProfile);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.pnbt);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_food";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_Food";
			this.TabControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvEmployee).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ptbProfile).EndInit();
			this.pnbt.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		internal TabControl TabControl1;
		internal TabPage TabPage1;
		internal TabPage TabPage2;
		internal OpenFileDialog OpenFileDialog1;
		internal DataGridView dgvEmployee;
		internal DevComponents.DotNetBar.Controls.ComboBoxEx cbUnit;
		internal DevComponents.Editors.ComboItem ComboItem1;
		internal DevComponents.Editors.ComboItem ComboItem2;
		internal DevComponents.Editors.ComboItem ComboItem3;
		internal DevComponents.Editors.ComboItem ComboItem4;
		internal DevComponents.Editors.ComboItem ComboItem5;
		internal DevComponents.DotNetBar.Controls.ComboBoxEx cbfoodGroup;
		internal DevComponents.Editors.ComboItem ComboItem11;
		internal DevComponents.Editors.ComboItem ComboItem12;
		internal DevComponents.Editors.ComboItem ComboItem13;
		internal DevComponents.Editors.ComboItem ComboItem14;
		internal DevComponents.Editors.ComboItem ComboItem15;
		internal DevComponents.DotNetBar.Controls.ComboBoxEx cbFoodType;
		internal DevComponents.Editors.ComboItem ComboItem6;
		internal DevComponents.Editors.ComboItem ComboItem7;
		internal DevComponents.Editors.ComboItem ComboItem8;
		internal DevComponents.Editors.ComboItem ComboItem9;
		internal DevComponents.Editors.ComboItem ComboItem10;
		internal Label Label5;
		internal Label Label11;
		internal Label Label4;
		internal Label Label9;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal PictureBox ptbProfile;
		internal DevComponents.DotNetBar.ButtonX ButtonX1;
		internal DevComponents.DotNetBar.ButtonX btEdit1;
		internal DevComponents.DotNetBar.ButtonX btClear1;
		internal DevComponents.DotNetBar.ButtonX btDelete1;
		internal DevComponents.DotNetBar.ButtonX btExit1;
		internal DevComponents.DotNetBar.ButtonX btChoos1;
		internal Panel pnbt;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtPath1;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtPrice1;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtID1;
		internal DevComponents.DotNetBar.Controls.TextBoxX txtName1;
		internal Panel Panel2;
		internal Panel Panel3;
		internal Label Label6;
		internal Label Label7;
		internal Label Label8;
		internal DevComponents.DotNetBar.ButtonX ButtonX2;
		internal Timer Timer1;
		internal ImageList ImageList1;
	}
	
}
