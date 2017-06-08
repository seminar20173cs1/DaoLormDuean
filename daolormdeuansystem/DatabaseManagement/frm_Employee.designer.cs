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
using DevComponents;

namespace daolormdeuansystem
{
   

    partial class frm_Employee : System.Windows.Forms.Form
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
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			base.Load += new System.EventHandler(frm_Employee_Load);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frm_Employee_FormClosing);
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.ptbProfile = new System.Windows.Forms.PictureBox();
			this.ptbProfile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ptbProfile_MouseDoubleClick);
			this.ptbProfile.Click += new System.EventHandler(this.ptbProfile_Click_1);
			this.cbProvince = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.ComboItem1 = new DevComponents.Editors.ComboItem();
			this.ComboItem2 = new DevComponents.Editors.ComboItem();
			this.ComboItem3 = new DevComponents.Editors.ComboItem();
			this.ComboItem4 = new DevComponents.Editors.ComboItem();
			this.ComboItem5 = new DevComponents.Editors.ComboItem();
			this.dtbDob = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
			this.btChoosePhoto = new System.Windows.Forms.Button();
			this.btChoosePhoto.Click += new System.EventHandler(this.btChoosePhoto_Click);
			this.btExit = new System.Windows.Forms.Button();
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			this.btClear = new System.Windows.Forms.Button();
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			this.btDelete = new System.Windows.Forms.Button();
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			this.btEdit = new System.Windows.Forms.Button();
			this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
			this.btSave = new System.Windows.Forms.Button();
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
			this.txtEmployeeDistrict = new System.Windows.Forms.TextBox();
			this.txtPicturePath = new System.Windows.Forms.TextBox();
			this.txtEmployeeTel = new System.Windows.Forms.TextBox();
			this.txtEmployeeVillage = new System.Windows.Forms.TextBox();
			this.txtEmployeePosition = new System.Windows.Forms.TextBox();
			this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtEmployeeParentTel = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.dgvEmployee = new System.Windows.Forms.DataGridView();
			this.dgvEmployee.Click += new System.EventHandler(this.dgvEmployee_Click);
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbProfile).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dtbDob).BeginInit();
			this.TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgvEmployee).BeginInit();
			this.SuspendLayout();
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			//
			//TabControl1
			//
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Location = new System.Drawing.Point(12, 12);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(867, 363);
			this.TabControl1.TabIndex = 21;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.ptbProfile);
			this.TabPage1.Controls.Add(this.cbProvince);
			this.TabPage1.Controls.Add(this.dtbDob);
			this.TabPage1.Controls.Add(this.btChoosePhoto);
			this.TabPage1.Controls.Add(this.btExit);
			this.TabPage1.Controls.Add(this.btClear);
			this.TabPage1.Controls.Add(this.btDelete);
			this.TabPage1.Controls.Add(this.btEdit);
			this.TabPage1.Controls.Add(this.btSave);
			this.TabPage1.Controls.Add(this.txtEmployeeSalary);
			this.TabPage1.Controls.Add(this.txtEmployeeDistrict);
			this.TabPage1.Controls.Add(this.txtPicturePath);
			this.TabPage1.Controls.Add(this.txtEmployeeTel);
			this.TabPage1.Controls.Add(this.txtEmployeeVillage);
			this.TabPage1.Controls.Add(this.txtEmployeePosition);
			this.TabPage1.Controls.Add(this.txtEmployeeLastName);
			this.TabPage1.Controls.Add(this.Label12);
			this.TabPage1.Controls.Add(this.txtEmployeeEmail);
			this.TabPage1.Controls.Add(this.Label8);
			this.TabPage1.Controls.Add(this.txtEmployeeName);
			this.TabPage1.Controls.Add(this.Label11);
			this.TabPage1.Controls.Add(this.txtEmployeeParentTel);
			this.TabPage1.Controls.Add(this.Label10);
			this.TabPage1.Controls.Add(this.Label4);
			this.TabPage1.Controls.Add(this.Label7);
			this.TabPage1.Controls.Add(this.txtEmployeeID);
			this.TabPage1.Controls.Add(this.Label9);
			this.TabPage1.Controls.Add(this.Label6);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Controls.Add(this.Label5);
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Location = new System.Drawing.Point(4, 32);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(859, 327);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "ຈັດການຂໍ້ມູນພະນັກງານ";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//ptbProfile
			//
			this.ptbProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ptbProfile.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ptbProfile.Location = new System.Drawing.Point(22, 21);
			this.ptbProfile.Name = "ptbProfile";
			this.ptbProfile.Size = new System.Drawing.Size(174, 230);
			this.ptbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ptbProfile.TabIndex = 52;
			this.ptbProfile.TabStop = false;
			//
			//cbProvince
			//
			this.cbProvince.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbProvince.DisplayMember = "Text";
			this.cbProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbProvince.ForeColor = System.Drawing.Color.Black;
			this.cbProvince.FormattingEnabled = true;
			this.cbProvince.ItemHeight = 26;
			this.cbProvince.Items.AddRange(new object[] {this.ComboItem1, this.ComboItem2, this.ComboItem3, this.ComboItem4, this.ComboItem5});
			this.cbProvince.Location = new System.Drawing.Point(631, 180);
			this.cbProvince.Name = "cbProvince";
			this.cbProvince.Size = new System.Drawing.Size(219, 32);
			this.cbProvince.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.cbProvince.TabIndex = 10;
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
			//dtbDob
			//
			this.dtbDob.Anchor = System.Windows.Forms.AnchorStyles.None;
			//
			//
			//
			this.dtbDob.BackgroundStyle.Class = "DateTimeInputBackground";
			this.dtbDob.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dtbDob.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
			this.dtbDob.ButtonDropDown.Visible = true;
			this.dtbDob.IsPopupCalendarOpen = false;
			this.dtbDob.Location = new System.Drawing.Point(317, 137);
			//
			//
			//
			//
			//
			//
			this.dtbDob.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dtbDob.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
			this.dtbDob.MonthCalendar.ClearButtonVisible = true;
			//
			//
			//
			this.dtbDob.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.dtbDob.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			this.dtbDob.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.dtbDob.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.dtbDob.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.dtbDob.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			this.dtbDob.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dtbDob.MonthCalendar.DisplayMonth = new DateTime(2016, 12, 1, 0, 0, 0, 0);
			//
			//
			//
			this.dtbDob.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.dtbDob.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			this.dtbDob.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.dtbDob.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.dtbDob.MonthCalendar.TodayButtonVisible = true;
			this.dtbDob.Name = "dtbDob";
			this.dtbDob.Size = new System.Drawing.Size(219, 31);
			this.dtbDob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.dtbDob.TabIndex = 3;
			this.dtbDob.TimeSelectorType = DevComponents.Editors.DateTimeAdv.eTimeSelectorType.TouchStyle;
			//
			//btChoosePhoto
			//
			this.btChoosePhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btChoosePhoto.Location = new System.Drawing.Point(759, 261);
			this.btChoosePhoto.Name = "btChoosePhoto";
			this.btChoosePhoto.Size = new System.Drawing.Size(91, 31);
			this.btChoosePhoto.TabIndex = 12;
			this.btChoosePhoto.Text = "ເລືອກຮູບ";
			this.btChoosePhoto.UseVisualStyleBackColor = true;
			//
			//btExit
			//
			this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btExit.Location = new System.Drawing.Point(662, 261);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(91, 31);
			this.btExit.TabIndex = 17;
			this.btExit.Text = "ອອກ";
			this.btExit.UseVisualStyleBackColor = true;
			//
			//btClear
			//
			this.btClear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btClear.Location = new System.Drawing.Point(565, 261);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(91, 31);
			this.btClear.TabIndex = 16;
			this.btClear.Text = "ລ້າງ";
			this.btClear.UseVisualStyleBackColor = true;
			//
			//btDelete
			//
			this.btDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btDelete.Location = new System.Drawing.Point(468, 261);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(91, 31);
			this.btDelete.TabIndex = 15;
			this.btDelete.Text = "ລົບ";
			this.btDelete.UseVisualStyleBackColor = true;
			//
			//btEdit
			//
			this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btEdit.Location = new System.Drawing.Point(371, 261);
			this.btEdit.Name = "btEdit";
			this.btEdit.Size = new System.Drawing.Size(91, 31);
			this.btEdit.TabIndex = 14;
			this.btEdit.Text = "ແກ້ໃຂ";
			this.btEdit.UseVisualStyleBackColor = true;
			//
			//btSave
			//
			this.btSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btSave.Location = new System.Drawing.Point(274, 261);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(91, 31);
			this.btSave.TabIndex = 13;
			this.btSave.Text = "ບັນທຶກ";
			this.btSave.UseVisualStyleBackColor = true;
			//
			//txtEmployeeSalary
			//
			this.txtEmployeeSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeSalary.Location = new System.Drawing.Point(631, 217);
			this.txtEmployeeSalary.Name = "txtEmployeeSalary";
			this.txtEmployeeSalary.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeSalary.TabIndex = 11;
			//
			//txtEmployeeDistrict
			//
			this.txtEmployeeDistrict.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeDistrict.Location = new System.Drawing.Point(631, 140);
			this.txtEmployeeDistrict.Name = "txtEmployeeDistrict";
			this.txtEmployeeDistrict.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeDistrict.TabIndex = 9;
			//
			//txtPicturePath
			//
			this.txtPicturePath.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPicturePath.Location = new System.Drawing.Point(22, 265);
			this.txtPicturePath.Name = "txtPicturePath";
			this.txtPicturePath.Size = new System.Drawing.Size(174, 31);
			this.txtPicturePath.TabIndex = 35;
			//
			//txtEmployeeTel
			//
			this.txtEmployeeTel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeTel.Location = new System.Drawing.Point(317, 217);
			this.txtEmployeeTel.Name = "txtEmployeeTel";
			this.txtEmployeeTel.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeTel.TabIndex = 5;
			//
			//txtEmployeeVillage
			//
			this.txtEmployeeVillage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeVillage.Location = new System.Drawing.Point(631, 100);
			this.txtEmployeeVillage.Name = "txtEmployeeVillage";
			this.txtEmployeeVillage.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeVillage.TabIndex = 8;
			//
			//txtEmployeePosition
			//
			this.txtEmployeePosition.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeePosition.Location = new System.Drawing.Point(317, 177);
			this.txtEmployeePosition.Name = "txtEmployeePosition";
			this.txtEmployeePosition.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeePosition.TabIndex = 4;
			//
			//txtEmployeeLastName
			//
			this.txtEmployeeLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeLastName.Location = new System.Drawing.Point(317, 100);
			this.txtEmployeeLastName.Name = "txtEmployeeLastName";
			this.txtEmployeeLastName.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeLastName.TabIndex = 2;
			//
			//Label12
			//
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(556, 217);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(66, 23);
			this.Label12.TabIndex = 24;
			this.Label12.Text = "ເງິນເດືອນ:";
			//
			//txtEmployeeEmail
			//
			this.txtEmployeeEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeEmail.Location = new System.Drawing.Point(631, 58);
			this.txtEmployeeEmail.Name = "txtEmployeeEmail";
			this.txtEmployeeEmail.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeEmail.TabIndex = 7;
			//
			//Label8
			//
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(577, 140);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(45, 23);
			this.Label8.TabIndex = 23;
			this.Label8.Text = "ເມືອງ:";
			//
			//txtEmployeeName
			//
			this.txtEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeName.Location = new System.Drawing.Point(317, 58);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeName.TabIndex = 1;
			//
			//Label11
			//
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(265, 217);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(46, 23);
			this.Label11.TabIndex = 22;
			this.Label11.Text = "ເບີໂທ:";
			//
			//txtEmployeeParentTel
			//
			this.txtEmployeeParentTel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeParentTel.Location = new System.Drawing.Point(631, 18);
			this.txtEmployeeParentTel.Name = "txtEmployeeParentTel";
			this.txtEmployeeParentTel.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeParentTel.TabIndex = 6;
			//
			//Label10
			//
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(575, 177);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(47, 23);
			this.Label10.TabIndex = 28;
			this.Label10.Text = "ແຂວງ:";
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(214, 140);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(97, 23);
			this.Label4.TabIndex = 21;
			this.Label4.Text = "ວັນເດືອນປີເກີດ:";
			//
			//Label7
			//
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(584, 103);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(38, 23);
			this.Label7.TabIndex = 27;
			this.Label7.Text = "ບ້ານ:";
			//
			//txtEmployeeID
			//
			this.txtEmployeeID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEmployeeID.Location = new System.Drawing.Point(317, 18);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(219, 31);
			this.txtEmployeeID.TabIndex = 0;
			//
			//Label9
			//
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(253, 177);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(58, 23);
			this.Label9.TabIndex = 26;
			this.Label9.Text = "ຕໍາແໜ່ງ:";
			//
			//Label6
			//
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(567, 61);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(55, 23);
			this.Label6.TabIndex = 29;
			this.Label6.Text = "Email:";
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(235, 100);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 23);
			this.Label3.TabIndex = 25;
			this.Label3.Text = "ນາມສະກຸນ:";
			//
			//Label5
			//
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(541, 21);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(81, 23);
			this.Label5.TabIndex = 32;
			this.Label5.Text = "ເບີຜູ້ປົກຄອງ:";
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(288, 61);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(23, 23);
			this.Label2.TabIndex = 30;
			this.Label2.Text = "ຊື່:";
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(260, 21);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(51, 23);
			this.Label1.TabIndex = 31;
			this.Label1.Text = "ລະຫັດ:";
			//
			//TabPage2
			//
			this.TabPage2.Controls.Add(this.dgvEmployee);
			this.TabPage2.Location = new System.Drawing.Point(4, 32);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(859, 327);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "ເບິ່ງຂໍ້ມູນພະນັກງານ";
			this.TabPage2.UseVisualStyleBackColor = true;
			//
			//dgvEmployee
			//
			this.dgvEmployee.AllowUserToAddRows = false;
			this.dgvEmployee.AllowUserToDeleteRows = false;
			this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEmployee.Location = new System.Drawing.Point(3, 3);
			this.dgvEmployee.Name = "dgvEmployee";
			this.dgvEmployee.ReadOnly = true;
			this.dgvEmployee.Size = new System.Drawing.Size(853, 321);
			this.dgvEmployee.TabIndex = 18;
			//
			//frm_Employee
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (9.0F), (float) (23.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 384);
			this.Controls.Add(this.TabControl1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frm_Employee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ເບິ່ງຂໍ້ມູນ";
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.ptbProfile).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dtbDob).EndInit();
			this.TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgvEmployee).EndInit();
			this.ResumeLayout(false);
			
		}
		internal OpenFileDialog OpenFileDialog1;
		internal TabControl TabControl1;
		internal TabPage TabPage1;
		internal PictureBox ptbProfile;
		internal DevComponents.DotNetBar.Controls.ComboBoxEx cbProvince;
		internal DevComponents.Editors.ComboItem ComboItem1;
		internal DevComponents.Editors.ComboItem ComboItem2;
		internal DevComponents.Editors.ComboItem ComboItem3;
		internal DevComponents.Editors.ComboItem ComboItem4;
		internal DevComponents.Editors.ComboItem ComboItem5;
		internal DevComponents.Editors.DateTimeAdv.DateTimeInput dtbDob;
		internal Button btChoosePhoto;
		internal Button btExit;
		internal Button btClear;
		internal Button btDelete;
		internal Button btEdit;
		internal Button btSave;
		internal TextBox txtEmployeeSalary;
		internal TextBox txtEmployeeDistrict;
		internal TextBox txtPicturePath;
		internal TextBox txtEmployeeTel;
		internal TextBox txtEmployeeVillage;
		internal TextBox txtEmployeePosition;
		internal TextBox txtEmployeeLastName;
		internal Label Label12;
		internal TextBox txtEmployeeEmail;
		internal Label Label8;
		internal TextBox txtEmployeeName;
		internal Label Label11;
		internal TextBox txtEmployeeParentTel;
		internal Label Label10;
		internal Label Label4;
		internal Label Label7;
		internal TextBox txtEmployeeID;
		internal Label Label9;
		internal Label Label6;
		internal Label Label3;
		internal Label Label5;
		internal Label Label2;
		internal Label Label1;
		internal TabPage TabPage2;
		internal DataGridView dgvEmployee;
	}
	
}
