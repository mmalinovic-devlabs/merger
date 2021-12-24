/*
 * Created by Ranorex
 * User: User
 * Date: 10.05.2012
 * Time: 15:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace KeePassTestSuite
{
    /// <summary>
    /// Description of AddCredentialEntry.
    /// </summary>
    [TestModule("36B3BA50-0797-4CDE-81E9-873F5EE516BD", ModuleType.UserCode, 1)]
    public class AddCredentialEntry : ITestModule
    {
    	
    	string _varTitle = "WordPressDemo";
    	[TestVariable("8FCE8266-9831-4706-ACA6-BB8D8A06B5AE")]
    	public string varTitle
    	{
    		get { return _varTitle; }
    		set { _varTitle = value; }
    	}
    	
    	string _varUsername = "admin";
    	[TestVariable("E65F0C1D-2762-405A-96A0-4515BFA94FDD")]
    	public string varUsername
    	{
    		get { return _varUsername; }
    		set { _varUsername = value; }
    	}
    	
    	
    	string _varPassword = "demo123";
    	[TestVariable("AE0C46C8-7A5D-45CC-83AB-44B0B8BF61C5")]
    	public string varPassword
    	{
    		get { return _varPassword; }
    		set { _varPassword = value; }
    	}
    	
    	string _varURL = "bitly.com/wp_demo";
    	[TestVariable("43C83430-F236-42FF-841D-A4BD6EB9C627")]
    	public string varURL
    	{
    		get { return _varURL; }
    		set { _varURL = value; }
    	}
    	
    	
    	string _varRepoIconIndex = "1";
    	[TestVariable("D2BDF856-F604-4019-8F2A-8634CFFB3D18")]
    	public string varRepoIconIndex
    	{
    		get { return _varRepoIconIndex; }
    		set { 
    				_varRepoIconIndex = value; 
    				// Additionally set the Repository Variable in Setter-Method
    				MyRepo.varIconIndex = _varRepoIconIndex;
    			}
    	}
    	
    	
    	string _varRepoExpires = "1 Year";
    	[TestVariable("A4A86036-4706-4288-AFB4-B2E86A05D3C8")]
    	public string varRepoExpires
    	{
    		get { return _varRepoExpires; }
    		set { 
    				_varRepoExpires = value; 
    				// Additionally set the Repository Variable in Setter-Method
    				MyRepo.varExpires = _varRepoExpires;
    			}
    	}
    	
    	
    	// Repository object to access UI Elements
    	KeePassTestSuiteRepository MyRepo = KeePassTestSuiteRepository.Instance;
    	
        /// Constructs a new instance.
        public AddCredentialEntry()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            // Click 'Add Entry' Button MainMenu
	        MyRepo.MainForm.Edit.Click();
	        MyRepo.KeePass.AddEntry.Click();
	        
	        // Set text fields
	        MyRepo.AddEntry.Title.TextValue = varTitle;
	        MyRepo.AddEntry.UserName.TextValue = varUsername;
	        MyRepo.AddEntry.Password.TextValue = varPassword;
	        MyRepo.AddEntry.Repeat.TextValue = varPassword;
	        MyRepo.AddEntry.URL.TextValue = varURL;
	        
	        // Choose an icon
	        MyRepo.AddEntry.MBtnIcon.Click();
	        MyRepo.IconPicker.LI_Icon.Click(Location.CenterLeft);
	        MyRepo.IconPicker.ButtonClose.Click();
	        
	        // Set Expires
	        MyRepo.AddEntry.MBtnStandardExpires.Click();
	        MyRepo.KeePass.MI_Expires.Click();
	        
	        // Save Credential Entry
	        MyRepo.AddEntry.ButtonOK.Click();
        }
    }
}
