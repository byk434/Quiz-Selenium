using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    public class SearchClass:CommonMethods
    {
        By productButton = By.XPath("//*[@class='material-icons card_travel']");
        By searchInput = By.XPath("//input[@id='search_product']");
        By searchIcon = By.XPath("//button[@id='submit_search']");

        public void productButtton()
        {
            Click(productButton);
        }
        public void searchingInput()
        {
            Write(searchInput, "shirt");
        }
        public void clickingSearchIcon()
        {
            Click(searchIcon);
        }

    }
}
