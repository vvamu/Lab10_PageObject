using lab9_WebDriver.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Models
{
    public abstract class BasePage : TestsClass , IBasePage
    {
        protected abstract string? Url { get; }



        [SetUp]
        public override void Setup()
        {
            base.Setup();
            workspace.OpenBrowserWithUrl(this.Url);
        }

        public bool CheckExpectedUrl(string url)
        {
            if(driver.Url == url) return true;
            else return false;
        }


        
    }
}
