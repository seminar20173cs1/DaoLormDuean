
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
	public partial class frm_MainDatabaseManagement: Form
	{
		public frm_MainDatabaseManagement()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_MainDatabaseManagement defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_MainDatabaseManagement Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_MainDatabaseManagement();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		public void btFoodCategory_Click(object sender, EventArgs e)
		{
			frm_FoodType.Default.ShowDialog();
			//Dim frm As New frm_FoodType
			//frm.MdiParent = Frm_Main
			//frm.Show()
			//frm.WindowState = FormWindowState.Maximized
		}
		
		public void btFoodGroup_Click(object sender, EventArgs e)
		{
			frm_FoodGroup.Default.ShowDialog();
			//Dim fg As New frm_FoodGroup
			//fg.MdiParent = Frm_Main
			//fg.Show()
			//fg.WindowState = FormWindowState.Maximized
		}
		
		public void btFood_Click(object sender, EventArgs e)
		{
			//'frm_Food.Show()
			//Dim food As New frm_food()
			//food.MdiParent = Frm_Main
			//food.Show()
			//food.WindowState = FormWindowState.Maximized
			frm_food.Default.ShowDialog(this);
			
			
		}
		//Public Sub Child(ByVal obj As Object, formname As Form)
		//    obj = New formname
		//    With obj
		
		//        .MdiParent = Frm_Main
		//        .Show()
		//        .WindowState = FormWindowState.Maximized
		//    End With
		//End Sub
		public void btBoattype_Click(object sender, EventArgs e)
		{
			frm_BoatType.Default.ShowDialog();
			//Dim bt As New frm_BoatType
			//bt.MdiParent = Frm_Main
			//bt.Show()
			//bt.WindowState = FormWindowState.Maximized
		}
		
		public void btBoat_Click(object sender, EventArgs e)
		{
			frm_Boat.Default.ShowDialog();
			
			//Dim boat As New frm_Boat
			//boat.MdiParent = Frm_Main
			//boat.Show()
			//boat.WindowState = FormWindowState.Maximized
		}
		
		public void btEmployee_Click(object sender, EventArgs e)
		{
			//frm_Employee.ShowDialog()
			frm_Employee2.Default.ShowDialog(this);
			//Dim em As New frm_Employee
			//em.MdiParent = Frm_Main
			//em.Show()
			//em.WindowState = FormWindowState.Maximized
		}
		
		public void btUnit_Click(object sender, EventArgs e)
		{
			frm_Unit.Default.ShowDialog();
			//Dim u As New frm_Unit
			//u.MdiParent = Frm_Main
			//u.Show()
			//u.WindowState = FormWindowState.Maximized
		}
		
		public void btUser_Click(object sender, EventArgs e)
		{
			frm_User.Default.ShowDialog();
			//Dim u As New frm_User
			//u.MdiParent = Frm_Main
			//u.Show()
			//u.WindowState = FormWindowState.Maximized
		}
		
		public void btRateExchange_Click(object sender, EventArgs e)
		{
			frm_RateExchange.Default.ShowDialog();
			//Dim r As New frm_RateExchange
			
			//r.MdiParent = Frm_Main
			//r.Show()
			//r.WindowState = FormWindowState.Maximized
		}
		
		private void Button9_Click(object sender, EventArgs e)
		{
			DialogResult confirm = MessageBox.Show("ຕ້ອງການທີ່ຈະອອກແທ້ບໍ?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirm == DialogResult.Yes)
			{
				this.Close();
			}
		}
		
		public void frm_MainDatabaseManagement_Load(object sender, EventArgs e)
		{
			//   Panel1.BackColor = Color.FromArgb(70, Color.Blue)
			
			pnboat.BackColor = Color.FromArgb(70, Color.Black);
			pnemployee.BackColor = Color.FromArgb(70, Color.Black);
			pnfood.BackColor = Color.FromArgb(70, Color.Black);
			pnother.BackColor = Color.FromArgb(70, Color.Black);
			btexit.BackColor = Color.FromArgb(70, Color.Black);
			//   Panel2.BackColor = Color.FromArgb(70, Color.Blue)
			// btFoodCategory.BackColor = Color.FromArgb(70, Color.Black)
		}
	}
}
