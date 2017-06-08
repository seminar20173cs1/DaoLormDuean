
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
using System.Resources;

namespace daolormdeuansystem
{
	public partial class Frm_Main
	{
		public Frm_Main()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Frm_Main defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
        /// 
		public static Frm_Main Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Frm_Main();
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
		
		public void Frm_Main_Load(object sender, EventArgs e)
		{
			//   Panel1.BackColor = Color.FromArgb(70, Color.Black)
			//Label2.Text = DateAndTime.Now
			
			//  MainUserControl.Height = 0
			//  MainUserControl.Width = 0
			Panel2.BackColor = Color.FromArgb(70, Color.Black);
			//  pnMenu.BackColor = Color.FromArgb(70, Color.Black)
			//   WindowState = FormWindowState.Maximized
			pnMenu.Width = 0;
			pnMenu.Height = 0;
			btMenu.Visible = false;
		}
		
		public void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			frm_Login.Default.Show();
		}
		
		public void tmIn_Tick(object sender, EventArgs e)
		{
			//  If (MainUserControl.Width <= 1200 Or MainUserControl.Height <= 360) Then
			//   MainUserControl.Width = MainUserControl.Width + 100
			//    MainUserControl.Height = MainUserControl.Height + 100
			//    Else
			// tmIn.Stop()
			// End If
			
		}
		
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			tmIn.Start();
		}
		
		private void MainUserControl_Load(object sender, EventArgs e)
		{
			frm_Boat k = new frm_Boat();
		///	k.MdiParent = Main.Default;
			k.Show();
			k.WindowState = FormWindowState.Maximized;
			
			//   tmOut.Start()
		}
		
		private void ButtonX6_Click(object sender, EventArgs e)
		{
			tmMenuOut.Start();
			frm_Employee emply = new frm_Employee();
			emply.MdiParent = this;
			emply.Show();
			emply.WindowState = FormWindowState.Maximized;
			emply.BringToFront();
			//  pnMenu.SendToBack()
			//  pnMenu.Hide()
			
			
		}
		
		public void Frm_Main_MdiChildActivate(object sender, EventArgs e)
		{
			//pnMenu.Hide()
		}
		
		public void ButtonX7_Click(object sender, EventArgs e)
		{
			
			if (btMenu.Text ==".")
			{
				tmMenu.Start();
				btMenu.Text = "";
				
			}
			else
			{
				
				pnMenu.Width = 0;
				pnMenu.Height = 0;
				btMenu.Text = ".";
			}
			
			
			
			
		}
		
		public void tmMenu_Tick(object sender, EventArgs e)
		{
			if (pnMenu.Width <= 600 | pnMenu.Height <= 400)
			{
				pnMenu.Width = pnMenu.Width + 100;
				pnMenu.Height = pnMenu.Height + 50;
				
			}
			else
			{
				tmMenu.Stop();
			}
		}
		
		public void tmMenuOut_Tick(object sender, EventArgs e)
		{
			if (pnMenu.Width > 0 | pnMenu.Height > 0)
			{
				pnMenu.Width = pnMenu.Width - 100;
				pnMenu.Height = pnMenu.Height - 100;
			}
			else
			{
				tmMenuOut.Stop();
			}
		}
		
		public void ButtonX6_Click_1(object sender, EventArgs e)
		{
			frm_MainDatabaseManagement.Default.ShowDialog(this);
			
		}
		
		private void MenuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btMenu.Text ==".")
			{
				tmMenu.Start();
				btMenu.Text = "";
				
			}
			else
			{
				
				pnMenu.Width = 0;
				pnMenu.Height = 0;
				btMenu.Text = ".";
			}
			
		}
		
		public void ButtonItem3_Click(object sender, EventArgs e)
		{
			this.Hide();
			frm_Login.Default.Show();
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			
			frm_MainService.Default.ShowDialog(this);
			
			
			// tmMenuOut.Start()
		}
		
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			// Dim re As New frm_MainReserve
			//re.ShowDialog()
			frm_MainReserve.Default.ShowDialog(this);
			
		}
		
		public void ReflectionLabel2_Click(object sender, EventArgs e)
		{
			
		}
		
		public void pnMenu_Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		public void ButtonX4_Click(object sender, EventArgs e)
		{
			frm_Login.Default.Show();
			this.Hide();
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			Label2.Text = DateTime.Now.ToString();
			
		}
		
		public void ButtonItem7_Click(object sender, EventArgs e)
		{
			ChooseReportByDate.Default.ShowDialog(this);
		}
		
		public void ButtonItem8_Click(object sender, EventArgs e)
		{
			ChooseReportByMonth.Default.ShowDialog(this);
		}
		
		public void ButtonItem9_Click(object sender, EventArgs e)
		{
			ChooseReportByYear.Default.ShowDialog(this);
		}
		
		public void ButtonItem5_Click(object sender, EventArgs e)
		{
			frm_ReportReservee.Default.ShowDialog();
		}
		
		public void ButtonItem6_Click(object sender, EventArgs e)
		{
			
		}
		
		public void ButtonItem4_Click(object sender, EventArgs e)
		{
			ChooseReportGoodSell.Default.ShowDialog(this);
		}
		
		public void ButtonItem2_Click(object sender, EventArgs e)
		{
			frm_ChangePassword.Default.ShowDialog();
			frm_ChangePassword.Default.lbUserName.Text = btUser.Text;
		}
		
		public void ButtonItem19_Click(object sender, EventArgs e)
		{
			ChooseReportGoodSellbyMonth.Default.ShowDialog(this);
			
		}
	}
}
