/*
 * Created by SharpDevelop.
 * User: Paul
 * Date: 3/1/2007
 * Time: 6:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text;

namespace ManyClip
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm
	{
		private static String CurrentText, PreviousText;
		private static bool CaptureEnabled;
		
			
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			// pfs for RunAtStartup checkbox
			if (rkApp.GetValue("ManyClipPFS") == null)
	        {
	            // The value doesn't exist, the application is not set to run at startup
	            checkBoxRunAtStartup.Checked = false;
	        }
	        else
	        {
	            // The value exists, the application is set to run at startup
	            checkBoxRunAtStartup.Checked = true;
	        }
        
        
        
			//InitializeBackgoundWorker();
			CaptureEnabled = true;
			BackgroundWorker1.RunWorkerAsync();
		}
				
				
		void ButtonStartClick(object sender, System.EventArgs e)
		{
			// routine assumes backgroundWorker was started in
			// MainForm constructor
			
			//toggle Capture
			if (CaptureEnabled.Equals(true))  
			{   // if capturing was enabled
				BackgroundWorker1.CancelAsync();
				// this will result in event handler BackgroundWorker1_RunWorkerCompleted
				// and the button color and text will be changes.
			}
			else 
			{  // if capturing was disabled
				
				BackgroundWorker1.RunWorkerAsync();
				CaptureEnabled = true;
				this.buttonStart.BackColor = System.Drawing.Color.LightGreen;
				this.buttonStart.Text = "Stop Capturing Clipboard Changes.";
				
			}
		}
		
		void ButtonRemoveClick(object sender, System.EventArgs e)
		{
			int x;
			if(itemList.SelectedIndex == -1)
		    {
		        MessageBox.Show("No item is selected.", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		    }
		    else
		    {
		    	 x = itemList.SelectedIndex;
	             itemList.Items.RemoveAt(itemList.SelectedIndex);
	             itemList.SelectedIndex =  System.Math.Min(itemList.Items.Count -1, x);
		    } 
		}
		
		void ButtonCopyClick(object sender, System.EventArgs e)
		{
			if(itemList.SelectedIndex == -1)
		    {
		        MessageBox.Show("No item is selected.", "No item selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		    }
		    else
		    {
				//Clipboard.SetText(itemList.SelectedItem.ToString()  );
				Clipboard.SetText(itemList.Text);
		    	//MessageBox.Show("Done..", "Copy Item to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void ButtonRemoveAllClick(object sender, System.EventArgs e)
		{
			itemList.Items.Clear(); 
		}
		
		void ButtonClearClipboardClick(object sender, System.EventArgs e)
		{
			Clipboard.Clear();
			MessageBox.Show("Done..", "Clear Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
