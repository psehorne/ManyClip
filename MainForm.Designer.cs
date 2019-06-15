/*
 * Created by SharpDevelop.
 * User: Paul
 * Date: 3/1/2007
 * Time: 6:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System.ComponentModel;
 using System.Text;
 using System.Threading;
 
 // the following added for checkBoxRunAtStartup
 using System.Windows.Forms;  // for type Application
 using Microsoft.Win32; // for RegistryKey
 
namespace ManyClip
{
	partial class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.itemList = new System.Windows.Forms.ListBox();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.buttonRemoveItem = new System.Windows.Forms.Button();
			this.buttonRemoveAll = new System.Windows.Forms.Button();
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.buttonStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonClearClipboard = new System.Windows.Forms.Button();
			this.checkBoxRunAtStartup = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// itemList
			// 
			this.itemList.FormattingEnabled = true;
			this.itemList.ItemHeight = 15;
			this.itemList.Location = new System.Drawing.Point(32, 82);
			this.itemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.itemList.Name = "itemList";
			this.itemList.Size = new System.Drawing.Size(606, 154);
			this.itemList.TabIndex = 5;
			// 
			// buttonCopy
			// 
			this.buttonCopy.Location = new System.Drawing.Point(32, 245);
			this.buttonCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(194, 27);
			this.buttonCopy.TabIndex = 2;
			this.buttonCopy.Text = "Copy Marked  Item to Clipboard";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new System.EventHandler(this.ButtonCopyClick);
			// 
			// buttonRemoveItem
			// 
			this.buttonRemoveItem.Location = new System.Drawing.Point(244, 245);
			this.buttonRemoveItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonRemoveItem.Name = "buttonRemoveItem";
			this.buttonRemoveItem.Size = new System.Drawing.Size(136, 27);
			this.buttonRemoveItem.TabIndex = 3;
			this.buttonRemoveItem.Text = "Remove Marked Item";
			this.buttonRemoveItem.UseVisualStyleBackColor = true;
			this.buttonRemoveItem.Click += new System.EventHandler(this.ButtonRemoveClick);
			// 
			// buttonRemoveAll
			// 
			this.buttonRemoveAll.Location = new System.Drawing.Point(404, 245);
			this.buttonRemoveAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonRemoveAll.Name = "buttonRemoveAll";
			this.buttonRemoveAll.Size = new System.Drawing.Size(88, 27);
			this.buttonRemoveAll.TabIndex = 4;
			this.buttonRemoveAll.Text = "Remove All";
			this.buttonRemoveAll.UseVisualStyleBackColor = true;
			this.buttonRemoveAll.Click += new System.EventHandler(this.ButtonRemoveAllClick);
			// 
			// BackgroundWorker1
			// 
			this.BackgroundWorker1.WorkerReportsProgress = true;
			this.BackgroundWorker1.WorkerSupportsCancellation = true;
			this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
			this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
			this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
			// 
			// buttonStart
			// 
			this.buttonStart.BackColor = System.Drawing.Color.LightGreen;
			this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonStart.Location = new System.Drawing.Point(320, 15);
			this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(189, 27);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "Stop Capturing Clipboard Changes";
			this.buttonStart.UseVisualStyleBackColor = false;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "ManyClip v1.2.0.0196\r\nCopyright @2007-2008 Paul F. Sehorne\r\nPaul@Sehorne.org";
			// 
			// buttonClearClipboard
			// 
			this.buttonClearClipboard.Location = new System.Drawing.Point(528, 245);
			this.buttonClearClipboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonClearClipboard.Name = "buttonClearClipboard";
			this.buttonClearClipboard.Size = new System.Drawing.Size(110, 27);
			this.buttonClearClipboard.TabIndex = 6;
			this.buttonClearClipboard.Text = "Clear Clipboard";
			this.buttonClearClipboard.UseVisualStyleBackColor = true;
			this.buttonClearClipboard.Click += new System.EventHandler(this.ButtonClearClipboardClick);
			// 
			// checkBoxRunAtStartup
			// 
			this.checkBoxRunAtStartup.Location = new System.Drawing.Point(549, 18);
			this.checkBoxRunAtStartup.Name = "checkBoxRunAtStartup";
			this.checkBoxRunAtStartup.Size = new System.Drawing.Size(101, 24);
			this.checkBoxRunAtStartup.TabIndex = 7;
			this.checkBoxRunAtStartup.Text = "Run at Startup";
			this.checkBoxRunAtStartup.UseVisualStyleBackColor = true;
			this.checkBoxRunAtStartup.CheckedChanged += new System.EventHandler(this.CheckBoxRunAtStartupCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 298);
			this.Controls.Add(this.checkBoxRunAtStartup);
			this.Controls.Add(this.buttonClearClipboard);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.buttonRemoveAll);
			this.Controls.Add(this.buttonRemoveItem);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.itemList);
			this.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximumSize = new System.Drawing.Size(685, 344);
			this.MinimumSize = new System.Drawing.Size(350, 140);
			this.Name = "MainForm";
			this.Text = "ManyClip";
			this.ResumeLayout(false);
		}
		
			
		        
		private System.Windows.Forms.Button buttonClearClipboard;
		private System.Windows.Forms.CheckBox checkBoxRunAtStartup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonStart;
		private System.ComponentModel.BackgroundWorker BackgroundWorker1;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.Button buttonRemoveItem;
		private System.Windows.Forms.Button buttonRemoveAll;
		private System.Windows.Forms.ListBox itemList;
		
		// pfs added for checkBoxRunAtStartup
		protected RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				
		private void BackgroundWorker1DoWork(object sender, 
		            System.ComponentModel.DoWorkEventArgs e)
		{  			   
			// Get the BackgroundWorker that raised this event.
		    BackgroundWorker worker = sender as BackgroundWorker;
		    while (!BackgroundWorker1.CancellationPending)
		    {
				Thread.Sleep(3000);
				worker.ReportProgress(0);
		    }
		}			
		
		void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			CaptureEnabled = false;
			this.buttonStart.BackColor = System.Drawing.Color.Red;
			PreviousText = null;  // forget all history
			this.buttonStart.Text = "Start Capturing Clipboard Changes.";
		}
		
		void CheckBoxRunAtStartupCheckedChanged(object sender, System.EventArgs e)
		{
			if ( checkBoxRunAtStartup.Checked )
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("ManyClipPFS", Application.ExecutablePath.ToString());
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("ManyClipPFS", false);
            }
		}
	}
}
