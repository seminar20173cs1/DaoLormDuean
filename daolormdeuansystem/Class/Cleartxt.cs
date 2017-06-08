
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



namespace daolormdeuansystem
{
	public class Cleartxt
	{
		public void ClearTextBox(Form frmName)
		{
			Control a = default(Control);
			foreach (Control tempLoopVar_a in frmName.Controls)
			{
				a = tempLoopVar_a;
				if (a is TextBox)
				{
					a.Text = "";
				}
			}
		}
	}
	
}
