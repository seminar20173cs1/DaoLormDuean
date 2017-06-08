
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
	public partial class ChooseReportGoodSellbyMonth
	{
		public ChooseReportGoodSellbyMonth()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static ChooseReportGoodSellbyMonth defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static ChooseReportGoodSellbyMonth Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new ChooseReportGoodSellbyMonth();
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
		public void ChooseReportGoodSellbyMonth_Load(object sender, EventArgs e)
		{
			int i = System.Convert.ToInt32(DateTime.Now.ToString("MM"));
			cbMonth.SelectedItem = i.ToString();
			cbYear.SelectedItem = DateTime.Now.ToString("yyyy");
		}
		
		public void btReportDate_Click(object sender, EventArgs e)
		{
			string sql = @"
SELECT    top " + System.Convert.ToString(int.Parse(txtTop.Text)) + @"    dbo.tb_SellDetail.foodID, dbo.tb_FoodAndDrink.foodName, COUNT(dbo.tb_SellDetail.foodID) AS SellAmount, dbo.tb_Unit.UnitName
FROM            dbo.tb_Selling INNER JOIN
dbo.tb_SellDetail ON dbo.tb_Selling.SellID = dbo.tb_SellDetail.SellID INNER JOIN
dbo.tb_FoodAndDrink ON dbo.tb_SellDetail.foodID = dbo.tb_FoodAndDrink.foodID INNER JOIN
dbo.tb_Unit ON dbo.tb_FoodAndDrink.UnitID = dbo.tb_Unit.UnitID
Where (dbo.tb_selldetail.sellID in (select SellID from dbo.tb_selling as Sell where (month(dateCome)='" + System.Convert.ToString(cbMonth.SelectedItem) + "') and (year(dateCome)='" + System.Convert.ToString(cbYear.SelectedItem) + @"')))
GROUP BY dbo.tb_SellDetail.foodID, dbo.tb_FoodAndDrink.foodName, dbo.tb_Unit.UnitName, dbo.tb_Unit.UnitName
order by sellAmount desc";
			
			DSReport dsr = new DSReport();
			BestSellByMonthAndYear rpt = new BestSellByMonthAndYear();
			var da = new SqlDataAdapter(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da.Fill(dsr, "DTMonthSellGood");
			if (dsr.Tables["DTMonthSellGood"].Rows.Count == 0)
			{
				MessageBox.Show("ບໍ່ມີຂໍ້ມູນ");
			}
			else
			{
				rpt.SetDataSource(dsr);
				rpt.SetParameterValue("top", txtTop.Text);
				rpt.SetParameterValue("month", cbMonth.SelectedItem);
				rpt.SetParameterValue("year", cbYear.SelectedItem);
				frm_MainReportChoosing.Default.CrystalReportViewer1.ReportSource = rpt;
				frm_MainReportChoosing.Default.Show(this);
			}
		}
	}
}
