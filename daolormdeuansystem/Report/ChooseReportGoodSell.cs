
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
	public partial class ChooseReportGoodSell
	{
		public ChooseReportGoodSell()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static ChooseReportGoodSell defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static ChooseReportGoodSell Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new ChooseReportGoodSell();
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
		public void ChooseReportGoodSell_Load(object sender, EventArgs e)
		{
			int i = System.Convert.ToInt32(DateTime.Now.ToString("MM"));
			//  cbMonth.SelectedItem = i.ToString
			cbYear.SelectedItem = DateTime.Now.ToString("yyyy");
		}
		
		public void btReportDate_Click(object sender, EventArgs e)
		{
			string sql = "SELECT        TOP " + TextBox1.Text + @" dbo.tb_FoodAndDrink.foodID, dbo.tb_FoodAndDrink.foodName, SUM(dbo.tb_SellDetail.foodAmount) AS SumTotal, dbo.tb_Unit.UnitName
FROM            dbo.tb_FoodAndDrink INNER JOIN
dbo.tb_SellDetail ON dbo.tb_FoodAndDrink.foodID = dbo.tb_SellDetail.foodID INNER JOIN
dbo.tb_Unit ON dbo.tb_FoodAndDrink.UnitID = dbo.tb_Unit.UnitID
WHERE        (dbo.tb_SellDetail.SellID IN
(SELECT        SellID
FROM            dbo.tb_Selling AS Sell
WHERE        (Year(dateCome) = '" + System.Convert.ToString(cbYear.SelectedItem) + @"')))
GROUP BY dbo.tb_FoodAndDrink.foodID, dbo.tb_FoodAndDrink.foodName, dbo.tb_Unit.UnitName
ORDER BY SumTotal DESC";
			
			DSReport dsr = new DSReport();
			BestSellYear rpt = new BestSellYear();
			var da = new SqlDataAdapter(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da.Fill(dsr, "DSBestSellByYear");
			if (dsr.Tables["DSBestSellByYear"].Rows.Count == 0)
			{
				MessageBox.Show("ບໍ່ມີຂໍ້ມູນ");
			}
			else
			{
				rpt.SetDataSource(dsr);
				rpt.SetParameterValue("top", TextBox1.Text);
				rpt.SetParameterValue("year", cbYear.SelectedItem);
				frm_MainReportChoosing.Default.CrystalReportViewer1.ReportSource = rpt;
				frm_MainReportChoosing.Default.Show(this);
			}
		}
		
		public void Label3_Click(object sender, EventArgs e)
		{
			
		}
		
		public void TextBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
