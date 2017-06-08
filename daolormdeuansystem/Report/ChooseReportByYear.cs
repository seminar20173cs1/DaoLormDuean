
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
	public partial class ChooseReportByYear
	{
		public ChooseReportByYear()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static ChooseReportByYear defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static ChooseReportByYear Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new ChooseReportByYear();
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
		public void btReportYear_Click(object sender, EventArgs e)
		{
			string sql = @"SELECT        Month(dbo.tb_Selling.dateCome) AS month, SUM(dbo.tb_SellDetail.foodPrice * dbo.tb_SellDetail.foodAmount) AS Total
FROM            dbo.tb_SellDetail INNER JOIN
dbo.tb_Selling ON dbo.tb_SellDetail.SellID = dbo.tb_Selling.SellID
WHERE (YEAR(dbo.tb_Selling.dateCome) = " + System.Convert.ToString(cbYear.SelectedItem) + @")
GROUP BY month(dbo.tb_Selling.dateCome)";
			DSReport dsr = new DSReport();
			YearReport rpt = new YearReport();
			var da = new SqlDataAdapter(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da.Fill(dsr, "DTReportYear");
			if (dsr.Tables["DTReportYear"].Rows.Count == 0)
			{
				MessageBox.Show("ບໍ່ມີຂໍ້ມູນໃນປີທີເລືອກ");
			}
			else
			{
				rpt.SetDataSource(dsr);
				rpt.SetParameterValue("year", cbYear.Text);
				
				frm_MainReportChoosing.Default.CrystalReportViewer1.ReportSource = rpt;
				frm_MainReportChoosing.Default.Show(this);
				
			}
			
			
			
		}
		
		public void ChooseReportByYear_Load(object sender, EventArgs e)
		{
			cbYear.SelectedItem = DateTime.Now.ToString("yyyy");
		}
	}
}
