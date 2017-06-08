
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

using Microsoft.VisualBasic;
using System.Data.SqlClient;
//using System.DateTime;

namespace daolormdeuansystem
{
	public partial class frm_TimeCalculation
	{
		public frm_TimeCalculation()
		{
			InitializeComponent();
		}
		int MoneybyHour;
		int MoneybyMinute;
		
		string hour;
		string minute;
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			SqlDataReader dr = default(SqlDataReader);
			string sqlprice = "select price from tb_boatType where boatTypeID = (select boattypeID from tb_boat where boatid = '" + lbBoatID.Text + "')";
			SqlCommand cm = new SqlCommand(sqlprice, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			dr = cm.ExecuteReader();
			dr.Read();
			int price = int.Parse(dr[0].ToString());
			//Dim newtime As String
			//newtime = DateTime.Today
			
			//'Dim startTime As TimeSpan
			//'startTime = TimeSpan.Parse(txtStartTime.Text)
			//'Dim stopTime As TimeSpan
			
			//'stopTime = TimeSpan.Parse(txtEndTime.Text)
			
			
			//'lbResultTime.Text = startTime.ToString & " " & stopTime.ToString
			//MsgBox(newtime.ToString("hh:mm"))
			//'    MsgBox((stopTime - startTime).ToString)
			
			
			
			//Dim sql = "Select time1 from tb_TestTimestamp where boat='" & txtStartTime.Text & "'"
			//'  Dim dr As SqlDataReader"
			//' Dim cm As SqlCommand
			
			
			//Dim cm As New SqlCommand(sql, connect.DatabaseConnection(constr))
			//Dim dr As SqlDataReader
			//dr = cm.ExecuteReader()
			//dr.Read()
			//Dim gettime As String = dr(0).ToString
			//Dim startTime As String = gettime.Substring(11, 5).ToString
			//'    MsgBox(startTime)
			//Dim StartTimeSpan As TimeSpan
			//StartTimeSpan = TimeSpan.Parse(startTime)
			
			
			//Dim finaltime As TimeSpan = TimeSpan.Parse(txtEndTime.Text) - TimeSpan.Parse(startTime)
			//MsgBox(finaltime.ToString)
			
			
			TimeSpan startTime = TimeSpan.Parse(txtStartTime.Text);
			TimeSpan stopTime = TimeSpan.Parse(txtEndTime.Text);
			TimeSpan finaltime = stopTime - startTime;
           // MessageBox.Show(finaltime.ToString());
			string finaltimeString = finaltime.ToString();
			hour = System.Convert.ToString(int.Parse(finaltimeString.Substring(0, 2)));
			minute = System.Convert.ToString(int.Parse(finaltimeString.Substring(3, 2)));
          //  MessageBox.Show(hour + " " + minute);
			
			////lbhour.Text = hour
			////lbminute.Text = minute
			lbhour.Text = hour;
			lbminute.Text = minute;
         //   MessageBox.Show(price.ToString());
                                    MoneybyHour = int.Parse(hour) * price;
           // MessageBox.Show(MoneybyHour.ToString());
                                    MoneybyMinute = System.Convert.ToInt32(((double) int.Parse(minute) / 60) * price);
           // MessageBox.Show(MoneybyMinute.ToString());
                                    ////  MsgBox(MoneybyHour & " " & MoneybyMinute)
                                    lbmoneybyHOur.Text = System.Convert.ToString(MoneybyHour);
                                    lbmoneybyMinute.Text = System.Convert.ToString(MoneybyMinute);
                                    int totalmoney = MoneybyHour + MoneybyMinute;
                                    txtAllMoney.Text = System.Convert.ToString(totalmoney);


        }
		
		public void btClose_Click(object sender, EventArgs e)
		{
			Dispose();
		}
		
		public void frm_TimeCalculation_Load(object sender, EventArgs e)
		{
            DateTime dt = new DateTime();

            txtStartTime.Text = Strings.Format(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[8].Value, "HH:mm");
            txtEndTime.Text = Strings.Format(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[9].Value, "HH:mm");
            lbSellID.Text = System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[0].Value);
            lbBoatID.Text = System.Convert.ToString(frm_MainService.Default.dgvOrder.Rows[frm_MainService.Default.dgvOrder.CurrentRow.Index].Cells[2].Value);
        }
		int tempMoney;
		int allMoneyToPaid;
		public void ButtonX2_Click(object sender, EventArgs e)
		{
			
			//
			
			tempMoney = MoneybyHour + MoneybyMinute;
			allMoneyToPaid = tempMoney + int.Parse(System.Convert.ToString(frm_MainService.Default.txtTotal.Tag));
			
			string realTime = (hour + ":" + minute).ToString();
			
			//  MsgBox(realTime)
			string sql = "Update tb_Selling SET BoatSailPrice='" + System.Convert.ToString(MoneybyHour) + "',BoatSailHourReal='" + realTime + "', Increase = " + System.Convert.ToString(int.Parse(System.Convert.ToString(MoneybyMinute))) + ", totalPrice=" + System.Convert.ToString(allMoneyToPaid) + " WHERE SellID = '" + lbSellID.Text + "'";
			ConstVar.upd.Update(sql, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			ConstVar.sh.ShowData("select * from v_Selling", ConstVar.connect.DatabaseConnection(ConstVar.constr), frm_MainService.Default.dgvOrder);
			frm_MainService.Default.RadioButton2.Checked = true;
			Dispose();
		}
		
		private void Button1_Click(object sender, EventArgs e)
		{
			
			
		}
	}
}
