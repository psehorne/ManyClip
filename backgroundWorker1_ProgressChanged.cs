/*
 * Created by SharpDevelop.
 * User: Paul
 * Date: 3/1/2007
 * Time: 8:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 using System.ComponentModel;
 using System.Windows.Forms;

namespace ManyClip
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm
	{
		private void BackgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
		{
			CurrentText = Clipboard.GetText();
			
			// only if clipboard was not empty
			if (CurrentText.Length > 0) 
			{
				if (CurrentText.CompareTo(PreviousText) != 0)
				{
					PreviousText = CurrentText;
					itemList.Items.Insert(0,CurrentText.ToString());
					// select current item
					itemList.SelectedIndex = 0;
				}
			}
		}
	}
}
