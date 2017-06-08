
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
	public partial class ChooseReportByDate
	{
		public ChooseReportByDate()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static ChooseReportByDate defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static ChooseReportByDate Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new ChooseReportByDate();
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
		public void btReportDate_Click(object sender, EventArgs e)
		{
			DSReport dsr = new DSReport();
			DateReport rpt = new DateReport();
			string Sql = " select * from v_ReportSellingByDay where cast(DateCome as Date) between  '" + dtp.Value.ToString("yyyy/MM/dd") + "' and '" + DateTimePicker1.Value.ToString("yyyy/MM/dd") + "'";
			var da = new SqlDataAdapter(Sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da.Fill(dsr, "DTDateReport");
			//   rpt.SetParameterValue("test", "hello")
			if (dsr.Tables["DTDateReport"].Rows.Count == 0)
			{
				MessageBox.Show("ບໍ່ມີຂໍ້ມູນນຳເຂົ້າວັນທີ: " + dtp.Value.ToString("yyyy/MM/dd"));
			}
			else
			{
				rpt.SetDataSource(dsr);
				frm_MainReportChoosing.Default.CrystalReportViewer1.ReportSource = rpt;
				frm_MainReportChoosing.Default.Show(this);
			}
		}
	}
}
