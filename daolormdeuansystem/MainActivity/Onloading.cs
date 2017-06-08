
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
	public sealed partial class Onloading
	{
		public Onloading()
		{
			InitializeComponent();
		}
		
		//TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
		//  of the Project Designer ("Properties" under the "Project" menu).
		
		
		public void SplashScreen1_Load(object sender, System.EventArgs e)
		{
			//Set up the dialog text at runtime according to the application's assembly information.
			
			//TODO: Customize the application's assembly information in the "Application" pane of the project
			//  properties dialog (under the "Project" menu).
			
			//Application title
			//If My.Application.Info.Title <> "" Then
			//    ApplicationTitle.Text = My.Application.Info.Title
			//Else
			//    'If the application title is missing, use the application name, without the extension
			//    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
			//End If
			
			//Format the version information using the text set into the Version control at design time as the
			//  formatting string.  This allows for effective localization if desired.
			//  Build and revision information could be included by using the following code and changing the
			//  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
			//  String.Format() in Help for more information.
			//
			//    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
			
		//	Version.Text = System.String.Format(Version.Text, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Major, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Minor);
			
			//Copyright info
		//	Copyright.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Copyright;
		}
		
		public void DetailsLayoutPanel_Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		public void MainLayoutPanel_Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		public void ApplicationTitle_Click(object sender, EventArgs e)
		{
			
		}
	}
	
}
