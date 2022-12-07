
using lab9_WebDriver.Data;
using lab9_WebDriver.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace lab9_WebDriver;


public class MyTest : TestsClass
{
    
    //protected override string? Url => "https://www.wattpad.com/home";

    private string bookName = "Остров Остов";

    [Test]
    public void SearchBook()
    {

        
        string text = "";
        try
        {
             

            var elements = driver.FindElements(By.ClassName("title"));
                foreach (var eleme in elements)
                    if (eleme.Text == bookName)
                    {
                        text = eleme.Text;
                        Assert.True(text != "");

                    return;
                    }

        }
        catch
        {
            Assert.Fail(); 
        }

        var searchPage = new SearchPage(bookName);
          


    }

    [Test]
    public void Test() //6. Добавить книгу в список для чтения
    {
        
        var home = new HomePage();

        home.LogIn(ApplicationUser.Login, ApplicationUser.Password);

        home.ClickOnTheTitleBook();
        home.AddBookToReaadingList();
        

        Assert.IsTrue(home.CheckAddBookToReaadingList());

    }

}