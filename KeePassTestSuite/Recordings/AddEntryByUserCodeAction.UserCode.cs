///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace KeePassTestSuite.Recordings
{
	public partial class AddEntryByUserCodeAction
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void AddEntryWithParams(string aTitle, string aUsername, string aPassword, string aURL)
		{
			KeePassTestSuiteRepository MyRepo = KeePassTestSuiteRepository.Instance;
			
			// Set text fields
			MyRepo.AddEntry.Title.TextValue = aTitle;
			MyRepo.AddEntry.UserName.TextValue = aUsername;
			MyRepo.AddEntry.Password.TextValue = aPassword;
			MyRepo.AddEntry.Repeat.TextValue = aPassword;
			MyRepo.AddEntry.URL.TextValue = aURL;
		}
		
		public void AddEntryWithParams(string aTitle, string aUsername, string aPassword, string aURL,string aIconIndex, string aExpires)
		{
			KeePassTestSuiteRepository MyRepo = KeePassTestSuiteRepository.Instance;
			
			// Set text fields
			MyRepo.AddEntry.Title.TextValue = aTitle;
			MyRepo.AddEntry.UserName.TextValue = aUsername;
			MyRepo.AddEntry.Password.TextValue = aPassword;
			MyRepo.AddEntry.Repeat.TextValue = aPassword;
			MyRepo.AddEntry.URL.TextValue = aURL;
			
			// Set Repository Variables
			MyRepo.varExpires = aExpires;
			MyRepo.varIconIndex = aIconIndex;
			
			// Set Icon
			MyRepo.AddEntry.MBtnIcon.Click();
			MyRepo.IconPicker.LI_Icon.Select();
			MyRepo.IconPicker.ButtonClose.Click();
			
			// Set Expires
			MyRepo.AddEntry.MBtnStandardExpires.Click();
			MyRepo.KeePass.MI_Expires.Click();
			
		}

	}
}