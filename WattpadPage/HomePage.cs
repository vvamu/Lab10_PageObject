using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9_WebDriver.WattpadPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;


namespace lab9_WebDriver.Page
{
    public class HomePage : BasePage
    {
        protected override string? Url => "https://www.wattpad.com/home";
        private string bookName;

        public HomePage() : base() { }

        public BasePage ClickOnTheBook(string Bookname)
        {
            bookName = Bookname;
            findElement($"driver.find_elements_by_xpath('//*[contains(text(), '{bookName}')]')");
            return this;
        }
        public BasePage ClickOnTheTitleBook()
        {
            findElement("//a[@class='title']").Click();
            return this;
        }

        public BasePage StartReadingBook()
        {
            findElement(By.ClassName("read btn-primary")).Click();
            return this;
        }
        public BasePage AddBookToReaadingList(string readingListName = "My Library (Private)")
        {
            findElement("//button[@class='btn-primary add-to-library-btn']").Click();
            var parentElement = findElement($"//span[text()='{readingListName}']/parent::button[@class='react-popover-item__btn']");
            parentElement.Click();

            return this;
 
        }


        public bool CheckAddBookToReaadingList(string readingListName = "My Library (Private)")
        {
            var parentElement = findElement($"//span[text()='{readingListName}']/parent::button[@class='react-popover-item__btn']");
            if (parentElement.FindElements(By.TagName("svg")).FirstOrDefault() == null)
                return false;
            return true;

        }


        #region NotUsed

        private void OpenContentPreferences()
        {

        }

        private void IncludeMatureOn()
        {

        }

        private void IncludeMatureOff()
        {

        }

        #endregion



        public BasePage LogIn(string login, string password)
        {
            Thread.Sleep(1000);
            findElement("//button[@class='btn btn-sm']").Click();

            Thread.Sleep(1000);
            findElement("//button[@class='btn-block btn-primary']").Click();

            Thread.Sleep(5000);
            var logIn = findElement(By.Id("login-username"));
            logIn.SendKeys(login);
            var pswd = findElement(By.Id("login-password"));
            pswd.SendKeys(password);

            findElement("//input[@value='Вход']").Click();
            Thread.Sleep(5000);


            return this;
            
        }

    }
}
