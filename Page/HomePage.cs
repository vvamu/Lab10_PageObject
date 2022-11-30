using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab9_WebDriver.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;


namespace lab9_WebDriver.Page
{

    //6. Добавить книгу в список для чтения
    public class HomePage : BasePage
    {
        protected override string? Url => "https://www.wattpad.com/home";
        private string bookName;

        private void ClickOnTheBook(string Bookname)
        {
            bookName = Bookname;
        }
        private void OpenContentPreferences()
        {

        }

        private void IncludeMatureOn()
        {

        }

        private void IncludeMatureOff()
        {

        }

        private void StartReadingBook()
        {

        }

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
