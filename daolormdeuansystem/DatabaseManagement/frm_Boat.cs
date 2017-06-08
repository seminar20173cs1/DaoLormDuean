
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


using System.IO;

namespace daolormdeuansystem
{
	public partial class frm_Boat
	{
		public frm_Boat()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frm_Boat defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frm_Boat Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frm_Boat();
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
		SQLControl SQL = new SQLControl();
		AutoID autoID = new AutoID();
		string constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=db_Restuarant;Integrated Security=True";
		classDatabaseConnection connect = new classDatabaseConnection();
		string sqlInsert;
		string sqlshow = "SELECT * FROM v_boat";
		
		classShowData selectData = new classShowData();
		public void btSave_Click(object sender, EventArgs e)
		{
			
			var sqlScript = "select boatID from tb_boat where boatID = '" + txtBoatID.Text + "'";
			//SQL.SQLCm = New SqlCommand(sqlScript, db.DatabaseConnection(constr))
			//db.SQLDr = db.SQLCm.ExecuteReader()
			// Timer1.Enabled = True
			SQL.SQLCmd = new System.Data.SqlClient.SqlCommand(sqlScript, SQL.SQLCon);
			SQL.SQLCon.Open();
			SQL.SQLDr = SQL.SQLCmd.ExecuteReader();
			if (SQL.SQLDr.HasRows)
			{
				MessageBox.Show("ລະຫັດນີ້ມີຢູ່ໃນຖານຂໍ້ມູນແລ້ວ", "ຄໍາເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
				// MsgBox("ລະຫັດ" 5)
				
			}
			else
			{
				sqlInsert = "INSERT INTO tb_boat(boatID, boatTypeID, Boatname, boatStatus, boatPicture) values('" + txtBoatID.Text + "','" + System.Convert.ToString(cbBoatType.SelectedValue) + "',N'" + txtBoatName.Text + "',N'" + ComboBox1.SelectedItem.ToString() + "', '" + txtpicture.Text + "')";
				ClassInsert save = new ClassInsert();
				save.Insert(sqlInsert, connect.DatabaseConnection(constr), "ຂໍ້ມູນເຮືອລະຫັດ " + txtBoatID.Text + " ໄດ້ຖືກບັນທຶກລົງໃນຖານຂໍ້ມູນແລ້ວ");
				txtBoatID.Text = autoID.SetID(constr, "BoatID", "tb_Boat", "B0", 1, 2);
				selectData.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvboat);
				Clear();
			}
			SQL.SQLCon.Close();
			
			
			
			
			
		}
		
		public void frm_Boat_Load(object sender, EventArgs e)
		{
			Panel2.BackColor = Color.FromArgb(50, Color.Black);
			ComboBox1.Text = "----------ເລືອກສະຖານະ----------";
			selectData.ShowDataInCombobox("Select boatTypeID, BoatTypeName from tb_BoatType", connect.DatabaseConnection(constr), cbBoatType, "BoatTypeID", "BoatTypeName");
			selectData.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvboat);
			txtBoatID.Text = autoID.SetID(constr, "BoatID", "tb_Boat", "B0", 1, 2);
		}
		string sqlupdate;
		public void btEdit_Click(object sender, EventArgs e)
		{
			sqlupdate = "UPDATE tb_boat SET boatTypeID = '" + System.Convert.ToString(cbBoatType.SelectedValue) + "', boatName = N'" + txtBoatName.Text + "', boatStatus = N'" + ComboBox1.SelectedItem.ToString() + "', boatPicture ='" + txtpicture.Text + "' Where boatID = '" + txtBoatID.Text + "'";
			classUpdate EditData = new classUpdate();
			EditData.Update(sqlupdate, connect.DatabaseConnection(constr), "ຂໍ້ມູນເຮືອໄດ້ຖືກແກ້ໄຂແລ້ວ");
			selectData.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvboat);
			Clear();
		}
		
		public void btClose_Click(object sender, EventArgs e)
		{
			Dispose();
			
		}
		
		public void btDelete_Click(object sender, EventArgs e)
		{
			string sqldeletescript = "Delete from tb_boat where boatID = '" + txtBoatID.Text + "'";
			classDelete del = new classDelete();
		   DialogResult i = MessageBox.Show("ທ່ານຕ້ອງການທີ່ຈະລົບ " + txtBoatID.Text + " ແທ້ບໍ່?", "ກະລຸນາຢືນຢັນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (i == DialogResult.Yes)
			{
				del.Delete(sqldeletescript, connect.DatabaseConnection(constr));
				selectData.ShowData(sqlshow, connect.DatabaseConnection(constr), dgvboat);
			}
			txtBoatID.Text = autoID.SetID(constr, "BoatID", "tb_Boat", "B0", 1, 2);
			Clear();
		}
		
		public void dgvBoat_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		public void dgvBoat_Click(object sender, EventArgs e)
		{
			txtBoatID.Text = dgvboat.Rows[dgvboat.CurrentRow.Index].Cells[0].Value.ToString();
			txtBoatName.Text = dgvboat.Rows[dgvboat.CurrentRow.Index].Cells[1].Value.ToString();
			cbBoatType.Text = dgvboat.Rows[dgvboat.CurrentRow.Index].Cells[2].Value.ToString();
			ComboBox1.Text = dgvboat.Rows[dgvboat.CurrentRow.Index].Cells[3].Value.ToString();
			txtpicture.Text = System.Convert.ToString(dgvboat.Rows[dgvboat.CurrentRow.Index].Cells[4].Value);
			PictureBox1.ImageLocation = txtpicture.Text;
			
		}
		public void Clear()
		{
			//   txtBoatID.Text = ""
			txtBoatName.Text = "";
			ComboBox1.Text = "";
			txtpicture.Text = "";
			PictureBox1.Image = null;
		}
		
		public void btClear_Click(object sender, EventArgs e)
		{
			Clear();
			txtBoatID.Text = autoID.SetID(constr, "BoatID", "tb_Boat", "B0", 1, 2);
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			//Dim opf As New OpenFileDialog
			//opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
			//If opf.ShowDialog = DialogResult.OK Then
			//    PictureBox1.Image = Image.FromFile(opf.FileName)
			//End If
			//Dim ms As New MemoryStream
			//PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
			
			try
			{
				OpenFileDialog1.ShowDialog();
				
				txtpicture.Text = OpenFileDialog1.FileName;
				PictureBox1.Image = Image.FromFile(txtpicture.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Error");
			}
		}
		
		public void PictureBox1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog1.ShowDialog();
				txtpicture.Text = OpenFileDialog1.FileName;
				PictureBox1.Image = Image.FromFile(txtpicture.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Error");
			}
		}
	}
}
