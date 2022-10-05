using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    internal class VerifyAllProducts:CommonMethods
    {
        By productButton = By.XPath("//*[@class='material-icons card_travel']");
        By viewProduct1 = By.XPath("//a[@href='/product_details/1']");
        By product4 = By.XPath("//a[@data-product-id='4']");


        public void productDetails()
        {
            Click(productButton);
            ScrollToElement(product4);
            Click(viewProduct1);
        }
        public void reFresh()
        {
            ReFreshPage();
        }
    }
}
