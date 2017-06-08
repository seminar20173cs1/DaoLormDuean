
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
	public partial class ChooseReportByMonth
	{
		public ChooseReportByMonth()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static ChooseReportByMonth defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static ChooseReportByMonth Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new ChooseReportByMonth();
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
		
		public void btReportMonth_Click(object sender, EventArgs e)
		{
			//  Dim Sql As String = " SELECT day(dbo.Bill.Datetime) AS day, SUM((dbo.BillDetail.Price * dbo.BillDetail.Quantity) * (100 - dbo.BillDetail.Discount) / 100) AS Total FROM dbo.Bill INNER JOIN dbo.BillDetail ON dbo.Bill.BillID = dbo.BillDetail.BillID WHERE (YEAR(dbo.Bill.Datetime) = " & cbYear.SelectedItem & ") and MONTH(dbo.bill.datetime) = " & cbMonth.SelectedItem & " GROUP BY day(dbo.Bill.Datetime) "
			//Dim sql As String = "SELECT day(dbo.tb_Selling.DateCome) AS day, SUM((dbo.tb_SellDetail.foodPrice * dbo.tb_SellDetail.foodAmount) AS Total FROM dbo.tb_Selling INNER JOIN dbo.tb_SellDetail ON dbo.tb_Selling.SellID = dbo.tb_SellDetail.SellID WHERE (YEAR(dbo.tb_Selling.dateCome) = " & cbYear.SelectedItem & ") and MONTH(dbo.tb_Selling.dateCome) = " & cbMonth.SelectedItem & " GROUP BY day(dbo.tb_Selling.dateCome)"
			
			string sql2 = @"SELECT        DAY(dbo.tb_Selling.dateCome) AS day, SUM(dbo.tb_SellDetail.foodPrice * dbo.tb_SellDetail.foodAmount) AS Total
FROM            dbo.tb_SellDetail INNER JOIN
dbo.tb_Selling ON dbo.tb_SellDetail.SellID = dbo.tb_Selling.SellID
WHERE (YEAR(dbo.tb_Selling.dateCome) = " + System.Convert.ToString(cbYear.SelectedItem) + ") and MONTH(dbo.tb_Selling.dateCome) between " + System.Convert.ToString(cbMonth.SelectedItem) + " and  " + System.Convert.ToString(ComboBox1.SelectedItem) + " GROUP BY DAY(dbo.tb_Selling.dateCome)";
			
			DSReport dsr = new DSReport();
			MReport rpt = new MReport(); //MonthYearReport
			var da = new SqlDataAdapter(sql2, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			//da.Fill(dsr, "DTReportBillMonth")
			//If dsr.Tables("DTReportBillMonth").Rows.Count = 0 Then
			da.Fill(dsr, "DataTable1");
			if (dsr.Tables["DataTable1"].Rows.Count == 0)
			{
				MessageBox.Show("ບໍ່ມີຂໍ້ມູນໃນເດືອນ ແລະ ປີທີເລືອກ");
			}
			else
			{
				rpt.SetDataSource(dsr);
				rpt.SetParameterValue("monthyear", cbMonth.Text + "/" + cbYear.Text);
				frm_MainReportChoosing.Default.CrystalReportViewer1.ReportSource = rpt;
				frm_MainReportChoosing.Default.Show(this);
				
				return ;
			}
		}
		
		public void ChooseReportByMonth_Load(object sender, EventArgs e)
		{
			int i = System.Convert.ToInt32(DateTime.Now.ToString("MM"));
			cbMonth.SelectedItem = i.ToString();
			cbYear.SelectedItem = DateTime.Now.ToString("yyyy");
			int u = System.Convert.ToInt32(DateTime.Now.ToString("MM"));
			ComboBox1.SelectedItem = u.ToString();
			
		}
	}
}
