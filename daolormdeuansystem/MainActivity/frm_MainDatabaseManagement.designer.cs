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

	partial class frm_MainDatabaseManagement : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frm_MainDatabaseManagement_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainDatabaseManagement));
			this.btFoodCategory = new System.Windows.Forms.Button();
			this.btFoodCategory.Click += new System.EventHandler(this.btFoodCategory_Click);
			this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
			this.btFoodGroup = new System.Windows.Forms.Button();
			this.btFoodGroup.Click += new System.EventHandler(this.btFoodGroup_Click);
			this.btFood = new System.Windows.Forms.Button();
			this.btFood.Click += new System.EventHandler(this.btFood_Click);
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btBoattype = new System.Windows.Forms.Button();
			this.btBoattype.Click += new System.EventHandler(this.btBoattype_Click);
			this.btBoat = new System.Windows.Forms.Button();
			this.btBoat.Click += new System.EventHandler(this.btBoat_Click);
			this.btEmployee = new System.Windows.Forms.Button();
			this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
			this.btUnit = new System.Windows.Forms.Button();
			this.btUnit.Click += new System.EventHandler(this.btUnit_Click);
			this.btUser = new System.Windows.Forms.Button();
			this.btUser.Click += new System.EventHandler(this.btUser_Click);
			this.btRateExchange = new System.Windows.Forms.Button();
			this.btRateExchange.Click += new System.EventHandler(this.btRateExchange_Click);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.pnother = new System.Windows.Forms.Panel();
			this.pnboat = new System.Windows.Forms.Panel();
			this.pnemployee = new System.Windows.Forms.Panel();
			this.pnfood = new System.Windows.Forms.Panel();
			this.btexit = new DevComponents.DotNetBar.ButtonX();
			this.Panel1.SuspendLayout();
			this.pnother.SuspendLayout();
			this.pnboat.SuspendLayout();
			this.pnemployee.SuspendLayout();
			this.pnfood.SuspendLayout();
			this.SuspendLayout();
			//
			//btFoodCategory
			//
			this.btFoodCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btFoodCategory.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btFoodCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btFoodCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btFoodCategory.Font = new System.Drawing.Font("Saysettha OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btFoodCategory.ForeColor = System.Drawing.Color.White;
			this.btFoodCategory.ImageKey = "Food-100 (1).png";
			this.btFoodCategory.ImageList = this.ImageList2;
			this.btFoodCategory.Location = new System.Drawing.Point(17, 125);
			this.btFoodCategory.Name = "btFoodCategory";
			this.btFoodCategory.Size = new System.Drawing.Size(162, 69);
			this.btFoodCategory.TabIndex = 0;
			this.btFoodCategory.Text = "ປະເພດອາຫານ";
			this.btFoodCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btFoodCategory.UseVisualStyleBackColor = false;
			//
			//ImageList2
			//
			this.ImageList2.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList2.ImageStream"));
			this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList2.Images.SetKeyName(0, "Conference-100.png");
			this.ImageList2.Images.SetKeyName(1, "Currency Exchange-100.png");
			this.ImageList2.Images.SetKeyName(2, "Food And Wine-100.png");
			this.ImageList2.Images.SetKeyName(3, "Food-100 (1).png");
			this.ImageList2.Images.SetKeyName(4, "Gondola-100.png");
			this.ImageList2.Images.SetKeyName(5, "Ingredients-100.png");
			this.ImageList2.Images.SetKeyName(6, "Permanent Job-100 (1).png");
			this.ImageList2.Images.SetKeyName(7, "Sail Boat-100.png");
			this.ImageList2.Images.SetKeyName(8, "Sailing Ship Large-100.png");
			this.ImageList2.Images.SetKeyName(9, "Scales-100.png");
			this.ImageList2.Images.SetKeyName(10, "User Shield-100.png");
			//
			//btFoodGroup
			//
			this.btFoodGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btFoodGroup.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btFoodGroup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btFoodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btFoodGroup.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btFoodGroup.ForeColor = System.Drawing.Color.White;
			this.btFoodGroup.ImageKey = "Ingredients-100.png";
			this.btFoodGroup.ImageList = this.ImageList2;
			this.btFoodGroup.Location = new System.Drawing.Point(17, 200);
			this.btFoodGroup.Name = "btFoodGroup";
			this.btFoodGroup.Size = new System.Drawing.Size(162, 69);
			this.btFoodGroup.TabIndex = 0;
			this.btFoodGroup.Text = "ກຸ່ມອາຫານ";
			this.btFoodGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btFoodGroup.UseVisualStyleBackColor = false;
			//
			//btFood
			//
			this.btFood.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btFood.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btFood.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btFood.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btFood.ForeColor = System.Drawing.Color.White;
			this.btFood.ImageKey = "Food And Wine-100.png";
			this.btFood.ImageList = this.ImageList2;
			this.btFood.Location = new System.Drawing.Point(17, 50);
			this.btFood.Name = "btFood";
			this.btFood.Size = new System.Drawing.Size(162, 69);
			this.btFood.TabIndex = 0;
			this.btFood.Text = "ອາຫານ";
			this.btFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btFood.UseVisualStyleBackColor = false;
			//
			//ImageList1
			//
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) (resources.GetObject("ImageList1.ImageStream"));
			this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "Check-100.png");
			this.ImageList1.Images.SetKeyName(1, "Delete-100 (2).png");
			this.ImageList1.Images.SetKeyName(2, "IMG-20161210-WA0004.jpg");
			this.ImageList1.Images.SetKeyName(3, "IMG-20161210-WA0006.jpg");
			this.ImageList1.Images.SetKeyName(4, "Key-100.png");
			this.ImageList1.Images.SetKeyName(5, "Password-100.png");
			this.ImageList1.Images.SetKeyName(6, "User Shield-100.png");
			//
			//btBoattype
			//
			this.btBoattype.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btBoattype.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btBoattype.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btBoattype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBoattype.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btBoattype.ForeColor = System.Drawing.Color.White;
			this.btBoattype.ImageKey = "Sailing Ship Large-100.png";
			this.btBoattype.ImageList = this.ImageList2;
			this.btBoattype.Location = new System.Drawing.Point(17, 162);
			this.btBoattype.Name = "btBoattype";
			this.btBoattype.Size = new System.Drawing.Size(162, 89);
			this.btBoattype.TabIndex = 0;
			this.btBoattype.Text = "ປະເພດເຮືອ";
			this.btBoattype.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btBoattype.UseVisualStyleBackColor = false;
			//
			//btBoat
			//
			this.btBoat.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btBoat.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btBoat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btBoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBoat.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btBoat.ForeColor = System.Drawing.Color.White;
			this.btBoat.ImageKey = "Sail Boat-100.png";
			this.btBoat.ImageList = this.ImageList2;
			this.btBoat.Location = new System.Drawing.Point(17, 67);
			this.btBoat.Name = "btBoat";
			this.btBoat.Size = new System.Drawing.Size(162, 89);
			this.btBoat.TabIndex = 0;
			this.btBoat.Text = "ເຮືອ";
			this.btBoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btBoat.UseVisualStyleBackColor = false;
			//
			//btEmployee
			//
			this.btEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btEmployee.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEmployee.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btEmployee.ForeColor = System.Drawing.Color.White;
			this.btEmployee.ImageKey = "Permanent Job-100 (1).png";
			this.btEmployee.ImageList = this.ImageList2;
			this.btEmployee.Location = new System.Drawing.Point(17, 67);
			this.btEmployee.Name = "btEmployee";
			this.btEmployee.Size = new System.Drawing.Size(162, 89);
			this.btEmployee.TabIndex = 0;
			this.btEmployee.Text = "ພະນັກງານ";
			this.btEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btEmployee.UseVisualStyleBackColor = false;
			//
			//btUnit
			//
			this.btUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btUnit.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btUnit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btUnit.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btUnit.ForeColor = System.Drawing.Color.White;
			this.btUnit.ImageKey = "Scales-100.png";
			this.btUnit.ImageList = this.ImageList2;
			this.btUnit.Location = new System.Drawing.Point(17, 162);
			this.btUnit.Name = "btUnit";
			this.btUnit.Size = new System.Drawing.Size(162, 89);
			this.btUnit.TabIndex = 0;
			this.btUnit.Text = "ຫົວໜ່ວຍ";
			this.btUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btUnit.UseVisualStyleBackColor = false;
			//
			//btUser
			//
			this.btUser.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btUser.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btUser.Font = new System.Drawing.Font("Saysettha OT", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btUser.ForeColor = System.Drawing.Color.White;
			this.btUser.ImageKey = "Conference-100.png";
			this.btUser.ImageList = this.ImageList2;
			this.btUser.Location = new System.Drawing.Point(17, 162);
			this.btUser.Name = "btUser";
			this.btUser.Size = new System.Drawing.Size(162, 89);
			this.btUser.TabIndex = 0;
			this.btUser.Text = "ຜູ້ໃຊ້";
			this.btUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btUser.UseVisualStyleBackColor = false;
			//
			//btRateExchange
			//
			this.btRateExchange.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btRateExchange.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btRateExchange.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btRateExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRateExchange.Font = new System.Drawing.Font("Saysettha OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btRateExchange.ForeColor = System.Drawing.Color.White;
			this.btRateExchange.ImageKey = "Currency Exchange-100.png";
			this.btRateExchange.ImageList = this.ImageList2;
			this.btRateExchange.Location = new System.Drawing.Point(17, 67);
			this.btRateExchange.Name = "btRateExchange";
			this.btRateExchange.Size = new System.Drawing.Size(162, 89);
			this.btRateExchange.TabIndex = 0;
			this.btRateExchange.Text = "ອັດຕາແລກປ່ຽນ";
			this.btRateExchange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btRateExchange.UseVisualStyleBackColor = false;
			//
			//Panel1
			//
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.pnother);
			this.Panel1.Controls.Add(this.pnboat);
			this.Panel1.Controls.Add(this.pnemployee);
			this.Panel1.Controls.Add(this.pnfood);
			this.Panel1.Location = new System.Drawing.Point(12, 52);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(820, 412);
			this.Panel1.TabIndex = 1;
			//
			//Label4
			//
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label4.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label4.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.White;
			this.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label4.ImageKey = "User Shield-100.png";
			this.Label4.ImageList = this.ImageList2;
			this.Label4.Location = new System.Drawing.Point(617, 30);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(196, 36);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "ຈັດການຂໍ້ມູນອື່ນໆ";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label3.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label3.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.White;
			this.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label3.ImageKey = "Sailing Ship Large-100.png";
			this.Label3.ImageList = this.ImageList2;
			this.Label3.Location = new System.Drawing.Point(410, 30);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(196, 36);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "ຈັດການຂໍ້ມູນເຮືອ";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label2
			//
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label2.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label2.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label2.ImageIndex = 6;
			this.Label2.ImageList = this.ImageList2;
			this.Label2.Location = new System.Drawing.Point(208, 31);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(196, 36);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "ຈັດການຂໍ້ມູນພະນັກງານ";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label1
			//
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label1.BackColor = System.Drawing.Color.DodgerBlue;
			this.Label1.Font = new System.Drawing.Font("Phetsarath OT", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label1.ImageKey = "Ingredients-100.png";
			this.Label1.ImageList = this.ImageList2;
			this.Label1.Location = new System.Drawing.Point(3, 31);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(196, 36);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "ຈັດການຂໍ້ມູນອາຫານ";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//pnother
			//
			this.pnother.BackColor = System.Drawing.Color.Cyan;
			this.pnother.Controls.Add(this.btRateExchange);
			this.pnother.Controls.Add(this.btUnit);
			this.pnother.Location = new System.Drawing.Point(617, 66);
			this.pnother.Name = "pnother";
			this.pnother.Size = new System.Drawing.Size(196, 318);
			this.pnother.TabIndex = 3;
			//
			//pnboat
			//
			this.pnboat.BackColor = System.Drawing.Color.Cyan;
			this.pnboat.Controls.Add(this.btBoattype);
			this.pnboat.Controls.Add(this.btBoat);
			this.pnboat.Location = new System.Drawing.Point(410, 66);
			this.pnboat.Name = "pnboat";
			this.pnboat.Size = new System.Drawing.Size(196, 318);
			this.pnboat.TabIndex = 2;
			//
			//pnemployee
			//
			this.pnemployee.BackColor = System.Drawing.Color.Cyan;
			this.pnemployee.Controls.Add(this.btUser);
			this.pnemployee.Controls.Add(this.btEmployee);
			this.pnemployee.Location = new System.Drawing.Point(208, 66);
			this.pnemployee.Name = "pnemployee";
			this.pnemployee.Size = new System.Drawing.Size(196, 318);
			this.pnemployee.TabIndex = 1;
			//
			//pnfood
			//
			this.pnfood.BackColor = System.Drawing.Color.Cyan;
			this.pnfood.Controls.Add(this.btFood);
			this.pnfood.Controls.Add(this.btFoodCategory);
			this.pnfood.Controls.Add(this.btFoodGroup);
			this.pnfood.Location = new System.Drawing.Point(3, 66);
			this.pnfood.Name = "pnfood";
			this.pnfood.Size = new System.Drawing.Size(196, 318);
			this.pnfood.TabIndex = 0;
			//
			//btexit
			//
			this.btexit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.btexit.Anchor = (System.Windows.Forms.AnchorStyles) (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btexit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.btexit.Font = new System.Drawing.Font("Saysettha OT", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btexit.Location = new System.Drawing.Point(756, 465);
			this.btexit.Name = "btexit";
			this.btexit.Size = new System.Drawing.Size(75, 33);
			this.btexit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.btexit.Symbol = "";
			this.btexit.SymbolColor = System.Drawing.Color.Red;
			this.btexit.TabIndex = 2;
            this.btexit.Text = "ອອກ"; // + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10));
			//
			//frm_MainDatabaseManagement
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (12.0F), (float) (31.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.BackgroundImage = Properties.Resources.IMG_20161210_WA0004;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(844, 502);
			this.Controls.Add(this.btexit);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Phetsarath OT", (float) (15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "frm_MainDatabaseManagement";
			this.Text = "frm_MainDatabaseManagement";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Panel1.ResumeLayout(false);
			this.pnother.ResumeLayout(false);
			this.pnboat.ResumeLayout(false);
			this.pnemployee.ResumeLayout(false);
			this.pnfood.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		internal Button btFoodCategory;
		internal Button btFoodGroup;
		internal Button btFood;
		internal Button btBoattype;
		internal Button btBoat;
		internal Button btEmployee;
		internal Button btUnit;
		internal Button btUser;
		internal Button btRateExchange;
		internal Panel Panel1;
		internal Panel pnother;
		internal Panel pnboat;
		internal Panel pnemployee;
		internal Panel pnfood;
		internal Label Label4;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal DevComponents.DotNetBar.ButtonX btexit;
		internal ImageList ImageList1;
		internal ImageList ImageList2;
	}
	
}
