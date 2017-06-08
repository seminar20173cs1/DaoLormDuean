
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


using System.Data.SqlClient;

namespace daolormdeuansystem
{
	public partial class frm_ReportReservee
	{
		public frm_ReportReservee()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_ReportReservee defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_ReportReservee Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_ReportReservee();
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
		public void btReportReserve_Click(object sender, EventArgs e)
		{
			if (!Information.IsNumeric(txtDay.Text) && txtDay.Text != "") //ກວດທັງຕົວເລກ ແລະ ຊ່ອງວ່າງ
			{
				//  txtDay.Text = txtDay.Text.Substring(0, txtDay.Text.Length - 1)
				//txtDay.Select(txtDay.Text.Length + 1, 1)
				txtDay.ResetText();
				txtDay.Focus();
				// Exit Sub
				
				
			}
			else
			{
				
				var sql = @"SELECT        dbo.tb_reserveBoat.reserveID, dbo.tb_employee.employeeName, dbo.tb_reserveBoat.boatID, dbo.tb_customer.customerName, dbo.tb_reserveBoat.reserveDate, dbo.tb_reserveBoat.reserveComeDate,
convert(varchar(8),dbo.tb_reserveBoat.reserveComeTime, 108) as reserveComeTime, dbo.tb_reserveBoat.boatHour, dbo.tb_reserveBoat.reserveStatus
FROM            dbo.tb_reserveBoat INNER JOIN
dbo.tb_employee ON dbo.tb_reserveBoat.employeeID = dbo.tb_employee.employeeID INNER JOIN
dbo.tb_customer ON dbo.tb_reserveBoat.customerID = dbo.tb_customer.customerID
where reserveComeDate between GETDATE() and DateADD(day, " + System.Convert.ToString(int.Parse(txtDay.Text)) + ", GETDATE())";
				DSReport dsr = new DSReport();
				ReserveReport1 rpt = new ReserveReport1();
				var da = new SqlDataAdapter(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
				da.Fill(dsr, "DTReserve");
				if (dsr.Tables["DTReserve"].Rows.Count == 0)
				{
					MessageBox.Show("ບໍ່ມີຂໍ້ມູນ");
				}
				else
				{
					rpt.SetDataSource(dsr);
					// rpt.SetParameterValue("top", TextBox1.Text)
					rpt.SetParameterValue("year", txtDay.Text);
					frm_MainReportChoosing.Default.CrystalReportViewer1.ReportSource = rpt;
					frm_MainReportChoosing.Default.Show(this);
				}
			}
			
			
		}
		
		public void frm_ReportReservee_Load(object sender, EventArgs e)
		{
			txtDay.Focus();
		}
	}
}
