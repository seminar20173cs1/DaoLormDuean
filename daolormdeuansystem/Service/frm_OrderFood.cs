
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
	public partial class frm_OrderFood
	{
		public frm_OrderFood()
		{
			InitializeComponent();
		}
		public void frm_OrderFood_Load(object sender, EventArgs e)
		{
			LoadFood();
			pnOrderList.AllowDrop = true;
		}
		PictureBox pictureFood;
		Label lbfood;
		//   Dim lbprice As Label
		TableLayoutPanel pn;
		public void LoadFood()
		{
			//    Dim cm As New SqlCommand("select  count(boatID) from tb_boat", connect.DatabaseConnection(constr))
			//    Dim dr As SqlDataReader
			SqlDataAdapter da = default(SqlDataAdapter);
			//'    dr = cm.ExecuteReader()
			//'    dr.Read()
			//'    Dim boatAmount As String = dr(0).ToString
			//'    '  Button1.Text = boatAmount
			//'    Dim boatno As Integer = 0
			string sqlfoodDetail = "Select  foodID, foodName,foodPrice,foodPhotoPath from tb_foodAndDrink";
			
			DataTable dt = new DataTable();
			da = new SqlDataAdapter(sqlfoodDetail, ConstVar.connect.DatabaseConnection(ConstVar.constr));
			da.Fill(dt);
			foreach (DataRow row in dt.Rows)
			{
				
				pn = new TableLayoutPanel();
				pn.Width = 220;
				pn.Height = 200;
				pn.BorderStyle = BorderStyle.Fixed3D;
				pictureFood = new PictureBox();
				lbfood = new Label();
				Label lbprice = new Label();
				pictureFood.Image = Image.FromFile(System.Convert.ToString(row["foodPhotopath"]));
				pictureFood.SizeMode = PictureBoxSizeMode.StretchImage;
				pictureFood.Width = 200;
				pictureFood.Height = 150;
				pictureFood.Tag = row["foodID"];
				pictureFood.AllowDrop = true;
				//    pictureFood.allowDrag = True
				
				lbfood.Text = System.Convert.ToString(row["foodName"]);
				lbfood.TextAlign = ContentAlignment.MiddleCenter;
				lbprice.Text = System.Convert.ToString(row["foodPrice"]);
				//    ''  gb.Controls.Add(pictureFood)
				//    '' gb.Controls.Add(lbfood)
				
				pn.Controls.Add(pictureFood);
				pn.Controls.Add(lbfood);
				pn.Controls.Add(lbprice);
				//     foodMenu.Controls.Add(pictureFood)
				//    Dim bt As New Button
				//    bt.Text = row("foodID")
				//  foodMenu.Controls.Add(lbfood)
				foodMenu.Controls.Add(pn);
				//   foodMenu.Controls.Add(lbprice)
				pn.MouseDown += this.PictMenuMouseDown;
			}
			
			
			
		}
		
		public void ButtonX1_Click(object sender, EventArgs e)
		{
			LoadFood();
		}
		
		public void FlowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
		{
			//Dim pictSelectedFood As New PictureBox
			//pictSelectedFood.Image = Image.FromFile()
			//pnOrderList.Controls.Add(pictSelectedFood)
			
			
			//Dim pic As PictureBox
			//Dim lb As Label
			//'  lb = e.Data.GetData(GetType(Label))
			
			//pic = e.Data.GetData(GetType(PictureBox))
			//pnOrderList.Controls.Add(pic)
			//pnOrderList.Controls.Add(lb)
			
			
			
			//If e.Data.GetData(GetType(TableLayoutPanel)) Then
			//    e.Effect = DragDropEffects.Copy
			
			//End If
			
			
			//If e.Data.GetDataPresent(DataFormats.Bitmap) Then
			//    e.Effect = DragDropEffects.Copy
			//Else
			//    e.Effect = DragDropEffects.None
			//End If
			
		//	TableLayoutPanel ty = default(TableLayoutPanel);
		//	ty = e.Data.GetData(typeof(TableLayoutPanel));
		//	pnOrderList.Controls.Add(ty);
		}
		
		
		
		private void PictMenuMouseDown(object sender, MouseEventArgs e)
		{
			//  Dim pbt As PictureBox
			
			TableLayoutPanel typ = default(TableLayoutPanel);
			
			
			typ = (TableLayoutPanel) sender;
			//   Dim lb As Label
			//pbt = CType(sender, PictureBox)
			//  lb = CType(sender, Label)
			// lb.Text = pbt.Tag.ToString()
			//    Dim idid As String = lb.Text
			typ.DoDragDrop(typ, DragDropEffects.All);
			//  pbt.DoDragDrop(pbt, DragDropEffects.Copy)
			//     lb.DoDragDrop(pbt.Tag, DragDropEffects.Copy)
			//   End If
			
		}
		
		public void pnOrderList_DragDrop(object sender, DragEventArgs e)
		{
			//TableLayoutPanel ty = default(TableLayoutPanel);
			//ty = e.Data.GetData(typeof(TableLayoutPanel));
		//	pnOrderList.Controls.Add(ty);
		}
	}
}
